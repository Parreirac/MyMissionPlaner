
using Esri.ArcGISRuntime.Geometry;
using MilitaryPlanner.Helpers;
using MyMissionPlaner.Models.NC1Components;
using NC1.Msg;
using NC1.Obj;
using NC1.Obj.tacarea;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;


/*
XBXmlEncoder encoder;
encoder = new XBXmlEncoder(fout, charset);
root.encodeDocument(encoder);
encoder.Close();*/
namespace MyMissionPlaner.Models
{

    public class NC1_MessageWrapper : Message
    {

        public BaseMessageType TrueNC1_Message { get; internal set; }

        static public NC1_MessageWrapper Create(XElement root)
        {
            try
            {

                string typeName = root.Name.LocalName;

                BaseMessageType obj = null;
                byte[] _bytes = Encoding/*.UTF8.*/.Unicode.GetBytes(root.ToString());
                MemoryStream _ss = new MemoryStream(_bytes);
                XmlTextReader xtr = new XmlTextReader(_ss);
                switch (typeName)
                {
                    case "NC1_MessageLibre":
                        NC1_MessageLibre_CC read_MessageLibre = new NC1_MessageLibre_CC();
                        read_MessageLibre.decodeDocument(xtr);
                        obj = new NC1_MessageLibre(read_MessageLibre.NC1_MessageLibre);
                        break;
                    case "NC1_BFT":
                        NC1_BFT_CC read_BFT = new NC1_BFT_CC();
                        read_BFT.decodeDocument(xtr);
                        obj = new NC1_BFT(read_BFT.NC1_BFT);
                        break;
                    case "NC1_STR":
                        NC1_STR_CC read_STR = new NC1_STR_CC();
                        read_STR.decodeDocument(xtr);
                        obj = new NC1_STR(read_STR.NC1_STR);
                        break;
                    case "NC1_OWNSITREP":
                        NC1_OWNSITREP_CC read_OWNSITREP = new NC1_OWNSITREP_CC();
                        read_OWNSITREP.decodeDocument(xtr);
                        obj = new NC1_OWNSITREP(read_OWNSITREP.NC1_OWNSITREP);
                        break;
                    case "NC1_ENSITREP":
                        NC1_ENSITREP_CC read_ENSITREP = new NC1_ENSITREP_CC();
                        read_ENSITREP.decodeDocument(xtr);
                        obj = new NC1_ENSITREP(read_ENSITREP.NC1_ENSITREP);
                        break;
                    case "NC1_EVENTREP":
                        NC1_EVENTREP_CC read_EVENTREP = new NC1_EVENTREP_CC();
                        read_EVENTREP.decodeDocument(xtr);
                        obj = new NC1_EVENTREP(read_EVENTREP.NC1_EVENTREP);
                        break;
                    default:
                        break;

                }



                /*   XNamespace xsiNamespace = XNamespace.Get("xsi");
                    XName xsiTypeName = xsiNamespace.GetName("type");
                    XName tName = XName.Get("type");
                    var NodesToChange = root.Descendants().Where(xe => xe.Attribute(tName) != null);

                    foreach (var v in NodesToChange)
                        v.SetAttributeValue(xsiTypeName, null);

                */
                //For now it seems to be a bug with the XmlSerializer generation using RefEmit. Leading to a System.PlatformNotSupportedException:
                //Compiling JScript/CSharp scripts is not supported.
                // XmlSerializer has a special mode in which the serializer would use reflection instead of RefEmit to do serialization.

                //           MethodInfo method = typeof(XmlSerializer).GetMethod("set_Mode", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                //          method.Invoke(null, new object[] { 1 });


                // Create an instance of the XmlSerializer class;
                // specify the type of object to be deserialized.


                //   MyXmlSerializer serializer = new MyXmlSerializer(typeof(IndividualType));
                //      FileStream fs = new FileStream("d:/toto.xml", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);  ;
                //    serializer.Serialize(fs, individualType);
                //     TextWriter text_writer = File.CreateText("d:/toto.xml");
                //      serializer.Serialize(text_writer, t);


                //     byte[] bytes = Encoding.UTF8./*.Unicode.*/GetBytes(root.ToString());
                /*    MemoryStream ss = new MemoryStream(bytes);

  //             Use the Deserialize method to restore the object's state with  data from the XML document. */
                //          BaseMessageType obj = (BaseMessageType)serializer.Deserialize(ss);
                //      var reader = XmlReader.Create(ss);


                if (obj != null)
                {
                    NC1_MessageWrapper msg = new NC1_MessageWrapper(obj.Id.ToString()) { TrueNC1_Message = obj };
                    if (msg.Init())
                    { }
                    return msg;
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    System.Diagnostics.Trace.WriteLine("NC1_MessageWrapper Create " + root.Name.LocalName + " er:" + ex.InnerException.ToString());// + obj.Name.LocalName);
                else
                    System.Diagnostics.Trace.WriteLine("NC1_MessageWrapper Create " + root.Name.LocalName);
            };
            return null;
        }

        NC1_MessageWrapper(String id) : base(id, false)
        { }

        // populates Base object (Message) with NC1 data return true if one submessage is created
        bool Init()
        {
            BaseMessageType trueMsg = TrueNC1_Message;

            List<BaseObjectType> objectsToHandle = new List<BaseObjectType> { };

            switch (trueMsg.GetType().Name)
            {

                // Init 
                case "NC1_InitOdb":
                    {
                        NC1_InitOdb msg = trueMsg as NC1_InitOdb;
                    }
                    break;
                case "NC1_ListeEquipementsRessources":
                    {
                        NC1_ListeEquipementsRessources msg = trueMsg as NC1_ListeEquipementsRessources;
                    }
                    break;

                // ordre
                case "nc1_opord":
                case "nc1_opord-ain":
                case "nc1_opord-alat":
                case "nc1_opord-gen":
                case "nc1_opord-log":
                case "nc1_opord-opsec":
                case "nc1_opord-rens":
                case "nc1_opord-roe":
                case "nc1_opord-sic":
                case "nc1_opord-mvt":
                case "nc1_opord-ge":
                case "nc1_conops":
                case "nc1_tactoap":
                case "nc1_technoap":
                case "nc1_boap":
                case "NC1_Apercu":
                    {
                        NC1_Apercu msg = trueMsg as NC1_Apercu;
                    }
                    break;

                case "NC1_Apercu3D":
                    {
                        NC1_Apercu3D msg = trueMsg as NC1_Apercu3D;
                    }
                    break;

                case "NC1_MessageLibre":
                    {
                        NC1_MessageLibre msg = trueMsg as NC1_MessageLibre;

                        if (msg.ObjectsGlobal/*.objectsGlobal */!= null)
                            objectsToHandle.AddRange(msg.ObjectsGlobal.Object_);

                        if (msg.Body != null)
                            foreach (var obj in msg.Body)
                                if (obj.Content != null && obj.Content.Objects != null)
                                    objectsToHandle.AddRange(obj.Content.Objects.Object_);
                    }

                    break;
                case "NC1_STR":
                    {
                        NC1_STR msg = trueMsg as NC1_STR;
                        if (msg.EnemyForcesSituation != null && msg.EnemyForcesSituation.Objects != null)
                            objectsToHandle.AddRange(msg.EnemyForcesSituation.Objects.Object_);
                        if (msg.Environment != null && msg.Environment.Objects != null)
                            objectsToHandle.AddRange(msg.Environment.Objects.Object_);
                        if (msg.OwnForcesSituation != null && msg.OwnForcesSituation.Objects != null)
                            objectsToHandle.AddRange(msg.OwnForcesSituation.Objects.Object_);
                    }
                    break;
                case "NC1_StAcmConduite":
                    {
                        NC1_StAcmConduite msg = trueMsg as NC1_StAcmConduite;

                        if (msg.TypedACMs != null)
                            foreach (var elem in msg.TypedACMs)
                                objectsToHandle.Add(elem.Acm);



                    }
                    break;




                case "nc1_objectivelist":
                case "nc1_firereport":
                case "nc1_igen":
                case "nc1_bda":
                case "nc1_callforfire":
                case "nc1_firecontrol":
                case "nc1_suppressionitsats":
                case "nc1_finalerteraideni":
                case "nc1_deployrep":
                case "nc1_annulertirinterdit":
                case "nc1_tirinterdit":
                case "nc1_cca-card":
                case "nc1_plandevol":
                case "nc1_helopsum":

                case "NC1_BFT":
                    {
                        NC1_BFT msg = trueMsg as NC1_BFT;
                        if (msg.Locations != null)
                            foreach (var obj in msg.Locations)//&& msg.locations.)
                            {
                                BaseObjectType objToAdd;
                                switch (obj.getWhichField())
                                {
                                    case NC1_BFT_ELEM_2_locations.Choice.track:
                                        objToAdd = obj.Track;
                                        break;


                                    case NC1_BFT_ELEM_2_locations.Choice.participant:
                                        objToAdd = obj.Participant;
                                        break;


                                    case NC1_BFT_ELEM_2_locations.Choice.None:
                                    default:
                                        objToAdd = null;
                                        break;
                                }
                                if (objToAdd != null)
                                    objectsToHandle.Add(objToAdd);


                            }
                    }
                    break;
                case "NC1_OWNSITREP":
                    {
                        NC1_OWNSITREP msg = trueMsg as NC1_OWNSITREP;
                        if (msg.OwnForcesTaskOrganizationAndPresence.Participant != null)
                            objectsToHandle.AddRange(msg.OwnForcesTaskOrganizationAndPresence.Participant);
                        if (msg.OwnForcesTaskOrganizationAndPresence.Track != null)
                            objectsToHandle.AddRange(msg.OwnForcesTaskOrganizationAndPresence.Track);
                        if (msg.OwnForcesTaskOrganizationAndPresence.Mission != null)
                            objectsToHandle.AddRange(msg.OwnForcesTaskOrganizationAndPresence.Mission);
                        if (msg.OwnForcesTaskOrganizationAndPresence.FriendlyUnit != null)
                            foreach (var el in msg.OwnForcesTaskOrganizationAndPresence.FriendlyUnit)
                            {
                                objectsToHandle.Add(el.Unit);
                                objectsToHandle.AddRange(el.EnemyUnit); // on pourrait tirer un trait ...
                            }

                        if (msg.ControlAndCoordinationMeans != null && msg.ControlAndCoordinationMeans.CoordinationMean != null)
                            objectsToHandle.AddRange(msg.ControlAndCoordinationMeans.CoordinationMean);


                    }
                    break;
                case "NC1_ENSITREP":
                    {
                        NC1_ENSITREP msg = trueMsg as NC1_ENSITREP;

                        if (msg.EnemyForces.Track != null)
                            objectsToHandle.AddRange(msg.EnemyForces.Track);

                        if (msg.EnemyForces.Mission != null)
                            objectsToHandle.AddRange(msg.EnemyForces.Mission);

                        if (msg.EnemyForces.EnemyUnit != null)
                            foreach (var el in msg.EnemyForces.EnemyUnit)
                            {
                                objectsToHandle.Add(el.Unit);
                                objectsToHandle.AddRange(el.AffectedFriendlyUnit); // on pourrait tirer un trait ...
                            }
                    }
                    break;
                case "NC1_EVENTREP":
                    {
                        NC1_EVENTREP msg = trueMsg as NC1_EVENTREP;
                        foreach (var evt in msg.EventReport)
                            objectsToHandle.Add(evt.Event_);

                    }
                    break;


                case "nc1_medevac-nine-line":
                case "nc1_eoincrep":
                    break;

                case "NC1_PRR":
                    {
                        NC1_PRR msg = trueMsg as NC1_PRR;
                    }
                    break;
                case "NC1_PEMA":
                    {
                        NC1_PEMA msg = trueMsg as NC1_PEMA;
                    }
                    break;
                case "NC1_INTREQ":
                    {
                        NC1_INTREQ msg = trueMsg as NC1_INTREQ;
                    }
                    break;

                case "NC1_INTREP":
                    {
                        NC1_INTREP msg = trueMsg as NC1_INTREP;
                        if (msg.IntelligenceReport != null && msg.IntelligenceReport.Report != null && msg.IntelligenceReport.Report.Objects.Object_ != null)
                            objectsToHandle.AddRange(msg.IntelligenceReport.Report.Objects.Object_);
                    }
                    break;
                case "NC1_INTSUM":
                    {
                        NC1_INTSUM msg = trueMsg as NC1_INTSUM;

                    }
                    break;


                case "NC1_SitObst":
                    {
                        NC1_SitObst msg = trueMsg as NC1_SitObst;

                        //       msg.ObstaclesAndWorks.BypassRoute // todo pra

                        if (msg.ObstaclesAndWorks.Facility != null)
                            objectsToHandle.AddRange(msg.ObstaclesAndWorks.Facility);

                        if (msg.ObstaclesAndWorks.GroundEntity != null)
                            objectsToHandle.AddRange(msg.ObstaclesAndWorks.GroundEntity);

                        if (msg.ObstaclesAndWorks.Obstacle != null)
                            objectsToHandle.AddRange(msg.ObstaclesAndWorks.Obstacle);

                    }
                    break;
                case "NC1_BARREP":
                    {
                        NC1_BARREP msg = trueMsg as NC1_BARREP;

                        if (msg.FriendlyObstacles.FriendlyObstacle != null)
                            objectsToHandle.AddRange(msg.FriendlyObstacles.FriendlyObstacle);


                    }
                    break;
                case "nc1_barreq":
                case "nc1_propositionplanobstacles":
                case "nc1_obsexord":
                case "nc1_engreccerep":
                case "nc1_engrecceord":

                case "nc1_admitexitrep":
                case "nc1_initmedrep":
                case "nc1_medsitrep":

                case "nc1_ewmsnsum":
                case "nc1_ewrtm":

                case "nc1_conarep":
                case "nc1_demalord":
                case "nc1_movorder":
                case "nc1_batrecevacreq":
                case "nc1_matdem":

                case "nc1_cbrn-1-bio":
                case "nc1_cbrn-1-chem":
                case "nc1_cbrn-3-bio":
                case "nc1_cbrn-3-chem":
                case "nc1_cbrn-4-bio":
                case "nc1_cbrn-4-chem":
                case "nc1_cbrn-5-bio":
                case "nc1_cbrn-5-chem":
                case "nc1_cbrn-cdr":
                case "nc1_cbrn-sitrep":
                    break;

                case "nc1_request":
                case "nc1_techstcupdate":
                    break;
                default:
                    break;

            }

            foreach (var nc1Object in objectsToHandle)
            {
                string id = null, name = null, symbolCode = "";
                NC1.Location.PointType point = null;
                NC1.Location.CircleType circle = null;
                NC1.Location.RectangleType rectangle = null;
                NC1.Location.PolylineType polyline = null;
                NC1.Location.PointType[] pointsmultiples = null;
                NC1.Location.PolygonType polygon = null;
                NC1.Location.EllipseType ellipse = null;
                NC1.Location.ArcbandType arcband = null;
                NC1.Location.ArrowType arrow = null;
                NC1.Location.MultipointType multipoint = null;
                NC1.Location.CorridorType corridor = null;
                NC1.Obj.acm.CorridorType corridor_acm = null;

                // Collect information for the sub Message

                switch (nc1Object.GetType().Name)
                {
                    case "UnitType":
                        var o_unit = nc1Object as NC1.Obj.unit.UnitType;
                        id = o_unit.Id;// obj.Attribute(idName).Value;
                        name = o_unit.TacticalData.Name;
                        symbolCode = o_unit.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_unit.Location.Point;
                        break;


                    case "AirParticipantType":
                        var o_ap = nc1Object as NC1.Obj.airparticipant.AirParticipantType;//.groundtrack.GroundTrackType;//.unit.UnitType;
                        id = o_ap.Id;// obj.Attribute(idName).Value;
                        name = o_ap.TacticalData.Name;
                        symbolCode = o_ap.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_ap.Location.Point;
                        break;
                    case "GroundParticipantType":
                        var o_gp = nc1Object as NC1.Obj.groundparticipant.GroundParticipantType;//.groundtrack.GroundTrackType;//.unit.UnitType;
                        id = o_gp.Id;// obj.Attribute(idName).Value;
                        name = o_gp.TacticalData.Name;
                        symbolCode = o_gp.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_gp.Location.Point;
                        break;

                    case "SeaParticipantType":
                        var o_sp = nc1Object as NC1.Obj.seaparticipant.SeaParticipantType;//.groundparticipant.GroundParticipantType;//.groundtrack.GroundTrackType;//.unit.UnitType;
                        id = o_sp.Id;// obj.Attribute(idName).Value;
                        name = o_sp.TacticalData.Name;
                        symbolCode = o_sp.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_sp.Location.Point;
                        break;

                    case "AirTrackType": // AirTrackType
                        var o_at = nc1Object as NC1.Obj.airtrack.AirTrackType;//.unit.UnitType;
                        id = o_at.Id;// obj.Attribute(idName).Value;
                        name = o_at.TacticalData.Name;
                        symbolCode = o_at.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_at.Location.Point;
                        break;                                      // 

                    case "SeaTrackType": // AirTrackType
                        var o_st = nc1Object as NC1.Obj.seatrack.SeaTrackType;//.unit.UnitType;
                        id = o_st.Id;// obj.Attribute(idName).Value;
                        name = o_st.TacticalData.Name;
                        symbolCode = o_st.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_st.Location.Point;
                        break;


                    case "GroundTrackType":
                        var o_gt = nc1Object as NC1.Obj.groundtrack.GroundTrackType;//.unit.UnitType;
                        id = o_gt.Id;// obj.Attribute(idName).Value;
                        name = o_gt.TacticalData.Name;
                        symbolCode = o_gt.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        point = o_gt.Location.Point;
                        break;
                    case "TacPointType":
                        var o_tp = nc1Object as NC1.Obj.tacpoint.TacPointType;//.tacarea.TacAreaType;//.Obj.unit.UnitType;
                        id = o_tp.Id;// obj.Attribute(idName).Value;
                        name = o_tp.TacticalData.Name;
                        symbolCode = o_tp.TacticalData.SymbolCode;
                        point = o_tp.Location.Point;
                        break;

                    case "EventType":
                        var o_etp = nc1Object as NC1.Obj._event.EventType;//.tacarea.TacAreaType;//.Obj.unit.UnitType;
                        id = o_etp.Id;// obj.Attribute(idName).Value;
                        name = o_etp.TacticalData.Name;
                        symbolCode = o_etp.TacticalData.SymbolCode;
                        point = o_etp.Location.Point;
                        break;
                    case "CbrnEventType":
                        var o_CBRN = nc1Object as NC1.Obj.cbrnevent.CbrnEventType;//.tacpoint.TacPointType;//.tacarea.TacAreaType;//.Obj.unit.UnitType;
                        id = o_CBRN.Id;
                        symbolCode = o_CBRN.TacticalData.SymbolCode;
                        if (o_CBRN.Foxtrot != null && o_CBRN.Foxtrot.IncidentLocation != null)
                        {
                            if (o_CBRN.Foxtrot.IncidentLocation.Length == 1)
                            {
                                name = o_CBRN.Foxtrot.IncidentLocation[0].Location.PlaceName;
                                point = o_CBRN.Foxtrot.IncidentLocation[0].Location.Point;
                            }

                            foreach (var elcbrn in o_CBRN.Foxtrot.IncidentLocation)  // TODO PRA a tester si plusieurs point 
                            {
                                //TODO PRA 
                            }

                        }


                        break;


                    case "MissionType":
                        var o_mission = nc1Object as NC1.Obj.mission.MissionType;
                        id = o_mission.Id;
                        name = o_mission.TacticalData.Name;
                        var typeM = o_mission.TacticalData.MissionType_5.getWhichField();
                        //   o_mission.TacticalData.ObjectiveLocalisedObjectId  //TODO PRA
                        switch (typeM)
                        {
                            case NC1.Obj.mission.MissionType_5.Choice.actionTask:
                                var action = o_mission.TacticalData.MissionType_5.ActionTask;
                                symbolCode = action.SymbolCode;
                                break;
                            case NC1.Obj.mission.MissionType_5.Choice.supportMission:
                                var action2 = o_mission.TacticalData.MissionType_5.SupportMission;
                                break;
                            case NC1.Obj.mission.MissionType_5.Choice.missionDescription:
                                var action3 = o_mission.TacticalData.MissionType_5.MissionDescription;
                                break;
                            case NC1.Obj.mission.MissionType_5.Choice.None:
                            default:
                                break;


                        }
                        break;

                    case "ObstacleType":
                        var o_bst = nc1Object as NC1.Obj.obstacle.ObstacleType;//.groundentity.GroundEntityType;
                        id = o_bst.Id;// obj.Attribute(idName).Value;
                        name = o_bst.TacticalData.Name;
                        symbolCode = o_bst.TacticalData.SymbolCode;
               
                        switch (o_bst.Location.ObstacleType_27.getWhichField())
                        {
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.point:
                                point = o_bst.Location.ObstacleType_27.Point;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.multipoint:
                                multipoint = o_bst.Location.ObstacleType_27.Multipoint;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.polyline:
                                polyline = o_bst.Location.ObstacleType_27.Polyline;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.polygon:
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.circle:
                                circle = o_bst.Location.ObstacleType_27.Circle;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.ellipse:
                                ellipse = o_bst.Location.ObstacleType_27.Ellipse;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.arcband:
                                arcband = o_bst.Location.ObstacleType_27.Arcband;
                                break;
                            case NC1.Obj.obstacle.ObstacleType_27.Choice.None:
                            default:
                                break;

                }

                        break;


                    case "GroundEntityType":
                        var o_ge = nc1Object as NC1.Obj.groundentity.GroundEntityType;
                        id = o_ge.Id;
                        name = o_ge.TacticalData.Name;

                        switch (o_ge.Location.GroundEntityType_4.getWhichField())
                        {
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.point:
                                point = o_ge.Location.GroundEntityType_4.Point;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.polyline:
                                polyline = o_ge.Location.GroundEntityType_4.Polyline;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.polygon:
                                polygon = o_ge.Location.GroundEntityType_4.Polygon;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.circle:
                                circle = o_ge.Location.GroundEntityType_4.Circle;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.ellipse:
                                ellipse = o_ge.Location.GroundEntityType_4.Ellipse;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.arcband:
                                arcband = o_ge.Location.GroundEntityType_4.Arcband;
                                break;
                            case NC1.Obj.groundentity.GroundEntityType_4.Choice.None:
                            default:
                                break;

                        }


                        break;


                    case "TacAreaType":
                        var o_ta = nc1Object as NC1.Obj.tacarea.TacAreaType;//.Obj.unit.UnitType;
                        id = o_ta.Id;// obj.Attribute(idName).Value;
                        name = o_ta.TacticalData.Name;
                        symbolCode = o_ta.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                        var loc_ta = o_ta.Location.TacAreaType_15;
                        var type = loc_ta.getWhichField();
                        switch (type)
                        {
                            case TacAreaType_15.Choice.arrow:
                                arrow = loc_ta.Arrow;
                                break;
                            case TacAreaType_15.Choice.arcband:
                                arcband = loc_ta.Arcband;
                                break;
                            case TacAreaType_15.Choice.circle:
                                circle = loc_ta.Circle;
                                break;
                            case TacAreaType_15.Choice.ellipse:
                                ellipse = loc_ta.Ellipse;
                                break;
                            case TacAreaType_15.Choice.multipoint:
                                multipoint = loc_ta.Multipoint;
                                break;
                            case TacAreaType_15.Choice.polygon:
                                polygon = loc_ta.Polygon;
                                break;
                            case TacAreaType_15.Choice.None:
                            default:
                                break;

                        }


                        break;

                    case "FacilityType":
                        var o_ft = nc1Object as NC1.Obj.facility.FacilityType;//.unit.UnitType;
                        id = o_ft.Id;// obj.Attribute(idName).Value;
                        name = o_ft.TacticalData.Name;
                        //o_ft.TacticalData.AchievementStatus // TODO PRA 
                        symbolCode = o_ft.TacticalData.SymbolCode;
                        //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???

                        if (o_ft.Location != null && o_ft.Location.FacilityType_45 != null)
                        {

                            switch (o_ft.Location.FacilityType_45.getWhichField())
                            {
                                case NC1.Obj.facility.FacilityType_45.Choice.point:
                                    point = o_ft.Location.FacilityType_45.Point;

                                    break;
                                case NC1.Obj.facility.FacilityType_45.Choice.multipoint:
                                    multipoint = o_ft.Location.FacilityType_45.Multipoint;
                                    break;
                                case NC1.Obj.facility.FacilityType_45.Choice.None:
                                default:
                                    break;

                            }

                        }

                        // TODO PRA on a d'autre données.


                        break;

                    case "TacLineType":
                        var o_tl = nc1Object as NC1.Obj.tacline.TacLineType;//.tacarea.TacAreaType;//.Obj.unit.UnitType;
                        break;


                    case "FireType":
                        var o_f = nc1Object as NC1.Obj.fire.FireType;//.tacline.TacLineType;

                        // o_f .ExecutiveReport.First().ShotLine  // TODO PRA 
                        //     o_f .CallForFireData.
                        break;

                    case "FireObjectiveType":

                        var o_fo = nc1Object as NC1.Obj.fireobjective.FireObjectiveType;
                        id = o_fo.Id;// obj.Attribute(idName).Value;
                        name = o_fo.TacticalData.Name;
                        //   symbolCode = o_fo.TacticalData.SymbolCode;
                        var loc_fo = o_fo.Location.FireObjectiveType_19;

                        var type1 = loc_fo.getWhichField();
                        switch (type1)
                        {
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.point:
                                point = loc_fo.Point;
                                break;
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.circle:
                                circle = loc_fo.Circle;
                                break;
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.rectangle:
                                rectangle = loc_fo.Rectangle;
                                break;
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.pointsMultiples:
                                pointsmultiples = loc_fo.PointsMultiples;
                                break;
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.polyline:
                                polyline = loc_fo.Polyline;
                                break;
                            case NC1.Obj.fireobjective.FireObjectiveType_19.Choice.None:
                            default:
                                break;
                        }
                        break;


                    case "FreeShapeType":
                        var o_fs = nc1Object as NC1.Obj.freeshape.FreeShapeType;
                        id = o_fs.Id;// obj.Attribute(idName).Value;
                        name = o_fs.TacticalData.Name;

                        //     o_fs.TacticalData.Style;
                        switch (o_fs.Location.FreeShapeType_23.getWhichField())
                        {
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.point:
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.polyline:
                                polyline = o_fs.Location.FreeShapeType_23.Polyline;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.polygon:
                                polygon = o_fs.Location.FreeShapeType_23.Polygon;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.rectangle:
                                rectangle = o_fs.Location.FreeShapeType_23.Rectangle;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.circle:
                                circle = o_fs.Location.FreeShapeType_23.Circle;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.ellipse:
                                ellipse = o_fs.Location.FreeShapeType_23.Ellipse;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.arcband:
                                arcband = o_fs.Location.FreeShapeType_23.Arcband;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.corridor:
                                corridor = o_fs.Location.FreeShapeType_23.Corridor;
                                break;
                            case NC1.Obj.freeshape.FreeShapeType_23.Choice.None:
                            default:
                                break;



                        }
                        break;

                    case "OrganisationType":
                        var o_ot = nc1Object as NC1.Obj.organisation.OrganisationType;
                        id = o_ot.Id;
                        point = o_ot.Location.Point;
                        name = o_ot.TacticalData.Name;
                        //                 o_ot.TacticalData.OrganisationType_9.getWhichField() // =>     None, civilianOrganisationType, militaryOrganisationType

                        break;
                    case "IndividualType":
                        {
                            var o_it = nc1Object as NC1.Obj.individual.IndividualType;//.groundtrack.GroundTrackType;//.unit.UnitType;
                            id = o_it.Id;// obj.Attribute(idName).Value;
                            name = o_it.TacticalData.Name;
                            symbolCode = o_it.TacticalData.SymbolCode;
                            //o_unit.TacticalData.FrSpecificSymbol;// TODO PRA ???
                            switch (o_it.Location.IndividualType_57.getWhichField())  //.Point;
                            {
                                case NC1.Obj.individual.IndividualType_57.Choice.ellipse:
                                    ellipse = o_it.Location.IndividualType_57.Ellipse;
                                    break;
                                case NC1.Obj.individual.IndividualType_57.Choice.polygon:
                                    polygon = o_it.Location.IndividualType_57.Polygon;
                                    break;
                                case NC1.Obj.individual.IndividualType_57.Choice.circle:
                                    circle = o_it.Location.IndividualType_57.Circle;
                                    break;
                                case NC1.Obj.individual.IndividualType_57.Choice.arcband:
                                    arcband = o_it.Location.IndividualType_57.Arcband;
                                    break;
                                case NC1.Obj.individual.IndividualType_57.Choice.point:
                                    point = o_it.Location.IndividualType_57.Point;
                                    break;
                                case NC1.Obj.individual.IndividualType_57.Choice.None:

                                default:
                                    break;

                            }


                        }
                        break;


                    case "AcmWezType":
                        var o_acm = nc1Object as NC1.Obj.acm.AcmWezType;
                        id = o_acm.Id;
                        o_acm.Location.AcmWezType_19.getWhichField();
                        switch (o_acm.Location.AcmWezType_19.getWhichField())  //.Point;
                        {
                            case  NC1.Obj.acm.AcmWezType_19.Choice.point:
                                point = o_acm.Location.AcmWezType_19.Point;
                                    break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.polyline:
                                polyline = o_acm.Location.AcmWezType_19.Polyline;
                                    break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.polygon:
                                polygon = o_acm.Location.AcmWezType_19.Polygon;
                                break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.circle:
                                circle = o_acm.Location.AcmWezType_19.Circle;
                                    break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.arcband:
                                arcband = o_acm.Location.AcmWezType_19.Arcband;
                                    break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.corridor:
                                // corridor =
                                corridor_acm = o_acm.Location.AcmWezType_19.Corridor;
                                break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.polyarc: // TODO PRA 
                                    break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.aorbit: // TODO PRA 
                                break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.airtrack:// TODO PRA 
                                break;
                            case  NC1.Obj.acm.AcmWezType_19.Choice.None:
                                    default:
                                break;


                        }

                        break;

                    default:
                        break;

                }


                System.Diagnostics.Trace.WriteLine("##NC1_init du message pour l'objet " + id);

                if (id == "13:9999:119")
                    id.IsNormalized();


                // TODO PRA : on pourrait de meme tout mettre ...

                //    foreach (XAttribute attr in obj.Attributes()) // dont type qui est le type d'objet et l'id NC1
                //        if (attr.Name != idName)
                //            smes.Add(attr.Name.LocalName, attr.Value);

                var tab = symbolCode.Split(':');
                //this._graphicalChart = tab[0];        // TODO PRA ?            

                string sc = tab.Length > 1 ? tab[1] : "";
                // handle data
                var sm = CreateSubMessageForNC1(id, name, sc, point);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, circle);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, rectangle);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, polyline);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, pointsmultiples);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, polygon);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, ellipse);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, arcband);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, arrow);
                if (sm == null)
                    sm = CreateSubMessageForNC1(id, name, sc, corridor);

                if (sm != null)
                    AddSimpleMessage(sm);
                else
                { }// TODO PRA y en a plein !!
            }


            //-----

            return objectsToHandle != null && objectsToHandle.Any();
        }

        private SimpleMessage CreateSubMessageForNC1(string id, string name, string symbolCode, object geometry)
        {
            if (geometry == null)
                return null;

            SpatialReference sr = SpatialReference.Create(int.Parse("4326"));
            var vu = sr.VerticalUnit;

            Geometry esryGeometry = null;

            switch (geometry.GetType().Name)
            {
                case "PointType":
                    NC1.Location.PointType geometry_p = geometry as NC1.Location.PointType;
                    //   CultureInfo cif = new CultureInfo("en-US");
                    esryGeometry = new MapPoint(((double)geometry_p.X), (double)geometry_p.Y, (double)geometry_p.Z, sr); // TODO PRA mettre SR partout !
                    break;
                case "CircleType":
                    NC1.Location.CircleType geometry_c = geometry as NC1.Location.CircleType;
                    // TODO PRA : pb sur l'unité de mesure en NC1 on est en mettre wgs94 sauf pour l'ALAT ou c'est au dessus du sol
                    var pn = new MapPoint(((double)geometry_c.Center.X), (double)geometry_c.Center.Y, (double)geometry_c.Center.Z, sr);
                    PolygonBuilder plcircleBuilder = new PolygonBuilder(sr);
                    /*       List<MapPoint> bufferMapPoints = new List<MapPoint>();
                            bufferMapPoints.Add(pn);
                            List<double> bufferDistances = new List<double>();
                            double bufferDistance = geometry_c.Radius * .001;// LinearUnits.Miles.ConvertTo(LinearUnits.Feet, bufferDistanceMiles);
                            bufferDistances.Add(bufferDistance);
                            IEnumerable<Geometry> bufferPolygons = GeometryEngine.Buffer(bufferMapPoints, bufferDistances, false);  

                            // Use a helper method to get the buffer distance in feet (unit that's used by the spatial reference).
                            // mais wgs84 n'en n'a pas !

                            //     string position = geometry_c.Center.Y.ToString() + "* | " + geometry_c.Center.X.ToString() + "*";
                            //        MapPoint point2 = CoordinateFormatter.FromLatitudeLongitude(position, sr);

                            EnvelopeBuilder myEnvelopeBuilder = new EnvelopeBuilder(SpatialReferences.Wgs84);
                            esryGeometry = bufferPolygons.First();*/


                    MapPoint center_ell = new MapPoint((double)geometry_c.Center.X, (double)geometry_c.Center.Y, (double)geometry_c.Center.Z, sr);

                    string centerUTM = CoordinateFormatter.ToUtm(center_ell, UtmConversionMode.NorthSouthIndicators, true);
                    // => 30N 489884 6199881
                    string[] centerUTM_split = centerUTM.Split(' ');
                    double x = double.Parse(centerUTM_split[1]);
                    double y = double.Parse(centerUTM_split[2]);

                    for (int i = 0; i < Constants._numPointForEllipse; i++) // each (var pt in geometry_p2t.Point)
                    {
                        double xx, yy;
                        xx = x + geometry_c.Radius * Math.Cos(((double)i) * 2.0 * Math.PI / ((double)Constants._numPointForEllipse));
                        yy = y + geometry_c.Radius * Math.Sin(((double)i) * 2.0 * Math.PI / ((double)Constants._numPointForEllipse));

                        string newPointUtm = centerUTM_split[0] + " " + (Math.Round(xx)).ToString() + " " + (Math.Round(yy)).ToString();
                        MapPoint newPoint = CoordinateFormatter.FromUtm(newPointUtm, sr, UtmConversionMode.NorthSouthIndicators);
                        //   newPoint.Z = geometry_ell.Center.Z;

                        plcircleBuilder.AddPoint(new MapPoint((double)newPoint.X, (double)newPoint.Y, (double)center_ell.Z));
                    }


                    // Esri.ArcGISRuntime.Symbology.SimpleMarkerSymbol
                    //var ell= new EllipticArcSegment(pn, pn, 0.0, true, true, geometry_c.Radius, geometry_c.Radius, sr);

                    //        esryGeometry = 

                    break;
                case "RectangleType":
                    NC1.Location.RectangleType geometry_rt = geometry as NC1.Location.RectangleType;//.CircleType;
                                                                                                    //    geometry_rt.
                                                                                                    //     PolylineBuilder plBuilder = new PolylineBuilder(sr);
                                                                                                    //     foreach (var pt in geometry_pt.Point)
                                                                                                    //         plBuilder.AddPoint(new MapPoint((double)pt.X, (double)pt.Y, (double)pt.Z));

                    //     esryGeometry = plBuilder.ToGeometry();
                    break;
                case "PolylineType":

                    NC1.Location.PolylineType geometry_pt = geometry as NC1.Location.PolylineType;//.CircleType;
                    PolylineBuilder plBuilder = new PolylineBuilder(sr);
                    foreach (var pt in geometry_pt.Point)
                        plBuilder.AddPoint(new MapPoint((double)pt.X, (double)pt.Y, (double)pt.Z));

                    esryGeometry = plBuilder.ToGeometry();

                    break;
                case "PolygonType":

                    NC1.Location.PolygonType geometry_p2t = geometry as NC1.Location.PolygonType;//.PolylineType;//.CircleType;
                    // TODO PRA : pb sur l'unité de mesure en NC1 on est en mettre wgs94 sauf pour l'ALAT ou c'est au dessus du sol
                    PolygonBuilder pl2Builder = new PolygonBuilder(sr);
                    foreach (var pt in geometry_p2t.Point)
                        pl2Builder.AddPoint(new MapPoint((double)pt.X, (double)pt.Y, (double)pt.Z));

                    esryGeometry = pl2Builder.ToGeometry();
                    break;
                case "EllipseType":
                    NC1.Location.EllipseType geometry_ell = geometry as NC1.Location.EllipseType;
                    // TODO PRA : pb sur l'unité de mesure en NC1 on est en mettre wgs94 sauf pour l'ALAT ou c'est au dessus du sol
                    PolygonBuilder pl3Builder = new PolygonBuilder(sr);
                    /*                  geometry_ell.Center;
                                      geometry_ell.MinRadius;//.Center;
                                      geometry_ell.MaxRadius;
                                      geometry_ell.Orientation;   */

                    MapPoint center_cir = new MapPoint((double)geometry_ell.Center.X, (double)geometry_ell.Center.Y, (double)geometry_ell.Center.Z, sr);

                    string centerUTM2 = CoordinateFormatter.ToUtm(center_cir, UtmConversionMode.NorthSouthIndicators, true);
                    // => 30N 489884 6199881
                    string[] centerUTM_split2 = centerUTM2.Split(' ');
                    double xc = double.Parse(centerUTM_split2[1]);
                    double yc = double.Parse(centerUTM_split2[2]);

                    double ax, ay, bx, by, theta;
                    theta = geometry_ell.Orientation* Math.PI / 180.0;

                    ax = geometry_ell.MaxRadius * Math.Cos(theta);
                    ay = geometry_ell.MaxRadius * Math.Sin(theta);

                    bx = - geometry_ell.MinRadius * Math.Sin(theta);
                    by = geometry_ell.MinRadius * Math.Cos(theta);

                    for (int i = 0; i < Constants._numPointForEllipse; i++) // each (var pt in geometry_p2t.Point)
                    {
                        double xx, yy;

                        double t = ((double)i) * 2.0 * Math.PI / ((double)Constants._numPointForEllipse);

                        xx = xc + ax * Math.Cos(t) + bx * Math.Sin(t);
                        yy = yc + ay * Math.Cos(t) + by * Math.Sin(t);
                       
                        string newPointUtm = centerUTM_split2[0] + " " + (Math.Round(xx)).ToString() + " " + (Math.Round(yy)).ToString();
                        MapPoint newPoint = CoordinateFormatter.FromUtm(newPointUtm, sr, UtmConversionMode.NorthSouthIndicators);
                        //   newPoint.Z = geometry_ell.Center.Z;

                        pl3Builder.AddPoint(new MapPoint((double)newPoint.X, (double)newPoint.Y, (double)center_cir.Z));
                    }

                    esryGeometry = pl3Builder.ToGeometry();


                    break;
                case "ArrowType":
                    break;
                case "PointType[]":
                    break;
                case "ArcbandType":
                    break;

                default:
                    break;

                    //                    NC1.Location.PointType[] pointsmultiples = null;  // esri PointCollection 


            }

            var m = new SimpleMessage(id)
            {
                symbolProperties = new SymbolProperties() { Name = name, SymbolID = symbolCode },
                SymbolGeometry = esryGeometry
            };

            return m;
        }


    }
    public class NC1_Message : Message
    {
        //        Dictionary<string, string> _metaData = new Dictionary<string, string>();
        // objectsGlobal mais a priori ne sert à rien !
        // todo PRA les effacer de header ?
        //     Dictionary<string, string> _header = new Dictionary<string, string>();

        //List<XElement> _body = new List<XElement>();

        public NC1_Message(String id) : base(id, false)
        { }


        //      public List<XElement> MixedTexts { get; internal set; }
        //      public List<XElement> Objects { get; internal set; }



    }

}
