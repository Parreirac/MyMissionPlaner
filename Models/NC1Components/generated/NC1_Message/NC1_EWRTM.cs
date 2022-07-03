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
    using NC1.Ew;
    using NC1.Obj.unit;
    public class NC1_EWRTM_ELEM_2_ecmTargetInformation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ewrtm",
          "NC1_EWRTM_ELEM_2_ecmTargetInformation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","ecmtgt"),
         new XBQualifiedName("","_5etginfo"),
         new XBQualifiedName("","_5ecmact"),
         new XBQualifiedName("","_5etgfreq")
      };
      static NC1_EWRTM_ELEM_2_ecmTargetInformation() {
         XBUtil.license =  _NC1_EWRTM.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< EcmtgtType> ecmtgt;
      protected System.Collections.Generic.IList< _5etginfoType> _5etginfo;
         
      protected System.Collections.Generic.IList< _5ecmactType> _5ecmact;
         
      protected System.Collections.Generic.IList< _5etgfreqType> _5etgfreq;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< EcmtgtType> Ecmtgt
      {
         get
         {
            if (this.ecmtgt == null) {
               this.ecmtgt = new List< EcmtgtType>();
            }
            return this.ecmtgt;
         }
      }

      public System.Collections.Generic.IList< _5etginfoType> _5etginfoProperty
      {
         get
         {
            if (this._5etginfo == null) {
               this._5etginfo = new List< _5etginfoType>();
            }
            return this._5etginfo;
         }
      }

      public System.Collections.Generic.IList< _5ecmactType> _5ecmactProperty
      {
         get
         {
            if (this._5ecmact == null) {
               this._5ecmact = new List< _5ecmactType>();
            }
            return this._5ecmact;
         }
      }

      public System.Collections.Generic.IList< _5etgfreqType> _5etgfreqProperty
      {
         get
         {
            if (this._5etgfreq == null) {
               this._5etgfreq = new List< _5etgfreqType>();
            }
            return this._5etgfreq;
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

               // ecmtgt
               this.ecmtgt = new List< EcmtgtType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   EcmtgtType _tmp_ecmtgt;
                  _tmp_ecmtgt = new  EcmtgtType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_ecmtgt.decode(reader, xbContext, false, false);
                  this.ecmtgt.Add(_tmp_ecmtgt);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.ecmtgt.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.ecmtgt.Count, "ecmtgt");
               else if (this.ecmtgt.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // _5etginfo
               this._5etginfo = new List< _5etginfoType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   _5etginfoType _tmp__5etginfo;
                  _tmp__5etginfo = new  _5etginfoType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5etginfo.decode(reader, xbContext, false, false);
                  this._5etginfo.Add(_tmp__5etginfo);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // _5ecmact
               this._5ecmact = new List< _5ecmactType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   _5ecmactType _tmp__5ecmact;
                  _tmp__5ecmact = new  _5ecmactType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5ecmact.decode(reader, xbContext, false, false);
                  this._5ecmact.Add(_tmp__5ecmact);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // _5etgfreq
               this._5etgfreq = new List< _5etgfreqType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   _5etgfreqType _tmp__5etgfreq;
                  _tmp__5etgfreq = new  _5etgfreqType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5etgfreq.decode(reader, xbContext, false, false);
                  this._5etgfreq.Add(_tmp__5etgfreq);

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

         // ecmtgt
         if (this.ecmtgt == null || this.ecmtgt.Count < 1) 
            throw new XBOccurrencesException( (this.ecmtgt == null ? 0 : this.ecmtgt.Count ) );

         foreach ( EcmtgtType _tmp_ecmtgt in this.ecmtgt){
            encoder.encodeStartElement("ecmtgt", "", "");
            _tmp_ecmtgt.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _5etginfo
         if ( this._5etginfo != null ){
            foreach ( _5etginfoType _tmp__5etginfo in this._5etginfo){
               encoder.encodeStartElement("_5etginfo", "", "");
               _tmp__5etginfo.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // _5ecmact
         if ( this._5ecmact != null ){
            foreach ( _5ecmactType _tmp__5ecmact in this._5ecmact){
               encoder.encodeStartElement("_5ecmact", "", "");
               _tmp__5ecmact.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // _5etgfreq
         if ( this._5etgfreq != null ){
            foreach ( _5etgfreqType _tmp__5etgfreq in this._5etgfreq){
               encoder.encodeStartElement("_5etgfreq", "", "");
               _tmp__5etgfreq.encode(encoder, xbContext, null, false);
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

   public class NC1_EWRTM_ELEM_2_esmTargetInformation : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ewrtm",
          "NC1_EWRTM_ELEM_2_esmTargetInformation");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","esmtgt"),
         new XBQualifiedName("","_5etginfo"),
         new XBQualifiedName("","_5etgfreq"),
         new XBQualifiedName("","_5esmact")
      };
      static NC1_EWRTM_ELEM_2_esmTargetInformation() {
         XBUtil.license =  _NC1_EWRTM.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< EsmtgtType> esmtgt;
      protected System.Collections.Generic.IList< _5etginfoType> _5etginfo;
         
      protected System.Collections.Generic.IList< _5etgfreqType> _5etgfreq;
         
      protected System.Collections.Generic.IList< _5esmactType> _5esmact;
         

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< EsmtgtType> Esmtgt
      {
         get
         {
            if (this.esmtgt == null) {
               this.esmtgt = new List< EsmtgtType>();
            }
            return this.esmtgt;
         }
      }

      public System.Collections.Generic.IList< _5etginfoType> _5etginfoProperty
      {
         get
         {
            if (this._5etginfo == null) {
               this._5etginfo = new List< _5etginfoType>();
            }
            return this._5etginfo;
         }
      }

      public System.Collections.Generic.IList< _5etgfreqType> _5etgfreqProperty
      {
         get
         {
            if (this._5etgfreq == null) {
               this._5etgfreq = new List< _5etgfreqType>();
            }
            return this._5etgfreq;
         }
      }

      public System.Collections.Generic.IList< _5esmactType> _5esmactProperty
      {
         get
         {
            if (this._5esmact == null) {
               this._5esmact = new List< _5esmactType>();
            }
            return this._5esmact;
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

               // esmtgt
               this.esmtgt = new List< EsmtgtType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   EsmtgtType _tmp_esmtgt;
                  _tmp_esmtgt = new  EsmtgtType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_esmtgt.decode(reader, xbContext, false, false);
                  this.esmtgt.Add(_tmp_esmtgt);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.esmtgt.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.esmtgt.Count, "esmtgt");
               else if (this.esmtgt.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // _5etginfo
               this._5etginfo = new List< _5etginfoType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   _5etginfoType _tmp__5etginfo;
                  _tmp__5etginfo = new  _5etginfoType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5etginfo.decode(reader, xbContext, false, false);
                  this._5etginfo.Add(_tmp__5etginfo);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // _5etgfreq
               this._5etgfreq = new List< _5etgfreqType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   _5etgfreqType _tmp__5etgfreq;
                  _tmp__5etgfreq = new  _5etgfreqType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5etgfreq.decode(reader, xbContext, false, false);
                  this._5etgfreq.Add(_tmp__5etgfreq);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // _5esmact
               this._5esmact = new List< _5esmactType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   _5esmactType _tmp__5esmact;
                  _tmp__5esmact = new  _5esmactType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__5esmact.decode(reader, xbContext, false, false);
                  this._5esmact.Add(_tmp__5esmact);

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

         // esmtgt
         if (this.esmtgt == null || this.esmtgt.Count < 1) 
            throw new XBOccurrencesException( (this.esmtgt == null ? 0 : this.esmtgt.Count ) );

         foreach ( EsmtgtType _tmp_esmtgt in this.esmtgt){
            encoder.encodeStartElement("esmtgt", "", "");
            _tmp_esmtgt.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _5etginfo
         if ( this._5etginfo != null ){
            foreach ( _5etginfoType _tmp__5etginfo in this._5etginfo){
               encoder.encodeStartElement("_5etginfo", "", "");
               _tmp__5etginfo.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // _5etgfreq
         if ( this._5etgfreq != null ){
            foreach ( _5etgfreqType _tmp__5etgfreq in this._5etgfreq){
               encoder.encodeStartElement("_5etgfreq", "", "");
               _tmp__5etgfreq.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // _5esmact
         if ( this._5esmact != null ){
            foreach ( _5esmactType _tmp__5esmact in this._5esmact){
               encoder.encodeStartElement("_5esmact", "", "");
               _tmp__5esmact.encode(encoder, xbContext, null, false);
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

   public class NC1_EWRTM_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ewrtm",
          "NC1_EWRTM_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","taskedUnit"),
         new XBQualifiedName("","ecmTargetInformation"),
         new XBQualifiedName("","esmTargetInformation"),
         new XBQualifiedName("","_8chaff"),
         new XBQualifiedName("","_8timeloc")
      };
      static NC1_EWRTM_ELEM() {
         XBUtil.license =  _NC1_EWRTM.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  UnitType taskedUnit;   //optional
      protected System.Collections.Generic.IList< NC1_EWRTM_ELEM_2_ecmTargetInformation> ecmTargetInformation;
         
      protected System.Collections.Generic.IList< NC1_EWRTM_ELEM_2_esmTargetInformation> esmTargetInformation;
         
      protected System.Collections.Generic.IList< _8ChaffType> _8chaff;
      protected System.Collections.Generic.IList< _8timelocType> _8timeloc;
         

      //attribute methods

      //content methods

      public  UnitType TaskedUnit
      {
         get
         {
            if (this.taskedUnit == null)
                throw new XBException("field taskedUnit not set");

            return this.taskedUnit;
         }
         set
         {
            this.taskedUnit = value;
         }
      }

      public System.Collections.Generic.IList< NC1_EWRTM_ELEM_2_ecmTargetInformation> EcmTargetInformation
      {
         get
         {
            if (this.ecmTargetInformation == null) {
               this.ecmTargetInformation = 
                  new List< NC1_EWRTM_ELEM_2_ecmTargetInformation>();
            }
            return this.ecmTargetInformation;
         }
      }

      public System.Collections.Generic.IList< NC1_EWRTM_ELEM_2_esmTargetInformation> EsmTargetInformation
      {
         get
         {
            if (this.esmTargetInformation == null) {
               this.esmTargetInformation = 
                  new List< NC1_EWRTM_ELEM_2_esmTargetInformation>();
            }
            return this.esmTargetInformation;
         }
      }

      public System.Collections.Generic.IList< _8ChaffType> _8chaffProperty
      {
         get
         {
            if (this._8chaff == null) {
               this._8chaff = new List< _8ChaffType>();
            }
            return this._8chaff;
         }
      }

      public System.Collections.Generic.IList< _8timelocType> _8timelocProperty
      {
         get
         {
            if (this._8timeloc == null) {
               this._8timeloc = new List< _8timelocType>();
            }
            return this._8timeloc;
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

               // taskedUnit
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.taskedUnit = new  UnitType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.taskedUnit.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ecmTargetInformation
               this.ecmTargetInformation = 
                  new List< NC1_EWRTM_ELEM_2_ecmTargetInformation>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   NC1_EWRTM_ELEM_2_ecmTargetInformation _tmp_ecmTargetInformation;
                  _tmp_ecmTargetInformation = new  NC1_EWRTM_ELEM_2_ecmTargetInformation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_ecmTargetInformation.decode(reader, xbContext, false, false);
                  this.ecmTargetInformation.Add(_tmp_ecmTargetInformation);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.ecmTargetInformation.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.ecmTargetInformation.Count, "ecmTargetInformation");
               else if (this.ecmTargetInformation.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // esmTargetInformation
               this.esmTargetInformation = 
                  new List< NC1_EWRTM_ELEM_2_esmTargetInformation>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   NC1_EWRTM_ELEM_2_esmTargetInformation _tmp_esmTargetInformation;
                  _tmp_esmTargetInformation = new  NC1_EWRTM_ELEM_2_esmTargetInformation();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_esmTargetInformation.decode(reader, xbContext, false, false);
                  this.esmTargetInformation.Add(_tmp_esmTargetInformation);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.esmTargetInformation.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.esmTargetInformation.Count, "esmTargetInformation");
               else if (this.esmTargetInformation.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // _8chaff
               this._8chaff = new List< _8ChaffType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   _8ChaffType _tmp__8chaff;
                  _tmp__8chaff = new  _8ChaffType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__8chaff.decode(reader, xbContext, false, false);
                  this._8chaff.Add(_tmp__8chaff);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // _8timeloc
               this._8timeloc = new List< _8timelocType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   _8timelocType _tmp__8timeloc;
                  _tmp__8timeloc = new  _8timelocType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp__8timeloc.decode(reader, xbContext, false, false);
                  this._8timeloc.Add(_tmp__8timeloc);

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

         // taskedUnit
         if (this.taskedUnit != null)  {
            encoder.encodeStartElement("taskedUnit", "", "");
            this.taskedUnit.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // ecmTargetInformation
         if (this.ecmTargetInformation == null || 
            this.ecmTargetInformation.Count < 1) 
            throw new XBOccurrencesException( (this.ecmTargetInformation == null ? 0 : this.ecmTargetInformation.Count ) );

         foreach ( NC1_EWRTM_ELEM_2_ecmTargetInformation _tmp_ecmTargetInformation in this.ecmTargetInformation)
         {
            encoder.encodeStartElement("ecmTargetInformation", "", "");
            _tmp_ecmTargetInformation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // esmTargetInformation
         if (this.esmTargetInformation == null || 
            this.esmTargetInformation.Count < 1) 
            throw new XBOccurrencesException( (this.esmTargetInformation == null ? 0 : this.esmTargetInformation.Count ) );

         foreach ( NC1_EWRTM_ELEM_2_esmTargetInformation _tmp_esmTargetInformation in this.esmTargetInformation)
         {
            encoder.encodeStartElement("esmTargetInformation", "", "");
            _tmp_esmTargetInformation.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // _8chaff
         if ( this._8chaff != null ){
            foreach ( _8ChaffType _tmp__8chaff in this._8chaff){
               encoder.encodeStartElement("_8chaff", "", "");
               _tmp__8chaff.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // _8timeloc
         if ( this._8timeloc != null ){
            foreach ( _8timelocType _tmp__8timeloc in this._8timeloc){
               encoder.encodeStartElement("_8timeloc", "", "");
               _tmp__8timeloc.encode(encoder, xbContext, null, false);
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

   public class NC1_EWRTM_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:ewrtm","NC1_EWRTM")
      };
      static NC1_EWRTM_CC() {
         XBUtil.license =  _NC1_EWRTM.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_EWRTM_ELEM nC1_EWRTM;

      //content methods

      public  NC1_EWRTM_ELEM NC1_EWRTM
      {
         get
         {
            if (this.nC1_EWRTM == null)
                throw new XBException("field nC1_EWRTM not set");

            return this.nC1_EWRTM;
         }
         set
         {
            this.nC1_EWRTM = value;
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
         //   encoder.setNamespaces(_NC1_EWRTM.namespaceContext);

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

            // nC1_EWRTM
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_EWRTM = new  NC1_EWRTM_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_EWRTM.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_EWRTM");

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

         // nC1_EWRTM
         if (this.nC1_EWRTM == null)
             throw new XBException("field nC1_EWRTM not set");

         encoder.encodeStartElement("NC1_EWRTM",  _NC1_EWRTM.NS_URI,  _NC1_EWRTM.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_EWRTM.encode(encoder, xbContext, null, false);
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

   public class _NC1_EWRTM {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:ewrtm";
      public static readonly String NS_PREFIX = "nc1ewrtm";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_EWRTM() {
      }
      static _NC1_EWRTM() {
         XBUtil.license = _NC1_EWRTM.license;
      }
   }
}
