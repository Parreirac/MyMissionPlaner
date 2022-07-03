using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Obj.meteo
{

   using System.IO;
   using System.Xml;
   using com.objsys.xbinder.runtime;
    using NC1.Location;
    using NC1.Obj;
    using NC1.Dictionnaries;
    public class AltitudeZoneType
   {
      public static readonly int _MIN = 0;
      public static readonly int _MAX = 36;
      static AltitudeZoneType() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //constructor
      private AltitudeZoneType() {} 


      public static String encode(int value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         String text_3;
         text_3 = value.ToString();
         return text_3;
      }


      public static int decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         int value = 0;
         value = XBSimpleType.parseInt32(text);
         if (!( _MIN <= value && _MAX >= value )) {
            throw new XBValueVioException(value);
         }
         return value;
      }
   }

   public class MeteoType_2_tacticalData : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_tacticalData");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","symbolCode"),
         new XBQualifiedName("","probabilityRatio"),
         new XBQualifiedName("","isRainy"),
         new XBQualifiedName("","isSnowy"),
         new XBQualifiedName("","isFoggy"),
         new XBQualifiedName("","isCloudy"),
         new XBQualifiedName("","url"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","extVersion")
      };
      static MeteoType_2_tacticalData() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected bool _set_name = false;
      protected string symbolCode;
      protected double probabilityRatio;
      protected bool _set_probabilityRatio = false;
      protected bool isRainy;
      protected bool _set_isRainy = false;
      protected bool isSnowy;
      protected bool _set_isSnowy = false;
      protected bool isFoggy;
      protected bool _set_isFoggy = false;
      protected bool isCloudy;
      protected bool _set_isCloudy = false;
      protected string url;
      protected bool _set_url = false;
      protected string comment;
      protected bool _set_comment = false;
      protected  ExtVersType extVersion;   //optional

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

      public string SymbolCode
      {
         get { return this.symbolCode; }
         set { this.symbolCode = value; }
      }

      public double ProbabilityRatio
      {
         get
         {
            if (!_set_probabilityRatio)
                throw new XBException("field probabilityRatio not set");

            return this.probabilityRatio;
         }
         set
         {
            this.probabilityRatio = value;
            _set_probabilityRatio = true;
         }
      }

      public bool IsRainy
      {
         get
         {
            if (!_set_isRainy) throw new XBException("field isRainy not set");

            return this.isRainy;
         }
         set
         {
            this.isRainy = value;
            _set_isRainy = true;
         }
      }

      public bool IsSnowy
      {
         get
         {
            if (!_set_isSnowy) throw new XBException("field isSnowy not set");

            return this.isSnowy;
         }
         set
         {
            this.isSnowy = value;
            _set_isSnowy = true;
         }
      }

      public bool IsFoggy
      {
         get
         {
            if (!_set_isFoggy) throw new XBException("field isFoggy not set");

            return this.isFoggy;
         }
         set
         {
            this.isFoggy = value;
            _set_isFoggy = true;
         }
      }

      public bool IsCloudy
      {
         get
         {
            if (!_set_isCloudy)
                throw new XBException("field isCloudy not set");

            return this.isCloudy;
         }
         set
         {
            this.isCloudy = value;
            _set_isCloudy = true;
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

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  ShortTextObjectType.decode(text, xbContext);

                  _set_name = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // symbolCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.symbolCode =  SymbolCodeType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "symbolCode");

               // probabilityRatio
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.probabilityRatio =  RatioType.decode(text, xbContext);

                  _set_probabilityRatio = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isRainy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isRainy = XBSimpleType.parseBoolean(text);

                  _set_isRainy = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isSnowy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isSnowy = XBSimpleType.parseBoolean(text);

                  _set_isSnowy = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isFoggy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isFoggy = XBSimpleType.parseBoolean(text);

                  _set_isFoggy = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isCloudy
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isCloudy = XBSimpleType.parseBoolean(text);

                  _set_isCloudy = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // url
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
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
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
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

         // name
         if (_set_name)  {
            encoder.encodeStartElement("name", "", "");
            String text_4;
            text_4 =  ShortTextObjectType.encode(this.name, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // symbolCode
         encoder.encodeStartElement("symbolCode", "", "");
         String text_3;
         text_3 =  SymbolCodeType.encode(this.symbolCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // probabilityRatio
         if (_set_probabilityRatio)  {
            encoder.encodeStartElement("probabilityRatio", "", "");
            text_3 =  RatioType.encode(this.probabilityRatio, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isRainy
         if (_set_isRainy)  {
            encoder.encodeStartElement("isRainy", "", "");
            text_3 = this.isRainy.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isSnowy
         if (_set_isSnowy)  {
            encoder.encodeStartElement("isSnowy", "", "");
            text_3 = this.isSnowy.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isFoggy
         if (_set_isFoggy)  {
            encoder.encodeStartElement("isFoggy", "", "");
            text_3 = this.isFoggy.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isCloudy
         if (_set_isCloudy)  {
            encoder.encodeStartElement("isCloudy", "", "");
            text_3 = this.isCloudy.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
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

   public class MeteoType_2_atmosphere : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_atmosphere");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","temperature"),
         new XBQualifiedName("","temperatureGradient"),
         new XBQualifiedName("","pressureQuantity"),
         new XBQualifiedName("","humidityRatio"),
         new XBQualifiedName("","extVersion")
      };
      static MeteoType_2_atmosphere() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected sbyte temperature;
      protected bool _set_temperature = false;
      protected int temperatureGradient;
      protected bool _set_temperatureGradient = false;
      protected ushort pressureQuantity;
      protected bool _set_pressureQuantity = false;
      protected double humidityRatio;
      protected bool _set_humidityRatio = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public sbyte Temperature
      {
         get
         {
            if (!_set_temperature)
                throw new XBException("field temperature not set");

            return this.temperature;
         }
         set
         {
            this.temperature = value;
            _set_temperature = true;
         }
      }

      public int TemperatureGradient
      {
         get
         {
            if (!_set_temperatureGradient)
                throw new XBException("field temperatureGradient not set");

            return this.temperatureGradient;
         }
         set
         {
            this.temperatureGradient = value;
            _set_temperatureGradient = true;
         }
      }

      public ushort PressureQuantity
      {
         get
         {
            if (!_set_pressureQuantity)
                throw new XBException("field pressureQuantity not set");

            return this.pressureQuantity;
         }
         set
         {
            this.pressureQuantity = value;
            _set_pressureQuantity = true;
         }
      }

      public double HumidityRatio
      {
         get
         {
            if (!_set_humidityRatio)
                throw new XBException("field humidityRatio not set");

            return this.humidityRatio;
         }
         set
         {
            this.humidityRatio = value;
            _set_humidityRatio = true;
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

               // temperature
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.temperature =  IntMinus63To63Type.decode(text, xbContext);

                  _set_temperature = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // temperatureGradient
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.temperatureGradient =  L165_6Code.decode(text, xbContext);

                  _set_temperatureGradient = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // pressureQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.pressureQuantity =  Int887To1140Type.decode(text, xbContext);

                  _set_pressureQuantity = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // humidityRatio
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.humidityRatio =  RatioType.decode(text, xbContext);

                  _set_humidityRatio = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
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

         // temperature
         if (_set_temperature)  {
            encoder.encodeStartElement("temperature", "", "");
            String text_4;
            text_4 =  IntMinus63To63Type.encode(this.temperature, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // temperatureGradient
         if (_set_temperatureGradient)  {
            encoder.encodeStartElement("temperatureGradient", "", "");
            String text_4;
            text_4 =  L165_6Code.encode(this.temperatureGradient, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // pressureQuantity
         if (_set_pressureQuantity)  {
            encoder.encodeStartElement("pressureQuantity", "", "");
            String text_4;
            text_4 =  Int887To1140Type.encode(this.pressureQuantity, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // humidityRatio
         if (_set_humidityRatio)  {
            encoder.encodeStartElement("humidityRatio", "", "");
            String text_4;
            text_4 =  RatioType.encode(this.humidityRatio, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
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

   public class MeteoType_2_cloudCover : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_cloudCover");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","altitudeZone"),
         new XBQualifiedName("","category"),
         new XBQualifiedName("","averageCoverage"),
         new XBQualifiedName("","extVersion")
      };
      static MeteoType_2_cloudCover() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int altitudeZone;
      protected int category;
      protected bool _set_category = false;
      protected int averageCoverage;
      protected bool _set_averageCoverage = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public int AltitudeZone
      {
         get { return this.altitudeZone; }
         set { this.altitudeZone = value; }
      }

      public int Category
      {
         get
         {
            if (!_set_category)
                throw new XBException("field category not set");

            return this.category;
         }
         set
         {
            this.category = value;
            _set_category = true;
         }
      }

      public int AverageCoverage
      {
         get
         {
            if (!_set_averageCoverage)
                throw new XBException("field averageCoverage not set");

            return this.averageCoverage;
         }
         set
         {
            this.averageCoverage = value;
            _set_averageCoverage = true;
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

               // altitudeZone
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.altitudeZone =  AltitudeZoneType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "altitudeZone");

               // category
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.category =  L165_9Code.decode(text, xbContext);

                  _set_category = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // averageCoverage
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.averageCoverage =  L165_10Code.decode(text, xbContext);

                  _set_averageCoverage = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
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

         // altitudeZone
         encoder.encodeStartElement("altitudeZone", "", "");
         String text_3;
         text_3 =  AltitudeZoneType.encode(this.altitudeZone, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // category
         if (_set_category)  {
            encoder.encodeStartElement("category", "", "");
            text_3 =  L165_9Code.encode(this.category, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // averageCoverage
         if (_set_averageCoverage)  {
            encoder.encodeStartElement("averageCoverage", "", "");
            text_3 =  L165_10Code.encode(this.averageCoverage, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
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

   public class MeteoType_2_wind : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_wind");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","altitudeZone"),
         new XBQualifiedName("","category"),
         new XBQualifiedName("","airStabilityCategory"),
         new XBQualifiedName("","windDirection"),
         new XBQualifiedName("","speed"),
         new XBQualifiedName("","extVersion")
      };
      static MeteoType_2_wind() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected int altitudeZone;
      protected bool _set_altitudeZone = false;
      protected int category;
      protected bool _set_category = false;
      protected int airStabilityCategory;
      protected bool _set_airStabilityCategory = false;
      protected double windDirection;
      protected bool _set_windDirection = false;
      protected short speed;
      protected bool _set_speed = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public int AltitudeZone
      {
         get
         {
            if (!_set_altitudeZone)
                throw new XBException("field altitudeZone not set");

            return this.altitudeZone;
         }
         set
         {
            this.altitudeZone = value;
            _set_altitudeZone = true;
         }
      }

      public int Category
      {
         get
         {
            if (!_set_category)
                throw new XBException("field category not set");

            return this.category;
         }
         set
         {
            this.category = value;
            _set_category = true;
         }
      }

      public int AirStabilityCategory
      {
         get
         {
            if (!_set_airStabilityCategory)
                throw new XBException("field airStabilityCategory not set");

            return this.airStabilityCategory;
         }
         set
         {
            this.airStabilityCategory = value;
            _set_airStabilityCategory = true;
         }
      }

      public double WindDirection
      {
         get
         {
            if (!_set_windDirection)
                throw new XBException("field windDirection not set");

            return this.windDirection;
         }
         set
         {
            this.windDirection = value;
            _set_windDirection = true;
         }
      }

      public short Speed
      {
         get
         {
            if (!_set_speed) throw new XBException("field speed not set");

            return this.speed;
         }
         set
         {
            this.speed = value;
            _set_speed = true;
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

               // altitudeZone
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.altitudeZone =  AltitudeZoneType.decode(text, xbContext);

                  _set_altitudeZone = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // category
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.category =  L165_11Code.decode(text, xbContext);

                  _set_category = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // airStabilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.airStabilityCategory =  L165_12Code.decode(text, xbContext);

                  _set_airStabilityCategory = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // windDirection
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.windDirection =  AngleType.decode(text, xbContext);

                  _set_windDirection = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // speed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.speed =  SpeedType.decode(text, xbContext);

                  _set_speed = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
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

         // altitudeZone
         if (_set_altitudeZone)  {
            encoder.encodeStartElement("altitudeZone", "", "");
            String text_4;
            text_4 =  AltitudeZoneType.encode(this.altitudeZone, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // category
         if (_set_category)  {
            encoder.encodeStartElement("category", "", "");
            String text_4;
            text_4 =  L165_11Code.encode(this.category, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // airStabilityCategory
         if (_set_airStabilityCategory)  {
            encoder.encodeStartElement("airStabilityCategory", "", "");
            String text_4;
            text_4 =  L165_12Code.encode(this.airStabilityCategory, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // windDirection
         if (_set_windDirection)  {
            encoder.encodeStartElement("windDirection", "", "");
            String text_4;
            text_4 =  AngleType.encode(this.windDirection, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // speed
         if (_set_speed)  {
            encoder.encodeStartElement("speed", "", "");
            String text_4;
            text_4 =  SpeedType.encode(this.speed, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
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

   public class MeteoType_2_visibility : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_visibility");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","direction"),
         new XBQualifiedName("","horizontalDistance"),
         new XBQualifiedName("","verticalDistance"),
         new XBQualifiedName("","category"),
         new XBQualifiedName("","extVersion")
      };
      static MeteoType_2_visibility() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected double direction;
      protected ushort horizontalDistance;
      protected bool _set_horizontalDistance = false;
      protected ushort verticalDistance;
      protected bool _set_verticalDistance = false;
      protected int category;
      protected bool _set_category = false;
      protected  ExtVersType extVersion;   //optional

      //attribute methods

      //content methods

      public double Direction
      {
         get { return this.direction; }
         set { this.direction = value; }
      }

      public ushort HorizontalDistance
      {
         get
         {
            if (!_set_horizontalDistance)
                throw new XBException("field horizontalDistance not set");

            return this.horizontalDistance;
         }
         set
         {
            this.horizontalDistance = value;
            _set_horizontalDistance = true;
         }
      }

      public ushort VerticalDistance
      {
         get
         {
            if (!_set_verticalDistance)
                throw new XBException("field verticalDistance not set");

            return this.verticalDistance;
         }
         set
         {
            this.verticalDistance = value;
            _set_verticalDistance = true;
         }
      }

      public int Category
      {
         get
         {
            if (!_set_category)
                throw new XBException("field category not set");

            return this.category;
         }
         set
         {
            this.category = value;
            _set_category = true;
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

               // direction
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.direction =  AngleType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "direction");

               // horizontalDistance
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.horizontalDistance =  Int0To25000Type.decode(text, xbContext);

                  _set_horizontalDistance = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // verticalDistance
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.verticalDistance =  Int0To25000Type.decode(text, xbContext);

                  _set_verticalDistance = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // category
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.category =  L165_7Code.decode(text, xbContext);

                  _set_category = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // extVersion
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
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

         // direction
         encoder.encodeStartElement("direction", "", "");
         String text_3;
         text_3 =  AngleType.encode(this.direction, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // horizontalDistance
         if (_set_horizontalDistance)  {
            encoder.encodeStartElement("horizontalDistance", "", "");
            text_3 =  Int0To25000Type.encode(this.horizontalDistance, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // verticalDistance
         if (_set_verticalDistance)  {
            encoder.encodeStartElement("verticalDistance", "", "");
            text_3 =  Int0To25000Type.encode(this.verticalDistance, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // category
         if (_set_category)  {
            encoder.encodeStartElement("category", "", "");
            text_3 =  L165_7Code.encode(this.category, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
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

   public class MeteoType_39
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_39");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","point"),
         new XBQualifiedName("","multipoint"),
         new XBQualifiedName("","polyline"),
         new XBQualifiedName("","polygon"),
         new XBQualifiedName("","circle"),
         new XBQualifiedName("","ellipse"),
         new XBQualifiedName("","arcband")
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
         if (XBQualifiedName.namesMatch(
            (XBQualifiedName)particleInfo[6], elemNs, elemLocalName)
            ) return true;
         return false;
      }

      public enum Choice  {
         None, point, multipoint, polyline, polygon, circle, ellipse, arcband}
      protected Choice _whichField;
      static MeteoType_39() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PointType point;
      protected  MultipointType multipoint;
      protected  PolylineType polyline;
      protected  PolygonType polygon;
      protected  CircleType circle;
      protected  EllipseType ellipse;
      protected  ArcbandType arcband;

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

      public  MultipointType Multipoint
      {
         get
         {
            if (_whichField != Choice.multipoint ) 
               throw new XBException("field multipoint not set");
            return this.multipoint;
         }
         set
         {
            this.multipoint = value;
            _whichField = Choice.multipoint;
         }
      }

      public  PolylineType Polyline
      {
         get
         {
            if (_whichField != Choice.polyline ) 
               throw new XBException("field polyline not set");
            return this.polyline;
         }
         set
         {
            this.polyline = value;
            _whichField = Choice.polyline;
         }
      }

      public  PolygonType Polygon
      {
         get
         {
            if (_whichField != Choice.polygon ) 
               throw new XBException("field polygon not set");
            return this.polygon;
         }
         set
         {
            this.polygon = value;
            _whichField = Choice.polygon;
         }
      }

      public  CircleType Circle
      {
         get
         {
            if (_whichField != Choice.circle ) 
               throw new XBException("field circle not set");
            return this.circle;
         }
         set
         {
            this.circle = value;
            _whichField = Choice.circle;
         }
      }

      public  EllipseType Ellipse
      {
         get
         {
            if (_whichField != Choice.ellipse ) 
               throw new XBException("field ellipse not set");
            return this.ellipse;
         }
         set
         {
            this.ellipse = value;
            _whichField = Choice.ellipse;
         }
      }

      public  ArcbandType Arcband
      {
         get
         {
            if (_whichField != Choice.arcband ) 
               throw new XBException("field arcband not set");
            return this.arcband;
         }
         set
         {
            this.arcband = value;
            _whichField = Choice.arcband;
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

            // point
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.point = new  PointType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.point.decode(reader, xbContext, false, false);
               _whichField = Choice.point;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // multipoint
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.multipoint = new  MultipointType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.multipoint.decode(reader, xbContext, false, false);
               _whichField = Choice.multipoint;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // polyline
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               this.polyline = new  PolylineType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.polyline.decode(reader, xbContext, false, false);
               _whichField = Choice.polyline;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // polygon
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
            {
               this.polygon = new  PolygonType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.polygon.decode(reader, xbContext, false, false);
               _whichField = Choice.polygon;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // circle
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
            {
               this.circle = new  CircleType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.circle.decode(reader, xbContext, false, false);
               _whichField = Choice.circle;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // ellipse
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
            {
               this.ellipse = new  EllipseType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.ellipse.decode(reader, xbContext, false, false);
               _whichField = Choice.ellipse;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // arcband
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
            {
               this.arcband = new  ArcbandType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.arcband.decode(reader, xbContext, false, false);
               _whichField = Choice.arcband;

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

            // point
            case Choice.point: {
               if (_whichField != Choice.point ) 
                  throw new XBException("field point not set");
               encoder.encodeStartElement("point", "", "");
               this.point.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // multipoint
            case Choice.multipoint: {
               if (_whichField != Choice.multipoint ) 
                  throw new XBException("field multipoint not set");
               encoder.encodeStartElement("multipoint", "", "");
               this.multipoint.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // polyline
            case Choice.polyline: {
               if (_whichField != Choice.polyline ) 
                  throw new XBException("field polyline not set");
               encoder.encodeStartElement("polyline", "", "");
               this.polyline.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // polygon
            case Choice.polygon: {
               if (_whichField != Choice.polygon ) 
                  throw new XBException("field polygon not set");
               encoder.encodeStartElement("polygon", "", "");
               this.polygon.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // circle
            case Choice.circle: {
               if (_whichField != Choice.circle ) 
                  throw new XBException("field circle not set");
               encoder.encodeStartElement("circle", "", "");
               this.circle.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // ellipse
            case Choice.ellipse: {
               if (_whichField != Choice.ellipse ) 
                  throw new XBException("field ellipse not set");
               encoder.encodeStartElement("ellipse", "", "");
               this.ellipse.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // arcband
            case Choice.arcband: {
               if (_whichField != Choice.arcband ) 
                  throw new XBException("field arcband not set");
               encoder.encodeStartElement("arcband", "", "");
               this.arcband.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class MeteoType_2_location : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType_2_location");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","speed"),
         new XBQualifiedName("","course"),
         new XBQualifiedName("","datetime"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","quality")
      };
      static MeteoType_2_location() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected bool _set_name = false;
      protected  MeteoType_39 meteoType_39;
      protected short speed;
      protected bool _set_speed = false;
      protected double course;
      protected bool _set_course = false;
      protected string datetime;
      protected bool _set_datetime = false;
      protected System.Collections.Generic.IList< PeriodType> validityPeriod;
         
      protected int quality;
      protected bool _set_quality = false;

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

      public  MeteoType_39 MeteoType_39
      {
         get
         {
            if (this.meteoType_39 == null)
                throw new XBException("field meteoType_39 not set");

            return this.meteoType_39;
         }
         set
         {
            this.meteoType_39 = value;
         }
      }

      public short Speed
      {
         get
         {
            if (!_set_speed) throw new XBException("field speed not set");

            return this.speed;
         }
         set
         {
            this.speed = value;
            _set_speed = true;
         }
      }

      public double Course
      {
         get
         {
            if (!_set_course) throw new XBException("field course not set");

            return this.course;
         }
         set
         {
            this.course = value;
            _set_course = true;
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

      public System.Collections.Generic.IList< PeriodType> ValidityPeriod
      {
         get
         {
            if (this.validityPeriod == null) {
               this.validityPeriod = new List< PeriodType>();
            }
            return this.validityPeriod;
         }
      }

      public int Quality
      {
         get
         {
            if (!_set_quality) throw new XBException("field quality not set");

            return this.quality;
         }
         set
         {
            this.quality = value;
            _set_quality = true;
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
                  this.name =  Text1To30ObjectType.decode(text, xbContext);

                  _set_name = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // meteoType_39
               if( moreContent_4 && 
                   MeteoType_39.acceptsElem(elemNs, elemLocalName) )
               {
                  this.meteoType_39 = new  MeteoType_39();
                  this.meteoType_39.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "meteoType_39");

               // speed
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.speed =  SpeedType.decode(text, xbContext);

                  _set_speed = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // course
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.course =  AngleType.decode(text, xbContext);

                  _set_course = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // datetime
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.datetime = text;

                  _set_datetime = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // validityPeriod
               this.validityPeriod = new List< PeriodType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   PeriodType _tmp_validityPeriod;
                  _tmp_validityPeriod = new  PeriodType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_validityPeriod.decode(reader, xbContext, false, false);
                  this.validityPeriod.Add(_tmp_validityPeriod);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // quality
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.quality =  L117_5Code.decode(text, xbContext);

                  _set_quality = true;

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

         // name
         if (_set_name)  {
            encoder.encodeStartElement("name", "", "");
            String text_4;
            text_4 =  Text1To30ObjectType.encode(this.name, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // meteoType_39
         if (this.meteoType_39 == null)
             throw new XBException("field meteoType_39 not set");

         this.meteoType_39.encode(encoder, xbContext);

         // speed
         if (_set_speed)  {
            encoder.encodeStartElement("speed", "", "");
            String text_4;
            text_4 =  SpeedType.encode(this.speed, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // course
         if (_set_course)  {
            encoder.encodeStartElement("course", "", "");
            String text_4;
            text_4 =  AngleType.encode(this.course, xbContext);
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

         // validityPeriod
         if ( this.validityPeriod != null ){
            foreach ( PeriodType _tmp_validityPeriod in this.validityPeriod)
            {
               encoder.encodeStartElement("validityPeriod", "", "");
               _tmp_validityPeriod.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // quality
         if (_set_quality)  {
            encoder.encodeStartElement("quality", "", "");
            String text_4;
            text_4 =  L117_5Code.encode(this.quality, xbContext);
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

   public class MeteoType :  LocalisedObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:meteo",
          "MeteoType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","tacticalData"),
         new XBQualifiedName("","atmosphere"),
         new XBQualifiedName("","cloudCover"),
         new XBQualifiedName("","wind"),
         new XBQualifiedName("","visibility"),
         new XBQualifiedName("","location")
      };
      static MeteoType() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  MeteoType_2_tacticalData tacticalData;   //optional
      protected  MeteoType_2_atmosphere atmosphere;   //optional
      protected System.Collections.Generic.IList< MeteoType_2_cloudCover> cloudCover;
         
      protected System.Collections.Generic.IList< MeteoType_2_wind> wind;
         
      protected System.Collections.Generic.IList< MeteoType_2_visibility> visibility;
         
      protected  MeteoType_2_location location;   //optional

      //attribute methods

      //content methods

      public  MeteoType_2_tacticalData TacticalData
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

      public  MeteoType_2_atmosphere Atmosphere
      {
         get
         {
            if (this.atmosphere == null)
                throw new XBException("field atmosphere not set");

            return this.atmosphere;
         }
         set
         {
            this.atmosphere = value;
         }
      }

      public System.Collections.Generic.IList< MeteoType_2_cloudCover> CloudCover
      {
         get
         {
            if (this.cloudCover == null) {
               this.cloudCover = new List< MeteoType_2_cloudCover>();
            }
            return this.cloudCover;
         }
      }

      public System.Collections.Generic.IList< MeteoType_2_wind> Wind
      {
         get
         {
            if (this.wind == null) {
               this.wind = new List< MeteoType_2_wind>();
            }
            return this.wind;
         }
      }

      public System.Collections.Generic.IList< MeteoType_2_visibility> Visibility
      {
         get
         {
            if (this.visibility == null) {
               this.visibility = new List< MeteoType_2_visibility>();
            }
            return this.visibility;
         }
      }

      public  MeteoType_2_location Location
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
                  this.tacticalData = new  MeteoType_2_tacticalData();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.tacticalData.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // atmosphere
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.atmosphere = new  MeteoType_2_atmosphere();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.atmosphere.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // cloudCover
               this.cloudCover = new List< MeteoType_2_cloudCover>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   MeteoType_2_cloudCover _tmp_cloudCover;
                  _tmp_cloudCover = new  MeteoType_2_cloudCover();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_cloudCover.decode(reader, xbContext, false, false);
                  this.cloudCover.Add(_tmp_cloudCover);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // wind
               this.wind = new List< MeteoType_2_wind>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   MeteoType_2_wind _tmp_wind;
                  _tmp_wind = new  MeteoType_2_wind();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_wind.decode(reader, xbContext, false, false);
                  this.wind.Add(_tmp_wind);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // visibility
               this.visibility = new List< MeteoType_2_visibility>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   MeteoType_2_visibility _tmp_visibility;
                  _tmp_visibility = new  MeteoType_2_visibility();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_visibility.decode(reader, xbContext, false, false);
                  this.visibility.Add(_tmp_visibility);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // location
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.location = new  MeteoType_2_location();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.location.decode(reader, xbContext, false, false);

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

         // atmosphere
         if (this.atmosphere != null)  {
            encoder.encodeStartElement("atmosphere", "", "");
            this.atmosphere.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // cloudCover
         if ( this.cloudCover != null ){
            foreach ( MeteoType_2_cloudCover _tmp_cloudCover in this.cloudCover)
            {
               encoder.encodeStartElement("cloudCover", "", "");
               _tmp_cloudCover.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // wind
         if ( this.wind != null ){
            foreach ( MeteoType_2_wind _tmp_wind in this.wind){
               encoder.encodeStartElement("wind", "", "");
               _tmp_wind.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // visibility
         if ( this.visibility != null ){
            foreach ( MeteoType_2_visibility _tmp_visibility in this.visibility)
            {
               encoder.encodeStartElement("visibility", "", "");
               _tmp_visibility.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // location
         if (this.location != null)  {
            encoder.encodeStartElement("location", "", "");
            this.location.encode(encoder, xbContext, null, false);
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

   public class NC1_Meteo_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:objet:meteo","NC1_Meteo")
      };
      static NC1_Meteo_CC() {
         XBUtil.license =  _NC1_Meteo.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  MeteoType nC1_Meteo;

      //content methods

      public  MeteoType NC1_Meteo
      {
         get
         {
            if (this.nC1_Meteo == null)
                throw new XBException("field nC1_Meteo not set");

            return this.nC1_Meteo;
         }
         set
         {
            this.nC1_Meteo = value;
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
         //   encoder.setNamespaces(_NC1_Meteo.namespaceContext);

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

            // nC1_Meteo
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_Meteo = new  MeteoType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_Meteo.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_Meteo");

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

         // nC1_Meteo
         if (this.nC1_Meteo == null)
             throw new XBException("field nC1_Meteo not set");

         encoder.encodeStartElement("NC1_Meteo",  _NC1_Meteo.NS_URI,  _NC1_Meteo.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_Meteo.encode(encoder, xbContext, null, false);
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

   public class _NC1_Meteo {

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
      public static readonly String NS_URI = "urn:fra:nc1:objet:meteo";
      public static readonly String NS_PREFIX = "nc1meteo";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_Meteo() {
      }
      static _NC1_Meteo() {
         XBUtil.license = _NC1_Meteo.license;
      }
   }
}
