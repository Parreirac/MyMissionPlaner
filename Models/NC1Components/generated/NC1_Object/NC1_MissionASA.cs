using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Obj.missionASA
{

   using System.IO;
   using System.Xml;
   using com.objsys.xbinder.runtime;
    using NC1.Location;
    using NC1.Obj;
    using NC1.Dictionnaries;
    using LevelsType = NC1.Obj.acm.LevelsType;



    public class AircraftEquipmentCode
   {
      static AircraftEquipmentCode() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //constructor
      private AircraftEquipmentCode() {} 


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

   public class AircraftTypeCode
   {
      static AircraftTypeCode() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //constructor
      private AircraftTypeCode() {} 


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

   public class PriorityCode
   {
      static PriorityCode() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //constructor
      private PriorityCode() {} 


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

   public class ElementDefenceType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "ElementDefenceType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","location"),
         new XBQualifiedName("","nature"),
         new XBQualifiedName("","priority")
      };
      static ElementDefenceType() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType location;
      protected string nature;
      protected bool _set_nature = false;
      protected int priority;
      protected bool _set_priority = false;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType Location
      {
         get
         {
            if (this.location == null)
                throw new XBException("field location not set");

            return this.location;
         }
         set
         {
            this.location = value;
         }
      }

      public string Nature
      {
         get
         {
            if (!_set_nature) throw new XBException("field nature not set");

            return this.nature;
         }
         set
         {
            this.nature = value;
            _set_nature = true;
         }
      }

      public int Priority
      {
         get
         {
            if (!_set_priority)
                throw new XBException("field priority not set");

            return this.priority;
         }
         set
         {
            this.priority = value;
            _set_priority = true;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // location
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.location = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.location.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "location");

               // nature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nature =  MediumTextType.decode(text, xbContext);

                  _set_nature = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // priority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.priority =  PriorityCode.decode(text, xbContext);

                  _set_priority = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // location
         if (this.location == null)
             throw new XBException("field location not set");

         encoder.encodeStartElement("location", "", "");
         this.location.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // nature
         if (_set_nature)  {
            encoder.encodeStartElement("nature", "", "");
            String text_4;
            text_4 =  MediumTextType.encode(this.nature, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // priority
         if (_set_priority)  {
            encoder.encodeStartElement("priority", "", "");
            String text_4;
            text_4 =  PriorityCode.encode(this.priority, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class WeaponCode
   {
      static WeaponCode() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //constructor
      private WeaponCode() {} 


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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","aircraftWeapon"),
         new XBQualifiedName("","aircraftWeaponUnlisted"),
         new XBQualifiedName("","aircraftEquipment"),
         new XBQualifiedName("","aircraftEquipmentUnlisted")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int aircraftWeapon;
      protected bool _set_aircraftWeapon = false;
      protected string aircraftWeaponUnlisted;
      protected bool _set_aircraftWeaponUnlisted = false;
      protected int aircraftEquipment;
      protected bool _set_aircraftEquipment = false;
      protected string aircraftEquipmentUnlisted;
      protected bool _set_aircraftEquipmentUnlisted = false;

      //attribute methods

      //content methods

      public int AircraftWeapon
      {
         get
         {
            if (!_set_aircraftWeapon)
                throw new XBException("field aircraftWeapon not set");

            return this.aircraftWeapon;
         }
         set
         {
            this.aircraftWeapon = value;
            _set_aircraftWeapon = true;
         }
      }

      public string AircraftWeaponUnlisted
      {
         get
         {
            if (!_set_aircraftWeaponUnlisted)
                throw new XBException("field aircraftWeaponUnlisted not set");

            return this.aircraftWeaponUnlisted;
         }
         set
         {
            this.aircraftWeaponUnlisted = value;
            _set_aircraftWeaponUnlisted = true;
         }
      }

      public int AircraftEquipment
      {
         get
         {
            if (!_set_aircraftEquipment)
                throw new XBException("field aircraftEquipment not set");

            return this.aircraftEquipment;
         }
         set
         {
            this.aircraftEquipment = value;
            _set_aircraftEquipment = true;
         }
      }

      public string AircraftEquipmentUnlisted
      {
         get
         {
            if (!_set_aircraftEquipmentUnlisted)
                throw new XBException("field aircraftEquipmentUnlisted not set");

            return this.aircraftEquipmentUnlisted;
         }
         set
         {
            this.aircraftEquipmentUnlisted = value;
            _set_aircraftEquipmentUnlisted = true;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // aircraftWeapon
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.aircraftWeapon =  WeaponCode.decode(text, xbContext);

                  _set_aircraftWeapon = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // aircraftWeaponUnlisted
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.aircraftWeaponUnlisted =  ShortTextType.decode(text, xbContext);

                  _set_aircraftWeaponUnlisted = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // aircraftEquipment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.aircraftEquipment =  AircraftEquipmentCode.decode(text, xbContext);

                  _set_aircraftEquipment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // aircraftEquipmentUnlisted
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.aircraftEquipmentUnlisted =  ShortTextType.decode(text, xbContext);

                  _set_aircraftEquipmentUnlisted = true;

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

         // aircraftWeapon
         if (_set_aircraftWeapon)  {
            encoder.encodeStartElement("aircraftWeapon", "", "");
            String text_4;
            text_4 =  WeaponCode.encode(this.aircraftWeapon, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // aircraftWeaponUnlisted
         if (_set_aircraftWeaponUnlisted)  {
            encoder.encodeStartElement("aircraftWeaponUnlisted", "", "");
            String text_4;
            text_4 =  ShortTextType.encode(this.aircraftWeaponUnlisted, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // aircraftEquipment
         if (_set_aircraftEquipment)  {
            encoder.encodeStartElement("aircraftEquipment", "", "");
            String text_4;
            text_4 =  AircraftEquipmentCode.encode(this.aircraftEquipment, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // aircraftEquipmentUnlisted
         if (_set_aircraftEquipmentUnlisted)  {
            encoder.encodeStartElement("aircraftEquipmentUnlisted", "", "");
            String text_4;
            text_4 =  ShortTextType.encode(this.aircraftEquipmentUnlisted, xbContext);
            encoder.encodeChars(text_4);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","priorityOfTheThreat"),
         new XBQualifiedName("","aircraftType"),
         new XBQualifiedName("","penetrationAxis"),
         new XBQualifiedName("","equipmentAndWeapon")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int priorityOfTheThreat;
      protected int aircraftType;
      protected  Nc1ObjectRefType penetrationAxis;   //optional
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon> equipmentAndWeapon;
         

      //attribute methods

      //content methods

      public int PriorityOfTheThreat
      {
         get { return this.priorityOfTheThreat; }
         set { this.priorityOfTheThreat = value; }
      }

      public int AircraftType
      {
         get { return this.aircraftType; }
         set { this.aircraftType = value; }
      }

      public  Nc1ObjectRefType PenetrationAxis
      {
         get
         {
            if (this.penetrationAxis == null)
                throw new XBException("field penetrationAxis not set");

            return this.penetrationAxis;
         }
         set
         {
            this.penetrationAxis = value;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon> EquipmentAndWeapon
      {
         get
         {
            if (this.equipmentAndWeapon == null) {
               this.equipmentAndWeapon = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon>()
                  ;
            }
            return this.equipmentAndWeapon;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // priorityOfTheThreat
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.priorityOfTheThreat =  PriorityCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "priorityOfTheThreat");

               // aircraftType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.aircraftType =  AircraftTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "aircraftType");

               // penetrationAxis
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.penetrationAxis = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.penetrationAxis.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // equipmentAndWeapon
               this.equipmentAndWeapon = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon _tmp_equipmentAndWeapon;
                  _tmp_equipmentAndWeapon = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_equipmentAndWeapon.decode(reader, xbContext, false, false);
                  this.equipmentAndWeapon.Add(_tmp_equipmentAndWeapon);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // priorityOfTheThreat
         encoder.encodeStartElement("priorityOfTheThreat", "", "");
         String text_3;
         text_3 =  PriorityCode.encode(this.priorityOfTheThreat, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // aircraftType
         encoder.encodeStartElement("aircraftType", "", "");
         text_3 =  AircraftTypeCode.encode(this.aircraftType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // penetrationAxis
         if (this.penetrationAxis != null)  {
            encoder.encodeStartElement("penetrationAxis", "", "");
            this.penetrationAxis.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // equipmentAndWeapon
         if ( this.equipmentAndWeapon != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat_equipmentAndWeapon _tmp_equipmentAndWeapon in this.equipmentAndWeapon)
            {
               encoder.encodeStartElement("equipmentAndWeapon", "", "");
               _tmp_equipmentAndWeapon.encode(encoder, xbContext, null, 
                  false);
               encoder.encodeEndElement();
            }
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","orderNumber"),
         new XBQualifiedName("","airDefenceSectionId")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected uint orderNumber;
      protected bool _set_orderNumber = false;
      protected  Nc1ObjectRefType airDefenceSectionId;   //optional

      //attribute methods

      //content methods

      public uint OrderNumber
      {
         get
         {
            if (!_set_orderNumber)
                throw new XBException("field orderNumber not set");

            return this.orderNumber;
         }
         set
         {
            this.orderNumber = value;
            _set_orderNumber = true;
         }
      }

      public  Nc1ObjectRefType AirDefenceSectionId
      {
         get
         {
            if (this.airDefenceSectionId == null)
                throw new XBException("field airDefenceSectionId not set");

            return this.airDefenceSectionId;
         }
         set
         {
            this.airDefenceSectionId = value;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // orderNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.orderNumber =  Int1To99999Type.decode(text, xbContext);

                  _set_orderNumber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airDefenceSectionId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.airDefenceSectionId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.airDefenceSectionId.decode(reader, xbContext, false, false);

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

         // orderNumber
         if (_set_orderNumber)  {
            encoder.encodeStartElement("orderNumber", "", "");
            String text_4;
            text_4 =  Int1To99999Type.encode(this.orderNumber, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // airDefenceSectionId
         if (this.airDefenceSectionId != null)  {
            encoder.encodeStartElement("airDefenceSectionId", "", "");
            this.airDefenceSectionId.encode(encoder, xbContext, null, false);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class UnitDefenceType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "UnitDefenceType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unit"),
         new XBQualifiedName("","unitHq"),
         new XBQualifiedName("","priority"),
         new XBQualifiedName("","comment")
      };
      static UnitDefenceType() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unit;
      protected  Nc1ObjectRefType unitHq;   //optional
      protected int priority;
      protected bool _set_priority = false;
      protected string comment;
      protected bool _set_comment = false;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType Unit
      {
         get
         {
            if (this.unit == null)
                throw new XBException("field unit not set");

            return this.unit;
         }
         set
         {
            this.unit = value;
         }
      }

      public  Nc1ObjectRefType UnitHq
      {
         get
         {
            if (this.unitHq == null)
                throw new XBException("field unitHq not set");

            return this.unitHq;
         }
         set
         {
            this.unitHq = value;
         }
      }

      public int Priority
      {
         get
         {
            if (!_set_priority)
                throw new XBException("field priority not set");

            return this.priority;
         }
         set
         {
            this.priority = value;
            _set_priority = true;
         }
      }

      public string Comment
      {
         get
         {
            if (!_set_comment) throw new XBException("field comment not set");

            return this.comment;
         }
         set
         {
            this.comment = value;
            _set_comment = true;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // unit
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.unit = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.unit.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "unit");

               // unitHq
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.unitHq = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.unitHq.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // priority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.priority =  PriorityCode.decode(text, xbContext);

                  _set_priority = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  LongTextType.decode(text, xbContext);

                  _set_comment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // unit
         if (this.unit == null) throw new XBException("field unit not set");

         encoder.encodeStartElement("unit", "", "");
         this.unit.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // unitHq
         if (this.unitHq != null)  {
            encoder.encodeStartElement("unitHq", "", "");
            this.unitHq.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // priority
         if (_set_priority)  {
            encoder.encodeStartElement("priority", "", "");
            String text_4;
            text_4 =  PriorityCode.encode(this.priority, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.comment, xbContext);
            encoder.encodeChars(text_4);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitToDefend"),
         new XBQualifiedName("","unitToEscort"),
         new XBQualifiedName("","elementToDefend")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  UnitDefenceType unitToDefend;   //optional
      protected  UnitDefenceType unitToEscort;   //optional
      protected  ElementDefenceType elementToDefend;   //optional

      //attribute methods

      //content methods

      public  UnitDefenceType UnitToDefend
      {
         get
         {
            if (this.unitToDefend == null)
                throw new XBException("field unitToDefend not set");

            return this.unitToDefend;
         }
         set
         {
            this.unitToDefend = value;
         }
      }

      public  UnitDefenceType UnitToEscort
      {
         get
         {
            if (this.unitToEscort == null)
                throw new XBException("field unitToEscort not set");

            return this.unitToEscort;
         }
         set
         {
            this.unitToEscort = value;
         }
      }

      public  ElementDefenceType ElementToDefend
      {
         get
         {
            if (this.elementToDefend == null)
                throw new XBException("field elementToDefend not set");

            return this.elementToDefend;
         }
         set
         {
            this.elementToDefend = value;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // unitToDefend
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.unitToDefend = new  UnitDefenceType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.unitToDefend.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // unitToEscort
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.unitToEscort = new  UnitDefenceType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.unitToEscort.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // elementToDefend
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.elementToDefend = new  ElementDefenceType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.elementToDefend.decode(reader, xbContext, false, false);

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

         // unitToDefend
         if (this.unitToDefend != null)  {
            encoder.encodeStartElement("unitToDefend", "", "");
            this.unitToDefend.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // unitToEscort
         if (this.unitToEscort != null)  {
            encoder.encodeStartElement("unitToEscort", "", "");
            this.unitToEscort.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // elementToDefend
         if (this.elementToDefend != null)  {
            encoder.encodeStartElement("elementToDefend", "", "");
            this.elementToDefend.encode(encoder, xbContext, null, false);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","area"),
         new XBQualifiedName("","verticalLevel")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType area;
      protected  LevelsType verticalLevel;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType Area
      {
         get
         {
            if (this.area == null)
                throw new XBException("field area not set");

            return this.area;
         }
         set
         {
            this.area = value;
         }
      }

      public  LevelsType VerticalLevel
      {
         get
         {
            if (this.verticalLevel == null)
                throw new XBException("field verticalLevel not set");

            return this.verticalLevel;
         }
         set
         {
            this.verticalLevel = value;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // area
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.area = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.area.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "area");

               // verticalLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.verticalLevel = new  LevelsType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.verticalLevel.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "verticalLevel");

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // area
         if (this.area == null) throw new XBException("field area not set");

         encoder.encodeStartElement("area", "", "");
         this.area.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // verticalLevel
         if (this.verticalLevel == null)
             throw new XBException("field verticalLevel not set");

         encoder.encodeStartElement("verticalLevel", "", "");
         this.verticalLevel.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","proposedDeploymentArea"),
         new XBQualifiedName("","surveillanceArea"),
         new XBQualifiedName("","comment")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType proposedDeploymentArea;   //optional
      protected  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea surveillanceArea;
         
      protected string comment;
      protected bool _set_comment = false;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType ProposedDeploymentArea
      {
         get
         {
            if (this.proposedDeploymentArea == null)
                throw new XBException("field proposedDeploymentArea not set");

            return this.proposedDeploymentArea;
         }
         set
         {
            this.proposedDeploymentArea = value;
         }
      }

      public  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea SurveillanceArea
      {
         get
         {
            if (this.surveillanceArea == null)
                throw new XBException("field surveillanceArea not set");

            return this.surveillanceArea;
         }
         set
         {
            this.surveillanceArea = value;
         }
      }

      public string Comment
      {
         get
         {
            if (!_set_comment) throw new XBException("field comment not set");

            return this.comment;
         }
         set
         {
            this.comment = value;
            _set_comment = true;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // proposedDeploymentArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.proposedDeploymentArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.proposedDeploymentArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // surveillanceArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.surveillanceArea = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea_surveillanceArea();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.surveillanceArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "surveillanceArea");

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  LongTextType.decode(text, xbContext);

                  _set_comment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // proposedDeploymentArea
         if (this.proposedDeploymentArea != null)  {
            encoder.encodeStartElement("proposedDeploymentArea", "", "");
            this.proposedDeploymentArea.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // surveillanceArea
         if (this.surveillanceArea == null)
             throw new XBException("field surveillanceArea not set");

         encoder.encodeStartElement("surveillanceArea", "", "");
         this.surveillanceArea.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.comment, xbContext);
            encoder.encodeChars(text_4);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","areaLocation"),
         new XBQualifiedName("","role"),
         new XBQualifiedName("","elementToDefend")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType areaLocation;
      protected string role;
      protected bool _set_role = false;
      protected  ElementDefenceType elementToDefend;   //optional

      //attribute methods

      //content methods

      public  Nc1ObjectRefType AreaLocation
      {
         get
         {
            if (this.areaLocation == null)
                throw new XBException("field areaLocation not set");

            return this.areaLocation;
         }
         set
         {
            this.areaLocation = value;
         }
      }

      public string Role
      {
         get
         {
            if (!_set_role) throw new XBException("field role not set");

            return this.role;
         }
         set
         {
            this.role = value;
            _set_role = true;
         }
      }

      public  ElementDefenceType ElementToDefend
      {
         get
         {
            if (this.elementToDefend == null)
                throw new XBException("field elementToDefend not set");

            return this.elementToDefend;
         }
         set
         {
            this.elementToDefend = value;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // areaLocation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.areaLocation = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.areaLocation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "areaLocation");

               // role
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.role =  MediumTextType.decode(text, xbContext);

                  _set_role = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // elementToDefend
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.elementToDefend = new  ElementDefenceType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.elementToDefend.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // areaLocation
         if (this.areaLocation == null)
             throw new XBException("field areaLocation not set");

         encoder.encodeStartElement("areaLocation", "", "");
         this.areaLocation.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // role
         if (_set_role)  {
            encoder.encodeStartElement("role", "", "");
            String text_4;
            text_4 =  MediumTextType.encode(this.role, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // elementToDefend
         if (this.elementToDefend != null)  {
            encoder.encodeStartElement("elementToDefend", "", "");
            this.elementToDefend.encode(encoder, xbContext, null, false);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class SurfaceToAirTypeCode
   {
      static SurfaceToAirTypeCode() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //constructor
      private SurfaceToAirTypeCode() {} 


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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","missionNumber"),
         new XBQualifiedName("","weaponsSystem"),
         new XBQualifiedName("","weaponsSystemUnlisted"),
         new XBQualifiedName("","batteryId"),
         new XBQualifiedName("","batteryCount"),
         new XBQualifiedName("","actualMissionEndDatetime"),
         new XBQualifiedName("","nextMissionStartDatetime"),
         new XBQualifiedName("","specialInstructions"),
         new XBQualifiedName("","particularArea"),
         new XBQualifiedName("","priorityThreat"),
         new XBQualifiedName("","implantationArea"),
         new XBQualifiedName("","specialDefence"),
         new XBQualifiedName("","surveillanceArea"),
         new XBQualifiedName("","defenceArea")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission() 
      {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected ushort missionNumber;
      protected System.Collections.Generic.IList<Int32> weaponsSystem;
      protected System.Collections.Generic.IList<String> weaponsSystemUnlisted;
         
      protected System.Collections.Generic.IList< Nc1ObjectRefType> batteryId;
         
      protected byte batteryCount;
      protected bool _set_batteryCount = false;
      protected string actualMissionEndDatetime;
      protected bool _set_actualMissionEndDatetime = false;
      protected string nextMissionStartDatetime;
      protected bool _set_nextMissionStartDatetime = false;
      protected string specialInstructions;
      protected bool _set_specialInstructions = false;
      protected System.Collections.Generic.IList< Nc1ObjectRefType> particularArea;
         
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat> priorityThreat;
         
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea> implantationArea;
         
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence> specialDefence;
         
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea> surveillanceArea;
         
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea> defenceArea;
         

      //attribute methods

      //content methods

      public ushort MissionNumber
      {
         get { return this.missionNumber; }
         set { this.missionNumber = value; }
      }

      public System.Collections.Generic.IList<Int32> WeaponsSystem
      {
         get
         {
            if (this.weaponsSystem == null) {
               this.weaponsSystem = new List<Int32>();
            }
            return this.weaponsSystem;
         }
      }

      public System.Collections.Generic.IList<String> WeaponsSystemUnlisted
      {
         get
         {
            if (this.weaponsSystemUnlisted == null) {
               this.weaponsSystemUnlisted = new List<String>();
            }
            return this.weaponsSystemUnlisted;
         }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> BatteryId
      {
         get
         {
            if (this.batteryId == null) {
               this.batteryId = new List< Nc1ObjectRefType>();
            }
            return this.batteryId;
         }
      }

      public byte BatteryCount
      {
         get
         {
            if (!_set_batteryCount)
                throw new XBException("field batteryCount not set");

            return this.batteryCount;
         }
         set
         {
            this.batteryCount = value;
            _set_batteryCount = true;
         }
      }

      public string ActualMissionEndDatetime
      {
         get
         {
            if (!_set_actualMissionEndDatetime)
                throw new XBException("field actualMissionEndDatetime not set");

            return this.actualMissionEndDatetime;
         }
         set
         {
            this.actualMissionEndDatetime = value;
            _set_actualMissionEndDatetime = true;
         }
      }

      public string NextMissionStartDatetime
      {
         get
         {
            if (!_set_nextMissionStartDatetime)
                throw new XBException("field nextMissionStartDatetime not set");

            return this.nextMissionStartDatetime;
         }
         set
         {
            this.nextMissionStartDatetime = value;
            _set_nextMissionStartDatetime = true;
         }
      }

      public string SpecialInstructions
      {
         get
         {
            if (!_set_specialInstructions)
                throw new XBException("field specialInstructions not set");

            return this.specialInstructions;
         }
         set
         {
            this.specialInstructions = value;
            _set_specialInstructions = true;
         }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> ParticularArea
      {
         get
         {
            if (this.particularArea == null) {
               this.particularArea = new List< Nc1ObjectRefType>();
            }
            return this.particularArea;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat> PriorityThreat
      {
         get
         {
            if (this.priorityThreat == null) {
               this.priorityThreat = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat>()
                  ;
            }
            return this.priorityThreat;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea> ImplantationArea
      {
         get
         {
            if (this.implantationArea == null) {
               this.implantationArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea>()
                  ;
            }
            return this.implantationArea;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence> SpecialDefence
      {
         get
         {
            if (this.specialDefence == null) {
               this.specialDefence = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence>()
                  ;
            }
            return this.specialDefence;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea> SurveillanceArea
      {
         get
         {
            if (this.surveillanceArea == null) {
               this.surveillanceArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea>()
                  ;
            }
            return this.surveillanceArea;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea> DefenceArea
      {
         get
         {
            if (this.defenceArea == null) {
               this.defenceArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea>()
                  ;
            }
            return this.defenceArea;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // missionNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.missionNumber = XBSimpleType.parseUInt16(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionNumber");

               // weaponsSystem
               this.weaponsSystem = new List<Int32>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  int _tmp_weaponsSystem;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  _tmp_weaponsSystem =  SurfaceToAirTypeCode.decode(text, xbContext);
                  this.weaponsSystem.Add(_tmp_weaponsSystem);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.weaponsSystem.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.weaponsSystem.Count, "weaponsSystem");
               else if (this.weaponsSystem.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // weaponsSystemUnlisted
               this.weaponsSystemUnlisted = new List<String>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  string _tmp_weaponsSystemUnlisted;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  _tmp_weaponsSystemUnlisted =  ShortTextType.decode(text, xbContext);
                  this.weaponsSystemUnlisted.Add(_tmp_weaponsSystemUnlisted);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // batteryId
               this.batteryId = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_batteryId;
                  _tmp_batteryId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_batteryId.decode(reader, xbContext, false, false);
                  this.batteryId.Add(_tmp_batteryId);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // batteryCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.batteryCount =  Int0To99Type.decode(text, xbContext);

                  _set_batteryCount = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // actualMissionEndDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.actualMissionEndDatetime = text;

                  _set_actualMissionEndDatetime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nextMissionStartDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.nextMissionStartDatetime = text;

                  _set_nextMissionStartDatetime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // specialInstructions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.specialInstructions =  MediumTextType.decode(text, xbContext);

                  _set_specialInstructions = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // particularArea
               this.particularArea = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_particularArea;
                  _tmp_particularArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_particularArea.decode(reader, xbContext, false, false);
                  this.particularArea.Add(_tmp_particularArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // priorityThreat
               this.priorityThreat = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat _tmp_priorityThreat;
                  _tmp_priorityThreat = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_priorityThreat.decode(reader, xbContext, false, false);
                  this.priorityThreat.Add(_tmp_priorityThreat);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // implantationArea
               this.implantationArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea _tmp_implantationArea;
                  _tmp_implantationArea = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_implantationArea.decode(reader, xbContext, false, false);
                  this.implantationArea.Add(_tmp_implantationArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // specialDefence
               this.specialDefence = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[11], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence _tmp_specialDefence;
                  _tmp_specialDefence = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_specialDefence.decode(reader, xbContext, false, false);
                  this.specialDefence.Add(_tmp_specialDefence);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // surveillanceArea
               this.surveillanceArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[12], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea _tmp_surveillanceArea;
                  _tmp_surveillanceArea = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_surveillanceArea.decode(reader, xbContext, false, false);
                  this.surveillanceArea.Add(_tmp_surveillanceArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // defenceArea
               this.defenceArea = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[13], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea _tmp_defenceArea;
                  _tmp_defenceArea = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_defenceArea.decode(reader, xbContext, false, false);
                  this.defenceArea.Add(_tmp_defenceArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // missionNumber
         encoder.encodeStartElement("missionNumber", "", "");
         String text_3;
         text_3 = this.missionNumber.ToString();
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // weaponsSystem
         if (this.weaponsSystem == null || this.weaponsSystem.Count < 1) 
            throw new XBOccurrencesException( (this.weaponsSystem == null ? 0 : this.weaponsSystem.Count ) );

         foreach (int _tmp_weaponsSystem in this.weaponsSystem){
            encoder.encodeStartElement("weaponsSystem", "", "");
            text_3 =  SurfaceToAirTypeCode.encode(_tmp_weaponsSystem, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // weaponsSystemUnlisted
         if ( this.weaponsSystemUnlisted != null ){
            foreach (string _tmp_weaponsSystemUnlisted in this.weaponsSystemUnlisted)
            {
               encoder.encodeStartElement("weaponsSystemUnlisted", "", "");
               text_3 =  ShortTextType.encode(_tmp_weaponsSystemUnlisted, xbContext);
               encoder.encodeChars(text_3);
               encoder.encodeEndElement();
            }
         }

         // batteryId
         if ( this.batteryId != null ){
            foreach ( Nc1ObjectRefType _tmp_batteryId in this.batteryId)
            {
               encoder.encodeStartElement("batteryId", "", "");
               _tmp_batteryId.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // batteryCount
         if (_set_batteryCount)  {
            encoder.encodeStartElement("batteryCount", "", "");
            text_3 =  Int0To99Type.encode(this.batteryCount, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // actualMissionEndDatetime
         if (_set_actualMissionEndDatetime)  {
            encoder.encodeStartElement("actualMissionEndDatetime", "", "");
            text_3 = this.actualMissionEndDatetime;
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // nextMissionStartDatetime
         if (_set_nextMissionStartDatetime)  {
            encoder.encodeStartElement("nextMissionStartDatetime", "", "");
            text_3 = this.nextMissionStartDatetime;
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // specialInstructions
         if (_set_specialInstructions)  {
            encoder.encodeStartElement("specialInstructions", "", "");
            text_3 =  MediumTextType.encode(this.specialInstructions, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // particularArea
         if ( this.particularArea != null ){
            foreach ( Nc1ObjectRefType _tmp_particularArea in this.particularArea)
            {
               encoder.encodeStartElement("particularArea", "", "");
               _tmp_particularArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // priorityThreat
         if ( this.priorityThreat != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_priorityThreat _tmp_priorityThreat in this.priorityThreat)
            {
               encoder.encodeStartElement("priorityThreat", "", "");
               _tmp_priorityThreat.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // implantationArea
         if ( this.implantationArea != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_implantationArea _tmp_implantationArea in this.implantationArea)
            {
               encoder.encodeStartElement("implantationArea", "", "");
               _tmp_implantationArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // specialDefence
         if ( this.specialDefence != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_specialDefence _tmp_specialDefence in this.specialDefence)
            {
               encoder.encodeStartElement("specialDefence", "", "");
               _tmp_specialDefence.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // surveillanceArea
         if ( this.surveillanceArea != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_surveillanceArea _tmp_surveillanceArea in this.surveillanceArea)
            {
               encoder.encodeStartElement("surveillanceArea", "", "");
               _tmp_surveillanceArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // defenceArea
         if ( this.defenceArea != null ){
            foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission_defenceArea _tmp_defenceArea in this.defenceArea)
            {
               encoder.encodeStartElement("defenceArea", "", "");
               _tmp_defenceArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData_airDefenceUnitMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData_airDefenceUnitMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","airDefenceUnitId"),
         new XBQualifiedName("","airDefenceMission")
      };
      static MissionASAType_2_tacticalData_airDefenceUnitMission() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType airDefenceUnitId;
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission> airDefenceMission;
         

      //attribute methods

      //content methods

      public  Nc1ObjectRefType AirDefenceUnitId
      {
         get
         {
            if (this.airDefenceUnitId == null)
                throw new XBException("field airDefenceUnitId not set");

            return this.airDefenceUnitId;
         }
         set
         {
            this.airDefenceUnitId = value;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission> AirDefenceMission
      {
         get
         {
            if (this.airDefenceMission == null) {
               this.airDefenceMission = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission>()
                  ;
            }
            return this.airDefenceMission;
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
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // airDefenceUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.airDefenceUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.airDefenceUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airDefenceUnitId");

               // airDefenceMission
               this.airDefenceMission = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission _tmp_airDefenceMission;
                  _tmp_airDefenceMission = new  MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_airDefenceMission.decode(reader, xbContext, false, false);
                  this.airDefenceMission.Add(_tmp_airDefenceMission);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.airDefenceMission.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.airDefenceMission.Count, "airDefenceMission");
               else if (this.airDefenceMission.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // airDefenceUnitId
         if (this.airDefenceUnitId == null)
             throw new XBException("field airDefenceUnitId not set");

         encoder.encodeStartElement("airDefenceUnitId", "", "");
         this.airDefenceUnitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // airDefenceMission
         if (this.airDefenceMission == null || this.airDefenceMission.Count < 1
            ) 
            throw new XBOccurrencesException( (this.airDefenceMission == null ? 0 : this.airDefenceMission.Count ) );

         foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission_airDefenceMission _tmp_airDefenceMission in this.airDefenceMission)
         {
            encoder.encodeStartElement("airDefenceMission", "", "");
            _tmp_airDefenceMission.encode(encoder, xbContext, null, false);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType_2_tacticalData : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType_2_tacticalData");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","airDefenceMissionNumber"),
         new XBQualifiedName("","tacticalPhase"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","airDefenceUnitMission"),
         new XBQualifiedName("","url"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","extVersion")
      };
      static MissionASAType_2_tacticalData() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string airDefenceMissionNumber;
      protected bool _set_airDefenceMissionNumber = false;
      protected int tacticalPhase;
      protected bool _set_tacticalPhase = false;
      protected  PeriodType validityPeriod;   //optional
      protected System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission> airDefenceUnitMission;
         
      protected string url;
      protected bool _set_url = false;
      protected string comment;
      protected bool _set_comment = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public string AirDefenceMissionNumber
      {
         get
         {
            if (!_set_airDefenceMissionNumber)
                throw new XBException("field airDefenceMissionNumber not set");

            return this.airDefenceMissionNumber;
         }
         set
         {
            this.airDefenceMissionNumber = value;
            _set_airDefenceMissionNumber = true;
         }
      }

      public int TacticalPhase
      {
         get
         {
            if (!_set_tacticalPhase)
                throw new XBException("field tacticalPhase not set");

            return this.tacticalPhase;
         }
         set
         {
            this.tacticalPhase = value;
            _set_tacticalPhase = true;
         }
      }

      public  PeriodType ValidityPeriod
      {
         get
         {
            if (this.validityPeriod == null)
                throw new XBException("field validityPeriod not set");

            return this.validityPeriod;
         }
         set
         {
            this.validityPeriod = value;
         }
      }

      public System.Collections.Generic.IList< MissionASAType_2_tacticalData_airDefenceUnitMission> AirDefenceUnitMission
      {
         get
         {
            if (this.airDefenceUnitMission == null) {
               this.airDefenceUnitMission = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission>()
                  ;
            }
            return this.airDefenceUnitMission;
         }
      }

      public string Url
      {
         get
         {
            if (!_set_url) throw new XBException("field url not set");

            return this.url;
         }
         set
         {
            this.url = value;
            _set_url = true;
         }
      }

      public string Comment
      {
         get
         {
            if (!_set_comment) throw new XBException("field comment not set");

            return this.comment;
         }
         set
         {
            this.comment = value;
            _set_comment = true;
         }
      }

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

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected virtual void validateAttrs(bool[] _attrPresenceFlags){
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {
         return false;
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

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

               // airDefenceMissionNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.airDefenceMissionNumber =  ShortTextObjectType.decode(text, xbContext);

                  _set_airDefenceMissionNumber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // tacticalPhase
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.tacticalPhase =  L114_10Code.decode(text, xbContext);

                  _set_tacticalPhase = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // validityPeriod
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.validityPeriod = new  PeriodType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.validityPeriod.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airDefenceUnitMission
               this.airDefenceUnitMission = 
                  new List< MissionASAType_2_tacticalData_airDefenceUnitMission>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   MissionASAType_2_tacticalData_airDefenceUnitMission _tmp_airDefenceUnitMission;
                  _tmp_airDefenceUnitMission = new  MissionASAType_2_tacticalData_airDefenceUnitMission();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_airDefenceUnitMission.decode(reader, xbContext, false, false);
                  this.airDefenceUnitMission.Add(_tmp_airDefenceUnitMission);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.airDefenceUnitMission.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.airDefenceUnitMission.Count, "airDefenceUnitMission");
               else if (this.airDefenceUnitMission.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // url
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.url =  MediumTextObjectType.decode(text, xbContext);

                  _set_url = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  LongTextObjectType.decode(text, xbContext);

                  _set_comment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.extVersion = new  ExtVersType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.extVersion.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               if (decodeAllContent && moreContent_4) 
                  throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            }
            else throw new XBOccurrencesException(0);
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

         // airDefenceMissionNumber
         if (_set_airDefenceMissionNumber)  {
            encoder.encodeStartElement("airDefenceMissionNumber", "", "");
            String text_4;
            text_4 =  ShortTextObjectType.encode(this.airDefenceMissionNumber, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // tacticalPhase
         if (_set_tacticalPhase)  {
            encoder.encodeStartElement("tacticalPhase", "", "");
            String text_4;
            text_4 =  L114_10Code.encode(this.tacticalPhase, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // validityPeriod
         if (this.validityPeriod != null)  {
            encoder.encodeStartElement("validityPeriod", "", "");
            this.validityPeriod.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // airDefenceUnitMission
         if (this.airDefenceUnitMission == null || 
            this.airDefenceUnitMission.Count < 1) 
            throw new XBOccurrencesException( (this.airDefenceUnitMission == null ? 0 : this.airDefenceUnitMission.Count ) );

         foreach ( MissionASAType_2_tacticalData_airDefenceUnitMission _tmp_airDefenceUnitMission in this.airDefenceUnitMission)
         {
            encoder.encodeStartElement("airDefenceUnitMission", "", "");
            _tmp_airDefenceUnitMission.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // url
         if (_set_url)  {
            encoder.encodeStartElement("url", "", "");
            String text_4;
            text_4 =  MediumTextObjectType.encode(this.url, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            String text_4;
            text_4 =  LongTextObjectType.encode(this.comment, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // extVersion
         if (this.extVersion != null)  {
            encoder.encodeStartElement("extVersion", "", "");
            this.extVersion.encode(encoder, xbContext, null, false);
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
            decodeAttr(name, ns, prefix, text, null, xbContext);
         }
         validateAttrs(null);

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

   public class MissionASAType :  BaseObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASA",
          "MissionASAType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","tacticalData")
      };
      static MissionASAType() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  MissionASAType_2_tacticalData tacticalData;   //optional
         

      //attribute methods

      //content methods

      public  MissionASAType_2_tacticalData TacticalData
      {
         get
         {
            if (this.tacticalData == null)
                throw new XBException("field tacticalData not set");

            return this.tacticalData;
         }
         set
         {
            this.tacticalData = value;
         }
      }

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
         try  {
            bool moreContent_4;
            moreContent_4 = base.decodeContent(reader, xbContext, false);
            if ( moreContent_4 ) {
               String elemLocalName = null;
               String elemNs = null;
               elemLocalName = reader.LocalName;
               elemNs = reader.NamespaceURI;

               // tacticalData
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.tacticalData = new  MissionASAType_2_tacticalData();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.tacticalData.decode(reader, xbContext, false, false);

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
      protected override void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeContent(encoder, xbContext);

         // tacticalData
         if (this.tacticalData != null)  {
            encoder.encodeStartElement("tacticalData", "", "");
            this.tacticalData.encode(encoder, xbContext, null, false);
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

   public class NC1_MissionASA_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:objet:missionASA","NC1_MissionASA")
      };
      static NC1_MissionASA_CC() {
         XBUtil.license =  _NC1_MissionASA.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MissionASAType nC1_MissionASA;

      //content methods

      public  MissionASAType NC1_MissionASA
      {
         get
         {
            if (this.nC1_MissionASA == null)
                throw new XBException("field nC1_MissionASA not set");

            return this.nC1_MissionASA;
         }
         set
         {
            this.nC1_MissionASA = value;
         }
      }


      public void decodeDocument(XmlTextReader reader) {
         XMLStreamHelper.beginDocumentDecode(reader);
         decode(reader, _xbContext);
      }

      /**
       * Encode contents of this class as entire document.
       */
      public void encodeDocument(XBXmlEncoder encoder) {
         //To use the generated namespace prefixes do the following:
         //   encoder.setNamespaces(_NC1_MissionASA.namespaceContext);

         encoder.encodeStartDocument();
         encode(encoder, _xbContext);
      }

      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is on corresponding END_ELEMENT.
       */
      public virtual void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         xbContext.clearSchemaLocationAttrs();

         //decode content
         try  {
            String elemLocalName = null;
            String elemNs = null;
            elemLocalName = reader.LocalName;
            elemNs = reader.NamespaceURI;

            // nC1_MissionASA
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_MissionASA = new  MissionASAType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_MissionASA.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_MissionASA");

            if (moreContent_4) 
               throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
         }
         catch( System.Xml.XmlException e )  {
            throw new XBException(e.ToString(), e);
         }
      }


      /**
       * Encode contents of this class as XML content.
       */
      public virtual void encode(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         //encode content

         // nC1_MissionASA
         if (this.nC1_MissionASA == null)
             throw new XBException("field nC1_MissionASA not set");

         encoder.encodeStartElement("NC1_MissionASA",  _NC1_MissionASA.NS_URI,  _NC1_MissionASA.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_MissionASA.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();
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

   public class _NC1_MissionASA {

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
      public static readonly String NS_URI = "urn:fra:nc1:objet:missionASA";
      public static readonly String NS_PREFIX = "nc1missionASA";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_MissionASA() {
      }
      static _NC1_MissionASA() {
         XBUtil.license = _NC1_MissionASA.license;
      }
   }
}
