using Esri.ArcGISRuntime.Geometry;
using MilitaryPlanner.Helpers;
using MyMissionPlaner.Helpers.MyHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyMissionPlaner.Models
{
  internal class NC1_Message_xml : NC1_Message
    {

        // 
        public NC1_Message_xml(string id) : base(id) { }


        // données d'attributs du message
        public Dictionary<string, string> MetaData { get; internal set; }

        // données uniques du message, hors objets
        public Dictionary<string, string> Header { get; internal set; }

        // données non uniques du message, hors objets
        public XElement[] Body { get; internal set; }

        // données non uniques du message, hors objets
        public XElement[] Objects { get; internal set; }
        static readonly XName[] NC1ObjectsNames = new XName[] { XName.Get("objects"), XName.Get("objectsGlobal"), XName.Get("track") };

        static List<string> dbgPurposeOnly = new List<string>();
        // populates Base object (Message) with NC1 data
        internal void init_old()
        {
            XName idName = XName.Get("id");
            XName locationName = XName.Get("location");
            XName tacticalDataName = XName.Get("tacticalData");
            XName codeSymbolName = XName.Get("symbolCode");
            XName nameName = XName.Get("name");
            XName xName = XName.Get("x");
            XName yName = XName.Get("y");
            XName zName = XName.Get("z");

            XName circleName = XName.Get("circle");
            XName pointName = XName.Get("point");
            XName polylineName = XName.Get("polyline");
            XName contentName = XName.Get("content");
            XName objectsName = XName.Get("objects");

            CultureInfo cif = new CultureInfo("en-US");

            foreach (XElement inBody in Body)
            {
                //                < title >
                //                < hierarchyLevel >
                //                < content >
                //                     < mixedText >
                //                     < objects >
                //                           < object>
                foreach (XElement sub in inBody.Elements(contentName))
                    foreach (XElement objects in sub.Elements(objectsName))
                        foreach (XElement obj in objects.Elements())
                        {
                            //System.Diagnostics.Trace.WriteLine("##NC1_init du message ^pour l'objet " + obj.Name.LocalName);
                            string id = obj.Attribute(idName).Value;
                            System.Diagnostics.Trace.WriteLine("##NC1_init du message pour l'objet " + id);

                            if (id == "13:9999:119")
                                id.IsNormalized();

                            SimpleMessage smes = new SimpleMessage(id);

                            foreach (XAttribute attr in obj.Attributes()) // dont type qui est le type d'objet et l'id NC1
                            {
                                if (attr.Name != idName)
                                    smes.Add(attr.Name.LocalName, attr.Value);
                            }

                            // on transfere les données vers le SimpleMessage
                            foreach (XElement subElement in obj.Elements())
                            {
                                if (!smes.ContainsKey(subElement.Name.LocalName))
                                    smes.Add(subElement.Name.LocalName, subElement.ToString());
                                else
                                {
                                    string oldValue = smes[subElement.Name.LocalName];
                                    System.Diagnostics.Trace.WriteLine("NC1_init correction pour le champ multiple " + subElement.Name.LocalName);
                                    smes[subElement.Name.LocalName] = oldValue + "\n" + subElement.ToString();
                                    // smes["type"] // donne le type d'obj
                                    string alerte = smes["type"] + " ; " + subElement.Name.LocalName;

                                    if (!dbgPurposeOnly.Contains(alerte))
                                        dbgPurposeOnly.Add(alerte);
                                }
                            }
                            XElement tactDataElement = obj.Element(tacticalDataName);
                            if (tactDataElement != null)
                            {
                                XElement csElem = tactDataElement.Element(codeSymbolName);
                                if (csElem != null)
                                {
                                    var tab = csElem.Value.Split(':');
                                    //this._graphicalChart = tab[0];        // TODO PRA ?            
                                    smes.symbolProperties.SymbolID = tab[1];
                                }

                                XElement nameElem = tactDataElement.Element(nameName);
                                if (nameElem != null)
                                    smes.symbolProperties.Name = nameElem.Value;
                            }
                            XElement localisationElement = obj.Element(locationName);

                            if (localisationElement != null)
                            {// handle positions.

                                string resultWkid = smes.WkText;
                                SpatialReference sr = SpatialReference.Create(int.Parse(resultWkid));

                                string[] data;
                                SearchPosition(localisationElement, out data);

                                //    MapPoint point;//= new MapPoint(Convert.ToDouble(p[0], cif), Convert.ToDouble(p[1], cif));
                                //    string position = p[1] + "* | " + p[0] + "*";// Convert.ToDouble(p[1], cif) + " | " + Convert.ToDouble(p[0], cif);
                                //    point = CoordinateFormatter.FromLatitudeLongitude(position, sr); // WGS84 par defaut dans le converteur 

                                // search first point in data
                                int indexPoint = 0;
                                int iStartPoint = -1;
                                int iLocation = -1;
                                foreach (string s in data)
                                {

                                    if (s == "point" || s == "center" || s == "pointsMultiples") break;
                                    if (s == "location")
                                        iLocation = indexPoint;
                                    if (s == "startPoint")
                                        iStartPoint = indexPoint;

                                    indexPoint++;
                                }


                                if (indexPoint == data.Length)
                                {
                                    if (iLocation != 0 && iLocation < iStartPoint)// TODO PRA faire qq chose d'autre !
                                        indexPoint = iStartPoint;
                                    else if (iStartPoint != -1 && iLocation > iStartPoint)// TODO PRA faire qq chose d'autre !
                                        indexPoint = iLocation;
                                    else
                                    {
                                        indexPoint = -1; // a priori on est dans le cas tacpoint (par exemple)
                                                         // TODO PRA 
                                    }


                                }
                                double xd; double yd; double zd = 0;

                                MyDouble.TryParse(data[indexPoint + 1], out xd);  // Convert.ToDouble(data[indexPoint + 1], cif);
                                MyDouble.TryParse(data[indexPoint + 2], out yd); //Double.MyTryParse(data[indexPoint + 1], out xd);

                                // si on n'a que deux coordonnées, alors la troisième peut être hors tableau
                                bool lastCoord = indexPoint + 3 == data.Length ? false : MyDouble.TryParse(data[indexPoint + 3], out zd);


                                MapPoint p = lastCoord ? new MapPoint(xd, yd, zd, sr) : new MapPoint(xd, yd, sr);

                                string newValue = p.X.ToString(cif) + ";" + p.Y.ToString(cif); // TODO PRA et le z ?
                                smes[Message.ControlPointsPropertyName] = newValue;

                                switch (data[0])
                                {
                                    case "circle":

                                        // todo pra et le radius avec XName radiusName = XName.Get("radius");

                                        smes.SymbolGeometry = p;
                                        break;

                                    case "location": // dans la pratique piunt directement ?
                                        smes.SymbolGeometry = p;
                                        break;
                                    case "rectangle": // centre, l, h, orientation // typiquement fireobjective
                                        break;
                                    case "segment": // typiquement airtrack !
                                        break;

                                    case "polygon": // typiquement individu !
                                        break;

                                    case "polyline": // typiquement tacline !
                                        break;

                                    case "ellipse": // typiquement tacarea !
                                        break;
                                    case "arcband": // typiquement freeshape
                                        break;
                                    case "corridor":// typiquement freeshape
                                        break;
                                    default:
                                        break;
                                }


                                if (smes.SymbolGeometry == null)
                                    smes.SymbolGeometry = null;

                            }

                            //     SimpleMessage msg = new SimpleMessage();
                            //       public SimpleMessage(string id, bool isTemporary = false)
                            AddSimpleMessage(smes);
                        }

            }
            // TODO PRA creation des objets graphiques

            // gestion du temps ?


        }

        // Lecteur générique de message NC1. On spécifie les éléments qui vont dans le body (des XElements directement)
        // les élements non pris. Les autres iront dans header (un dico)
        // dropedNames to filter Graphicals Objects

        private static NC1_Message Load(XElement root, XName[] bodyNames, XName[] objectNames, XName[] dropedNames)
        {
            Dictionary<string, string> metaData = new Dictionary<string, string>();  // va contenir l'id !

            if (root.HasAttributes)
                foreach (XAttribute xattrib in root.Attributes())
                    metaData.Add(xattrib.Name.LocalName, xattrib.Value);

            string messageId;

            if (!metaData.TryGetValue("id", out messageId))
                messageId = "No id"; // TODO PRA ! 


            if (messageId == "2621179287")
                messageId.IsNormalized();

            Dictionary<string, string> header = new Dictionary<string, string>();

            XName[] filter = new XName[bodyNames.Length + dropedNames.Length + objectNames.Length];

            bodyNames.CopyTo(filter, 0);
            dropedNames.CopyTo(filter, bodyNames.Length);
            objectNames.CopyTo(filter, bodyNames.Length + dropedNames.Length);

            HandleXElem(header, root, filter, null);


            List<XElement> list = new List<XElement>();

            foreach (XName xname in bodyNames) // we assume dropedElements not in bodyElements
                if (xname.LocalName.Length > 0)
                    list.AddRange(root.Descendants(xname));//.Descendants());

            List<XElement> list2 = new List<XElement>();

            /*     foreach (XName xname in objectNames) 
                 {
                     if (xname.LocalName.Length > 0)
                     {
                         IEnumerable<XElement> res = root.Descendants(xname).Elements();

                         list2.AddRange(res.Where(xel=> !dropedNames.Contains(xel.Name) ) );//.Descendants());
                     }
                 }*/


            foreach (XElement xelN1 in root.Elements())
            {
                foreach (XElement xelN2 in xelN1.Descendants())
                {
                    if (NC1ObjectsNames.Contains(xelN2.Name))
                        list2.Add(xelN2);
                }
            }



            NC1_Message_xml message = new NC1_Message_xml(messageId)
            {
                MetaData = metaData,
                Header = header,
                Body = list.ToArray(),//.ToList()//. Todo pra plutot un array !,
                Objects = list2.ToArray()
                //MixedText = contentElement.Element(mixedTextName),
                //Objects = contentElement.Element(objectsName)
            };

            message.init();

            return message;
        }


        public static NC1_Message LoadMessageLibre(XElement root)
        {

            XName bodyName = XName.Get("body");
            XName objectsName = XName.Get("objects");
            //      XName objectName = XName.Get("object");
            XName objectsGlobalName = XName.Get("objectsGlobal");
            return Load(root, new XName[] { bodyName }, new XName[] { objectsName, objectsGlobalName }, Array.Empty<XName>());
        }



        public static NC1_Message LoadMessageLibre_old(XElement root)
        {
            Dictionary<string, string> metaData = new Dictionary<string, string>();  // va contenir l'id !

            if (root.HasAttributes)
                foreach (XAttribute xattrib in root.Attributes())
                    metaData.Add(xattrib.Name.LocalName, xattrib.Value);

            Dictionary<string, string> header = new Dictionary<string, string>();
            XName bodyName = XName.Get("body");
            XName objectsGlobalName = XName.Get("objectsGlobal");
            // TODO PRA : les objets devraient ....

            HandleXElem(header, root, new XName[] { bodyName, objectsGlobalName });
            /*    foreach (XElement xelem in root.Elements())
                {
                    if (xelem.Name != bodyName)
                        header.Add(xelem.Name.LocalName, xelem.Value);
                    }
                }*/

            //        Dictionary<string, string> body = new Dictionary<string, string>();
            //        XName contentName = XName.Get("content");
            //            foreach (XElement xElement in root.Elements(bodyName))
            //        HandleXElem(body, root, contentName, bodyName);
            //       XElement contentElement = root.Element(bodyName).Element(contentName);
            //     XName objectsName = XName.Get("objects");
            //      XName mixedTextName = XName.Get("mixedText");

            string messageId;

            if (!metaData.TryGetValue("id", out messageId))
                messageId = "No id";


            if (messageId == "2621179287")
                messageId.IsNormalized();


            //            contentElement.Element(objectsName);
            //            ;

            //     root.Elements(bodyName);

            NC1_Message_xml message = new NC1_Message_xml(messageId)
            {
                MetaData = metaData,
                Header = header,
                Body = root.Elements(bodyName).ToArray()
                //MixedText = contentElement.Element(mixedTextName),
                //Objects = contentElement.Element(objectsName)
            };

            message.init();

            return message;


        }

        private static void HandleXElem(Dictionary<string, string> dict, XElement element, XName[] filters, XName startName = null)
        {
            foreach (XElement xelem in element.Elements())
            {
                if (startName != null && xelem.Name != startName)
                    continue;

                if (!filters.Contains(xelem.Name))//!= filters)
                {
                    if (xelem.Name != startName && !xelem.Elements().Any())
                        dict.Add(xelem.Name.LocalName, xelem.Value);
                    HandleXElem(dict, xelem, filters);
                }

            }
        }
        public static NC1_Message Load(XElement root)
        {
            XName locationsName = XName.Get("locations");
            XName trackName = XName.Get("track");
            XName fireObjectivesName = XName.Get("fireObjectives");
            XName bodyName = XName.Get("body");
            XName objectsName = XName.Get("objects");
            //      XName objectName = XName.Get("object");
            XName objectsGlobalName = XName.Get("objectsGlobal");
            XName mixedTextName = XName.Get("mixedText");

            XName ownForcesSituationName = XName.Get("ownForcesSituation");
            XName enemyForcesSituationName = XName.Get("enemyForcesSituation");
            XName environmentName = XName.Get("environment");



            switch (root.Name.LocalName.ToLower())
            {
                case "nc1_initodb":
                    return null;
                case "nc1_listeequipementsressources":
                    return null;

                case "nc1_opord":
                    return null;
                case "nc1_opord-ain":
                    return null;
                case "nc1_opord-alat":
                    return null;
                case "nc1_opord-gen":
                    return null;
                case "nc1_opord-log":
                    return null;
                case "nc1_opord-opsec":
                    return null;
                case "nc1_opord-rens":
                    return null;
                case "nc1_opord-roe":
                    return null;
                case "nc1_opord-sic":
                    return null;
                case "nc1_opord-mvt":
                    return null;
                case "nc1_opord-ge":
                    return null;
                case "nc1_conops":
                    return null;
                case "nc1_apercu":
                    return null;
                case "nc1_apercu3d":
                    return null;
                case "nc1_tactoap":
                    return null;
                case "nc1_technoap":
                    return null;
                case "nc1_boap":
                    return null;

                case "nc1_messagelibre":
                    return Load(root, new XName[] { bodyName }, new XName[] { objectsName, objectsGlobalName }, Array.Empty<XName>());
                case "nc1_str":
                    return Load(root, Array.Empty<XName>(), new XName[] { ownForcesSituationName, enemyForcesSituationName, environmentName }, new XName[] { mixedTextName });

                case "nc1_stacmconduite":
                    return null;
                case "nc1_objectivelist":



                    return Load(root, Array.Empty<XName>(), new XName[] { fireObjectivesName }, Array.Empty<XName>());// ()//LoadMessageLibre(root);

                //    return LoadMessageLibre(root);
                //              return null;
                case "nc1_firereport":
                    return null;
                case "nc1_igen":
                    return null;
                case "nc1_bda":
                    return null;
                case "nc1_callforfire":
                    return null;
                case "nc1_firecontrol":
                    return null;
                case "nc1_suppressionitsats":
                    return null;
                case "nc1_finalerteraideni":
                    return null;
                case "nc1_deployrep":
                    return null;
                case "nc1_annulertirinterdit":
                    return null;
                case "nc1_tirinterdit":
                    return null;
                case "nc1_cca-card":
                    return null;
                case "nc1_plandevol":
                    return null;
                case "nc1_helopsum":
                    return null;

                case "nc1_bft":

                    return Load(root, Array.Empty<XName>(), new XName[] { locationsName }, Array.Empty<XName>());// ()//LoadMessageLibre(root);
                                                                                                                 //        return null;
                case "nc1_ownsitrep":
                    return null;
                case "nc1_ensitrep":
                    return null;
                case "nc1_eventrep":
                    return null;
                case "nc1_medevac-nine-line":
                    return null;
                case "nc1_eoincrep":
                    return null;

                case "nc1_prr":
                    return null;
                case "nc1_pema":
                    return null;
                case "nc1_intreq":
                    return null;
                case "nc1_intrep":
                    return null;
                case "nc1_intsum":
                    return null;

                case "nc1_sitobst":
                    return null;
                case "nc1_barrep":
                    return null;
                case "nc1_barreq":
                    return null;
                case "nc1_propositionplanobstacles":
                    return null;
                case "nc1_engrecceord":
                    return null;

                case "nc1_admitexitrep":
                    return null;
                case "nc1_initmedrep":
                    return null;
                case "nc1_medsitrep":
                    return null;

                case "nc1_ewmsnsum":
                    return null;
                case "nc1_ewrtm":
                    return null;

                case "nc1_conarep":
                    return null;
                case "nc1_demalord":
                    return null;
                case "nc1_movorder":
                    return null;
                case "nc1_batrecevacreq":
                    return null;
                case "nc1_obsexord":
                    return null;
                case "nc1_engreccerep":
                    return null;
                case "nc1_matdem":
                    return null;

                case "nc1_cbrn-1-bio":
                    return null;
                case "nc1_cbrn-1-chem":
                    return null;
                case "nc1_cbrn-3-bio":
                    return null;
                case "nc1_cbrn-3-chem":
                    return null;
                case "nc1_cbrn-4-bio":
                    return null;
                case "nc1_cbrn-4-chem":
                    return null;
                case "nc1_cbrn-5-bio":
                    return null;
                case "nc1_cbrn-5-chem":
                    return null;
                case "nc1_cbrn-cdr":
                    return null;
                case "nc1_cbrn-sitrep":
                    return null;

                case "nc1_request":
                    return null;
                case "nc1_techstcupdate":
                    return null;

                default:
                    return null;
            }


        }



        // recursively add subElements of xelem, except  filter and all filter children)
        // if startName is set, start with Element of corresponding name.
        private static void HandleXElem_old(Dictionary<string, string> dict, XElement element, XName[] filters, XName startName = null)
        {
            foreach (XElement xelem in element.Elements())
            {
                if (startName != null && xelem.Name != startName)
                    continue;

                if (!filters.Contains(xelem.Name))//!= filters)
                {
                    if (xelem.Name != startName)
                        dict.Add(xelem.Name.LocalName, xelem.Value);
                    HandleXElem(dict, xelem, filters);
                }

            }
        }



        // populates Base object (Message) with NC1 data
        internal void init()
        {
            XName idName = XName.Get("id");
            XName locationName = XName.Get("location");
            XName tacticalDataName = XName.Get("tacticalData");
            XName codeSymbolName = XName.Get("symbolCode");
            XName nameName = XName.Get("name");
            XName xName = XName.Get("x");
            XName yName = XName.Get("y");
            XName zName = XName.Get("z");

            XName circleName = XName.Get("circle");
            XName pointName = XName.Get("point");
            XName polylineName = XName.Get("polyline");
            XName contentName = XName.Get("content");
            XName objectsName = XName.Get("objects");

            CultureInfo cif = new CultureInfo("en-US");

            //          foreach (XElement inBody in Bodys)
            {
                //                < title >
                //                < hierarchyLevel >
                //                < content >
                //                     < mixedText >
                //                     < objects >
                //                           < object>
                //           foreach (XElement sub in inBody.Elements(contentName))
                //              foreach (XElement objects in sub.Elements(objectsName))
                foreach (XElement obj in this.Objects)// objects.Elements())
                {
                    if (!obj.HasAttributes && !obj.HasElements)
                    {

                        string alerte = this.MetaData.LastOrDefault().Key + " ; " + obj.Name.LocalName + " no attributes nor elements";
                        System.Diagnostics.Trace.WriteLine("NC1_init correction pour l'objet inexploitable " + obj.Name.LocalName);
                        if (!dbgPurposeOnly.Contains(alerte))
                            dbgPurposeOnly.Add(alerte);
                        continue;
                    }


                    //System.Diagnostics.Trace.WriteLine("##NC1_init du message ^pour l'objet " + obj.Name.LocalName);
                    string id = obj.Attribute(idName).Value;
                    System.Diagnostics.Trace.WriteLine("##NC1_init du message pour l'objet " + id);

                    if (id == "13:9999:119")
                        id.IsNormalized();

                    SimpleMessage smes = new SimpleMessage(id);

                    foreach (XAttribute attr in obj.Attributes()) // dont type qui est le type d'objet et l'id NC1
                    {
                        if (attr.Name != idName)
                            smes.Add(attr.Name.LocalName, attr.Value);
                    }

                    // on transfere les données vers le SimpleMessage
                    foreach (XElement subElement in obj.Elements())
                    {
                        if (!smes.ContainsKey(subElement.Name.LocalName))
                            smes.Add(subElement.Name.LocalName, subElement.ToString());
                        else
                        {
                            string oldValue = smes[subElement.Name.LocalName];
                            System.Diagnostics.Trace.WriteLine("NC1_init correction pour le champ multiple " + subElement.Name.LocalName);
                            smes[subElement.Name.LocalName] = oldValue + "\n" + subElement.ToString();
                            // smes["type"] // donne le type d'obj
                            string alerte = smes["type"] + " ; " + subElement.Name.LocalName;

                            if (!dbgPurposeOnly.Contains(alerte))
                                dbgPurposeOnly.Add(alerte);
                        }
                    }
                    XElement tactDataElement = obj.Element(tacticalDataName);
                    if (tactDataElement != null)
                    {
                        XElement csElem = tactDataElement.Element(codeSymbolName);
                        if (csElem != null)
                        {
                            var tab = csElem.Value.Split(':');
                            //this._graphicalChart = tab[0];        // TODO PRA ?            
                            smes.symbolProperties.SymbolID = tab[1];
                        }

                        XElement nameElem = tactDataElement.Element(nameName);
                        if (nameElem != null)
                            smes.symbolProperties.Name = nameElem.Value;
                    }
                    XElement localisationElement = obj.Element(locationName);

                    if (localisationElement != null)
                    {// handle positions.

                        string resultWkid = smes.WkText;
                        SpatialReference sr = SpatialReference.Create(int.Parse(resultWkid));

                        string[] data;
                        SearchPosition(localisationElement, out data);

                        //    MapPoint point;//= new MapPoint(Convert.ToDouble(p[0], cif), Convert.ToDouble(p[1], cif));
                        //    string position = p[1] + "* | " + p[0] + "*";// Convert.ToDouble(p[1], cif) + " | " + Convert.ToDouble(p[0], cif);
                        //    point = CoordinateFormatter.FromLatitudeLongitude(position, sr); // WGS84 par defaut dans le converteur 

                        // search first point in data
                        int indexPoint = 0;
                        int iStartPoint = -1;
                        int iLocation = -1;
                        foreach (string s in data)
                        {

                            if (s == "point" || s == "center" || s == "pointsMultiples") break;
                            if (s == "location")
                                iLocation = indexPoint;
                            if (s == "startPoint")
                                iStartPoint = indexPoint;

                            indexPoint++;
                        }


                        if (indexPoint == data.Length)
                        {
                            if (iLocation != 0 && iLocation < iStartPoint)// TODO PRA faire qq chose d'autre !
                                indexPoint = iStartPoint;
                            else if (iStartPoint != -1 && iLocation > iStartPoint)// TODO PRA faire qq chose d'autre !
                                indexPoint = iLocation;
                            else
                            {
                                indexPoint = -1; // a priori on est dans le cas tacpoint (par exemple)
                                                 // TODO PRA 
                            }


                        }
                        double xd; double yd; double zd = 0;

                        MyDouble.TryParse(data[indexPoint + 1], out xd);  // Convert.ToDouble(data[indexPoint + 1], cif);
                        MyDouble.TryParse(data[indexPoint + 2], out yd); //Double.MyTryParse(data[indexPoint + 1], out xd);

                        // si on n'a que deux coordonnées, alors la troisième peut être hors tableau
                        bool lastCoord = indexPoint + 3 == data.Length ? false : MyDouble.TryParse(data[indexPoint + 3], out zd);


                        MapPoint p = lastCoord ? new MapPoint(xd, yd, zd, sr) : new MapPoint(xd, yd, sr);

                        string newValue = p.X.ToString(cif) + ";" + p.Y.ToString(cif); // TODO PRA et le z ?
                        smes[Message.ControlPointsPropertyName] = newValue;

                        switch (data[0])
                        {
                            case "circle":

                                // todo pra et le radius avec XName radiusName = XName.Get("radius");

                                smes.SymbolGeometry = p;
                                break;

                            case "location": // dans la pratique piunt directement ?
                                smes.SymbolGeometry = p;
                                break;
                            case "rectangle": // centre, l, h, orientation // typiquement fireobjective
                                break;
                            case "segment": // typiquement airtrack !
                                break;

                            case "polygon": // typiquement individu !
                                break;

                            case "polyline": // typiquement tacline !
                                break;

                            case "ellipse": // typiquement tacarea !
                                break;
                            case "arcband": // typiquement freeshape
                                break;
                            case "corridor":// typiquement freeshape
                                break;
                            default:
                                break;
                        }


                        if (smes.SymbolGeometry == null)
                            smes.SymbolGeometry = null;

                    }

                    //     SimpleMessage msg = new SimpleMessage();
                    //       public SimpleMessage(string id, bool isTemporary = false)
                    AddSimpleMessage(smes);
                }

            }
            // TODO PRA creation des objets graphiques

            // gestion du temps ?


        }

        internal static void SearchPosition(XElement elem, out string[] data)
        {
            XName x = XName.Get("x");
            //       XName y = XName.Get("y");
            XName z = XName.Get("z");

            List<string> liste = new List<string>();

            var tmp = elem.Descendants(x);
            if (tmp == null || !tmp.Any())
                tmp = elem.Descendants(XName.Get("latitude"));  // Correctif pour les 3D routes mieux faire ? TODO PRA 


            if (tmp == null || !tmp.Any())
            {
                liste.Add(elem.Name.LocalName);
                foreach (XElement el in elem.Elements())
                {
                    liste.Add(el.Name.LocalName);
                    if (el.HasAttributes)
                        liste.Add(el.Attribute(XName.Get("id")).Value);
                    else
                        liste.Add(el.Value);

                }
                data = liste.ToArray();
                return;
            }

            XElement firstCoord = tmp.FirstOrDefault();

            XElement pointOrCenter = firstCoord.Parent;
            XElement geometry = pointOrCenter.Parent;

            liste.Add(geometry.Name.LocalName);
            //    liste.Add(pointOrCenter.Name.LocalName);

            foreach (XElement current in geometry.Descendants())
            {
                if (current.Parent.Name != pointOrCenter.Name)
                {
                    //  liste.Add(current.Value);
                    liste.Add(current.Name.LocalName);

                    if (!current.HasElements)
                        liste.Add(current.Value);
                }
                else
                {

                    liste.Add(current.Value);
                }


            }

            XName startPointName = XName.Get("startPoint");  // modif pour les routes
            if (geometry.Name == startPointName) // on ajoute le noeud suivant
            {
                XName endPointName = XName.Get("endTacPointId");
                XElement pn = geometry.Parent;
                XElement endPoint = elem.Descendants(endPointName).FirstOrDefault();
                if (endPoint != null)
                {
                    liste.Add(endPoint.Name.LocalName);

                    if (endPoint.HasAttributes)
                        liste.Add(endPoint.Attribute(XName.Get("id")).Value);
                    else
                        liste.Add(endPoint.Value);  // TODO PRA a tester
                }

            }


            //  Search first node with x.
            // parent is point or center.
            // parent is geometrie.
            // gets others data .. (radius other points)
            data = liste.ToArray();
        }





    }
}
