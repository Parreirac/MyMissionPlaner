using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Msg
{

   using System.IO;
   using System.Xml;
   using com.objsys.xbinder.runtime;
    using NC1.Msg;
    using NC1.Obj;
    using AltitudeType = NC1.Location.AltitudeType;
    using NC1.Dictionnaries;
    using NC1.Obj.unit;
    using GroundEntityType = NC1.Obj.groundentity.GroundEntityType;
    using FacilityType = NC1.Obj.facility.FacilityType;
    using RouteType = NC1.Obj.route.RouteType;
    using ReinforcementType = NC1.Obj.reinforcement.ReinforcementType;
    using ObstacleType = NC1.Obj.obstacle.ObstacleType;




    public class TaskOrganisationMemberSimplifiedType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "TaskOrganisationMemberSimplifiedType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","unit"),
         new XBQualifiedName("","description"),
         new XBQualifiedName("","reinforcement")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[2], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, unit, description, reinforcement}
      protected Choice _whichField;
      static TaskOrganisationMemberSimplifiedType_1() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  UnitType unit;
      protected string description;
      protected  ReinforcementType reinforcement;

      //content methods

      public  UnitType Unit
      {
         get
         {
            if (_whichField != Choice.unit ) 
               throw new XBException("field unit not set");
            return this.unit;
         }
         set
         {
            this.unit = value;
            _whichField = Choice.unit;
         }
      }

      public string Description
      {
         get
         {
            if (_whichField != Choice.description ) 
               throw new XBException("field description not set");
            return this.description;
         }
         set
         {
            this.description = value;
            _whichField = Choice.description;
         }
      }

      public  ReinforcementType Reinforcement
      {
         get
         {
            if (_whichField != Choice.reinforcement ) 
               throw new XBException("field reinforcement not set");
            return this.reinforcement;
         }
         set
         {
            this.reinforcement = value;
            _whichField = Choice.reinforcement;
         }
      }

      public Choice getWhichField() { return _whichField; }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is just beyond last node for last elementit validated.
       */
      public virtual void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext) 
      {

         //decode content
         try  {
            String elemLocalName = null;
            String elemNs = null;
            elemLocalName = reader.LocalName;
            elemNs = reader.NamespaceURI;

            // unit
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.unit = new  UnitType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.unit.decode(reader, xbContext, false, false);
               _whichField = Choice.unit;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // description
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               this.description =  LongTextType.decode(text, xbContext);
               _whichField = Choice.description;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // reinforcement
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               this.reinforcement = new  ReinforcementType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.reinforcement.decode(reader, xbContext, false, false);
               _whichField = Choice.reinforcement;

               XMLStreamHelper.moveToContentElement(reader);
            }
            else throw new XBException("Unexpected element: "
                + XBQualifiedName.toString(elemNs, elemLocalName) );
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
         if ( _whichField == Choice.None ) 
            throw new XBException("no field set in choice group");

         switch( _whichField )  {

            // unit
            case Choice.unit: {
               if (_whichField != Choice.unit ) 
                  throw new XBException("field unit not set");
               encoder.encodeStartElement("unit", "", "");
               this.unit.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // description
            case Choice.description: {
               if (_whichField != Choice.description ) 
                  throw new XBException("field description not set");
               encoder.encodeStartElement("description", "", "");
               String text_5;
               text_5 =  LongTextType.encode(this.description, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }

            // reinforcement
            case Choice.reinforcement: {
               if (_whichField != Choice.reinforcement ) 
                  throw new XBException("field reinforcement not set");
               encoder.encodeStartElement("reinforcement", "", "");
               this.reinforcement.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class TaskOrganisationMemberSimplifiedType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "TaskOrganisationMemberSimplifiedType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {

      };
      static TaskOrganisationMemberSimplifiedType() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  TaskOrganisationMemberSimplifiedType_1 taskOrganisationMemberSimplifiedType_1;
         

      //attribute methods

      //content methods

      public  TaskOrganisationMemberSimplifiedType_1 TaskOrganisationMemberSimplifiedType_1
      {
         get
         {
            if (this.taskOrganisationMemberSimplifiedType_1 == null)
                throw new XBException("field taskOrganisationMemberSimplifiedType_1 not set");

            return this.taskOrganisationMemberSimplifiedType_1;
         }
         set
         {
            this.taskOrganisationMemberSimplifiedType_1 = value;
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

               // taskOrganisationMemberSimplifiedType_1
               if( moreContent_4 && 
                   TaskOrganisationMemberSimplifiedType_1.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.taskOrganisationMemberSimplifiedType_1 = new  TaskOrganisationMemberSimplifiedType_1();
                  this.taskOrganisationMemberSimplifiedType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "taskOrganisationMemberSimplifiedType_1");

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

         // taskOrganisationMemberSimplifiedType_1
         if (this.taskOrganisationMemberSimplifiedType_1 == null)
             throw new XBException("field taskOrganisationMemberSimplifiedType_1 not set");

         this.taskOrganisationMemberSimplifiedType_1.encode(encoder, xbContext);
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

   public class NC1_OPORD_ELEM_2_objectsGlobal : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2_objectsGlobal");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","object")
      };
      static NC1_OPORD_ELEM_2_objectsGlobal() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< BaseObjectType> object_;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< BaseObjectType> Object_
      {
         get
         {
            if (this.object_ == null) {
               this.object_ = new List< BaseObjectType>();
            }
            return this.object_;
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

               // object_
               this.object_ = new List< BaseObjectType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   BaseObjectType _tmp_object_;
                  _tmp_object_ =  BaseObjectType.createObject(
                     XMLStreamHelper.readXsiType(reader) );
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_object_.decode(reader, xbContext, false, false);
                  this.object_.Add(_tmp_object_);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.object_.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.object_.Count, "object_");
               else if (this.object_.Count == 0 && moreContent_4) 
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

         // object_
         if (this.object_ == null || this.object_.Count < 1) 
            throw new XBOccurrencesException( (this.object_ == null ? 0 : this.object_.Count ) );

         foreach ( BaseObjectType _tmp_object_ in this.object_){
            encoder.encodeStartElement("object", "", "");
            _tmp_object_.encode(encoder, xbContext, 
                BaseObjectType.XSD_TYPE, false);
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

   public class OrderCategoryCode
   {
      static OrderCategoryCode() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //constructor
      private OrderCategoryCode() {} 


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

   public class NC1_OPORD_ELEM_2_orderCategory : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2_orderCategory");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","category"),
         new XBQualifiedName("","number")
      };
      static NC1_OPORD_ELEM_2_orderCategory() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int category;
      protected byte number;

      //attribute methods

      //content methods

      public int Category
      {
         get { return this.category; }
         set { this.category = value; }
      }

      public byte Number
      {
         get { return this.number; }
         set { this.number = value; }
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

               // category
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.category =  OrderCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "category");

               // number
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.number =  Int0To99Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "number");

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

         // category
         encoder.encodeStartElement("category", "", "");
         String text_3;
         text_3 =  OrderCategoryCode.encode(this.category, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // number
         encoder.encodeStartElement("number", "", "");
         text_3 =  Int0To99Type.encode(this.number, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
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

   public class NC1_OPORD_ELEM_2_taskOrganisation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2_taskOrganisation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","member")
      };
      static NC1_OPORD_ELEM_2_taskOrganisation() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< TaskOrganisationMemberSimplifiedType> member;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< TaskOrganisationMemberSimplifiedType> Member
      {
         get
         {
            if (this.member == null) {
               this.member = 
                  new List< TaskOrganisationMemberSimplifiedType>();
            }
            return this.member;
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

               // member
               this.member = 
                  new List< TaskOrganisationMemberSimplifiedType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   TaskOrganisationMemberSimplifiedType _tmp_member;
                  _tmp_member = new  TaskOrganisationMemberSimplifiedType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_member.decode(reader, xbContext, false, false);
                  this.member.Add(_tmp_member);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.member.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.member.Count, "member");
               else if (this.member.Count == 0 && moreContent_4) 
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

         // member
         if (this.member == null || this.member.Count < 1) 
            throw new XBOccurrencesException( (this.member == null ? 0 : this.member.Count ) );

         foreach ( TaskOrganisationMemberSimplifiedType _tmp_member in this.member)
         {
            encoder.encodeStartElement("member", "", "");
            _tmp_member.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","assessment")
      };
      static NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string assessment;
      protected bool _set_assessment = false;

      //attribute methods

      //content methods

      public string Assessment
      {
         get
         {
            if (!_set_assessment)
                throw new XBException("field assessment not set");

            return this.assessment;
         }
         set
         {
            this.assessment = value;
            _set_assessment = true;
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

               // assessment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.assessment =  WideTextType.decode(text, xbContext);

                  _set_assessment = true;

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

         // assessment
         if (_set_assessment)  {
            encoder.encodeStartElement("assessment", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.assessment, xbContext);
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

   public class NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ME1"),
         new XBQualifiedName("","ME2")
      };
      static NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MixedAnyType mE1;   //optional
      protected  MixedAnyType mE2;   //optional

      //attribute methods

      //content methods

      public  MixedAnyType ME1
      {
         get
         {
            if (this.mE1 == null) throw new XBException("field mE1 not set");

            return this.mE1;
         }
         set
         {
            this.mE1 = value;
         }
      }

      public  MixedAnyType ME2
      {
         get
         {
            if (this.mE2 == null) throw new XBException("field mE2 not set");

            return this.mE2;
         }
         set
         {
            this.mE2 = value;
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

               // mE1
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.mE1 = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.mE1.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // mE2
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.mE2 = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.mE2.decode(reader, xbContext, false, false);

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

         // mE1
         if (this.mE1 != null)  {
            encoder.encodeStartElement("ME1", "", "");
            this.mE1.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // mE2
         if (this.mE2 != null)  {
            encoder.encodeStartElement("ME2", "", "");
            this.mE2.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","description")
      };
      static NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected bool _set_name = false;
      protected  MixedAnyType description;   //optional

      //attribute methods

      //content methods

      public string Name
      {
         get
         {
            if (!_set_name) throw new XBException("field name not set");

            return this.name;
         }
         set
         {
            this.name = value;
            _set_name = true;
         }
      }

      public  MixedAnyType Description
      {
         get
         {
            if (this.description == null)
                throw new XBException("field description not set");

            return this.description;
         }
         set
         {
            this.description = value;
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

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  MediumTextType.decode(text, xbContext);

                  _set_name = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // description
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.description = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.description.decode(reader, xbContext, false, false);

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

         // name
         if (_set_name)  {
            encoder.encodeStartElement("name", "", "");
            String text_4;
            text_4 =  MediumTextType.encode(this.name, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // description
         if (this.description != null)  {
            encoder.encodeStartElement("description", "", "");
            this.description.encode(encoder, xbContext, null, false);
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

   public class SectionStatusCode
   {
      static SectionStatusCode() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //constructor
      private SectionStatusCode() {} 


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

   public class NC1_OPORD_ELEM_2__1_situation_A_enemySituation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_A_enemySituation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","enemySituationSectionStatus"),
         new XBQualifiedName("","enemySituationGlobal"),
         new XBQualifiedName("","generalAssessment"),
         new XBQualifiedName("","globalEnemy"),
         new XBQualifiedName("","initialEnemy"),
         new XBQualifiedName("","laterEnemy"),
         new XBQualifiedName("","inReactionEnemy"),
         new XBQualifiedName("","futureEnemy"),
         new XBQualifiedName("","threat")
      };
      static NC1_OPORD_ELEM_2__1_situation_A_enemySituation() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int enemySituationSectionStatus;
      protected bool _set_enemySituationSectionStatus = false;
      protected  MixedAnyType enemySituationGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment generalAssessment;
            //optional
      protected  MixedAnyType globalEnemy;   //optional
      protected  MixedAnyType initialEnemy;   //optional
      protected  MixedAnyType laterEnemy;   //optional
      protected  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy inReactionEnemy;
            //optional
      protected  MixedAnyType futureEnemy;   //optional
      protected System.Collections.Generic.IList< NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat> threat;
         

      //attribute methods

      //content methods

      public int EnemySituationSectionStatus
      {
         get
         {
            if (!_set_enemySituationSectionStatus)
                throw new XBException("field enemySituationSectionStatus not set");

            return this.enemySituationSectionStatus;
         }
         set
         {
            this.enemySituationSectionStatus = value;
            _set_enemySituationSectionStatus = true;
         }
      }

      public  MixedAnyType EnemySituationGlobal
      {
         get
         {
            if (this.enemySituationGlobal == null)
                throw new XBException("field enemySituationGlobal not set");

            return this.enemySituationGlobal;
         }
         set
         {
            this.enemySituationGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment GeneralAssessment
      {
         get
         {
            if (this.generalAssessment == null)
                throw new XBException("field generalAssessment not set");

            return this.generalAssessment;
         }
         set
         {
            this.generalAssessment = value;
         }
      }

      public  MixedAnyType GlobalEnemy
      {
         get
         {
            if (this.globalEnemy == null)
                throw new XBException("field globalEnemy not set");

            return this.globalEnemy;
         }
         set
         {
            this.globalEnemy = value;
         }
      }

      public  MixedAnyType InitialEnemy
      {
         get
         {
            if (this.initialEnemy == null)
                throw new XBException("field initialEnemy not set");

            return this.initialEnemy;
         }
         set
         {
            this.initialEnemy = value;
         }
      }

      public  MixedAnyType LaterEnemy
      {
         get
         {
            if (this.laterEnemy == null)
                throw new XBException("field laterEnemy not set");

            return this.laterEnemy;
         }
         set
         {
            this.laterEnemy = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy InReactionEnemy
      {
         get
         {
            if (this.inReactionEnemy == null)
                throw new XBException("field inReactionEnemy not set");

            return this.inReactionEnemy;
         }
         set
         {
            this.inReactionEnemy = value;
         }
      }

      public  MixedAnyType FutureEnemy
      {
         get
         {
            if (this.futureEnemy == null)
                throw new XBException("field futureEnemy not set");

            return this.futureEnemy;
         }
         set
         {
            this.futureEnemy = value;
         }
      }

      public System.Collections.Generic.IList< NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat> Threat
      {
         get
         {
            if (this.threat == null) {
               this.threat = 
                  new List< NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat>()
                  ;
            }
            return this.threat;
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

               // enemySituationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.enemySituationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_enemySituationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // enemySituationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.enemySituationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.enemySituationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // generalAssessment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.generalAssessment = new  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_generalAssessment();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.generalAssessment.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // globalEnemy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.globalEnemy = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.globalEnemy.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // initialEnemy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.initialEnemy = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.initialEnemy.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // laterEnemy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.laterEnemy = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.laterEnemy.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // inReactionEnemy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.inReactionEnemy = new  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_inReactionEnemy();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.inReactionEnemy.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // futureEnemy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.futureEnemy = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.futureEnemy.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // threat
               this.threat = 
                  new List< NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                   NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat _tmp_threat;
                  _tmp_threat = new  NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_threat.decode(reader, xbContext, false, false);
                  this.threat.Add(_tmp_threat);

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

         // enemySituationSectionStatus
         if (_set_enemySituationSectionStatus)  {
            encoder.encodeStartElement("enemySituationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.enemySituationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // enemySituationGlobal
         if (this.enemySituationGlobal != null)  {
            encoder.encodeStartElement("enemySituationGlobal", "", "");
            this.enemySituationGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // generalAssessment
         if (this.generalAssessment != null)  {
            encoder.encodeStartElement("generalAssessment", "", "");
            this.generalAssessment.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // globalEnemy
         if (this.globalEnemy != null)  {
            encoder.encodeStartElement("globalEnemy", "", "");
            this.globalEnemy.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // initialEnemy
         if (this.initialEnemy != null)  {
            encoder.encodeStartElement("initialEnemy", "", "");
            this.initialEnemy.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // laterEnemy
         if (this.laterEnemy != null)  {
            encoder.encodeStartElement("laterEnemy", "", "");
            this.laterEnemy.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // inReactionEnemy
         if (this.inReactionEnemy != null)  {
            encoder.encodeStartElement("inReactionEnemy", "", "");
            this.inReactionEnemy.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // futureEnemy
         if (this.futureEnemy != null)  {
            encoder.encodeStartElement("futureEnemy", "", "");
            this.futureEnemy.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // threat
         if ( this.threat != null ){
            foreach ( NC1_OPORD_ELEM_2__1_situation_A_enemySituation_threat _tmp_threat in this.threat)
            {
               encoder.encodeStartElement("threat", "", "");
               _tmp_threat.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","assessment")
      };
      static NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string assessment;
      protected bool _set_assessment = false;

      //attribute methods

      //content methods

      public string Assessment
      {
         get
         {
            if (!_set_assessment)
                throw new XBException("field assessment not set");

            return this.assessment;
         }
         set
         {
            this.assessment = value;
            _set_assessment = true;
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

               // assessment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.assessment =  WideTextType.decode(text, xbContext);

                  _set_assessment = true;

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

         // assessment
         if (_set_assessment)  {
            encoder.encodeStartElement("assessment", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.assessment, xbContext);
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

   public class NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","localAirSupport"),
         new XBQualifiedName("","airDefenceSupport")
      };
      static NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string localAirSupport;
      protected bool _set_localAirSupport = false;
      protected string airDefenceSupport;
      protected bool _set_airDefenceSupport = false;

      //attribute methods

      //content methods

      public string LocalAirSupport
      {
         get
         {
            if (!_set_localAirSupport)
                throw new XBException("field localAirSupport not set");

            return this.localAirSupport;
         }
         set
         {
            this.localAirSupport = value;
            _set_localAirSupport = true;
         }
      }

      public string AirDefenceSupport
      {
         get
         {
            if (!_set_airDefenceSupport)
                throw new XBException("field airDefenceSupport not set");

            return this.airDefenceSupport;
         }
         set
         {
            this.airDefenceSupport = value;
            _set_airDefenceSupport = true;
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

               // localAirSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.localAirSupport =  WideTextType.decode(text, xbContext);

                  _set_localAirSupport = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airDefenceSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.airDefenceSupport =  WideTextType.decode(text, xbContext);

                  _set_airDefenceSupport = true;

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

         // localAirSupport
         if (_set_localAirSupport)  {
            encoder.encodeStartElement("localAirSupport", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.localAirSupport, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // airDefenceSupport
         if (_set_airDefenceSupport)  {
            encoder.encodeStartElement("airDefenceSupport", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.airDefenceSupport, xbContext);
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

   public class NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ownForcesSituationSectionStatus"),
         new XBQualifiedName("","ownForcesSituationGlobal"),
         new XBQualifiedName("","ownForcesAssessment"),
         new XBQualifiedName("","higherUnitMissions"),
         new XBQualifiedName("","neighbourUnitsMissions"),
         new XBQualifiedName("","airSituation")
      };
      static NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int ownForcesSituationSectionStatus;
      protected bool _set_ownForcesSituationSectionStatus = false;
      protected  MixedAnyType ownForcesSituationGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment ownForcesAssessment;
            //optional
      protected  MixedAnyType higherUnitMissions;   //optional
      protected  MixedAnyType neighbourUnitsMissions;   //optional
      protected  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation airSituation;
            //optional

      //attribute methods

      //content methods

      public int OwnForcesSituationSectionStatus
      {
         get
         {
            if (!_set_ownForcesSituationSectionStatus)
                throw new XBException("field ownForcesSituationSectionStatus not set");

            return this.ownForcesSituationSectionStatus;
         }
         set
         {
            this.ownForcesSituationSectionStatus = value;
            _set_ownForcesSituationSectionStatus = true;
         }
      }

      public  MixedAnyType OwnForcesSituationGlobal
      {
         get
         {
            if (this.ownForcesSituationGlobal == null)
                throw new XBException("field ownForcesSituationGlobal not set");

            return this.ownForcesSituationGlobal;
         }
         set
         {
            this.ownForcesSituationGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment OwnForcesAssessment
      {
         get
         {
            if (this.ownForcesAssessment == null)
                throw new XBException("field ownForcesAssessment not set");

            return this.ownForcesAssessment;
         }
         set
         {
            this.ownForcesAssessment = value;
         }
      }

      public  MixedAnyType HigherUnitMissions
      {
         get
         {
            if (this.higherUnitMissions == null)
                throw new XBException("field higherUnitMissions not set");

            return this.higherUnitMissions;
         }
         set
         {
            this.higherUnitMissions = value;
         }
      }

      public  MixedAnyType NeighbourUnitsMissions
      {
         get
         {
            if (this.neighbourUnitsMissions == null)
                throw new XBException("field neighbourUnitsMissions not set");

            return this.neighbourUnitsMissions;
         }
         set
         {
            this.neighbourUnitsMissions = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation AirSituation
      {
         get
         {
            if (this.airSituation == null)
                throw new XBException("field airSituation not set");

            return this.airSituation;
         }
         set
         {
            this.airSituation = value;
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

               // ownForcesSituationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.ownForcesSituationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_ownForcesSituationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ownForcesSituationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.ownForcesSituationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.ownForcesSituationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ownForcesAssessment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.ownForcesAssessment = new  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_ownForcesAssessment();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.ownForcesAssessment.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // higherUnitMissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.higherUnitMissions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.higherUnitMissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // neighbourUnitsMissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.neighbourUnitsMissions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.neighbourUnitsMissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airSituation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.airSituation = new  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation_airSituation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.airSituation.decode(reader, xbContext, false, false);

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

         // ownForcesSituationSectionStatus
         if (_set_ownForcesSituationSectionStatus)  {
            encoder.encodeStartElement("ownForcesSituationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.ownForcesSituationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // ownForcesSituationGlobal
         if (this.ownForcesSituationGlobal != null)  {
            encoder.encodeStartElement("ownForcesSituationGlobal", "", "");
            this.ownForcesSituationGlobal.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // ownForcesAssessment
         if (this.ownForcesAssessment != null)  {
            encoder.encodeStartElement("ownForcesAssessment", "", "");
            this.ownForcesAssessment.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // higherUnitMissions
         if (this.higherUnitMissions != null)  {
            encoder.encodeStartElement("higherUnitMissions", "", "");
            this.higherUnitMissions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // neighbourUnitsMissions
         if (this.neighbourUnitsMissions != null)  {
            encoder.encodeStartElement("neighbourUnitsMissions", "", "");
            this.neighbourUnitsMissions.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // airSituation
         if (this.airSituation != null)  {
            encoder.encodeStartElement("airSituation", "", "");
            this.airSituation.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__1_situation_C_reinforcements : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation_C_reinforcements");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","reinforcementsSectionStatus"),
         new XBQualifiedName("","reinforcementsGlobal"),
         new XBQualifiedName("","reinforcement")
      };
      static NC1_OPORD_ELEM_2__1_situation_C_reinforcements() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int reinforcementsSectionStatus;
      protected bool _set_reinforcementsSectionStatus = false;
      protected  MixedAnyType reinforcementsGlobal;   //optional
      protected System.Collections.Generic.IList< ReinforcementType> reinforcement;
         

      //attribute methods

      //content methods

      public int ReinforcementsSectionStatus
      {
         get
         {
            if (!_set_reinforcementsSectionStatus)
                throw new XBException("field reinforcementsSectionStatus not set");

            return this.reinforcementsSectionStatus;
         }
         set
         {
            this.reinforcementsSectionStatus = value;
            _set_reinforcementsSectionStatus = true;
         }
      }

      public  MixedAnyType ReinforcementsGlobal
      {
         get
         {
            if (this.reinforcementsGlobal == null)
                throw new XBException("field reinforcementsGlobal not set");

            return this.reinforcementsGlobal;
         }
         set
         {
            this.reinforcementsGlobal = value;
         }
      }

      public System.Collections.Generic.IList< ReinforcementType> Reinforcement
      {
         get
         {
            if (this.reinforcement == null) {
               this.reinforcement = new List< ReinforcementType>();
            }
            return this.reinforcement;
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

               // reinforcementsSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.reinforcementsSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_reinforcementsSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reinforcementsGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.reinforcementsGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.reinforcementsGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reinforcement
               this.reinforcement = new List< ReinforcementType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   ReinforcementType _tmp_reinforcement;
                  _tmp_reinforcement = new  ReinforcementType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_reinforcement.decode(reader, xbContext, false, false);
                  this.reinforcement.Add(_tmp_reinforcement);

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

         // reinforcementsSectionStatus
         if (_set_reinforcementsSectionStatus)  {
            encoder.encodeStartElement("reinforcementsSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.reinforcementsSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // reinforcementsGlobal
         if (this.reinforcementsGlobal != null)  {
            encoder.encodeStartElement("reinforcementsGlobal", "", "");
            this.reinforcementsGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // reinforcement
         if ( this.reinforcement != null ){
            foreach ( ReinforcementType _tmp_reinforcement in this.reinforcement)
            {
               encoder.encodeStartElement("reinforcement", "", "");
               _tmp_reinforcement.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__1_situation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__1_situation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","situationSectionStatus"),
         new XBQualifiedName("","situationGlobal"),
         new XBQualifiedName("","A_enemySituation"),
         new XBQualifiedName("","B_ownForcesSituation"),
         new XBQualifiedName("","C_reinforcements"),
         new XBQualifiedName("","D_commanderAssessment"),
         new XBQualifiedName("","E_environment")
      };
      static NC1_OPORD_ELEM_2__1_situation() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int situationSectionStatus;
      protected bool _set_situationSectionStatus = false;
      protected  MixedAnyType situationGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__1_situation_A_enemySituation a_enemySituation;
            //optional
      protected  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation b_ownForcesSituation;
            //optional
      protected  NC1_OPORD_ELEM_2__1_situation_C_reinforcements c_reinforcements;
            //optional
      protected string d_commanderAssessment;
      protected bool _set_d_commanderAssessment = false;
      protected  MixedAnyType e_environment;   //optional

      //attribute methods

      //content methods

      public int SituationSectionStatus
      {
         get
         {
            if (!_set_situationSectionStatus)
                throw new XBException("field situationSectionStatus not set");

            return this.situationSectionStatus;
         }
         set
         {
            this.situationSectionStatus = value;
            _set_situationSectionStatus = true;
         }
      }

      public  MixedAnyType SituationGlobal
      {
         get
         {
            if (this.situationGlobal == null)
                throw new XBException("field situationGlobal not set");

            return this.situationGlobal;
         }
         set
         {
            this.situationGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_A_enemySituation A_enemySituation
      {
         get
         {
            if (this.a_enemySituation == null)
                throw new XBException("field a_enemySituation not set");

            return this.a_enemySituation;
         }
         set
         {
            this.a_enemySituation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation B_ownForcesSituation
      {
         get
         {
            if (this.b_ownForcesSituation == null)
                throw new XBException("field b_ownForcesSituation not set");

            return this.b_ownForcesSituation;
         }
         set
         {
            this.b_ownForcesSituation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation_C_reinforcements C_reinforcements
      {
         get
         {
            if (this.c_reinforcements == null)
                throw new XBException("field c_reinforcements not set");

            return this.c_reinforcements;
         }
         set
         {
            this.c_reinforcements = value;
         }
      }

      public string D_commanderAssessment
      {
         get
         {
            if (!_set_d_commanderAssessment)
                throw new XBException("field d_commanderAssessment not set");

            return this.d_commanderAssessment;
         }
         set
         {
            this.d_commanderAssessment = value;
            _set_d_commanderAssessment = true;
         }
      }

      public  MixedAnyType E_environment
      {
         get
         {
            if (this.e_environment == null)
                throw new XBException("field e_environment not set");

            return this.e_environment;
         }
         set
         {
            this.e_environment = value;
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

               // situationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.situationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_situationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // situationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.situationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.situationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_enemySituation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_enemySituation = new  NC1_OPORD_ELEM_2__1_situation_A_enemySituation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_enemySituation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_ownForcesSituation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_ownForcesSituation = new  NC1_OPORD_ELEM_2__1_situation_B_ownForcesSituation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_ownForcesSituation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_reinforcements
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c_reinforcements = new  NC1_OPORD_ELEM_2__1_situation_C_reinforcements();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_reinforcements.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_commanderAssessment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.d_commanderAssessment =  WideTextType.decode(text, xbContext);

                  _set_d_commanderAssessment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // e_environment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.e_environment = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.e_environment.decode(reader, xbContext, false, false);

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

         // situationSectionStatus
         if (_set_situationSectionStatus)  {
            encoder.encodeStartElement("situationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.situationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // situationGlobal
         if (this.situationGlobal != null)  {
            encoder.encodeStartElement("situationGlobal", "", "");
            this.situationGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a_enemySituation
         if (this.a_enemySituation != null)  {
            encoder.encodeStartElement("A_enemySituation", "", "");
            this.a_enemySituation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b_ownForcesSituation
         if (this.b_ownForcesSituation != null)  {
            encoder.encodeStartElement("B_ownForcesSituation", "", "");
            this.b_ownForcesSituation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c_reinforcements
         if (this.c_reinforcements != null)  {
            encoder.encodeStartElement("C_reinforcements", "", "");
            this.c_reinforcements.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d_commanderAssessment
         if (_set_d_commanderAssessment)  {
            encoder.encodeStartElement("D_commanderAssessment", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.d_commanderAssessment, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // e_environment
         if (this.e_environment != null)  {
            encoder.encodeStartElement("E_environment", "", "");
            this.e_environment.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__2_mission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__2_mission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","mission"),
         new XBQualifiedName("","sectionStatus")
      };
      static NC1_OPORD_ELEM_2__2_mission() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MixedAnyType mission;
      protected int sectionStatus;

      //attribute methods

      //content methods

      public  MixedAnyType Mission
      {
         get
         {
            if (this.mission == null)
                throw new XBException("field mission not set");

            return this.mission;
         }
         set
         {
            this.mission = value;
         }
      }

      public int SectionStatus
      {
         get { return this.sectionStatus; }
         set { this.sectionStatus = value; }
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

               // mission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.mission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.mission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "mission");

               // sectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sectionStatus =  SectionStatusCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sectionStatus");

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

         // mission
         if (this.mission == null)
             throw new XBException("field mission not set");

         encoder.encodeStartElement("mission", "", "");
         this.mission.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // sectionStatus
         encoder.encodeStartElement("sectionStatus", "", "");
         String text_3;
         text_3 =  SectionStatusCode.encode(this.sectionStatus, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
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

   public class NC1_OPORD_ELEM_2__3_execution_A_intention_description : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_A_intention_description");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","description"),
         new XBQualifiedName("","sectionStatus")
      };
      static NC1_OPORD_ELEM_2__3_execution_A_intention_description() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string description;
      protected bool _set_description = false;
      protected int sectionStatus;

      //attribute methods

      //content methods

      public string Description
      {
         get
         {
            if (!_set_description)
                throw new XBException("field description not set");

            return this.description;
         }
         set
         {
            this.description = value;
            _set_description = true;
         }
      }

      public int SectionStatus
      {
         get { return this.sectionStatus; }
         set { this.sectionStatus = value; }
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

               // description
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.description =  WideTextType.decode(text, xbContext);

                  _set_description = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // sectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sectionStatus =  SectionStatusCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sectionStatus");

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

         // description
         if (_set_description)  {
            encoder.encodeStartElement("description", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.description, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // sectionStatus
         encoder.encodeStartElement("sectionStatus", "", "");
         String text_3;
         text_3 =  SectionStatusCode.encode(this.sectionStatus, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
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

   public class NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","step"),
         new XBQualifiedName("","name"),
         new XBQualifiedName("","startDatetime"),
         new XBQualifiedName("","stopDatetime"),
         new XBQualifiedName("","stepDescription")
      };
      static NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int step;
      protected string name;
      protected bool _set_name = false;
      protected string startDatetime;
      protected string stopDatetime;
      protected  MixedAnyType stepDescription;   //optional

      //attribute methods

      //content methods

      public int Step
      {
         get { return this.step; }
         set { this.step = value; }
      }

      public string Name
      {
         get
         {
            if (!_set_name) throw new XBException("field name not set");

            return this.name;
         }
         set
         {
            this.name = value;
            _set_name = true;
         }
      }

      public string StartDatetime
      {
         get { return this.startDatetime; }
         set { this.startDatetime = value; }
      }

      public string StopDatetime
      {
         get { return this.stopDatetime; }
         set { this.stopDatetime = value; }
      }

      public  MixedAnyType StepDescription
      {
         get
         {
            if (this.stepDescription == null)
                throw new XBException("field stepDescription not set");

            return this.stepDescription;
         }
         set
         {
            this.stepDescription = value;
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

               // step
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.step =  L114_10Code.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "step");

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  MediumTextType.decode(text, xbContext);

                  _set_name = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // startDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.startDatetime = text;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "startDatetime");

               // stopDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.stopDatetime = text;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "stopDatetime");

               // stepDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.stepDescription = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.stepDescription.decode(reader, xbContext, false, false);

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

         // step
         encoder.encodeStartElement("step", "", "");
         String text_3;
         text_3 =  L114_10Code.encode(this.step, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // name
         if (_set_name)  {
            encoder.encodeStartElement("name", "", "");
            text_3 =  MediumTextType.encode(this.name, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // startDatetime
         encoder.encodeStartElement("startDatetime", "", "");
         text_3 = this.startDatetime;
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // stopDatetime
         encoder.encodeStartElement("stopDatetime", "", "");
         text_3 = this.stopDatetime;
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // stepDescription
         if (this.stepDescription != null)  {
            encoder.encodeStartElement("stepDescription", "", "");
            this.stepDescription.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_A_intention : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_A_intention");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","intentionSectionStatus"),
         new XBQualifiedName("","intentionGlobal"),
         new XBQualifiedName("","description"),
         new XBQualifiedName("","maneuverStep")
      };
      static NC1_OPORD_ELEM_2__3_execution_A_intention() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int intentionSectionStatus;
      protected bool _set_intentionSectionStatus = false;
      protected  MixedAnyType intentionGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__3_execution_A_intention_description description;
            //optional
      protected System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep> maneuverStep;
         

      //attribute methods

      //content methods

      public int IntentionSectionStatus
      {
         get
         {
            if (!_set_intentionSectionStatus)
                throw new XBException("field intentionSectionStatus not set");

            return this.intentionSectionStatus;
         }
         set
         {
            this.intentionSectionStatus = value;
            _set_intentionSectionStatus = true;
         }
      }

      public  MixedAnyType IntentionGlobal
      {
         get
         {
            if (this.intentionGlobal == null)
                throw new XBException("field intentionGlobal not set");

            return this.intentionGlobal;
         }
         set
         {
            this.intentionGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_A_intention_description Description
      {
         get
         {
            if (this.description == null)
                throw new XBException("field description not set");

            return this.description;
         }
         set
         {
            this.description = value;
         }
      }

      public System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep> ManeuverStep
      {
         get
         {
            if (this.maneuverStep == null) {
               this.maneuverStep = 
                  new List< NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep>()
                  ;
            }
            return this.maneuverStep;
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

               // intentionSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.intentionSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_intentionSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // intentionGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.intentionGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.intentionGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // description
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.description = new  NC1_OPORD_ELEM_2__3_execution_A_intention_description();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.description.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // maneuverStep
               this.maneuverStep = 
                  new List< NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep _tmp_maneuverStep;
                  _tmp_maneuverStep = new  NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_maneuverStep.decode(reader, xbContext, false, false);
                  this.maneuverStep.Add(_tmp_maneuverStep);

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

         // intentionSectionStatus
         if (_set_intentionSectionStatus)  {
            encoder.encodeStartElement("intentionSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.intentionSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // intentionGlobal
         if (this.intentionGlobal != null)  {
            encoder.encodeStartElement("intentionGlobal", "", "");
            this.intentionGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // description
         if (this.description != null)  {
            encoder.encodeStartElement("description", "", "");
            this.description.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // maneuverStep
         if ( this.maneuverStep != null ){
            foreach ( NC1_OPORD_ELEM_2__3_execution_A_intention_maneuverStep _tmp_maneuverStep in this.maneuverStep)
            {
               encoder.encodeStartElement("maneuverStep", "", "");
               _tmp_maneuverStep.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","step"),
         new XBQualifiedName("","stepDescription")
      };
      static NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int step;
      protected bool _set_step = false;
      protected  MixedAnyType stepDescription;   //optional

      //attribute methods

      //content methods

      public int Step
      {
         get
         {
            if (!_set_step) throw new XBException("field step not set");

            return this.step;
         }
         set
         {
            this.step = value;
            _set_step = true;
         }
      }

      public  MixedAnyType StepDescription
      {
         get
         {
            if (this.stepDescription == null)
                throw new XBException("field stepDescription not set");

            return this.stepDescription;
         }
         set
         {
            this.stepDescription = value;
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

               // step
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.step =  L114_10Code.decode(text, xbContext);

                  _set_step = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // stepDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.stepDescription = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.stepDescription.decode(reader, xbContext, false, false);

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

         // step
         if (_set_step)  {
            encoder.encodeStartElement("step", "", "");
            String text_4;
            text_4 =  L114_10Code.encode(this.step, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // stepDescription
         if (this.stepDescription != null)  {
            encoder.encodeStartElement("stepDescription", "", "");
            this.stepDescription.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","maneuverStep")
      };
      static NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;   //optional
      protected System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep> maneuverStep;
         

      //attribute methods

      //content methods

      public  Nc1ObjectRefType UnitId
      {
         get
         {
            if (this.unitId == null)
                throw new XBException("field unitId not set");

            return this.unitId;
         }
         set
         {
            this.unitId = value;
         }
      }

      public System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep> ManeuverStep
      {
         get
         {
            if (this.maneuverStep == null) {
               this.maneuverStep = 
                  new List< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep>()
                  ;
            }
            return this.maneuverStep;
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

               // unitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.unitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.unitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // maneuverStep
               this.maneuverStep = 
                  new List< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep _tmp_maneuverStep;
                  _tmp_maneuverStep = new  NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_maneuverStep.decode(reader, xbContext, false, false);
                  this.maneuverStep.Add(_tmp_maneuverStep);

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

         // unitId
         if (this.unitId != null)  {
            encoder.encodeStartElement("unitId", "", "");
            this.unitId.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // maneuverStep
         if ( this.maneuverStep != null ){
            foreach ( NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit_maneuverStep _tmp_maneuverStep in this.maneuverStep)
            {
               encoder.encodeStartElement("maneuverStep", "", "");
               _tmp_maneuverStep.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","nonSpecializedUnitsMissionsSectionStatus"),
         new XBQualifiedName("","nonSpecializedUnitsMissionsGlobal"),
         new XBQualifiedName("","unit")
      };
      static NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int nonSpecializedUnitsMissionsSectionStatus;
      protected bool _set_nonSpecializedUnitsMissionsSectionStatus = false;
      protected  MixedAnyType nonSpecializedUnitsMissionsGlobal;
            //optional
      protected System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit> unit;
         

      //attribute methods

      //content methods

      public int NonSpecializedUnitsMissionsSectionStatus
      {
         get
         {
            if (!_set_nonSpecializedUnitsMissionsSectionStatus)
                throw new XBException("field nonSpecializedUnitsMissionsSectionStatus not set");

            return this.nonSpecializedUnitsMissionsSectionStatus;
         }
         set
         {
            this.nonSpecializedUnitsMissionsSectionStatus = value;
            _set_nonSpecializedUnitsMissionsSectionStatus = true;
         }
      }

      public  MixedAnyType NonSpecializedUnitsMissionsGlobal
      {
         get
         {
            if (this.nonSpecializedUnitsMissionsGlobal == null)
                throw new XBException("field nonSpecializedUnitsMissionsGlobal not set");

            return this.nonSpecializedUnitsMissionsGlobal;
         }
         set
         {
            this.nonSpecializedUnitsMissionsGlobal = value;
         }
      }

      public System.Collections.Generic.IList< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit> Unit
      {
         get
         {
            if (this.unit == null) {
               this.unit = 
                  new List< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit>()
                  ;
            }
            return this.unit;
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

               // nonSpecializedUnitsMissionsSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.nonSpecializedUnitsMissionsSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_nonSpecializedUnitsMissionsSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nonSpecializedUnitsMissionsGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.nonSpecializedUnitsMissionsGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.nonSpecializedUnitsMissionsGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // unit
               this.unit = 
                  new List< NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit _tmp_unit;
                  _tmp_unit = new  NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_unit.decode(reader, xbContext, false, false);
                  this.unit.Add(_tmp_unit);

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

         // nonSpecializedUnitsMissionsSectionStatus
         if (_set_nonSpecializedUnitsMissionsSectionStatus)  {
            encoder.encodeStartElement("nonSpecializedUnitsMissionsSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.nonSpecializedUnitsMissionsSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // nonSpecializedUnitsMissionsGlobal
         if (this.nonSpecializedUnitsMissionsGlobal != null)  {
            encoder.encodeStartElement("nonSpecializedUnitsMissionsGlobal", "", "");
            this.nonSpecializedUnitsMissionsGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // unit
         if ( this.unit != null ){
            foreach ( NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions_unit _tmp_unit in this.unit)
            {
               encoder.encodeStartElement("unit", "", "");
               _tmp_unit.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","landFiresSectionStatus"),
         new XBQualifiedName("","landFiresGlobal"),
         new XBQualifiedName("","C11_generalMission"),
         new XBQualifiedName("","C12_command"),
         new XBQualifiedName("","C13_fireMissions"),
         new XBQualifiedName("","C14_ammunitions"),
         new XBQualifiedName("","C15_coordinationMeans"),
         new XBQualifiedName("","C16_fireReinforcements"),
         new XBQualifiedName("","C17_intelMission"),
         new XBQualifiedName("","C18_acqMission"),
         new XBQualifiedName("","C19_deployment")
      };
      static NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int landFiresSectionStatus;
      protected bool _set_landFiresSectionStatus = false;
      protected  MixedAnyType landFiresGlobal;   //optional
      protected  MixedAnyType c11_generalMission;   //optional
      protected  MixedAnyType c12_command;   //optional
      protected  MixedAnyType c13_fireMissions;   //optional
      protected  MixedAnyType c14_ammunitions;   //optional
      protected  MixedAnyType c15_coordinationMeans;   //optional
      protected  MixedAnyType c16_fireReinforcements;   //optional
      protected  MixedAnyType c17_intelMission;   //optional
      protected  MixedAnyType c18_acqMission;   //optional
      protected  MixedAnyType c19_deployment;   //optional

      //attribute methods

      //content methods

      public int LandFiresSectionStatus
      {
         get
         {
            if (!_set_landFiresSectionStatus)
                throw new XBException("field landFiresSectionStatus not set");

            return this.landFiresSectionStatus;
         }
         set
         {
            this.landFiresSectionStatus = value;
            _set_landFiresSectionStatus = true;
         }
      }

      public  MixedAnyType LandFiresGlobal
      {
         get
         {
            if (this.landFiresGlobal == null)
                throw new XBException("field landFiresGlobal not set");

            return this.landFiresGlobal;
         }
         set
         {
            this.landFiresGlobal = value;
         }
      }

      public  MixedAnyType C11_generalMission
      {
         get
         {
            if (this.c11_generalMission == null)
                throw new XBException("field c11_generalMission not set");

            return this.c11_generalMission;
         }
         set
         {
            this.c11_generalMission = value;
         }
      }

      public  MixedAnyType C12_command
      {
         get
         {
            if (this.c12_command == null)
                throw new XBException("field c12_command not set");

            return this.c12_command;
         }
         set
         {
            this.c12_command = value;
         }
      }

      public  MixedAnyType C13_fireMissions
      {
         get
         {
            if (this.c13_fireMissions == null)
                throw new XBException("field c13_fireMissions not set");

            return this.c13_fireMissions;
         }
         set
         {
            this.c13_fireMissions = value;
         }
      }

      public  MixedAnyType C14_ammunitions
      {
         get
         {
            if (this.c14_ammunitions == null)
                throw new XBException("field c14_ammunitions not set");

            return this.c14_ammunitions;
         }
         set
         {
            this.c14_ammunitions = value;
         }
      }

      public  MixedAnyType C15_coordinationMeans
      {
         get
         {
            if (this.c15_coordinationMeans == null)
                throw new XBException("field c15_coordinationMeans not set");

            return this.c15_coordinationMeans;
         }
         set
         {
            this.c15_coordinationMeans = value;
         }
      }

      public  MixedAnyType C16_fireReinforcements
      {
         get
         {
            if (this.c16_fireReinforcements == null)
                throw new XBException("field c16_fireReinforcements not set");

            return this.c16_fireReinforcements;
         }
         set
         {
            this.c16_fireReinforcements = value;
         }
      }

      public  MixedAnyType C17_intelMission
      {
         get
         {
            if (this.c17_intelMission == null)
                throw new XBException("field c17_intelMission not set");

            return this.c17_intelMission;
         }
         set
         {
            this.c17_intelMission = value;
         }
      }

      public  MixedAnyType C18_acqMission
      {
         get
         {
            if (this.c18_acqMission == null)
                throw new XBException("field c18_acqMission not set");

            return this.c18_acqMission;
         }
         set
         {
            this.c18_acqMission = value;
         }
      }

      public  MixedAnyType C19_deployment
      {
         get
         {
            if (this.c19_deployment == null)
                throw new XBException("field c19_deployment not set");

            return this.c19_deployment;
         }
         set
         {
            this.c19_deployment = value;
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

               // landFiresSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.landFiresSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_landFiresSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // landFiresGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.landFiresGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.landFiresGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c11_generalMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.c11_generalMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c11_generalMission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c12_command
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.c12_command = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c12_command.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c13_fireMissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c13_fireMissions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c13_fireMissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c14_ammunitions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.c14_ammunitions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c14_ammunitions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c15_coordinationMeans
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.c15_coordinationMeans = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c15_coordinationMeans.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c16_fireReinforcements
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.c16_fireReinforcements = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c16_fireReinforcements.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c17_intelMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.c17_intelMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c17_intelMission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c18_acqMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  this.c18_acqMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c18_acqMission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c19_deployment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  this.c19_deployment = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c19_deployment.decode(reader, xbContext, false, false);

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

         // landFiresSectionStatus
         if (_set_landFiresSectionStatus)  {
            encoder.encodeStartElement("landFiresSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.landFiresSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // landFiresGlobal
         if (this.landFiresGlobal != null)  {
            encoder.encodeStartElement("landFiresGlobal", "", "");
            this.landFiresGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c11_generalMission
         if (this.c11_generalMission != null)  {
            encoder.encodeStartElement("C11_generalMission", "", "");
            this.c11_generalMission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c12_command
         if (this.c12_command != null)  {
            encoder.encodeStartElement("C12_command", "", "");
            this.c12_command.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c13_fireMissions
         if (this.c13_fireMissions != null)  {
            encoder.encodeStartElement("C13_fireMissions", "", "");
            this.c13_fireMissions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c14_ammunitions
         if (this.c14_ammunitions != null)  {
            encoder.encodeStartElement("C14_ammunitions", "", "");
            this.c14_ammunitions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c15_coordinationMeans
         if (this.c15_coordinationMeans != null)  {
            encoder.encodeStartElement("C15_coordinationMeans", "", "");
            this.c15_coordinationMeans.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // c16_fireReinforcements
         if (this.c16_fireReinforcements != null)  {
            encoder.encodeStartElement("C16_fireReinforcements", "", "");
            this.c16_fireReinforcements.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // c17_intelMission
         if (this.c17_intelMission != null)  {
            encoder.encodeStartElement("C17_intelMission", "", "");
            this.c17_intelMission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c18_acqMission
         if (this.c18_acqMission != null)  {
            encoder.encodeStartElement("C18_acqMission", "", "");
            this.c18_acqMission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c19_deployment
         if (this.c19_deployment != null)  {
            encoder.encodeStartElement("C19_deployment", "", "");
            this.c19_deployment.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","member")
      };
      static NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< TaskOrganisationMemberSimplifiedType> member;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< TaskOrganisationMemberSimplifiedType> Member
      {
         get
         {
            if (this.member == null) {
               this.member = 
                  new List< TaskOrganisationMemberSimplifiedType>();
            }
            return this.member;
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

               // member
               this.member = 
                  new List< TaskOrganisationMemberSimplifiedType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   TaskOrganisationMemberSimplifiedType _tmp_member;
                  _tmp_member = new  TaskOrganisationMemberSimplifiedType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_member.decode(reader, xbContext, false, false);
                  this.member.Add(_tmp_member);

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

         // member
         if ( this.member != null ){
            foreach ( TaskOrganisationMemberSimplifiedType _tmp_member in this.member)
            {
               encoder.encodeStartElement("member", "", "");
               _tmp_member.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","airDefenceSectionStatus"),
         new XBQualifiedName("","airDefenceGlobal"),
         new XBQualifiedName("","C21_generalMission"),
         new XBQualifiedName("","C22_taskOrganisation"),
         new XBQualifiedName("","C23_ownUnitsMission")
      };
      static NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int airDefenceSectionStatus;
      protected bool _set_airDefenceSectionStatus = false;
      protected  MixedAnyType airDefenceGlobal;   //optional
      protected string c21_generalMission;
      protected bool _set_c21_generalMission = false;
      protected  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation c22_taskOrganisation;
            //optional
      protected  MixedAnyType c23_ownUnitsMission;   //optional

      //attribute methods

      //content methods

      public int AirDefenceSectionStatus
      {
         get
         {
            if (!_set_airDefenceSectionStatus)
                throw new XBException("field airDefenceSectionStatus not set");

            return this.airDefenceSectionStatus;
         }
         set
         {
            this.airDefenceSectionStatus = value;
            _set_airDefenceSectionStatus = true;
         }
      }

      public  MixedAnyType AirDefenceGlobal
      {
         get
         {
            if (this.airDefenceGlobal == null)
                throw new XBException("field airDefenceGlobal not set");

            return this.airDefenceGlobal;
         }
         set
         {
            this.airDefenceGlobal = value;
         }
      }

      public string C21_generalMission
      {
         get
         {
            if (!_set_c21_generalMission)
                throw new XBException("field c21_generalMission not set");

            return this.c21_generalMission;
         }
         set
         {
            this.c21_generalMission = value;
            _set_c21_generalMission = true;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation C22_taskOrganisation
      {
         get
         {
            if (this.c22_taskOrganisation == null)
                throw new XBException("field c22_taskOrganisation not set");

            return this.c22_taskOrganisation;
         }
         set
         {
            this.c22_taskOrganisation = value;
         }
      }

      public  MixedAnyType C23_ownUnitsMission
      {
         get
         {
            if (this.c23_ownUnitsMission == null)
                throw new XBException("field c23_ownUnitsMission not set");

            return this.c23_ownUnitsMission;
         }
         set
         {
            this.c23_ownUnitsMission = value;
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

               // airDefenceSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airDefenceSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_airDefenceSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airDefenceGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.airDefenceGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.airDefenceGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c21_generalMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.c21_generalMission =  WideTextType.decode(text, xbContext);

                  _set_c21_generalMission = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c22_taskOrganisation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.c22_taskOrganisation = new  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence_C22_taskOrganisation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c22_taskOrganisation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c23_ownUnitsMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c23_ownUnitsMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c23_ownUnitsMission.decode(reader, xbContext, false, false);

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

         // airDefenceSectionStatus
         if (_set_airDefenceSectionStatus)  {
            encoder.encodeStartElement("airDefenceSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.airDefenceSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // airDefenceGlobal
         if (this.airDefenceGlobal != null)  {
            encoder.encodeStartElement("airDefenceGlobal", "", "");
            this.airDefenceGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c21_generalMission
         if (_set_c21_generalMission)  {
            encoder.encodeStartElement("C21_generalMission", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.c21_generalMission, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // c22_taskOrganisation
         if (this.c22_taskOrganisation != null)  {
            encoder.encodeStartElement("C22_taskOrganisation", "", "");
            this.c22_taskOrganisation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c23_ownUnitsMission
         if (this.c23_ownUnitsMission != null)  {
            encoder.encodeStartElement("C23_ownUnitsMission", "", "");
            this.c23_ownUnitsMission.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_C_fires : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_C_fires");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","firesSectionStatus"),
         new XBQualifiedName("","firesGlobal"),
         new XBQualifiedName("","C1_landFires"),
         new XBQualifiedName("","C2_airDefence")
      };
      static NC1_OPORD_ELEM_2__3_execution_C_fires() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int firesSectionStatus;
      protected bool _set_firesSectionStatus = false;
      protected  MixedAnyType firesGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires c1_landFires;
            //optional
      protected  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence c2_airDefence;
            //optional

      //attribute methods

      //content methods

      public int FiresSectionStatus
      {
         get
         {
            if (!_set_firesSectionStatus)
                throw new XBException("field firesSectionStatus not set");

            return this.firesSectionStatus;
         }
         set
         {
            this.firesSectionStatus = value;
            _set_firesSectionStatus = true;
         }
      }

      public  MixedAnyType FiresGlobal
      {
         get
         {
            if (this.firesGlobal == null)
                throw new XBException("field firesGlobal not set");

            return this.firesGlobal;
         }
         set
         {
            this.firesGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires C1_landFires
      {
         get
         {
            if (this.c1_landFires == null)
                throw new XBException("field c1_landFires not set");

            return this.c1_landFires;
         }
         set
         {
            this.c1_landFires = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence C2_airDefence
      {
         get
         {
            if (this.c2_airDefence == null)
                throw new XBException("field c2_airDefence not set");

            return this.c2_airDefence;
         }
         set
         {
            this.c2_airDefence = value;
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

               // firesSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.firesSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_firesSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // firesGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.firesGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.firesGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c1_landFires
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.c1_landFires = new  NC1_OPORD_ELEM_2__3_execution_C_fires_C1_landFires();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c1_landFires.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c2_airDefence
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.c2_airDefence = new  NC1_OPORD_ELEM_2__3_execution_C_fires_C2_airDefence();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c2_airDefence.decode(reader, xbContext, false, false);

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

         // firesSectionStatus
         if (_set_firesSectionStatus)  {
            encoder.encodeStartElement("firesSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.firesSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // firesGlobal
         if (this.firesGlobal != null)  {
            encoder.encodeStartElement("firesGlobal", "", "");
            this.firesGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c1_landFires
         if (this.c1_landFires != null)  {
            encoder.encodeStartElement("C1_landFires", "", "");
            this.c1_landFires.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c2_airDefence
         if (this.c2_airDefence != null)  {
            encoder.encodeStartElement("C2_airDefence", "", "");
            this.c2_airDefence.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","reinforcement")
      };
      static NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< ReinforcementType> reinforcement;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< ReinforcementType> Reinforcement
      {
         get
         {
            if (this.reinforcement == null) {
               this.reinforcement = new List< ReinforcementType>();
            }
            return this.reinforcement;
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

               // reinforcement
               this.reinforcement = new List< ReinforcementType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   ReinforcementType _tmp_reinforcement;
                  _tmp_reinforcement = new  ReinforcementType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_reinforcement.decode(reader, xbContext, false, false);
                  this.reinforcement.Add(_tmp_reinforcement);

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

         // reinforcement
         if ( this.reinforcement != null ){
            foreach ( ReinforcementType _tmp_reinforcement in this.reinforcement)
            {
               encoder.encodeStartElement("reinforcement", "", "");
               _tmp_reinforcement.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_D_engineer : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_D_engineer");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","engineerSectionStatus"),
         new XBQualifiedName("","engineerGlobal"),
         new XBQualifiedName("","D1_generalMission"),
         new XBQualifiedName("","D2_specificMissions"),
         new XBQualifiedName("","D3_reinforcements"),
         new XBQualifiedName("","D4_ownUnitsMission"),
         new XBQualifiedName("","D5_coordination")
      };
      static NC1_OPORD_ELEM_2__3_execution_D_engineer() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int engineerSectionStatus;
      protected bool _set_engineerSectionStatus = false;
      protected  MixedAnyType engineerGlobal;   //optional
      protected string d1_generalMission;
      protected bool _set_d1_generalMission = false;
      protected  MixedAnyType d2_specificMissions;   //optional
      protected  NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements d3_reinforcements;
            //optional
      protected  MixedAnyType d4_ownUnitsMission;   //optional
      protected  MixedAnyType d5_coordination;   //optional

      //attribute methods

      //content methods

      public int EngineerSectionStatus
      {
         get
         {
            if (!_set_engineerSectionStatus)
                throw new XBException("field engineerSectionStatus not set");

            return this.engineerSectionStatus;
         }
         set
         {
            this.engineerSectionStatus = value;
            _set_engineerSectionStatus = true;
         }
      }

      public  MixedAnyType EngineerGlobal
      {
         get
         {
            if (this.engineerGlobal == null)
                throw new XBException("field engineerGlobal not set");

            return this.engineerGlobal;
         }
         set
         {
            this.engineerGlobal = value;
         }
      }

      public string D1_generalMission
      {
         get
         {
            if (!_set_d1_generalMission)
                throw new XBException("field d1_generalMission not set");

            return this.d1_generalMission;
         }
         set
         {
            this.d1_generalMission = value;
            _set_d1_generalMission = true;
         }
      }

      public  MixedAnyType D2_specificMissions
      {
         get
         {
            if (this.d2_specificMissions == null)
                throw new XBException("field d2_specificMissions not set");

            return this.d2_specificMissions;
         }
         set
         {
            this.d2_specificMissions = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements D3_reinforcements
      {
         get
         {
            if (this.d3_reinforcements == null)
                throw new XBException("field d3_reinforcements not set");

            return this.d3_reinforcements;
         }
         set
         {
            this.d3_reinforcements = value;
         }
      }

      public  MixedAnyType D4_ownUnitsMission
      {
         get
         {
            if (this.d4_ownUnitsMission == null)
                throw new XBException("field d4_ownUnitsMission not set");

            return this.d4_ownUnitsMission;
         }
         set
         {
            this.d4_ownUnitsMission = value;
         }
      }

      public  MixedAnyType D5_coordination
      {
         get
         {
            if (this.d5_coordination == null)
                throw new XBException("field d5_coordination not set");

            return this.d5_coordination;
         }
         set
         {
            this.d5_coordination = value;
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

               // engineerSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.engineerSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_engineerSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // engineerGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.engineerGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.engineerGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d1_generalMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.d1_generalMission =  WideTextType.decode(text, xbContext);

                  _set_d1_generalMission = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d2_specificMissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.d2_specificMissions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d2_specificMissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d3_reinforcements
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.d3_reinforcements = new  NC1_OPORD_ELEM_2__3_execution_D_engineer_D3_reinforcements();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d3_reinforcements.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d4_ownUnitsMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.d4_ownUnitsMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d4_ownUnitsMission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d5_coordination
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.d5_coordination = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d5_coordination.decode(reader, xbContext, false, false);

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

         // engineerSectionStatus
         if (_set_engineerSectionStatus)  {
            encoder.encodeStartElement("engineerSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.engineerSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // engineerGlobal
         if (this.engineerGlobal != null)  {
            encoder.encodeStartElement("engineerGlobal", "", "");
            this.engineerGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d1_generalMission
         if (_set_d1_generalMission)  {
            encoder.encodeStartElement("D1_generalMission", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.d1_generalMission, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // d2_specificMissions
         if (this.d2_specificMissions != null)  {
            encoder.encodeStartElement("D2_specificMissions", "", "");
            this.d2_specificMissions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d3_reinforcements
         if (this.d3_reinforcements != null)  {
            encoder.encodeStartElement("D3_reinforcements", "", "");
            this.d3_reinforcements.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d4_ownUnitsMission
         if (this.d4_ownUnitsMission != null)  {
            encoder.encodeStartElement("D4_ownUnitsMission", "", "");
            this.d4_ownUnitsMission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d5_coordination
         if (this.d5_coordination != null)  {
            encoder.encodeStartElement("D5_coordination", "", "");
            this.d5_coordination.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_G_roadTraffic : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_G_roadTraffic");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","roadTrafficSectionStatus"),
         new XBQualifiedName("","roadTrafficGlobal"),
         new XBQualifiedName("","G1_reinforcements"),
         new XBQualifiedName("","G2_subordinatesMeans"),
         new XBQualifiedName("","G3_ownUnitsMission"),
         new XBQualifiedName("","G4_coordination")
      };
      static NC1_OPORD_ELEM_2__3_execution_G_roadTraffic() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int roadTrafficSectionStatus;
      protected bool _set_roadTrafficSectionStatus = false;
      protected  MixedAnyType roadTrafficGlobal;   //optional
      protected  MixedAnyType g1_reinforcements;   //optional
      protected  MixedAnyType g2_subordinatesMeans;   //optional
      protected  MixedAnyType g3_ownUnitsMission;   //optional
      protected  MixedAnyType g4_coordination;   //optional

      //attribute methods

      //content methods

      public int RoadTrafficSectionStatus
      {
         get
         {
            if (!_set_roadTrafficSectionStatus)
                throw new XBException("field roadTrafficSectionStatus not set");

            return this.roadTrafficSectionStatus;
         }
         set
         {
            this.roadTrafficSectionStatus = value;
            _set_roadTrafficSectionStatus = true;
         }
      }

      public  MixedAnyType RoadTrafficGlobal
      {
         get
         {
            if (this.roadTrafficGlobal == null)
                throw new XBException("field roadTrafficGlobal not set");

            return this.roadTrafficGlobal;
         }
         set
         {
            this.roadTrafficGlobal = value;
         }
      }

      public  MixedAnyType G1_reinforcements
      {
         get
         {
            if (this.g1_reinforcements == null)
                throw new XBException("field g1_reinforcements not set");

            return this.g1_reinforcements;
         }
         set
         {
            this.g1_reinforcements = value;
         }
      }

      public  MixedAnyType G2_subordinatesMeans
      {
         get
         {
            if (this.g2_subordinatesMeans == null)
                throw new XBException("field g2_subordinatesMeans not set");

            return this.g2_subordinatesMeans;
         }
         set
         {
            this.g2_subordinatesMeans = value;
         }
      }

      public  MixedAnyType G3_ownUnitsMission
      {
         get
         {
            if (this.g3_ownUnitsMission == null)
                throw new XBException("field g3_ownUnitsMission not set");

            return this.g3_ownUnitsMission;
         }
         set
         {
            this.g3_ownUnitsMission = value;
         }
      }

      public  MixedAnyType G4_coordination
      {
         get
         {
            if (this.g4_coordination == null)
                throw new XBException("field g4_coordination not set");

            return this.g4_coordination;
         }
         set
         {
            this.g4_coordination = value;
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

               // roadTrafficSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.roadTrafficSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_roadTrafficSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // roadTrafficGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.roadTrafficGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.roadTrafficGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // g1_reinforcements
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.g1_reinforcements = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.g1_reinforcements.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // g2_subordinatesMeans
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.g2_subordinatesMeans = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.g2_subordinatesMeans.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // g3_ownUnitsMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.g3_ownUnitsMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.g3_ownUnitsMission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // g4_coordination
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.g4_coordination = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.g4_coordination.decode(reader, xbContext, false, false);

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

         // roadTrafficSectionStatus
         if (_set_roadTrafficSectionStatus)  {
            encoder.encodeStartElement("roadTrafficSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.roadTrafficSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // roadTrafficGlobal
         if (this.roadTrafficGlobal != null)  {
            encoder.encodeStartElement("roadTrafficGlobal", "", "");
            this.roadTrafficGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // g1_reinforcements
         if (this.g1_reinforcements != null)  {
            encoder.encodeStartElement("G1_reinforcements", "", "");
            this.g1_reinforcements.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // g2_subordinatesMeans
         if (this.g2_subordinatesMeans != null)  {
            encoder.encodeStartElement("G2_subordinatesMeans", "", "");
            this.g2_subordinatesMeans.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // g3_ownUnitsMission
         if (this.g3_ownUnitsMission != null)  {
            encoder.encodeStartElement("G3_ownUnitsMission", "", "");
            this.g3_ownUnitsMission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // g4_coordination
         if (this.g4_coordination != null)  {
            encoder.encodeStartElement("G4_coordination", "", "");
            this.g4_coordination.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","coordinationMeansSectionStatus"),
         new XBQualifiedName("","coordinationMeansGlobal"),
         new XBQualifiedName("","H1_limits"),
         new XBQualifiedName("","H2_coordinationLines"),
         new XBQualifiedName("","H3_links"),
         new XBQualifiedName("","H4_coordinationAreas"),
         new XBQualifiedName("","H5_nbc"),
         new XBQualifiedName("","H6_antiAirDefence"),
         new XBQualifiedName("","H7_datetimes"),
         new XBQualifiedName("","H8_acmAndExternRelations"),
         new XBQualifiedName("","H9_identification")
      };
      static NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int coordinationMeansSectionStatus;
      protected bool _set_coordinationMeansSectionStatus = false;
      protected  MixedAnyType coordinationMeansGlobal;   //optional
      protected  MixedAnyType h1_limits;   //optional
      protected  MixedAnyType h2_coordinationLines;   //optional
      protected  MixedAnyType h3_links;   //optional
      protected  MixedAnyType h4_coordinationAreas;   //optional
      protected  MixedAnyType h5_nbc;   //optional
      protected  MixedAnyType h6_antiAirDefence;   //optional
      protected  MixedAnyType h7_datetimes;   //optional
      protected  MixedAnyType h8_acmAndExternRelations;   //optional
      protected  MixedAnyType h9_identification;   //optional

      //attribute methods

      //content methods

      public int CoordinationMeansSectionStatus
      {
         get
         {
            if (!_set_coordinationMeansSectionStatus)
                throw new XBException("field coordinationMeansSectionStatus not set");

            return this.coordinationMeansSectionStatus;
         }
         set
         {
            this.coordinationMeansSectionStatus = value;
            _set_coordinationMeansSectionStatus = true;
         }
      }

      public  MixedAnyType CoordinationMeansGlobal
      {
         get
         {
            if (this.coordinationMeansGlobal == null)
                throw new XBException("field coordinationMeansGlobal not set");

            return this.coordinationMeansGlobal;
         }
         set
         {
            this.coordinationMeansGlobal = value;
         }
      }

      public  MixedAnyType H1_limits
      {
         get
         {
            if (this.h1_limits == null)
                throw new XBException("field h1_limits not set");

            return this.h1_limits;
         }
         set
         {
            this.h1_limits = value;
         }
      }

      public  MixedAnyType H2_coordinationLines
      {
         get
         {
            if (this.h2_coordinationLines == null)
                throw new XBException("field h2_coordinationLines not set");

            return this.h2_coordinationLines;
         }
         set
         {
            this.h2_coordinationLines = value;
         }
      }

      public  MixedAnyType H3_links
      {
         get
         {
            if (this.h3_links == null)
                throw new XBException("field h3_links not set");

            return this.h3_links;
         }
         set
         {
            this.h3_links = value;
         }
      }

      public  MixedAnyType H4_coordinationAreas
      {
         get
         {
            if (this.h4_coordinationAreas == null)
                throw new XBException("field h4_coordinationAreas not set");

            return this.h4_coordinationAreas;
         }
         set
         {
            this.h4_coordinationAreas = value;
         }
      }

      public  MixedAnyType H5_nbc
      {
         get
         {
            if (this.h5_nbc == null)
                throw new XBException("field h5_nbc not set");

            return this.h5_nbc;
         }
         set
         {
            this.h5_nbc = value;
         }
      }

      public  MixedAnyType H6_antiAirDefence
      {
         get
         {
            if (this.h6_antiAirDefence == null)
                throw new XBException("field h6_antiAirDefence not set");

            return this.h6_antiAirDefence;
         }
         set
         {
            this.h6_antiAirDefence = value;
         }
      }

      public  MixedAnyType H7_datetimes
      {
         get
         {
            if (this.h7_datetimes == null)
                throw new XBException("field h7_datetimes not set");

            return this.h7_datetimes;
         }
         set
         {
            this.h7_datetimes = value;
         }
      }

      public  MixedAnyType H8_acmAndExternRelations
      {
         get
         {
            if (this.h8_acmAndExternRelations == null)
                throw new XBException("field h8_acmAndExternRelations not set");

            return this.h8_acmAndExternRelations;
         }
         set
         {
            this.h8_acmAndExternRelations = value;
         }
      }

      public  MixedAnyType H9_identification
      {
         get
         {
            if (this.h9_identification == null)
                throw new XBException("field h9_identification not set");

            return this.h9_identification;
         }
         set
         {
            this.h9_identification = value;
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

               // coordinationMeansSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.coordinationMeansSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_coordinationMeansSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // coordinationMeansGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.coordinationMeansGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.coordinationMeansGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h1_limits
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.h1_limits = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h1_limits.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h2_coordinationLines
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.h2_coordinationLines = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h2_coordinationLines.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h3_links
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.h3_links = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h3_links.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h4_coordinationAreas
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.h4_coordinationAreas = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h4_coordinationAreas.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h5_nbc
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.h5_nbc = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h5_nbc.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h6_antiAirDefence
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.h6_antiAirDefence = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h6_antiAirDefence.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h7_datetimes
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.h7_datetimes = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h7_datetimes.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h8_acmAndExternRelations
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  this.h8_acmAndExternRelations = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h8_acmAndExternRelations.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h9_identification
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  this.h9_identification = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h9_identification.decode(reader, xbContext, false, false);

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

         // coordinationMeansSectionStatus
         if (_set_coordinationMeansSectionStatus)  {
            encoder.encodeStartElement("coordinationMeansSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.coordinationMeansSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // coordinationMeansGlobal
         if (this.coordinationMeansGlobal != null)  {
            encoder.encodeStartElement("coordinationMeansGlobal", "", "");
            this.coordinationMeansGlobal.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // h1_limits
         if (this.h1_limits != null)  {
            encoder.encodeStartElement("H1_limits", "", "");
            this.h1_limits.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h2_coordinationLines
         if (this.h2_coordinationLines != null)  {
            encoder.encodeStartElement("H2_coordinationLines", "", "");
            this.h2_coordinationLines.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h3_links
         if (this.h3_links != null)  {
            encoder.encodeStartElement("H3_links", "", "");
            this.h3_links.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h4_coordinationAreas
         if (this.h4_coordinationAreas != null)  {
            encoder.encodeStartElement("H4_coordinationAreas", "", "");
            this.h4_coordinationAreas.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h5_nbc
         if (this.h5_nbc != null)  {
            encoder.encodeStartElement("H5_nbc", "", "");
            this.h5_nbc.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h6_antiAirDefence
         if (this.h6_antiAirDefence != null)  {
            encoder.encodeStartElement("H6_antiAirDefence", "", "");
            this.h6_antiAirDefence.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h7_datetimes
         if (this.h7_datetimes != null)  {
            encoder.encodeStartElement("H7_datetimes", "", "");
            this.h7_datetimes.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h8_acmAndExternRelations
         if (this.h8_acmAndExternRelations != null)  {
            encoder.encodeStartElement("H8_acmAndExternRelations", "", "");
            this.h8_acmAndExternRelations.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // h9_identification
         if (this.h9_identification != null)  {
            encoder.encodeStartElement("H9_identification", "", "");
            this.h9_identification.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__3_execution : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__3_execution");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","executionSectionStatus"),
         new XBQualifiedName("","executionGlobal"),
         new XBQualifiedName("","A_intention"),
         new XBQualifiedName("","B_nonSpecializedUnitsMissions"),
         new XBQualifiedName("","C_fires"),
         new XBQualifiedName("","D_engineer"),
         new XBQualifiedName("","E_armyAviation"),
         new XBQualifiedName("","F_ew"),
         new XBQualifiedName("","G_roadTraffic"),
         new XBQualifiedName("","H_coordinationMeans")
      };
      static NC1_OPORD_ELEM_2__3_execution() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int executionSectionStatus;
      protected bool _set_executionSectionStatus = false;
      protected  MixedAnyType executionGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__3_execution_A_intention a_intention;
            //optional
      protected  NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions b_nonSpecializedUnitsMissions;
            //optional
      protected  NC1_OPORD_ELEM_2__3_execution_C_fires c_fires;
            //optional
      protected  NC1_OPORD_ELEM_2__3_execution_D_engineer d_engineer;
            //optional
      protected string e_armyAviation;
      protected bool _set_e_armyAviation = false;
      protected  MixedAnyType f_ew;   //optional
      protected  NC1_OPORD_ELEM_2__3_execution_G_roadTraffic g_roadTraffic;
            //optional
      protected  NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans h_coordinationMeans;
            //optional

      //attribute methods

      //content methods

      public int ExecutionSectionStatus
      {
         get
         {
            if (!_set_executionSectionStatus)
                throw new XBException("field executionSectionStatus not set");

            return this.executionSectionStatus;
         }
         set
         {
            this.executionSectionStatus = value;
            _set_executionSectionStatus = true;
         }
      }

      public  MixedAnyType ExecutionGlobal
      {
         get
         {
            if (this.executionGlobal == null)
                throw new XBException("field executionGlobal not set");

            return this.executionGlobal;
         }
         set
         {
            this.executionGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_A_intention A_intention
      {
         get
         {
            if (this.a_intention == null)
                throw new XBException("field a_intention not set");

            return this.a_intention;
         }
         set
         {
            this.a_intention = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions B_nonSpecializedUnitsMissions
      {
         get
         {
            if (this.b_nonSpecializedUnitsMissions == null)
                throw new XBException("field b_nonSpecializedUnitsMissions not set");

            return this.b_nonSpecializedUnitsMissions;
         }
         set
         {
            this.b_nonSpecializedUnitsMissions = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_C_fires C_fires
      {
         get
         {
            if (this.c_fires == null)
                throw new XBException("field c_fires not set");

            return this.c_fires;
         }
         set
         {
            this.c_fires = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_D_engineer D_engineer
      {
         get
         {
            if (this.d_engineer == null)
                throw new XBException("field d_engineer not set");

            return this.d_engineer;
         }
         set
         {
            this.d_engineer = value;
         }
      }

      public string E_armyAviation
      {
         get
         {
            if (!_set_e_armyAviation)
                throw new XBException("field e_armyAviation not set");

            return this.e_armyAviation;
         }
         set
         {
            this.e_armyAviation = value;
            _set_e_armyAviation = true;
         }
      }

      public  MixedAnyType F_ew
      {
         get
         {
            if (this.f_ew == null)
                throw new XBException("field f_ew not set");

            return this.f_ew;
         }
         set
         {
            this.f_ew = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_G_roadTraffic G_roadTraffic
      {
         get
         {
            if (this.g_roadTraffic == null)
                throw new XBException("field g_roadTraffic not set");

            return this.g_roadTraffic;
         }
         set
         {
            this.g_roadTraffic = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans H_coordinationMeans
      {
         get
         {
            if (this.h_coordinationMeans == null)
                throw new XBException("field h_coordinationMeans not set");

            return this.h_coordinationMeans;
         }
         set
         {
            this.h_coordinationMeans = value;
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

               // executionSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.executionSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_executionSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // executionGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.executionGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.executionGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_intention
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_intention = new  NC1_OPORD_ELEM_2__3_execution_A_intention();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_intention.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_nonSpecializedUnitsMissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_nonSpecializedUnitsMissions = new  NC1_OPORD_ELEM_2__3_execution_B_nonSpecializedUnitsMissions();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_nonSpecializedUnitsMissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_fires
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c_fires = new  NC1_OPORD_ELEM_2__3_execution_C_fires();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_fires.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_engineer
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.d_engineer = new  NC1_OPORD_ELEM_2__3_execution_D_engineer();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d_engineer.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // e_armyAviation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.e_armyAviation =  WideTextType.decode(text, xbContext);

                  _set_e_armyAviation = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // f_ew
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.f_ew = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.f_ew.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // g_roadTraffic
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.g_roadTraffic = new  NC1_OPORD_ELEM_2__3_execution_G_roadTraffic();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.g_roadTraffic.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // h_coordinationMeans
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  this.h_coordinationMeans = new  NC1_OPORD_ELEM_2__3_execution_H_coordinationMeans();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.h_coordinationMeans.decode(reader, xbContext, false, false);

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

         // executionSectionStatus
         if (_set_executionSectionStatus)  {
            encoder.encodeStartElement("executionSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.executionSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // executionGlobal
         if (this.executionGlobal != null)  {
            encoder.encodeStartElement("executionGlobal", "", "");
            this.executionGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a_intention
         if (this.a_intention != null)  {
            encoder.encodeStartElement("A_intention", "", "");
            this.a_intention.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b_nonSpecializedUnitsMissions
         if (this.b_nonSpecializedUnitsMissions != null)  {
            encoder.encodeStartElement("B_nonSpecializedUnitsMissions", "", "");
            this.b_nonSpecializedUnitsMissions.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // c_fires
         if (this.c_fires != null)  {
            encoder.encodeStartElement("C_fires", "", "");
            this.c_fires.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d_engineer
         if (this.d_engineer != null)  {
            encoder.encodeStartElement("D_engineer", "", "");
            this.d_engineer.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // e_armyAviation
         if (_set_e_armyAviation)  {
            encoder.encodeStartElement("E_armyAviation", "", "");
            String text_4;
            text_4 =  WideTextType.encode(this.e_armyAviation, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // f_ew
         if (this.f_ew != null)  {
            encoder.encodeStartElement("F_ew", "", "");
            this.f_ew.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // g_roadTraffic
         if (this.g_roadTraffic != null)  {
            encoder.encodeStartElement("G_roadTraffic", "", "");
            this.g_roadTraffic.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // h_coordinationMeans
         if (this.h_coordinationMeans != null)  {
            encoder.encodeStartElement("H_coordinationMeans", "", "");
            this.h_coordinationMeans.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","situationStatusCode"),
         new XBQualifiedName("","situationGlobal"),
         new XBQualifiedName("","forcesToSupport"),
         new XBQualifiedName("","technicalGeneral")
      };
      static NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int situationStatusCode;
      protected bool _set_situationStatusCode = false;
      protected  MixedAnyType situationGlobal;   //optional
      protected  MixedAnyType forcesToSupport;   //optional
      protected  MixedAnyType technicalGeneral;   //optional

      //attribute methods

      //content methods

      public int SituationStatusCode
      {
         get
         {
            if (!_set_situationStatusCode)
                throw new XBException("field situationStatusCode not set");

            return this.situationStatusCode;
         }
         set
         {
            this.situationStatusCode = value;
            _set_situationStatusCode = true;
         }
      }

      public  MixedAnyType SituationGlobal
      {
         get
         {
            if (this.situationGlobal == null)
                throw new XBException("field situationGlobal not set");

            return this.situationGlobal;
         }
         set
         {
            this.situationGlobal = value;
         }
      }

      public  MixedAnyType ForcesToSupport
      {
         get
         {
            if (this.forcesToSupport == null)
                throw new XBException("field forcesToSupport not set");

            return this.forcesToSupport;
         }
         set
         {
            this.forcesToSupport = value;
         }
      }

      public  MixedAnyType TechnicalGeneral
      {
         get
         {
            if (this.technicalGeneral == null)
                throw new XBException("field technicalGeneral not set");

            return this.technicalGeneral;
         }
         set
         {
            this.technicalGeneral = value;
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

               // situationStatusCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.situationStatusCode =  SectionStatusCode.decode(text, xbContext);

                  _set_situationStatusCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // situationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.situationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.situationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // forcesToSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.forcesToSupport = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.forcesToSupport.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // technicalGeneral
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.technicalGeneral = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.technicalGeneral.decode(reader, xbContext, false, false);

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

         // situationStatusCode
         if (_set_situationStatusCode)  {
            encoder.encodeStartElement("situationStatusCode", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.situationStatusCode, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // situationGlobal
         if (this.situationGlobal != null)  {
            encoder.encodeStartElement("situationGlobal", "", "");
            this.situationGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // forcesToSupport
         if (this.forcesToSupport != null)  {
            encoder.encodeStartElement("forcesToSupport", "", "");
            this.forcesToSupport.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // technicalGeneral
         if (this.technicalGeneral != null)  {
            encoder.encodeStartElement("technicalGeneral", "", "");
            this.technicalGeneral.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","missionStatusCode"),
         new XBQualifiedName("","missionGlobal"),
         new XBQualifiedName("","logisticsElement"),
         new XBQualifiedName("","objective"),
         new XBQualifiedName("","priority"),
         new XBQualifiedName("","effort")
      };
      static NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int missionStatusCode;
      protected bool _set_missionStatusCode = false;
      protected  MixedAnyType missionGlobal;   //optional
      protected  MixedAnyType logisticsElement;   //optional
      protected  MixedAnyType objective;   //optional
      protected  MixedAnyType priority;   //optional
      protected  MixedAnyType effort;   //optional

      //attribute methods

      //content methods

      public int MissionStatusCode
      {
         get
         {
            if (!_set_missionStatusCode)
                throw new XBException("field missionStatusCode not set");

            return this.missionStatusCode;
         }
         set
         {
            this.missionStatusCode = value;
            _set_missionStatusCode = true;
         }
      }

      public  MixedAnyType MissionGlobal
      {
         get
         {
            if (this.missionGlobal == null)
                throw new XBException("field missionGlobal not set");

            return this.missionGlobal;
         }
         set
         {
            this.missionGlobal = value;
         }
      }

      public  MixedAnyType LogisticsElement
      {
         get
         {
            if (this.logisticsElement == null)
                throw new XBException("field logisticsElement not set");

            return this.logisticsElement;
         }
         set
         {
            this.logisticsElement = value;
         }
      }

      public  MixedAnyType Objective
      {
         get
         {
            if (this.objective == null)
                throw new XBException("field objective not set");

            return this.objective;
         }
         set
         {
            this.objective = value;
         }
      }

      public  MixedAnyType Priority
      {
         get
         {
            if (this.priority == null)
                throw new XBException("field priority not set");

            return this.priority;
         }
         set
         {
            this.priority = value;
         }
      }

      public  MixedAnyType Effort
      {
         get
         {
            if (this.effort == null)
                throw new XBException("field effort not set");

            return this.effort;
         }
         set
         {
            this.effort = value;
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

               // missionStatusCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.missionStatusCode =  SectionStatusCode.decode(text, xbContext);

                  _set_missionStatusCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // missionGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.missionGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.missionGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // logisticsElement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.logisticsElement = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.logisticsElement.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // objective
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.objective = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.objective.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // priority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.priority = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.priority.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // effort
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.effort = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.effort.decode(reader, xbContext, false, false);

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

         // missionStatusCode
         if (_set_missionStatusCode)  {
            encoder.encodeStartElement("missionStatusCode", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.missionStatusCode, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // missionGlobal
         if (this.missionGlobal != null)  {
            encoder.encodeStartElement("missionGlobal", "", "");
            this.missionGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // logisticsElement
         if (this.logisticsElement != null)  {
            encoder.encodeStartElement("logisticsElement", "", "");
            this.logisticsElement.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // objective
         if (this.objective != null)  {
            encoder.encodeStartElement("objective", "", "");
            this.objective.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // priority
         if (this.priority != null)  {
            encoder.encodeStartElement("priority", "", "");
            this.priority.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // effort
         if (this.effort != null)  {
            encoder.encodeStartElement("effort", "", "");
            this.effort.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","executionStatusCode"),
         new XBQualifiedName("","executionGlobal"),
         new XBQualifiedName("","logisticsManeuver"),
         new XBQualifiedName("","logisticsResources"),
         new XBQualifiedName("","logisticsDeployment"),
         new XBQualifiedName("","supplies"),
         new XBQualifiedName("","maintenance"),
         new XBQualifiedName("","healthSupport"),
         new XBQualifiedName("","humanSupport"),
         new XBQualifiedName("","traffic")
      };
      static NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int executionStatusCode;
      protected bool _set_executionStatusCode = false;
      protected  MixedAnyType executionGlobal;   //optional
      protected  MixedAnyType logisticsManeuver;   //optional
      protected  MixedAnyType logisticsResources;   //optional
      protected  MixedAnyType logisticsDeployment;   //optional
      protected  MixedAnyType supplies;   //optional
      protected  MixedAnyType maintenance;   //optional
      protected  MixedAnyType healthSupport;   //optional
      protected  MixedAnyType humanSupport;   //optional
      protected  MixedAnyType traffic;   //optional

      //attribute methods

      //content methods

      public int ExecutionStatusCode
      {
         get
         {
            if (!_set_executionStatusCode)
                throw new XBException("field executionStatusCode not set");

            return this.executionStatusCode;
         }
         set
         {
            this.executionStatusCode = value;
            _set_executionStatusCode = true;
         }
      }

      public  MixedAnyType ExecutionGlobal
      {
         get
         {
            if (this.executionGlobal == null)
                throw new XBException("field executionGlobal not set");

            return this.executionGlobal;
         }
         set
         {
            this.executionGlobal = value;
         }
      }

      public  MixedAnyType LogisticsManeuver
      {
         get
         {
            if (this.logisticsManeuver == null)
                throw new XBException("field logisticsManeuver not set");

            return this.logisticsManeuver;
         }
         set
         {
            this.logisticsManeuver = value;
         }
      }

      public  MixedAnyType LogisticsResources
      {
         get
         {
            if (this.logisticsResources == null)
                throw new XBException("field logisticsResources not set");

            return this.logisticsResources;
         }
         set
         {
            this.logisticsResources = value;
         }
      }

      public  MixedAnyType LogisticsDeployment
      {
         get
         {
            if (this.logisticsDeployment == null)
                throw new XBException("field logisticsDeployment not set");

            return this.logisticsDeployment;
         }
         set
         {
            this.logisticsDeployment = value;
         }
      }

      public  MixedAnyType Supplies
      {
         get
         {
            if (this.supplies == null)
                throw new XBException("field supplies not set");

            return this.supplies;
         }
         set
         {
            this.supplies = value;
         }
      }

      public  MixedAnyType Maintenance
      {
         get
         {
            if (this.maintenance == null)
                throw new XBException("field maintenance not set");

            return this.maintenance;
         }
         set
         {
            this.maintenance = value;
         }
      }

      public  MixedAnyType HealthSupport
      {
         get
         {
            if (this.healthSupport == null)
                throw new XBException("field healthSupport not set");

            return this.healthSupport;
         }
         set
         {
            this.healthSupport = value;
         }
      }

      public  MixedAnyType HumanSupport
      {
         get
         {
            if (this.humanSupport == null)
                throw new XBException("field humanSupport not set");

            return this.humanSupport;
         }
         set
         {
            this.humanSupport = value;
         }
      }

      public  MixedAnyType Traffic
      {
         get
         {
            if (this.traffic == null)
                throw new XBException("field traffic not set");

            return this.traffic;
         }
         set
         {
            this.traffic = value;
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

               // executionStatusCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.executionStatusCode =  SectionStatusCode.decode(text, xbContext);

                  _set_executionStatusCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // executionGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.executionGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.executionGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // logisticsManeuver
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.logisticsManeuver = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.logisticsManeuver.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // logisticsResources
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.logisticsResources = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.logisticsResources.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // logisticsDeployment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.logisticsDeployment = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.logisticsDeployment.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // supplies
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.supplies = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.supplies.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // maintenance
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.maintenance = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.maintenance.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // healthSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.healthSupport = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.healthSupport.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // humanSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.humanSupport = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.humanSupport.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // traffic
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  this.traffic = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.traffic.decode(reader, xbContext, false, false);

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

         // executionStatusCode
         if (_set_executionStatusCode)  {
            encoder.encodeStartElement("executionStatusCode", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.executionStatusCode, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // executionGlobal
         if (this.executionGlobal != null)  {
            encoder.encodeStartElement("executionGlobal", "", "");
            this.executionGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // logisticsManeuver
         if (this.logisticsManeuver != null)  {
            encoder.encodeStartElement("logisticsManeuver", "", "");
            this.logisticsManeuver.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // logisticsResources
         if (this.logisticsResources != null)  {
            encoder.encodeStartElement("logisticsResources", "", "");
            this.logisticsResources.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // logisticsDeployment
         if (this.logisticsDeployment != null)  {
            encoder.encodeStartElement("logisticsDeployment", "", "");
            this.logisticsDeployment.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // supplies
         if (this.supplies != null)  {
            encoder.encodeStartElement("supplies", "", "");
            this.supplies.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // maintenance
         if (this.maintenance != null)  {
            encoder.encodeStartElement("maintenance", "", "");
            this.maintenance.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // healthSupport
         if (this.healthSupport != null)  {
            encoder.encodeStartElement("healthSupport", "", "");
            this.healthSupport.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // humanSupport
         if (this.humanSupport != null)  {
            encoder.encodeStartElement("humanSupport", "", "");
            this.humanSupport.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // traffic
         if (this.traffic != null)  {
            encoder.encodeStartElement("traffic", "", "");
            this.traffic.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","administrativeAndLogisticsServicesSectionStatus")
            ,
         new XBQualifiedName("","administrativeAndLogisticsServicesGlobal"),
         new XBQualifiedName("","A_situation"),
         new XBQualifiedName("","B_mission"),
         new XBQualifiedName("","C_execution"),
         new XBQualifiedName("","D_administration"),
         new XBQualifiedName("","E_commandOrganization")
      };
      static NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int administrativeAndLogisticsServicesSectionStatus;
      protected bool _set_administrativeAndLogisticsServicesSectionStatus = false;
      protected  MixedAnyType administrativeAndLogisticsServicesGlobal;
            //optional
      protected  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation a_situation;
            //optional
      protected  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission b_mission;
            //optional
      protected  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution c_execution;
            //optional
      protected  MixedAnyType d_administration;   //optional
      protected  MixedAnyType e_commandOrganization;   //optional

      //attribute methods

      //content methods

      public int AdministrativeAndLogisticsServicesSectionStatus
      {
         get
         {
            if (!_set_administrativeAndLogisticsServicesSectionStatus)
                throw new XBException("field administrativeAndLogisticsServicesSectionStatus not set");

            return this.administrativeAndLogisticsServicesSectionStatus;
         }
         set
         {
            this.administrativeAndLogisticsServicesSectionStatus = value;
            _set_administrativeAndLogisticsServicesSectionStatus = true;
         }
      }

      public  MixedAnyType AdministrativeAndLogisticsServicesGlobal
      {
         get
         {
            if (this.administrativeAndLogisticsServicesGlobal == null)
                throw new XBException("field administrativeAndLogisticsServicesGlobal not set");

            return this.administrativeAndLogisticsServicesGlobal;
         }
         set
         {
            this.administrativeAndLogisticsServicesGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation A_situation
      {
         get
         {
            if (this.a_situation == null)
                throw new XBException("field a_situation not set");

            return this.a_situation;
         }
         set
         {
            this.a_situation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission B_mission
      {
         get
         {
            if (this.b_mission == null)
                throw new XBException("field b_mission not set");

            return this.b_mission;
         }
         set
         {
            this.b_mission = value;
         }
      }

      public  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution C_execution
      {
         get
         {
            if (this.c_execution == null)
                throw new XBException("field c_execution not set");

            return this.c_execution;
         }
         set
         {
            this.c_execution = value;
         }
      }

      public  MixedAnyType D_administration
      {
         get
         {
            if (this.d_administration == null)
                throw new XBException("field d_administration not set");

            return this.d_administration;
         }
         set
         {
            this.d_administration = value;
         }
      }

      public  MixedAnyType E_commandOrganization
      {
         get
         {
            if (this.e_commandOrganization == null)
                throw new XBException("field e_commandOrganization not set");

            return this.e_commandOrganization;
         }
         set
         {
            this.e_commandOrganization = value;
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

               // administrativeAndLogisticsServicesSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.administrativeAndLogisticsServicesSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_administrativeAndLogisticsServicesSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // administrativeAndLogisticsServicesGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.administrativeAndLogisticsServicesGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.administrativeAndLogisticsServicesGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_situation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_situation = new  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_A_situation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_situation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_mission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_mission = new  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_B_mission();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_mission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_execution
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c_execution = new  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices_C_execution();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_execution.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_administration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.d_administration = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d_administration.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // e_commandOrganization
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.e_commandOrganization = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.e_commandOrganization.decode(reader, xbContext, false, false);

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

         // administrativeAndLogisticsServicesSectionStatus
         if (_set_administrativeAndLogisticsServicesSectionStatus)  {
            encoder.encodeStartElement("administrativeAndLogisticsServicesSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.administrativeAndLogisticsServicesSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // administrativeAndLogisticsServicesGlobal
         if (this.administrativeAndLogisticsServicesGlobal != null)  {
            encoder.encodeStartElement("administrativeAndLogisticsServicesGlobal", "", "");
            this.administrativeAndLogisticsServicesGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // a_situation
         if (this.a_situation != null)  {
            encoder.encodeStartElement("A_situation", "", "");
            this.a_situation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b_mission
         if (this.b_mission != null)  {
            encoder.encodeStartElement("B_mission", "", "");
            this.b_mission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // c_execution
         if (this.c_execution != null)  {
            encoder.encodeStartElement("C_execution", "", "");
            this.c_execution.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d_administration
         if (this.d_administration != null)  {
            encoder.encodeStartElement("D_administration", "", "");
            this.d_administration.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // e_commandOrganization
         if (this.e_commandOrganization != null)  {
            encoder.encodeStartElement("E_commandOrganization", "", "");
            this.e_commandOrganization.encode(encoder, xbContext, null, 
               false);
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

   public class NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","commandSectionStatus"),
         new XBQualifiedName("","commandGlobal"),
         new XBQualifiedName("","A1_hqOrganization"),
         new XBQualifiedName("","A2_hqLocations"),
         new XBQualifiedName("","A3_shiftedLinks")
      };
      static NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int commandSectionStatus;
      protected bool _set_commandSectionStatus = false;
      protected  MixedAnyType commandGlobal;   //optional
      protected  MixedAnyType a1_hqOrganization;   //optional
      protected  MixedAnyType a2_hqLocations;   //optional
      protected  MixedAnyType a3_shiftedLinks;   //optional

      //attribute methods

      //content methods

      public int CommandSectionStatus
      {
         get
         {
            if (!_set_commandSectionStatus)
                throw new XBException("field commandSectionStatus not set");

            return this.commandSectionStatus;
         }
         set
         {
            this.commandSectionStatus = value;
            _set_commandSectionStatus = true;
         }
      }

      public  MixedAnyType CommandGlobal
      {
         get
         {
            if (this.commandGlobal == null)
                throw new XBException("field commandGlobal not set");

            return this.commandGlobal;
         }
         set
         {
            this.commandGlobal = value;
         }
      }

      public  MixedAnyType A1_hqOrganization
      {
         get
         {
            if (this.a1_hqOrganization == null)
                throw new XBException("field a1_hqOrganization not set");

            return this.a1_hqOrganization;
         }
         set
         {
            this.a1_hqOrganization = value;
         }
      }

      public  MixedAnyType A2_hqLocations
      {
         get
         {
            if (this.a2_hqLocations == null)
                throw new XBException("field a2_hqLocations not set");

            return this.a2_hqLocations;
         }
         set
         {
            this.a2_hqLocations = value;
         }
      }

      public  MixedAnyType A3_shiftedLinks
      {
         get
         {
            if (this.a3_shiftedLinks == null)
                throw new XBException("field a3_shiftedLinks not set");

            return this.a3_shiftedLinks;
         }
         set
         {
            this.a3_shiftedLinks = value;
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

               // commandSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.commandSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_commandSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // commandGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.commandGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.commandGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a1_hqOrganization
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a1_hqOrganization = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a1_hqOrganization.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a2_hqLocations
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.a2_hqLocations = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a2_hqLocations.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a3_shiftedLinks
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.a3_shiftedLinks = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a3_shiftedLinks.decode(reader, xbContext, false, false);

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

         // commandSectionStatus
         if (_set_commandSectionStatus)  {
            encoder.encodeStartElement("commandSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.commandSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // commandGlobal
         if (this.commandGlobal != null)  {
            encoder.encodeStartElement("commandGlobal", "", "");
            this.commandGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a1_hqOrganization
         if (this.a1_hqOrganization != null)  {
            encoder.encodeStartElement("A1_hqOrganization", "", "");
            this.a1_hqOrganization.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a2_hqLocations
         if (this.a2_hqLocations != null)  {
            encoder.encodeStartElement("A2_hqLocations", "", "");
            this.a2_hqLocations.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a3_shiftedLinks
         if (this.a3_shiftedLinks != null)  {
            encoder.encodeStartElement("A3_shiftedLinks", "", "");
            this.a3_shiftedLinks.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ITAndLinksSectionStatus"),
         new XBQualifiedName("","ITAndLinksGlobal"),
         new XBQualifiedName("","B1_IT"),
         new XBQualifiedName("","B2_links")
      };
      static NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int iTAndLinksSectionStatus;
      protected bool _set_iTAndLinksSectionStatus = false;
      protected  MixedAnyType iTAndLinksGlobal;   //optional
      protected  MixedAnyType b1_IT;   //optional
      protected  MixedAnyType b2_links;   //optional

      //attribute methods

      //content methods

      public int ITAndLinksSectionStatus
      {
         get
         {
            if (!_set_iTAndLinksSectionStatus)
                throw new XBException("field iTAndLinksSectionStatus not set");

            return this.iTAndLinksSectionStatus;
         }
         set
         {
            this.iTAndLinksSectionStatus = value;
            _set_iTAndLinksSectionStatus = true;
         }
      }

      public  MixedAnyType ITAndLinksGlobal
      {
         get
         {
            if (this.iTAndLinksGlobal == null)
                throw new XBException("field iTAndLinksGlobal not set");

            return this.iTAndLinksGlobal;
         }
         set
         {
            this.iTAndLinksGlobal = value;
         }
      }

      public  MixedAnyType B1_IT
      {
         get
         {
            if (this.b1_IT == null)
                throw new XBException("field b1_IT not set");

            return this.b1_IT;
         }
         set
         {
            this.b1_IT = value;
         }
      }

      public  MixedAnyType B2_links
      {
         get
         {
            if (this.b2_links == null)
                throw new XBException("field b2_links not set");

            return this.b2_links;
         }
         set
         {
            this.b2_links = value;
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

               // iTAndLinksSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.iTAndLinksSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_iTAndLinksSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // iTAndLinksGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.iTAndLinksGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.iTAndLinksGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b1_IT
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.b1_IT = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b1_IT.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b2_links
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b2_links = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b2_links.decode(reader, xbContext, false, false);

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

         // iTAndLinksSectionStatus
         if (_set_iTAndLinksSectionStatus)  {
            encoder.encodeStartElement("ITAndLinksSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.iTAndLinksSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // iTAndLinksGlobal
         if (this.iTAndLinksGlobal != null)  {
            encoder.encodeStartElement("ITAndLinksGlobal", "", "");
            this.iTAndLinksGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b1_IT
         if (this.b1_IT != null)  {
            encoder.encodeStartElement("B1_IT", "", "");
            this.b1_IT.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b2_links
         if (this.b2_links != null)  {
            encoder.encodeStartElement("B2_links", "", "");
            this.b2_links.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__5_commandAndTransmissions : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__5_commandAndTransmissions");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","commandAndTransmissionsSectionStatus"),
         new XBQualifiedName("","commandAndTransmissionsGlobal"),
         new XBQualifiedName("","A_command"),
         new XBQualifiedName("","B_ITAndLinks")
      };
      static NC1_OPORD_ELEM_2__5_commandAndTransmissions() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int commandAndTransmissionsSectionStatus;
      protected bool _set_commandAndTransmissionsSectionStatus = false;
      protected  MixedAnyType commandAndTransmissionsGlobal;   //optional
         
      protected  NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command a_command;
            //optional
      protected  NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks b_ITAndLinks;
            //optional

      //attribute methods

      //content methods

      public int CommandAndTransmissionsSectionStatus
      {
         get
         {
            if (!_set_commandAndTransmissionsSectionStatus)
                throw new XBException("field commandAndTransmissionsSectionStatus not set");

            return this.commandAndTransmissionsSectionStatus;
         }
         set
         {
            this.commandAndTransmissionsSectionStatus = value;
            _set_commandAndTransmissionsSectionStatus = true;
         }
      }

      public  MixedAnyType CommandAndTransmissionsGlobal
      {
         get
         {
            if (this.commandAndTransmissionsGlobal == null)
                throw new XBException("field commandAndTransmissionsGlobal not set");

            return this.commandAndTransmissionsGlobal;
         }
         set
         {
            this.commandAndTransmissionsGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command A_command
      {
         get
         {
            if (this.a_command == null)
                throw new XBException("field a_command not set");

            return this.a_command;
         }
         set
         {
            this.a_command = value;
         }
      }

      public  NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks B_ITAndLinks
      {
         get
         {
            if (this.b_ITAndLinks == null)
                throw new XBException("field b_ITAndLinks not set");

            return this.b_ITAndLinks;
         }
         set
         {
            this.b_ITAndLinks = value;
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

               // commandAndTransmissionsSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.commandAndTransmissionsSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_commandAndTransmissionsSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // commandAndTransmissionsGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.commandAndTransmissionsGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.commandAndTransmissionsGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_command
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_command = new  NC1_OPORD_ELEM_2__5_commandAndTransmissions_A_command();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_command.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_ITAndLinks
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_ITAndLinks = new  NC1_OPORD_ELEM_2__5_commandAndTransmissions_B_ITAndLinks();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_ITAndLinks.decode(reader, xbContext, false, false);

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

         // commandAndTransmissionsSectionStatus
         if (_set_commandAndTransmissionsSectionStatus)  {
            encoder.encodeStartElement("commandAndTransmissionsSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.commandAndTransmissionsSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // commandAndTransmissionsGlobal
         if (this.commandAndTransmissionsGlobal != null)  {
            encoder.encodeStartElement("commandAndTransmissionsGlobal", "", "");
            this.commandAndTransmissionsGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // a_command
         if (this.a_command != null)  {
            encoder.encodeStartElement("A_command", "", "");
            this.a_command.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b_ITAndLinks
         if (this.b_ITAndLinks != null)  {
            encoder.encodeStartElement("B_ITAndLinks", "", "");
            this.b_ITAndLinks.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","flightInformationSectionStatus"),
         new XBQualifiedName("","flightInformationGlobal"),
         new XBQualifiedName("","presentationTime"),
         new XBQualifiedName("","takeoffTime"),
         new XBQualifiedName("","flightDuration"),
         new XBQualifiedName("","planesNumber"),
         new XBQualifiedName("","dropHeight"),
         new XBQualifiedName("","dropSchedule")
      };
      static NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int flightInformationSectionStatus;
      protected bool _set_flightInformationSectionStatus = false;
      protected  MixedAnyType flightInformationGlobal;   //optional
      protected string presentationTime;
      protected bool _set_presentationTime = false;
      protected string takeoffTime;
      protected bool _set_takeoffTime = false;
      protected XBDuration flightDuration;   //optional
      protected int planesNumber;
      protected bool _set_planesNumber = false;
      protected int dropHeight;
      protected bool _set_dropHeight = false;
      protected string dropSchedule;
      protected bool _set_dropSchedule = false;

      //attribute methods

      //content methods

      public int FlightInformationSectionStatus
      {
         get
         {
            if (!_set_flightInformationSectionStatus)
                throw new XBException("field flightInformationSectionStatus not set");

            return this.flightInformationSectionStatus;
         }
         set
         {
            this.flightInformationSectionStatus = value;
            _set_flightInformationSectionStatus = true;
         }
      }

      public  MixedAnyType FlightInformationGlobal
      {
         get
         {
            if (this.flightInformationGlobal == null)
                throw new XBException("field flightInformationGlobal not set");

            return this.flightInformationGlobal;
         }
         set
         {
            this.flightInformationGlobal = value;
         }
      }

      public string PresentationTime
      {
         get
         {
            if (!_set_presentationTime)
                throw new XBException("field presentationTime not set");

            return this.presentationTime;
         }
         set
         {
            this.presentationTime = value;
            _set_presentationTime = true;
         }
      }

      public string TakeoffTime
      {
         get
         {
            if (!_set_takeoffTime)
                throw new XBException("field takeoffTime not set");

            return this.takeoffTime;
         }
         set
         {
            this.takeoffTime = value;
            _set_takeoffTime = true;
         }
      }

      public XBDuration FlightDuration
      {
         get
         {
            if (this.flightDuration == null)
                throw new XBException("field flightDuration not set");

            return this.flightDuration;
         }
         set
         {
            this.flightDuration = value;
         }
      }

      public int PlanesNumber
      {
         get
         {
            if (!_set_planesNumber)
                throw new XBException("field planesNumber not set");

            return this.planesNumber;
         }
         set
         {
            this.planesNumber = value;
            _set_planesNumber = true;
         }
      }

      public int DropHeight
      {
         get
         {
            if (!_set_dropHeight)
                throw new XBException("field dropHeight not set");

            return this.dropHeight;
         }
         set
         {
            this.dropHeight = value;
            _set_dropHeight = true;
         }
      }

      public string DropSchedule
      {
         get
         {
            if (!_set_dropSchedule)
                throw new XBException("field dropSchedule not set");

            return this.dropSchedule;
         }
         set
         {
            this.dropSchedule = value;
            _set_dropSchedule = true;
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

               // flightInformationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.flightInformationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_flightInformationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // flightInformationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.flightInformationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.flightInformationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // presentationTime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.presentationTime = text;

                  _set_presentationTime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // takeoffTime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.takeoffTime = text;

                  _set_takeoffTime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // flightDuration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.flightDuration = XBDurationHelper.parseXML(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // planesNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.planesNumber = XBSimpleType.parseInt32(text);

                  _set_planesNumber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // dropHeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.dropHeight =  AltitudeType.decode(text, xbContext);

                  _set_dropHeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // dropSchedule
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.dropSchedule = text;

                  _set_dropSchedule = true;

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

         // flightInformationSectionStatus
         if (_set_flightInformationSectionStatus)  {
            encoder.encodeStartElement("flightInformationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.flightInformationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // flightInformationGlobal
         if (this.flightInformationGlobal != null)  {
            encoder.encodeStartElement("flightInformationGlobal", "", "");
            this.flightInformationGlobal.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // presentationTime
         if (_set_presentationTime)  {
            encoder.encodeStartElement("presentationTime", "", "");
            String text_4;
            text_4 = this.presentationTime;
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // takeoffTime
         if (_set_takeoffTime)  {
            encoder.encodeStartElement("takeoffTime", "", "");
            String text_4;
            text_4 = this.takeoffTime;
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // flightDuration
         if (this.flightDuration != null)  {
            encoder.encodeStartElement("flightDuration", "", "");
            String text_4;
            text_4 = this.flightDuration.ToString();
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // planesNumber
         if (_set_planesNumber)  {
            encoder.encodeStartElement("planesNumber", "", "");
            String text_4;
            text_4 = this.planesNumber.ToString();
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // dropHeight
         if (_set_dropHeight)  {
            encoder.encodeStartElement("dropHeight", "", "");
            String text_4;
            text_4 =  AltitudeType.encode(this.dropHeight, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // dropSchedule
         if (_set_dropSchedule)  {
            encoder.encodeStartElement("dropSchedule", "", "");
            String text_4;
            text_4 = this.dropSchedule;
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

   public class NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","landingAreaCaracteristicsSectionStatus"),
         new XBQualifiedName("","landingAreaCaracteristicsGlobal"),
         new XBQualifiedName("","geographicSituation"),
         new XBQualifiedName("","objectiveSituation"),
         new XBQualifiedName("","dimensions"),
         new XBQualifiedName("","groundType"),
         new XBQualifiedName("","immediateEnvironment")
      };
      static NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int landingAreaCaracteristicsSectionStatus;
      protected bool _set_landingAreaCaracteristicsSectionStatus = false;
      protected  MixedAnyType landingAreaCaracteristicsGlobal;
            //optional
      protected  MixedAnyType geographicSituation;   //optional
      protected  MixedAnyType objectiveSituation;   //optional
      protected  MixedAnyType dimensions;   //optional
      protected string groundType;
      protected bool _set_groundType = false;
      protected  MixedAnyType immediateEnvironment;   //optional

      //attribute methods

      //content methods

      public int LandingAreaCaracteristicsSectionStatus
      {
         get
         {
            if (!_set_landingAreaCaracteristicsSectionStatus)
                throw new XBException("field landingAreaCaracteristicsSectionStatus not set");

            return this.landingAreaCaracteristicsSectionStatus;
         }
         set
         {
            this.landingAreaCaracteristicsSectionStatus = value;
            _set_landingAreaCaracteristicsSectionStatus = true;
         }
      }

      public  MixedAnyType LandingAreaCaracteristicsGlobal
      {
         get
         {
            if (this.landingAreaCaracteristicsGlobal == null)
                throw new XBException("field landingAreaCaracteristicsGlobal not set");

            return this.landingAreaCaracteristicsGlobal;
         }
         set
         {
            this.landingAreaCaracteristicsGlobal = value;
         }
      }

      public  MixedAnyType GeographicSituation
      {
         get
         {
            if (this.geographicSituation == null)
                throw new XBException("field geographicSituation not set");

            return this.geographicSituation;
         }
         set
         {
            this.geographicSituation = value;
         }
      }

      public  MixedAnyType ObjectiveSituation
      {
         get
         {
            if (this.objectiveSituation == null)
                throw new XBException("field objectiveSituation not set");

            return this.objectiveSituation;
         }
         set
         {
            this.objectiveSituation = value;
         }
      }

      public  MixedAnyType Dimensions
      {
         get
         {
            if (this.dimensions == null)
                throw new XBException("field dimensions not set");

            return this.dimensions;
         }
         set
         {
            this.dimensions = value;
         }
      }

      public string GroundType
      {
         get
         {
            if (!_set_groundType)
                throw new XBException("field groundType not set");

            return this.groundType;
         }
         set
         {
            this.groundType = value;
            _set_groundType = true;
         }
      }

      public  MixedAnyType ImmediateEnvironment
      {
         get
         {
            if (this.immediateEnvironment == null)
                throw new XBException("field immediateEnvironment not set");

            return this.immediateEnvironment;
         }
         set
         {
            this.immediateEnvironment = value;
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

               // landingAreaCaracteristicsSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.landingAreaCaracteristicsSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_landingAreaCaracteristicsSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // landingAreaCaracteristicsGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.landingAreaCaracteristicsGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.landingAreaCaracteristicsGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // geographicSituation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.geographicSituation = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.geographicSituation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // objectiveSituation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.objectiveSituation = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.objectiveSituation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // dimensions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.dimensions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.dimensions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // groundType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.groundType =  LongTextType.decode(text, xbContext);

                  _set_groundType = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // immediateEnvironment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.immediateEnvironment = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.immediateEnvironment.decode(reader, xbContext, false, false);

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

         // landingAreaCaracteristicsSectionStatus
         if (_set_landingAreaCaracteristicsSectionStatus)  {
            encoder.encodeStartElement("landingAreaCaracteristicsSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.landingAreaCaracteristicsSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // landingAreaCaracteristicsGlobal
         if (this.landingAreaCaracteristicsGlobal != null)  {
            encoder.encodeStartElement("landingAreaCaracteristicsGlobal", "", "");
            this.landingAreaCaracteristicsGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // geographicSituation
         if (this.geographicSituation != null)  {
            encoder.encodeStartElement("geographicSituation", "", "");
            this.geographicSituation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // objectiveSituation
         if (this.objectiveSituation != null)  {
            encoder.encodeStartElement("objectiveSituation", "", "");
            this.objectiveSituation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // dimensions
         if (this.dimensions != null)  {
            encoder.encodeStartElement("dimensions", "", "");
            this.dimensions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // groundType
         if (_set_groundType)  {
            encoder.encodeStartElement("groundType", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.groundType, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // immediateEnvironment
         if (this.immediateEnvironment != null)  {
            encoder.encodeStartElement("immediateEnvironment", "", "");
            this.immediateEnvironment.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","landingConditionSectionStatus"),
         new XBQualifiedName("","landdingConditionGlobal"),
         new XBQualifiedName("","landingPlan"),
         new XBQualifiedName("","loadDistribution")
      };
      static NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int landingConditionSectionStatus;
      protected bool _set_landingConditionSectionStatus = false;
      protected  MixedAnyType landdingConditionGlobal;   //optional
      protected  MixedAnyType landingPlan;   //optional
      protected string loadDistribution;
      protected bool _set_loadDistribution = false;

      //attribute methods

      //content methods

      public int LandingConditionSectionStatus
      {
         get
         {
            if (!_set_landingConditionSectionStatus)
                throw new XBException("field landingConditionSectionStatus not set");

            return this.landingConditionSectionStatus;
         }
         set
         {
            this.landingConditionSectionStatus = value;
            _set_landingConditionSectionStatus = true;
         }
      }

      public  MixedAnyType LanddingConditionGlobal
      {
         get
         {
            if (this.landdingConditionGlobal == null)
                throw new XBException("field landdingConditionGlobal not set");

            return this.landdingConditionGlobal;
         }
         set
         {
            this.landdingConditionGlobal = value;
         }
      }

      public  MixedAnyType LandingPlan
      {
         get
         {
            if (this.landingPlan == null)
                throw new XBException("field landingPlan not set");

            return this.landingPlan;
         }
         set
         {
            this.landingPlan = value;
         }
      }

      public string LoadDistribution
      {
         get
         {
            if (!_set_loadDistribution)
                throw new XBException("field loadDistribution not set");

            return this.loadDistribution;
         }
         set
         {
            this.loadDistribution = value;
            _set_loadDistribution = true;
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

               // landingConditionSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.landingConditionSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_landingConditionSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // landdingConditionGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.landdingConditionGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.landdingConditionGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // landingPlan
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.landingPlan = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.landingPlan.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // loadDistribution
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.loadDistribution =  LongTextType.decode(text, xbContext);

                  _set_loadDistribution = true;

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

         // landingConditionSectionStatus
         if (_set_landingConditionSectionStatus)  {
            encoder.encodeStartElement("landingConditionSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.landingConditionSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // landdingConditionGlobal
         if (this.landdingConditionGlobal != null)  {
            encoder.encodeStartElement("landdingConditionGlobal", "", "");
            this.landdingConditionGlobal.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // landingPlan
         if (this.landingPlan != null)  {
            encoder.encodeStartElement("landingPlan", "", "");
            this.landingPlan.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // loadDistribution
         if (_set_loadDistribution)  {
            encoder.encodeStartElement("loadDistribution", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.loadDistribution, xbContext);
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

   public class NC1_OPORD_ELEM_2__6_jumpOrders : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__6_jumpOrders");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","jumpOrdersSectionStatus"),
         new XBQualifiedName("","jumpOrdersGlobal"),
         new XBQualifiedName("","A_flightInformation"),
         new XBQualifiedName("","B_landingAreaCaracteristics"),
         new XBQualifiedName("","C_landingCondition"),
         new XBQualifiedName("","D_markingInformation")
      };
      static NC1_OPORD_ELEM_2__6_jumpOrders() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int jumpOrdersSectionStatus;
      protected bool _set_jumpOrdersSectionStatus = false;
      protected  MixedAnyType jumpOrdersGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation a_flightInformation;
            //optional
      protected  NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics b_landingAreaCaracteristics;
            //optional
      protected  NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition c_landingCondition;
            //optional
      protected  MixedAnyType d_markingInformation;   //optional

      //attribute methods

      //content methods

      public int JumpOrdersSectionStatus
      {
         get
         {
            if (!_set_jumpOrdersSectionStatus)
                throw new XBException("field jumpOrdersSectionStatus not set");

            return this.jumpOrdersSectionStatus;
         }
         set
         {
            this.jumpOrdersSectionStatus = value;
            _set_jumpOrdersSectionStatus = true;
         }
      }

      public  MixedAnyType JumpOrdersGlobal
      {
         get
         {
            if (this.jumpOrdersGlobal == null)
                throw new XBException("field jumpOrdersGlobal not set");

            return this.jumpOrdersGlobal;
         }
         set
         {
            this.jumpOrdersGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation A_flightInformation
      {
         get
         {
            if (this.a_flightInformation == null)
                throw new XBException("field a_flightInformation not set");

            return this.a_flightInformation;
         }
         set
         {
            this.a_flightInformation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics B_landingAreaCaracteristics
      {
         get
         {
            if (this.b_landingAreaCaracteristics == null)
                throw new XBException("field b_landingAreaCaracteristics not set");

            return this.b_landingAreaCaracteristics;
         }
         set
         {
            this.b_landingAreaCaracteristics = value;
         }
      }

      public  NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition C_landingCondition
      {
         get
         {
            if (this.c_landingCondition == null)
                throw new XBException("field c_landingCondition not set");

            return this.c_landingCondition;
         }
         set
         {
            this.c_landingCondition = value;
         }
      }

      public  MixedAnyType D_markingInformation
      {
         get
         {
            if (this.d_markingInformation == null)
                throw new XBException("field d_markingInformation not set");

            return this.d_markingInformation;
         }
         set
         {
            this.d_markingInformation = value;
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

               // jumpOrdersSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.jumpOrdersSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_jumpOrdersSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // jumpOrdersGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.jumpOrdersGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.jumpOrdersGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_flightInformation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_flightInformation = new  NC1_OPORD_ELEM_2__6_jumpOrders_A_flightInformation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_flightInformation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_landingAreaCaracteristics
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_landingAreaCaracteristics = new  NC1_OPORD_ELEM_2__6_jumpOrders_B_landingAreaCaracteristics();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_landingAreaCaracteristics.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_landingCondition
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c_landingCondition = new  NC1_OPORD_ELEM_2__6_jumpOrders_C_landingCondition();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_landingCondition.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_markingInformation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.d_markingInformation = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d_markingInformation.decode(reader, xbContext, false, false);

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

         // jumpOrdersSectionStatus
         if (_set_jumpOrdersSectionStatus)  {
            encoder.encodeStartElement("jumpOrdersSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.jumpOrdersSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // jumpOrdersGlobal
         if (this.jumpOrdersGlobal != null)  {
            encoder.encodeStartElement("jumpOrdersGlobal", "", "");
            this.jumpOrdersGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // a_flightInformation
         if (this.a_flightInformation != null)  {
            encoder.encodeStartElement("A_flightInformation", "", "");
            this.a_flightInformation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // b_landingAreaCaracteristics
         if (this.b_landingAreaCaracteristics != null)  {
            encoder.encodeStartElement("B_landingAreaCaracteristics", "", "");
            this.b_landingAreaCaracteristics.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // c_landingCondition
         if (this.c_landingCondition != null)  {
            encoder.encodeStartElement("C_landingCondition", "", "");
            this.c_landingCondition.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d_markingInformation
         if (this.d_markingInformation != null)  {
            encoder.encodeStartElement("D_markingInformation", "", "");
            this.d_markingInformation.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","personnelIdentificationSectionStatus"),
         new XBQualifiedName("","personnelIdentificationGlobal"),
         new XBQualifiedName("","units"),
         new XBQualifiedName("","pathfinders")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int personnelIdentificationSectionStatus;
      protected bool _set_personnelIdentificationSectionStatus = false;
      protected  MixedAnyType personnelIdentificationGlobal;   //optional
         
      protected  MixedAnyType units;   //optional
      protected  MixedAnyType pathfinders;   //optional

      //attribute methods

      //content methods

      public int PersonnelIdentificationSectionStatus
      {
         get
         {
            if (!_set_personnelIdentificationSectionStatus)
                throw new XBException("field personnelIdentificationSectionStatus not set");

            return this.personnelIdentificationSectionStatus;
         }
         set
         {
            this.personnelIdentificationSectionStatus = value;
            _set_personnelIdentificationSectionStatus = true;
         }
      }

      public  MixedAnyType PersonnelIdentificationGlobal
      {
         get
         {
            if (this.personnelIdentificationGlobal == null)
                throw new XBException("field personnelIdentificationGlobal not set");

            return this.personnelIdentificationGlobal;
         }
         set
         {
            this.personnelIdentificationGlobal = value;
         }
      }

      public  MixedAnyType Units
      {
         get
         {
            if (this.units == null)
                throw new XBException("field units not set");

            return this.units;
         }
         set
         {
            this.units = value;
         }
      }

      public  MixedAnyType Pathfinders
      {
         get
         {
            if (this.pathfinders == null)
                throw new XBException("field pathfinders not set");

            return this.pathfinders;
         }
         set
         {
            this.pathfinders = value;
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

               // personnelIdentificationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.personnelIdentificationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_personnelIdentificationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // personnelIdentificationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.personnelIdentificationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.personnelIdentificationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // units
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.units = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.units.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // pathfinders
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.pathfinders = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.pathfinders.decode(reader, xbContext, false, false);

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

         // personnelIdentificationSectionStatus
         if (_set_personnelIdentificationSectionStatus)  {
            encoder.encodeStartElement("personnelIdentificationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.personnelIdentificationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // personnelIdentificationGlobal
         if (this.personnelIdentificationGlobal != null)  {
            encoder.encodeStartElement("personnelIdentificationGlobal", "", "");
            this.personnelIdentificationGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // units
         if (this.units != null)  {
            encoder.encodeStartElement("units", "", "");
            this.units.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // pathfinders
         if (this.pathfinders != null)  {
            encoder.encodeStartElement("pathfinders", "", "");
            this.pathfinders.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","droppedMaterialIdentificationRecoverySectionStatus")
            ,
         new XBQualifiedName("","droppedMaterialIdentificationRecoveryGlobal")
            ,
         new XBQualifiedName("","packageType"),
         new XBQualifiedName("","packageMarking"),
         new XBQualifiedName("","recoveryPersonnel")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int droppedMaterialIdentificationRecoverySectionStatus;
      protected bool _set_droppedMaterialIdentificationRecoverySectionStatus = false;
      protected  MixedAnyType droppedMaterialIdentificationRecoveryGlobal;
            //optional
      protected string packageType;
      protected bool _set_packageType = false;
      protected string packageMarking;
      protected bool _set_packageMarking = false;
      protected  MixedAnyType recoveryPersonnel;   //optional

      //attribute methods

      //content methods

      public int DroppedMaterialIdentificationRecoverySectionStatus
      {
         get
         {
            if (!_set_droppedMaterialIdentificationRecoverySectionStatus)
                throw new XBException("field droppedMaterialIdentificationRecoverySectionStatus not set");

            return this.droppedMaterialIdentificationRecoverySectionStatus;
         }
         set
         {
            this.droppedMaterialIdentificationRecoverySectionStatus = value;
            _set_droppedMaterialIdentificationRecoverySectionStatus = true;
         }
      }

      public  MixedAnyType DroppedMaterialIdentificationRecoveryGlobal
      {
         get
         {
            if (this.droppedMaterialIdentificationRecoveryGlobal == null)
                throw new XBException("field droppedMaterialIdentificationRecoveryGlobal not set");

            return this.droppedMaterialIdentificationRecoveryGlobal;
         }
         set
         {
            this.droppedMaterialIdentificationRecoveryGlobal = value;
         }
      }

      public string PackageType
      {
         get
         {
            if (!_set_packageType)
                throw new XBException("field packageType not set");

            return this.packageType;
         }
         set
         {
            this.packageType = value;
            _set_packageType = true;
         }
      }

      public string PackageMarking
      {
         get
         {
            if (!_set_packageMarking)
                throw new XBException("field packageMarking not set");

            return this.packageMarking;
         }
         set
         {
            this.packageMarking = value;
            _set_packageMarking = true;
         }
      }

      public  MixedAnyType RecoveryPersonnel
      {
         get
         {
            if (this.recoveryPersonnel == null)
                throw new XBException("field recoveryPersonnel not set");

            return this.recoveryPersonnel;
         }
         set
         {
            this.recoveryPersonnel = value;
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

               // droppedMaterialIdentificationRecoverySectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.droppedMaterialIdentificationRecoverySectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_droppedMaterialIdentificationRecoverySectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // droppedMaterialIdentificationRecoveryGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.droppedMaterialIdentificationRecoveryGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.droppedMaterialIdentificationRecoveryGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // packageType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.packageType =  LongTextType.decode(text, xbContext);

                  _set_packageType = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // packageMarking
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.packageMarking =  LongTextType.decode(text, xbContext);

                  _set_packageMarking = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // recoveryPersonnel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.recoveryPersonnel = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.recoveryPersonnel.decode(reader, xbContext, false, false);

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

         // droppedMaterialIdentificationRecoverySectionStatus
         if (_set_droppedMaterialIdentificationRecoverySectionStatus)  {
            encoder.encodeStartElement("droppedMaterialIdentificationRecoverySectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.droppedMaterialIdentificationRecoverySectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // droppedMaterialIdentificationRecoveryGlobal
         if (this.droppedMaterialIdentificationRecoveryGlobal != null)  {
            encoder.encodeStartElement("droppedMaterialIdentificationRecoveryGlobal", "", "");
            this.droppedMaterialIdentificationRecoveryGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // packageType
         if (_set_packageType)  {
            encoder.encodeStartElement("packageType", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.packageType, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // packageMarking
         if (_set_packageMarking)  {
            encoder.encodeStartElement("packageMarking", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.packageMarking, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // recoveryPersonnel
         if (this.recoveryPersonnel != null)  {
            encoder.encodeStartElement("recoveryPersonnel", "", "");
            this.recoveryPersonnel.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","droppedMaterialDestinationSectionStatus"),
         new XBQualifiedName("","droppedMaterialDestinationGlobal"),
         new XBQualifiedName("","individualMaterial"),
         new XBQualifiedName("","collectiveMaterial")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int droppedMaterialDestinationSectionStatus;
      protected bool _set_droppedMaterialDestinationSectionStatus = false;
      protected  MixedAnyType droppedMaterialDestinationGlobal;
            //optional
      protected string individualMaterial;
      protected bool _set_individualMaterial = false;
      protected string collectiveMaterial;
      protected bool _set_collectiveMaterial = false;

      //attribute methods

      //content methods

      public int DroppedMaterialDestinationSectionStatus
      {
         get
         {
            if (!_set_droppedMaterialDestinationSectionStatus)
                throw new XBException("field droppedMaterialDestinationSectionStatus not set");

            return this.droppedMaterialDestinationSectionStatus;
         }
         set
         {
            this.droppedMaterialDestinationSectionStatus = value;
            _set_droppedMaterialDestinationSectionStatus = true;
         }
      }

      public  MixedAnyType DroppedMaterialDestinationGlobal
      {
         get
         {
            if (this.droppedMaterialDestinationGlobal == null)
                throw new XBException("field droppedMaterialDestinationGlobal not set");

            return this.droppedMaterialDestinationGlobal;
         }
         set
         {
            this.droppedMaterialDestinationGlobal = value;
         }
      }

      public string IndividualMaterial
      {
         get
         {
            if (!_set_individualMaterial)
                throw new XBException("field individualMaterial not set");

            return this.individualMaterial;
         }
         set
         {
            this.individualMaterial = value;
            _set_individualMaterial = true;
         }
      }

      public string CollectiveMaterial
      {
         get
         {
            if (!_set_collectiveMaterial)
                throw new XBException("field collectiveMaterial not set");

            return this.collectiveMaterial;
         }
         set
         {
            this.collectiveMaterial = value;
            _set_collectiveMaterial = true;
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

               // droppedMaterialDestinationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.droppedMaterialDestinationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_droppedMaterialDestinationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // droppedMaterialDestinationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.droppedMaterialDestinationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.droppedMaterialDestinationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // individualMaterial
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.individualMaterial =  LongTextType.decode(text, xbContext);

                  _set_individualMaterial = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // collectiveMaterial
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.collectiveMaterial =  LongTextType.decode(text, xbContext);

                  _set_collectiveMaterial = true;

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

         // droppedMaterialDestinationSectionStatus
         if (_set_droppedMaterialDestinationSectionStatus)  {
            encoder.encodeStartElement("droppedMaterialDestinationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.droppedMaterialDestinationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // droppedMaterialDestinationGlobal
         if (this.droppedMaterialDestinationGlobal != null)  {
            encoder.encodeStartElement("droppedMaterialDestinationGlobal", "", "");
            this.droppedMaterialDestinationGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // individualMaterial
         if (_set_individualMaterial)  {
            encoder.encodeStartElement("individualMaterial", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.individualMaterial, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // collectiveMaterial
         if (_set_collectiveMaterial)  {
            encoder.encodeStartElement("collectiveMaterial", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.collectiveMaterial, xbContext);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","reorganizationSystemOrganizationSectionStatus")
            ,
         new XBQualifiedName("","reorganizationSystemOrganizationGlobal"),
         new XBQualifiedName("","reorganizationTechnic"),
         new XBQualifiedName("","startPoint"),
         new XBQualifiedName("","reorganizationAxis"),
         new XBQualifiedName("","reorganizationArea"),
         new XBQualifiedName("","staffToControl"),
         new XBQualifiedName("","recognitionSignals"),
         new XBQualifiedName("","pathfindersMission")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization() 
      {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int reorganizationSystemOrganizationSectionStatus;
      protected bool _set_reorganizationSystemOrganizationSectionStatus = false;
      protected  MixedAnyType reorganizationSystemOrganizationGlobal;
            //optional
      protected string reorganizationTechnic;
      protected bool _set_reorganizationTechnic = false;
      protected  MixedAnyType startPoint;   //optional
      protected  MixedAnyType reorganizationAxis;   //optional
      protected  MixedAnyType reorganizationArea;   //optional
      protected  MixedAnyType staffToControl;   //optional
      protected string recognitionSignals;
      protected bool _set_recognitionSignals = false;
      protected  MixedAnyType pathfindersMission;   //optional

      //attribute methods

      //content methods

      public int ReorganizationSystemOrganizationSectionStatus
      {
         get
         {
            if (!_set_reorganizationSystemOrganizationSectionStatus)
                throw new XBException("field reorganizationSystemOrganizationSectionStatus not set");

            return this.reorganizationSystemOrganizationSectionStatus;
         }
         set
         {
            this.reorganizationSystemOrganizationSectionStatus = value;
            _set_reorganizationSystemOrganizationSectionStatus = true;
         }
      }

      public  MixedAnyType ReorganizationSystemOrganizationGlobal
      {
         get
         {
            if (this.reorganizationSystemOrganizationGlobal == null)
                throw new XBException("field reorganizationSystemOrganizationGlobal not set");

            return this.reorganizationSystemOrganizationGlobal;
         }
         set
         {
            this.reorganizationSystemOrganizationGlobal = value;
         }
      }

      public string ReorganizationTechnic
      {
         get
         {
            if (!_set_reorganizationTechnic)
                throw new XBException("field reorganizationTechnic not set");

            return this.reorganizationTechnic;
         }
         set
         {
            this.reorganizationTechnic = value;
            _set_reorganizationTechnic = true;
         }
      }

      public  MixedAnyType StartPoint
      {
         get
         {
            if (this.startPoint == null)
                throw new XBException("field startPoint not set");

            return this.startPoint;
         }
         set
         {
            this.startPoint = value;
         }
      }

      public  MixedAnyType ReorganizationAxis
      {
         get
         {
            if (this.reorganizationAxis == null)
                throw new XBException("field reorganizationAxis not set");

            return this.reorganizationAxis;
         }
         set
         {
            this.reorganizationAxis = value;
         }
      }

      public  MixedAnyType ReorganizationArea
      {
         get
         {
            if (this.reorganizationArea == null)
                throw new XBException("field reorganizationArea not set");

            return this.reorganizationArea;
         }
         set
         {
            this.reorganizationArea = value;
         }
      }

      public  MixedAnyType StaffToControl
      {
         get
         {
            if (this.staffToControl == null)
                throw new XBException("field staffToControl not set");

            return this.staffToControl;
         }
         set
         {
            this.staffToControl = value;
         }
      }

      public string RecognitionSignals
      {
         get
         {
            if (!_set_recognitionSignals)
                throw new XBException("field recognitionSignals not set");

            return this.recognitionSignals;
         }
         set
         {
            this.recognitionSignals = value;
            _set_recognitionSignals = true;
         }
      }

      public  MixedAnyType PathfindersMission
      {
         get
         {
            if (this.pathfindersMission == null)
                throw new XBException("field pathfindersMission not set");

            return this.pathfindersMission;
         }
         set
         {
            this.pathfindersMission = value;
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

               // reorganizationSystemOrganizationSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.reorganizationSystemOrganizationSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_reorganizationSystemOrganizationSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reorganizationSystemOrganizationGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.reorganizationSystemOrganizationGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.reorganizationSystemOrganizationGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reorganizationTechnic
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.reorganizationTechnic =  LongTextType.decode(text, xbContext);

                  _set_reorganizationTechnic = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // startPoint
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.startPoint = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.startPoint.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reorganizationAxis
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.reorganizationAxis = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.reorganizationAxis.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reorganizationArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.reorganizationArea = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.reorganizationArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // staffToControl
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.staffToControl = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.staffToControl.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // recognitionSignals
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.recognitionSignals =  LongTextType.decode(text, xbContext);

                  _set_recognitionSignals = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // pathfindersMission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.pathfindersMission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.pathfindersMission.decode(reader, xbContext, false, false);

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

         // reorganizationSystemOrganizationSectionStatus
         if (_set_reorganizationSystemOrganizationSectionStatus)  {
            encoder.encodeStartElement("reorganizationSystemOrganizationSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.reorganizationSystemOrganizationSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // reorganizationSystemOrganizationGlobal
         if (this.reorganizationSystemOrganizationGlobal != null)  {
            encoder.encodeStartElement("reorganizationSystemOrganizationGlobal", "", "");
            this.reorganizationSystemOrganizationGlobal.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // reorganizationTechnic
         if (_set_reorganizationTechnic)  {
            encoder.encodeStartElement("reorganizationTechnic", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.reorganizationTechnic, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // startPoint
         if (this.startPoint != null)  {
            encoder.encodeStartElement("startPoint", "", "");
            this.startPoint.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // reorganizationAxis
         if (this.reorganizationAxis != null)  {
            encoder.encodeStartElement("reorganizationAxis", "", "");
            this.reorganizationAxis.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // reorganizationArea
         if (this.reorganizationArea != null)  {
            encoder.encodeStartElement("reorganizationArea", "", "");
            this.reorganizationArea.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // staffToControl
         if (this.staffToControl != null)  {
            encoder.encodeStartElement("staffToControl", "", "");
            this.staffToControl.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // recognitionSignals
         if (_set_recognitionSignals)  {
            encoder.encodeStartElement("recognitionSignals", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.recognitionSignals, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // pathfindersMission
         if (this.pathfindersMission != null)  {
            encoder.encodeStartElement("pathfindersMission", "", "");
            this.pathfindersMission.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ableToMove"),
         new XBQualifiedName("","unableToMove")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected uint ableToMove;
      protected bool _set_ableToMove = false;
      protected uint unableToMove;
      protected bool _set_unableToMove = false;

      //attribute methods

      //content methods

      public uint AbleToMove
      {
         get
         {
            if (!_set_ableToMove)
                throw new XBException("field ableToMove not set");

            return this.ableToMove;
         }
         set
         {
            this.ableToMove = value;
            _set_ableToMove = true;
         }
      }

      public uint UnableToMove
      {
         get
         {
            if (!_set_unableToMove)
                throw new XBException("field unableToMove not set");

            return this.unableToMove;
         }
         set
         {
            this.unableToMove = value;
            _set_unableToMove = true;
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

               // ableToMove
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.ableToMove = XBSimpleType.parseUInt32(text);

                  _set_ableToMove = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // unableToMove
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.unableToMove = XBSimpleType.parseUInt32(text);

                  _set_unableToMove = true;

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

         // ableToMove
         if (_set_ableToMove)  {
            encoder.encodeStartElement("ableToMove", "", "");
            String text_4;
            text_4 = this.ableToMove.ToString();
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // unableToMove
         if (_set_unableToMove)  {
            encoder.encodeStartElement("unableToMove", "", "");
            String text_4;
            text_4 = this.unableToMove.ToString();
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","conductSectionStatus"),
         new XBQualifiedName("","conductGlobal"),
         new XBQualifiedName("","injured"),
         new XBQualifiedName("","enemyPresence"),
         new XBQualifiedName("","unexpectedAreaJump"),
         new XBQualifiedName("","reverseAxisJump"),
         new XBQualifiedName("","recoveryNotBelongingUnit")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int conductSectionStatus;
      protected bool _set_conductSectionStatus = false;
      protected  MixedAnyType conductGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured injured;
            //optional
      protected string enemyPresence;
      protected bool _set_enemyPresence = false;
      protected string unexpectedAreaJump;
      protected bool _set_unexpectedAreaJump = false;
      protected string reverseAxisJump;
      protected bool _set_reverseAxisJump = false;
      protected string recoveryNotBelongingUnit;
      protected bool _set_recoveryNotBelongingUnit = false;

      //attribute methods

      //content methods

      public int ConductSectionStatus
      {
         get
         {
            if (!_set_conductSectionStatus)
                throw new XBException("field conductSectionStatus not set");

            return this.conductSectionStatus;
         }
         set
         {
            this.conductSectionStatus = value;
            _set_conductSectionStatus = true;
         }
      }

      public  MixedAnyType ConductGlobal
      {
         get
         {
            if (this.conductGlobal == null)
                throw new XBException("field conductGlobal not set");

            return this.conductGlobal;
         }
         set
         {
            this.conductGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured Injured
      {
         get
         {
            if (this.injured == null)
                throw new XBException("field injured not set");

            return this.injured;
         }
         set
         {
            this.injured = value;
         }
      }

      public string EnemyPresence
      {
         get
         {
            if (!_set_enemyPresence)
                throw new XBException("field enemyPresence not set");

            return this.enemyPresence;
         }
         set
         {
            this.enemyPresence = value;
            _set_enemyPresence = true;
         }
      }

      public string UnexpectedAreaJump
      {
         get
         {
            if (!_set_unexpectedAreaJump)
                throw new XBException("field unexpectedAreaJump not set");

            return this.unexpectedAreaJump;
         }
         set
         {
            this.unexpectedAreaJump = value;
            _set_unexpectedAreaJump = true;
         }
      }

      public string ReverseAxisJump
      {
         get
         {
            if (!_set_reverseAxisJump)
                throw new XBException("field reverseAxisJump not set");

            return this.reverseAxisJump;
         }
         set
         {
            this.reverseAxisJump = value;
            _set_reverseAxisJump = true;
         }
      }

      public string RecoveryNotBelongingUnit
      {
         get
         {
            if (!_set_recoveryNotBelongingUnit)
                throw new XBException("field recoveryNotBelongingUnit not set");

            return this.recoveryNotBelongingUnit;
         }
         set
         {
            this.recoveryNotBelongingUnit = value;
            _set_recoveryNotBelongingUnit = true;
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

               // conductSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.conductSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_conductSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // conductGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.conductGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.conductGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // injured
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.injured = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct_injured();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.injured.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // enemyPresence
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.enemyPresence =  LongTextType.decode(text, xbContext);

                  _set_enemyPresence = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // unexpectedAreaJump
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.unexpectedAreaJump =  LongTextType.decode(text, xbContext);

                  _set_unexpectedAreaJump = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reverseAxisJump
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.reverseAxisJump =  LongTextType.decode(text, xbContext);

                  _set_reverseAxisJump = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // recoveryNotBelongingUnit
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.recoveryNotBelongingUnit =  LongTextType.decode(text, xbContext);

                  _set_recoveryNotBelongingUnit = true;

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

         // conductSectionStatus
         if (_set_conductSectionStatus)  {
            encoder.encodeStartElement("conductSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.conductSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // conductGlobal
         if (this.conductGlobal != null)  {
            encoder.encodeStartElement("conductGlobal", "", "");
            this.conductGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // injured
         if (this.injured != null)  {
            encoder.encodeStartElement("injured", "", "");
            this.injured.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // enemyPresence
         if (_set_enemyPresence)  {
            encoder.encodeStartElement("enemyPresence", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.enemyPresence, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // unexpectedAreaJump
         if (_set_unexpectedAreaJump)  {
            encoder.encodeStartElement("unexpectedAreaJump", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.unexpectedAreaJump, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // reverseAxisJump
         if (_set_reverseAxisJump)  {
            encoder.encodeStartElement("reverseAxisJump", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.reverseAxisJump, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // recoveryNotBelongingUnit
         if (_set_recoveryNotBelongingUnit)  {
            encoder.encodeStartElement("recoveryNotBelongingUnit", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.recoveryNotBelongingUnit, xbContext);
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

   public class NC1_OPORD_ELEM_2__7_reorganizationOrders : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM_2__7_reorganizationOrders");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","reorganizationOrdersSectionStatus"),
         new XBQualifiedName("","reorganizationOrdersGlobal"),
         new XBQualifiedName("","A_personnelIdentification"),
         new XBQualifiedName("","B_droppedMaterialIdentificationRecovery"),
         new XBQualifiedName("","C_droppedMaterialDestination"),
         new XBQualifiedName("","D_reorganizationSystemOrganization"),
         new XBQualifiedName("","E_conduct"),
         new XBQualifiedName("","F_minimumTimeMaterialPersonnel")
      };
      static NC1_OPORD_ELEM_2__7_reorganizationOrders() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int reorganizationOrdersSectionStatus;
      protected bool _set_reorganizationOrdersSectionStatus = false;
      protected  MixedAnyType reorganizationOrdersGlobal;   //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification a_personnelIdentification;
            //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery b_droppedMaterialIdentificationRecovery;
            //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination c_droppedMaterialDestination;
            //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization d_reorganizationSystemOrganization;
            //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct e_conduct;
            //optional
      protected  MixedAnyType f_minimumTimeMaterialPersonnel;
            //optional

      //attribute methods

      //content methods

      public int ReorganizationOrdersSectionStatus
      {
         get
         {
            if (!_set_reorganizationOrdersSectionStatus)
                throw new XBException("field reorganizationOrdersSectionStatus not set");

            return this.reorganizationOrdersSectionStatus;
         }
         set
         {
            this.reorganizationOrdersSectionStatus = value;
            _set_reorganizationOrdersSectionStatus = true;
         }
      }

      public  MixedAnyType ReorganizationOrdersGlobal
      {
         get
         {
            if (this.reorganizationOrdersGlobal == null)
                throw new XBException("field reorganizationOrdersGlobal not set");

            return this.reorganizationOrdersGlobal;
         }
         set
         {
            this.reorganizationOrdersGlobal = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification A_personnelIdentification
      {
         get
         {
            if (this.a_personnelIdentification == null)
                throw new XBException("field a_personnelIdentification not set");

            return this.a_personnelIdentification;
         }
         set
         {
            this.a_personnelIdentification = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery B_droppedMaterialIdentificationRecovery
      {
         get
         {
            if (this.b_droppedMaterialIdentificationRecovery == null)
                throw new XBException("field b_droppedMaterialIdentificationRecovery not set");

            return this.b_droppedMaterialIdentificationRecovery;
         }
         set
         {
            this.b_droppedMaterialIdentificationRecovery = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination C_droppedMaterialDestination
      {
         get
         {
            if (this.c_droppedMaterialDestination == null)
                throw new XBException("field c_droppedMaterialDestination not set");

            return this.c_droppedMaterialDestination;
         }
         set
         {
            this.c_droppedMaterialDestination = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization D_reorganizationSystemOrganization
      {
         get
         {
            if (this.d_reorganizationSystemOrganization == null)
                throw new XBException("field d_reorganizationSystemOrganization not set");

            return this.d_reorganizationSystemOrganization;
         }
         set
         {
            this.d_reorganizationSystemOrganization = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct E_conduct
      {
         get
         {
            if (this.e_conduct == null)
                throw new XBException("field e_conduct not set");

            return this.e_conduct;
         }
         set
         {
            this.e_conduct = value;
         }
      }

      public  MixedAnyType F_minimumTimeMaterialPersonnel
      {
         get
         {
            if (this.f_minimumTimeMaterialPersonnel == null)
                throw new XBException("field f_minimumTimeMaterialPersonnel not set");

            return this.f_minimumTimeMaterialPersonnel;
         }
         set
         {
            this.f_minimumTimeMaterialPersonnel = value;
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

               // reorganizationOrdersSectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.reorganizationOrdersSectionStatus =  SectionStatusCode.decode(text, xbContext);

                  _set_reorganizationOrdersSectionStatus = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reorganizationOrdersGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.reorganizationOrdersGlobal = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.reorganizationOrdersGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // a_personnelIdentification
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.a_personnelIdentification = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_A_personnelIdentification();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_personnelIdentification.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_droppedMaterialIdentificationRecovery
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.b_droppedMaterialIdentificationRecovery = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_B_droppedMaterialIdentificationRecovery();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_droppedMaterialIdentificationRecovery.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_droppedMaterialDestination
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.c_droppedMaterialDestination = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_C_droppedMaterialDestination();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_droppedMaterialDestination.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_reorganizationSystemOrganization
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.d_reorganizationSystemOrganization = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_D_reorganizationSystemOrganization();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d_reorganizationSystemOrganization.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // e_conduct
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.e_conduct = new  NC1_OPORD_ELEM_2__7_reorganizationOrders_E_conduct();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.e_conduct.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // f_minimumTimeMaterialPersonnel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.f_minimumTimeMaterialPersonnel = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.f_minimumTimeMaterialPersonnel.decode(reader, xbContext, false, false);

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

         // reorganizationOrdersSectionStatus
         if (_set_reorganizationOrdersSectionStatus)  {
            encoder.encodeStartElement("reorganizationOrdersSectionStatus", "", "");
            String text_4;
            text_4 =  SectionStatusCode.encode(this.reorganizationOrdersSectionStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // reorganizationOrdersGlobal
         if (this.reorganizationOrdersGlobal != null)  {
            encoder.encodeStartElement("reorganizationOrdersGlobal", "", "");
            this.reorganizationOrdersGlobal.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // a_personnelIdentification
         if (this.a_personnelIdentification != null)  {
            encoder.encodeStartElement("A_personnelIdentification", "", "");
            this.a_personnelIdentification.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // b_droppedMaterialIdentificationRecovery
         if (this.b_droppedMaterialIdentificationRecovery != null)  {
            encoder.encodeStartElement("B_droppedMaterialIdentificationRecovery", "", "");
            this.b_droppedMaterialIdentificationRecovery.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // c_droppedMaterialDestination
         if (this.c_droppedMaterialDestination != null)  {
            encoder.encodeStartElement("C_droppedMaterialDestination", "", "");
            this.c_droppedMaterialDestination.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // d_reorganizationSystemOrganization
         if (this.d_reorganizationSystemOrganization != null)  {
            encoder.encodeStartElement("D_reorganizationSystemOrganization", "", "");
            this.d_reorganizationSystemOrganization.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // e_conduct
         if (this.e_conduct != null)  {
            encoder.encodeStartElement("E_conduct", "", "");
            this.e_conduct.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // f_minimumTimeMaterialPersonnel
         if (this.f_minimumTimeMaterialPersonnel != null)  {
            encoder.encodeStartElement("F_minimumTimeMaterialPersonnel", "", "");
            this.f_minimumTimeMaterialPersonnel.encode(encoder, xbContext, 
               null, false);
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

   public class AnnexeOpordCode
   {
      static AnnexeOpordCode() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //constructor
      private AnnexeOpordCode() {} 


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

   public class ObstaclesAndWorksType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "obstaclesAndWorksType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","obstacle"),
         new XBQualifiedName("","facility"),
         new XBQualifiedName("","route"),
         new XBQualifiedName("","groundEntity")
      };
      static ObstaclesAndWorksType() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< ObstacleType> obstacle;
         
      protected System.Collections.Generic.IList< FacilityType> facility;
         
      protected System.Collections.Generic.IList< RouteType> route;
      protected System.Collections.Generic.IList< GroundEntityType> groundEntity;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< ObstacleType> Obstacle
      {
         get
         {
            if (this.obstacle == null) {
               this.obstacle = new List< ObstacleType>();
            }
            return this.obstacle;
         }
      }

      public System.Collections.Generic.IList< FacilityType> Facility
      {
         get
         {
            if (this.facility == null) {
               this.facility = new List< FacilityType>();
            }
            return this.facility;
         }
      }

      public System.Collections.Generic.IList< RouteType> Route
      {
         get
         {
            if (this.route == null) {
               this.route = new List< RouteType>();
            }
            return this.route;
         }
      }

      public System.Collections.Generic.IList< GroundEntityType> GroundEntity
      {
         get
         {
            if (this.groundEntity == null) {
               this.groundEntity = new List< GroundEntityType>();
            }
            return this.groundEntity;
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

               // obstacle
               this.obstacle = new List< ObstacleType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   ObstacleType _tmp_obstacle;
                  _tmp_obstacle = new  ObstacleType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_obstacle.decode(reader, xbContext, false, false);
                  this.obstacle.Add(_tmp_obstacle);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // facility
               this.facility = new List< FacilityType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   FacilityType _tmp_facility;
                  _tmp_facility = new  FacilityType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_facility.decode(reader, xbContext, false, false);
                  this.facility.Add(_tmp_facility);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // route
               this.route = new List< RouteType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   RouteType _tmp_route;
                  _tmp_route = new  RouteType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_route.decode(reader, xbContext, false, false);
                  this.route.Add(_tmp_route);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // groundEntity
               this.groundEntity = new List< GroundEntityType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   GroundEntityType _tmp_groundEntity;
                  _tmp_groundEntity = new  GroundEntityType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_groundEntity.decode(reader, xbContext, false, false);
                  this.groundEntity.Add(_tmp_groundEntity);

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

         // obstacle
         if ( this.obstacle != null ){
            foreach ( ObstacleType _tmp_obstacle in this.obstacle){
               encoder.encodeStartElement("obstacle", "", "");
               _tmp_obstacle.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // facility
         if ( this.facility != null ){
            foreach ( FacilityType _tmp_facility in this.facility){
               encoder.encodeStartElement("facility", "", "");
               _tmp_facility.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // route
         if ( this.route != null ){
            foreach ( RouteType _tmp_route in this.route){
               encoder.encodeStartElement("route", "", "");
               _tmp_route.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // groundEntity
         if ( this.groundEntity != null ){
            foreach ( GroundEntityType _tmp_groundEntity in this.groundEntity)
            {
               encoder.encodeStartElement("groundEntity", "", "");
               _tmp_groundEntity.encode(encoder, xbContext, null, false);
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

   public class SignatureType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "SignatureType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","rank"),
         new XBQualifiedName("","datetime")
      };
      static SignatureType() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected int rank;
      protected string datetime;

      //attribute methods

      //content methods

      public string Name
      {
         get { return this.name; }
         set { this.name = value; }
      }

      public int Rank
      {
         get { return this.rank; }
         set { this.rank = value; }
      }

      public string Datetime
      {
         get { return this.datetime; }
         set { this.datetime = value; }
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

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  ShortTextType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "name");

               // rank
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.rank =  L112_10Code.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "rank");

               // datetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.datetime = text;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "datetime");

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

         // name
         encoder.encodeStartElement("name", "", "");
         String text_3;
         text_3 =  ShortTextType.encode(this.name, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // rank
         encoder.encodeStartElement("rank", "", "");
         text_3 =  L112_10Code.encode(this.rank, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // datetime
         encoder.encodeStartElement("datetime", "", "");
         text_3 = this.datetime;
         encoder.encodeChars(text_3);
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

   public class TaskOrganisationMemberType_1_description : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "TaskOrganisationMemberType_1_description");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","description"),
         new XBQualifiedName("","sectionStatus")
      };
      static TaskOrganisationMemberType_1_description() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string description;
      protected bool _set_description = false;
      protected int sectionStatus;

      //attribute methods

      //content methods

      public string Description
      {
         get
         {
            if (!_set_description)
                throw new XBException("field description not set");

            return this.description;
         }
         set
         {
            this.description = value;
            _set_description = true;
         }
      }

      public int SectionStatus
      {
         get { return this.sectionStatus; }
         set { this.sectionStatus = value; }
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

               // description
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.description =  LongTextType.decode(text, xbContext);

                  _set_description = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // sectionStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sectionStatus =  SectionStatusCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sectionStatus");

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

         // description
         if (_set_description)  {
            encoder.encodeStartElement("description", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.description, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // sectionStatus
         encoder.encodeStartElement("sectionStatus", "", "");
         String text_3;
         text_3 =  SectionStatusCode.encode(this.sectionStatus, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
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

   public class TaskOrganisationMemberType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "TaskOrganisationMemberType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","reinforcement"),
         new XBQualifiedName("","unit"),
         new XBQualifiedName("","description")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[2], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, reinforcement, unit, description}
      protected Choice _whichField;
      static TaskOrganisationMemberType_1() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  ReinforcementType reinforcement;
      protected  UnitType unit;
      protected  TaskOrganisationMemberType_1_description description;

      //content methods

      public  ReinforcementType Reinforcement
      {
         get
         {
            if (_whichField != Choice.reinforcement ) 
               throw new XBException("field reinforcement not set");
            return this.reinforcement;
         }
         set
         {
            this.reinforcement = value;
            _whichField = Choice.reinforcement;
         }
      }

      public  UnitType Unit
      {
         get
         {
            if (_whichField != Choice.unit ) 
               throw new XBException("field unit not set");
            return this.unit;
         }
         set
         {
            this.unit = value;
            _whichField = Choice.unit;
         }
      }

      public  TaskOrganisationMemberType_1_description Description
      {
         get
         {
            if (_whichField != Choice.description ) 
               throw new XBException("field description not set");
            return this.description;
         }
         set
         {
            this.description = value;
            _whichField = Choice.description;
         }
      }

      public Choice getWhichField() { return _whichField; }


      /**
       * Decode from stream into this object.
       * PRE: reader is on START_ELEMENT of element to decode.
       * POST: reader is just beyond last node for last elementit validated.
       */
      public virtual void decode(XmlTextReader reader, com.objsys.xbinder.runtime.XBContext xbContext) 
      {

         //decode content
         try  {
            String elemLocalName = null;
            String elemNs = null;
            elemLocalName = reader.LocalName;
            elemNs = reader.NamespaceURI;

            // reinforcement
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.reinforcement = new  ReinforcementType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.reinforcement.decode(reader, xbContext, false, false);
               _whichField = Choice.reinforcement;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // unit
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.unit = new  UnitType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.unit.decode(reader, xbContext, false, false);
               _whichField = Choice.unit;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // description
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               this.description = new  TaskOrganisationMemberType_1_description();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.description.decode(reader, xbContext, false, false);
               _whichField = Choice.description;

               XMLStreamHelper.moveToContentElement(reader);
            }
            else throw new XBException("Unexpected element: "
                + XBQualifiedName.toString(elemNs, elemLocalName) );
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
         if ( _whichField == Choice.None ) 
            throw new XBException("no field set in choice group");

         switch( _whichField )  {

            // reinforcement
            case Choice.reinforcement: {
               if (_whichField != Choice.reinforcement ) 
                  throw new XBException("field reinforcement not set");
               encoder.encodeStartElement("reinforcement", "", "");
               this.reinforcement.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // unit
            case Choice.unit: {
               if (_whichField != Choice.unit ) 
                  throw new XBException("field unit not set");
               encoder.encodeStartElement("unit", "", "");
               this.unit.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // description
            case Choice.description: {
               if (_whichField != Choice.description ) 
                  throw new XBException("field description not set");
               encoder.encodeStartElement("description", "", "");
               this.description.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class TaskOrganisationMemberType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "TaskOrganisationMemberType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {

      };
      static TaskOrganisationMemberType() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  TaskOrganisationMemberType_1 taskOrganisationMemberType_1;
         

      //attribute methods

      //content methods

      public  TaskOrganisationMemberType_1 TaskOrganisationMemberType_1
      {
         get
         {
            if (this.taskOrganisationMemberType_1 == null)
                throw new XBException("field taskOrganisationMemberType_1 not set");

            return this.taskOrganisationMemberType_1;
         }
         set
         {
            this.taskOrganisationMemberType_1 = value;
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

               // taskOrganisationMemberType_1
               if( moreContent_4 && 
                   TaskOrganisationMemberType_1.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.taskOrganisationMemberType_1 = new  TaskOrganisationMemberType_1();
                  this.taskOrganisationMemberType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "taskOrganisationMemberType_1");

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

         // taskOrganisationMemberType_1
         if (this.taskOrganisationMemberType_1 == null)
             throw new XBException("field taskOrganisationMemberType_1 not set");

         this.taskOrganisationMemberType_1.encode(encoder, xbContext);
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

   public class NC1_OPORD_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opord",
          "NC1_OPORD_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","objectsGlobal"),
         new XBQualifiedName("","reference"),
         new XBQualifiedName("","orderCategory"),
         new XBQualifiedName("","taskOrganisation"),
         new XBQualifiedName("","_1_situation"),
         new XBQualifiedName("","_2_mission"),
         new XBQualifiedName("","_3_execution"),
         new XBQualifiedName("","_4_administrativeAndLogisticsServices"),
         new XBQualifiedName("","_5_commandAndTransmissions"),
         new XBQualifiedName("","_6_jumpOrders"),
         new XBQualifiedName("","_7_reorganizationOrders"),
         new XBQualifiedName("","acknowledgement"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","signature"),
         new XBQualifiedName("","appendice")
      };
      static NC1_OPORD_ELEM() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  NC1_OPORD_ELEM_2_objectsGlobal objectsGlobal;
            //optional
      protected System.Collections.Generic.IList<String> reference;
      protected  NC1_OPORD_ELEM_2_orderCategory orderCategory;
      protected  NC1_OPORD_ELEM_2_taskOrganisation taskOrganisation;
            //optional
      protected  NC1_OPORD_ELEM_2__1_situation _1_situation;   //optional
         
      protected  NC1_OPORD_ELEM_2__2_mission _2_mission;
      protected  NC1_OPORD_ELEM_2__3_execution _3_execution;   //optional
         
      protected  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices _4_administrativeAndLogisticsServices;
            //optional
      protected  NC1_OPORD_ELEM_2__5_commandAndTransmissions _5_commandAndTransmissions;
            //optional
      protected  NC1_OPORD_ELEM_2__6_jumpOrders _6_jumpOrders;
            //optional
      protected  NC1_OPORD_ELEM_2__7_reorganizationOrders _7_reorganizationOrders;
            //optional
      protected bool acknowledgement;
      protected bool _set_acknowledgement = false;
      protected  CommentSectionType comment;   //optional
      protected  SignatureType signature_;   //optional
      protected System.Collections.Generic.IList<Int32> appendice;

      //attribute methods

      //content methods

      public  NC1_OPORD_ELEM_2_objectsGlobal ObjectsGlobal
      {
         get
         {
            if (this.objectsGlobal == null)
                throw new XBException("field objectsGlobal not set");

            return this.objectsGlobal;
         }
         set
         {
            this.objectsGlobal = value;
         }
      }

      public System.Collections.Generic.IList<String> Reference
      {
         get
         {
            if (this.reference == null) {
               this.reference = new List<String>();
            }
            return this.reference;
         }
      }

      public  NC1_OPORD_ELEM_2_orderCategory OrderCategory
      {
         get
         {
            if (this.orderCategory == null)
                throw new XBException("field orderCategory not set");

            return this.orderCategory;
         }
         set
         {
            this.orderCategory = value;
         }
      }

      public  NC1_OPORD_ELEM_2_taskOrganisation TaskOrganisation
      {
         get
         {
            if (this.taskOrganisation == null)
                throw new XBException("field taskOrganisation not set");

            return this.taskOrganisation;
         }
         set
         {
            this.taskOrganisation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__1_situation _1_situationProperty
      {
         get
         {
            if (this._1_situation == null)
                throw new XBException("field _1_situation not set");

            return this._1_situation;
         }
         set
         {
            this._1_situation = value;
         }
      }

      public  NC1_OPORD_ELEM_2__2_mission _2_missionProperty
      {
         get
         {
            if (this._2_mission == null)
                throw new XBException("field _2_mission not set");

            return this._2_mission;
         }
         set
         {
            this._2_mission = value;
         }
      }

      public  NC1_OPORD_ELEM_2__3_execution _3_executionProperty
      {
         get
         {
            if (this._3_execution == null)
                throw new XBException("field _3_execution not set");

            return this._3_execution;
         }
         set
         {
            this._3_execution = value;
         }
      }

      public  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices _4_administrativeAndLogisticsServicesProperty
      {
         get
         {
            if (this._4_administrativeAndLogisticsServices == null)
                throw new XBException("field _4_administrativeAndLogisticsServices not set");

            return this._4_administrativeAndLogisticsServices;
         }
         set
         {
            this._4_administrativeAndLogisticsServices = value;
         }
      }

      public  NC1_OPORD_ELEM_2__5_commandAndTransmissions _5_commandAndTransmissionsProperty
      {
         get
         {
            if (this._5_commandAndTransmissions == null)
                throw new XBException("field _5_commandAndTransmissions not set");

            return this._5_commandAndTransmissions;
         }
         set
         {
            this._5_commandAndTransmissions = value;
         }
      }

      public  NC1_OPORD_ELEM_2__6_jumpOrders _6_jumpOrdersProperty
      {
         get
         {
            if (this._6_jumpOrders == null)
                throw new XBException("field _6_jumpOrders not set");

            return this._6_jumpOrders;
         }
         set
         {
            this._6_jumpOrders = value;
         }
      }

      public  NC1_OPORD_ELEM_2__7_reorganizationOrders _7_reorganizationOrdersProperty
      {
         get
         {
            if (this._7_reorganizationOrders == null)
                throw new XBException("field _7_reorganizationOrders not set");

            return this._7_reorganizationOrders;
         }
         set
         {
            this._7_reorganizationOrders = value;
         }
      }

      public bool Acknowledgement
      {
         get
         {
            if (!_set_acknowledgement)
                throw new XBException("field acknowledgement not set");

            return this.acknowledgement;
         }
         set
         {
            this.acknowledgement = value;
            _set_acknowledgement = true;
         }
      }

      public  CommentSectionType Comment
      {
         get
         {
            if (this.comment == null)
                throw new XBException("field comment not set");

            return this.comment;
         }
         set
         {
            this.comment = value;
         }
      }

      public  SignatureType Signature_
      {
         get
         {
            if (this.signature_ == null)
                throw new XBException("field signature_ not set");

            return this.signature_;
         }
         set
         {
            this.signature_ = value;
         }
      }

      public System.Collections.Generic.IList<Int32> Appendice
      {
         get
         {
            if (this.appendice == null) {
               this.appendice = new List<Int32>();
            }
            return this.appendice;
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

               // objectsGlobal
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.objectsGlobal = new  NC1_OPORD_ELEM_2_objectsGlobal();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.objectsGlobal.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // reference
               this.reference = new List<String>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  string _tmp_reference;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  _tmp_reference =  MediumTextType.decode(text, xbContext);
                  this.reference.Add(_tmp_reference);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // orderCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.orderCategory = new  NC1_OPORD_ELEM_2_orderCategory();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.orderCategory.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "orderCategory");

               // taskOrganisation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.taskOrganisation = new  NC1_OPORD_ELEM_2_taskOrganisation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.taskOrganisation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _1_situation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this._1_situation = new  NC1_OPORD_ELEM_2__1_situation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._1_situation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _2_mission
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this._2_mission = new  NC1_OPORD_ELEM_2__2_mission();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._2_mission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "_2_mission");

               // _3_execution
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this._3_execution = new  NC1_OPORD_ELEM_2__3_execution();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._3_execution.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _4_administrativeAndLogisticsServices
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this._4_administrativeAndLogisticsServices = new  NC1_OPORD_ELEM_2__4_administrativeAndLogisticsServices();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._4_administrativeAndLogisticsServices.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _5_commandAndTransmissions
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this._5_commandAndTransmissions = new  NC1_OPORD_ELEM_2__5_commandAndTransmissions();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._5_commandAndTransmissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _6_jumpOrders
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  this._6_jumpOrders = new  NC1_OPORD_ELEM_2__6_jumpOrders();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._6_jumpOrders.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _7_reorganizationOrders
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  this._7_reorganizationOrders = new  NC1_OPORD_ELEM_2__7_reorganizationOrders();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._7_reorganizationOrders.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // acknowledgement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[11], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.acknowledgement = XBSimpleType.parseBoolean(text);

                  _set_acknowledgement = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[12], elemNs, elemLocalName) )
               {
                  this.comment = new  CommentSectionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.comment.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // signature_
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[13], elemNs, elemLocalName) )
               {
                  this.signature_ = new  SignatureType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.signature_.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // appendice
               this.appendice = new List<Int32>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[14], elemNs, elemLocalName) )
               {
                  int _tmp_appendice;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  _tmp_appendice =  AnnexeOpordCode.decode(text, xbContext);
                  this.appendice.Add(_tmp_appendice);

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
      protected override void encodeContent(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         base.encodeContent(encoder, xbContext);

         // objectsGlobal
         if (this.objectsGlobal != null)  {
            encoder.encodeStartElement("objectsGlobal", "", "");
            this.objectsGlobal.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // reference
         if ( this.reference != null ){
            foreach (string _tmp_reference in this.reference){
               encoder.encodeStartElement("reference", "", "");
               String text_5;
               text_5 =  MediumTextType.encode(_tmp_reference, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
            }
         }

         // orderCategory
         if (this.orderCategory == null)
             throw new XBException("field orderCategory not set");

         encoder.encodeStartElement("orderCategory", "", "");
         this.orderCategory.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // taskOrganisation
         if (this.taskOrganisation != null)  {
            encoder.encodeStartElement("taskOrganisation", "", "");
            this.taskOrganisation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _1_situation
         if (this._1_situation != null)  {
            encoder.encodeStartElement("_1_situation", "", "");
            this._1_situation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _2_mission
         if (this._2_mission == null)
             throw new XBException("field _2_mission not set");

         encoder.encodeStartElement("_2_mission", "", "");
         this._2_mission.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // _3_execution
         if (this._3_execution != null)  {
            encoder.encodeStartElement("_3_execution", "", "");
            this._3_execution.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _4_administrativeAndLogisticsServices
         if (this._4_administrativeAndLogisticsServices != null)  {
            encoder.encodeStartElement("_4_administrativeAndLogisticsServices", "", "");
            this._4_administrativeAndLogisticsServices.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // _5_commandAndTransmissions
         if (this._5_commandAndTransmissions != null)  {
            encoder.encodeStartElement("_5_commandAndTransmissions", "", "");
            this._5_commandAndTransmissions.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // _6_jumpOrders
         if (this._6_jumpOrders != null)  {
            encoder.encodeStartElement("_6_jumpOrders", "", "");
            this._6_jumpOrders.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _7_reorganizationOrders
         if (this._7_reorganizationOrders != null)  {
            encoder.encodeStartElement("_7_reorganizationOrders", "", "");
            this._7_reorganizationOrders.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // acknowledgement
         if (_set_acknowledgement)  {
            encoder.encodeStartElement("acknowledgement", "", "");
            String text_4;
            text_4 = this.acknowledgement.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // comment
         if (this.comment != null)  {
            encoder.encodeStartElement("comment", "", "");
            this.comment.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // signature_
         if (this.signature_ != null)  {
            encoder.encodeStartElement("signature", "", "");
            this.signature_.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // appendice
         if ( this.appendice != null ){
            foreach (int _tmp_appendice in this.appendice){
               encoder.encodeStartElement("appendice", "", "");
               String text_5;
               text_5 =  AnnexeOpordCode.encode(_tmp_appendice, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
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

   public class NC1_OPORD_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:opord","NC1_OPORD")
      };
      static NC1_OPORD_CC() {
         XBUtil.license =  _NC1_OPORD.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_OPORD_ELEM nC1_OPORD;

      //content methods

      public  NC1_OPORD_ELEM NC1_OPORD
      {
         get
         {
            if (this.nC1_OPORD == null)
                throw new XBException("field nC1_OPORD not set");

            return this.nC1_OPORD;
         }
         set
         {
            this.nC1_OPORD = value;
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
         //   encoder.setNamespaces(_NC1_OPORD.namespaceContext);

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

            // nC1_OPORD
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_OPORD = new  NC1_OPORD_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_OPORD.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_OPORD");

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

         // nC1_OPORD
         if (this.nC1_OPORD == null)
             throw new XBException("field nC1_OPORD not set");

         encoder.encodeStartElement("NC1_OPORD",  _NC1_OPORD.NS_URI,  _NC1_OPORD.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_OPORD.encode(encoder, xbContext, null, false);
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

   public class _NC1_OPORD {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:opord";
      public static readonly String NS_PREFIX = "nc1opord";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_OPORD() {
      }
      static _NC1_OPORD() {
         XBUtil.license = _NC1_OPORD.license;
      }
   }
}
