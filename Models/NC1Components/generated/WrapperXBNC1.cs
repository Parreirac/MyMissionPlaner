
using com.objsys.xbinder.runtime;
using NC1.Msg; // TODO pra pourquoi si large ?
using System.Collections.Generic;

namespace MyMissionPlaner.Models.NC1Components
{
    public class NC1_STR : NC1_STR_ELEM
    {
        public NC1_STR(NC1_STR_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            Comment = source.Comment;


            try
            {
                ExtFunction = source.ExtFunction;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ExtVersion = source.ExtVersion;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }

            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;

            try
            {
                ReferenceMessageId = source.ReferenceMessageId;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)

            }
            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;

            OwnForcesSituation = source.OwnForcesSituation;
            EnemyForcesSituation = source.EnemyForcesSituation;
            Environment = source.Environment;
        }
    }

    public class NC1_StAcmConduite : NC1_StAcmConduite_ELEM { }

    public class NC1_OWNSITREP : NC1_OWNSITREP_ELEM
    {
        public NC1_OWNSITREP(NC1_OWNSITREP_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            Comment = source.Comment;
            try
            {
                ExtFunction = source.ExtFunction;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ExtVersion = source.ExtVersion;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ReferenceMessageId = source.ReferenceMessageId;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;


            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;

            ControlAndCoordinationLinesAssessment = source.ControlAndCoordinationLinesAssessment;
            ControlAndCoordinationMeans = source.ControlAndCoordinationMeans;
            OwnForcesAssessment = source.OwnForcesAssessment;
            OwnForcesTaskOrganizationAndPresence = source.OwnForcesTaskOrganizationAndPresence;
        }

    }

    public class NC1_ENSITREP : NC1_ENSITREP_ELEM
    {
        public NC1_ENSITREP(NC1_ENSITREP_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            Comment = source.Comment;
            //         ExtFunction = source.ExtFunction;  // TODO PRA 
            //       ExtVersion = source.ExtVersion;
            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;
            //     ReferenceMessageId = source.ReferenceMessageId;
            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;

            Assessment = source.Assessment;
            ControlAndCoordinationMeans = source.ControlAndCoordinationMeans;
            EnemyForces = source.EnemyForces;

        }

    }


    public class NC1_MessageLibre : NC1_MessageLibre_ELEM
    {
        public NC1_MessageLibre(NC1_MessageLibre_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            //      Comment = source.Comment;  // pas de commentaire dans un messageLibre
            try
            {
                ExtFunction = source.ExtFunction;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ExtVersion = source.ExtVersion;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ReferenceMessageId = source.ReferenceMessageId;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;
            //   ReferenceMessageId = source.ReferenceMessageId;
            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;

            body = source.Body;

            /*this.body source.Body.CopyTo(body,0);=*/
            IsTemplate = source.IsTemplate;
            Subject = source.Subject;
            Nature = source.Nature;

            try
            {
                ObjectsGlobal = source.ObjectsGlobal;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                ObjectsGlobal = new NC1_MessageLibre_ELEM_2_objectsGlobal();
            //    ObjectsGlobal.Object_. = new List<NC1.Obj.BaseObjectType>();

    //            if (xbe.Message != "field referenceMessageId not set") 
    // TODO PRA faire qq chose !
    //           if (xbe.)
            }

            Type = source.Type;

        }
    }

    public class NC1_ListeEquipementsRessources : NC1_ListeEquipementsRessources_ELEM { }
    public class NC1_INTSUM : NC1_INTSUM_ELEM { }
    public class NC1_SitObst : NC1_SitObst_ELEM { }
    public class NC1_INTREQ : NC1_INTREQ_ELEM { }
    public class NC1_Apercu : NC1_Apercu_ELEM { }
    public class NC1_INTREP : NC1_INTREP_ELEM { }
    public class NC1_InitOdb : NC1_InitOdb_ELEM { }
    public class NC1_EVENTREP : NC1_EVENTREP_ELEM
    {
        public NC1_EVENTREP(NC1_EVENTREP_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            Comment = source.Comment;
            try
            {
                ExtFunction = source.ExtFunction;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ExtVersion = source.ExtVersion;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ReferenceMessageId = source.ReferenceMessageId;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;
            //    ReferenceMessageId = source.ReferenceMessageId;
            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;

            eventReport = source.EventReport;
        }


    }
    public class NC1_BFT : NC1_BFT_ELEM
    {
        public NC1_BFT(NC1_BFT_ELEM source) : base()
        {
            Id = source.Id;
            LastChangeDatetime = source.LastChangeDatetime;
            Classification = source.Classification;
            Comment = source.Comment;
            try
            {
                ExtFunction = source.ExtFunction;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ExtVersion = source.ExtVersion;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            try
            {
                ReferenceMessageId = source.ReferenceMessageId;
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }
            MajorVersion = source.MajorVersion;
            MinorVersion = source.MinorVersion;
            MediumVersion = source.MediumVersion;
            //    ReferenceMessageId = source.ReferenceMessageId;
            Situation = source.Situation;
            UrgencyLevel = source.UrgencyLevel;
            try
            {
                foreach (var elemen in source.Locations)
                    Locations.Add(elemen);
            }
            catch (XBException xbe)//      ("field referenceMessageId not set"))
            {
                //           if (xbe.)
            }

        }

    }
    public class NC1_BARREP : NC1_BARREP_ELEM { }
    public class NC1_Apercu3D : NC1_Apercu3D_ELEM { }
    public class NC1_PRR : NC1_PRR_ELEM { }
    public class NC1_PEMA : NC1_PEMA_ELEM { }
}