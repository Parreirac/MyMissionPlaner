using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace  NC1.Cbrn {
    using NC1;
    using PointType = NC1.Location.PointType;
    using System.IO;
   using System.Xml;
    using CbrnEventType = NC1.Obj.cbrnevent.CbrnEventType;

   public class AirStabilityCategoryCode
   {
      static AirStabilityCategoryCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private AirStabilityCategoryCode() {} 


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

   public class AlfaType_2
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "AlfaType_2");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","unitIdentification")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, unitId, unitIdentification}
      protected Choice _whichField;
      static AlfaType_2() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string unitIdentification;

      //content methods

      public  Nc1ObjectRefType UnitId
      {
         get
         {
            if (_whichField != Choice.unitId ) 
               throw new XBException("field unitId not set");
            return this.unitId;
         }
         set
         {
            this.unitId = value;
            _whichField = Choice.unitId;
         }
      }

      public string UnitIdentification
      {
         get
         {
            if (_whichField != Choice.unitIdentification ) 
               throw new XBException("field unitIdentification not set");
            return this.unitIdentification;
         }
         set
         {
            this.unitIdentification = value;
            _whichField = Choice.unitIdentification;
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

            // unitId
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.unitId = new  Nc1ObjectRefType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.unitId.decode(reader, xbContext, false, false);
               _whichField = Choice.unitId;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // unitIdentification
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               this.unitIdentification =  Text1To9ABNSType.decode(text, xbContext);
               _whichField = Choice.unitIdentification;

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

            // unitId
            case Choice.unitId: {
               if (_whichField != Choice.unitId ) 
                  throw new XBException("field unitId not set");
               encoder.encodeStartElement("unitId", "", "");
               this.unitId.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // unitIdentification
            case Choice.unitIdentification: {
               if (_whichField != Choice.unitIdentification ) 
                  throw new XBException("field unitIdentification not set");
               encoder.encodeStartElement("unitIdentification", "", "");
               String text_5;
               text_5 =  Text1To9ABNSType.encode(this.unitIdentification, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class IncidentTypeCode
   {
      static IncidentTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private IncidentTypeCode() {} 


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

   public class AlfaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "AlfaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","locationCode"),
         new XBQualifiedName("","sequenceNumber"),
         new XBQualifiedName("","incidentType")
      };
      static AlfaType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string locationCode;
      protected  AlfaType_2 alfaType_2;
      protected string sequenceNumber;
      protected int incidentType;

      //attribute methods

      //content methods

      public string LocationCode
      {
         get { return this.locationCode; }
         set { this.locationCode = value; }
      }

      public  AlfaType_2 AlfaType_2
      {
         get
         {
            if (this.alfaType_2 == null)
                throw new XBException("field alfaType_2 not set");

            return this.alfaType_2;
         }
         set
         {
            this.alfaType_2 = value;
         }
      }

      public string SequenceNumber
      {
         get { return this.sequenceNumber; }
         set { this.sequenceNumber = value; }
      }

      public int IncidentType
      {
         get { return this.incidentType; }
         set { this.incidentType = value; }
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

               // locationCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.locationCode =  Text2To3ANType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "locationCode");

               // alfaType_2
               if( moreContent_4 && 
                   AlfaType_2.acceptsElem(elemNs, elemLocalName) )
               {
                  this.alfaType_2 = new  AlfaType_2();
                  this.alfaType_2.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "alfaType_2");

               // sequenceNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.sequenceNumber =  Text1To10ABNSType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sequenceNumber");

               // incidentType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.incidentType =  IncidentTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "incidentType");

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

         // locationCode
         encoder.encodeStartElement("locationCode", "", "");
         String text_3;
         text_3 =  Text2To3ANType.encode(this.locationCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // alfaType_2
         if (this.alfaType_2 == null)
             throw new XBException("field alfaType_2 not set");

         this.alfaType_2.encode(encoder, xbContext);

         // sequenceNumber
         encoder.encodeStartElement("sequenceNumber", "", "");
         text_3 =  Text1To10ABNSType.encode(this.sequenceNumber, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // incidentType
         encoder.encodeStartElement("incidentType", "", "");
         text_3 =  IncidentTypeCode.encode(this.incidentType, xbContext);
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

   public class AreamType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "AreamType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","validityAreaName")
      };
      static AreamType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string validityAreaName;

      //attribute methods

      //content methods

      public string ValidityAreaName
      {
         get { return this.validityAreaName; }
         set { this.validityAreaName = value; }
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

               // validityAreaName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.validityAreaName =  Text1To30ABNSType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "validityAreaName");

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

         // validityAreaName
         encoder.encodeStartElement("validityAreaName", "", "");
         String text_3;
         text_3 =  Text1To30ABNSType.encode(this.validityAreaName, xbContext);
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

   public class BravoType_location : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "BravoType_location");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","point"),
         new XBQualifiedName("","placeName")
      };

      public enum Choice  {
         None, point, placeName}
      protected Choice _whichField;
      static BravoType_location() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PointType point;
      protected string placeName;

      //attribute methods

      //content methods

      public  PointType Point
      {
         get
         {
            if (_whichField != Choice.point ) 
               throw new XBException("field point not set");
            return this.point;
         }
         set
         {
            this.point = value;
            _whichField = Choice.point;
         }
      }

      public string PlaceName
      {
         get
         {
            if (_whichField != Choice.placeName ) 
               throw new XBException("field placeName not set");
            return this.placeName;
         }
         set
         {
            this.placeName = value;
            _whichField = Choice.placeName;
         }
      }

      public Choice getWhichField() { return _whichField; }

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

               // point
               if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.point = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.point.decode(reader, xbContext, false, false);
                  _whichField = Choice.point;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // placeName
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.placeName =  Text1To30ABNSType.decode(text, xbContext);
                  _whichField = Choice.placeName;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else throw new XBException("Unexpected element: "
                   + XBQualifiedName.toString(elemNs, elemLocalName) );

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

         if ( _whichField == Choice.None ) 
            throw new XBException("no field set in choice group");

         switch( _whichField )  {

            // point
            case Choice.point: {
               if (_whichField != Choice.point ) 
                  throw new XBException("field point not set");
               encoder.encodeStartElement("point", "", "");
               this.point.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // placeName
            case Choice.placeName: {
               if (_whichField != Choice.placeName ) 
                  throw new XBException("field placeName not set");
               encoder.encodeStartElement("placeName", "", "");
               String text_5;
               text_5 =  Text1To30ABNSType.encode(this.placeName, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
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

   public class BravoType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "BravoType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","location"),
         new XBQualifiedName("","direction")
      };
      static BravoType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  BravoType_location location;
      protected double direction;

      //attribute methods

      //content methods

      public  BravoType_location Location
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

      public double Direction
      {
         get { return this.direction; }
         set { this.direction = value; }
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
                  this.location = new  BravoType_location();
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

               // direction
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.direction =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "direction");

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

         // direction
         encoder.encodeStartElement("direction", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.direction, xbContext);
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

   public class CloudCoverageCode
   {
      static CloudCoverageCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private CloudCoverageCode() {} 


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

   public class ContainerTypeCode
   {
      static ContainerTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private ContainerTypeCode() {} 


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

   public class DeliverySystemTypeCode
   {
      static DeliverySystemTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private DeliverySystemTypeCode() {} 


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

   public class DeltaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "DeltaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","startDatetime"),
         new XBQualifiedName("","endDatetime")
      };
      static DeltaType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string startDatetime;
      protected string endDatetime;
      protected bool _set_endDatetime = false;

      //attribute methods

      //content methods

      public string StartDatetime
      {
         get { return this.startDatetime; }
         set { this.startDatetime = value; }
      }

      public string EndDatetime
      {
         get
         {
            if (!_set_endDatetime)
                throw new XBException("field endDatetime not set");

            return this.endDatetime;
         }
         set
         {
            this.endDatetime = value;
            _set_endDatetime = true;
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

               // startDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
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

               // endDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.endDatetime = text;

                  _set_endDatetime = true;

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

         // startDatetime
         encoder.encodeStartElement("startDatetime", "", "");
         String text_3;
         text_3 = this.startDatetime;
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // endDatetime
         if (_set_endDatetime)  {
            encoder.encodeStartElement("endDatetime", "", "");
            text_3 = this.endDatetime;
            encoder.encodeChars(text_3);
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

   public class DetectionConfidenceLevelCode
   {
      static DetectionConfidenceLevelCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private DetectionConfidenceLevelCode() {} 


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

   public class DetectionMeanTypeCode
   {
      static DetectionMeanTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private DetectionMeanTypeCode() {} 


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

   public class DetectionTypeCode
   {
      static DetectionTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private DetectionTypeCode() {} 


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

   public class FoxtrotType_incidentLocation_location : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "FoxtrotType_incidentLocation_location");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","point"),
         new XBQualifiedName("","placeName")
      };

      public enum Choice  {
         None, point, placeName}
      protected Choice _whichField;
      static FoxtrotType_incidentLocation_location() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PointType point;
      protected string placeName;

      //attribute methods

      //content methods

      public  PointType Point
      {
         get
         {
            if (_whichField != Choice.point ) 
               throw new XBException("field point not set");
            return this.point;
         }
         set
         {
            this.point = value;
            _whichField = Choice.point;
         }
      }

      public string PlaceName
      {
         get
         {
            if (_whichField != Choice.placeName ) 
               throw new XBException("field placeName not set");
            return this.placeName;
         }
         set
         {
            this.placeName = value;
            _whichField = Choice.placeName;
         }
      }

      public Choice getWhichField() { return _whichField; }

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

               // point
               if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.point = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.point.decode(reader, xbContext, false, false);
                  _whichField = Choice.point;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // placeName
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.placeName =  Text1To54ABNSType.decode(text, xbContext);
                  _whichField = Choice.placeName;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else throw new XBException("Unexpected element: "
                   + XBQualifiedName.toString(elemNs, elemLocalName) );

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

         if ( _whichField == Choice.None ) 
            throw new XBException("no field set in choice group");

         switch( _whichField )  {

            // point
            case Choice.point: {
               if (_whichField != Choice.point ) 
                  throw new XBException("field point not set");
               encoder.encodeStartElement("point", "", "");
               this.point.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // placeName
            case Choice.placeName: {
               if (_whichField != Choice.placeName ) 
                  throw new XBException("field placeName not set");
               encoder.encodeStartElement("placeName", "", "");
               String text_5;
               text_5 =  Text1To54ABNSType.encode(this.placeName, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
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

   public class LocationQualifierCode
   {
      static LocationQualifierCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private LocationQualifierCode() {} 


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

   public class FoxtrotType_incidentLocation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "FoxtrotType_incidentLocation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","location"),
         new XBQualifiedName("","locationQualifier")
      };
      static FoxtrotType_incidentLocation() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  FoxtrotType_incidentLocation_location location;
      protected int locationQualifier;

      //attribute methods

      //content methods

      public  FoxtrotType_incidentLocation_location Location
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

      public int LocationQualifier
      {
         get { return this.locationQualifier; }
         set { this.locationQualifier = value; }
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
                  this.location = new  FoxtrotType_incidentLocation_location();
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

               // locationQualifier
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.locationQualifier =  LocationQualifierCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "locationQualifier");

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

         // locationQualifier
         encoder.encodeStartElement("locationQualifier", "", "");
         String text_3;
         text_3 =  LocationQualifierCode.encode(this.locationQualifier, xbContext);
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

   public class FoxtrotType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "FoxtrotType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","incidentLocation")
      };
      static FoxtrotType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  FoxtrotType_incidentLocation[] incidentLocation;
      protected int _length_incidentLocation = 0;

      //attribute methods

      //content methods

      public  FoxtrotType_incidentLocation[] IncidentLocation
      {
         get
         {
            if (this.incidentLocation == null)
                throw new XBException("field incidentLocation not set");

             FoxtrotType_incidentLocation[] 
               arrCopy = new  FoxtrotType_incidentLocation[_length_incidentLocation];
            Array.Copy(this.incidentLocation, arrCopy, _length_incidentLocation);
            return arrCopy;
         }
         set
         {
            this.incidentLocation = value;
            this.incidentLocation = new  FoxtrotType_incidentLocation[value.Length];
            value.CopyTo(this.incidentLocation, 0);
            _length_incidentLocation = value.Length;
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

               // incidentLocation
               this.incidentLocation = new  FoxtrotType_incidentLocation[6];
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.incidentLocation[_length_incidentLocation] = new  FoxtrotType_incidentLocation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.incidentLocation[_length_incidentLocation].decode(reader, xbContext, false, false);
                  _length_incidentLocation++;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4 && _length_incidentLocation < 6) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( _length_incidentLocation < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(_length_incidentLocation, "incidentLocation");
               else if (_length_incidentLocation == 0 && moreContent_4) 
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

         // incidentLocation
         if (this.incidentLocation == null || _length_incidentLocation < 1 || 
            6 < _length_incidentLocation) 
            throw new XBOccurrencesException( (this.incidentLocation == null ? 0 : _length_incidentLocation ) );

         for (int i = 0; i < _length_incidentLocation; i++) {
            encoder.encodeStartElement("incidentLocation", "", "");
            this.incidentLocation[i].encode(encoder, xbContext, null, false);
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

   public class GenericAlarmResultCode
   {
      static GenericAlarmResultCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private GenericAlarmResultCode() {} 


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

   public class SizeOfReleaseCode
   {
      static SizeOfReleaseCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SizeOfReleaseCode() {} 


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

   public class GolfType_5
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "GolfType_5");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","substanceContainerCount"),
         new XBQualifiedName("","totalReleaseQuantity"),
         new XBQualifiedName("","sizeOfRelease")
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
         None, substanceContainerCount, totalReleaseQuantity, sizeOfRelease}
      protected Choice _whichField;
      static GolfType_5() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected ushort substanceContainerCount;
      protected uint totalReleaseQuantity;
      protected int sizeOfRelease;

      //content methods

      public ushort SubstanceContainerCount
      {
         get
         {
            if (_whichField != Choice.substanceContainerCount ) 
               throw new XBException("field substanceContainerCount not set");
            return this.substanceContainerCount;
         }
         set
         {
            this.substanceContainerCount = value;
            _whichField = Choice.substanceContainerCount;
         }
      }

      public uint TotalReleaseQuantity
      {
         get
         {
            if (_whichField != Choice.totalReleaseQuantity ) 
               throw new XBException("field totalReleaseQuantity not set");
            return this.totalReleaseQuantity;
         }
         set
         {
            this.totalReleaseQuantity = value;
            _whichField = Choice.totalReleaseQuantity;
         }
      }

      public int SizeOfRelease
      {
         get
         {
            if (_whichField != Choice.sizeOfRelease ) 
               throw new XBException("field sizeOfRelease not set");
            return this.sizeOfRelease;
         }
         set
         {
            this.sizeOfRelease = value;
            _whichField = Choice.sizeOfRelease;
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

            // substanceContainerCount
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceContainerCount =  Int1To999Type.decode(text, xbContext);
               _whichField = Choice.substanceContainerCount;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // totalReleaseQuantity
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.totalReleaseQuantity =  Int1To999999Type.decode(text, xbContext);
               _whichField = Choice.totalReleaseQuantity;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // sizeOfRelease
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.sizeOfRelease =  SizeOfReleaseCode.decode(text, xbContext);
               _whichField = Choice.sizeOfRelease;

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

            // substanceContainerCount
            case Choice.substanceContainerCount: {
               if (_whichField != Choice.substanceContainerCount ) 
                  throw new XBException("field substanceContainerCount not set");
               encoder.encodeStartElement("substanceContainerCount", "", "");
               String text_5;
               text_5 =  Int1To999Type.encode(this.substanceContainerCount, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // totalReleaseQuantity
            case Choice.totalReleaseQuantity: {
               if (_whichField != Choice.totalReleaseQuantity ) 
                  throw new XBException("field totalReleaseQuantity not set");
               encoder.encodeStartElement("totalReleaseQuantity", "", "");
               String text_5;
               text_5 =  Int1To999999Type.encode(this.totalReleaseQuantity, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // sizeOfRelease
            case Choice.sizeOfRelease: {
               if (_whichField != Choice.sizeOfRelease ) 
                  throw new XBException("field sizeOfRelease not set");
               encoder.encodeStartElement("sizeOfRelease", "", "");
               String text_5;
               text_5 =  SizeOfReleaseCode.encode(this.sizeOfRelease, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class IncidentQualificationCode
   {
      static IncidentQualificationCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private IncidentQualificationCode() {} 


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

   public class GolfType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "GolfType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","incidentQualification"),
         new XBQualifiedName("","deliverySystem"),
         new XBQualifiedName("","deliverySystemsCount"),
         new XBQualifiedName("","substanceContainerType")
      };
      static GolfType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int incidentQualification;
      protected int deliverySystem;
      protected ushort deliverySystemsCount;
      protected int substanceContainerType;
      protected  GolfType_5 golfType_5;

      //attribute methods

      //content methods

      public int IncidentQualification
      {
         get { return this.incidentQualification; }
         set { this.incidentQualification = value; }
      }

      public int DeliverySystem
      {
         get { return this.deliverySystem; }
         set { this.deliverySystem = value; }
      }

      public ushort DeliverySystemsCount
      {
         get { return this.deliverySystemsCount; }
         set { this.deliverySystemsCount = value; }
      }

      public int SubstanceContainerType
      {
         get { return this.substanceContainerType; }
         set { this.substanceContainerType = value; }
      }

      public  GolfType_5 GolfType_5
      {
         get
         {
            if (this.golfType_5 == null)
                throw new XBException("field golfType_5 not set");

            return this.golfType_5;
         }
         set
         {
            this.golfType_5 = value;
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

               // incidentQualification
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.incidentQualification =  IncidentQualificationCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "incidentQualification");

               // deliverySystem
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.deliverySystem =  DeliverySystemTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "deliverySystem");

               // deliverySystemsCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.deliverySystemsCount =  Int1To999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "deliverySystemsCount");

               // substanceContainerType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.substanceContainerType =  ContainerTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "substanceContainerType");

               // golfType_5
               if( moreContent_4 && 
                   GolfType_5.acceptsElem(elemNs, elemLocalName) )
               {
                  this.golfType_5 = new  GolfType_5();
                  this.golfType_5.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "golfType_5");

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

         // incidentQualification
         encoder.encodeStartElement("incidentQualification", "", "");
         String text_3;
         text_3 =  IncidentQualificationCode.encode(this.incidentQualification, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // deliverySystem
         encoder.encodeStartElement("deliverySystem", "", "");
         text_3 =  DeliverySystemTypeCode.encode(this.deliverySystem, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // deliverySystemsCount
         encoder.encodeStartElement("deliverySystemsCount", "", "");
         text_3 =  Int1To999Type.encode(this.deliverySystemsCount, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // substanceContainerType
         encoder.encodeStartElement("substanceContainerType", "", "");
         text_3 =  ContainerTypeCode.encode(this.substanceContainerType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // golfType_5
         if (this.golfType_5 == null)
             throw new XBException("field golfType_5 not set");

         this.golfType_5.encode(encoder, xbContext);
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

   public class HazardTypeCode
   {
      static HazardTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private HazardTypeCode() {} 


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

   public class HazardLevelType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "HazardLevelType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","hazardType"),
         new XBQualifiedName("","probability")
      };
      static HazardLevelType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int hazardType;
      protected double probability;

      //attribute methods

      //content methods

      public int HazardType
      {
         get { return this.hazardType; }
         set { this.hazardType = value; }
      }

      public double Probability
      {
         get { return this.probability; }
         set { this.probability = value; }
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

               // hazardType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.hazardType =  HazardTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "hazardType");

               // probability
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.probability =  RatioType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "probability");

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

         // hazardType
         encoder.encodeStartElement("hazardType", "", "");
         String text_3;
         text_3 =  HazardTypeCode.encode(this.hazardType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // probability
         encoder.encodeStartElement("probability", "", "");
         text_3 =  RatioType.encode(this.probability, xbContext);
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

   public class IncidentDescriptionCode
   {
      static IncidentDescriptionCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private IncidentDescriptionCode() {} 


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

   public class IncidentStatusCode
   {
      static IncidentStatusCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private IncidentStatusCode() {} 


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

   public class IndiabType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiabType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","releaseHeightProbability"),
         new XBQualifiedName("","minReleaseHeight"),
         new XBQualifiedName("","maxReleaseHeight"),
         new XBQualifiedName("","releaseHeightAccuracy")
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
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[3], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, releaseHeightProbability, minReleaseHeight, maxReleaseHeight, 
            releaseHeightAccuracy}
      protected Choice _whichField;
      static IndiabType_1() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double releaseHeightProbability;
      protected uint minReleaseHeight;
      protected uint maxReleaseHeight;
      protected uint releaseHeightAccuracy;

      //content methods

      public double ReleaseHeightProbability
      {
         get
         {
            if (_whichField != Choice.releaseHeightProbability ) 
               throw new XBException("field releaseHeightProbability not set");
            return this.releaseHeightProbability;
         }
         set
         {
            this.releaseHeightProbability = value;
            _whichField = Choice.releaseHeightProbability;
         }
      }

      public uint MinReleaseHeight
      {
         get
         {
            if (_whichField != Choice.minReleaseHeight ) 
               throw new XBException("field minReleaseHeight not set");
            return this.minReleaseHeight;
         }
         set
         {
            this.minReleaseHeight = value;
            _whichField = Choice.minReleaseHeight;
         }
      }

      public uint MaxReleaseHeight
      {
         get
         {
            if (_whichField != Choice.maxReleaseHeight ) 
               throw new XBException("field maxReleaseHeight not set");
            return this.maxReleaseHeight;
         }
         set
         {
            this.maxReleaseHeight = value;
            _whichField = Choice.maxReleaseHeight;
         }
      }

      public uint ReleaseHeightAccuracy
      {
         get
         {
            if (_whichField != Choice.releaseHeightAccuracy ) 
               throw new XBException("field releaseHeightAccuracy not set");
            return this.releaseHeightAccuracy;
         }
         set
         {
            this.releaseHeightAccuracy = value;
            _whichField = Choice.releaseHeightAccuracy;
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

            // releaseHeightProbability
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseHeightProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.releaseHeightProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // minReleaseHeight
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.minReleaseHeight =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.minReleaseHeight;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // maxReleaseHeight
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.maxReleaseHeight =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.maxReleaseHeight;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // releaseHeightAccuracy
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseHeightAccuracy =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.releaseHeightAccuracy;

               XMLStreamHelper.moveToContentElement(reader);
            }
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
         if ( _whichField != Choice.None ) 
         switch( _whichField )  {

            // releaseHeightProbability
            case Choice.releaseHeightProbability: {
               encoder.encodeStartElement("releaseHeightProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.releaseHeightProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // minReleaseHeight
            case Choice.minReleaseHeight: {
               encoder.encodeStartElement("minReleaseHeight", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.minReleaseHeight, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // maxReleaseHeight
            case Choice.maxReleaseHeight: {
               encoder.encodeStartElement("maxReleaseHeight", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.maxReleaseHeight, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // releaseHeightAccuracy
            case Choice.releaseHeightAccuracy: {
               encoder.encodeStartElement("releaseHeightAccuracy", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.releaseHeightAccuracy, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class IndiabType_6
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiabType_6");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","substanceTypeProbability"),
         new XBQualifiedName("","substanceNameProbability")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, substanceTypeProbability, substanceNameProbability}
      protected Choice _whichField;
      static IndiabType_6() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double substanceTypeProbability;
      protected double substanceNameProbability;

      //content methods

      public double SubstanceTypeProbability
      {
         get
         {
            if (_whichField != Choice.substanceTypeProbability ) 
               throw new XBException("field substanceTypeProbability not set");
            return this.substanceTypeProbability;
         }
         set
         {
            this.substanceTypeProbability = value;
            _whichField = Choice.substanceTypeProbability;
         }
      }

      public double SubstanceNameProbability
      {
         get
         {
            if (_whichField != Choice.substanceNameProbability ) 
               throw new XBException("field substanceNameProbability not set");
            return this.substanceNameProbability;
         }
         set
         {
            this.substanceNameProbability = value;
            _whichField = Choice.substanceNameProbability;
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

            // substanceTypeProbability
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceTypeProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.substanceTypeProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // substanceNameProbability
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceNameProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.substanceNameProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }
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
         if ( _whichField != Choice.None ) 
         switch( _whichField )  {

            // substanceTypeProbability
            case Choice.substanceTypeProbability: {
               encoder.encodeStartElement("substanceTypeProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.substanceTypeProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // substanceNameProbability
            case Choice.substanceNameProbability: {
               encoder.encodeStartElement("substanceNameProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.substanceNameProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class SampleIdentificationConfidenceLevelCode
   {
      static SampleIdentificationConfidenceLevelCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SampleIdentificationConfidenceLevelCode() {} 


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

   public class IndiabType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiabType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","persistencyProbability"),
         new XBQualifiedName("","sampleIdentificationConfidenceLevel")
      };
      static IndiabType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  IndiabType_1 indiabType_1;   //optional
      protected  IndiabType_6 indiabType_6;   //optional
      protected double persistencyProbability;
      protected bool _set_persistencyProbability = false;
      protected int sampleIdentificationConfidenceLevel;
      protected bool _set_sampleIdentificationConfidenceLevel = false;

      //attribute methods

      //content methods

      public  IndiabType_1 IndiabType_1
      {
         get
         {
            if (this.indiabType_1 == null)
                throw new XBException("field indiabType_1 not set");

            return this.indiabType_1;
         }
         set
         {
            this.indiabType_1 = value;
         }
      }

      public  IndiabType_6 IndiabType_6
      {
         get
         {
            if (this.indiabType_6 == null)
                throw new XBException("field indiabType_6 not set");

            return this.indiabType_6;
         }
         set
         {
            this.indiabType_6 = value;
         }
      }

      public double PersistencyProbability
      {
         get
         {
            if (!_set_persistencyProbability)
                throw new XBException("field persistencyProbability not set");

            return this.persistencyProbability;
         }
         set
         {
            this.persistencyProbability = value;
            _set_persistencyProbability = true;
         }
      }

      public int SampleIdentificationConfidenceLevel
      {
         get
         {
            if (!_set_sampleIdentificationConfidenceLevel)
                throw new XBException("field sampleIdentificationConfidenceLevel not set");

            return this.sampleIdentificationConfidenceLevel;
         }
         set
         {
            this.sampleIdentificationConfidenceLevel = value;
            _set_sampleIdentificationConfidenceLevel = true;
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

               // indiabType_1
               if( moreContent_4 && 
                   IndiabType_1.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiabType_1 = new  IndiabType_1();
                  this.indiabType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // indiabType_6
               if( moreContent_4 && 
                   IndiabType_6.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiabType_6 = new  IndiabType_6();
                  this.indiabType_6.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // persistencyProbability
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.persistencyProbability =  RatioType.decode(text, xbContext);

                  _set_persistencyProbability = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // sampleIdentificationConfidenceLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sampleIdentificationConfidenceLevel =  SampleIdentificationConfidenceLevelCode.decode(text, xbContext);

                  _set_sampleIdentificationConfidenceLevel = true;

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

         // indiabType_1
         if (this.indiabType_1 != null)  {
            this.indiabType_1.encode(encoder, xbContext);
         }

         // indiabType_6
         if (this.indiabType_6 != null)  {
            this.indiabType_6.encode(encoder, xbContext);
         }

         // persistencyProbability
         if (_set_persistencyProbability)  {
            encoder.encodeStartElement("persistencyProbability", "", "");
            String text_4;
            text_4 =  RatioType.encode(this.persistencyProbability, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // sampleIdentificationConfidenceLevel
         if (_set_sampleIdentificationConfidenceLevel)  {
            encoder.encodeStartElement("sampleIdentificationConfidenceLevel", "", "");
            String text_4;
            text_4 =  SampleIdentificationConfidenceLevelCode.encode(this.sampleIdentificationConfidenceLevel, xbContext);
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

   public class IndiacType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiacType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","releaseHeightProbability"),
         new XBQualifiedName("","minReleaseHeight"),
         new XBQualifiedName("","maxReleaseHeight"),
         new XBQualifiedName("","releaseHeightAccuracy")
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
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[3], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, releaseHeightProbability, minReleaseHeight, maxReleaseHeight, 
            releaseHeightAccuracy}
      protected Choice _whichField;
      static IndiacType_1() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double releaseHeightProbability;
      protected uint minReleaseHeight;
      protected uint maxReleaseHeight;
      protected uint releaseHeightAccuracy;

      //content methods

      public double ReleaseHeightProbability
      {
         get
         {
            if (_whichField != Choice.releaseHeightProbability ) 
               throw new XBException("field releaseHeightProbability not set");
            return this.releaseHeightProbability;
         }
         set
         {
            this.releaseHeightProbability = value;
            _whichField = Choice.releaseHeightProbability;
         }
      }

      public uint MinReleaseHeight
      {
         get
         {
            if (_whichField != Choice.minReleaseHeight ) 
               throw new XBException("field minReleaseHeight not set");
            return this.minReleaseHeight;
         }
         set
         {
            this.minReleaseHeight = value;
            _whichField = Choice.minReleaseHeight;
         }
      }

      public uint MaxReleaseHeight
      {
         get
         {
            if (_whichField != Choice.maxReleaseHeight ) 
               throw new XBException("field maxReleaseHeight not set");
            return this.maxReleaseHeight;
         }
         set
         {
            this.maxReleaseHeight = value;
            _whichField = Choice.maxReleaseHeight;
         }
      }

      public uint ReleaseHeightAccuracy
      {
         get
         {
            if (_whichField != Choice.releaseHeightAccuracy ) 
               throw new XBException("field releaseHeightAccuracy not set");
            return this.releaseHeightAccuracy;
         }
         set
         {
            this.releaseHeightAccuracy = value;
            _whichField = Choice.releaseHeightAccuracy;
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

            // releaseHeightProbability
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseHeightProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.releaseHeightProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // minReleaseHeight
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.minReleaseHeight =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.minReleaseHeight;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // maxReleaseHeight
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.maxReleaseHeight =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.maxReleaseHeight;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // releaseHeightAccuracy
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseHeightAccuracy =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.releaseHeightAccuracy;

               XMLStreamHelper.moveToContentElement(reader);
            }
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
         if ( _whichField != Choice.None ) 
         switch( _whichField )  {

            // releaseHeightProbability
            case Choice.releaseHeightProbability: {
               encoder.encodeStartElement("releaseHeightProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.releaseHeightProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // minReleaseHeight
            case Choice.minReleaseHeight: {
               encoder.encodeStartElement("minReleaseHeight", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.minReleaseHeight, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // maxReleaseHeight
            case Choice.maxReleaseHeight: {
               encoder.encodeStartElement("maxReleaseHeight", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.maxReleaseHeight, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // releaseHeightAccuracy
            case Choice.releaseHeightAccuracy: {
               encoder.encodeStartElement("releaseHeightAccuracy", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.releaseHeightAccuracy, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class IndiacType_6
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiacType_6");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","substanceTypeProbability"),
         new XBQualifiedName("","substanceNameProbability"),
         new XBQualifiedName("","substanceUnnaProbability")
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
         None, substanceTypeProbability, substanceNameProbability, 
            substanceUnnaProbability}
      protected Choice _whichField;
      static IndiacType_6() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double substanceTypeProbability;
      protected double substanceNameProbability;
      protected double substanceUnnaProbability;

      //content methods

      public double SubstanceTypeProbability
      {
         get
         {
            if (_whichField != Choice.substanceTypeProbability ) 
               throw new XBException("field substanceTypeProbability not set");
            return this.substanceTypeProbability;
         }
         set
         {
            this.substanceTypeProbability = value;
            _whichField = Choice.substanceTypeProbability;
         }
      }

      public double SubstanceNameProbability
      {
         get
         {
            if (_whichField != Choice.substanceNameProbability ) 
               throw new XBException("field substanceNameProbability not set");
            return this.substanceNameProbability;
         }
         set
         {
            this.substanceNameProbability = value;
            _whichField = Choice.substanceNameProbability;
         }
      }

      public double SubstanceUnnaProbability
      {
         get
         {
            if (_whichField != Choice.substanceUnnaProbability ) 
               throw new XBException("field substanceUnnaProbability not set");
            return this.substanceUnnaProbability;
         }
         set
         {
            this.substanceUnnaProbability = value;
            _whichField = Choice.substanceUnnaProbability;
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

            // substanceTypeProbability
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceTypeProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.substanceTypeProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // substanceNameProbability
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceNameProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.substanceNameProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // substanceUnnaProbability
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceUnnaProbability =  RatioType.decode(text, xbContext);
               _whichField = Choice.substanceUnnaProbability;

               XMLStreamHelper.moveToContentElement(reader);
            }
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
         if ( _whichField != Choice.None ) 
         switch( _whichField )  {

            // substanceTypeProbability
            case Choice.substanceTypeProbability: {
               encoder.encodeStartElement("substanceTypeProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.substanceTypeProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // substanceNameProbability
            case Choice.substanceNameProbability: {
               encoder.encodeStartElement("substanceNameProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.substanceNameProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // substanceUnnaProbability
            case Choice.substanceUnnaProbability: {
               encoder.encodeStartElement("substanceUnnaProbability", "", "");
               String text_5;
               text_5 =  RatioType.encode(this.substanceUnnaProbability, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class IndiacType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiacType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","persistencyProbability"),
         new XBQualifiedName("","sampleIdentificationConfidenceLevel")
      };
      static IndiacType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  IndiacType_1 indiacType_1;   //optional
      protected  IndiacType_6 indiacType_6;   //optional
      protected double persistencyProbability;
      protected bool _set_persistencyProbability = false;
      protected int sampleIdentificationConfidenceLevel;
      protected bool _set_sampleIdentificationConfidenceLevel = false;

      //attribute methods

      //content methods

      public  IndiacType_1 IndiacType_1
      {
         get
         {
            if (this.indiacType_1 == null)
                throw new XBException("field indiacType_1 not set");

            return this.indiacType_1;
         }
         set
         {
            this.indiacType_1 = value;
         }
      }

      public  IndiacType_6 IndiacType_6
      {
         get
         {
            if (this.indiacType_6 == null)
                throw new XBException("field indiacType_6 not set");

            return this.indiacType_6;
         }
         set
         {
            this.indiacType_6 = value;
         }
      }

      public double PersistencyProbability
      {
         get
         {
            if (!_set_persistencyProbability)
                throw new XBException("field persistencyProbability not set");

            return this.persistencyProbability;
         }
         set
         {
            this.persistencyProbability = value;
            _set_persistencyProbability = true;
         }
      }

      public int SampleIdentificationConfidenceLevel
      {
         get
         {
            if (!_set_sampleIdentificationConfidenceLevel)
                throw new XBException("field sampleIdentificationConfidenceLevel not set");

            return this.sampleIdentificationConfidenceLevel;
         }
         set
         {
            this.sampleIdentificationConfidenceLevel = value;
            _set_sampleIdentificationConfidenceLevel = true;
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

               // indiacType_1
               if( moreContent_4 && 
                   IndiacType_1.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiacType_1 = new  IndiacType_1();
                  this.indiacType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // indiacType_6
               if( moreContent_4 && 
                   IndiacType_6.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiacType_6 = new  IndiacType_6();
                  this.indiacType_6.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // persistencyProbability
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.persistencyProbability =  RatioType.decode(text, xbContext);

                  _set_persistencyProbability = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // sampleIdentificationConfidenceLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sampleIdentificationConfidenceLevel =  SampleIdentificationConfidenceLevelCode.decode(text, xbContext);

                  _set_sampleIdentificationConfidenceLevel = true;

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

         // indiacType_1
         if (this.indiacType_1 != null)  {
            this.indiacType_1.encode(encoder, xbContext);
         }

         // indiacType_6
         if (this.indiacType_6 != null)  {
            this.indiacType_6.encode(encoder, xbContext);
         }

         // persistencyProbability
         if (_set_persistencyProbability)  {
            encoder.encodeStartElement("persistencyProbability", "", "");
            String text_4;
            text_4 =  RatioType.encode(this.persistencyProbability, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // sampleIdentificationConfidenceLevel
         if (_set_sampleIdentificationConfidenceLevel)  {
            encoder.encodeStartElement("sampleIdentificationConfidenceLevel", "", "");
            String text_4;
            text_4 =  SampleIdentificationConfidenceLevelCode.encode(this.sampleIdentificationConfidenceLevel, xbContext);
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

   public class ReleaseTypeCode
   {
      static ReleaseTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private ReleaseTypeCode() {} 


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

   public class IndiaType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiaType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","releaseType"),
         new XBQualifiedName("","releaseHeight")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, releaseType, releaseHeight}
      protected Choice _whichField;
      static IndiaType_1() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int releaseType;
      protected uint releaseHeight;

      //content methods

      public int ReleaseType
      {
         get
         {
            if (_whichField != Choice.releaseType ) 
               throw new XBException("field releaseType not set");
            return this.releaseType;
         }
         set
         {
            this.releaseType = value;
            _whichField = Choice.releaseType;
         }
      }

      public uint ReleaseHeight
      {
         get
         {
            if (_whichField != Choice.releaseHeight ) 
               throw new XBException("field releaseHeight not set");
            return this.releaseHeight;
         }
         set
         {
            this.releaseHeight = value;
            _whichField = Choice.releaseHeight;
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

            // releaseType
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseType =  ReleaseTypeCode.decode(text, xbContext);
               _whichField = Choice.releaseType;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // releaseHeight
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.releaseHeight =  Int1To99999Type.decode(text, xbContext);
               _whichField = Choice.releaseHeight;

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

            // releaseType
            case Choice.releaseType: {
               if (_whichField != Choice.releaseType ) 
                  throw new XBException("field releaseType not set");
               encoder.encodeStartElement("releaseType", "", "");
               String text_5;
               text_5 =  ReleaseTypeCode.encode(this.releaseType, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // releaseHeight
            case Choice.releaseHeight: {
               if (_whichField != Choice.releaseHeight ) 
                  throw new XBException("field releaseHeight not set");
               encoder.encodeStartElement("releaseHeight", "", "");
               String text_5;
               text_5 =  Int1To99999Type.encode(this.releaseHeight, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class SubstanceTypeCode
   {
      static SubstanceTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SubstanceTypeCode() {} 


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

   public class SubstanceNameCode
   {
      static SubstanceNameCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SubstanceNameCode() {} 


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

   public class IndiaType_4
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiaType_4");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","substanceType"),
         new XBQualifiedName("","substanceName"),
         new XBQualifiedName("","unnaIdentificationNumber")
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
         None, substanceType, substanceName, unnaIdentificationNumber}
      protected Choice _whichField;
      static IndiaType_4() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int substanceType;
      protected int substanceName;
      protected ushort unnaIdentificationNumber;

      //content methods

      public int SubstanceType
      {
         get
         {
            if (_whichField != Choice.substanceType ) 
               throw new XBException("field substanceType not set");
            return this.substanceType;
         }
         set
         {
            this.substanceType = value;
            _whichField = Choice.substanceType;
         }
      }

      public int SubstanceName
      {
         get
         {
            if (_whichField != Choice.substanceName ) 
               throw new XBException("field substanceName not set");
            return this.substanceName;
         }
         set
         {
            this.substanceName = value;
            _whichField = Choice.substanceName;
         }
      }

      public ushort UnnaIdentificationNumber
      {
         get
         {
            if (_whichField != Choice.unnaIdentificationNumber ) 
               throw new XBException("field unnaIdentificationNumber not set");
            return this.unnaIdentificationNumber;
         }
         set
         {
            this.unnaIdentificationNumber = value;
            _whichField = Choice.unnaIdentificationNumber;
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

            // substanceType
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceType =  SubstanceTypeCode.decode(text, xbContext);
               _whichField = Choice.substanceType;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // substanceName
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.substanceName =  SubstanceNameCode.decode(text, xbContext);
               _whichField = Choice.substanceName;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // unnaIdentificationNumber
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.unnaIdentificationNumber =  Int0To9999Type.decode(text, xbContext);
               _whichField = Choice.unnaIdentificationNumber;

               XMLStreamHelper.moveToContentElement(reader);
            }
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
         if ( _whichField != Choice.None ) 
         switch( _whichField )  {

            // substanceType
            case Choice.substanceType: {
               encoder.encodeStartElement("substanceType", "", "");
               String text_5;
               text_5 =  SubstanceTypeCode.encode(this.substanceType, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // substanceName
            case Choice.substanceName: {
               encoder.encodeStartElement("substanceName", "", "");
               String text_5;
               text_5 =  SubstanceNameCode.encode(this.substanceName, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // unnaIdentificationNumber
            case Choice.unnaIdentificationNumber: {
               encoder.encodeStartElement("unnaIdentificationNumber", "", "");
               String text_5;
               text_5 =  Int0To9999Type.encode(this.unnaIdentificationNumber, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class PersistencyTypeCode
   {
      static PersistencyTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private PersistencyTypeCode() {} 


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

   public class IndiaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "IndiaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","persistencyType"),
         new XBQualifiedName("","detectionType"),
         new XBQualifiedName("","confidenceLevel")
      };
      static IndiaType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  IndiaType_1 indiaType_1;
      protected  IndiaType_4 indiaType_4;   //optional
      protected int persistencyType;
      protected bool _set_persistencyType = false;
      protected int detectionType;
      protected bool _set_detectionType = false;
      protected int confidenceLevel;
      protected bool _set_confidenceLevel = false;

      //attribute methods

      //content methods

      public  IndiaType_1 IndiaType_1
      {
         get
         {
            if (this.indiaType_1 == null)
                throw new XBException("field indiaType_1 not set");

            return this.indiaType_1;
         }
         set
         {
            this.indiaType_1 = value;
         }
      }

      public  IndiaType_4 IndiaType_4
      {
         get
         {
            if (this.indiaType_4 == null)
                throw new XBException("field indiaType_4 not set");

            return this.indiaType_4;
         }
         set
         {
            this.indiaType_4 = value;
         }
      }

      public int PersistencyType
      {
         get
         {
            if (!_set_persistencyType)
                throw new XBException("field persistencyType not set");

            return this.persistencyType;
         }
         set
         {
            this.persistencyType = value;
            _set_persistencyType = true;
         }
      }

      public int DetectionType
      {
         get
         {
            if (!_set_detectionType)
                throw new XBException("field detectionType not set");

            return this.detectionType;
         }
         set
         {
            this.detectionType = value;
            _set_detectionType = true;
         }
      }

      public int ConfidenceLevel
      {
         get
         {
            if (!_set_confidenceLevel)
                throw new XBException("field confidenceLevel not set");

            return this.confidenceLevel;
         }
         set
         {
            this.confidenceLevel = value;
            _set_confidenceLevel = true;
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

               // indiaType_1
               if( moreContent_4 && 
                   IndiaType_1.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiaType_1 = new  IndiaType_1();
                  this.indiaType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "indiaType_1");

               // indiaType_4
               if( moreContent_4 && 
                   IndiaType_4.acceptsElem(elemNs, elemLocalName) )
               {
                  this.indiaType_4 = new  IndiaType_4();
                  this.indiaType_4.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // persistencyType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.persistencyType =  PersistencyTypeCode.decode(text, xbContext);

                  _set_persistencyType = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // detectionType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.detectionType =  DetectionTypeCode.decode(text, xbContext);

                  _set_detectionType = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // confidenceLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.confidenceLevel =  DetectionConfidenceLevelCode.decode(text, xbContext);

                  _set_confidenceLevel = true;

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

         // indiaType_1
         if (this.indiaType_1 == null)
             throw new XBException("field indiaType_1 not set");

         this.indiaType_1.encode(encoder, xbContext);

         // indiaType_4
         if (this.indiaType_4 != null)  {
            this.indiaType_4.encode(encoder, xbContext);
         }

         // persistencyType
         if (_set_persistencyType)  {
            encoder.encodeStartElement("persistencyType", "", "");
            String text_4;
            text_4 =  PersistencyTypeCode.encode(this.persistencyType, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // detectionType
         if (_set_detectionType)  {
            encoder.encodeStartElement("detectionType", "", "");
            String text_4;
            text_4 =  DetectionTypeCode.encode(this.detectionType, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // confidenceLevel
         if (_set_confidenceLevel)  {
            encoder.encodeStartElement("confidenceLevel", "", "");
            String text_4;
            text_4 =  DetectionConfidenceLevelCode.encode(this.confidenceLevel, xbContext);
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

   public class MikerType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "MikerType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","incidentDescription"),
         new XBQualifiedName("","incidentStatus")
      };
      static MikerType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int incidentDescription;
      protected int incidentStatus;

      //attribute methods

      //content methods

      public int IncidentDescription
      {
         get { return this.incidentDescription; }
         set { this.incidentDescription = value; }
      }

      public int IncidentStatus
      {
         get { return this.incidentStatus; }
         set { this.incidentStatus = value; }
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

               // incidentDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.incidentDescription =  IncidentDescriptionCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "incidentDescription");

               // incidentStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.incidentStatus =  IncidentStatusCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "incidentStatus");

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

         // incidentDescription
         encoder.encodeStartElement("incidentDescription", "", "");
         String text_3;
         text_3 =  IncidentDescriptionCode.encode(this.incidentDescription, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // incidentStatus
         encoder.encodeStartElement("incidentStatus", "", "");
         text_3 =  IncidentStatusCode.encode(this.incidentStatus, xbContext);
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

   public class OscarType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "OscarType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","estimatedContourLinesDatetime")
      };
      static OscarType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string estimatedContourLinesDatetime;

      //attribute methods

      //content methods

      public string EstimatedContourLinesDatetime
      {
         get { return this.estimatedContourLinesDatetime; }
         set { this.estimatedContourLinesDatetime = value; }
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

               // estimatedContourLinesDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.estimatedContourLinesDatetime = text;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "estimatedContourLinesDatetime");

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

         // estimatedContourLinesDatetime
         encoder.encodeStartElement("estimatedContourLinesDatetime", "", "");
         String text_3;
         text_3 = this.estimatedContourLinesDatetime;
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

   public class PapaaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "PapaaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","releaseAreaRadius"),
         new XBQualifiedName("","releaseAreaMinDuration"),
         new XBQualifiedName("","releaseAreaCalculatedDuration"),
         new XBQualifiedName("","hazardAreaDistance"),
         new XBQualifiedName("","hazardAreaMinDuration"),
         new XBQualifiedName("","hazardAreaCalculatedDuration")
      };
      static PapaaType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected uint releaseAreaRadius;
      protected XBDuration releaseAreaMinDuration;
      protected XBDuration releaseAreaCalculatedDuration;
      protected uint hazardAreaDistance;
      protected XBDuration hazardAreaMinDuration;
      protected XBDuration hazardAreaCalculatedDuration;

      //attribute methods

      //content methods

      public uint ReleaseAreaRadius
      {
         get { return this.releaseAreaRadius; }
         set { this.releaseAreaRadius = value; }
      }

      public XBDuration ReleaseAreaMinDuration
      {
         get
         {
            if (this.releaseAreaMinDuration == null)
                throw new XBException("field releaseAreaMinDuration not set");

            return this.releaseAreaMinDuration;
         }
         set
         {
            this.releaseAreaMinDuration = value;
         }
      }

      public XBDuration ReleaseAreaCalculatedDuration
      {
         get
         {
            if (this.releaseAreaCalculatedDuration == null)
                throw new XBException("field releaseAreaCalculatedDuration not set");

            return this.releaseAreaCalculatedDuration;
         }
         set
         {
            this.releaseAreaCalculatedDuration = value;
         }
      }

      public uint HazardAreaDistance
      {
         get { return this.hazardAreaDistance; }
         set { this.hazardAreaDistance = value; }
      }

      public XBDuration HazardAreaMinDuration
      {
         get
         {
            if (this.hazardAreaMinDuration == null)
                throw new XBException("field hazardAreaMinDuration not set");

            return this.hazardAreaMinDuration;
         }
         set
         {
            this.hazardAreaMinDuration = value;
         }
      }

      public XBDuration HazardAreaCalculatedDuration
      {
         get
         {
            if (this.hazardAreaCalculatedDuration == null)
                throw new XBException("field hazardAreaCalculatedDuration not set");

            return this.hazardAreaCalculatedDuration;
         }
         set
         {
            this.hazardAreaCalculatedDuration = value;
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

               // releaseAreaRadius
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.releaseAreaRadius =  Int0To999999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "releaseAreaRadius");

               // releaseAreaMinDuration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.releaseAreaMinDuration = XBDurationHelper.parseXML(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "releaseAreaMinDuration");

               // releaseAreaCalculatedDuration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.releaseAreaCalculatedDuration = XBDurationHelper.parseXML(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "releaseAreaCalculatedDuration");

               // hazardAreaDistance
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.hazardAreaDistance =  Int0To999999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "hazardAreaDistance");

               // hazardAreaMinDuration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.hazardAreaMinDuration = XBDurationHelper.parseXML(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "hazardAreaMinDuration");

               // hazardAreaCalculatedDuration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.hazardAreaCalculatedDuration = XBDurationHelper.parseXML(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "hazardAreaCalculatedDuration");

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

         // releaseAreaRadius
         encoder.encodeStartElement("releaseAreaRadius", "", "");
         String text_3;
         text_3 =  Int0To999999Type.encode(this.releaseAreaRadius, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // releaseAreaMinDuration
         if (this.releaseAreaMinDuration == null)
             throw new XBException("field releaseAreaMinDuration not set");

         encoder.encodeStartElement("releaseAreaMinDuration", "", "");
         text_3 = this.releaseAreaMinDuration.ToString();
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // releaseAreaCalculatedDuration
         if (this.releaseAreaCalculatedDuration == null)
             throw new XBException("field releaseAreaCalculatedDuration not set");

         encoder.encodeStartElement("releaseAreaCalculatedDuration", "", "");
         text_3 = this.releaseAreaCalculatedDuration.ToString();
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // hazardAreaDistance
         encoder.encodeStartElement("hazardAreaDistance", "", "");
         text_3 =  Int0To999999Type.encode(this.hazardAreaDistance, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // hazardAreaMinDuration
         if (this.hazardAreaMinDuration == null)
             throw new XBException("field hazardAreaMinDuration not set");

         encoder.encodeStartElement("hazardAreaMinDuration", "", "");
         text_3 = this.hazardAreaMinDuration.ToString();
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // hazardAreaCalculatedDuration
         if (this.hazardAreaCalculatedDuration == null)
             throw new XBException("field hazardAreaCalculatedDuration not set");

         encoder.encodeStartElement("hazardAreaCalculatedDuration", "", "");
         text_3 = this.hazardAreaCalculatedDuration.ToString();
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

   public class PapaxType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "PapaxType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","startDatetime"),
         new XBQualifiedName("","hazardAreaPoint")
      };
      static PapaxType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string startDatetime;
      protected  PointType[] hazardAreaPoint;
      protected int _length_hazardAreaPoint = 0;

      //attribute methods

      //content methods

      public string StartDatetime
      {
         get { return this.startDatetime; }
         set { this.startDatetime = value; }
      }

      public  PointType[] HazardAreaPoint
      {
         get
         {
            if (this.hazardAreaPoint == null)
                throw new XBException("field hazardAreaPoint not set");

             PointType[] 
               arrCopy = new  PointType[_length_hazardAreaPoint];
            Array.Copy(this.hazardAreaPoint, arrCopy, _length_hazardAreaPoint);
            return arrCopy;
         }
         set
         {
            this.hazardAreaPoint = value;
            this.hazardAreaPoint = new  PointType[value.Length];
            value.CopyTo(this.hazardAreaPoint, 0);
            _length_hazardAreaPoint = value.Length;
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

               // startDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
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

               // hazardAreaPoint
               this.hazardAreaPoint = new  PointType[20];
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.hazardAreaPoint[_length_hazardAreaPoint] = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.hazardAreaPoint[_length_hazardAreaPoint].decode(reader, xbContext, false, false);
                  _length_hazardAreaPoint++;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4 && _length_hazardAreaPoint < 20) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( _length_hazardAreaPoint < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(_length_hazardAreaPoint, "hazardAreaPoint");
               else if (_length_hazardAreaPoint == 0 && moreContent_4) 
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

         // startDatetime
         encoder.encodeStartElement("startDatetime", "", "");
         String text_3;
         text_3 = this.startDatetime;
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // hazardAreaPoint
         if (this.hazardAreaPoint == null || _length_hazardAreaPoint < 1 || 
            20 < _length_hazardAreaPoint) 
            throw new XBOccurrencesException( (this.hazardAreaPoint == null ? 0 : _length_hazardAreaPoint ) );

         for (int i = 0; i < _length_hazardAreaPoint; i++) {
            encoder.encodeStartElement("hazardAreaPoint", "", "");
            this.hazardAreaPoint[i].encode(encoder, xbContext, null, false);
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

   public class SampleTypeCode
   {
      static SampleTypeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SampleTypeCode() {} 


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

   public class QuebecType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "QuebecType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","detectionLocation"),
         new XBQualifiedName("","sampleType"),
         new XBQualifiedName("","detectionType"),
         new XBQualifiedName("","detectionMeanType"),
         new XBQualifiedName("","measurementHeight"),
         new XBQualifiedName("","distanceToCloud"),
         new XBQualifiedName("","leftRadialLine"),
         new XBQualifiedName("","rightRadialLine"),
         new XBQualifiedName("","cloudTopAngle"),
         new XBQualifiedName("","cloudBottomAngle")
      };
      static QuebecType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PointType detectionLocation;
      protected int sampleType;
      protected int detectionType;
      protected int detectionMeanType;
      protected uint measurementHeight;
      protected bool _set_measurementHeight = false;
      protected uint distanceToCloud;
      protected bool _set_distanceToCloud = false;
      protected double leftRadialLine;
      protected bool _set_leftRadialLine = false;
      protected double rightRadialLine;
      protected bool _set_rightRadialLine = false;
      protected double cloudTopAngle;
      protected bool _set_cloudTopAngle = false;
      protected double cloudBottomAngle;
      protected bool _set_cloudBottomAngle = false;

      //attribute methods

      //content methods

      public  PointType DetectionLocation
      {
         get
         {
            if (this.detectionLocation == null)
                throw new XBException("field detectionLocation not set");

            return this.detectionLocation;
         }
         set
         {
            this.detectionLocation = value;
         }
      }

      public int SampleType
      {
         get { return this.sampleType; }
         set { this.sampleType = value; }
      }

      public int DetectionType
      {
         get { return this.detectionType; }
         set { this.detectionType = value; }
      }

      public int DetectionMeanType
      {
         get { return this.detectionMeanType; }
         set { this.detectionMeanType = value; }
      }

      public uint MeasurementHeight
      {
         get
         {
            if (!_set_measurementHeight)
                throw new XBException("field measurementHeight not set");

            return this.measurementHeight;
         }
         set
         {
            this.measurementHeight = value;
            _set_measurementHeight = true;
         }
      }

      public uint DistanceToCloud
      {
         get
         {
            if (!_set_distanceToCloud)
                throw new XBException("field distanceToCloud not set");

            return this.distanceToCloud;
         }
         set
         {
            this.distanceToCloud = value;
            _set_distanceToCloud = true;
         }
      }

      public double LeftRadialLine
      {
         get
         {
            if (!_set_leftRadialLine)
                throw new XBException("field leftRadialLine not set");

            return this.leftRadialLine;
         }
         set
         {
            this.leftRadialLine = value;
            _set_leftRadialLine = true;
         }
      }

      public double RightRadialLine
      {
         get
         {
            if (!_set_rightRadialLine)
                throw new XBException("field rightRadialLine not set");

            return this.rightRadialLine;
         }
         set
         {
            this.rightRadialLine = value;
            _set_rightRadialLine = true;
         }
      }

      public double CloudTopAngle
      {
         get
         {
            if (!_set_cloudTopAngle)
                throw new XBException("field cloudTopAngle not set");

            return this.cloudTopAngle;
         }
         set
         {
            this.cloudTopAngle = value;
            _set_cloudTopAngle = true;
         }
      }

      public double CloudBottomAngle
      {
         get
         {
            if (!_set_cloudBottomAngle)
                throw new XBException("field cloudBottomAngle not set");

            return this.cloudBottomAngle;
         }
         set
         {
            this.cloudBottomAngle = value;
            _set_cloudBottomAngle = true;
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

               // detectionLocation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.detectionLocation = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.detectionLocation.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "detectionLocation");

               // sampleType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.sampleType =  SampleTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sampleType");

               // detectionType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.detectionType =  DetectionTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "detectionType");

               // detectionMeanType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.detectionMeanType =  DetectionMeanTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "detectionMeanType");

               // measurementHeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.measurementHeight =  Int0To99999Type.decode(text, xbContext);

                  _set_measurementHeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // distanceToCloud
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.distanceToCloud =  Int1To99999Type.decode(text, xbContext);

                  _set_distanceToCloud = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // leftRadialLine
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.leftRadialLine =  AngleType.decode(text, xbContext);

                  _set_leftRadialLine = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // rightRadialLine
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.rightRadialLine =  AngleType.decode(text, xbContext);

                  _set_rightRadialLine = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // cloudTopAngle
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudTopAngle =  ElevationAngleType.decode(text, xbContext);

                  _set_cloudTopAngle = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // cloudBottomAngle
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudBottomAngle =  ElevationAngleType.decode(text, xbContext);

                  _set_cloudBottomAngle = true;

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

         // detectionLocation
         if (this.detectionLocation == null)
             throw new XBException("field detectionLocation not set");

         encoder.encodeStartElement("detectionLocation", "", "");
         this.detectionLocation.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // sampleType
         encoder.encodeStartElement("sampleType", "", "");
         String text_3;
         text_3 =  SampleTypeCode.encode(this.sampleType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // detectionType
         encoder.encodeStartElement("detectionType", "", "");
         text_3 =  DetectionTypeCode.encode(this.detectionType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // detectionMeanType
         encoder.encodeStartElement("detectionMeanType", "", "");
         text_3 =  DetectionMeanTypeCode.encode(this.detectionMeanType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // measurementHeight
         if (_set_measurementHeight)  {
            encoder.encodeStartElement("measurementHeight", "", "");
            text_3 =  Int0To99999Type.encode(this.measurementHeight, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // distanceToCloud
         if (_set_distanceToCloud)  {
            encoder.encodeStartElement("distanceToCloud", "", "");
            text_3 =  Int1To99999Type.encode(this.distanceToCloud, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // leftRadialLine
         if (_set_leftRadialLine)  {
            encoder.encodeStartElement("leftRadialLine", "", "");
            text_3 =  AngleType.encode(this.leftRadialLine, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // rightRadialLine
         if (_set_rightRadialLine)  {
            encoder.encodeStartElement("rightRadialLine", "", "");
            text_3 =  AngleType.encode(this.rightRadialLine, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // cloudTopAngle
         if (_set_cloudTopAngle)  {
            encoder.encodeStartElement("cloudTopAngle", "", "");
            text_3 =  ElevationAngleType.encode(this.cloudTopAngle, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // cloudBottomAngle
         if (_set_cloudBottomAngle)  {
            encoder.encodeStartElement("cloudBottomAngle", "", "");
            text_3 =  ElevationAngleType.encode(this.cloudBottomAngle, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
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

   public class RelativeHumidityRangeCode
   {
      static RelativeHumidityRangeCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private RelativeHumidityRangeCode() {} 


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

   public class RomeoType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "RomeoType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","atmosphericParticleConcentrationQuantity"),
         new XBQualifiedName("","massFractionConcentrationQuantity"),
         new XBQualifiedName("","surfaceDepositionQuantity"),
         new XBQualifiedName("","volumeConcentrationQuantity"),
         new XBQualifiedName("","concentrationTimeQuantity")
      };
      static RomeoType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double atmosphericParticleConcentrationQuantity;
      protected bool _set_atmosphericParticleConcentrationQuantity = false;
      protected double massFractionConcentrationQuantity;
      protected bool _set_massFractionConcentrationQuantity = false;
      protected double surfaceDepositionQuantity;
      protected bool _set_surfaceDepositionQuantity = false;
      protected double volumeConcentrationQuantity;
      protected bool _set_volumeConcentrationQuantity = false;
      protected double concentrationTimeQuantity;
      protected bool _set_concentrationTimeQuantity = false;

      //attribute methods

      //content methods

      public double AtmosphericParticleConcentrationQuantity
      {
         get
         {
            if (!_set_atmosphericParticleConcentrationQuantity)
                throw new XBException("field atmosphericParticleConcentrationQuantity not set");

            return this.atmosphericParticleConcentrationQuantity;
         }
         set
         {
            this.atmosphericParticleConcentrationQuantity = value;
            _set_atmosphericParticleConcentrationQuantity = true;
         }
      }

      public double MassFractionConcentrationQuantity
      {
         get
         {
            if (!_set_massFractionConcentrationQuantity)
                throw new XBException("field massFractionConcentrationQuantity not set");

            return this.massFractionConcentrationQuantity;
         }
         set
         {
            this.massFractionConcentrationQuantity = value;
            _set_massFractionConcentrationQuantity = true;
         }
      }

      public double SurfaceDepositionQuantity
      {
         get
         {
            if (!_set_surfaceDepositionQuantity)
                throw new XBException("field surfaceDepositionQuantity not set");

            return this.surfaceDepositionQuantity;
         }
         set
         {
            this.surfaceDepositionQuantity = value;
            _set_surfaceDepositionQuantity = true;
         }
      }

      public double VolumeConcentrationQuantity
      {
         get
         {
            if (!_set_volumeConcentrationQuantity)
                throw new XBException("field volumeConcentrationQuantity not set");

            return this.volumeConcentrationQuantity;
         }
         set
         {
            this.volumeConcentrationQuantity = value;
            _set_volumeConcentrationQuantity = true;
         }
      }

      public double ConcentrationTimeQuantity
      {
         get
         {
            if (!_set_concentrationTimeQuantity)
                throw new XBException("field concentrationTimeQuantity not set");

            return this.concentrationTimeQuantity;
         }
         set
         {
            this.concentrationTimeQuantity = value;
            _set_concentrationTimeQuantity = true;
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

               // atmosphericParticleConcentrationQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.atmosphericParticleConcentrationQuantity =  Decimal0To99999999999999Type.decode(text, xbContext);

                  _set_atmosphericParticleConcentrationQuantity = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // massFractionConcentrationQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.massFractionConcentrationQuantity =  Decimal0To99999999999999Type.decode(text, xbContext);

                  _set_massFractionConcentrationQuantity = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // surfaceDepositionQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.surfaceDepositionQuantity =  Decimal0To99999999999999Type.decode(text, xbContext);

                  _set_surfaceDepositionQuantity = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // volumeConcentrationQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.volumeConcentrationQuantity =  Decimal0To99999999999999Type.decode(text, xbContext);

                  _set_volumeConcentrationQuantity = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // concentrationTimeQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.concentrationTimeQuantity =  Decimal0To99999999999999Type.decode(text, xbContext);

                  _set_concentrationTimeQuantity = true;

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

         // atmosphericParticleConcentrationQuantity
         if (_set_atmosphericParticleConcentrationQuantity)  {
            encoder.encodeStartElement("atmosphericParticleConcentrationQuantity", "", "");
            String text_4;
            text_4 =  Decimal0To99999999999999Type.encode(this.atmosphericParticleConcentrationQuantity, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // massFractionConcentrationQuantity
         if (_set_massFractionConcentrationQuantity)  {
            encoder.encodeStartElement("massFractionConcentrationQuantity", "", "");
            String text_4;
            text_4 =  Decimal0To99999999999999Type.encode(this.massFractionConcentrationQuantity, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // surfaceDepositionQuantity
         if (_set_surfaceDepositionQuantity)  {
            encoder.encodeStartElement("surfaceDepositionQuantity", "", "");
            String text_4;
            text_4 =  Decimal0To99999999999999Type.encode(this.surfaceDepositionQuantity, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // volumeConcentrationQuantity
         if (_set_volumeConcentrationQuantity)  {
            encoder.encodeStartElement("volumeConcentrationQuantity", "", "");
            String text_4;
            text_4 =  Decimal0To99999999999999Type.encode(this.volumeConcentrationQuantity, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // concentrationTimeQuantity
         if (_set_concentrationTimeQuantity)  {
            encoder.encodeStartElement("concentrationTimeQuantity", "", "");
            String text_4;
            text_4 =  Decimal0To99999999999999Type.encode(this.concentrationTimeQuantity, xbContext);
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

   public class SierraType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "SierraType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","readingDatetime"),
         new XBQualifiedName("","contaminationDatetime")
      };

      public static bool acceptsElem(String elemNs, String elemLocalName) {
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[0], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[1], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, readingDatetime, contaminationDatetime}
      protected Choice _whichField;
      static SierraType_1() {
         XBUtil.license =  _Cbrn.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string readingDatetime;
      protected string contaminationDatetime;

      //content methods

      public string ReadingDatetime
      {
         get
         {
            if (_whichField != Choice.readingDatetime ) 
               throw new XBException("field readingDatetime not set");
            return this.readingDatetime;
         }
         set
         {
            this.readingDatetime = value;
            _whichField = Choice.readingDatetime;
         }
      }

      public string ContaminationDatetime
      {
         get
         {
            if (_whichField != Choice.contaminationDatetime ) 
               throw new XBException("field contaminationDatetime not set");
            return this.contaminationDatetime;
         }
         set
         {
            this.contaminationDatetime = value;
            _whichField = Choice.contaminationDatetime;
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

            // readingDatetime
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.readingDatetime = text;
               _whichField = Choice.readingDatetime;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // contaminationDatetime
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.contaminationDatetime = text;
               _whichField = Choice.contaminationDatetime;

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

            // readingDatetime
            case Choice.readingDatetime: {
               if (_whichField != Choice.readingDatetime ) 
                  throw new XBException("field readingDatetime not set");
               encoder.encodeStartElement("readingDatetime", "", "");
               String text_5;
               text_5 = this.readingDatetime;
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }

            // contaminationDatetime
            case Choice.contaminationDatetime: {
               if (_whichField != Choice.contaminationDatetime ) 
                  throw new XBException("field contaminationDatetime not set");
               encoder.encodeStartElement("contaminationDatetime", "", "");
               String text_5;
               text_5 = this.contaminationDatetime;
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class SierraType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "SierraType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {

      };
      static SierraType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  SierraType_1 sierraType_1;

      //attribute methods

      //content methods

      public  SierraType_1 SierraType_1
      {
         get
         {
            if (this.sierraType_1 == null)
                throw new XBException("field sierraType_1 not set");

            return this.sierraType_1;
         }
         set
         {
            this.sierraType_1 = value;
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

               // sierraType_1
               if( moreContent_4 && 
                   SierraType_1.acceptsElem(elemNs, elemLocalName) )
               {
                  this.sierraType_1 = new  SierraType_1();
                  this.sierraType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "sierraType_1");

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

         // sierraType_1
         if (this.sierraType_1 == null)
             throw new XBException("field sierraType_1 not set");

         this.sierraType_1.encode(encoder, xbContext);
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

   public class SignificantWeatherPhenomenaCode
   {
      static SignificantWeatherPhenomenaCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private SignificantWeatherPhenomenaCode() {} 


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

   public class TerrainTopographyDescriptionCode
   {
      static TerrainTopographyDescriptionCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private TerrainTopographyDescriptionCode() {} 


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

   public class VegetationDescriptionCode
   {
      static VegetationDescriptionCode() {
         XBUtil.license =  _Cbrn.license;
      }

      //constructor
      private VegetationDescriptionCode() {} 


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

   public class TangoType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "TangoType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","terrainTopographyDescription"),
         new XBQualifiedName("","vegetationDescription")
      };
      static TangoType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int terrainTopographyDescription;
      protected int vegetationDescription;

      //attribute methods

      //content methods

      public int TerrainTopographyDescription
      {
         get { return this.terrainTopographyDescription; }
         set { this.terrainTopographyDescription = value; }
      }

      public int VegetationDescription
      {
         get { return this.vegetationDescription; }
         set { this.vegetationDescription = value; }
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

               // terrainTopographyDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.terrainTopographyDescription =  TerrainTopographyDescriptionCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "terrainTopographyDescription");

               // vegetationDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.vegetationDescription =  VegetationDescriptionCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "vegetationDescription");

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

         // terrainTopographyDescription
         encoder.encodeStartElement("terrainTopographyDescription", "", "");
         String text_3;
         text_3 =  TerrainTopographyDescriptionCode.encode(this.terrainTopographyDescription, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // vegetationDescription
         encoder.encodeStartElement("vegetationDescription", "", "");
         text_3 =  VegetationDescriptionCode.encode(this.vegetationDescription, xbContext);
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

   public class WhiskeymType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "WhiskeymType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","downwindDirection"),
         new XBQualifiedName("","windSpeed"),
         new XBQualifiedName("","airStabilityCategory"),
         new XBQualifiedName("","airTemperature"),
         new XBQualifiedName("","relativeHumidity"),
         new XBQualifiedName("","significantWeatherPhenomena"),
         new XBQualifiedName("","cloudCoverage")
      };
      static WhiskeymType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double downwindDirection;
      protected short windSpeed;
      protected int airStabilityCategory;
      protected sbyte airTemperature;
      protected int relativeHumidity;
      protected int significantWeatherPhenomena;
      protected int cloudCoverage;

      //attribute methods

      //content methods

      public double DownwindDirection
      {
         get { return this.downwindDirection; }
         set { this.downwindDirection = value; }
      }

      public short WindSpeed
      {
         get { return this.windSpeed; }
         set { this.windSpeed = value; }
      }

      public int AirStabilityCategory
      {
         get { return this.airStabilityCategory; }
         set { this.airStabilityCategory = value; }
      }

      public sbyte AirTemperature
      {
         get { return this.airTemperature; }
         set { this.airTemperature = value; }
      }

      public int RelativeHumidity
      {
         get { return this.relativeHumidity; }
         set { this.relativeHumidity = value; }
      }

      public int SignificantWeatherPhenomena
      {
         get { return this.significantWeatherPhenomena; }
         set { this.significantWeatherPhenomena = value; }
      }

      public int CloudCoverage
      {
         get { return this.cloudCoverage; }
         set { this.cloudCoverage = value; }
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

               // downwindDirection
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.downwindDirection =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "downwindDirection");

               // windSpeed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.windSpeed =  SpeedType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "windSpeed");

               // airStabilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airStabilityCategory =  AirStabilityCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airStabilityCategory");

               // airTemperature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airTemperature =  IntMinus63To63Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airTemperature");

               // relativeHumidity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.relativeHumidity =  RelativeHumidityRangeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "relativeHumidity");

               // significantWeatherPhenomena
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.significantWeatherPhenomena =  SignificantWeatherPhenomenaCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "significantWeatherPhenomena");

               // cloudCoverage
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudCoverage =  CloudCoverageCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "cloudCoverage");

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

         // downwindDirection
         encoder.encodeStartElement("downwindDirection", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.downwindDirection, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // windSpeed
         encoder.encodeStartElement("windSpeed", "", "");
         text_3 =  SpeedType.encode(this.windSpeed, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airStabilityCategory
         encoder.encodeStartElement("airStabilityCategory", "", "");
         text_3 =  AirStabilityCategoryCode.encode(this.airStabilityCategory, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airTemperature
         encoder.encodeStartElement("airTemperature", "", "");
         text_3 =  IntMinus63To63Type.encode(this.airTemperature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // relativeHumidity
         encoder.encodeStartElement("relativeHumidity", "", "");
         text_3 =  RelativeHumidityRangeCode.encode(this.relativeHumidity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // significantWeatherPhenomena
         encoder.encodeStartElement("significantWeatherPhenomena", "", "");
         text_3 =  SignificantWeatherPhenomenaCode.encode(this.significantWeatherPhenomena, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // cloudCoverage
         encoder.encodeStartElement("cloudCoverage", "", "");
         text_3 =  CloudCoverageCode.encode(this.cloudCoverage, xbContext);
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

   public class WhiskeyType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "WhiskeyType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","genericAlarmResult"),
         new XBQualifiedName("","nonSpecificPotentialHarmfulResult"),
         new XBQualifiedName("","confirmatoryTest"),
         new XBQualifiedName("","confidenceLevel")
      };
      static WhiskeyType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int genericAlarmResult;
      protected int nonSpecificPotentialHarmfulResult;
      protected bool confirmatoryTest;
      protected bool _set_confirmatoryTest = false;
      protected int confidenceLevel;
      protected bool _set_confidenceLevel = false;

      //attribute methods

      //content methods

      public int GenericAlarmResult
      {
         get { return this.genericAlarmResult; }
         set { this.genericAlarmResult = value; }
      }

      public int NonSpecificPotentialHarmfulResult
      {
         get { return this.nonSpecificPotentialHarmfulResult; }
         set { this.nonSpecificPotentialHarmfulResult = value; }
      }

      public bool ConfirmatoryTest
      {
         get
         {
            if (!_set_confirmatoryTest)
                throw new XBException("field confirmatoryTest not set");

            return this.confirmatoryTest;
         }
         set
         {
            this.confirmatoryTest = value;
            _set_confirmatoryTest = true;
         }
      }

      public int ConfidenceLevel
      {
         get
         {
            if (!_set_confidenceLevel)
                throw new XBException("field confidenceLevel not set");

            return this.confidenceLevel;
         }
         set
         {
            this.confidenceLevel = value;
            _set_confidenceLevel = true;
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

               // genericAlarmResult
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.genericAlarmResult =  GenericAlarmResultCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "genericAlarmResult");

               // nonSpecificPotentialHarmfulResult
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.nonSpecificPotentialHarmfulResult =  GenericAlarmResultCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "nonSpecificPotentialHarmfulResult");

               // confirmatoryTest
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.confirmatoryTest = XBSimpleType.parseBoolean(text);

                  _set_confirmatoryTest = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // confidenceLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.confidenceLevel =  DetectionConfidenceLevelCode.decode(text, xbContext);

                  _set_confidenceLevel = true;

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

         // genericAlarmResult
         encoder.encodeStartElement("genericAlarmResult", "", "");
         String text_3;
         text_3 =  GenericAlarmResultCode.encode(this.genericAlarmResult, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // nonSpecificPotentialHarmfulResult
         encoder.encodeStartElement("nonSpecificPotentialHarmfulResult", "", "");
         text_3 =  GenericAlarmResultCode.encode(this.nonSpecificPotentialHarmfulResult, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // confirmatoryTest
         if (_set_confirmatoryTest)  {
            encoder.encodeStartElement("confirmatoryTest", "", "");
            text_3 = this.confirmatoryTest.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // confidenceLevel
         if (_set_confidenceLevel)  {
            encoder.encodeStartElement("confidenceLevel", "", "");
            text_3 =  DetectionConfidenceLevelCode.encode(this.confidenceLevel, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
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

   public class XrayaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "XrayaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","contaminationLevel"),
         new XBQualifiedName("","hazardLevel"),
         new XBQualifiedName("","hazardAreaPoint")
      };
      static XrayaType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  RomeoType contaminationLevel;   //optional
      protected  HazardLevelType hazardLevel;   //optional
      protected  PointType[] hazardAreaPoint;
      protected int _length_hazardAreaPoint = 0;

      //attribute methods

      //content methods

      public  RomeoType ContaminationLevel
      {
         get
         {
            if (this.contaminationLevel == null)
                throw new XBException("field contaminationLevel not set");

            return this.contaminationLevel;
         }
         set
         {
            this.contaminationLevel = value;
         }
      }

      public  HazardLevelType HazardLevel
      {
         get
         {
            if (this.hazardLevel == null)
                throw new XBException("field hazardLevel not set");

            return this.hazardLevel;
         }
         set
         {
            this.hazardLevel = value;
         }
      }

      public  PointType[] HazardAreaPoint
      {
         get
         {
            if (this.hazardAreaPoint == null)
                throw new XBException("field hazardAreaPoint not set");

             PointType[] 
               arrCopy = new  PointType[_length_hazardAreaPoint];
            Array.Copy(this.hazardAreaPoint, arrCopy, _length_hazardAreaPoint);
            return arrCopy;
         }
         set
         {
            this.hazardAreaPoint = value;
            this.hazardAreaPoint = new  PointType[value.Length];
            value.CopyTo(this.hazardAreaPoint, 0);
            _length_hazardAreaPoint = value.Length;
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

               // contaminationLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.contaminationLevel = new  RomeoType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.contaminationLevel.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // hazardLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.hazardLevel = new  HazardLevelType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.hazardLevel.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // hazardAreaPoint
               this.hazardAreaPoint = new  PointType[50];
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.hazardAreaPoint[_length_hazardAreaPoint] = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.hazardAreaPoint[_length_hazardAreaPoint].decode(reader, xbContext, false, false);
                  _length_hazardAreaPoint++;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4 && _length_hazardAreaPoint < 50) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( _length_hazardAreaPoint < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(_length_hazardAreaPoint, "hazardAreaPoint");
               else if (_length_hazardAreaPoint == 0 && moreContent_4) 
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

         // contaminationLevel
         if (this.contaminationLevel != null)  {
            encoder.encodeStartElement("contaminationLevel", "", "");
            this.contaminationLevel.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // hazardLevel
         if (this.hazardLevel != null)  {
            encoder.encodeStartElement("hazardLevel", "", "");
            this.hazardLevel.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // hazardAreaPoint
         if (this.hazardAreaPoint == null || _length_hazardAreaPoint < 1 || 
            50 < _length_hazardAreaPoint) 
            throw new XBOccurrencesException( (this.hazardAreaPoint == null ? 0 : _length_hazardAreaPoint ) );

         for (int i = 0; i < _length_hazardAreaPoint; i++) {
            encoder.encodeStartElement("hazardAreaPoint", "", "");
            this.hazardAreaPoint[i].encode(encoder, xbContext, null, false);
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

   public class XraybType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "XraybType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","contaminationLevel"),
         new XBQualifiedName("","hazardLevel"),
         new XBQualifiedName("","probability"),
         new XBQualifiedName("","hazardAreaPoint")
      };
      static XraybType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  RomeoType contaminationLevel;   //optional
      protected  HazardLevelType hazardLevel;   //optional
      protected double probability;
      protected  PointType[] hazardAreaPoint;
      protected int _length_hazardAreaPoint = 0;

      //attribute methods

      //content methods

      public  RomeoType ContaminationLevel
      {
         get
         {
            if (this.contaminationLevel == null)
                throw new XBException("field contaminationLevel not set");

            return this.contaminationLevel;
         }
         set
         {
            this.contaminationLevel = value;
         }
      }

      public  HazardLevelType HazardLevel
      {
         get
         {
            if (this.hazardLevel == null)
                throw new XBException("field hazardLevel not set");

            return this.hazardLevel;
         }
         set
         {
            this.hazardLevel = value;
         }
      }

      public double Probability
      {
         get { return this.probability; }
         set { this.probability = value; }
      }

      public  PointType[] HazardAreaPoint
      {
         get
         {
            if (this.hazardAreaPoint == null)
                throw new XBException("field hazardAreaPoint not set");

             PointType[] 
               arrCopy = new  PointType[_length_hazardAreaPoint];
            Array.Copy(this.hazardAreaPoint, arrCopy, _length_hazardAreaPoint);
            return arrCopy;
         }
         set
         {
            this.hazardAreaPoint = value;
            this.hazardAreaPoint = new  PointType[value.Length];
            value.CopyTo(this.hazardAreaPoint, 0);
            _length_hazardAreaPoint = value.Length;
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

               // contaminationLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.contaminationLevel = new  RomeoType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.contaminationLevel.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // hazardLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.hazardLevel = new  HazardLevelType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.hazardLevel.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // probability
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.probability =  RatioType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "probability");

               // hazardAreaPoint
               this.hazardAreaPoint = new  PointType[50];
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.hazardAreaPoint[_length_hazardAreaPoint] = new  PointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.hazardAreaPoint[_length_hazardAreaPoint].decode(reader, xbContext, false, false);
                  _length_hazardAreaPoint++;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4 && _length_hazardAreaPoint < 50) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( _length_hazardAreaPoint < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(_length_hazardAreaPoint, "hazardAreaPoint");
               else if (_length_hazardAreaPoint == 0 && moreContent_4) 
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

         // contaminationLevel
         if (this.contaminationLevel != null)  {
            encoder.encodeStartElement("contaminationLevel", "", "");
            this.contaminationLevel.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // hazardLevel
         if (this.hazardLevel != null)  {
            encoder.encodeStartElement("hazardLevel", "", "");
            this.hazardLevel.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // probability
         encoder.encodeStartElement("probability", "", "");
         String text_3;
         text_3 =  RatioType.encode(this.probability, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // hazardAreaPoint
         if (this.hazardAreaPoint == null || _length_hazardAreaPoint < 1 || 
            50 < _length_hazardAreaPoint) 
            throw new XBOccurrencesException( (this.hazardAreaPoint == null ? 0 : _length_hazardAreaPoint ) );

         for (int i = 0; i < _length_hazardAreaPoint; i++) {
            encoder.encodeStartElement("hazardAreaPoint", "", "");
            this.hazardAreaPoint[i].encode(encoder, xbContext, null, false);
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

   public class XraymType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "XraymType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","downwindDirection"),
         new XBQualifiedName("","windSpeed"),
         new XBQualifiedName("","airStabilityCategory"),
         new XBQualifiedName("","airTemperature"),
         new XBQualifiedName("","relativeHumidity"),
         new XBQualifiedName("","significantWeatherPhenomena"),
         new XBQualifiedName("","cloudCoverage")
      };
      static XraymType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double downwindDirection;
      protected short windSpeed;
      protected int airStabilityCategory;
      protected sbyte airTemperature;
      protected int relativeHumidity;
      protected int significantWeatherPhenomena;
      protected int cloudCoverage;

      //attribute methods

      //content methods

      public double DownwindDirection
      {
         get { return this.downwindDirection; }
         set { this.downwindDirection = value; }
      }

      public short WindSpeed
      {
         get { return this.windSpeed; }
         set { this.windSpeed = value; }
      }

      public int AirStabilityCategory
      {
         get { return this.airStabilityCategory; }
         set { this.airStabilityCategory = value; }
      }

      public sbyte AirTemperature
      {
         get { return this.airTemperature; }
         set { this.airTemperature = value; }
      }

      public int RelativeHumidity
      {
         get { return this.relativeHumidity; }
         set { this.relativeHumidity = value; }
      }

      public int SignificantWeatherPhenomena
      {
         get { return this.significantWeatherPhenomena; }
         set { this.significantWeatherPhenomena = value; }
      }

      public int CloudCoverage
      {
         get { return this.cloudCoverage; }
         set { this.cloudCoverage = value; }
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

               // downwindDirection
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.downwindDirection =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "downwindDirection");

               // windSpeed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.windSpeed =  SpeedType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "windSpeed");

               // airStabilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airStabilityCategory =  AirStabilityCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airStabilityCategory");

               // airTemperature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airTemperature =  IntMinus63To63Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airTemperature");

               // relativeHumidity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.relativeHumidity =  RelativeHumidityRangeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "relativeHumidity");

               // significantWeatherPhenomena
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.significantWeatherPhenomena =  SignificantWeatherPhenomenaCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "significantWeatherPhenomena");

               // cloudCoverage
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudCoverage =  CloudCoverageCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "cloudCoverage");

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

         // downwindDirection
         encoder.encodeStartElement("downwindDirection", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.downwindDirection, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // windSpeed
         encoder.encodeStartElement("windSpeed", "", "");
         text_3 =  SpeedType.encode(this.windSpeed, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airStabilityCategory
         encoder.encodeStartElement("airStabilityCategory", "", "");
         text_3 =  AirStabilityCategoryCode.encode(this.airStabilityCategory, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airTemperature
         encoder.encodeStartElement("airTemperature", "", "");
         text_3 =  IntMinus63To63Type.encode(this.airTemperature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // relativeHumidity
         encoder.encodeStartElement("relativeHumidity", "", "");
         text_3 =  RelativeHumidityRangeCode.encode(this.relativeHumidity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // significantWeatherPhenomena
         encoder.encodeStartElement("significantWeatherPhenomena", "", "");
         text_3 =  SignificantWeatherPhenomenaCode.encode(this.significantWeatherPhenomena, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // cloudCoverage
         encoder.encodeStartElement("cloudCoverage", "", "");
         text_3 =  CloudCoverageCode.encode(this.cloudCoverage, xbContext);
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

   public class YankeemType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "YankeemType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","downwindDirection"),
         new XBQualifiedName("","windSpeed"),
         new XBQualifiedName("","airStabilityCategory"),
         new XBQualifiedName("","airTemperature"),
         new XBQualifiedName("","relativeHumidity"),
         new XBQualifiedName("","significantWeatherPhenomena"),
         new XBQualifiedName("","cloudCoverage")
      };
      static YankeemType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double downwindDirection;
      protected short windSpeed;
      protected int airStabilityCategory;
      protected sbyte airTemperature;
      protected int relativeHumidity;
      protected int significantWeatherPhenomena;
      protected int cloudCoverage;

      //attribute methods

      //content methods

      public double DownwindDirection
      {
         get { return this.downwindDirection; }
         set { this.downwindDirection = value; }
      }

      public short WindSpeed
      {
         get { return this.windSpeed; }
         set { this.windSpeed = value; }
      }

      public int AirStabilityCategory
      {
         get { return this.airStabilityCategory; }
         set { this.airStabilityCategory = value; }
      }

      public sbyte AirTemperature
      {
         get { return this.airTemperature; }
         set { this.airTemperature = value; }
      }

      public int RelativeHumidity
      {
         get { return this.relativeHumidity; }
         set { this.relativeHumidity = value; }
      }

      public int SignificantWeatherPhenomena
      {
         get { return this.significantWeatherPhenomena; }
         set { this.significantWeatherPhenomena = value; }
      }

      public int CloudCoverage
      {
         get { return this.cloudCoverage; }
         set { this.cloudCoverage = value; }
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

               // downwindDirection
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.downwindDirection =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "downwindDirection");

               // windSpeed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.windSpeed =  SpeedType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "windSpeed");

               // airStabilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airStabilityCategory =  AirStabilityCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airStabilityCategory");

               // airTemperature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airTemperature =  IntMinus63To63Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airTemperature");

               // relativeHumidity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.relativeHumidity =  RelativeHumidityRangeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "relativeHumidity");

               // significantWeatherPhenomena
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.significantWeatherPhenomena =  SignificantWeatherPhenomenaCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "significantWeatherPhenomena");

               // cloudCoverage
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudCoverage =  CloudCoverageCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "cloudCoverage");

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

         // downwindDirection
         encoder.encodeStartElement("downwindDirection", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.downwindDirection, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // windSpeed
         encoder.encodeStartElement("windSpeed", "", "");
         text_3 =  SpeedType.encode(this.windSpeed, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airStabilityCategory
         encoder.encodeStartElement("airStabilityCategory", "", "");
         text_3 =  AirStabilityCategoryCode.encode(this.airStabilityCategory, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airTemperature
         encoder.encodeStartElement("airTemperature", "", "");
         text_3 =  IntMinus63To63Type.encode(this.airTemperature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // relativeHumidity
         encoder.encodeStartElement("relativeHumidity", "", "");
         text_3 =  RelativeHumidityRangeCode.encode(this.relativeHumidity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // significantWeatherPhenomena
         encoder.encodeStartElement("significantWeatherPhenomena", "", "");
         text_3 =  SignificantWeatherPhenomenaCode.encode(this.significantWeatherPhenomena, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // cloudCoverage
         encoder.encodeStartElement("cloudCoverage", "", "");
         text_3 =  CloudCoverageCode.encode(this.cloudCoverage, xbContext);
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

   public class YankeeType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "YankeeType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","downwindDirection"),
         new XBQualifiedName("","windSpeed")
      };
      static YankeeType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double downwindDirection;
      protected short windSpeed;

      //attribute methods

      //content methods

      public double DownwindDirection
      {
         get { return this.downwindDirection; }
         set { this.downwindDirection = value; }
      }

      public short WindSpeed
      {
         get { return this.windSpeed; }
         set { this.windSpeed = value; }
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

               // downwindDirection
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.downwindDirection =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "downwindDirection");

               // windSpeed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.windSpeed =  SpeedType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "windSpeed");

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

         // downwindDirection
         encoder.encodeStartElement("downwindDirection", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.downwindDirection, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // windSpeed
         encoder.encodeStartElement("windSpeed", "", "");
         text_3 =  SpeedType.encode(this.windSpeed, xbContext);
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

   public class ZulumType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "ZulumType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","observationDatetime"),
         new XBQualifiedName("","validityPeriod")
      };
      static ZulumType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string observationDatetime;
      protected  PeriodType validityPeriod;

      //attribute methods

      //content methods

      public string ObservationDatetime
      {
         get { return this.observationDatetime; }
         set { this.observationDatetime = value; }
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

               // observationDatetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.observationDatetime = text;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "observationDatetime");

               // validityPeriod
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.validityPeriod = new  PeriodType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.validityPeriod.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "validityPeriod");

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

         // observationDatetime
         encoder.encodeStartElement("observationDatetime", "", "");
         String text_3;
         text_3 = this.observationDatetime;
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // validityPeriod
         if (this.validityPeriod == null)
             throw new XBException("field validityPeriod not set");

         encoder.encodeStartElement("validityPeriod", "", "");
         this.validityPeriod.encode(encoder, xbContext, null, false);
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

   public class ZuluType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:cbrn",
          "ZuluType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","airStabilityCategory"),
         new XBQualifiedName("","airTemperature"),
         new XBQualifiedName("","relativeHumidity"),
         new XBQualifiedName("","significantWeatherPhenomena"),
         new XBQualifiedName("","cloudCoverage")
      };
      static ZuluType() {
         XBUtil.license =  _Cbrn.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int airStabilityCategory;
      protected sbyte airTemperature;
      protected int relativeHumidity;
      protected int significantWeatherPhenomena;
      protected int cloudCoverage;

      //attribute methods

      //content methods

      public int AirStabilityCategory
      {
         get { return this.airStabilityCategory; }
         set { this.airStabilityCategory = value; }
      }

      public sbyte AirTemperature
      {
         get { return this.airTemperature; }
         set { this.airTemperature = value; }
      }

      public int RelativeHumidity
      {
         get { return this.relativeHumidity; }
         set { this.relativeHumidity = value; }
      }

      public int SignificantWeatherPhenomena
      {
         get { return this.significantWeatherPhenomena; }
         set { this.significantWeatherPhenomena = value; }
      }

      public int CloudCoverage
      {
         get { return this.cloudCoverage; }
         set { this.cloudCoverage = value; }
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

               // airStabilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airStabilityCategory =  AirStabilityCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airStabilityCategory");

               // airTemperature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airTemperature =  IntMinus63To63Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "airTemperature");

               // relativeHumidity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.relativeHumidity =  RelativeHumidityRangeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "relativeHumidity");

               // significantWeatherPhenomena
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.significantWeatherPhenomena =  SignificantWeatherPhenomenaCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "significantWeatherPhenomena");

               // cloudCoverage
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.cloudCoverage =  CloudCoverageCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "cloudCoverage");

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

         // airStabilityCategory
         encoder.encodeStartElement("airStabilityCategory", "", "");
         String text_3;
         text_3 =  AirStabilityCategoryCode.encode(this.airStabilityCategory, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // airTemperature
         encoder.encodeStartElement("airTemperature", "", "");
         text_3 =  IntMinus63To63Type.encode(this.airTemperature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // relativeHumidity
         encoder.encodeStartElement("relativeHumidity", "", "");
         text_3 =  RelativeHumidityRangeCode.encode(this.relativeHumidity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // significantWeatherPhenomena
         encoder.encodeStartElement("significantWeatherPhenomena", "", "");
         text_3 =  SignificantWeatherPhenomenaCode.encode(this.significantWeatherPhenomena, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // cloudCoverage
         encoder.encodeStartElement("cloudCoverage", "", "");
         text_3 =  CloudCoverageCode.encode(this.cloudCoverage, xbContext);
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
   /**
    * This file was generated by the Objective Systems XBinder(tm) Compiler
    * (http://www.obj-sys.com).  Version: 2.7.0, Date: 19-Jun-2022.
    * Copyright (c) 2003-2021 Objective Systems, Inc.
    *
    * Permission is hereby granted to redistribute this file with the
    * condition that this copyright notice be present and not altered.
    */

   public class _Cbrn {

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
      public static readonly String NS_URI = "urn:fra:nc1:common:cbrn";
      public static readonly String NS_PREFIX = "nc1cbrn";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _Cbrn() {
      }
      static _Cbrn() {
         XBUtil.license = _Cbrn.license;
      }
   }
}
