using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Obj.missionASS
{

   using System.IO;
   using System.Xml;
   using com.objsys.xbinder.runtime;
    using NC1.Dictionnaries;
   public class CaliberCategoryCode
   {
      static CaliberCategoryCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private CaliberCategoryCode() {} 


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

   public class LoadTypeCode
   {
      static LoadTypeCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private LoadTypeCode() {} 


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

   public class AllocatedConsumptionType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "AllocatedConsumptionType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","caliber"),
         new XBQualifiedName("","otherCaliber"),
         new XBQualifiedName("","loadType"),
         new XBQualifiedName("","allowedAmmo"),
         new XBQualifiedName("","usedAmmo")
      };
      static AllocatedConsumptionType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int caliber;
      protected string otherCaliber;
      protected bool _set_otherCaliber = false;
      protected int loadType;
      protected ushort allowedAmmo;
      protected ushort usedAmmo;
      protected bool _set_usedAmmo = false;

      //attribute methods

      //content methods

      public int Caliber
      {
         get { return this.caliber; }
         set { this.caliber = value; }
      }

      public string OtherCaliber
      {
         get
         {
            if (!_set_otherCaliber)
                throw new XBException("field otherCaliber not set");

            return this.otherCaliber;
         }
         set
         {
            this.otherCaliber = value;
            _set_otherCaliber = true;
         }
      }

      public int LoadType
      {
         get { return this.loadType; }
         set { this.loadType = value; }
      }

      public ushort AllowedAmmo
      {
         get { return this.allowedAmmo; }
         set { this.allowedAmmo = value; }
      }

      public ushort UsedAmmo
      {
         get
         {
            if (!_set_usedAmmo)
                throw new XBException("field usedAmmo not set");

            return this.usedAmmo;
         }
         set
         {
            this.usedAmmo = value;
            _set_usedAmmo = true;
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

               // caliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.caliber =  CaliberCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "caliber");

               // otherCaliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherCaliber =  ShortTextObjectType.decode(text, xbContext);

                  _set_otherCaliber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // loadType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.loadType =  LoadTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "loadType");

               // allowedAmmo
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.allowedAmmo =  Int0To9999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "allowedAmmo");

               // usedAmmo
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.usedAmmo =  Int0To9999Type.decode(text, xbContext);

                  _set_usedAmmo = true;

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

         // caliber
         encoder.encodeStartElement("caliber", "", "");
         String text_3;
         text_3 =  CaliberCategoryCode.encode(this.caliber, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherCaliber
         if (_set_otherCaliber)  {
            encoder.encodeStartElement("otherCaliber", "", "");
            text_3 =  ShortTextObjectType.encode(this.otherCaliber, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // loadType
         encoder.encodeStartElement("loadType", "", "");
         text_3 =  LoadTypeCode.encode(this.loadType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // allowedAmmo
         encoder.encodeStartElement("allowedAmmo", "", "");
         text_3 =  Int0To9999Type.encode(this.allowedAmmo, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // usedAmmo
         if (_set_usedAmmo)  {
            encoder.encodeStartElement("usedAmmo", "", "");
            text_3 =  Int0To9999Type.encode(this.usedAmmo, xbContext);
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

   public class AllottedQuantityType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "AllottedQuantityType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","plannedQuantity"),
         new XBQualifiedName("","opportunityQuantity")
      };
      static AllottedQuantityType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected ushort plannedQuantity;
      protected ushort opportunityQuantity;

      //attribute methods

      //content methods

      public ushort PlannedQuantity
      {
         get { return this.plannedQuantity; }
         set { this.plannedQuantity = value; }
      }

      public ushort OpportunityQuantity
      {
         get { return this.opportunityQuantity; }
         set { this.opportunityQuantity = value; }
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

               // plannedQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.plannedQuantity =  Int0To9999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "plannedQuantity");

               // opportunityQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.opportunityQuantity =  Int0To9999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "opportunityQuantity");

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

         // plannedQuantity
         encoder.encodeStartElement("plannedQuantity", "", "");
         String text_3;
         text_3 =  Int0To9999Type.encode(this.plannedQuantity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // opportunityQuantity
         encoder.encodeStartElement("opportunityQuantity", "", "");
         text_3 =  Int0To9999Type.encode(this.opportunityQuantity, xbContext);
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

   public class BatteryPriorityCode
   {
      static BatteryPriorityCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private BatteryPriorityCode() {} 


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

   public class ConsumptionType_4
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ConsumptionType_4");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","globalAmmo"),
         new XBQualifiedName("","allottedAmmo")
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
         None, globalAmmo, allottedAmmo}
      protected Choice _whichField;
      static ConsumptionType_4() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected ushort globalAmmo;
      protected  AllottedQuantityType allottedAmmo;

      //content methods

      public ushort GlobalAmmo
      {
         get
         {
            if (_whichField != Choice.globalAmmo ) 
               throw new XBException("field globalAmmo not set");
            return this.globalAmmo;
         }
         set
         {
            this.globalAmmo = value;
            _whichField = Choice.globalAmmo;
         }
      }

      public  AllottedQuantityType AllottedAmmo
      {
         get
         {
            if (_whichField != Choice.allottedAmmo ) 
               throw new XBException("field allottedAmmo not set");
            return this.allottedAmmo;
         }
         set
         {
            this.allottedAmmo = value;
            _whichField = Choice.allottedAmmo;
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

            // globalAmmo
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.globalAmmo =  Int0To9999Type.decode(text, xbContext);
               _whichField = Choice.globalAmmo;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // allottedAmmo
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.allottedAmmo = new  AllottedQuantityType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.allottedAmmo.decode(reader, xbContext, false, false);
               _whichField = Choice.allottedAmmo;

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

            // globalAmmo
            case Choice.globalAmmo: {
               if (_whichField != Choice.globalAmmo ) 
                  throw new XBException("field globalAmmo not set");
               encoder.encodeStartElement("globalAmmo", "", "");
               String text_5;
               text_5 =  Int0To9999Type.encode(this.globalAmmo, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
               break;
            }

            // allottedAmmo
            case Choice.allottedAmmo: {
               if (_whichField != Choice.allottedAmmo ) 
                  throw new XBException("field allottedAmmo not set");
               encoder.encodeStartElement("allottedAmmo", "", "");
               this.allottedAmmo.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class ConsumptionType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ConsumptionType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","caliber"),
         new XBQualifiedName("","otherCaliber"),
         new XBQualifiedName("","loadType")
      };
      static ConsumptionType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int caliber;
      protected string otherCaliber;
      protected bool _set_otherCaliber = false;
      protected int loadType;
      protected  ConsumptionType_4 consumptionType_4;

      //attribute methods

      //content methods

      public int Caliber
      {
         get { return this.caliber; }
         set { this.caliber = value; }
      }

      public string OtherCaliber
      {
         get
         {
            if (!_set_otherCaliber)
                throw new XBException("field otherCaliber not set");

            return this.otherCaliber;
         }
         set
         {
            this.otherCaliber = value;
            _set_otherCaliber = true;
         }
      }

      public int LoadType
      {
         get { return this.loadType; }
         set { this.loadType = value; }
      }

      public  ConsumptionType_4 ConsumptionType_4
      {
         get
         {
            if (this.consumptionType_4 == null)
                throw new XBException("field consumptionType_4 not set");

            return this.consumptionType_4;
         }
         set
         {
            this.consumptionType_4 = value;
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

               // caliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.caliber =  CaliberCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "caliber");

               // otherCaliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherCaliber =  ShortTextObjectType.decode(text, xbContext);

                  _set_otherCaliber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // loadType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.loadType =  LoadTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "loadType");

               // consumptionType_4
               if( moreContent_4 && 
                   ConsumptionType_4.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.consumptionType_4 = new  ConsumptionType_4();
                  this.consumptionType_4.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "consumptionType_4");

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

         // caliber
         encoder.encodeStartElement("caliber", "", "");
         String text_3;
         text_3 =  CaliberCategoryCode.encode(this.caliber, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherCaliber
         if (_set_otherCaliber)  {
            encoder.encodeStartElement("otherCaliber", "", "");
            text_3 =  ShortTextObjectType.encode(this.otherCaliber, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // loadType
         encoder.encodeStartElement("loadType", "", "");
         text_3 =  LoadTypeCode.encode(this.loadType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // consumptionType_4
         if (this.consumptionType_4 == null)
             throw new XBException("field consumptionType_4 not set");

         this.consumptionType_4.encode(encoder, xbContext);
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

   public class SearchedEffectCode
   {
      static SearchedEffectCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private SearchedEffectCode() {} 


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

   public class ContactEffectType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ContactEffectType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","supportUnitId"),
         new XBQualifiedName("","effectType"),
         new XBQualifiedName("","otherEffect")
      };
      static ContactEffectType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType supportUnitId;
      protected int effectType;
      protected string otherEffect;
      protected bool _set_otherEffect = false;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType SupportUnitId
      {
         get
         {
            if (this.supportUnitId == null)
                throw new XBException("field supportUnitId not set");

            return this.supportUnitId;
         }
         set
         {
            this.supportUnitId = value;
         }
      }

      public int EffectType
      {
         get { return this.effectType; }
         set { this.effectType = value; }
      }

      public string OtherEffect
      {
         get
         {
            if (!_set_otherEffect)
                throw new XBException("field otherEffect not set");

            return this.otherEffect;
         }
         set
         {
            this.otherEffect = value;
            _set_otherEffect = true;
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

               // supportUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.supportUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.supportUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "supportUnitId");

               // effectType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.effectType =  SearchedEffectCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "effectType");

               // otherEffect
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherEffect =  MediumTextObjectType.decode(text, xbContext);

                  _set_otherEffect = true;

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

         // supportUnitId
         if (this.supportUnitId == null)
             throw new XBException("field supportUnitId not set");

         encoder.encodeStartElement("supportUnitId", "", "");
         this.supportUnitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // effectType
         encoder.encodeStartElement("effectType", "", "");
         String text_3;
         text_3 =  SearchedEffectCode.encode(this.effectType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherEffect
         if (_set_otherEffect)  {
            encoder.encodeStartElement("otherEffect", "", "");
            text_3 =  MediumTextObjectType.encode(this.otherEffect, xbContext);
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

   public class EffectByAreaType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "EffectByAreaType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","areaId"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","searchedEffectType"),
         new XBQualifiedName("","otherEffect")
      };
      static EffectByAreaType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType areaId;
      protected  PeriodType validityPeriod;   //optional
      protected int searchedEffectType;
      protected string otherEffect;
      protected bool _set_otherEffect = false;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType AreaId
      {
         get
         {
            if (this.areaId == null)
                throw new XBException("field areaId not set");

            return this.areaId;
         }
         set
         {
            this.areaId = value;
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

      public int SearchedEffectType
      {
         get { return this.searchedEffectType; }
         set { this.searchedEffectType = value; }
      }

      public string OtherEffect
      {
         get
         {
            if (!_set_otherEffect)
                throw new XBException("field otherEffect not set");

            return this.otherEffect;
         }
         set
         {
            this.otherEffect = value;
            _set_otherEffect = true;
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

               // areaId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.areaId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.areaId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "areaId");

               // validityPeriod
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
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

               // searchedEffectType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.searchedEffectType =  SearchedEffectCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "searchedEffectType");

               // otherEffect
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherEffect =  MediumTextObjectType.decode(text, xbContext);

                  _set_otherEffect = true;

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

         // areaId
         if (this.areaId == null)
             throw new XBException("field areaId not set");

         encoder.encodeStartElement("areaId", "", "");
         this.areaId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // validityPeriod
         if (this.validityPeriod != null)  {
            encoder.encodeStartElement("validityPeriod", "", "");
            this.validityPeriod.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // searchedEffectType
         encoder.encodeStartElement("searchedEffectType", "", "");
         String text_3;
         text_3 =  SearchedEffectCode.encode(this.searchedEffectType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherEffect
         if (_set_otherEffect)  {
            encoder.encodeStartElement("otherEffect", "", "");
            text_3 =  MediumTextObjectType.encode(this.otherEffect, xbContext);
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

   public class TypeBatteryCode
   {
      static TypeBatteryCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private TypeBatteryCode() {} 


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

   public class SubTypeBatteryCode
   {
      static SubTypeBatteryCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private SubTypeBatteryCode() {} 


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

   public class EquipmentPriorityType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "EquipmentPriorityType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","priorityId"),
         new XBQualifiedName("","type"),
         new XBQualifiedName("","subType"),
         new XBQualifiedName("","priority")
      };
      static EquipmentPriorityType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string priorityId;
      protected int type;
      protected int subType;
      protected int priority;

      //attribute methods

      //content methods

      public string PriorityId
      {
         get { return this.priorityId; }
         set { this.priorityId = value; }
      }

      public int Type
      {
         get { return this.type; }
         set { this.type = value; }
      }

      public int SubType
      {
         get { return this.subType; }
         set { this.subType = value; }
      }

      public int Priority
      {
         get { return this.priority; }
         set { this.priority = value; }
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

               // priorityId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.priorityId =  ShortTextObjectType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "priorityId");

               // type
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.type =  TypeBatteryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "type");

               // subType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.subType =  SubTypeBatteryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "subType");

               // priority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.priority =  BatteryPriorityCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "priority");

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

         // priorityId
         encoder.encodeStartElement("priorityId", "", "");
         String text_3;
         text_3 =  ShortTextObjectType.encode(this.priorityId, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // type
         encoder.encodeStartElement("type", "", "");
         text_3 =  TypeBatteryCode.encode(this.type, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // subType
         encoder.encodeStartElement("subType", "", "");
         text_3 =  SubTypeBatteryCode.encode(this.subType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // priority
         encoder.encodeStartElement("priority", "", "");
         text_3 =  BatteryPriorityCode.encode(this.priority, xbContext);
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

   public class FireUnitDescriptionType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "FireUnitDescriptionType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","caliber"),
         new XBQualifiedName("","otherCaliber"),
         new XBQualifiedName("","unitType"),
         new XBQualifiedName("","allowedAmmo"),
         new XBQualifiedName("","comment")
      };
      static FireUnitDescriptionType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int caliber;
      protected string otherCaliber;
      protected bool _set_otherCaliber = false;
      protected string unitType;
      protected uint allowedAmmo;
      protected string comment;
      protected bool _set_comment = false;

      //attribute methods

      //content methods

      public int Caliber
      {
         get { return this.caliber; }
         set { this.caliber = value; }
      }

      public string OtherCaliber
      {
         get
         {
            if (!_set_otherCaliber)
                throw new XBException("field otherCaliber not set");

            return this.otherCaliber;
         }
         set
         {
            this.otherCaliber = value;
            _set_otherCaliber = true;
         }
      }

      public string UnitType
      {
         get { return this.unitType; }
         set { this.unitType = value; }
      }

      public uint AllowedAmmo
      {
         get { return this.allowedAmmo; }
         set { this.allowedAmmo = value; }
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

               // caliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.caliber =  CaliberCategoryCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "caliber");

               // otherCaliber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherCaliber =  ShortTextObjectType.decode(text, xbContext);

                  _set_otherCaliber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // unitType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.unitType =  SymbolCodeType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "unitType");

               // allowedAmmo
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.allowedAmmo =  Int0To99999Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "allowedAmmo");

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  MediumTextObjectType.decode(text, xbContext);

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

         // caliber
         encoder.encodeStartElement("caliber", "", "");
         String text_3;
         text_3 =  CaliberCategoryCode.encode(this.caliber, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherCaliber
         if (_set_otherCaliber)  {
            encoder.encodeStartElement("otherCaliber", "", "");
            text_3 =  ShortTextObjectType.encode(this.otherCaliber, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // unitType
         encoder.encodeStartElement("unitType", "", "");
         text_3 =  SymbolCodeType.encode(this.unitType, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // allowedAmmo
         encoder.encodeStartElement("allowedAmmo", "", "");
         text_3 =  Int0To99999Type.encode(this.allowedAmmo, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            text_3 =  MediumTextObjectType.encode(this.comment, xbContext);
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

   public class FormationType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "FormationType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","rank"),
         new XBQualifiedName("","function")
      };
      static FormationType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string rank;
      protected string function;

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

      public string Rank
      {
         get { return this.rank; }
         set { this.rank = value; }
      }

      public string Function
      {
         get { return this.function; }
         set { this.function = value; }
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
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "unitId");

               // rank
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.rank =  MediumTextObjectType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "rank");

               // function
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.function =  MediumTextObjectType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "function");

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

         // unitId
         if (this.unitId == null)
             throw new XBException("field unitId not set");

         encoder.encodeStartElement("unitId", "", "");
         this.unitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // rank
         encoder.encodeStartElement("rank", "", "");
         String text_3;
         text_3 =  MediumTextObjectType.encode(this.rank, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // function
         encoder.encodeStartElement("function", "", "");
         text_3 =  MediumTextObjectType.encode(this.function, xbContext);
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

   public class IntelligenceActionPriorityCode
   {
      static IntelligenceActionPriorityCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private IntelligenceActionPriorityCode() {} 


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

   public class IntelligenceTypeCode
   {
      static IntelligenceTypeCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private IntelligenceTypeCode() {} 


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

   public class SupplyPeriodType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "SupplyPeriodType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","firstSupply"),
         new XBQualifiedName("","supplyCycle")
      };
      static SupplyPeriodType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string firstSupply;
      protected bool _set_firstSupply = false;
      protected ulong supplyCycle;
      protected bool _set_supplyCycle = false;

      //attribute methods

      //content methods

      public string FirstSupply
      {
         get
         {
            if (!_set_firstSupply)
                throw new XBException("field firstSupply not set");

            return this.firstSupply;
         }
         set
         {
            this.firstSupply = value;
            _set_firstSupply = true;
         }
      }

      public ulong SupplyCycle
      {
         get
         {
            if (!_set_supplyCycle)
                throw new XBException("field supplyCycle not set");

            return this.supplyCycle;
         }
         set
         {
            this.supplyCycle = value;
            _set_supplyCycle = true;
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

               // firstSupply
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.firstSupply = text;

                  _set_firstSupply = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // supplyCycle
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.supplyCycle =  Int0To2147483647Type.decode(text, xbContext);

                  _set_supplyCycle = true;

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

         // firstSupply
         if (_set_firstSupply)  {
            encoder.encodeStartElement("firstSupply", "", "");
            String text_4;
            text_4 = this.firstSupply;
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // supplyCycle
         if (_set_supplyCycle)  {
            encoder.encodeStartElement("supplyCycle", "", "");
            String text_4;
            text_4 =  Int0To2147483647Type.encode(this.supplyCycle, xbContext);
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

   public class IntelTaskType_3
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "IntelTaskType_3");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","limitSupplyTime"),
         new XBQualifiedName("","cycleSupplyTime")
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
         None, limitSupplyTime, cycleSupplyTime}
      protected Choice _whichField;
      static IntelTaskType_3() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string limitSupplyTime;
      protected  SupplyPeriodType cycleSupplyTime;

      //content methods

      public string LimitSupplyTime
      {
         get
         {
            if (_whichField != Choice.limitSupplyTime ) 
               throw new XBException("field limitSupplyTime not set");
            return this.limitSupplyTime;
         }
         set
         {
            this.limitSupplyTime = value;
            _whichField = Choice.limitSupplyTime;
         }
      }

      public  SupplyPeriodType CycleSupplyTime
      {
         get
         {
            if (_whichField != Choice.cycleSupplyTime ) 
               throw new XBException("field cycleSupplyTime not set");
            return this.cycleSupplyTime;
         }
         set
         {
            this.cycleSupplyTime = value;
            _whichField = Choice.cycleSupplyTime;
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

            // limitSupplyTime
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               text = XBSimpleType.whitespaceCollapse(text);
               this.limitSupplyTime = text;
               _whichField = Choice.limitSupplyTime;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // cycleSupplyTime
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.cycleSupplyTime = new  SupplyPeriodType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.cycleSupplyTime.decode(reader, xbContext, false, false);
               _whichField = Choice.cycleSupplyTime;

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

            // limitSupplyTime
            case Choice.limitSupplyTime: {
               if (_whichField != Choice.limitSupplyTime ) 
                  throw new XBException("field limitSupplyTime not set");
               encoder.encodeStartElement("limitSupplyTime", "", "");
               String text_5;
               text_5 = this.limitSupplyTime;
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }

            // cycleSupplyTime
            case Choice.cycleSupplyTime: {
               if (_whichField != Choice.cycleSupplyTime ) 
                  throw new XBException("field cycleSupplyTime not set");
               encoder.encodeStartElement("cycleSupplyTime", "", "");
               this.cycleSupplyTime.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class TypeObservationCode
   {
      static TypeObservationCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private TypeObservationCode() {} 


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

   public class SearchedFactType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "SearchedFactType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ref"),
         new XBQualifiedName("","domain"),
         new XBQualifiedName("","searchedElement"),
         new XBQualifiedName("","isOfImmediateInterestIndicator"),
         new XBQualifiedName("","interestedAuthority"),
         new XBQualifiedName("","observationType")
      };
      static SearchedFactType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string ref_;
      protected int domain;
      protected string searchedElement;
      protected bool isOfImmediateInterestIndicator;
      protected System.Collections.Generic.IList< Nc1ObjectRefType> interestedAuthority;
         
      protected System.Collections.Generic.IList<Int32> observationType;

      //attribute methods

      //content methods

      public string Ref_
      {
         get { return this.ref_; }
         set { this.ref_ = value; }
      }

      public int Domain
      {
         get { return this.domain; }
         set { this.domain = value; }
      }

      public string SearchedElement
      {
         get { return this.searchedElement; }
         set { this.searchedElement = value; }
      }

      public bool IsOfImmediateInterestIndicator
      {
         get { return this.isOfImmediateInterestIndicator; }
         set { this.isOfImmediateInterestIndicator = value; }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> InterestedAuthority
      {
         get
         {
            if (this.interestedAuthority == null) {
               this.interestedAuthority = new List< Nc1ObjectRefType>();
            }
            return this.interestedAuthority;
         }
      }

      public System.Collections.Generic.IList<Int32> ObservationType
      {
         get
         {
            if (this.observationType == null) {
               this.observationType = new List<Int32>();
            }
            return this.observationType;
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

               // ref_
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.ref_ =  Text1To8ANType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "ref_");

               // domain
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.domain =  IntelligenceTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "domain");

               // searchedElement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.searchedElement =  MediumTextObjectType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "searchedElement");

               // isOfImmediateInterestIndicator
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isOfImmediateInterestIndicator = XBSimpleType.parseBoolean(text);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "isOfImmediateInterestIndicator");

               // interestedAuthority
               this.interestedAuthority = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_interestedAuthority;
                  _tmp_interestedAuthority = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_interestedAuthority.decode(reader, xbContext, false, false);
                  this.interestedAuthority.Add(_tmp_interestedAuthority);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.interestedAuthority.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.interestedAuthority.Count, "interestedAuthority");
               else if (this.interestedAuthority.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // observationType
               this.observationType = new List<Int32>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  int _tmp_observationType;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  _tmp_observationType =  TypeObservationCode.decode(text, xbContext);
                  this.observationType.Add(_tmp_observationType);

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

         // ref_
         encoder.encodeStartElement("ref", "", "");
         String text_3;
         text_3 =  Text1To8ANType.encode(this.ref_, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // domain
         encoder.encodeStartElement("domain", "", "");
         text_3 =  IntelligenceTypeCode.encode(this.domain, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // searchedElement
         encoder.encodeStartElement("searchedElement", "", "");
         text_3 =  MediumTextObjectType.encode(this.searchedElement, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // isOfImmediateInterestIndicator
         encoder.encodeStartElement("isOfImmediateInterestIndicator", "", "");
         text_3 = this.isOfImmediateInterestIndicator.ToString().ToLower();
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // interestedAuthority
         if (this.interestedAuthority == null || 
            this.interestedAuthority.Count < 1) 
            throw new XBOccurrencesException( (this.interestedAuthority == null ? 0 : this.interestedAuthority.Count ) );

         foreach ( Nc1ObjectRefType _tmp_interestedAuthority in this.interestedAuthority)
         {
            encoder.encodeStartElement("interestedAuthority", "", "");
            _tmp_interestedAuthority.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // observationType
         if ( this.observationType != null ){
            foreach (int _tmp_observationType in this.observationType){
               encoder.encodeStartElement("observationType", "", "");
               text_3 =  TypeObservationCode.encode(_tmp_observationType, xbContext);
               encoder.encodeCharsNoEscaping(text_3);
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

   public class IntelTaskType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "IntelTaskType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","prioriteAction"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","searchArea"),
         new XBQualifiedName("","searchedFact"),
         new XBQualifiedName("","clue")
      };
      static IntelTaskType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int prioriteAction;
      protected bool _set_prioriteAction = false;
      protected  PeriodType validityPeriod;   //optional
      protected  IntelTaskType_3 intelTaskType_3;
      protected  Nc1ObjectRefType searchArea;   //optional
      protected  SearchedFactType searchedFact;
      protected string clue;
      protected bool _set_clue = false;

      //attribute methods

      //content methods

      public int PrioriteAction
      {
         get
         {
            if (!_set_prioriteAction)
                throw new XBException("field prioriteAction not set");

            return this.prioriteAction;
         }
         set
         {
            this.prioriteAction = value;
            _set_prioriteAction = true;
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

      public  IntelTaskType_3 IntelTaskType_3
      {
         get
         {
            if (this.intelTaskType_3 == null)
                throw new XBException("field intelTaskType_3 not set");

            return this.intelTaskType_3;
         }
         set
         {
            this.intelTaskType_3 = value;
         }
      }

      public  Nc1ObjectRefType SearchArea
      {
         get
         {
            if (this.searchArea == null)
                throw new XBException("field searchArea not set");

            return this.searchArea;
         }
         set
         {
            this.searchArea = value;
         }
      }

      public  SearchedFactType SearchedFact
      {
         get
         {
            if (this.searchedFact == null)
                throw new XBException("field searchedFact not set");

            return this.searchedFact;
         }
         set
         {
            this.searchedFact = value;
         }
      }

      public string Clue
      {
         get
         {
            if (!_set_clue) throw new XBException("field clue not set");

            return this.clue;
         }
         set
         {
            this.clue = value;
            _set_clue = true;
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

               // prioriteAction
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.prioriteAction =  IntelligenceActionPriorityCode.decode(text, xbContext);

                  _set_prioriteAction = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // validityPeriod
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
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

               // intelTaskType_3
               if( moreContent_4 && 
                   IntelTaskType_3.acceptsElem(elemNs, elemLocalName) )
               {
                  this.intelTaskType_3 = new  IntelTaskType_3();
                  this.intelTaskType_3.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "intelTaskType_3");

               // searchArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.searchArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.searchArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // searchedFact
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.searchedFact = new  SearchedFactType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.searchedFact.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "searchedFact");

               // clue
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.clue =  MediumTextObjectType.decode(text, xbContext);

                  _set_clue = true;

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

         // prioriteAction
         if (_set_prioriteAction)  {
            encoder.encodeStartElement("prioriteAction", "", "");
            String text_4;
            text_4 =  IntelligenceActionPriorityCode.encode(this.prioriteAction, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // validityPeriod
         if (this.validityPeriod != null)  {
            encoder.encodeStartElement("validityPeriod", "", "");
            this.validityPeriod.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // intelTaskType_3
         if (this.intelTaskType_3 == null)
             throw new XBException("field intelTaskType_3 not set");

         this.intelTaskType_3.encode(encoder, xbContext);

         // searchArea
         if (this.searchArea != null)  {
            encoder.encodeStartElement("searchArea", "", "");
            this.searchArea.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // searchedFact
         if (this.searchedFact == null)
             throw new XBException("field searchedFact not set");

         encoder.encodeStartElement("searchedFact", "", "");
         this.searchedFact.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // clue
         if (_set_clue)  {
            encoder.encodeStartElement("clue", "", "");
            String text_4;
            text_4 =  MediumTextObjectType.encode(this.clue, xbContext);
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

   public class TargetTypeCode
   {
      static TargetTypeCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private TargetTypeCode() {} 


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

   public class SubTargetTypeCode
   {
      static SubTargetTypeCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private SubTargetTypeCode() {} 


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

   public class TacticalLevelCode
   {
      static TacticalLevelCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private TacticalLevelCode() {} 


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

   public class PriorityTargetType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "PriorityTargetType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","targetNature"),
         new XBQualifiedName("","subTargetNature"),
         new XBQualifiedName("","tacticalLevel")
      };
      static PriorityTargetType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int targetNature;
      protected int subTargetNature;
      protected int tacticalLevel;
      protected bool _set_tacticalLevel = false;

      //attribute methods

      //content methods

      public int TargetNature
      {
         get { return this.targetNature; }
         set { this.targetNature = value; }
      }

      public int SubTargetNature
      {
         get { return this.subTargetNature; }
         set { this.subTargetNature = value; }
      }

      public int TacticalLevel
      {
         get
         {
            if (!_set_tacticalLevel)
                throw new XBException("field tacticalLevel not set");

            return this.tacticalLevel;
         }
         set
         {
            this.tacticalLevel = value;
            _set_tacticalLevel = true;
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

               // targetNature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.targetNature =  TargetTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "targetNature");

               // subTargetNature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.subTargetNature =  SubTargetTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "subTargetNature");

               // tacticalLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.tacticalLevel =  TacticalLevelCode.decode(text, xbContext);

                  _set_tacticalLevel = true;

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

         // targetNature
         encoder.encodeStartElement("targetNature", "", "");
         String text_3;
         text_3 =  TargetTypeCode.encode(this.targetNature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // subTargetNature
         encoder.encodeStartElement("subTargetNature", "", "");
         text_3 =  SubTargetTypeCode.encode(this.subTargetNature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // tacticalLevel
         if (_set_tacticalLevel)  {
            encoder.encodeStartElement("tacticalLevel", "", "");
            text_3 =  TacticalLevelCode.encode(this.tacticalLevel, xbContext);
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

   public class MissionASSType_5_superiorFieldArtilleryMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_superiorFieldArtilleryMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","priorityTarget"),
         new XBQualifiedName("","fireSupportArea"),
         new XBQualifiedName("","searchedEffect"),
         new XBQualifiedName("","otherEffect")
      };
      static MissionASSType_5_superiorFieldArtilleryMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< PriorityTargetType> priorityTarget;
         
      protected  Nc1ObjectRefType fireSupportArea;
      protected System.Collections.Generic.IList<Int32> searchedEffect;
      protected string otherEffect;
      protected bool _set_otherEffect = false;

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< PriorityTargetType> PriorityTarget
      {
         get
         {
            if (this.priorityTarget == null) {
               this.priorityTarget = new List< PriorityTargetType>();
            }
            return this.priorityTarget;
         }
      }

      public  Nc1ObjectRefType FireSupportArea
      {
         get
         {
            if (this.fireSupportArea == null)
                throw new XBException("field fireSupportArea not set");

            return this.fireSupportArea;
         }
         set
         {
            this.fireSupportArea = value;
         }
      }

      public System.Collections.Generic.IList<Int32> SearchedEffect
      {
         get
         {
            if (this.searchedEffect == null) {
               this.searchedEffect = new List<Int32>();
            }
            return this.searchedEffect;
         }
      }

      public string OtherEffect
      {
         get
         {
            if (!_set_otherEffect)
                throw new XBException("field otherEffect not set");

            return this.otherEffect;
         }
         set
         {
            this.otherEffect = value;
            _set_otherEffect = true;
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

               // priorityTarget
               this.priorityTarget = new List< PriorityTargetType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   PriorityTargetType _tmp_priorityTarget;
                  _tmp_priorityTarget = new  PriorityTargetType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_priorityTarget.decode(reader, xbContext, false, false);
                  this.priorityTarget.Add(_tmp_priorityTarget);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.priorityTarget.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.priorityTarget.Count, "priorityTarget");
               else if (this.priorityTarget.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // fireSupportArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.fireSupportArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.fireSupportArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "fireSupportArea");

               // searchedEffect
               this.searchedEffect = new List<Int32>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  int _tmp_searchedEffect;
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  _tmp_searchedEffect =  SearchedEffectCode.decode(text, xbContext);
                  this.searchedEffect.Add(_tmp_searchedEffect);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // otherEffect
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherEffect =  ShortTextObjectType.decode(text, xbContext);

                  _set_otherEffect = true;

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

         // priorityTarget
         if (this.priorityTarget == null || this.priorityTarget.Count < 1) 
            throw new XBOccurrencesException( (this.priorityTarget == null ? 0 : this.priorityTarget.Count ) );

         foreach ( PriorityTargetType _tmp_priorityTarget in this.priorityTarget)
         {
            encoder.encodeStartElement("priorityTarget", "", "");
            _tmp_priorityTarget.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // fireSupportArea
         if (this.fireSupportArea == null)
             throw new XBException("field fireSupportArea not set");

         encoder.encodeStartElement("fireSupportArea", "", "");
         this.fireSupportArea.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // searchedEffect
         if ( this.searchedEffect != null ){
            foreach (int _tmp_searchedEffect in this.searchedEffect){
               encoder.encodeStartElement("searchedEffect", "", "");
               String text_5;
               text_5 =  SearchedEffectCode.encode(_tmp_searchedEffect, xbContext);
               encoder.encodeCharsNoEscaping(text_5);
               encoder.encodeEndElement();
            }
         }

         // otherEffect
         if (_set_otherEffect)  {
            encoder.encodeStartElement("otherEffect", "", "");
            String text_4;
            text_4 =  ShortTextObjectType.encode(this.otherEffect, xbContext);
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

   public class ObjectiveForcesType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ObjectiveForcesType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","comment")
      };
      static ObjectiveForcesType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string comment;
      protected bool _set_comment = false;

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
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "unitId");

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  MediumTextObjectType.decode(text, xbContext);

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

         // unitId
         if (this.unitId == null)
             throw new XBException("field unitId not set");

         encoder.encodeStartElement("unitId", "", "");
         this.unitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            String text_4;
            text_4 =  MediumTextObjectType.encode(this.comment, xbContext);
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

   public class ObjectifType_1
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ObjectifType_1");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","objectiveForces"),
         new XBQualifiedName("","areaId")
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
         None, objectiveForces, areaId}
      protected Choice _whichField;
      static ObjectifType_1() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  ObjectiveForcesType objectiveForces;
      protected  Nc1ObjectRefType areaId;

      //content methods

      public  ObjectiveForcesType ObjectiveForces
      {
         get
         {
            if (_whichField != Choice.objectiveForces ) 
               throw new XBException("field objectiveForces not set");
            return this.objectiveForces;
         }
         set
         {
            this.objectiveForces = value;
            _whichField = Choice.objectiveForces;
         }
      }

      public  Nc1ObjectRefType AreaId
      {
         get
         {
            if (_whichField != Choice.areaId ) 
               throw new XBException("field areaId not set");
            return this.areaId;
         }
         set
         {
            this.areaId = value;
            _whichField = Choice.areaId;
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

            // objectiveForces
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.objectiveForces = new  ObjectiveForcesType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.objectiveForces.decode(reader, xbContext, false, false);
               _whichField = Choice.objectiveForces;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // areaId
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.areaId = new  Nc1ObjectRefType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.areaId.decode(reader, xbContext, false, false);
               _whichField = Choice.areaId;

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

            // objectiveForces
            case Choice.objectiveForces: {
               if (_whichField != Choice.objectiveForces ) 
                  throw new XBException("field objectiveForces not set");
               encoder.encodeStartElement("objectiveForces", "", "");
               this.objectiveForces.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // areaId
            case Choice.areaId: {
               if (_whichField != Choice.areaId ) 
                  throw new XBException("field areaId not set");
               encoder.encodeStartElement("areaId", "", "");
               this.areaId.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class ObjectifType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "ObjectifType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {

      };
      static ObjectifType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  ObjectifType_1 objectifType_1;

      //attribute methods

      //content methods

      public  ObjectifType_1 ObjectifType_1
      {
         get
         {
            if (this.objectifType_1 == null)
                throw new XBException("field objectifType_1 not set");

            return this.objectifType_1;
         }
         set
         {
            this.objectifType_1 = value;
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

               // objectifType_1
               if( moreContent_4 && 
                   ObjectifType_1.acceptsElem(elemNs, elemLocalName) )
               {
                  this.objectifType_1 = new  ObjectifType_1();
                  this.objectifType_1.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "objectifType_1");

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

         // objectifType_1
         if (this.objectifType_1 == null)
             throw new XBException("field objectifType_1 not set");

         this.objectifType_1.encode(encoder, xbContext);
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

   public class MissionASSType_5_contactFieldArtilleryMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_contactFieldArtilleryMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","groundUnitId"),
         new XBQualifiedName("","priorityTarget"),
         new XBQualifiedName("","fireSupportArea"),
         new XBQualifiedName("","searchedEffect"),
         new XBQualifiedName("","consumption"),
         new XBQualifiedName("","immediatelyAvailable"),
         new XBQualifiedName("","delayedAvailable"),
         new XBQualifiedName("","notice"),
         new XBQualifiedName("","target")
      };
      static MissionASSType_5_contactFieldArtilleryMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType groundUnitId;
      protected System.Collections.Generic.IList< PriorityTargetType> priorityTarget;
         
      protected System.Collections.Generic.IList< Nc1ObjectRefType> fireSupportArea;
         
      protected System.Collections.Generic.IList< ContactEffectType> searchedEffect;
         
      protected System.Collections.Generic.IList< ConsumptionType> consumption;
         
      protected byte immediatelyAvailable;
      protected byte delayedAvailable;
      protected bool _set_delayedAvailable = false;
      protected ulong notice;
      protected bool _set_notice = false;
      protected  ObjectifType target;   //optional

      //attribute methods

      //content methods

      public  Nc1ObjectRefType GroundUnitId
      {
         get
         {
            if (this.groundUnitId == null)
                throw new XBException("field groundUnitId not set");

            return this.groundUnitId;
         }
         set
         {
            this.groundUnitId = value;
         }
      }

      public System.Collections.Generic.IList< PriorityTargetType> PriorityTarget
      {
         get
         {
            if (this.priorityTarget == null) {
               this.priorityTarget = new List< PriorityTargetType>();
            }
            return this.priorityTarget;
         }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> FireSupportArea
      {
         get
         {
            if (this.fireSupportArea == null) {
               this.fireSupportArea = new List< Nc1ObjectRefType>();
            }
            return this.fireSupportArea;
         }
      }

      public System.Collections.Generic.IList< ContactEffectType> SearchedEffect
      {
         get
         {
            if (this.searchedEffect == null) {
               this.searchedEffect = new List< ContactEffectType>();
            }
            return this.searchedEffect;
         }
      }

      public System.Collections.Generic.IList< ConsumptionType> Consumption
      {
         get
         {
            if (this.consumption == null) {
               this.consumption = new List< ConsumptionType>();
            }
            return this.consumption;
         }
      }

      public byte ImmediatelyAvailable
      {
         get { return this.immediatelyAvailable; }
         set { this.immediatelyAvailable = value; }
      }

      public byte DelayedAvailable
      {
         get
         {
            if (!_set_delayedAvailable)
                throw new XBException("field delayedAvailable not set");

            return this.delayedAvailable;
         }
         set
         {
            this.delayedAvailable = value;
            _set_delayedAvailable = true;
         }
      }

      public ulong Notice
      {
         get
         {
            if (!_set_notice) throw new XBException("field notice not set");

            return this.notice;
         }
         set
         {
            this.notice = value;
            _set_notice = true;
         }
      }

      public  ObjectifType Target
      {
         get
         {
            if (this.target == null)
                throw new XBException("field target not set");

            return this.target;
         }
         set
         {
            this.target = value;
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

               // groundUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.groundUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.groundUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "groundUnitId");

               // priorityTarget
               this.priorityTarget = new List< PriorityTargetType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   PriorityTargetType _tmp_priorityTarget;
                  _tmp_priorityTarget = new  PriorityTargetType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_priorityTarget.decode(reader, xbContext, false, false);
                  this.priorityTarget.Add(_tmp_priorityTarget);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.priorityTarget.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.priorityTarget.Count, "priorityTarget");
               else if (this.priorityTarget.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // fireSupportArea
               this.fireSupportArea = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_fireSupportArea;
                  _tmp_fireSupportArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_fireSupportArea.decode(reader, xbContext, false, false);
                  this.fireSupportArea.Add(_tmp_fireSupportArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // searchedEffect
               this.searchedEffect = new List< ContactEffectType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   ContactEffectType _tmp_searchedEffect;
                  _tmp_searchedEffect = new  ContactEffectType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_searchedEffect.decode(reader, xbContext, false, false);
                  this.searchedEffect.Add(_tmp_searchedEffect);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // consumption
               this.consumption = new List< ConsumptionType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   ConsumptionType _tmp_consumption;
                  _tmp_consumption = new  ConsumptionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_consumption.decode(reader, xbContext, false, false);
                  this.consumption.Add(_tmp_consumption);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.consumption.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.consumption.Count, "consumption");
               else if (this.consumption.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // immediatelyAvailable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.immediatelyAvailable =  Int0To99Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "immediatelyAvailable");

               // delayedAvailable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.delayedAvailable =  Int0To99Type.decode(text, xbContext);

                  _set_delayedAvailable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // notice
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.notice =  Int0To2147483647Type.decode(text, xbContext);

                  _set_notice = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // target
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.target = new  ObjectifType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.target.decode(reader, xbContext, false, false);

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

         // groundUnitId
         if (this.groundUnitId == null)
             throw new XBException("field groundUnitId not set");

         encoder.encodeStartElement("groundUnitId", "", "");
         this.groundUnitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // priorityTarget
         if (this.priorityTarget == null || this.priorityTarget.Count < 1) 
            throw new XBOccurrencesException( (this.priorityTarget == null ? 0 : this.priorityTarget.Count ) );

         foreach ( PriorityTargetType _tmp_priorityTarget in this.priorityTarget)
         {
            encoder.encodeStartElement("priorityTarget", "", "");
            _tmp_priorityTarget.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // fireSupportArea
         if ( this.fireSupportArea != null ){
            foreach ( Nc1ObjectRefType _tmp_fireSupportArea in this.fireSupportArea)
            {
               encoder.encodeStartElement("fireSupportArea", "", "");
               _tmp_fireSupportArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // searchedEffect
         if ( this.searchedEffect != null ){
            foreach ( ContactEffectType _tmp_searchedEffect in this.searchedEffect)
            {
               encoder.encodeStartElement("searchedEffect", "", "");
               _tmp_searchedEffect.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // consumption
         if (this.consumption == null || this.consumption.Count < 1) 
            throw new XBOccurrencesException( (this.consumption == null ? 0 : this.consumption.Count ) );

         foreach ( ConsumptionType _tmp_consumption in this.consumption)
         {
            encoder.encodeStartElement("consumption", "", "");
            _tmp_consumption.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // immediatelyAvailable
         encoder.encodeStartElement("immediatelyAvailable", "", "");
         String text_3;
         text_3 =  Int0To99Type.encode(this.immediatelyAvailable, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // delayedAvailable
         if (_set_delayedAvailable)  {
            encoder.encodeStartElement("delayedAvailable", "", "");
            text_3 =  Int0To99Type.encode(this.delayedAvailable, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // notice
         if (_set_notice)  {
            encoder.encodeStartElement("notice", "", "");
            text_3 =  Int0To2147483647Type.encode(this.notice, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // target
         if (this.target != null)  {
            encoder.encodeStartElement("target", "", "");
            this.target.encode(encoder, xbContext, null, false);
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

   public class MoyensAcquisitionCode
   {
      static MoyensAcquisitionCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private MoyensAcquisitionCode() {} 


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

   public class MissionASSType_5_indepthFieldArtilleryMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_indepthFieldArtilleryMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","priorityTarget"),
         new XBQualifiedName("","target"),
         new XBQualifiedName("","effectByArea"),
         new XBQualifiedName("","acquisitionMeans"),
         new XBQualifiedName("","otherAcquisitionMeans"),
         new XBQualifiedName("","acquisitionModes"),
         new XBQualifiedName("","consumption")
      };
      static MissionASSType_5_indepthFieldArtilleryMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< PriorityTargetType> priorityTarget;
         
      protected  ObjectifType target;   //optional
      protected System.Collections.Generic.IList< EffectByAreaType> effectByArea;
         
      protected int acquisitionMeans;
      protected string otherAcquisitionMeans;
      protected bool _set_otherAcquisitionMeans = false;
      protected string acquisitionModes;
      protected bool _set_acquisitionModes = false;
      protected System.Collections.Generic.IList< ConsumptionType> consumption;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< PriorityTargetType> PriorityTarget
      {
         get
         {
            if (this.priorityTarget == null) {
               this.priorityTarget = new List< PriorityTargetType>();
            }
            return this.priorityTarget;
         }
      }

      public  ObjectifType Target
      {
         get
         {
            if (this.target == null)
                throw new XBException("field target not set");

            return this.target;
         }
         set
         {
            this.target = value;
         }
      }

      public System.Collections.Generic.IList< EffectByAreaType> EffectByArea
      {
         get
         {
            if (this.effectByArea == null) {
               this.effectByArea = new List< EffectByAreaType>();
            }
            return this.effectByArea;
         }
      }

      public int AcquisitionMeans
      {
         get { return this.acquisitionMeans; }
         set { this.acquisitionMeans = value; }
      }

      public string OtherAcquisitionMeans
      {
         get
         {
            if (!_set_otherAcquisitionMeans)
                throw new XBException("field otherAcquisitionMeans not set");

            return this.otherAcquisitionMeans;
         }
         set
         {
            this.otherAcquisitionMeans = value;
            _set_otherAcquisitionMeans = true;
         }
      }

      public string AcquisitionModes
      {
         get
         {
            if (!_set_acquisitionModes)
                throw new XBException("field acquisitionModes not set");

            return this.acquisitionModes;
         }
         set
         {
            this.acquisitionModes = value;
            _set_acquisitionModes = true;
         }
      }

      public System.Collections.Generic.IList< ConsumptionType> Consumption
      {
         get
         {
            if (this.consumption == null) {
               this.consumption = new List< ConsumptionType>();
            }
            return this.consumption;
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

               // priorityTarget
               this.priorityTarget = new List< PriorityTargetType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   PriorityTargetType _tmp_priorityTarget;
                  _tmp_priorityTarget = new  PriorityTargetType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_priorityTarget.decode(reader, xbContext, false, false);
                  this.priorityTarget.Add(_tmp_priorityTarget);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.priorityTarget.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.priorityTarget.Count, "priorityTarget");
               else if (this.priorityTarget.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // target
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.target = new  ObjectifType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.target.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // effectByArea
               this.effectByArea = new List< EffectByAreaType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   EffectByAreaType _tmp_effectByArea;
                  _tmp_effectByArea = new  EffectByAreaType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_effectByArea.decode(reader, xbContext, false, false);
                  this.effectByArea.Add(_tmp_effectByArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.effectByArea.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.effectByArea.Count, "effectByArea");
               else if (this.effectByArea.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // acquisitionMeans
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.acquisitionMeans =  MoyensAcquisitionCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "acquisitionMeans");

               // otherAcquisitionMeans
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.otherAcquisitionMeans =  MediumTextObjectType.decode(text, xbContext);

                  _set_otherAcquisitionMeans = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // acquisitionModes
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.acquisitionModes =  MediumTextObjectType.decode(text, xbContext);

                  _set_acquisitionModes = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // consumption
               this.consumption = new List< ConsumptionType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                   ConsumptionType _tmp_consumption;
                  _tmp_consumption = new  ConsumptionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_consumption.decode(reader, xbContext, false, false);
                  this.consumption.Add(_tmp_consumption);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.consumption.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.consumption.Count, "consumption");
               else if (this.consumption.Count == 0 && moreContent_4) 
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

         // priorityTarget
         if (this.priorityTarget == null || this.priorityTarget.Count < 1) 
            throw new XBOccurrencesException( (this.priorityTarget == null ? 0 : this.priorityTarget.Count ) );

         foreach ( PriorityTargetType _tmp_priorityTarget in this.priorityTarget)
         {
            encoder.encodeStartElement("priorityTarget", "", "");
            _tmp_priorityTarget.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // target
         if (this.target != null)  {
            encoder.encodeStartElement("target", "", "");
            this.target.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // effectByArea
         if (this.effectByArea == null || this.effectByArea.Count < 1) 
            throw new XBOccurrencesException( (this.effectByArea == null ? 0 : this.effectByArea.Count ) );

         foreach ( EffectByAreaType _tmp_effectByArea in this.effectByArea)
         {
            encoder.encodeStartElement("effectByArea", "", "");
            _tmp_effectByArea.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // acquisitionMeans
         encoder.encodeStartElement("acquisitionMeans", "", "");
         String text_3;
         text_3 =  MoyensAcquisitionCode.encode(this.acquisitionMeans, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // otherAcquisitionMeans
         if (_set_otherAcquisitionMeans)  {
            encoder.encodeStartElement("otherAcquisitionMeans", "", "");
            text_3 =  MediumTextObjectType.encode(this.otherAcquisitionMeans, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // acquisitionModes
         if (_set_acquisitionModes)  {
            encoder.encodeStartElement("acquisitionModes", "", "");
            text_3 =  MediumTextObjectType.encode(this.acquisitionModes, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // consumption
         if (this.consumption == null || this.consumption.Count < 1) 
            throw new XBOccurrencesException( (this.consumption == null ? 0 : this.consumption.Count ) );

         foreach ( ConsumptionType _tmp_consumption in this.consumption)
         {
            encoder.encodeStartElement("consumption", "", "");
            _tmp_consumption.encode(encoder, xbContext, null, false);
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

   public class NatureMissionRenfCode
   {
      static NatureMissionRenfCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private NatureMissionRenfCode() {} 


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

   public class MissionASSType_5_fireReinforcementMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_fireReinforcementMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","beneficialUnitId"),
         new XBQualifiedName("","fireUnitDescription"),
         new XBQualifiedName("","fireReinforcementType"),
         new XBQualifiedName("","priorNotice"),
         new XBQualifiedName("","fireSupportArea"),
         new XBQualifiedName("","allocatedConsumption")
      };
      static MissionASSType_5_fireReinforcementMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType beneficialUnitId;
      protected System.Collections.Generic.IList< FireUnitDescriptionType> fireUnitDescription;
         
      protected int fireReinforcementType;
      protected ulong priorNotice;
      protected bool _set_priorNotice = false;
      protected System.Collections.Generic.IList< Nc1ObjectRefType> fireSupportArea;
         
      protected System.Collections.Generic.IList< AllocatedConsumptionType> allocatedConsumption;
         

      //attribute methods

      //content methods

      public  Nc1ObjectRefType BeneficialUnitId
      {
         get
         {
            if (this.beneficialUnitId == null)
                throw new XBException("field beneficialUnitId not set");

            return this.beneficialUnitId;
         }
         set
         {
            this.beneficialUnitId = value;
         }
      }

      public System.Collections.Generic.IList< FireUnitDescriptionType> FireUnitDescription
      {
         get
         {
            if (this.fireUnitDescription == null) {
               this.fireUnitDescription = 
                  new List< FireUnitDescriptionType>();
            }
            return this.fireUnitDescription;
         }
      }

      public int FireReinforcementType
      {
         get { return this.fireReinforcementType; }
         set { this.fireReinforcementType = value; }
      }

      public ulong PriorNotice
      {
         get
         {
            if (!_set_priorNotice)
                throw new XBException("field priorNotice not set");

            return this.priorNotice;
         }
         set
         {
            this.priorNotice = value;
            _set_priorNotice = true;
         }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> FireSupportArea
      {
         get
         {
            if (this.fireSupportArea == null) {
               this.fireSupportArea = new List< Nc1ObjectRefType>();
            }
            return this.fireSupportArea;
         }
      }

      public System.Collections.Generic.IList< AllocatedConsumptionType> AllocatedConsumption
      {
         get
         {
            if (this.allocatedConsumption == null) {
               this.allocatedConsumption = 
                  new List< AllocatedConsumptionType>();
            }
            return this.allocatedConsumption;
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

               // beneficialUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.beneficialUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.beneficialUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "beneficialUnitId");

               // fireUnitDescription
               this.fireUnitDescription = 
                  new List< FireUnitDescriptionType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   FireUnitDescriptionType _tmp_fireUnitDescription;
                  _tmp_fireUnitDescription = new  FireUnitDescriptionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_fireUnitDescription.decode(reader, xbContext, false, false);
                  this.fireUnitDescription.Add(_tmp_fireUnitDescription);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // fireReinforcementType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.fireReinforcementType =  NatureMissionRenfCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "fireReinforcementType");

               // priorNotice
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.priorNotice =  Int0To2147483647Type.decode(text, xbContext);

                  _set_priorNotice = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fireSupportArea
               this.fireSupportArea = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_fireSupportArea;
                  _tmp_fireSupportArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_fireSupportArea.decode(reader, xbContext, false, false);
                  this.fireSupportArea.Add(_tmp_fireSupportArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.fireSupportArea.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.fireSupportArea.Count, "fireSupportArea");
               else if (this.fireSupportArea.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // allocatedConsumption
               this.allocatedConsumption = 
                  new List< AllocatedConsumptionType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                   AllocatedConsumptionType _tmp_allocatedConsumption;
                  _tmp_allocatedConsumption = new  AllocatedConsumptionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_allocatedConsumption.decode(reader, xbContext, false, false);
                  this.allocatedConsumption.Add(_tmp_allocatedConsumption);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.allocatedConsumption.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.allocatedConsumption.Count, "allocatedConsumption");
               else if (this.allocatedConsumption.Count == 0 && moreContent_4) 
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

         // beneficialUnitId
         if (this.beneficialUnitId == null)
             throw new XBException("field beneficialUnitId not set");

         encoder.encodeStartElement("beneficialUnitId", "", "");
         this.beneficialUnitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // fireUnitDescription
         if ( this.fireUnitDescription != null ){
            foreach ( FireUnitDescriptionType _tmp_fireUnitDescription in this.fireUnitDescription)
            {
               encoder.encodeStartElement("fireUnitDescription", "", "");
               _tmp_fireUnitDescription.encode(encoder, xbContext, null, 
                  false);
               encoder.encodeEndElement();
            }
         }

         // fireReinforcementType
         encoder.encodeStartElement("fireReinforcementType", "", "");
         String text_3;
         text_3 =  NatureMissionRenfCode.encode(this.fireReinforcementType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // priorNotice
         if (_set_priorNotice)  {
            encoder.encodeStartElement("priorNotice", "", "");
            text_3 =  Int0To2147483647Type.encode(this.priorNotice, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // fireSupportArea
         if (this.fireSupportArea == null || this.fireSupportArea.Count < 1) 
            throw new XBOccurrencesException( (this.fireSupportArea == null ? 0 : this.fireSupportArea.Count ) );

         foreach ( Nc1ObjectRefType _tmp_fireSupportArea in this.fireSupportArea)
         {
            encoder.encodeStartElement("fireSupportArea", "", "");
            _tmp_fireSupportArea.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // allocatedConsumption
         if (this.allocatedConsumption == null || 
            this.allocatedConsumption.Count < 1) 
            throw new XBOccurrencesException( (this.allocatedConsumption == null ? 0 : this.allocatedConsumption.Count ) );

         foreach ( AllocatedConsumptionType _tmp_allocatedConsumption in this.allocatedConsumption)
         {
            encoder.encodeStartElement("allocatedConsumption", "", "");
            _tmp_allocatedConsumption.encode(encoder, xbContext, null, false);
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

   public class NatureMissionAcqCOBRACode
   {
      static NatureMissionAcqCOBRACode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private NatureMissionAcqCOBRACode() {} 


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

   public class PriorityCOBRACode
   {
      static PriorityCOBRACode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private PriorityCOBRACode() {} 


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

   public class TrustCode
   {
      static TrustCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private TrustCode() {} 


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

   public class MissionASSType_40_acquiringCOBRA : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_40_acquiringCOBRA");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","missionNature"),
         new XBQualifiedName("","equipmentPriority"),
         new XBQualifiedName("","missionPriority"),
         new XBQualifiedName("","fireUnitDistance"),
         new XBQualifiedName("","minNumberOfTrajectories"),
         new XBQualifiedName("","trustLevel"),
         new XBQualifiedName("","fireUnitId"),
         new XBQualifiedName("","registrationFireUnitId"),
         new XBQualifiedName("","delegationFireIndicator"),
         new XBQualifiedName("","delegationFireNumber"),
         new XBQualifiedName("","delegationComment")
      };
      static MissionASSType_40_acquiringCOBRA() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int missionNature;
      protected System.Collections.Generic.IList< EquipmentPriorityType> equipmentPriority;
         
      protected int missionPriority;
      protected bool _set_missionPriority = false;
      protected ushort fireUnitDistance;
      protected bool _set_fireUnitDistance = false;
      protected ushort minNumberOfTrajectories;
      protected bool _set_minNumberOfTrajectories = false;
      protected int trustLevel;
      protected bool _set_trustLevel = false;
      protected  Nc1ObjectRefType fireUnitId;   //optional
      protected  Nc1ObjectRefType registrationFireUnitId;   //optional
      protected bool delegationFireIndicator;
      protected bool _set_delegationFireIndicator = false;
      protected ushort delegationFireNumber;
      protected bool _set_delegationFireNumber = false;
      protected string delegationComment;
      protected bool _set_delegationComment = false;

      //attribute methods

      //content methods

      public int MissionNature
      {
         get { return this.missionNature; }
         set { this.missionNature = value; }
      }

      public System.Collections.Generic.IList< EquipmentPriorityType> EquipmentPriority
      {
         get
         {
            if (this.equipmentPriority == null) {
               this.equipmentPriority = 
                  new List< EquipmentPriorityType>();
            }
            return this.equipmentPriority;
         }
      }

      public int MissionPriority
      {
         get
         {
            if (!_set_missionPriority)
                throw new XBException("field missionPriority not set");

            return this.missionPriority;
         }
         set
         {
            this.missionPriority = value;
            _set_missionPriority = true;
         }
      }

      public ushort FireUnitDistance
      {
         get
         {
            if (!_set_fireUnitDistance)
                throw new XBException("field fireUnitDistance not set");

            return this.fireUnitDistance;
         }
         set
         {
            this.fireUnitDistance = value;
            _set_fireUnitDistance = true;
         }
      }

      public ushort MinNumberOfTrajectories
      {
         get
         {
            if (!_set_minNumberOfTrajectories)
                throw new XBException("field minNumberOfTrajectories not set");

            return this.minNumberOfTrajectories;
         }
         set
         {
            this.minNumberOfTrajectories = value;
            _set_minNumberOfTrajectories = true;
         }
      }

      public int TrustLevel
      {
         get
         {
            if (!_set_trustLevel)
                throw new XBException("field trustLevel not set");

            return this.trustLevel;
         }
         set
         {
            this.trustLevel = value;
            _set_trustLevel = true;
         }
      }

      public  Nc1ObjectRefType FireUnitId
      {
         get
         {
            if (this.fireUnitId == null)
                throw new XBException("field fireUnitId not set");

            return this.fireUnitId;
         }
         set
         {
            this.fireUnitId = value;
         }
      }

      public  Nc1ObjectRefType RegistrationFireUnitId
      {
         get
         {
            if (this.registrationFireUnitId == null)
                throw new XBException("field registrationFireUnitId not set");

            return this.registrationFireUnitId;
         }
         set
         {
            this.registrationFireUnitId = value;
         }
      }

      public bool DelegationFireIndicator
      {
         get
         {
            if (!_set_delegationFireIndicator)
                throw new XBException("field delegationFireIndicator not set");

            return this.delegationFireIndicator;
         }
         set
         {
            this.delegationFireIndicator = value;
            _set_delegationFireIndicator = true;
         }
      }

      public ushort DelegationFireNumber
      {
         get
         {
            if (!_set_delegationFireNumber)
                throw new XBException("field delegationFireNumber not set");

            return this.delegationFireNumber;
         }
         set
         {
            this.delegationFireNumber = value;
            _set_delegationFireNumber = true;
         }
      }

      public string DelegationComment
      {
         get
         {
            if (!_set_delegationComment)
                throw new XBException("field delegationComment not set");

            return this.delegationComment;
         }
         set
         {
            this.delegationComment = value;
            _set_delegationComment = true;
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

               // missionNature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.missionNature =  NatureMissionAcqCOBRACode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionNature");

               // equipmentPriority
               this.equipmentPriority = 
                  new List< EquipmentPriorityType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   EquipmentPriorityType _tmp_equipmentPriority;
                  _tmp_equipmentPriority = new  EquipmentPriorityType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_equipmentPriority.decode(reader, xbContext, false, false);
                  this.equipmentPriority.Add(_tmp_equipmentPriority);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // missionPriority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.missionPriority =  PriorityCOBRACode.decode(text, xbContext);

                  _set_missionPriority = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fireUnitDistance
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.fireUnitDistance =  Int0To9999Type.decode(text, xbContext);

                  _set_fireUnitDistance = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // minNumberOfTrajectories
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.minNumberOfTrajectories =  Int0To999Type.decode(text, xbContext);

                  _set_minNumberOfTrajectories = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // trustLevel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.trustLevel =  TrustCode.decode(text, xbContext);

                  _set_trustLevel = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fireUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  this.fireUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.fireUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // registrationFireUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.registrationFireUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.registrationFireUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // delegationFireIndicator
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.delegationFireIndicator = XBSimpleType.parseBoolean(text);

                  _set_delegationFireIndicator = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // delegationFireNumber
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.delegationFireNumber =  Int0To9999Type.decode(text, xbContext);

                  _set_delegationFireNumber = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // delegationComment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.delegationComment =  LongTextObjectType.decode(text, xbContext);

                  _set_delegationComment = true;

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

         // missionNature
         encoder.encodeStartElement("missionNature", "", "");
         String text_3;
         text_3 =  NatureMissionAcqCOBRACode.encode(this.missionNature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // equipmentPriority
         if ( this.equipmentPriority != null ){
            foreach ( EquipmentPriorityType _tmp_equipmentPriority in this.equipmentPriority)
            {
               encoder.encodeStartElement("equipmentPriority", "", "");
               _tmp_equipmentPriority.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // missionPriority
         if (_set_missionPriority)  {
            encoder.encodeStartElement("missionPriority", "", "");
            text_3 =  PriorityCOBRACode.encode(this.missionPriority, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // fireUnitDistance
         if (_set_fireUnitDistance)  {
            encoder.encodeStartElement("fireUnitDistance", "", "");
            text_3 =  Int0To9999Type.encode(this.fireUnitDistance, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // minNumberOfTrajectories
         if (_set_minNumberOfTrajectories)  {
            encoder.encodeStartElement("minNumberOfTrajectories", "", "");
            text_3 =  Int0To999Type.encode(this.minNumberOfTrajectories, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // trustLevel
         if (_set_trustLevel)  {
            encoder.encodeStartElement("trustLevel", "", "");
            text_3 =  TrustCode.encode(this.trustLevel, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // fireUnitId
         if (this.fireUnitId != null)  {
            encoder.encodeStartElement("fireUnitId", "", "");
            this.fireUnitId.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // registrationFireUnitId
         if (this.registrationFireUnitId != null)  {
            encoder.encodeStartElement("registrationFireUnitId", "", "");
            this.registrationFireUnitId.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // delegationFireIndicator
         if (_set_delegationFireIndicator)  {
            encoder.encodeStartElement("delegationFireIndicator", "", "");
            text_3 = this.delegationFireIndicator.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // delegationFireNumber
         if (_set_delegationFireNumber)  {
            encoder.encodeStartElement("delegationFireNumber", "", "");
            text_3 =  Int0To9999Type.encode(this.delegationFireNumber, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // delegationComment
         if (_set_delegationComment)  {
            encoder.encodeStartElement("delegationComment", "", "");
            text_3 =  LongTextObjectType.encode(this.delegationComment, xbContext);
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

   public class NatureMissionAcqCode
   {
      static NatureMissionAcqCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private NatureMissionAcqCode() {} 


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

   public class MissionASSType_40_acquiring : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_40_acquiring");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","missionNature"),
         new XBQualifiedName("","target"),
         new XBQualifiedName("","coordinationUnit"),
         new XBQualifiedName("","rattachmentUnit"),
         new XBQualifiedName("","firingExecutionTerms"),
         new XBQualifiedName("","firingRegistrationTerms")
      };
      static MissionASSType_40_acquiring() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int missionNature;
      protected  PriorityTargetType target;   //optional
      protected  FormationType coordinationUnit;   //optional
      protected  FormationType rattachmentUnit;   //optional
      protected string firingExecutionTerms;
      protected bool _set_firingExecutionTerms = false;
      protected string firingRegistrationTerms;
      protected bool _set_firingRegistrationTerms = false;

      //attribute methods

      //content methods

      public int MissionNature
      {
         get { return this.missionNature; }
         set { this.missionNature = value; }
      }

      public  PriorityTargetType Target
      {
         get
         {
            if (this.target == null)
                throw new XBException("field target not set");

            return this.target;
         }
         set
         {
            this.target = value;
         }
      }

      public  FormationType CoordinationUnit
      {
         get
         {
            if (this.coordinationUnit == null)
                throw new XBException("field coordinationUnit not set");

            return this.coordinationUnit;
         }
         set
         {
            this.coordinationUnit = value;
         }
      }

      public  FormationType RattachmentUnit
      {
         get
         {
            if (this.rattachmentUnit == null)
                throw new XBException("field rattachmentUnit not set");

            return this.rattachmentUnit;
         }
         set
         {
            this.rattachmentUnit = value;
         }
      }

      public string FiringExecutionTerms
      {
         get
         {
            if (!_set_firingExecutionTerms)
                throw new XBException("field firingExecutionTerms not set");

            return this.firingExecutionTerms;
         }
         set
         {
            this.firingExecutionTerms = value;
            _set_firingExecutionTerms = true;
         }
      }

      public string FiringRegistrationTerms
      {
         get
         {
            if (!_set_firingRegistrationTerms)
                throw new XBException("field firingRegistrationTerms not set");

            return this.firingRegistrationTerms;
         }
         set
         {
            this.firingRegistrationTerms = value;
            _set_firingRegistrationTerms = true;
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

               // missionNature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.missionNature =  NatureMissionAcqCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionNature");

               // target
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.target = new  PriorityTargetType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.target.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // coordinationUnit
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.coordinationUnit = new  FormationType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.coordinationUnit.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // rattachmentUnit
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.rattachmentUnit = new  FormationType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.rattachmentUnit.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // firingExecutionTerms
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.firingExecutionTerms =  MediumTextObjectType.decode(text, xbContext);

                  _set_firingExecutionTerms = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // firingRegistrationTerms
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.firingRegistrationTerms =  MediumTextObjectType.decode(text, xbContext);

                  _set_firingRegistrationTerms = true;

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

         // missionNature
         encoder.encodeStartElement("missionNature", "", "");
         String text_3;
         text_3 =  NatureMissionAcqCode.encode(this.missionNature, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // target
         if (this.target != null)  {
            encoder.encodeStartElement("target", "", "");
            this.target.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // coordinationUnit
         if (this.coordinationUnit != null)  {
            encoder.encodeStartElement("coordinationUnit", "", "");
            this.coordinationUnit.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // rattachmentUnit
         if (this.rattachmentUnit != null)  {
            encoder.encodeStartElement("rattachmentUnit", "", "");
            this.rattachmentUnit.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // firingExecutionTerms
         if (_set_firingExecutionTerms)  {
            encoder.encodeStartElement("firingExecutionTerms", "", "");
            text_3 =  MediumTextObjectType.encode(this.firingExecutionTerms, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // firingRegistrationTerms
         if (_set_firingRegistrationTerms)  {
            encoder.encodeStartElement("firingRegistrationTerms", "", "");
            text_3 =  MediumTextObjectType.encode(this.firingRegistrationTerms, xbContext);
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

   public class MissionASSType_40
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_40");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","acquiringCOBRA"),
         new XBQualifiedName("","acquiring")
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
         None, acquiringCOBRA, acquiring}
      protected Choice _whichField;
      static MissionASSType_40() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MissionASSType_40_acquiringCOBRA acquiringCOBRA;
      protected  MissionASSType_40_acquiring acquiring;

      //content methods

      public  MissionASSType_40_acquiringCOBRA AcquiringCOBRA
      {
         get
         {
            if (_whichField != Choice.acquiringCOBRA ) 
               throw new XBException("field acquiringCOBRA not set");
            return this.acquiringCOBRA;
         }
         set
         {
            this.acquiringCOBRA = value;
            _whichField = Choice.acquiringCOBRA;
         }
      }

      public  MissionASSType_40_acquiring Acquiring
      {
         get
         {
            if (_whichField != Choice.acquiring ) 
               throw new XBException("field acquiring not set");
            return this.acquiring;
         }
         set
         {
            this.acquiring = value;
            _whichField = Choice.acquiring;
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

            // acquiringCOBRA
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.acquiringCOBRA = new  MissionASSType_40_acquiringCOBRA();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.acquiringCOBRA.decode(reader, xbContext, false, false);
               _whichField = Choice.acquiringCOBRA;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // acquiring
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.acquiring = new  MissionASSType_40_acquiring();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.acquiring.decode(reader, xbContext, false, false);
               _whichField = Choice.acquiring;

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

            // acquiringCOBRA
            case Choice.acquiringCOBRA: {
               if (_whichField != Choice.acquiringCOBRA ) 
                  throw new XBException("field acquiringCOBRA not set");
               encoder.encodeStartElement("acquiringCOBRA", "", "");
               this.acquiringCOBRA.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // acquiring
            case Choice.acquiring: {
               if (_whichField != Choice.acquiring ) 
                  throw new XBException("field acquiring not set");
               encoder.encodeStartElement("acquiring", "", "");
               this.acquiring.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class MoyenAcquisitionArtCode
   {
      static MoyenAcquisitionArtCode() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //constructor
      private MoyenAcquisitionArtCode() {} 


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

   public class MissionASSType_5_acquiringFieldArtilleryMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_acquiringFieldArtilleryMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","beneficialUnitId"),
         new XBQualifiedName("","resourcesType"),
         new XBQualifiedName("","observationArea"),
         new XBQualifiedName("","deploymentArea")
      };
      static MissionASSType_5_acquiringFieldArtilleryMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType beneficialUnitId;   //optional
      protected int resourcesType;
      protected System.Collections.Generic.IList< Nc1ObjectRefType> observationArea;
         
      protected System.Collections.Generic.IList< Nc1ObjectRefType> deploymentArea;
         
      protected  MissionASSType_40 missionASSType_40;

      //attribute methods

      //content methods

      public  Nc1ObjectRefType BeneficialUnitId
      {
         get
         {
            if (this.beneficialUnitId == null)
                throw new XBException("field beneficialUnitId not set");

            return this.beneficialUnitId;
         }
         set
         {
            this.beneficialUnitId = value;
         }
      }

      public int ResourcesType
      {
         get { return this.resourcesType; }
         set { this.resourcesType = value; }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> ObservationArea
      {
         get
         {
            if (this.observationArea == null) {
               this.observationArea = new List< Nc1ObjectRefType>();
            }
            return this.observationArea;
         }
      }

      public System.Collections.Generic.IList< Nc1ObjectRefType> DeploymentArea
      {
         get
         {
            if (this.deploymentArea == null) {
               this.deploymentArea = new List< Nc1ObjectRefType>();
            }
            return this.deploymentArea;
         }
      }

      public  MissionASSType_40 MissionASSType_40
      {
         get
         {
            if (this.missionASSType_40 == null)
                throw new XBException("field missionASSType_40 not set");

            return this.missionASSType_40;
         }
         set
         {
            this.missionASSType_40 = value;
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

               // beneficialUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.beneficialUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.beneficialUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // resourcesType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.resourcesType =  MoyenAcquisitionArtCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "resourcesType");

               // observationArea
               this.observationArea = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_observationArea;
                  _tmp_observationArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_observationArea.decode(reader, xbContext, false, false);
                  this.observationArea.Add(_tmp_observationArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // deploymentArea
               this.deploymentArea = new List< Nc1ObjectRefType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   Nc1ObjectRefType _tmp_deploymentArea;
                  _tmp_deploymentArea = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_deploymentArea.decode(reader, xbContext, false, false);
                  this.deploymentArea.Add(_tmp_deploymentArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // missionASSType_40
               if( moreContent_4 && 
                   MissionASSType_40.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.missionASSType_40 = new  MissionASSType_40();
                  this.missionASSType_40.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionASSType_40");

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

         // beneficialUnitId
         if (this.beneficialUnitId != null)  {
            encoder.encodeStartElement("beneficialUnitId", "", "");
            this.beneficialUnitId.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // resourcesType
         encoder.encodeStartElement("resourcesType", "", "");
         String text_3;
         text_3 =  MoyenAcquisitionArtCode.encode(this.resourcesType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // observationArea
         if ( this.observationArea != null ){
            foreach ( Nc1ObjectRefType _tmp_observationArea in this.observationArea)
            {
               encoder.encodeStartElement("observationArea", "", "");
               _tmp_observationArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // deploymentArea
         if ( this.deploymentArea != null ){
            foreach ( Nc1ObjectRefType _tmp_deploymentArea in this.deploymentArea)
            {
               encoder.encodeStartElement("deploymentArea", "", "");
               _tmp_deploymentArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // missionASSType_40
         if (this.missionASSType_40 == null)
             throw new XBException("field missionASSType_40 not set");

         this.missionASSType_40.encode(encoder, xbContext);
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

   public class MissionASSType_62
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_62");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","areaId"),
         new XBQualifiedName("","intelTask")
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
         None, areaId, intelTask}
      protected Choice _whichField;
      static MissionASSType_62() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType areaId;
      protected System.Collections.Generic.IList< IntelTaskType> intelTask;
         

      //content methods

      public  Nc1ObjectRefType AreaId
      {
         get
         {
            if (_whichField != Choice.areaId ) 
               throw new XBException("field areaId not set");
            return this.areaId;
         }
         set
         {
            this.areaId = value;
            _whichField = Choice.areaId;
         }
      }

      public System.Collections.Generic.IList< IntelTaskType> IntelTask
      {
         get
         {
            if (_whichField != Choice.intelTask ) 
               throw new XBException("field intelTask not set");
            if (_whichField  != Choice.intelTask) {
               this.intelTask = new List< IntelTaskType>();
               _whichField = Choice.intelTask;
            }
            return this.intelTask;
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

            // areaId
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.areaId = new  Nc1ObjectRefType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.areaId.decode(reader, xbContext, false, false);
               _whichField = Choice.areaId;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // intelTask
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.intelTask = new List< IntelTaskType>();
               do  {
                   IntelTaskType _tmp_intelTask;
                  _tmp_intelTask = new  IntelTaskType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_intelTask.decode(reader, xbContext, false, false);
                  this.intelTask.Add(_tmp_intelTask);
                  _whichField = Choice.intelTask;

                  bool moreContent_6;
                  moreContent_6 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_6) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) );
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

            // areaId
            case Choice.areaId: {
               if (_whichField != Choice.areaId ) 
                  throw new XBException("field areaId not set");
               encoder.encodeStartElement("areaId", "", "");
               this.areaId.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // intelTask
            case Choice.intelTask: {
               if (this.intelTask == null || this.intelTask.Count < 1) 
                  throw new XBOccurrencesException( (this.intelTask == null ? 0 : this.intelTask.Count ) );

               foreach ( IntelTaskType _tmp_intelTask in this.intelTask)
               {
                  encoder.encodeStartElement("intelTask", "", "");
                  _tmp_intelTask.encode(encoder, xbContext, null, false);
                  encoder.encodeEndElement();
               }
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class MissionASSType_5_intelFieldArtilleryMission : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5_intelFieldArtilleryMission");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","priority")
      };
      static MissionASSType_5_intelFieldArtilleryMission() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string priority;
      protected bool _set_priority = false;
      protected  MissionASSType_62 missionASSType_62;

      //attribute methods

      //content methods

      public string Priority
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

      public  MissionASSType_62 MissionASSType_62
      {
         get
         {
            if (this.missionASSType_62 == null)
                throw new XBException("field missionASSType_62 not set");

            return this.missionASSType_62;
         }
         set
         {
            this.missionASSType_62 = value;
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

               // priority
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.priority =  MediumTextObjectType.decode(text, xbContext);

                  _set_priority = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // missionASSType_62
               if( moreContent_4 && 
                   MissionASSType_62.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.missionASSType_62 = new  MissionASSType_62();
                  this.missionASSType_62.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionASSType_62");

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

         // priority
         if (_set_priority)  {
            encoder.encodeStartElement("priority", "", "");
            String text_4;
            text_4 =  MediumTextObjectType.encode(this.priority, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // missionASSType_62
         if (this.missionASSType_62 == null)
             throw new XBException("field missionASSType_62 not set");

         this.missionASSType_62.encode(encoder, xbContext);
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

   public class MissionASSType_5
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_5");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","superiorFieldArtilleryMission"),
         new XBQualifiedName("","contactFieldArtilleryMission"),
         new XBQualifiedName("","indepthFieldArtilleryMission"),
         new XBQualifiedName("","fireReinforcementMission"),
         new XBQualifiedName("","acquiringFieldArtilleryMission"),
         new XBQualifiedName("","intelFieldArtilleryMission")
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
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[4], elemNs, elemLocalName)
            ) return true;
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[5], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, superiorFieldArtilleryMission, contactFieldArtilleryMission, 
            indepthFieldArtilleryMission, fireReinforcementMission, 
            acquiringFieldArtilleryMission, intelFieldArtilleryMission}
      protected Choice _whichField;
      static MissionASSType_5() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MissionASSType_5_superiorFieldArtilleryMission superiorFieldArtilleryMission;
         
      protected  MissionASSType_5_contactFieldArtilleryMission contactFieldArtilleryMission;
         
      protected  MissionASSType_5_indepthFieldArtilleryMission indepthFieldArtilleryMission;
         
      protected  MissionASSType_5_fireReinforcementMission fireReinforcementMission;
         
      protected  MissionASSType_5_acquiringFieldArtilleryMission acquiringFieldArtilleryMission;
         
      protected  MissionASSType_5_intelFieldArtilleryMission intelFieldArtilleryMission;
         

      //content methods

      public  MissionASSType_5_superiorFieldArtilleryMission SuperiorFieldArtilleryMission
      {
         get
         {
            if (_whichField != Choice.superiorFieldArtilleryMission ) 
               throw new XBException("field superiorFieldArtilleryMission not set");
            return this.superiorFieldArtilleryMission;
         }
         set
         {
            this.superiorFieldArtilleryMission = value;
            _whichField = Choice.superiorFieldArtilleryMission;
         }
      }

      public  MissionASSType_5_contactFieldArtilleryMission ContactFieldArtilleryMission
      {
         get
         {
            if (_whichField != Choice.contactFieldArtilleryMission ) 
               throw new XBException("field contactFieldArtilleryMission not set");
            return this.contactFieldArtilleryMission;
         }
         set
         {
            this.contactFieldArtilleryMission = value;
            _whichField = Choice.contactFieldArtilleryMission;
         }
      }

      public  MissionASSType_5_indepthFieldArtilleryMission IndepthFieldArtilleryMission
      {
         get
         {
            if (_whichField != Choice.indepthFieldArtilleryMission ) 
               throw new XBException("field indepthFieldArtilleryMission not set");
            return this.indepthFieldArtilleryMission;
         }
         set
         {
            this.indepthFieldArtilleryMission = value;
            _whichField = Choice.indepthFieldArtilleryMission;
         }
      }

      public  MissionASSType_5_fireReinforcementMission FireReinforcementMission
      {
         get
         {
            if (_whichField != Choice.fireReinforcementMission ) 
               throw new XBException("field fireReinforcementMission not set");
            return this.fireReinforcementMission;
         }
         set
         {
            this.fireReinforcementMission = value;
            _whichField = Choice.fireReinforcementMission;
         }
      }

      public  MissionASSType_5_acquiringFieldArtilleryMission AcquiringFieldArtilleryMission
      {
         get
         {
            if (_whichField != Choice.acquiringFieldArtilleryMission ) 
               throw new XBException("field acquiringFieldArtilleryMission not set");
            return this.acquiringFieldArtilleryMission;
         }
         set
         {
            this.acquiringFieldArtilleryMission = value;
            _whichField = Choice.acquiringFieldArtilleryMission;
         }
      }

      public  MissionASSType_5_intelFieldArtilleryMission IntelFieldArtilleryMission
      {
         get
         {
            if (_whichField != Choice.intelFieldArtilleryMission ) 
               throw new XBException("field intelFieldArtilleryMission not set");
            return this.intelFieldArtilleryMission;
         }
         set
         {
            this.intelFieldArtilleryMission = value;
            _whichField = Choice.intelFieldArtilleryMission;
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

            // superiorFieldArtilleryMission
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.superiorFieldArtilleryMission = new  MissionASSType_5_superiorFieldArtilleryMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.superiorFieldArtilleryMission.decode(reader, xbContext, false, false);
               _whichField = Choice.superiorFieldArtilleryMission;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // contactFieldArtilleryMission
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.contactFieldArtilleryMission = new  MissionASSType_5_contactFieldArtilleryMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.contactFieldArtilleryMission.decode(reader, xbContext, false, false);
               _whichField = Choice.contactFieldArtilleryMission;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // indepthFieldArtilleryMission
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               this.indepthFieldArtilleryMission = new  MissionASSType_5_indepthFieldArtilleryMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.indepthFieldArtilleryMission.decode(reader, xbContext, false, false);
               _whichField = Choice.indepthFieldArtilleryMission;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // fireReinforcementMission
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
            {
               this.fireReinforcementMission = new  MissionASSType_5_fireReinforcementMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.fireReinforcementMission.decode(reader, xbContext, false, false);
               _whichField = Choice.fireReinforcementMission;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // acquiringFieldArtilleryMission
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
            {
               this.acquiringFieldArtilleryMission = new  MissionASSType_5_acquiringFieldArtilleryMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.acquiringFieldArtilleryMission.decode(reader, xbContext, false, false);
               _whichField = Choice.acquiringFieldArtilleryMission;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // intelFieldArtilleryMission
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
            {
               this.intelFieldArtilleryMission = new  MissionASSType_5_intelFieldArtilleryMission();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.intelFieldArtilleryMission.decode(reader, xbContext, false, false);
               _whichField = Choice.intelFieldArtilleryMission;

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

            // superiorFieldArtilleryMission
            case Choice.superiorFieldArtilleryMission: {
               if (_whichField != Choice.superiorFieldArtilleryMission ) 
                  throw new XBException("field superiorFieldArtilleryMission not set");
               encoder.encodeStartElement("superiorFieldArtilleryMission", "", "");
               this.superiorFieldArtilleryMission.encode(encoder, xbContext, 
                  null, false);
               encoder.encodeEndElement();
               break;
            }

            // contactFieldArtilleryMission
            case Choice.contactFieldArtilleryMission: {
               if (_whichField != Choice.contactFieldArtilleryMission ) 
                  throw new XBException("field contactFieldArtilleryMission not set");
               encoder.encodeStartElement("contactFieldArtilleryMission", "", "");
               this.contactFieldArtilleryMission.encode(encoder, xbContext, 
                  null, false);
               encoder.encodeEndElement();
               break;
            }

            // indepthFieldArtilleryMission
            case Choice.indepthFieldArtilleryMission: {
               if (_whichField != Choice.indepthFieldArtilleryMission ) 
                  throw new XBException("field indepthFieldArtilleryMission not set");
               encoder.encodeStartElement("indepthFieldArtilleryMission", "", "");
               this.indepthFieldArtilleryMission.encode(encoder, xbContext, 
                  null, false);
               encoder.encodeEndElement();
               break;
            }

            // fireReinforcementMission
            case Choice.fireReinforcementMission: {
               if (_whichField != Choice.fireReinforcementMission ) 
                  throw new XBException("field fireReinforcementMission not set");
               encoder.encodeStartElement("fireReinforcementMission", "", "");
               this.fireReinforcementMission.encode(encoder, xbContext, null, 
                  false);
               encoder.encodeEndElement();
               break;
            }

            // acquiringFieldArtilleryMission
            case Choice.acquiringFieldArtilleryMission: {
               if (_whichField != Choice.acquiringFieldArtilleryMission ) 
                  throw new XBException("field acquiringFieldArtilleryMission not set");
               encoder.encodeStartElement("acquiringFieldArtilleryMission", "", "");
               this.acquiringFieldArtilleryMission.encode(encoder, xbContext, 
                  null, false);
               encoder.encodeEndElement();
               break;
            }

            // intelFieldArtilleryMission
            case Choice.intelFieldArtilleryMission: {
               if (_whichField != Choice.intelFieldArtilleryMission ) 
                  throw new XBException("field intelFieldArtilleryMission not set");
               encoder.encodeStartElement("intelFieldArtilleryMission", "", "");
               this.intelFieldArtilleryMission.encode(encoder, xbContext, 
                  null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class MissionASSType_2_tacticalData : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType_2_tacticalData");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","missionASSName"),
         new XBQualifiedName("","executiveUnitId"),
         new XBQualifiedName("","levelOfConfirmation"),
         new XBQualifiedName("","tacticalPhase"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","url"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","extVersion")
      };
      static MissionASSType_2_tacticalData() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string missionASSName;
      protected  Nc1ObjectRefType executiveUnitId;
      protected  MissionASSType_5 missionASSType_5;
      protected int levelOfConfirmation;
      protected bool _set_levelOfConfirmation = false;
      protected int tacticalPhase;
      protected bool _set_tacticalPhase = false;
      protected  PeriodType validityPeriod;   //optional
      protected string url;
      protected bool _set_url = false;
      protected string comment;
      protected bool _set_comment = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public string MissionASSName
      {
         get { return this.missionASSName; }
         set { this.missionASSName = value; }
      }

      public  Nc1ObjectRefType ExecutiveUnitId
      {
         get
         {
            if (this.executiveUnitId == null)
                throw new XBException("field executiveUnitId not set");

            return this.executiveUnitId;
         }
         set
         {
            this.executiveUnitId = value;
         }
      }

      public  MissionASSType_5 MissionASSType_5
      {
         get
         {
            if (this.missionASSType_5 == null)
                throw new XBException("field missionASSType_5 not set");

            return this.missionASSType_5;
         }
         set
         {
            this.missionASSType_5 = value;
         }
      }

      public int LevelOfConfirmation
      {
         get
         {
            if (!_set_levelOfConfirmation)
                throw new XBException("field levelOfConfirmation not set");

            return this.levelOfConfirmation;
         }
         set
         {
            this.levelOfConfirmation = value;
            _set_levelOfConfirmation = true;
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

               // missionASSName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.missionASSName =  Text1To10ANType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionASSName");

               // executiveUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.executiveUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.executiveUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "executiveUnitId");

               // missionASSType_5
               if( moreContent_4 && 
                   MissionASSType_5.acceptsElem(elemNs, elemLocalName) )
               {
                  this.missionASSType_5 = new  MissionASSType_5();
                  this.missionASSType_5.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "missionASSType_5");

               // levelOfConfirmation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.levelOfConfirmation =  L105_4Code.decode(text, xbContext);

                  _set_levelOfConfirmation = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // tacticalPhase
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
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

               // url
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
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

         // missionASSName
         encoder.encodeStartElement("missionASSName", "", "");
         String text_3;
         text_3 =  Text1To10ANType.encode(this.missionASSName, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // executiveUnitId
         if (this.executiveUnitId == null)
             throw new XBException("field executiveUnitId not set");

         encoder.encodeStartElement("executiveUnitId", "", "");
         this.executiveUnitId.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // missionASSType_5
         if (this.missionASSType_5 == null)
             throw new XBException("field missionASSType_5 not set");

         this.missionASSType_5.encode(encoder, xbContext);

         // levelOfConfirmation
         if (_set_levelOfConfirmation)  {
            encoder.encodeStartElement("levelOfConfirmation", "", "");
            text_3 =  L105_4Code.encode(this.levelOfConfirmation, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // tacticalPhase
         if (_set_tacticalPhase)  {
            encoder.encodeStartElement("tacticalPhase", "", "");
            text_3 =  L114_10Code.encode(this.tacticalPhase, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // validityPeriod
         if (this.validityPeriod != null)  {
            encoder.encodeStartElement("validityPeriod", "", "");
            this.validityPeriod.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // url
         if (_set_url)  {
            encoder.encodeStartElement("url", "", "");
            text_3 =  MediumTextObjectType.encode(this.url, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            text_3 =  LongTextObjectType.encode(this.comment, xbContext);
            encoder.encodeChars(text_3);
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

   public class MissionASSType :  BaseObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:missionASS",
          "MissionASSType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","tacticalData")
      };
      static MissionASSType() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  MissionASSType_2_tacticalData tacticalData;   //optional
         

      //attribute methods

      //content methods

      public  MissionASSType_2_tacticalData TacticalData
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
                  this.tacticalData = new  MissionASSType_2_tacticalData();
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

   public class NC1_MissionASS_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:objet:missionASS","NC1_MissionASS")
      };
      static NC1_MissionASS_CC() {
         XBUtil.license =  _NC1_MissionASS.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MissionASSType nC1_MissionASS;

      //content methods

      public  MissionASSType NC1_MissionASS
      {
         get
         {
            if (this.nC1_MissionASS == null)
                throw new XBException("field nC1_MissionASS not set");

            return this.nC1_MissionASS;
         }
         set
         {
            this.nC1_MissionASS = value;
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
         //   encoder.setNamespaces(_NC1_MissionASS.namespaceContext);

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

            // nC1_MissionASS
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_MissionASS = new  MissionASSType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_MissionASS.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_MissionASS");

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

         // nC1_MissionASS
         if (this.nC1_MissionASS == null)
             throw new XBException("field nC1_MissionASS not set");

         encoder.encodeStartElement("NC1_MissionASS",  _NC1_MissionASS.NS_URI,  _NC1_MissionASS.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_MissionASS.encode(encoder, xbContext, null, false);
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

   public class _NC1_MissionASS {

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
      public static readonly String NS_URI = "urn:fra:nc1:objet:missionASS";
      public static readonly String NS_PREFIX = "nc1missionASS";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_MissionASS() {
      }
      static _NC1_MissionASS() {
         XBUtil.license = _NC1_MissionASS.license;
      }
   }
}
