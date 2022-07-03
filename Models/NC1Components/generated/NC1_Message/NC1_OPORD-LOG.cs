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
    public class NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opordlog",
          "NC1_OPORD-LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","supply"),
         new XBQualifiedName("","transports"),
         new XBQualifiedName("","services"),
         new XBQualifiedName("","workforce"),
         new XBQualifiedName("","hygieneAndSafety"),
         new XBQualifiedName("","postOffice"),
         new XBQualifiedName("","maintenance")
      };
      static NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices() 
      {
         XBUtil.license =  _NC1_OPORD_LOG.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MixedAnyType supply;   //optional
      protected  MixedAnyType transports;   //optional
      protected  MixedAnyType services;   //optional
      protected  MixedAnyType workforce;   //optional
      protected string hygieneAndSafety;
      protected bool _set_hygieneAndSafety = false;
      protected  MixedAnyType postOffice;   //optional
      protected string maintenance;
      protected bool _set_maintenance = false;

      //attribute methods

      //content methods

      public  MixedAnyType Supply
      {
         get
         {
            if (this.supply == null)
                throw new XBException("field supply not set");

            return this.supply;
         }
         set
         {
            this.supply = value;
         }
      }

      public  MixedAnyType Transports
      {
         get
         {
            if (this.transports == null)
                throw new XBException("field transports not set");

            return this.transports;
         }
         set
         {
            this.transports = value;
         }
      }

      public  MixedAnyType Services
      {
         get
         {
            if (this.services == null)
                throw new XBException("field services not set");

            return this.services;
         }
         set
         {
            this.services = value;
         }
      }

      public  MixedAnyType Workforce
      {
         get
         {
            if (this.workforce == null)
                throw new XBException("field workforce not set");

            return this.workforce;
         }
         set
         {
            this.workforce = value;
         }
      }

      public string HygieneAndSafety
      {
         get
         {
            if (!_set_hygieneAndSafety)
                throw new XBException("field hygieneAndSafety not set");

            return this.hygieneAndSafety;
         }
         set
         {
            this.hygieneAndSafety = value;
            _set_hygieneAndSafety = true;
         }
      }

      public  MixedAnyType PostOffice
      {
         get
         {
            if (this.postOffice == null)
                throw new XBException("field postOffice not set");

            return this.postOffice;
         }
         set
         {
            this.postOffice = value;
         }
      }

      public string Maintenance
      {
         get
         {
            if (!_set_maintenance)
                throw new XBException("field maintenance not set");

            return this.maintenance;
         }
         set
         {
            this.maintenance = value;
            _set_maintenance = true;
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

               // supply
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.supply = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.supply.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // transports
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.transports = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.transports.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // services
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.services = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.services.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // workforce
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.workforce = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.workforce.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // hygieneAndSafety
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.hygieneAndSafety =  LongTextType.decode(text, xbContext);

                  _set_hygieneAndSafety = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // postOffice
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.postOffice = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.postOffice.decode(reader, xbContext, false, false);

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
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.maintenance =  LongTextType.decode(text, xbContext);

                  _set_maintenance = true;

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

         // supply
         if (this.supply != null)  {
            encoder.encodeStartElement("supply", "", "");
            this.supply.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // transports
         if (this.transports != null)  {
            encoder.encodeStartElement("transports", "", "");
            this.transports.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // services
         if (this.services != null)  {
            encoder.encodeStartElement("services", "", "");
            this.services.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // workforce
         if (this.workforce != null)  {
            encoder.encodeStartElement("workforce", "", "");
            this.workforce.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // hygieneAndSafety
         if (_set_hygieneAndSafety)  {
            encoder.encodeStartElement("hygieneAndSafety", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.hygieneAndSafety, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // postOffice
         if (this.postOffice != null)  {
            encoder.encodeStartElement("postOffice", "", "");
            this.postOffice.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // maintenance
         if (_set_maintenance)  {
            encoder.encodeStartElement("maintenance", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.maintenance, xbContext);
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

   public class NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opordlog",
          "NC1_OPORD-LOG_ELEM_2__4_administrativeAndLogisticsServices");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","A_equipmentAndServices"),
         new XBQualifiedName("","B_medEvacuationAndTreatment"),
         new XBQualifiedName("","C_staff"),
         new XBQualifiedName("","D_foreignAndHostNationSupport"),
         new XBQualifiedName("","E_miscellaneous")
      };
      static NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices() {
         XBUtil.license =  _NC1_OPORD_LOG.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices a_equipmentAndServices;
            //optional
      protected  MixedAnyType b_medEvacuationAndTreatment;   //optional
      protected  MixedAnyType c_staff;   //optional
      protected  MixedAnyType d_foreignAndHostNationSupport;   //optional
         
      protected  MixedAnyType e_miscellaneous;   //optional

      //attribute methods

      //content methods

      public  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices A_equipmentAndServices
      {
         get
         {
            if (this.a_equipmentAndServices == null)
                throw new XBException("field a_equipmentAndServices not set");

            return this.a_equipmentAndServices;
         }
         set
         {
            this.a_equipmentAndServices = value;
         }
      }

      public  MixedAnyType B_medEvacuationAndTreatment
      {
         get
         {
            if (this.b_medEvacuationAndTreatment == null)
                throw new XBException("field b_medEvacuationAndTreatment not set");

            return this.b_medEvacuationAndTreatment;
         }
         set
         {
            this.b_medEvacuationAndTreatment = value;
         }
      }

      public  MixedAnyType C_staff
      {
         get
         {
            if (this.c_staff == null)
                throw new XBException("field c_staff not set");

            return this.c_staff;
         }
         set
         {
            this.c_staff = value;
         }
      }

      public  MixedAnyType D_foreignAndHostNationSupport
      {
         get
         {
            if (this.d_foreignAndHostNationSupport == null)
                throw new XBException("field d_foreignAndHostNationSupport not set");

            return this.d_foreignAndHostNationSupport;
         }
         set
         {
            this.d_foreignAndHostNationSupport = value;
         }
      }

      public  MixedAnyType E_miscellaneous
      {
         get
         {
            if (this.e_miscellaneous == null)
                throw new XBException("field e_miscellaneous not set");

            return this.e_miscellaneous;
         }
         set
         {
            this.e_miscellaneous = value;
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

               // a_equipmentAndServices
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.a_equipmentAndServices = new  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices_A_equipmentAndServices();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.a_equipmentAndServices.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // b_medEvacuationAndTreatment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.b_medEvacuationAndTreatment = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.b_medEvacuationAndTreatment.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // c_staff
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.c_staff = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.c_staff.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // d_foreignAndHostNationSupport
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.d_foreignAndHostNationSupport = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.d_foreignAndHostNationSupport.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // e_miscellaneous
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.e_miscellaneous = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.e_miscellaneous.decode(reader, xbContext, false, false);

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

         // a_equipmentAndServices
         if (this.a_equipmentAndServices != null)  {
            encoder.encodeStartElement("A_equipmentAndServices", "", "");
            this.a_equipmentAndServices.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // b_medEvacuationAndTreatment
         if (this.b_medEvacuationAndTreatment != null)  {
            encoder.encodeStartElement("B_medEvacuationAndTreatment", "", "");
            this.b_medEvacuationAndTreatment.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
         }

         // c_staff
         if (this.c_staff != null)  {
            encoder.encodeStartElement("C_staff", "", "");
            this.c_staff.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // d_foreignAndHostNationSupport
         if (this.d_foreignAndHostNationSupport != null)  {
            encoder.encodeStartElement("D_foreignAndHostNationSupport", "", "");
            this.d_foreignAndHostNationSupport.encode(encoder, xbContext, 
               null, false);
            encoder.encodeEndElement();
         }

         // e_miscellaneous
         if (this.e_miscellaneous != null)  {
            encoder.encodeStartElement("E_miscellaneous", "", "");
            this.e_miscellaneous.encode(encoder, xbContext, null, false);
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

   public class NC1_OPORD_LOG_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:opordlog",
          "NC1_OPORD-LOG_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","_1_situation"),
         new XBQualifiedName("","_2_mission"),
         new XBQualifiedName("","_3_execution"),
         new XBQualifiedName("","_4_administrativeAndLogisticsServices"),
         new XBQualifiedName("","_5_commandAndTransmissions"),
         new XBQualifiedName("","acknowledgement"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","signature")
      };
      static NC1_OPORD_LOG_ELEM() {
         XBUtil.license =  _NC1_OPORD_LOG.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  MixedAnyType _1_situation;   //optional
      protected  MixedAnyType _2_mission;   //optional
      protected  MixedAnyType _3_execution;   //optional
      protected  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices _4_administrativeAndLogisticsServices;
            //optional
      protected  MixedAnyType _5_commandAndTransmissions;   //optional
      protected bool acknowledgement;
      protected bool _set_acknowledgement = false;
      protected  CommentSectionType comment;   //optional
      protected  SignatureType signature_;   //optional

      //attribute methods

      //content methods

      public  MixedAnyType _1_situationProperty
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

      public  MixedAnyType _2_missionProperty
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

      public  MixedAnyType _3_executionProperty
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

      public  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices _4_administrativeAndLogisticsServicesProperty
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

      public  MixedAnyType _5_commandAndTransmissionsProperty
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

               // _1_situation
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this._1_situation = new  MixedAnyType();
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
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this._2_mission = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._2_mission.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // _3_execution
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this._3_execution = new  MixedAnyType();
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
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this._4_administrativeAndLogisticsServices = new  NC1_OPORD_LOG_ELEM_2__4_administrativeAndLogisticsServices();
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
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this._5_commandAndTransmissions = new  MixedAnyType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this._5_commandAndTransmissions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // acknowledgement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  this.signature_ = new  SignatureType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.signature_.decode(reader, xbContext, false, false);

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

         // _1_situation
         if (this._1_situation != null)  {
            encoder.encodeStartElement("_1_situation", "", "");
            this._1_situation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _2_mission
         if (this._2_mission != null)  {
            encoder.encodeStartElement("_2_mission", "", "");
            this._2_mission.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

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

   public class NC1_OPORD_LOG_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:opordlog","NC1_OPORD-LOG")
      };
      static NC1_OPORD_LOG_CC() {
         XBUtil.license =  _NC1_OPORD_LOG.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_OPORD_LOG_ELEM nC1_OPORD_LOG;

      //content methods

      public  NC1_OPORD_LOG_ELEM NC1_OPORD_LOG
      {
         get
         {
            if (this.nC1_OPORD_LOG == null)
                throw new XBException("field nC1_OPORD_LOG not set");

            return this.nC1_OPORD_LOG;
         }
         set
         {
            this.nC1_OPORD_LOG = value;
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
         //   encoder.setNamespaces(_NC1_OPORD_LOG.namespaceContext);

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

            // nC1_OPORD_LOG
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_OPORD_LOG = new  NC1_OPORD_LOG_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_OPORD_LOG.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_OPORD_LOG");

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

         // nC1_OPORD_LOG
         if (this.nC1_OPORD_LOG == null)
             throw new XBException("field nC1_OPORD_LOG not set");

         encoder.encodeStartElement("NC1_OPORD-LOG",  _NC1_OPORD_LOG.NS_URI,  _NC1_OPORD_LOG.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_OPORD_LOG.encode(encoder, xbContext, null, false);
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

   public class _NC1_OPORD_LOG {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:opordlog";
      public static readonly String NS_PREFIX = "nc1opordlog";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_OPORD_LOG() {
      }
      static _NC1_OPORD_LOG() {
         XBUtil.license = _NC1_OPORD_LOG.license;
      }
   }
}
