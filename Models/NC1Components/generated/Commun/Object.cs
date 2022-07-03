using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Obj {

   using System.IO;
   using System.Xml;

    using ParticipantType = NC1.Participant.ParticipantType;
    using TrackType = NC1.Tracks.TrackType;
    using UnitType = NC1.Obj.unit.UnitType;
    using FireObjectiveType = NC1.Obj.fireobjective.FireObjectiveType;
    using CbrnEventType = NC1.Obj.cbrnevent.CbrnEventType;
    using FreeShapeType = NC1.Obj.freeshape.FreeShapeType;
    using EventType = NC1.Obj._event.EventType;
    using FacilityType = NC1.Obj.facility.FacilityType;
    using FireType = NC1.Obj.fire.FireType;
    using GroundEntityType = NC1.Obj.groundentity.GroundEntityType;
    using _3DRouteType = NC1.Obj._3droute._3DRouteType;
    using _2DCoordinationMeanType = NC1.Obj._2dcoordinationmean._2DCoordinationMeanType;
    using TacPointType = NC1.Obj.tacpoint.TacPointType;
    using TacLineType = NC1.Obj.tacline.TacLineType;
    using TacAreaType = NC1.Obj.tacarea.TacAreaType;
    using SeaParticipantType = NC1.Obj.seaparticipant.SeaParticipantType;
    using RouteType = NC1.Obj.route.RouteType;
    using ReinforcementType = NC1.Obj.reinforcement.ReinforcementType;
    using RoeType = NC1.Obj.roe.RoeType;
    using OrganisationType = NC1.Obj.organisation.OrganisationType;
    using ObstacleType = NC1.Obj.obstacle.ObstacleType;
    using MissionType = NC1.Obj.mission.MissionType;
    using MissionASSType = NC1.Obj.missionASS.MissionASSType;
    using MissionASAType = NC1.Obj.missionASA.MissionASAType;
    using MeteoType = NC1.Obj.meteo.MeteoType;
    using IntelRequirementType = NC1.Obj.intelrequirement.IntelRequirementType;
    using IndividualType = NC1.Obj.individual.IndividualType;
    using IffProcedureType = NC1.Obj.iffprocedure.IffProcedureType;
    using GroundTrackType = NC1.Obj.groundtrack.GroundTrackType;
    using GroundParticipantType = NC1.Obj.groundparticipant.GroundParticipantType;
    using AirTrackType = NC1.Obj.airtrack.AirTrackType;
    using AcmWezType = NC1.Obj.acm.AcmWezType;
    using AirParticipantType = NC1.Obj.airparticipant.AirParticipantType;
    using ConvoyType = NC1.Obj.convoy.ConvoyType;
    using SeaTrackType = NC1.Obj.seatrack.SeaTrackType;

    public class ActivationStatusCode
   {
      static ActivationStatusCode() {
         XBUtil.license =  _Object.license;
      }

      //constructor
      private ActivationStatusCode() {} 


      public static String encode(int value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static int decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         int value = 0;
         value = XBSimpleType.parseInt32(text);
         return value;
      }
   }

   public class IsFullCode
   {
      static IsFullCode() {
         XBUtil.license =  _Object.license;
      }

      //constructor
      private IsFullCode() {} 


      public static String encode(int value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static int decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         int value = 0;
         value = XBSimpleType.parseInt32(text);
         return value;
      }
   }

   public class BaseObjectType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:object",
          "BaseObjectType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","extVersion"),
         new XBQualifiedName("","extFunction")
      };
      static BaseObjectType() {
         XBUtil.license =  _Object.license;
      }


      /**
       * Factory method
       */
      public static new  BaseObjectType createObject(XBQualifiedName type) 
      {
         if ( type == null || type.equals( BaseObjectType.XSD_TYPE ) ) 
            return new  BaseObjectType();
         else if ( type.equals( LocalisedObjectType.XSD_TYPE) ) 
            return new  LocalisedObjectType();
         else if ( type.equals( _2DCoordinationMeanType.XSD_TYPE) ) 
            return new  _2DCoordinationMeanType();
         else if ( type.equals( TacAreaType.XSD_TYPE) ) 
            return new  TacAreaType();
         else if ( type.equals( TacLineType.XSD_TYPE) ) 
            return new  TacLineType();
         else if ( type.equals( TacPointType.XSD_TYPE) ) 
            return new  TacPointType();
         else if ( type.equals( PhysicalObjectType.XSD_TYPE) ) 
            return new  PhysicalObjectType();
         else if ( type.equals( AgentType.XSD_TYPE) ) 
            return new  AgentType();
         else if ( type.equals( IndividualType.XSD_TYPE) ) 
            return new  IndividualType();
         else if ( type.equals( OrganisationType.XSD_TYPE) ) 
            return new  OrganisationType();
         else if ( type.equals( UnitType.XSD_TYPE) ) 
            return new  UnitType();
         else if ( type.equals( ParticipantType.XSD_TYPE) ) 
            return new  ParticipantType();
         else if ( type.equals( AirParticipantType.XSD_TYPE) ) 
            return new  AirParticipantType();
         else if ( type.equals( GroundParticipantType.XSD_TYPE) ) 
            return new  GroundParticipantType();
         else if ( type.equals( SeaParticipantType.XSD_TYPE) ) 
            return new  SeaParticipantType();
         else if ( type.equals( TrackType.XSD_TYPE) ) 
            return new  TrackType();
         else if ( type.equals( AirTrackType.XSD_TYPE) ) 
            return new  AirTrackType();
         else if ( type.equals( GroundTrackType.XSD_TYPE) ) 
            return new  GroundTrackType();
         else if ( type.equals( SeaTrackType.XSD_TYPE) ) 
            return new  SeaTrackType();
         else if ( type.equals( ConvoyType.XSD_TYPE) ) 
            return new  ConvoyType();
         else if ( type.equals( FacilityType.XSD_TYPE) ) 
            return new  FacilityType();
         else if ( type.equals( GroundEntityType.XSD_TYPE) ) 
            return new  GroundEntityType();
         else if ( type.equals( ObstacleType.XSD_TYPE) ) 
            return new  ObstacleType();
         else if ( type.equals( _3DRouteType.XSD_TYPE) ) 
            return new  _3DRouteType();
         else if ( type.equals( AcmWezType.XSD_TYPE) ) 
            return new  AcmWezType();
         else if ( type.equals( CbrnEventType.XSD_TYPE) ) 
            return new  CbrnEventType();
         else if ( type.equals( EventType.XSD_TYPE) ) 
            return new  EventType();
         else if ( type.equals( FireType.XSD_TYPE) ) 
            return new  FireType();
         else if ( type.equals( FireObjectiveType.XSD_TYPE) ) 
            return new  FireObjectiveType();
         else if ( type.equals( FreeShapeType.XSD_TYPE) ) 
            return new  FreeShapeType();
         else if ( type.equals( IffProcedureType.XSD_TYPE) ) 
            return new  IffProcedureType();
         else if ( type.equals( IntelRequirementType.XSD_TYPE) ) 
            return new  IntelRequirementType();
         else if ( type.equals( MeteoType.XSD_TYPE) ) 
            return new  MeteoType();
         else if ( type.equals( RouteType.XSD_TYPE) ) 
            return new  RouteType();
         else if ( type.equals( MissionType.XSD_TYPE) ) 
            return new  MissionType();
         else if ( type.equals( MissionASAType.XSD_TYPE) ) 
            return new  MissionASAType();
         else if ( type.equals( MissionASSType.XSD_TYPE) ) 
            return new  MissionASSType();
         else if ( type.equals( ReinforcementType.XSD_TYPE) ) 
            return new  ReinforcementType();
         else if ( type.equals( RoeType.XSD_TYPE) ) 
            return new  RoeType();
         else throw new XBValidationException("unknown type:" + type);
      }

      //attribute fields
      protected string activationChangeDatetime;
      protected int activationStatus;
      protected string id;
      protected string instance;
      protected bool _set_instance = false;
      protected int isFull;
      protected string lastChangeDatetime;
      protected byte majorVersion;
      protected byte mediumVersion;
      protected byte minorVersion;

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  ExtVersType extVersion;   //optional
      protected  ExtFunctType extFunction;   //optional

      //attribute methods

      public string ActivationChangeDatetime
      {
         get { return this.activationChangeDatetime; }
         set { this.activationChangeDatetime = value; }
      }

      public int ActivationStatus
      {
         get { return this.activationStatus; }
         set { this.activationStatus = value; }
      }

      public string Id
      {
         get { return this.id; }
         set { this.id = value; }
      }

      public string Instance
      {
         get
         {
            if (!_set_instance)
                throw new XBException("field instance not set");

            return this.instance;
         }
         set
         {
            this.instance = value;
            _set_instance = true;
         }
      }

      public int IsFull
      {
         get { return this.isFull; }
         set { this.isFull = value; }
      }

      public string LastChangeDatetime
      {
         get { return this.lastChangeDatetime; }
         set { this.lastChangeDatetime = value; }
      }

      public byte MajorVersion
      {
         get { return this.majorVersion; }
         set { this.majorVersion = value; }
      }

      public byte MediumVersion
      {
         get { return this.mediumVersion; }
         set { this.mediumVersion = value; }
      }

      public byte MinorVersion
      {
         get { return this.minorVersion; }
         set { this.minorVersion = value; }
      }

      //content methods

      public  ExtVersType ExtVersion
      {
         get
         {
            if (this.extVersion == null)
                throw new XBException("field extVersion not set");

            return this.extVersion;
         }
         set
         {
            this.extVersion = value;
         }
      }

      public  ExtFunctType ExtFunction
      {
         get
         {
            if (this.extFunction == null)
                throw new XBException("field extFunction not set");

            return this.extFunction;
         }
         set
         {
            this.extFunction = value;
         }
      }

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected virtual void validateAttrs(bool[] _attrPresenceFlags){
         if (!_attrPresenceFlags[0]) 
            throw new XBValidationException("missing attribute activationChangeDatetime");
         if (!_attrPresenceFlags[1]) 
            throw new XBValidationException("missing attribute activationStatus");
         if (!_attrPresenceFlags[2]) 
            throw new XBValidationException("missing attribute id");
         if (!_attrPresenceFlags[3]) 
            throw new XBValidationException("missing attribute isFull");
         if (!_attrPresenceFlags[4]) 
            throw new XBValidationException("missing attribute lastChangeDatetime");
         if (!_attrPresenceFlags[5]) 
            throw new XBValidationException("missing attribute majorVersion");
         if (!_attrPresenceFlags[6]) 
            throw new XBValidationException("missing attribute mediumVersion");
         if (!_attrPresenceFlags[7]) 
            throw new XBValidationException("missing attribute minorVersion");
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /*    activationChangeDatetime    */
         if (name.CompareTo("activationChangeDatetime") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.activationChangeDatetime = text;
            _attrPresenceFlags[0] = true;
            return true;
         }

         /*    activationStatus    */
         else if (name.CompareTo("activationStatus") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.activationStatus =  ActivationStatusCode.decode(text, xbContext);
            _attrPresenceFlags[1] = true;
            return true;
         }

         /*    id    */
         else if (name.CompareTo("id") == 0  && ns.CompareTo("") == 0 ) {
            this.id =  Nc1ObjectIdType.decode(text, xbContext);
            _attrPresenceFlags[2] = true;
            return true;
         }

         /*    instance    */
         else if (name.CompareTo("instance") == 0  && ns.CompareTo("") == 0 ) 
         {
            this.instance =  ShortTextObjectType.decode(text, xbContext);
            _set_instance = true;
            return true;
         }

         /*    isFull    */
         else if (name.CompareTo("isFull") == 0  && ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.isFull =  IsFullCode.decode(text, xbContext);
            _attrPresenceFlags[3] = true;
            return true;
         }

         /*    lastChangeDatetime    */
         else if (name.CompareTo("lastChangeDatetime") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.lastChangeDatetime = text;
            _attrPresenceFlags[4] = true;
            return true;
         }

         /*    majorVersion    */
         else if (name.CompareTo("majorVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.majorVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[5] = true;
            return true;
         }

         /*    mediumVersion    */
         else if (name.CompareTo("mediumVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.mediumVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[6] = true;
            return true;
         }

         /*    minorVersion    */
         else if (name.CompareTo("minorVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.minorVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[7] = true;
            return true;
         }
         else  {
            return false;
         }
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /* activationChangeDatetime -> activationChangeDatetime    */
         String text_3;
         text_3 = this.activationChangeDatetime;
         encoder.encodeAttr("activationChangeDatetime", "", "", text_3);

         /* activationStatus -> activationStatus    */
         text_3 =  ActivationStatusCode.encode(this.activationStatus, xbContext);
         encoder.encodeAttr("activationStatus", "", "", text_3);

         /* id -> id    */
         text_3 =  Nc1ObjectIdType.encode(this.id, xbContext);
         encoder.encodeAttr("id", "", "", text_3);

         /* instance -> instance    */
         if (_set_instance) {
            text_3 =  ShortTextObjectType.encode(this.instance, xbContext);
            encoder.encodeAttr("instance", "", "", text_3);
         }

         /* isFull -> isFull    */
         text_3 =  IsFullCode.encode(this.isFull, xbContext);
         encoder.encodeAttr("isFull", "", "", text_3);

         /* lastChangeDatetime -> lastChangeDatetime    */
         text_3 = this.lastChangeDatetime;
         encoder.encodeAttr("lastChangeDatetime", "", "", text_3);

         /* majorVersion -> majorVersion    */
         text_3 =  Int0To99Type.encode(this.majorVersion, xbContext);
         encoder.encodeAttr("majorVersion", "", "", text_3);

         /* mediumVersion -> mediumVersion    */
         text_3 =  Int0To99Type.encode(this.mediumVersion, xbContext);
         encoder.encodeAttr("mediumVersion", "", "", text_3);

         /* minorVersion -> minorVersion    */
         text_3 =  Int0To99Type.encode(this.minorVersion, xbContext);
         encoder.encodeAttr("minorVersion", "", "", text_3);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element whose content  is to be decoded.
       * POST: if return is false, reader is on corresponding END_ELEMENT.
       *    if return is true, reader is positioned at first bit of unprocessed content.
       * @param decodeAllContent if true, an error occurs if any content is not decoded by this method.
       *    (ie, the return must be false)
       * @return true if more content remains to be decoded, false otherwise
       */
      protected virtual bool decodeContent(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool decodeAllContent) {
         try  {
            bool moreContent_4;
            if (elementEmpty) {
               moreContent_4 = false;
            }
            else {
               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            if ( moreContent_4 ) {
               String elemLocalName = null;
               String elemNs = null;
               elemLocalName = reader.LocalName;
               elemNs = reader.NamespaceURI;

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.extVersion = new  ExtVersType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.extVersion.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extFunction
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.extFunction = new  ExtFunctType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.extFunction.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            return moreContent_4;
         }
         catch( System.Xml.XmlException e )  {
            throw new XBException(e.ToString(), e);
         }
      }


      /**
       * Encode content.
       */
      protected virtual void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         // extVersion
         if (this.extVersion != null)  {
            encoder.encodeStartElement("extVersion", "", "");
            this.extVersion.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // extFunction
         if (this.extFunction != null)  {
            encoder.encodeStartElement("extFunction", "", "");
            this.extFunction.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is on corresponding END_ELEMENT.
       * @param isNilled Pass true if the element was nillable and nilled.
       *       If true, an exception will result if any content is found.
       *       If false, an exception will result if non-emptiable particles
       *       are missing.
       * @param hasDefault Pass true if the element has a default fixed value.
       *       Clients are responsible for validating fixed values.
       *       If false, and isNilled is also false, an exception will result
       *       if no character data is found and no character data is invalid.
       *       If true, missing character data is ignored; you should have
       *       initialized the value field to the default value.
       */
      public virtual void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool isNilled, bool hasDefault) {

         //track presence of required, primitive type attrs
         bool[] _attrPresenceFlags = new bool[8];

         decodeNamespaces(reader);
         elementEmpty = XMLStreamHelper.checkEmptyElement(reader);

         for(bool moreAttr = reader.MoveToFirstAttribute(); moreAttr; 
            moreAttr = reader.MoveToNextAttribute()) {

            String text = reader.Value;
            String ns = reader.NamespaceURI;
            String name = reader.LocalName;
            String prefix = reader.Prefix;

            if (ns.CompareTo("http://www.w3.org/2001/XMLSchema-instance") == 0 ) continue;
            if (ns.CompareTo("http://www.w3.org/2000/xmlns/") == 0 ) continue;
            decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext);
         }
         validateAttrs(_attrPresenceFlags);

         if ( isNilled ) XMLStreamHelper.assertEmptyElement(reader);
         else  {
            decodeContent(reader, xbContext, true);
         }
      }


      /**
       * Encode contents of this class as XML content.
       * Caller should surround this method with calls to encoder.encodeStartElement 
       * and encoder.encodeEndElement.
       * @param elemDeclType if not null, encode xsi:type if this class's
       *    XSD_TYPE does not correspond to elemDeclType.
       * @param ignoreContent if true, do not encode, or validate, character
       *    data or child elements.  Encode an xsi:nil attribute.
       */
      public virtual void encode(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext, 
         XBQualifiedName elemDeclType, bool ignoreContent) {

         encodeNamespaces(encoder);

         if ( elemDeclType != null && !XSD_TYPE.equals(elemDeclType) ) 
            encoder.encodeXsiType(XSD_TYPE);
         encodeAttrs(encoder, xbContext);
         if ( ignoreContent )  {
            encoder.encodeAttr("nil", "http://www.w3.org/2001/XMLSchema-instance", "xsi", "true");
            return;
         }

         encodeContent(encoder, xbContext);
      }
   }

   public class LocalisedObjectType :  BaseObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:object",
          "LocalisedObjectType");
      static LocalisedObjectType() {
         XBUtil.license =  _Object.license;
      }


      /**
       * Factory method
       */
      public static new  LocalisedObjectType createObject(XBQualifiedName type) 
      {
         if ( type == null || type.equals( LocalisedObjectType.XSD_TYPE ) ) 
            return new  LocalisedObjectType();
         else if ( type.equals( _2DCoordinationMeanType.XSD_TYPE) ) 
            return new  _2DCoordinationMeanType();
         else if ( type.equals( TacAreaType.XSD_TYPE) ) 
            return new  TacAreaType();
         else if ( type.equals( TacLineType.XSD_TYPE) ) 
            return new  TacLineType();
         else if ( type.equals( TacPointType.XSD_TYPE) ) 
            return new  TacPointType();
         else if ( type.equals( PhysicalObjectType.XSD_TYPE) ) 
            return new  PhysicalObjectType();
         else if ( type.equals( AgentType.XSD_TYPE) ) 
            return new  AgentType();
         else if ( type.equals( IndividualType.XSD_TYPE) ) 
            return new  IndividualType();
         else if ( type.equals( OrganisationType.XSD_TYPE) ) 
            return new  OrganisationType();
         else if ( type.equals( UnitType.XSD_TYPE) ) 
            return new  UnitType();
         else if ( type.equals( ParticipantType.XSD_TYPE) ) 
            return new  ParticipantType();
         else if ( type.equals( AirParticipantType.XSD_TYPE) ) 
            return new  AirParticipantType();
         else if ( type.equals( GroundParticipantType.XSD_TYPE) ) 
            return new  GroundParticipantType();
         else if ( type.equals( SeaParticipantType.XSD_TYPE) ) 
            return new  SeaParticipantType();
         else if ( type.equals( TrackType.XSD_TYPE) ) 
            return new  TrackType();
         else if ( type.equals( AirTrackType.XSD_TYPE) ) 
            return new  AirTrackType();
         else if ( type.equals( GroundTrackType.XSD_TYPE) ) 
            return new  GroundTrackType();
         else if ( type.equals( SeaTrackType.XSD_TYPE) ) 
            return new  SeaTrackType();
         else if ( type.equals( ConvoyType.XSD_TYPE) ) 
            return new  ConvoyType();
         else if ( type.equals( FacilityType.XSD_TYPE) ) 
            return new  FacilityType();
         else if ( type.equals( GroundEntityType.XSD_TYPE) ) 
            return new  GroundEntityType();
         else if ( type.equals( ObstacleType.XSD_TYPE) ) 
            return new  ObstacleType();
         else if ( type.equals( _3DRouteType.XSD_TYPE) ) 
            return new  _3DRouteType();
         else if ( type.equals( AcmWezType.XSD_TYPE) ) 
            return new  AcmWezType();
         else if ( type.equals( CbrnEventType.XSD_TYPE) ) 
            return new  CbrnEventType();
         else if ( type.equals( EventType.XSD_TYPE) ) 
            return new  EventType();
         else if ( type.equals( FireType.XSD_TYPE) ) 
            return new  FireType();
         else if ( type.equals( FireObjectiveType.XSD_TYPE) ) 
            return new  FireObjectiveType();
         else if ( type.equals( FreeShapeType.XSD_TYPE) ) 
            return new  FreeShapeType();
         else if ( type.equals( IffProcedureType.XSD_TYPE) ) 
            return new  IffProcedureType();
         else if ( type.equals( IntelRequirementType.XSD_TYPE) ) 
            return new  IntelRequirementType();
         else if ( type.equals( MeteoType.XSD_TYPE) ) 
            return new  MeteoType();
         else if ( type.equals( RouteType.XSD_TYPE) ) 
            return new  RouteType();
         else throw new XBValidationException("unknown type:" + type);
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields

      //attribute methods

      //content methods

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected override void validateAttrs(bool[] _attrPresenceFlags){
         base.validateAttrs(_attrPresenceFlags);
      }


      protected override bool decodeAttr(String name, String ns, 
         String prefix, String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         if (base.decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext)) 
            return true;
         else  {
            return false;
         }
      }

      protected override void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeAttrs(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element whose content  is to be decoded.
       * POST: if return is false, reader is on corresponding END_ELEMENT.
       *    if return is true, reader is positioned at first bit of unprocessed content.
       * @param decodeAllContent if true, an error occurs if any content is not decoded by this method.
       *    (ie, the return must be false)
       * @return true if more content remains to be decoded, false otherwise
       */
      protected override bool decodeContent(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool decodeAllContent) {
         bool moreContent_3;
         moreContent_3 = base.decodeContent(reader, xbContext, false);
         if (decodeAllContent && moreContent_3) 
            throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
         //no content to decode locally
         return moreContent_3;
      }


      /**
       * Encode content.
       */
      protected override void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeContent(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is on corresponding END_ELEMENT.
       * @param isNilled Pass true if the element was nillable and nilled.
       *       If true, an exception will result if any content is found.
       *       If false, an exception will result if non-emptiable particles
       *       are missing.
       * @param hasDefault Pass true if the element has a default fixed value.
       *       Clients are responsible for validating fixed values.
       *       If false, and isNilled is also false, an exception will result
       *       if no character data is found and no character data is invalid.
       *       If true, missing character data is ignored; you should have
       *       initialized the value field to the default value.
       */
      public override void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool isNilled, bool hasDefault) {

         //track presence of required, primitive type attrs
         bool[] _attrPresenceFlags = new bool[8];

         decodeNamespaces(reader);
         elementEmpty = XMLStreamHelper.checkEmptyElement(reader);

         for(bool moreAttr = reader.MoveToFirstAttribute(); moreAttr; 
            moreAttr = reader.MoveToNextAttribute()) {

            String text = reader.Value;
            String ns = reader.NamespaceURI;
            String name = reader.LocalName;
            String prefix = reader.Prefix;

            if (ns.CompareTo("http://www.w3.org/2001/XMLSchema-instance") == 0 ) continue;
            if (ns.CompareTo("http://www.w3.org/2000/xmlns/") == 0 ) continue;
            decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext);
         }
         validateAttrs(_attrPresenceFlags);

         if ( isNilled ) XMLStreamHelper.assertEmptyElement(reader);
         else  {
            decodeContent(reader, xbContext, true);
         }
      }


      /**
       * Encode contents of this class as XML content.
       * Caller should surround this method with calls to encoder.encodeStartElement 
       * and encoder.encodeEndElement.
       * @param elemDeclType if not null, encode xsi:type if this class's
       *    XSD_TYPE does not correspond to elemDeclType.
       * @param ignoreContent if true, do not encode, or validate, character
       *    data or child elements.  Encode an xsi:nil attribute.
       */
      public override void encode(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext, 
         XBQualifiedName elemDeclType, bool ignoreContent) {

         encodeNamespaces(encoder);

         if ( elemDeclType != null && !XSD_TYPE.equals(elemDeclType) ) 
            encoder.encodeXsiType(XSD_TYPE);
         encodeAttrs(encoder, xbContext);
         if ( ignoreContent )  {
            encoder.encodeAttr("nil", "http://www.w3.org/2001/XMLSchema-instance", "xsi", "true");
            return;
         }

         encodeContent(encoder, xbContext);
      }
   }

   public class PhysicalObjectType :  LocalisedObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:object",
          "PhysicalObjectType");
      static PhysicalObjectType() {
         XBUtil.license =  _Object.license;
      }


      /**
       * Factory method
       */
      public static new  PhysicalObjectType createObject(XBQualifiedName type) 
      {
         if ( type == null || type.equals( PhysicalObjectType.XSD_TYPE ) ) 
            return new  PhysicalObjectType();
         else if ( type.equals( AgentType.XSD_TYPE) ) 
            return new  AgentType();
         else if ( type.equals( IndividualType.XSD_TYPE) ) 
            return new  IndividualType();
         else if ( type.equals( OrganisationType.XSD_TYPE) ) 
            return new  OrganisationType();
         else if ( type.equals( UnitType.XSD_TYPE) ) 
            return new  UnitType();
         else if ( type.equals( ParticipantType.XSD_TYPE) ) 
            return new  ParticipantType();
         else if ( type.equals( AirParticipantType.XSD_TYPE) ) 
            return new  AirParticipantType();
         else if ( type.equals( GroundParticipantType.XSD_TYPE) ) 
            return new  GroundParticipantType();
         else if ( type.equals( SeaParticipantType.XSD_TYPE) ) 
            return new  SeaParticipantType();
         else if ( type.equals( TrackType.XSD_TYPE) ) 
            return new  TrackType();
         else if ( type.equals( AirTrackType.XSD_TYPE) ) 
            return new  AirTrackType();
         else if ( type.equals( GroundTrackType.XSD_TYPE) ) 
            return new  GroundTrackType();
         else if ( type.equals( SeaTrackType.XSD_TYPE) ) 
            return new  SeaTrackType();
         else if ( type.equals( ConvoyType.XSD_TYPE) ) 
            return new  ConvoyType();
         else if ( type.equals( FacilityType.XSD_TYPE) ) 
            return new  FacilityType();
         else if ( type.equals( GroundEntityType.XSD_TYPE) ) 
            return new  GroundEntityType();
         else if ( type.equals( ObstacleType.XSD_TYPE) ) 
            return new  ObstacleType();
         else throw new XBValidationException("unknown type:" + type);
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields

      //attribute methods

      //content methods

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected override void validateAttrs(bool[] _attrPresenceFlags){
         base.validateAttrs(_attrPresenceFlags);
      }


      protected override bool decodeAttr(String name, String ns, 
         String prefix, String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         if (base.decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext)) 
            return true;
         else  {
            return false;
         }
      }

      protected override void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeAttrs(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element whose content  is to be decoded.
       * POST: if return is false, reader is on corresponding END_ELEMENT.
       *    if return is true, reader is positioned at first bit of unprocessed content.
       * @param decodeAllContent if true, an error occurs if any content is not decoded by this method.
       *    (ie, the return must be false)
       * @return true if more content remains to be decoded, false otherwise
       */
      protected override bool decodeContent(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool decodeAllContent) {
         bool moreContent_3;
         moreContent_3 = base.decodeContent(reader, xbContext, false);
         if (decodeAllContent && moreContent_3) 
            throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
         //no content to decode locally
         return moreContent_3;
      }


      /**
       * Encode content.
       */
      protected override void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeContent(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is on corresponding END_ELEMENT.
       * @param isNilled Pass true if the element was nillable and nilled.
       *       If true, an exception will result if any content is found.
       *       If false, an exception will result if non-emptiable particles
       *       are missing.
       * @param hasDefault Pass true if the element has a default fixed value.
       *       Clients are responsible for validating fixed values.
       *       If false, and isNilled is also false, an exception will result
       *       if no character data is found and no character data is invalid.
       *       If true, missing character data is ignored; you should have
       *       initialized the value field to the default value.
       */
      public override void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool isNilled, bool hasDefault) {

         //track presence of required, primitive type attrs
         bool[] _attrPresenceFlags = new bool[8];

         decodeNamespaces(reader);
         elementEmpty = XMLStreamHelper.checkEmptyElement(reader);

         for(bool moreAttr = reader.MoveToFirstAttribute(); moreAttr; 
            moreAttr = reader.MoveToNextAttribute()) {

            String text = reader.Value;
            String ns = reader.NamespaceURI;
            String name = reader.LocalName;
            String prefix = reader.Prefix;

            if (ns.CompareTo("http://www.w3.org/2001/XMLSchema-instance") == 0 ) continue;
            if (ns.CompareTo("http://www.w3.org/2000/xmlns/") == 0 ) continue;
            decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext);
         }
         validateAttrs(_attrPresenceFlags);

         if ( isNilled ) XMLStreamHelper.assertEmptyElement(reader);
         else  {
            decodeContent(reader, xbContext, true);
         }
      }


      /**
       * Encode contents of this class as XML content.
       * Caller should surround this method with calls to encoder.encodeStartElement 
       * and encoder.encodeEndElement.
       * @param elemDeclType if not null, encode xsi:type if this class's
       *    XSD_TYPE does not correspond to elemDeclType.
       * @param ignoreContent if true, do not encode, or validate, character
       *    data or child elements.  Encode an xsi:nil attribute.
       */
      public override void encode(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext, 
         XBQualifiedName elemDeclType, bool ignoreContent) {

         encodeNamespaces(encoder);

         if ( elemDeclType != null && !XSD_TYPE.equals(elemDeclType) ) 
            encoder.encodeXsiType(XSD_TYPE);
         encodeAttrs(encoder, xbContext);
         if ( ignoreContent )  {
            encoder.encodeAttr("nil", "http://www.w3.org/2001/XMLSchema-instance", "xsi", "true");
            return;
         }

         encodeContent(encoder, xbContext);
      }
   }

   public class AgentType :  PhysicalObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:object",
          "AgentType");
      static AgentType() {
         XBUtil.license =  _Object.license;
      }


      /**
       * Factory method
       */
      public static new  AgentType createObject(XBQualifiedName type) {
         if ( type == null || type.equals( AgentType.XSD_TYPE ) ) 
            return new  AgentType();
         else if ( type.equals( IndividualType.XSD_TYPE) ) 
            return new  IndividualType();
         else if ( type.equals( OrganisationType.XSD_TYPE) ) 
            return new  OrganisationType();
         else if ( type.equals( UnitType.XSD_TYPE) ) 
            return new  UnitType();
         else throw new XBValidationException("unknown type:" + type);
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields

      //attribute methods

      //content methods

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected override void validateAttrs(bool[] _attrPresenceFlags){
         base.validateAttrs(_attrPresenceFlags);
      }


      protected override bool decodeAttr(String name, String ns, 
         String prefix, String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         if (base.decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext)) 
            return true;
         else  {
            return false;
         }
      }

      protected override void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeAttrs(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element whose content  is to be decoded.
       * POST: if return is false, reader is on corresponding END_ELEMENT.
       *    if return is true, reader is positioned at first bit of unprocessed content.
       * @param decodeAllContent if true, an error occurs if any content is not decoded by this method.
       *    (ie, the return must be false)
       * @return true if more content remains to be decoded, false otherwise
       */
      protected override bool decodeContent(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool decodeAllContent) {
         bool moreContent_3;
         moreContent_3 = base.decodeContent(reader, xbContext, false);
         if (decodeAllContent && moreContent_3) 
            throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
         //no content to decode locally
         return moreContent_3;
      }


      /**
       * Encode content.
       */
      protected override void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeContent(encoder, xbContext);
      }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is on corresponding END_ELEMENT.
       * @param isNilled Pass true if the element was nillable and nilled.
       *       If true, an exception will result if any content is found.
       *       If false, an exception will result if non-emptiable particles
       *       are missing.
       * @param hasDefault Pass true if the element has a default fixed value.
       *       Clients are responsible for validating fixed values.
       *       If false, and isNilled is also false, an exception will result
       *       if no character data is found and no character data is invalid.
       *       If true, missing character data is ignored; you should have
       *       initialized the value field to the default value.
       */
      public override void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext, 
         bool isNilled, bool hasDefault) {

         //track presence of required, primitive type attrs
         bool[] _attrPresenceFlags = new bool[8];

         decodeNamespaces(reader);
         elementEmpty = XMLStreamHelper.checkEmptyElement(reader);

         for(bool moreAttr = reader.MoveToFirstAttribute(); moreAttr; 
            moreAttr = reader.MoveToNextAttribute()) {

            String text = reader.Value;
            String ns = reader.NamespaceURI;
            String name = reader.LocalName;
            String prefix = reader.Prefix;

            if (ns.CompareTo("http://www.w3.org/2001/XMLSchema-instance") == 0 ) continue;
            if (ns.CompareTo("http://www.w3.org/2000/xmlns/") == 0 ) continue;
            decodeAttr(name, ns, prefix, text, _attrPresenceFlags, xbContext);
         }
         validateAttrs(_attrPresenceFlags);

         if ( isNilled ) XMLStreamHelper.assertEmptyElement(reader);
         else  {
            decodeContent(reader, xbContext, true);
         }
      }


      /**
       * Encode contents of this class as XML content.
       * Caller should surround this method with calls to encoder.encodeStartElement 
       * and encoder.encodeEndElement.
       * @param elemDeclType if not null, encode xsi:type if this class's
       *    XSD_TYPE does not correspond to elemDeclType.
       * @param ignoreContent if true, do not encode, or validate, character
       *    data or child elements.  Encode an xsi:nil attribute.
       */
      public override void encode(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext, 
         XBQualifiedName elemDeclType, bool ignoreContent) {

         encodeNamespaces(encoder);

         if ( elemDeclType != null && !XSD_TYPE.equals(elemDeclType) ) 
            encoder.encodeXsiType(XSD_TYPE);
         encodeAttrs(encoder, xbContext);
         if ( ignoreContent )  {
            encoder.encodeAttr("nil", "http://www.w3.org/2001/XMLSchema-instance", "xsi", "true");
            return;
         }

         encodeContent(encoder, xbContext);
      }
   }
   /**
    * This file was generated by the Objective Systems XBinder(tm) Compiler
    * (http://www.obj-sys.com).  Version: 2.7.0, Date: 19-Jun-2022.
    * Copyright (c) 2003-2021 Objective Systems, Inc.
    *
    * Permission is hereby granted to redistribute this file with the
    * condition that this copyright notice be present and not altered.
    */

   public class _Object {

      public static XBXmlNamespace[] namespaceContext = {
         new XBXmlNamespace("nc12dcoord", "urn:fra:nc1:objet:2dcoordinationmean")
         , new XBXmlNamespace("nc1common", "urn:fra:nc1:common:attribute"), 
         new XBXmlNamespace("nc1sicsdicos", "urn:fra:nc1:common:sicsdicos"), 
         new XBXmlNamespace("nc1objcom", "urn:fra:nc1:common:object"), 
         new XBXmlNamespace("nc1cbrn", "urn:fra:nc1:common:cbrn"), 
         new XBXmlNamespace("nc1location", "urn:fra:nc1:common:location"), 
         new XBXmlNamespace("nc1com", "urn:fra:nc1:common:communication"), 
         new XBXmlNamespace("nc1ew", "urn:fra:nc1:common:ew"), 
         new XBXmlNamespace("nc1msgcom", "urn:fra:nc1:common:message"), 
         new XBXmlNamespace("nc13droute", "urn:fra:nc1:objet:3droute"), 
         new XBXmlNamespace("nc1acm", "urn:fra:nc1:objet:acm"), 
         new XBXmlNamespace("nc1airparticipant", "urn:fra:nc1:objet:airparticipant")
         , new XBXmlNamespace("nc1logistics", "urn:fra:nc1:common:logistics"), 
         new XBXmlNamespace("nc1participant", "urn:fra:nc1:objet:participant")
         , new XBXmlNamespace("nc1airtrack", "urn:fra:nc1:objet:airtrack"), 
         new XBXmlNamespace("nc1track", "urn:fra:nc1:objet:track"), 
         new XBXmlNamespace("nc1cbrnevent", "urn:fra:nc1:objet:cbrnevent"), 
         new XBXmlNamespace("nc1convoy", "urn:fra:nc1:objet:convoy"), 
         new XBXmlNamespace("nc1event", "urn:fra:nc1:objet:event"), 
         new XBXmlNamespace("nc1medical", "urn:fra:nc1:common:health"), 
         new XBXmlNamespace("nc1facility", "urn:fra:nc1:objet:facility"), 
         new XBXmlNamespace("nc1fire", "urn:fra:nc1:objet:fire"), 
         new XBXmlNamespace("nc1fireobjective", "urn:fra:nc1:objet:fireobjective")
         , new XBXmlNamespace("nc1freeshape", "urn:fra:nc1:objet:freeshape"), 
         new XBXmlNamespace("nc1groundentity", "urn:fra:nc1:objet:groundentity")
         , 
         new XBXmlNamespace("nc1groundparticipant", "urn:fra:nc1:objet:groundparticipant")
         , 
         new XBXmlNamespace("nc1groundtrack", "urn:fra:nc1:objet:groundtrack")
         , 
         new XBXmlNamespace("nc1iffprocedure", "urn:fra:nc1:objet:iffprocedure")
         , new XBXmlNamespace("nc1individual", "urn:fra:nc1:objet:individual")
         , 
         new XBXmlNamespace("nc1intelreq", "urn:fra:nc1:objet:intelrequirement")
         , new XBXmlNamespace("nc1meteo", "urn:fra:nc1:objet:meteo"), 
         new XBXmlNamespace("nc1mission", "urn:fra:nc1:objet:mission"), 
         new XBXmlNamespace("nc1missionASA", "urn:fra:nc1:objet:missionASA"), 
         new XBXmlNamespace("nc1missionASS", "urn:fra:nc1:objet:missionASS"), 
         new XBXmlNamespace("nc1obstacle", "urn:fra:nc1:objet:obstacle"), 
         new XBXmlNamespace("nc1organisation", "urn:fra:nc1:objet:organisation")
         , 
         new XBXmlNamespace("nc1reinforcement", "urn:fra:nc1:objet:reinforcement")
         , new XBXmlNamespace("nc1roe", "urn:fra:nc1:objet:roe"), 
         new XBXmlNamespace("nc1route", "urn:fra:nc1:objet:route"), 
         new XBXmlNamespace("nc1seaparticipant", "urn:fra:nc1:objet:seaparticipant")
         , new XBXmlNamespace("nc1seatrack", "urn:fra:nc1:objet:seatrack"), 
         new XBXmlNamespace("nc1tacarea", "urn:fra:nc1:objet:tacarea"), 
         new XBXmlNamespace("nc1tacline", "urn:fra:nc1:objet:tacline"), 
         new XBXmlNamespace("nc1tacpoint", "urn:fra:nc1:objet:tacpoint"), 
         new XBXmlNamespace("nc1unit", "urn:fra:nc1:objet:unit"), 
         new XBXmlNamespace("nc1admitexitrep", "urn:fra:nc1:message:admitexitrep")
         , 
         new XBXmlNamespace("nc1annultirinterdit", "urn:fra:nc1:message:annultirinterdit")
         , new XBXmlNamespace("nc1apercu", "urn:fra:nc1:message:apercu"), 
         new XBXmlNamespace("nc1apercu3d", "urn:fra:nc1:message:apercu3d"), 
         new XBXmlNamespace("nc1barrep", "urn:fra:nc1:message:barrep"), 
         new XBXmlNamespace("nc1batrecevacreq", "urn:fra:nc1:message:batrecevacreq")
         , new XBXmlNamespace("nc1bda", "urn:fra:nc1:message:bda"), 
         new XBXmlNamespace("nc1bft", "urn:fra:nc1:message:bft"), 
         new XBXmlNamespace("nc1boap", "urn:fra:nc1:message:boap"), 
         new XBXmlNamespace("nc1technoap", "urn:fra:nc1:message:technoap"), 
         new XBXmlNamespace("nc1barreq", "urn:fra:nc1:message:barreq"), 
         new XBXmlNamespace("cbrn1bio", "urn:fra:nc1:message:cbrn1bio"), 
         new XBXmlNamespace("nc1cbrn1chem", "urn:fra:nc1:message:cbrn1chem"), 
         new XBXmlNamespace("nc1cbrn3bio", "urn:fra:nc1:message:cbrn3bio"), 
         new XBXmlNamespace("nc1cbrn3chem", "urn:fra:nc1:message:cbrn3chem"), 
         new XBXmlNamespace("nc1cbrn4bio", "urn:fra:nc1:message:cbrn4bio"), 
         new XBXmlNamespace("nc1cbrn4chem", "urn:fra:nc1:message:cbrn4chem"), 
         new XBXmlNamespace("nc1cbrn5bio", "urn:fra:nc1:message:cbrn5bio"), 
         new XBXmlNamespace("nc1cbrn5chem", "urn:fra:nc1:message:cbrn5chem"), 
         new XBXmlNamespace("nc1cbrncdr", "urn:fra:nc1:message:cbrncdr"), 
         new XBXmlNamespace("nc1cbrnsitrep", "urn:fra:nc1:message:cbrnsitrep")
         , new XBXmlNamespace("nc1ccacard", "urn:fra:nc1:message:ccacard"), 
         new XBXmlNamespace("nc1cff", "urn:fra:nc1:message:callforfire"), 
         new XBXmlNamespace("nc1conarep", "urn:fra:nc1:message:conarep"), 
         new XBXmlNamespace("nc1conops", "urn:fra:nc1:message:conops"), 
         new XBXmlNamespace("nc1opord", "urn:fra:nc1:message:opord"), 
         new XBXmlNamespace("nc1creationitsats", "urn:fra:nc1:message:creationitsats")
         , new XBXmlNamespace("nc1deployrep", "urn:fra:nc1:message:deployrep")
         , new XBXmlNamespace("nc1demalord", "urn:fra:nc1:message:demalord"), 
         new XBXmlNamespace("nc1engrecceord", "urn:fra:nc1:message:engrecceord")
         , 
         new XBXmlNamespace("nc1engreccerep", "urn:fra:nc1:message:engreccerep")
         , new XBXmlNamespace("nc1ensitrep", "urn:fra:nc1:message:ensitrep"), 
         new XBXmlNamespace("nc1eoincrep", "urn:fra:nc1:message:eoincrep"), 
         new XBXmlNamespace("nc1eventrep", "urn:fra:nc1:message:eventrep"), 
         new XBXmlNamespace("nc1ewmsnsum", "urn:fra:nc1:message:ewmsnsum"), 
         new XBXmlNamespace("nc1ewrtm", "urn:fra:nc1:message:ewrtm"), 
         new XBXmlNamespace("nc1finalertraideni", "urn:fra:nc1:message:finalerteraideni")
         , 
         new XBXmlNamespace("nc1firecontrol", "urn:fra:nc1:message:firecontrol")
         , 
         new XBXmlNamespace("nc1firereport", "urn:fra:nc1:message:firereport")
         , new XBXmlNamespace("nc1helopsum", "urn:fra:nc1:message:helopsum"), 
         new XBXmlNamespace("nc1igen", "urn:fra:nc1:message:igen"), 
         new XBXmlNamespace("nc1intrep", "urn:fra:nc1:message:intrep"), 
         new XBXmlNamespace("nc1intreq", "urn:fra:nc1:message:intreq"), 
         new XBXmlNamespace("nc1intsum", "urn:fra:nc1:message:intsum"), 
         new XBXmlNamespace("nc1initmedrep", "urn:fra:nc1:message:initmedrep")
         , new XBXmlNamespace("nc1initodb", "urn:fra:nc1:message:initodb"), 
         new XBXmlNamespace("nc1ler", "urn:fra:nc1:message:ler"), 
         new XBXmlNamespace("nc1medevac", "urn:fra:nc1:message:medevac"), 
         new XBXmlNamespace("nc1matdem", "urn:fra:nc1:message:matdem"), 
         new XBXmlNamespace("nc1medsitrep", "urn:fra:nc1:message:medsitrep"), 
         new XBXmlNamespace("nc1messagelibre", "urn:fra:nc1:message:messagelibre")
         , new XBXmlNamespace("nc1movorder", "urn:fra:nc1:message:movorder"), 
         new XBXmlNamespace("nc1obsexord", "urn:fra:nc1:message:obsexord"), 
         new XBXmlNamespace("nc1opordain", "urn:fra:nc1:message:opordain"), 
         new XBXmlNamespace("nc1opordalat", "urn:fra:nc1:message:opordalat"), 
         new XBXmlNamespace("nc1opordge", "urn:fra:nc1:message:opordge"), 
         new XBXmlNamespace("nc1opordgen", "urn:fra:nc1:message:opordgen"), 
         new XBXmlNamespace("nc1opordlog", "urn:fra:nc1:message:opordlog"), 
         new XBXmlNamespace("nc1opordmvt", "urn:fra:nc1:message:opordmvt"), 
         new XBXmlNamespace("nc1opordopsec", "urn:fra:nc1:message:opordopsec")
         , new XBXmlNamespace("nc1opordrens", "urn:fra:nc1:message:opordrens")
         , new XBXmlNamespace("nc1opordroe", "urn:fra:nc1:message:opordroe"), 
         new XBXmlNamespace("nc1opordsic", "urn:fra:nc1:message:opordsic"), 
         new XBXmlNamespace("nc1ownsitrep", "urn:fra:nc1:message:ownsitrep"), 
         new XBXmlNamespace("nc1objectivelist", "urn:fra:nc1:message:objectivelist")
         , new XBXmlNamespace("nc1pema", "urn:fra:nc1:message:pema"), 
         new XBXmlNamespace("nc1prr", "urn:fra:nc1:message:prr"), 
         new XBXmlNamespace("nc1plandevol", "urn:fra:nc1:message:plandevol"), 
         new XBXmlNamespace("nc1propplanobst", "urn:fra:nc1:message:propplanobstacles")
         , new XBXmlNamespace("nc1request", "urn:fra:nc1:message:request"), 
         new XBXmlNamespace("nc1str", "urn:fra:nc1:message:str"), 
         new XBXmlNamespace("nc1sitobst", "urn:fra:nc1:message:sitobst"), 
         new XBXmlNamespace("nc1stacmconduite", "urn:fra:nc1:message:stacmconduite")
         , 
         new XBXmlNamespace("nc1suppritsats", "urn:fra:nc1:message:suppressionitsats")
         , new XBXmlNamespace("nc1tactoap", "urn:fra:nc1:message:tactoap"), 
         new XBXmlNamespace("nc1techreqinfo", "urn:fra:nc1:service:reqinfo"), 
         new XBXmlNamespace("nc1stcupdate", "urn:fra:nc1:service:stcupdate"), 
         new XBXmlNamespace("nc1tirinterdit", "urn:fra:nc1:message:tirinterdit")
         };

      //declare constants for the schema's ns and preferred prefix
      public static readonly String NS_URI = "urn:fra:nc1:common:object";
      public static readonly String NS_PREFIX = "nc1objcom";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _Object() {
      }
      static _Object() {
         XBUtil.license = _Object.license;
      }
   }
}
