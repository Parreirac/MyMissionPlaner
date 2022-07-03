using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Msg {

   using System.IO;
   using System.Xml;
    using NC1.Obj;
    using LongitudeType = NC1.Location.LongitudeType;
    using LatitudeType = NC1.Location.LatitudeType;
    using AltitudeType = NC1.Location.AltitudeType;
   
   public class ClassificationCode
   {
      static ClassificationCode() {
         XBUtil.license =  _Message.license;
      }

      //constructor
      private ClassificationCode() {} 


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

   public class Nc1MessageIdType
   {
      static Nc1MessageIdType() {
         XBUtil.license =  _Message.license;
      }

      //constructor
      private Nc1MessageIdType() {} 


      public static String encode(uint value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static uint decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint value = 0;
         value = XBSimpleType.parseUInt32(text);
         return value;
      }
   }

   public class ListOfIdType
   {
      static ListOfIdType() {
         XBUtil.license =  _Message.license;
      }

      //constructor
      private ListOfIdType() {} 


      public static String encode(uint[] value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         StringBuilder text_sb = new StringBuilder();
         String text_3;
         for(int i = 0; i < value.Length; i++) {
            text_3 =  Nc1MessageIdType.encode(value[i], xbContext);
            if ( i > 0 ) text_sb.Append(" ");
            text_sb.Append(text_3);
         }
         text_3 = text_sb.ToString();
         return text_3;
      }


      public static uint[] decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint[] value = null;
         if (text.Length == 0) value = new uint[0];
         else  {
            String[] _tokens = 
               text.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries)
               ;
            value = new uint[_tokens.Length];
            for(int _tokens_idx = 0; _tokens_idx < _tokens.Length; _tokens_idx++) 
            {
               value[_tokens_idx] =  Nc1MessageIdType.decode(_tokens[_tokens_idx], xbContext);
            }
         }
         return value;
      }
   }

   public class UrgencyLevelCode
   {
      static UrgencyLevelCode() {
         XBUtil.license =  _Message.license;
      }

      //constructor
      private UrgencyLevelCode() {} 


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

   public class BaseMessageType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "BaseMessageType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","extVersion"),
         new XBQualifiedName("","extFunction")
      };
      static BaseMessageType() {
         XBUtil.license =  _Message.license;
      }

      //attribute fields
      protected int classification;
      protected uint id;
      protected string lastChangeDatetime;
      protected byte majorVersion;
      protected byte mediumVersion;
      protected byte minorVersion;
      protected uint[] referenceMessageId;   //optional
      protected string situation;
      protected int urgencyLevel;

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  ExtVersType extVersion;   //optional
      protected  ExtFunctType extFunction;   //optional

      //attribute methods

      public int Classification
      {
         get { return this.classification; }
         set { this.classification = value; }
      }

      public uint Id
      {
         get { return this.id; }
         set { this.id = value; }
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

      public uint[] ReferenceMessageId
      {
         get
         {
            if (this.referenceMessageId == null)
                throw new XBException("field referenceMessageId not set");

            uint[] arrCopy = new uint[this.referenceMessageId.Length];
            this.referenceMessageId.CopyTo(arrCopy, 0);
            return arrCopy;
         }
         set
         {
            this.referenceMessageId = value;
            this.referenceMessageId = new uint[value.Length];
            value.CopyTo(this.referenceMessageId, 0);
         }
      }

      public string Situation
      {
         get { return this.situation; }
         set { this.situation = value; }
      }

      public int UrgencyLevel
      {
         get { return this.urgencyLevel; }
         set { this.urgencyLevel = value; }
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
            throw new XBValidationException("missing attribute classification");
         if (!_attrPresenceFlags[1]) 
            throw new XBValidationException("missing attribute id");
         if (!_attrPresenceFlags[2]) 
            throw new XBValidationException("missing attribute lastChangeDatetime");
         if (!_attrPresenceFlags[3]) 
            throw new XBValidationException("missing attribute majorVersion");
         if (!_attrPresenceFlags[4]) 
            throw new XBValidationException("missing attribute mediumVersion");
         if (!_attrPresenceFlags[5]) 
            throw new XBValidationException("missing attribute minorVersion");
         if (!_attrPresenceFlags[6]) 
            throw new XBValidationException("missing attribute situation");
         if (!_attrPresenceFlags[7]) 
            throw new XBValidationException("missing attribute urgencyLevel");
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /*    classification    */
         if (name.CompareTo("classification") == 0  && ns.CompareTo("") == 0 ) 
         {
            text = XBSimpleType.whitespaceCollapse(text);
            this.classification =  ClassificationCode.decode(text, xbContext);
            _attrPresenceFlags[0] = true;
            return true;
         }

         /*    id    */
         else if (name.CompareTo("id") == 0  && ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.id =  Nc1MessageIdType.decode(text, xbContext);
            _attrPresenceFlags[1] = true;
            return true;
         }

         /*    lastChangeDatetime    */
         else if (name.CompareTo("lastChangeDatetime") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.lastChangeDatetime = text;
            _attrPresenceFlags[2] = true;
            return true;
         }

         /*    majorVersion    */
         else if (name.CompareTo("majorVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.majorVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[3] = true;
            return true;
         }

         /*    mediumVersion    */
         else if (name.CompareTo("mediumVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.mediumVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[4] = true;
            return true;
         }

         /*    minorVersion    */
         else if (name.CompareTo("minorVersion") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.minorVersion =  Int0To99Type.decode(text, xbContext);
            _attrPresenceFlags[5] = true;
            return true;
         }

         /*    referenceMessageId    */
         else if (name.CompareTo("referenceMessageId") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.referenceMessageId =  ListOfIdType.decode(text, xbContext);
            return true;
         }

         /*    situation    */
         else if (name.CompareTo("situation") == 0  && ns.CompareTo("") == 0 ) 
         {
            this.situation =  MessageTextObjectType.decode(text, xbContext);
            _attrPresenceFlags[6] = true;
            return true;
         }

         /*    urgencyLevel    */
         else if (name.CompareTo("urgencyLevel") == 0  && 
            ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.urgencyLevel =  UrgencyLevelCode.decode(text, xbContext);
            _attrPresenceFlags[7] = true;
            return true;
         }
         else  {
            return false;
         }
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /* classification -> classification    */
         String text_3;
         text_3 =  ClassificationCode.encode(this.classification, xbContext);
         encoder.encodeAttr("classification", "", "", text_3);

         /* id -> id    */
         text_3 =  Nc1MessageIdType.encode(this.id, xbContext);
         encoder.encodeAttr("id", "", "", text_3);

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

         /* referenceMessageId -> referenceMessageId    */
         if (this.referenceMessageId != null) {
            text_3 =  ListOfIdType.encode(this.referenceMessageId, xbContext);
            encoder.encodeAttr("referenceMessageId", "", "", text_3);
         }

         /* situation -> situation    */
         text_3 =  MessageTextObjectType.encode(this.situation, xbContext);
         encoder.encodeAttr("situation", "", "", text_3);

         /* urgencyLevel -> urgencyLevel    */
         text_3 =  UrgencyLevelCode.encode(this.urgencyLevel, xbContext);
         encoder.encodeAttr("urgencyLevel", "", "", text_3);
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

   public class CommentSectionType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "CommentSectionType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","url")
      };
      static CommentSectionType() {
         XBUtil.license =  _Message.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string comment;
      protected bool _set_comment = false;
      protected string url;
      protected bool _set_url = false;

      //attribute methods

      //content methods

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

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.comment =  LongTextType.decode(text, xbContext);

                  _set_comment = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // url
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.url =  MediumTextType.decode(text, xbContext);

                  _set_url = true;

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

         // comment
         if (_set_comment)  {
            encoder.encodeStartElement("comment", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.comment, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // url
         if (_set_url)  {
            encoder.encodeStartElement("url", "", "");
            String text_4;
            text_4 =  MediumTextType.encode(this.url, xbContext);
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

   public class HierarchyLevelType
   {
      private static XBPatternValidator patternValidator;

      static HierarchyLevelType() {
         XBUtil.license =  _Message.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[a-zA-Z0-9](.[a-zA-Z0-9])*");
         patternValidator = new XBPatternValidator(patternValidator);
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private HierarchyLevelType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 20)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 20)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class AnyReferenceType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "AnyReferenceType");
      private static XBPatternValidator value_patval;

      static AnyReferenceType() {
         XBUtil.license =  _Message.license;
         value_patval = new XBPatternValidator();
         value_patval.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //attribute fields
      protected string attachedFile;
      protected bool _set_attachedFile = false;
      protected string datetime;
      protected bool _set_datetime = false;
      protected string id;
      protected bool _set_id = false;
      protected string instance;
      protected bool _set_instance = false;
      protected string type;
      protected decimal x;
      protected bool _set_x = false;
      protected decimal y;
      protected bool _set_y = false;
      protected int z;
      protected bool _set_z = false;

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string value;

      //attribute methods

      public string AttachedFile
      {
         get
         {
            if (!_set_attachedFile)
                throw new XBException("field attachedFile not set");

            return this.attachedFile;
         }
         set
         {
            this.attachedFile = value;
            _set_attachedFile = true;
         }
      }

      public string Datetime
      {
         get
         {
            if (!_set_datetime)
                throw new XBException("field datetime not set");

            return this.datetime;
         }
         set
         {
            this.datetime = value;
            _set_datetime = true;
         }
      }

      public string Id
      {
         get
         {
            if (!_set_id) throw new XBException("field id not set");

            return this.id;
         }
         set
         {
            this.id = value;
            _set_id = true;
         }
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

      public string Type
      {
         get { return this.type; }
         set { this.type = value; }
      }

      public decimal X
      {
         get
         {
            if (!_set_x) throw new XBException("field x not set");

            return this.x;
         }
         set
         {
            this.x = value;
            _set_x = true;
         }
      }

      public decimal Y
      {
         get
         {
            if (!_set_y) throw new XBException("field y not set");

            return this.y;
         }
         set
         {
            this.y = value;
            _set_y = true;
         }
      }

      public int Z
      {
         get
         {
            if (!_set_z) throw new XBException("field z not set");

            return this.z;
         }
         set
         {
            this.z = value;
            _set_z = true;
         }
      }

      //content methods

      public string Value
      {
         get { return this.value; }
         set { this.value = value; }
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
            throw new XBValidationException("missing attribute type");
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /*    attachedFile    */
         if (name.CompareTo("attachedFile") == 0  && ns.CompareTo("") == 0 ) {
            this.attachedFile =  MediumTextObjectType.decode(text, xbContext);
            _set_attachedFile = true;
            return true;
         }

         /*    datetime    */
         else if (name.CompareTo("datetime") == 0  && ns.CompareTo("") == 0 ) 
         {
            text = XBSimpleType.whitespaceCollapse(text);
            this.datetime = text;
            _set_datetime = true;
            return true;
         }

         /*    id    */
         else if (name.CompareTo("id") == 0  && ns.CompareTo("") == 0 ) {
            this.id =  Nc1ObjectIdType.decode(text, xbContext);
            _set_id = true;
            return true;
         }

         /*    instance    */
         else if (name.CompareTo("instance") == 0  && ns.CompareTo("") == 0 ) 
         {
            this.instance =  ShortTextObjectType.decode(text, xbContext);
            _set_instance = true;
            return true;
         }

         /*    type    */
         else if (name.CompareTo("type") == 0  && ns.CompareTo("") == 0 ) {
            this.type =  ShortTextType.decode(text, xbContext);
            _attrPresenceFlags[0] = true;
            return true;
         }

         /*    x    */
         else if (name.CompareTo("x") == 0  && ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.x =  LongitudeType.decode(text, xbContext);
            _set_x = true;
            return true;
         }

         /*    y    */
         else if (name.CompareTo("y") == 0  && ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.y =  LatitudeType.decode(text, xbContext);
            _set_y = true;
            return true;
         }

         /*    z    */
         else if (name.CompareTo("z") == 0  && ns.CompareTo("") == 0 ) {
            text = XBSimpleType.whitespaceCollapse(text);
            this.z =  AltitudeType.decode(text, xbContext);
            _set_z = true;
            return true;
         }
         else  {
            return false;
         }
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /* attachedFile -> attachedFile    */
         if (_set_attachedFile) {
            String text_4;
            text_4 =  MediumTextObjectType.encode(this.attachedFile, xbContext);
            encoder.encodeAttr("attachedFile", "", "", text_4);
         }

         /* datetime -> datetime    */
         if (_set_datetime) {
            String text_4;
            text_4 = this.datetime;
            encoder.encodeAttr("datetime", "", "", text_4);
         }

         /* id -> id    */
         if (_set_id) {
            String text_4;
            text_4 =  Nc1ObjectIdType.encode(this.id, xbContext);
            encoder.encodeAttr("id", "", "", text_4);
         }

         /* instance -> instance    */
         if (_set_instance) {
            String text_4;
            text_4 =  ShortTextObjectType.encode(this.instance, xbContext);
            encoder.encodeAttr("instance", "", "", text_4);
         }

         /* type -> type    */
         String text_3;
         text_3 =  ShortTextType.encode(this.type, xbContext);
         encoder.encodeAttr("type", "", "", text_3);

         /* x -> x    */
         if (_set_x) {
            text_3 =  LongitudeType.encode(this.x, xbContext);
            encoder.encodeAttr("x", "", "", text_3);
         }

         /* y -> y    */
         if (_set_y) {
            text_3 =  LatitudeType.encode(this.y, xbContext);
            encoder.encodeAttr("y", "", "", text_3);
         }

         /* z -> z    */
         if (_set_z) {
            text_3 =  AltitudeType.encode(this.z, xbContext);
            encoder.encodeAttr("z", "", "", text_3);
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
         bool[] _attrPresenceFlags = new bool[1];

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
            //decode content
            try  {
               String text = reader.ReadString();
               if (!hasDefault || text.Length != 0 ) {
                  value_patval.validate(text);
                  this.value = text;
               }
               //else: empty, but default value is available
            }
            catch( System.Xml.XmlException e )  {
               throw new XBException(e.ToString(), e);
            }
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

         //encode content
         String text_3;
         text_3 = this.value;
         value_patval.validate(text_3);
         encoder.encodeChars(text_3);
      }
   }

   public class MixedAnyType_mixedText : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "MixedAnyType_mixedText");
      static MixedAnyType_mixedText() {
         XBUtil.license =  _Message.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected String mixedContent;

      //attribute methods

      //content methods

      public string MixedContent
      {
         get { return this.mixedContent; }
         set { this.mixedContent = value; }
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
            //consume all content as raw XML
            mixedContent = XMLStreamHelper.readContent(reader);
            return false;  //no content remains
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

         encoder.encodeCharsNoEscaping(mixedContent);
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

   public class MixedAnyType_objects : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "MixedAnyType_objects");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","object")
      };
      static MixedAnyType_objects() {
         XBUtil.license =  _Message.license;
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

   public class MixedAnyType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:message",
          "MixedAnyType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","mixedText"),
         new XBQualifiedName("","objects")
      };
      static MixedAnyType() {
         XBUtil.license =  _Message.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MixedAnyType_mixedText mixedText;
      protected  MixedAnyType_objects objects;   //optional

      //attribute methods

      //content methods

      public  MixedAnyType_mixedText MixedText
      {
         get
         {
            if (this.mixedText == null)
                throw new XBException("field mixedText not set");

            return this.mixedText;
         }
         set
         {
            this.mixedText = value;
         }
      }

      public  MixedAnyType_objects Objects
      {
         get
         {
            if (this.objects == null)
                throw new XBException("field objects not set");

            return this.objects;
         }
         set
         {
            this.objects = value;
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

               // mixedText
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.mixedText = new  MixedAnyType_mixedText();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.mixedText.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "mixedText");

               // objects
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.objects = new  MixedAnyType_objects();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.objects.decode(reader, xbContext, false, false);

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

         // mixedText
         if (this.mixedText == null)
             throw new XBException("field mixedText not set");

         encoder.encodeStartElement("mixedText", "", "");
         this.mixedText.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // objects
         if (this.objects != null)  {
            encoder.encodeStartElement("objects", "", "");
            this.objects.encode(encoder, xbContext, null, false);
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
   /**
    * This file was generated by the Objective Systems XBinder(tm) Compiler
    * (http://www.obj-sys.com).  Version: 2.7.0, Date: 19-Jun-2022.
    * Copyright (c) 2003-2021 Objective Systems, Inc.
    *
    * Permission is hereby granted to redistribute this file with the
    * condition that this copyright notice be present and not altered.
    */

   public class _Message {

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
      public static readonly String NS_URI = "urn:fra:nc1:common:message";
      public static readonly String NS_PREFIX = "nc1msgcom";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _Message() {
      }
      static _Message() {
         XBUtil.license = _Message.license;
      }
   }
}
