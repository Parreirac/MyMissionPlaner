// Copyright 2015 Esri 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI;
using MilitaryPlanner.Helpers;
using MyMissionPlaner.Helpers.MyHelpers;
using MyMissionPlaner.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MilitaryPlanner.Models
{
    [Serializable]
    public class Mission : NotificationObject
    {
        public string[] Filenames { get; private set; }

        // Pour le format xml natif ESRI 
        public List<Graphic> _graphics;
        

        public Mission()
        {
            _name = "Default Mission";
            _phaseList = new List<MissionPhase>();
            //     _timeAwareMilitaryMessages = new List<TimeAwareMilitaryMessage>();  // Modif pra les messages sont dans les phases maintenant
        }

//      private string _sourceFormat;

//        public string SourceFormat { get { return _sourceFormat; } }

        private string _sourceFormatVersion;
        public string Version { get { return _sourceFormatVersion; } }
        private string _graphicalChart;

        public string GraphicalChart { get { return _graphicalChart; } }

        public List<MissionPhase> Phases(TimeExtent te)
        {
            return _phaseList.Where(mp => !(mp.VisibleTimeExtent.EndTime < te.StartTime || mp.VisibleTimeExtent.StartTime > te.EndTime)).ToList();//  te.StartTime >= mp.VisibleTimeExtent.StartTime) || (mp.VisibleTimeExtent.StartTime >= te.StartTime && te.EndTime <= mp.VisibleTimeExtent.EndTime)).ToList();//.ToArray();
        }

        public bool Remove(SimpleMessage msg)
        {
            bool returnValue = false;
            foreach (MissionPhase mp in _phaseList)
                returnValue = mp.Remove(msg) || returnValue; // l'évaluation doit etre a gauche sinon si returnValue = true elle n'est pas faite !
            return returnValue;
        }

        public List<SimpleMessage> GetMessages(string id)  // TODO PRA en readonly ?
        {
            List<SimpleMessage> liste = new List<SimpleMessage>();

            foreach (MissionPhase mp in _phaseList)
            {
                var lm = mp.GetMessages(id);
                if (lm.Any())
                    liste.AddRange(lm);
            }
            return liste;
        }


        private static bool Intersects(TimeExtent t1, TimeExtent t2)
        {
            if ((t1.EndTime < t2.StartTime) || (t1.StartTime > t2.EndTime)) return false;
            return true; ;
        }

        //TODO PRA
        // Version directe, on regarde message
        // si le message n'est pas un TimeAwareMilitaryMessage => va planter
        /*    public List<Message> GetMessagesUnsafe(TimeExtent timeExtent)
            {
                var militaryMessages = GetMessages().Where(m => Intersects(timeExtent, (m as TimeAwareMilitaryMessage).VisibleTimeExtent));//.EndTime > timeExtent.StartTime && (m as TimeAwareMilitaryMessage).VisibleTimeExtent.StartTime < timeExtent.EndTime).ToList(); // (timeExtent)) ).ToList();
                return militaryMessages.ToList();
            }*/

        public List<SimpleMessage> GetMessages(TimeExtent timeExtent)
        {
            List<SimpleMessage> liste = new List<SimpleMessage>();

            foreach (MissionPhase mp in Phases(timeExtent))
            {

                foreach (SimpleMessage msg in mp.Messages)//.me .GetMessagesGetMessages())
                {
                    TimeAwareMilitaryMessage tam = msg as TimeAwareMilitaryMessage;

                    if (tam != null)
                    {
                        if (Intersects(timeExtent, tam.VisibleTimeExtent))
                            liste.Add(tam);
                    }
                    else
                        liste.Add(msg); // Le msg n'a pas de temps, c'est donc celui de la phase qui est déjà filtré

                }
            }
            return liste;
        }


        public List<SimpleMessage> GetMessages()  // TODO PRA en readonly ?
        {
            List<SimpleMessage> liste = new List<SimpleMessage>();

            foreach (MissionPhase mp in _phaseList)
            {
                var lm = mp.Messages;//.GetMessages();
                if (lm.Count > 0)
                    liste.AddRange(lm);
            }
            return liste;
        }

        [XmlIgnore]
        private string _name;

        [XmlElement]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }
        [XmlIgnore]
        private List<MissionPhase> _phaseList;// = new List<MissionPhase>();

        [XmlElement] //("PhaseList",typeof(List<MissionPhase>))]
        public List<MissionPhase> PhaseList
        {
            get { return _phaseList; }
            set
            {
                if (_phaseList != value)
                {
                    _phaseList = value;
                    RaisePropertyChanged(() => PhaseList);
                }
            }
        }

        //      [XmlIgnore]
        //        private List<TimeAwareMilitaryMessage> _timeAwareMilitaryMessages;// = new List<TimeAwareMilitaryMessage>();

        /*     [XmlElement("PersistentMessages", typeof(List<TimeAwareMilitaryMessage>))]  // TODO PRA
             public List<TimeAwareMilitaryMessage> MilitaryMessages
             {
                 get
                 {
                     return _timeAwareMilitaryMessages;
                 }

                 set
                 {
                     if (value != _timeAwareMilitaryMessages)
                     {
                         _timeAwareMilitaryMessages = value;
                         RaisePropertyChanged(() => MilitaryMessages);
                     }
                 }
             } */

        public bool Save(string filename)
        {
            return Save(filename, Constants.SAVE_AS_MISSION);
        }

        public bool Save(string filename, int saveAsType)
        {
            switch (saveAsType)
            {
                case Constants.SAVE_AS_GEOMESSAGES:
                    return SaveGeomessages(filename);

                case Constants.SAVE_AS_MISSION:
                default:
                    return SaveMission(filename);
            }
        }

        private bool SaveMission(string filename)  //TODO PRA
        {
            if (String.IsNullOrWhiteSpace(filename))
                return false;

            XmlSerializer x = new XmlSerializer(GetType());
            XmlWriter writer = new XmlTextWriter(filename, Encoding.UTF8);

            x.Serialize(writer, this);

            return true;
        }

        private bool SaveGeomessages(string filename)
        {
            if (String.IsNullOrWhiteSpace(filename))
            {
                return false;
            }

            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("geomessages");

                var mm = this.GetMessages();

                foreach (TimeAwareMilitaryMessage message in mm)
                {
                    writer.WriteStartElement("geomessage");
                    foreach (KeyValuePair<string, string> kvp in message)
                    {
                        string key = kvp.Key.ToLower();
                        string value = kvp.Value;
                        if ("sic" == key)
                        {
                            while (15 > value.Length)
                            {
                                value += "-";
                            }
                        }

                        writer.WriteElementString(key, value);
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            return true;
        }

        public bool Load2(string filename) // test pra version de base
        {
            if (!String.IsNullOrWhiteSpace(filename) && File.Exists(filename))
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(GetType());
                    FileStreamOptions streamOptions = new FileStreamOptions(); // Modif PRA mettre une lecture multiple
                    //  a priori les option par defaut suffisent.
                    streamOptions.Mode = FileMode.Open;
                    streamOptions.Access = FileAccess.Read;
                    streamOptions.Share = FileShare.Read;
                    TextReader tr = new StreamReader(filename, streamOptions);
                    var temp = x.Deserialize(tr) as Mission;

                    if (temp != null)
                    {
                        Name = temp.Name;
                        PhaseList = temp.PhaseList;  // TODO PRA cette version ne peut plus marcher !
                        //MilitaryMessages = temp.MilitaryMessages;
                        tr.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in loading mission file.\n" + ex.ToString());
                }

            }

            return false;
        }

        public bool LoadNC1(XElement root)
        {
            //     _sourceFormat = root.Name.LocalName; // todo pra a deplacer vers messsage pour la selection multiple
            //         XAttribute versionAttribute = root.Attribute(version);
            //            _sourceFormatVersion = versionAttribute.Value  // TODO PRA 

       //  NC1_Message msg = null;//.Load(root);

            NC1_MessageWrapper msg = NC1_MessageWrapper.Create(root);
      //      NC1_Message msg = mm.TrueNC1_Message;
            if (msg != null)
            {
                PhaseList[0].AddMessage(msg);
                foreach (SimpleMessage m in msg.SubMessages)
                    PhaseList[0].AddMessage(m); // sinon la selection ne fonctionne pas
                return true;
            }

            return false;
        }


        public bool LoadNVG(XElement root)
        {
            //        this._sourceFormat = "NVG"; // todo pra 
            _name = "Default Mission";
            XName version = XName.Get("version");
            //      root.Document..FirstNode.

            XAttribute versionAttribute = root.Attribute(version);
            _sourceFormatVersion = versionAttribute.Value;

            //        XName a = XName.Get("a");  // typiquement en v0,3
            XName point = XName.Get("point");
            XName symbol = XName.Get("symbol");
            //           XName label = XName.Get("label");
            XName id = XName.Get("id");
            XName x = XName.Get("x");
            XName y = XName.Get("y");
            //          XName uri = XName.Get("uri");  // typiquement en v0,3
            //       Name = x.Value;  // mettre le nom du fichier ?

            int i = 0;

            foreach (var elem in root.Elements())// ....Elements(a))
            {
                XName points = XName.Get("points");
                // TODO faire une liste des attributs et eleme deja traités !

                List<string> attributesDone = new List<string>();
                List<string> elementsDone = new List<string>();
                string type = elem.Name.LocalName;

                XElement elementwithMessageInfo = elem;

                XName myId = XName.Get("uri");
                XAttribute idAtrib = elementwithMessageInfo.Attribute(myId);
                attributesDone.Add(myId.LocalName);

                if (idAtrib == null)
                {   // L'element n'a pas d'uri (nvg2)
                    // soit l'id est dans un attribut sous le nom d'id
                    // soit c'est dans un element subordonné (typiquement la géométrie)
                    myId = XName.Get("id");
                    idAtrib = elem.Attribute(id); // va servir de clé en NVG 2

                    if (idAtrib == null)
                    {
                        foreach (XElement subElem in elem.Elements())//.Attributes())
                        {

                            var value = subElem.Attribute(id);
                            if (value != null)
                            {
                                elementwithMessageInfo = subElem;
                                idAtrib = value;
                                break; // TODO PRA : suffit s'il y a plusieurs elements ?
                            }
                        }
                    }
                    attributesDone.Add(id.LocalName);
                }

                //             XAttribute labelElem = elem.Attribute(label);
                XAttribute symbolElem = elementwithMessageInfo.Attribute(symbol);
                attributesDone.Add(symbol.LocalName);
                string symbolString = symbolElem != null ? symbolElem.Value : "";
                string codeSymbol = "";
                if (symbolString != "")
                {
                    var tab = symbolString.Split(':');
                    this._graphicalChart = tab[0];
                    codeSymbol = tab[1];
                }

                SimpleMessage msg = new SimpleMessage(idAtrib.Value)
                {
                    symbolProperties = new SymbolProperties() { SymbolID = codeSymbol }
                };
                //            msg.Add/*setProperty*/(Message.SicCodePropertyName, codeSymbol);
                XAttribute pointsElem = elementwithMessageInfo.Attribute(points); // ou elem.Element(point);
                if (pointsElem != null)
                {
                    attributesDone.Add(points.LocalName);
                    string listePoints = pointsElem.Value.Replace(',', ';').Replace(' ', ';');
                    msg.Add/*setProperty*/(Message.ControlPointsPropertyName, listePoints); // TODO PRA : modifier !!
                }
                else
                {
                    if (elementwithMessageInfo.Name.LocalName == point.LocalName)// TODO PRA et pour les autres cas ? != null)
                    {
                        msg.Add/*setProperty*/(Message.ControlPointsPropertyName, elementwithMessageInfo.Attribute(x).Value + ";" + elementwithMessageInfo.Attribute(y).Value);
                        attributesDone.Add(x.LocalName);
                        attributesDone.Add(y.LocalName);
                        //   elementsDone.Add(elmentwithMessageInfo.Name.LocalName);
                    }
                }

                //    
                foreach (XAttribute subElem in elementwithMessageInfo.Attributes())
                {
                    if (!attributesDone.Contains(subElem.Name.LocalName))
                        //      if (subElem.Name.LocalName != Message.SicCodePropertyName && subElem.Name != uri && subElem.Name != points && subElem.Name  != symbol)
                        msg.Add/*setProperty*/(subElem.Name.LocalName, subElem.Value);
                }

                foreach (XElement subElem in elementwithMessageInfo.Elements())//.Attributes())
                {
                    if (!elementsDone.Contains(subElem.Name.LocalName))
                        msg.Add/*setProperty*/(subElem.Name.LocalName, subElem.Value);
                }

                PhaseList[0].AddMessage(msg);

                //                    XElement pointElem = elem.Element(point);
                i++;

            }

            return i > 0;// t if rue;
        }

        public bool LoadMission(XElement rootElem)
        {
            //        this._sourceFormat = "Mission"; // TODO PRA deplacer vers msg
            XName missionPhase = XName.Get("MissionPhase");
            XName name = XName.Get("Name");
            XName id = XName.Get("ID");
            XName phaseList = XName.Get("PhaseList");
            XName visibleTimeExtent = XName.Get("VisibleTimeExtent");
            XName start = XName.Get("Start");
            XName end = XName.Get("End");
            XName persistentMessages = XName.Get("PersistentMessages");
            XName persistentMessage = XName.Get("PersistentMessage");

            var x = rootElem.Element(name);
            if (x != null)
                Name = x.Value;

            XElement pl = rootElem.Element(phaseList);

            List<MissionPhase> tmpMPL = new List<MissionPhase>();

            foreach (var elem in pl.Elements(missionPhase))
            {
                MissionPhase tmpMP = new MissionPhase();
                tmpMPL.Add(tmpMP);
                tmpMP.Name = elem.Element(name).Value;
                tmpMP.ID = elem.Element(id).Value;  // TODO PRA : est ce dans l'esprit XML ?
                XElement vte = elem.Element(visibleTimeExtent);

                if (vte != null)
                    tmpMP.VisibleTimeExtent = new TimeExtent((DateTimeOffset)vte.Element(start), (DateTimeOffset)vte.Element(end));

                XElement pms = elem.Element(persistentMessages);

                if (pms != null)
                {
                    foreach (var pm in pms.Elements(persistentMessage))
                    {
                        TimeAwareMilitaryMessage msg = TimeAwareMilitaryMessage.MonReader(pm);
                        tmpMP.AddMessage(msg);
                    }
                }
            }
            PhaseList = tmpMPL;
            return true;
        }

        // return true if one file have been readed
        public bool Load(string[] filenames)
        {
            if (filenames == null || filenames.Length == 0)
                return false;

            Filenames = filenames;

            bool returnValue = false;


            // store PhaseList
            var tmpPL = PhaseList;
            // emty current liste :
            PhaseList = new List<MissionPhase> { new MissionPhase() };// ();

            foreach (string file in filenames)
            {
                if (String.IsNullOrWhiteSpace(file) || !File.Exists(file))
                    continue;

                System.Diagnostics.Trace.WriteLine("##Loading file " + file);


                if (file.EndsWith(".shp",true,null) || file.EndsWith(".sbx", true, null))
                {
                    returnValue = LoadShapeFile (file).Result || returnValue;
                        continue;
               }
                XDocument xfile = XDocument.Load(file);  // TODO PRA si echec en lecture ....
                var rootElem = xfile.Root;
                var xmlType = rootElem.Name.LocalName;
                if (xmlType.StartsWith("NC1_"))
                    xmlType = "nc1_";
                //     bool retour = false;
                switch (xmlType.ToLower())
                {
                    case "nvg":
                        returnValue = LoadNVG(rootElem) || returnValue ; //  /!\ L'évaluation DOIT etre a gauche sinon si 
                        break;                                           // returnValue = true, elle n'est pas calculée !
                    case "mission":
                        returnValue = LoadMission(rootElem) || returnValue ;
                        break;
                    case "nc1_":
                        returnValue = LoadNC1(rootElem) || returnValue ;
                        break;
                    case "messages":
                        returnValue = LoadEsriMessages(rootElem) || returnValue;
                        break;
                    default:
                        break;
                }

            }

            if (returnValue)
                Filenames = filenames;
            else
                PhaseList = tmpPL; // restore value

            return returnValue;
        }

        private bool LoadEsriMessages(XElement rootElem)
        {
            IEnumerable<XElement> messages = rootElem.Descendants("message");

            // Add a graphic for each message.

            if (_graphics == null)
                _graphics = new List<Graphic>();
            else
                _graphics.Clear();

            foreach (var message in messages)
            {
                _graphics.Add(GraphicFromAttributes(message.Descendants().ToList()));
          
            }
            return _graphics.Any();

        }
        // FROM WPF Example Name: DictionaryRendererGraphicsOverlay

        private Graphic GraphicFromAttributes(List<XElement> graphicAttributes)
        {
            // Get the geometry and the spatial reference from the message elements.
            XElement geometryAttribute = graphicAttributes.First(attr => attr.Name == "_control_points");
            XElement spatialReferenceAttr = graphicAttributes.First(attr => attr.Name == "_wkid");

            // Split the geometry field into a list of points.
            Array pointStrings = geometryAttribute.Value.Split(';');

            // Create a point collection in the correct spatial reference.
            int wkid = Convert.ToInt32(spatialReferenceAttr.Value);
            SpatialReference pointSR = SpatialReference.Create(wkid);
            PointCollection graphicPoints = new PointCollection(pointSR);

            // Add a point for each point in the list.
            foreach (string pointString in pointStrings)
            {
                var coords = pointString.Split(',');
                double x, y;
                MyDouble.TryParse(coords[0], out x);
                MyDouble.TryParse(coords[1], out y);
                graphicPoints.Add(x, y);
            }

            // Create a multipoint from the point collection.
            Multipoint graphicMultipoint = new Multipoint(graphicPoints);

            // Create the graphic from the multipoint.
            Graphic messageGraphic = new Graphic(graphicMultipoint);

            // Add all of the message's attributes to the graphic (some of these are used for rendering).
            foreach (XElement attr in graphicAttributes)
            {
                messageGraphic.Attributes[attr.Name.ToString()] = attr.Value;
            }

            return messageGraphic;
        }

        // A shapefile dataset consists of at least three files: *.shp, *.shx, and*.dbf(and may include various others).
        // Open a shapefile using the path to the*.shp file(specified in Path). The associated *.shx and *.dbf files must be
        // present at the same location and each of the component files of a shapefile must be smaller than 2 GB.If the minimum
        // required files are not present(or larger than 2 GB), the table will fail to load.If the file permissions are read-only,
        // features cannot be edited. On-the-fly projection of a shapefile is only supported if an associated *.prj file is present.
        // Otherwise, the features are assumed to have the same spatial reference as the map.  
        //  ArcGIS for Desktop can be used to create spatial indexes for shapefiles(stored in *.sbn and *.sbx files). Having a
        //  current spatial index ensures that a high level of performance is maintained when drawing and working with the
        //  shapefile's features and that the shapefile's extent is accurate.
        private async Task<bool> LoadShapeFile (string file)
        {
            var res = await ShapefileFeatureTable.OpenAsync(file);

            if (res == null)
                return false;
      
     //       ShapefileFeatureTable myShapefile = res. .Layer;

            // Create a feature layer to display the shapefile
            FeatureLayer newFeatureLayer = new FeatureLayer(res);

           var msg = new SimpleMessage(newFeatureLayer);


            PhaseList[0].AddMessage(msg);
            return true;

        }

        public bool AddPhase(string name)
        {
            try
            {
                var phase = new MissionPhase(/*name*/ ) { Name = name, ID = Guid.NewGuid().ToString("D") };

                if (PhaseList.Count > 0)
                {
                    var lastTimeExtent = PhaseList.Last().VisibleTimeExtent;
                    phase.VisibleTimeExtent = new TimeExtent(lastTimeExtent.EndTime.AddSeconds(1.0), lastTimeExtent.EndTime.AddHours(1.0));// lastTimeExtent.Offset(new TimeSpan(1, 0, 0)).End);
                }
                else
                {
                    // set default time extent
                    phase.VisibleTimeExtent = new TimeExtent(DateTime.Now, DateTime.Now.AddSeconds(3599));
                }

                PhaseList.Add(phase);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public Mission ShallowCopy()
        {
            return (Mission)MemberwiseClone();
        }

        //   [Obsolete("A tester pra ", false)]
        public Mission DeepCopy()
        {
            Mission mission = (Mission)MemberwiseClone(); // fait une copie, donc les listes sont les memes !

            // MODIF PRA : le clone a deja tout. De plus les messages (associés à la phase) sont
            // effacés par le code ci après
            // sauf que si je supprimer, le programme devient très lent !
            // a priori c'est le fait d'effacer les messages via le code de base qui accelère tout.

            mission.Name = Name;// string.Copy(Name);

            var pl = PhaseList.Select(mp => new MissionPhase
            {
                ID = mp.ID, //string.Copy(),  // TODO PRA le copy est il utile ? a priori non !
                Name = mp.Name,//string.Copy(),
                VisibleTimeExtent = new TimeExtent(mp.VisibleTimeExtent.StartTime, mp.VisibleTimeExtent.EndTime)
                 ,
                Messages = new List<SimpleMessage>(mp.Messages.ToList())
            }).ToList();
            mission.PhaseList = pl;

            return mission;
        }
    }
    // todo pra mettre un descriptif
    /*    [Serializable]
        public class MyTimeExtent : TimeExtent//, ISerializable// Pour palier le changement dans TimeExtent, qui n'a plus de constructeur sans argument
        {
            public MyTimeExtent() : base(DateTimeOffset.MinValue, DateTimeOffset.MaxValue)//.UtcNow) 
            { }
            public MyTimeExtent(DateTimeOffset timeInstant) : base(timeInstant)
            { }

            public MyTimeExtent(DateTimeOffset startTime, DateTimeOffset endTime) : base(startTime, endTime)
            { }

            [XmlElement("End", typeof(DateTimeOffset))]
            public new DateTimeOffset EndTime
            {
                get;
                set;
            }

            [XmlElement("Start", typeof(DateTimeOffset))]
            public new DateTimeOffset StartTime
            {
                get;
                set;
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
                    {
                 //       info.AddValue("<VisibleTimeExtent>", null);
                        info.AddValue("Start", StartTime);
                        info.AddValue("End", EndTime);
                 //       info.AddValue("</VisibleTimeExtent>", null);
                    }

                    // The special constructor is used to deserialize values.
                    protected MyTimeExtent(SerializationInfo info, StreamingContext context):base(
                        (DateTimeOffset) info.GetValue("Start", typeof(DateTimeOffset)),
                        (DateTimeOffset) info.GetValue("End", typeof(DateTimeOffset))) 
                    {}

            // existe de base, c'est interdit
            //   public static implicit operator MyTimeExtent(TimeExtent value)
            //   {
            //       return new MyTimeExtent(value.StartTime, value.EndTime);
            //   }
        }
    */

    //   [Serializable]
    public class MissionPhase : NotificationObject, ISerializable  // Test pour palier l'absence de TimeExtent() 
    {
        public MissionPhase(string name = null)
        {
            if (name != null)
                _name = name;
            ID = "No ID";
            VisibleTimeExtent = new TimeExtent(DateTimeOffset.MinValue, DateTimeOffset.MaxValue);
            Messages = new List<SimpleMessage>();// ajout pra
        }

        // ajout pour le xaml EditMissionPhasesView // todo pra verifier s'il sert 
        public DateTimeOffset StartTime
        {
            get { return VisibleTimeExtent.StartTime; }
            set { VisibleTimeExtent = new TimeExtent(value, VisibleTimeExtent.EndTime); }
        }

        public DateTimeOffset EndTime
        {
            get { return VisibleTimeExtent.EndTime; }
            set { VisibleTimeExtent = new TimeExtent(VisibleTimeExtent.StartTime, value); }
        }

        public List<SimpleMessage> Messages { get; set; }

        public bool Remove(SimpleMessage msg)
        {
            return Messages.Remove(msg);
        }

        public void AddMessage(SimpleMessage msg) // ajout pra
        {
            Messages.Add(msg);
        }

        public IEnumerable<SimpleMessage> GetMessages(string id)
        {
            return Messages.Where(m => m.Id == id);//.ToList();
        }

        //       [XmlIgnore]
        private string _name;
        //      [XmlElement]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }
        //    [XmlElement]
        public string ID
        {
            get;
            set;
        }


        private TimeExtent _visibleTimeExtent;

        // [XmlElement("VisibleTimeExtent", typeof(MyTimeExtent))]
        //    public MyTimeExtent VisibleTimeExtent { get; set; }
        public TimeExtent VisibleTimeExtent
        { //get; set; }
            get { return _visibleTimeExtent; }
            set
            {
                _visibleTimeExtent = value;
            }
        }



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //        XDocument data = new XDocument();//.Load(filename);
            XName missionPhase = XName.Get("MissionPhase");
            XName name = XName.Get("Name");
            XName id = XName.Get("ID");
            //   XName phaseList = XName.Get("PhaseList");
            XName visibleTimeExtent = XName.Get("VisibleTimeExtent");
            XName start = XName.Get("Start");
            XName end = XName.Get("End");
            //    XName persistentMessages = XName.Get("PersistentMessages");
            //        XName persistentMessage = XName.Get("PersistentMessage");
            //   MissionPhase tmpMP = new MissionPhase();

            XElement nodeThis = new XElement(missionPhase);
            nodeThis.Add(name, this.Name);
            nodeThis.Add(id, this.ID);
            XElement nodeVTE = new XElement(visibleTimeExtent);
            nodeVTE.Add(start, this.VisibleTimeExtent.StartTime);
            nodeVTE.Add(end, this.VisibleTimeExtent.EndTime);
            nodeThis.AddFirst(nodeVTE);

            string str = nodeThis.ToString();

            info.AddValue(str, null);


        }

        /*       protected MissionPhase(SerializationInfo serializationInfo, StreamingContext streamingContext)
               {
                   Name = (string)serializationInfo.GetValue("Name", typeof(string));
                   ID = (string)serializationInfo.GetValue("ID", typeof(string));
                   VisibleTimeExtent =(MyTimeExtent) serializationInfo.GetValue("VisibleTimeExtent", typeof(MyTimeExtent));
               }*/
    }

}
