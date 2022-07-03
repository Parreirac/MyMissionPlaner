using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1 {

   using System.IO;
   using System.Xml;
    using NC1.Dictionnaries;
   public class TextLightObjectType
   {
      private static XBPatternValidator patternValidator;

      static TextLightObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:]*");
      }

      //constructor
      private TextLightObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class ShortTextObjectType
   {
      private static XBPatternValidator patternValidator;

      static ShortTextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:]*");
      }

      //constructor
      private ShortTextObjectType() {} 


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

   public class SymbolCodeType
   {
      private static XBPatternValidator patternValidator;

      static SymbolCodeType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9]*:[A-Z0-9\\-]{15}");
      }

      //constructor
      private SymbolCodeType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 16 || value.Length > 21)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 16 || text.Length > 21)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Nc1ObjectIdType
   {
      private static XBPatternValidator patternValidator;

      static Nc1ObjectIdType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("([1-5]?[0-9]|6[0-3])(:(1638[0-3]|163[0-7][0-9]|16[0-2][0-9]{2}|1[0-5][0-9]{3}|[1-9][0-9]{3}|[1-9][0-9]{2}|[1-9][0-9]|[0-9])){2}");
      }

      //constructor
      private Nc1ObjectIdType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 5 || value.Length > 14)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 5 || text.Length > 14)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Nc1ObjectRefType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "Nc1ObjectRefType");
      static Nc1ObjectRefType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields
      protected string id;
      protected string instance;
      protected bool _set_instance = false;

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields

      //attribute methods

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

      //content methods

      /**
       * Validate attributes after decoding.
       * Checks required attributes are set.
       * Assigns missing optional attributes default value.
       *
       * @param _attrPresenceFlags Flags set during decoding.
       */
      protected virtual void validateAttrs(bool[] _attrPresenceFlags){
         if (!_attrPresenceFlags[0]) 
            throw new XBValidationException("missing attribute id");
      }


      protected virtual bool decodeAttr(String name, String ns, String prefix, 
         String text, bool[] _attrPresenceFlags, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /*    id    */
         if (name.CompareTo("id") == 0  && ns.CompareTo("") == 0 ) {
            this.id =  Nc1ObjectIdType.decode(text, xbContext);
            _attrPresenceFlags[0] = true;
            return true;
         }

         /*    instance    */
         else if (name.CompareTo("instance") == 0  && ns.CompareTo("") == 0 ) 
         {
            this.instance =  ShortTextObjectType.decode(text, xbContext);
            _set_instance = true;
            return true;
         }
         else  {
            return false;
         }
      }

      protected virtual void encodeAttrs(XBXmlEncoder encoder, 
         com.objsys.xbinder.runtime.XBContext xbContext) {

         /* id -> id    */
         String text_3;
         text_3 =  Nc1ObjectIdType.encode(this.id, xbContext);
         encoder.encodeAttr("id", "", "", text_3);

         /* instance -> instance    */
         if (_set_instance) {
            text_3 =  ShortTextObjectType.encode(this.instance, xbContext);
            encoder.encodeAttr("instance", "", "", text_3);
         }
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
            if (elementEmpty)  {
               moreContent_4 = false;
            }
            else  {
               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            if (decodeAllContent && moreContent_4) 
               throw new XBUnexpectedElementException(reader.NamespaceURI, reader.LocalName);
            //no content to decode locally
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

         //no content to encode
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

   public class Tnl16Type
   {
      private static XBPatternValidator patternValidator;

      static Tnl16Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[0-7A-HJ-NP-Z]{2}[0-7]{3}");
      }

      //constructor
      private Tnl16Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 5 || value.Length > 5)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 5 || text.Length > 5)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class TextObjectType
   {
      private static XBPatternValidator patternValidator;

      static TextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private TextObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class MediumTextObjectType
   {
      private static XBPatternValidator patternValidator;

      static MediumTextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private MediumTextObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 150)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 150)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class LongTextObjectType
   {
      private static XBPatternValidator patternValidator;

      static LongTextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private LongTextObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 500)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 500)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class ExtVersType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "ExtVersType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new String[] { "" }
      };
      static ExtVersType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList<String> any;

      //attribute methods

      //content methods

      public System.Collections.Generic.IList<String> Any
      {
         get
         {
            if (this.any == null) {
               this.any = new List<String>();
            }
            return this.any;
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

               // any
               this.any = new List<String>();
               if (moreContent_4) while( 0 <= XBArrays.linearSearch(
                  (String[])particleInfo[0], elemNs) )
               {
                  string _tmp_any;
                  _tmp_any = XMLStreamHelper.readElementAndContent(reader);
                  this.any.Add(_tmp_any);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.any.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.any.Count, "any");
               else if (this.any.Count == 0 && moreContent_4) 
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

         // any
         if (this.any == null || this.any.Count < 1) 
            throw new XBOccurrencesException( (this.any == null ? 0 : this.any.Count ) );

         foreach (string _tmp_any in this.any){
            String text_4;
            //use text_4 to hold namespace of element in fragment
            text_4 = encoder.checkWellFormedElementAndContent(_tmp_any);
            if (0 > XBArrays.linearSearch((String[])particleInfo[0], text_4)) 
               throw new XBValidationException("wildcard does not allow namespace \"" + text_4 + "\"");
            encoder.encodeCharsNoEscaping(_tmp_any);
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

   public class ExtFunctType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "ExtFunctType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = Array.Empty<object>();
      static ExtFunctType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList<String> any;

      //attribute methods

      //content methods

      public System.Collections.Generic.IList<String> Any
      {
         get
         {
            if (this.any == null) {
               this.any = new List<String>();
            }
            return this.any;
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

               // any
               this.any = new List<String>();
               if (moreContent_4) while( (elemNs.Length != 0
                   && elemNs.CompareTo("urn:fra:nc1:common:attribute") != 0 )
                   )
               {
                  string _tmp_any;
                  _tmp_any = XMLStreamHelper.readElementAndContent(reader);
                  this.any.Add(_tmp_any);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.any.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.any.Count, "any");
               else if (this.any.Count == 0 && moreContent_4) 
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

         // any
         if (this.any == null || this.any.Count < 1) 
            throw new XBOccurrencesException( (this.any == null ? 0 : this.any.Count ) );

         foreach (string _tmp_any in this.any){
            String text_4;
            //use text_4 to hold namespace of element in fragment
            text_4 = encoder.checkWellFormedElementAndContent(_tmp_any);
            if ((text_4.Length == 0
                || text_4.CompareTo("urn:fra:nc1:common:attribute") == 0 )) 
               throw new XBValidationException("wildcard does not allow namespace \"" + text_4 + "\"");
            encoder.encodeCharsNoEscaping(_tmp_any);
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

   public class Int0To99Type
   {
      public static readonly byte _MAX = 99;
      static Int0To99Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To99Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class ABNSType
   {
      private static XBPatternValidator patternValidator;

      static ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class ABNType
   {
      private static XBPatternValidator patternValidator;

      static ABNType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 ]*");
      }

      //constructor
      private ABNType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class AlphaNumSpaceStringType
   {
      private static XBPatternValidator patternValidator;

      static AlphaNumSpaceStringType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9 ]*");
      }

      //constructor
      private AlphaNumSpaceStringType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class AlphaNumStringType
   {
      private static XBPatternValidator patternValidator;

      static AlphaNumStringType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9]*");
      }

      //constructor
      private AlphaNumStringType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class AngleType
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 360;
      static AngleType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private AngleType() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
            try
            {
                value = XBSimpleType.parseDouble(text);  // TODO PRA plante !!! 
            }
            catch (Exception e) {
              var ret = MyMissionPlaner.Helpers.MyHelpers.MyDouble.TryParse(text, out value);// TODO PRA si faux ...
            
            }

         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class ANSType
   {
      private static XBPatternValidator patternValidator;

      static ANSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9\\.]*");
      }

      //constructor
      private ANSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class ANType
   {
      private static XBPatternValidator patternValidator;

      static ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class AType
   {
      private static XBPatternValidator patternValidator;

      static AType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z]*");
      }

      //constructor
      private AType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class CycleFrequencyCode
   {
      static CycleFrequencyCode() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private CycleFrequencyCode() {} 


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

   public class Decimal0To1000000Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 1000000;
      static Decimal0To1000000Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To1000000Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To20Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 20;
      static Decimal0To20Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To20Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To99999999999999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 99999999999999;
      static Decimal0To99999999999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To99999999999999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To9999999999999Digits3Type
   {
      public static readonly decimal _MIN = 0M;
      public static readonly decimal _MAX = 9999999999999M;
      static Decimal0To9999999999999Digits3Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To9999999999999Digits3Type() {} 


      public static String encode(decimal value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = XBSimpleType.formatDecimal(value, -1, 3, 0, 1, false, false, false);
         return text_3;
      }


      public static decimal decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         decimal value = 0;
         value = XBSimpleType.parseDecimalAndValidate(text, -1, 3);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To99999999999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 99999999999;
      static Decimal0To99999999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To99999999999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To9999999999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 9999999999;
      static Decimal0To9999999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To9999999999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To99999999Digits3Type
   {
      public static readonly decimal _MIN = 0M;
      public static readonly decimal _MAX = 99999999M;
      static Decimal0To99999999Digits3Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To99999999Digits3Type() {} 


      public static String encode(decimal value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = XBSimpleType.formatDecimal(value, -1, 3, 0, 1, false, false, false);
         return text_3;
      }


      public static decimal decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         decimal value = 0;
         value = XBSimpleType.parseDecimalAndValidate(text, -1, 3);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To99999999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 99999999;
      static Decimal0To99999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To99999999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To999999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 999999;
      static Decimal0To999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To999999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To9999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 9999;
      static Decimal0To9999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To9999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To999Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 999;
      static Decimal0To999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To999Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Decimal0To99Type
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 99;
      static Decimal0To99Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Decimal0To99Type() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class DimensionType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "DimensionType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","length"),
         new XBQualifiedName("","width"),
         new XBQualifiedName("","height"),
         new XBQualifiedName("","depth")
      };
      static DimensionType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double length;
      protected bool _set_length = false;
      protected double width;
      protected bool _set_width = false;
      protected double height;
      protected bool _set_height = false;
      protected double depth;
      protected bool _set_depth = false;

      //attribute methods

      //content methods

      public double Length
      {
         get
         {
            if (!_set_length) throw new XBException("field length not set");

            return this.length;
         }
         set
         {
            this.length = value;
            _set_length = true;
         }
      }

      public double Width
      {
         get
         {
            if (!_set_width) throw new XBException("field width not set");

            return this.width;
         }
         set
         {
            this.width = value;
            _set_width = true;
         }
      }

      public double Height
      {
         get
         {
            if (!_set_height) throw new XBException("field height not set");

            return this.height;
         }
         set
         {
            this.height = value;
            _set_height = true;
         }
      }

      public double Depth
      {
         get
         {
            if (!_set_depth) throw new XBException("field depth not set");

            return this.depth;
         }
         set
         {
            this.depth = value;
            _set_depth = true;
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

               // length
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.length =  Decimal0To999999Type.decode(text, xbContext);

                  _set_length = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // width
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.width =  Decimal0To999999Type.decode(text, xbContext);

                  _set_width = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // height
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.height =  Decimal0To999999Type.decode(text, xbContext);

                  _set_height = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // depth
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.depth =  Decimal0To999999Type.decode(text, xbContext);

                  _set_depth = true;

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

         // length
         if (_set_length)  {
            encoder.encodeStartElement("length", "", "");
            String text_4;
            text_4 =  Decimal0To999999Type.encode(this.length, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // width
         if (_set_width)  {
            encoder.encodeStartElement("width", "", "");
            String text_4;
            text_4 =  Decimal0To999999Type.encode(this.width, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // height
         if (_set_height)  {
            encoder.encodeStartElement("height", "", "");
            String text_4;
            text_4 =  Decimal0To999999Type.encode(this.height, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // depth
         if (_set_depth)  {
            encoder.encodeStartElement("depth", "", "");
            String text_4;
            text_4 =  Decimal0To999999Type.encode(this.depth, xbContext);
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

   public class Duration10YearsType
   {
      static Duration10YearsType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Duration10YearsType() {} 


      public static String encode(XBDuration value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static XBDuration decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         XBDuration value = null;
         value = XBDurationHelper.parseXML(text);
         return value;
      }
   }

   public class Duration1DayType
   {
      static Duration1DayType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Duration1DayType() {} 


      public static String encode(XBDuration value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static XBDuration decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         XBDuration value = null;
         value = XBDurationHelper.parseXML(text);
         return value;
      }
   }

   public class Duration1YearType
   {
      static Duration1YearType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Duration1YearType() {} 


      public static String encode(XBDuration value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static XBDuration decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         XBDuration value = null;
         value = XBDurationHelper.parseXML(text);
         return value;
      }
   }

   public class Duration999YearsType
   {
      static Duration999YearsType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Duration999YearsType() {} 


      public static String encode(XBDuration value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static XBDuration decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         XBDuration value = null;
         value = XBDurationHelper.parseXML(text);
         return value;
      }
   }

   public class Vmf_UrnType
   {
      public static readonly ulong _MAX = 16777215L;
      static Vmf_UrnType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Vmf_UrnType() {} 


      public static String encode(ulong value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ulong decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ulong value = 0;
         value = XBSimpleType.parseUInt64(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Vmf_EisnType
   {
      public static readonly ulong _MAX = 4294967295L;
      static Vmf_EisnType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Vmf_EisnType() {} 


      public static String encode(ulong value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ulong decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ulong value = 0;
         value = XBSimpleType.parseUInt64(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class EirnType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "EirnType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","urn"),
         new XBQualifiedName("","eisn")
      };
      static EirnType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected ulong urn;
      protected ulong eisn;
      protected bool _set_eisn = false;

      //attribute methods

      //content methods

      public ulong Urn
      {
         get { return this.urn; }
         set { this.urn = value; }
      }

      public ulong Eisn
      {
         get
         {
            if (!_set_eisn) throw new XBException("field eisn not set");

            return this.eisn;
         }
         set
         {
            this.eisn = value;
            _set_eisn = true;
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

               // urn
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.urn =  Vmf_UrnType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "urn");

               // eisn
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.eisn =  Vmf_EisnType.decode(text, xbContext);

                  _set_eisn = true;

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

         // urn
         encoder.encodeStartElement("urn", "", "");
         String text_3;
         text_3 =  Vmf_UrnType.encode(this.urn, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // eisn
         if (_set_eisn)  {
            encoder.encodeStartElement("eisn", "", "");
            text_3 =  Vmf_EisnType.encode(this.eisn, xbContext);
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

   public class ElevationAngleType
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 360;
      static ElevationAngleType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private ElevationAngleType() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To1000Type
   {
      public static readonly ushort _MAX = 1000;
      static Int0To1000Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To1000Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To100Type
   {
      public static readonly byte _MAX = 100;
      static Int0To100Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To100Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To150Type
   {
      public static readonly byte _MAX = 150;
      static Int0To150Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To150Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To15Type
   {
      public static readonly byte _MAX = 15;
      static Int0To15Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To15Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To16383Type
   {
      public static readonly ushort _MAX = 16383;
      static Int0To16383Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To16383Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To2147483647Type
   {
      public static readonly ulong _MAX = 2147483647L;
      static Int0To2147483647Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To2147483647Type() {} 


      public static String encode(ulong value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ulong decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ulong value = 0;
         value = XBSimpleType.parseUInt64(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To25000Type
   {
      public static readonly ushort _MAX = 25000;
      static Int0To25000Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To25000Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To255Type
   {
      static Int0To255Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To255Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         return value;
      }
   }

   public class Int0To30000Type
   {
      public static readonly ushort _MAX = 30000;
      static Int0To30000Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To30000Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To999999999999Type
   {
      public static readonly ulong _MAX = 999999999999L;
      static Int0To999999999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To999999999999Type() {} 


      public static String encode(ulong value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ulong decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ulong value = 0;
         value = XBSimpleType.parseUInt64(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To999999Type
   {
      public static readonly uint _MAX = 999999;
      static Int0To999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To999999Type() {} 


      public static String encode(uint value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static uint decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint value = 0;
         value = XBSimpleType.parseUInt32(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To99999Type
   {
      public static readonly uint _MAX = 99999;
      static Int0To99999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To99999Type() {} 


      public static String encode(uint value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static uint decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint value = 0;
         value = XBSimpleType.parseUInt32(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To9999Type
   {
      public static readonly ushort _MAX = 9999;
      static Int0To9999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To9999Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To999Type
   {
      public static readonly ushort _MAX = 999;
      static Int0To999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To999Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int0To9Type
   {
      public static readonly byte _MAX = 9;
      static Int0To9Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int0To9Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int1To999999Type
   {
      public static readonly uint _MIN = 1;
      public static readonly uint _MAX = 999999;
      static Int1To999999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int1To999999Type() {} 


      public static String encode(uint value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static uint decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint value = 0;
         value = XBSimpleType.parseUInt32(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int1To99999Type
   {
      public static readonly uint _MIN = 1;
      public static readonly uint _MAX = 99999;
      static Int1To99999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int1To99999Type() {} 


      public static String encode(uint value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static uint decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         uint value = 0;
         value = XBSimpleType.parseUInt32(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int1To999Type
   {
      public static readonly ushort _MIN = 1;
      public static readonly ushort _MAX = 999;
      static Int1To999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int1To999Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int1To99Type
   {
      public static readonly byte _MIN = 1;
      public static readonly byte _MAX = 99;
      static Int1To99Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int1To99Type() {} 


      public static String encode(byte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static byte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         byte value = 0;
         value = XBSimpleType.parseByte(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Int887To1140Type
   {
      public static readonly ushort _MIN = 887;
      public static readonly ushort _MAX = 1140;
      static Int887To1140Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Int887To1140Type() {} 


      public static String encode(ushort value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static ushort decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         ushort value = 0;
         value = XBSimpleType.parseUInt16(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class IntMinus63To63Type
   {
      public static readonly sbyte _MIN = -63;
      public static readonly sbyte _MAX = 63;
      static IntMinus63To63Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private IntMinus63To63Type() {} 


      public static String encode(sbyte value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static sbyte decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         sbyte value = 0;
         value = XBSimpleType.parseSByte(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class IntMinus999To999Type
   {
      public static readonly short _MIN = -999;
      public static readonly short _MAX = 999;
      static IntMinus999To999Type() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private IntMinus999To999Type() {} 


      public static String encode(short value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static short decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         short value = 0;
         value = XBSimpleType.parseInt16(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class LevelReferenceCode
   {
      static LevelReferenceCode() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private LevelReferenceCode() {} 


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

   public class TextType
   {
      private static XBPatternValidator patternValidator;

      static TextType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:\\n\\rÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private TextType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class LongTextType
   {
      private static XBPatternValidator patternValidator;

      static LongTextType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:\\n\\rÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private LongTextType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 500)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 500)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class MediumTextType
   {
      private static XBPatternValidator patternValidator;

      static MediumTextType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:\\n\\rÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private MediumTextType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 150)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 150)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class MessageTextObjectType
   {
      private static XBPatternValidator patternValidator;

      static MessageTextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private MessageTextObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 30)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 30)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class MultiposturePeriodType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "MultiposturePeriodType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","startDatetime"),
         new XBQualifiedName("","endDatetime"),
         new XBQualifiedName("","tacticalTime"),
         new XBQualifiedName("","periodDescription")
      };
      static MultiposturePeriodType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string startDatetime;
      protected bool _set_startDatetime = false;
      protected string endDatetime;
      protected bool _set_endDatetime = false;
      protected int tacticalTime;
      protected bool _set_tacticalTime = false;
      protected string periodDescription;
      protected bool _set_periodDescription = false;

      //attribute methods

      //content methods

      public string StartDatetime
      {
         get
         {
            if (!_set_startDatetime)
                throw new XBException("field startDatetime not set");

            return this.startDatetime;
         }
         set
         {
            this.startDatetime = value;
            _set_startDatetime = true;
         }
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

      public int TacticalTime
      {
         get
         {
            if (!_set_tacticalTime)
                throw new XBException("field tacticalTime not set");

            return this.tacticalTime;
         }
         set
         {
            this.tacticalTime = value;
            _set_tacticalTime = true;
         }
      }

      public string PeriodDescription
      {
         get
         {
            if (!_set_periodDescription)
                throw new XBException("field periodDescription not set");

            return this.periodDescription;
         }
         set
         {
            this.periodDescription = value;
            _set_periodDescription = true;
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

                  _set_startDatetime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

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
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // tacticalTime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.tacticalTime =  L114_10Code.decode(text, xbContext);

                  _set_tacticalTime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // periodDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.periodDescription =  LongTextObjectType.decode(text, xbContext);

                  _set_periodDescription = true;

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

         // startDatetime
         if (_set_startDatetime)  {
            encoder.encodeStartElement("startDatetime", "", "");
            String text_4;
            text_4 = this.startDatetime;
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // endDatetime
         if (_set_endDatetime)  {
            encoder.encodeStartElement("endDatetime", "", "");
            String text_4;
            text_4 = this.endDatetime;
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // tacticalTime
         if (_set_tacticalTime)  {
            encoder.encodeStartElement("tacticalTime", "", "");
            String text_4;
            text_4 =  L114_10Code.encode(this.tacticalTime, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // periodDescription
         if (_set_periodDescription)  {
            encoder.encodeStartElement("periodDescription", "", "");
            String text_4;
            text_4 =  LongTextObjectType.encode(this.periodDescription, xbContext);
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

   public class Nc1MessageTypeCode
   {
      static Nc1MessageTypeCode() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private Nc1MessageTypeCode() {} 


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

   public class NicCodeType
   {
      private static XBPatternValidator patternValidator;

      static NicCodeType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9]*");
      }

      //constructor
      private NicCodeType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length > 20)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length > 20)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class PeriodType : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "PeriodType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","startDatetime"),
         new XBQualifiedName("","duration")
      };
      static PeriodType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string startDatetime;
      protected XBDuration duration;   //optional

      //attribute methods

      //content methods

      public string StartDatetime
      {
         get { return this.startDatetime; }
         set { this.startDatetime = value; }
      }

      public XBDuration Duration
      {
         get
         {
            if (this.duration == null)
                throw new XBException("field duration not set");

            return this.duration;
         }
         set
         {
            this.duration = value;
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

               // duration
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.duration =  Duration10YearsType.decode(text, xbContext);

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

         // duration
         if (this.duration != null)  {
            encoder.encodeStartElement("duration", "", "");
            text_3 =  Duration10YearsType.encode(this.duration, xbContext);
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

   public class QualifiedDatetimeType : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:common:attribute",
          "QualifiedDatetimeType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","qualifier"),
         new XBQualifiedName("","datetime")
      };
      static QualifiedDatetimeType() {
         XBUtil.license =  _Common.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int qualifier;
      protected bool _set_qualifier = false;
      protected string datetime;
      protected bool _set_datetime = false;

      //attribute methods

      //content methods

      public int Qualifier
      {
         get
         {
            if (!_set_qualifier)
                throw new XBException("field qualifier not set");

            return this.qualifier;
         }
         set
         {
            this.qualifier = value;
            _set_qualifier = true;
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

               // qualifier
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.qualifier =  L111_14Code.decode(text, xbContext);

                  _set_qualifier = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // datetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.datetime = text;

                  _set_datetime = true;

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

         // qualifier
         if (_set_qualifier)  {
            encoder.encodeStartElement("qualifier", "", "");
            String text_4;
            text_4 =  L111_14Code.encode(this.qualifier, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // datetime
         if (_set_datetime)  {
            encoder.encodeStartElement("datetime", "", "");
            String text_4;
            text_4 = this.datetime;
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

   public class RatioType
   {
      public static readonly double _MIN = 0;
      public static readonly double _MAX = 1;
      static RatioType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private RatioType() {} 


      public static String encode(double value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 =  _Common.defaultDoubleFmt.format(value );
         return text_3;
      }


      public static double decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         double value = 0;
         value = XBSimpleType.parseDouble( text );
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class TextLightType
   {
      private static XBPatternValidator patternValidator;

      static TextLightType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private TextLightType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class ShortTextType
   {
      private static XBPatternValidator patternValidator;

      static ShortTextType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private ShortTextType() {} 


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

   public class SpeedType
   {
      public static readonly short _MIN = 0;
      public static readonly short _MAX = 2000;
      static SpeedType() {
         XBUtil.license =  _Common.license;
      }

      //constructor
      private SpeedType() {} 


      public static String encode(short value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static short decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         short value = 0;
         value = XBSimpleType.parseInt16(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class Stnl16Type
   {
      private static XBPatternValidator patternValidator;

      static Stnl16Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[0-7]{5}");
      }

      //constructor
      private Stnl16Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class Text1To10ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To10ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To10ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 10)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 10)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To10ANType
   {
      private static XBPatternValidator patternValidator;

      static Text1To10ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text1To10ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 10)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 10)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To15ANSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To15ANSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9\\.]*");
      }

      //constructor
      private Text1To15ANSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 15)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 15)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To15Type
   {
      private static XBPatternValidator patternValidator;

      static Text1To15Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private Text1To15Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 15)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 15)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To16ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To16ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To16ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 16)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 16)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To18ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To18ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To18ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 18)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 18)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class XType
   {
      private static XBPatternValidator patternValidator;

      static XType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 .,\\-\\(\\)!@#\\$%^&*=_+\\[\\]\\\\\"';<>~|]*");
      }

      //constructor
      private XType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class Text1To20XType
   {
      private static XBPatternValidator patternValidator;

      static Text1To20XType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 .,\\-\\(\\)!@#\\$%^&*=_+\\[\\]\\\\\"';<>~|]*");
      }

      //constructor
      private Text1To20XType() {} 


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

   public class Text1To30ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To30ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To30ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 30)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 30)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To30ObjectType
   {
      private static XBPatternValidator patternValidator;

      static Text1To30ObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private Text1To30ObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 30)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 30)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To30Type
   {
      private static XBPatternValidator patternValidator;

      static Text1To30Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private Text1To30Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 30)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 30)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To38ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To38ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9 \\.,\\-\\(\\)?]*");
         patternValidator = new XBPatternValidator(patternValidator);
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To38ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 38)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 38)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To38XType
   {
      private static XBPatternValidator patternValidator;

      static Text1To38XType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 .,\\-\\(\\)!@#\\$%^&*=_+\\[\\]\\\\\"';<>~|]*");
      }

      //constructor
      private Text1To38XType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 38)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 38)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To3ANType
   {
      private static XBPatternValidator patternValidator;

      static Text1To3ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text1To3ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 3)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 3)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To40Type
   {
      private static XBPatternValidator patternValidator;

      static Text1To40Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private Text1To40Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 40)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 40)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To4ANType
   {
      private static XBPatternValidator patternValidator;

      static Text1To4ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text1To4ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 4)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 4)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To50Type
   {
      private static XBPatternValidator patternValidator;

      static Text1To50Type() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:ÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private Text1To50Type() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 50)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 50)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To54ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To54ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To54ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 54)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 54)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To5ANType
   {
      private static XBPatternValidator patternValidator;

      static Text1To5ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text1To5ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 5)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 5)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To6ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To6ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To6ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 6)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 6)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To8ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To8ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To8ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 8)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 8)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To8ANType
   {
      private static XBPatternValidator patternValidator;

      static Text1To8ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text1To8ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 8)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 8)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To99ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To99ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To99ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 99)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 99)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To99XType
   {
      private static XBPatternValidator patternValidator;

      static Text1To99XType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 .,\\-\\(\\)!@#\\$%^&*=_+\\[\\]\\\\\"';<>~|]*");
      }

      //constructor
      private Text1To99XType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 99)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 99)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text1To9ABNSType
   {
      private static XBPatternValidator patternValidator;

      static Text1To9ABNSType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 \\.,\\-\\(\\)?]*");
      }

      //constructor
      private Text1To9ABNSType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 9)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 9)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text2To2AType
   {
      private static XBPatternValidator patternValidator;

      static Text2To2AType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z]{2}");
         patternValidator = new XBPatternValidator(patternValidator);
         patternValidator.addPattern("[A-Za-z]*");
      }

      //constructor
      private Text2To2AType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         return text;
      }
   }

   public class Text2To3ANType
   {
      private static XBPatternValidator patternValidator;

      static Text2To3ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text2To3ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 2 || value.Length > 3)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 2 || text.Length > 3)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text2To6ANType
   {
      private static XBPatternValidator patternValidator;

      static Text2To6ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text2To6ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 2 || value.Length > 6)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 2 || text.Length > 6)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text3To6ANType
   {
      private static XBPatternValidator patternValidator;

      static Text3To6ANType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9]*");
      }

      //constructor
      private Text3To6ANType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 3 || value.Length > 6)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 3 || text.Length > 6)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text4To8AType
   {
      private static XBPatternValidator patternValidator;

      static Text4To8AType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z]*");
      }

      //constructor
      private Text4To8AType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 4 || value.Length > 8)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 4 || text.Length > 8)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class Text5To20ABNType
   {
      private static XBPatternValidator patternValidator;

      static Text5To20ABNType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9 ]*");
      }

      //constructor
      private Text5To20ABNType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 5 || value.Length > 20)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 5 || text.Length > 20)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class TnoType
   {
      private static XBPatternValidator patternValidator;

      static TnoType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z]{2}[0-9]{4}");
      }

      //constructor
      private TnoType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 6 || value.Length > 6)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 6 || text.Length > 6)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class WideTextObjectType
   {
      private static XBPatternValidator patternValidator;

      static WideTextObjectType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]\\{\\}\\\\\"';<>~|€/:\\n\\r]*");
      }

      //constructor
      private WideTextObjectType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 7680)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 7680)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class WideTextType
   {
      private static XBPatternValidator patternValidator;

      static WideTextType() {
         XBUtil.license =  _Common.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Za-z0-9àâäéèêëïîôöùûüÿç .,\\-\\(\\)?!@#\\$%^&*=_+\\[\\]{}\\\\\"';<>~|€/:\\n\\rÇåìÄÅÉæÆòÖÜøØáíóúñÑ¡«»ÁÂÀãÃðÐÊËÈÍÎÏÌÓßÔÒõÕµÚÛÙýÝ§°¿¢®	` Œœ‒–’…]*");
      }

      //constructor
      private WideTextType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 7680)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 7680)
            throw new XBLengthVioException(text.Length);
         return text;
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

   public class _Common {

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
      public static readonly String NS_URI = "urn:fra:nc1:common:attribute";
      public static readonly String NS_PREFIX = "nc1common";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _Common() {
      }
      static _Common() {
         XBUtil.license = _Common.license;
      }
   }
}
