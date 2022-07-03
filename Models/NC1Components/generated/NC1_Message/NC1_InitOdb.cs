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
    using NC1.Dictionnaries;
   public class IdOpsType
   {
      private static XBPatternValidator patternValidator;

      static IdOpsType() {
         XBUtil.license =  _NC1_InitOdb.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9]*");
      }

      //constructor
      private IdOpsType() {} 


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

   public class IdAscaType
   {
      private static XBPatternValidator patternValidator;

      static IdAscaType() {
         XBUtil.license =  _NC1_InitOdb.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("([A-Z0-9 ]\\.){3}([A-Z0-9 ]){3}\\.([A-Z0-9 ]){3}");
      }

      //constructor
      private IdAscaType() {} 


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

   public class NC1_InitOdb_ELEM_2_forces : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:initodb",
          "NC1_InitOdb_ELEM_2_forces");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","orbatName"),
         new XBQualifiedName("","orbatNameDescription"),
         new XBQualifiedName("","symbolCode"),
         new XBQualifiedName("","frSpecificSymbol"),
         new XBQualifiedName("","modifier"),
         new XBQualifiedName("","commandAndControlRole"),
         new XBQualifiedName("","idOps"),
         new XBQualifiedName("","superiorUnitId"),
         new XBQualifiedName("","dbmFId"),
         new XBQualifiedName("","stnl16"),
         new XBQualifiedName("","jreId"),
         new XBQualifiedName("","eirn"),
         new XBQualifiedName("","nffiSystemId"),
         new XBQualifiedName("","nffiTransponderId"),
         new XBQualifiedName("","ascaId")
      };
      static NC1_InitOdb_ELEM_2_forces() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string orbatName;
      protected string orbatNameDescription;
      protected bool _set_orbatNameDescription = false;
      protected string symbolCode;
      protected int frSpecificSymbol;
      protected bool _set_frSpecificSymbol = false;
      protected string modifier;
      protected bool _set_modifier = false;
      protected int commandAndControlRole;
      protected bool _set_commandAndControlRole = false;
      protected string idOps;
      protected bool _set_idOps = false;
      protected  Nc1ObjectRefType superiorUnitId;   //optional
      protected int dbmFId;
      protected bool _set_dbmFId = false;
      protected string stnl16;
      protected bool _set_stnl16 = false;
      protected string jreId;
      protected bool _set_jreId = false;
      protected  EirnType eirn;   //optional
      protected string nffiSystemId;
      protected bool _set_nffiSystemId = false;
      protected string nffiTransponderId;
      protected bool _set_nffiTransponderId = false;
      protected string ascaId;
      protected bool _set_ascaId = false;

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

      public string OrbatName
      {
         get { return this.orbatName; }
         set { this.orbatName = value; }
      }

      public string OrbatNameDescription
      {
         get
         {
            if (!_set_orbatNameDescription)
                throw new XBException("field orbatNameDescription not set");

            return this.orbatNameDescription;
         }
         set
         {
            this.orbatNameDescription = value;
            _set_orbatNameDescription = true;
         }
      }

      public string SymbolCode
      {
         get { return this.symbolCode; }
         set { this.symbolCode = value; }
      }

      public int FrSpecificSymbol
      {
         get
         {
            if (!_set_frSpecificSymbol)
                throw new XBException("field frSpecificSymbol not set");

            return this.frSpecificSymbol;
         }
         set
         {
            this.frSpecificSymbol = value;
            _set_frSpecificSymbol = true;
         }
      }

      public string Modifier
      {
         get
         {
            if (!_set_modifier)
                throw new XBException("field modifier not set");

            return this.modifier;
         }
         set
         {
            this.modifier = value;
            _set_modifier = true;
         }
      }

      public int CommandAndControlRole
      {
         get
         {
            if (!_set_commandAndControlRole)
                throw new XBException("field commandAndControlRole not set");

            return this.commandAndControlRole;
         }
         set
         {
            this.commandAndControlRole = value;
            _set_commandAndControlRole = true;
         }
      }

      public string IdOps
      {
         get
         {
            if (!_set_idOps) throw new XBException("field idOps not set");

            return this.idOps;
         }
         set
         {
            this.idOps = value;
            _set_idOps = true;
         }
      }

      public  Nc1ObjectRefType SuperiorUnitId
      {
         get
         {
            if (this.superiorUnitId == null)
                throw new XBException("field superiorUnitId not set");

            return this.superiorUnitId;
         }
         set
         {
            this.superiorUnitId = value;
         }
      }

      public int DbmFId
      {
         get
         {
            if (!_set_dbmFId) throw new XBException("field dbmFId not set");

            return this.dbmFId;
         }
         set
         {
            this.dbmFId = value;
            _set_dbmFId = true;
         }
      }

      public string Stnl16
      {
         get
         {
            if (!_set_stnl16) throw new XBException("field stnl16 not set");

            return this.stnl16;
         }
         set
         {
            this.stnl16 = value;
            _set_stnl16 = true;
         }
      }

      public string JreId
      {
         get
         {
            if (!_set_jreId) throw new XBException("field jreId not set");

            return this.jreId;
         }
         set
         {
            this.jreId = value;
            _set_jreId = true;
         }
      }

      public  EirnType Eirn
      {
         get
         {
            if (this.eirn == null)
                throw new XBException("field eirn not set");

            return this.eirn;
         }
         set
         {
            this.eirn = value;
         }
      }

      public string NffiSystemId
      {
         get
         {
            if (!_set_nffiSystemId)
                throw new XBException("field nffiSystemId not set");

            return this.nffiSystemId;
         }
         set
         {
            this.nffiSystemId = value;
            _set_nffiSystemId = true;
         }
      }

      public string NffiTransponderId
      {
         get
         {
            if (!_set_nffiTransponderId)
                throw new XBException("field nffiTransponderId not set");

            return this.nffiTransponderId;
         }
         set
         {
            this.nffiTransponderId = value;
            _set_nffiTransponderId = true;
         }
      }

      public string AscaId
      {
         get
         {
            if (!_set_ascaId) throw new XBException("field ascaId not set");

            return this.ascaId;
         }
         set
         {
            this.ascaId = value;
            _set_ascaId = true;
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

               // orbatName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.orbatName =  Text1To15ANSType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "orbatName");

               // orbatNameDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.orbatNameDescription =  Text1To50Type.decode(text, xbContext);

                  _set_orbatNameDescription = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // symbolCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
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

               // frSpecificSymbol
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.frSpecificSymbol = Obj.unit.UnitFrSpecificCode.decode(text, xbContext);

                  _set_frSpecificSymbol = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // modifier
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.modifier =  ShortTextObjectType.decode(text, xbContext);

                  _set_modifier = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // commandAndControlRole
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.commandAndControlRole =  L110_30Code.decode(text, xbContext);

                  _set_commandAndControlRole = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // idOps
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.idOps =  IdOpsType.decode(text, xbContext);

                  _set_idOps = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // superiorUnitId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  this.superiorUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.superiorUnitId.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // dbmFId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.dbmFId = XBSimpleType.parseInt32(text);

                  _set_dbmFId = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // stnl16
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.stnl16 =  Stnl16Type.decode(text, xbContext);

                  _set_stnl16 = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // jreId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[11], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.jreId =  Tnl16Type.decode(text, xbContext);

                  _set_jreId = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // eirn
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[12], elemNs, elemLocalName) )
               {
                  this.eirn = new  EirnType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.eirn.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nffiSystemId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[13], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nffiSystemId =  MediumTextObjectType.decode(text, xbContext);

                  _set_nffiSystemId = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nffiTransponderId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[14], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nffiTransponderId =  ShortTextObjectType.decode(text, xbContext);

                  _set_nffiTransponderId = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ascaId
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[15], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.ascaId =  IdAscaType.decode(text, xbContext);

                  _set_ascaId = true;

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

         // orbatName
         encoder.encodeStartElement("orbatName", "", "");
         String text_3;
         text_3 =  Text1To15ANSType.encode(this.orbatName, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // orbatNameDescription
         if (_set_orbatNameDescription)  {
            encoder.encodeStartElement("orbatNameDescription", "", "");
            text_3 =  Text1To50Type.encode(this.orbatNameDescription, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // symbolCode
         encoder.encodeStartElement("symbolCode", "", "");
         text_3 =  SymbolCodeType.encode(this.symbolCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // frSpecificSymbol
         if (_set_frSpecificSymbol)  {
            encoder.encodeStartElement("frSpecificSymbol", "", "");
            text_3 = Obj.unit.UnitFrSpecificCode.encode(this.frSpecificSymbol, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // modifier
         if (_set_modifier)  {
            encoder.encodeStartElement("modifier", "", "");
            text_3 =  ShortTextObjectType.encode(this.modifier, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // commandAndControlRole
         if (_set_commandAndControlRole)  {
            encoder.encodeStartElement("commandAndControlRole", "", "");
            text_3 =  L110_30Code.encode(this.commandAndControlRole, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // idOps
         if (_set_idOps)  {
            encoder.encodeStartElement("idOps", "", "");
            text_3 =  IdOpsType.encode(this.idOps, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // superiorUnitId
         if (this.superiorUnitId != null)  {
            encoder.encodeStartElement("superiorUnitId", "", "");
            this.superiorUnitId.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // dbmFId
         if (_set_dbmFId)  {
            encoder.encodeStartElement("dbmFId", "", "");
            text_3 = this.dbmFId.ToString();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // stnl16
         if (_set_stnl16)  {
            encoder.encodeStartElement("stnl16", "", "");
            text_3 =  Stnl16Type.encode(this.stnl16, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // jreId
         if (_set_jreId)  {
            encoder.encodeStartElement("jreId", "", "");
            text_3 =  Tnl16Type.encode(this.jreId, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // eirn
         if (this.eirn != null)  {
            encoder.encodeStartElement("eirn", "", "");
            this.eirn.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // nffiSystemId
         if (_set_nffiSystemId)  {
            encoder.encodeStartElement("nffiSystemId", "", "");
            text_3 =  MediumTextObjectType.encode(this.nffiSystemId, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // nffiTransponderId
         if (_set_nffiTransponderId)  {
            encoder.encodeStartElement("nffiTransponderId", "", "");
            text_3 =  ShortTextObjectType.encode(this.nffiTransponderId, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // ascaId
         if (_set_ascaId)  {
            encoder.encodeStartElement("ascaId", "", "");
            text_3 =  IdAscaType.encode(this.ascaId, xbContext);
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

   public class NC1_InitOdb_ELEM_2_equipmentsHoldings : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:initodb",
          "NC1_InitOdb_ELEM_2_equipmentsHoldings");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","nicCode"),
         new XBQualifiedName("","theoreticalQuantity"),
         new XBQualifiedName("","holdingQuantity")
      };
      static NC1_InitOdb_ELEM_2_equipmentsHoldings() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string nicCode;
      protected ulong theoreticalQuantity;
      protected ulong holdingQuantity;
      protected bool _set_holdingQuantity = false;

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

      public string NicCode
      {
         get { return this.nicCode; }
         set { this.nicCode = value; }
      }

      public ulong TheoreticalQuantity
      {
         get { return this.theoreticalQuantity; }
         set { this.theoreticalQuantity = value; }
      }

      public ulong HoldingQuantity
      {
         get
         {
            if (!_set_holdingQuantity)
                throw new XBException("field holdingQuantity not set");

            return this.holdingQuantity;
         }
         set
         {
            this.holdingQuantity = value;
            _set_holdingQuantity = true;
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

               // nicCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nicCode =  NicCodeType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "nicCode");

               // theoreticalQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.theoreticalQuantity =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "theoreticalQuantity");

               // holdingQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.holdingQuantity =  Int0To2147483647Type.decode(text, xbContext);

                  _set_holdingQuantity = true;

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

         // nicCode
         encoder.encodeStartElement("nicCode", "", "");
         String text_3;
         text_3 =  NicCodeType.encode(this.nicCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // theoreticalQuantity
         encoder.encodeStartElement("theoreticalQuantity", "", "");
         text_3 =  Int0To2147483647Type.encode(this.theoreticalQuantity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // holdingQuantity
         if (_set_holdingQuantity)  {
            encoder.encodeStartElement("holdingQuantity", "", "");
            text_3 =  Int0To2147483647Type.encode(this.holdingQuantity, xbContext);
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

   public class NC1_InitOdb_ELEM_2_resourcesHoldings : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:initodb",
          "NC1_InitOdb_ELEM_2_resourcesHoldings");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","nicCode"),
         new XBQualifiedName("","theoreticalQuantity"),
         new XBQualifiedName("","holdingQuantity")
      };
      static NC1_InitOdb_ELEM_2_resourcesHoldings() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected string nicCode;
      protected ulong theoreticalQuantity;
      protected ulong holdingQuantity;

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

      public string NicCode
      {
         get { return this.nicCode; }
         set { this.nicCode = value; }
      }

      public ulong TheoreticalQuantity
      {
         get { return this.theoreticalQuantity; }
         set { this.theoreticalQuantity = value; }
      }

      public ulong HoldingQuantity
      {
         get { return this.holdingQuantity; }
         set { this.holdingQuantity = value; }
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

               // nicCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nicCode =  NicCodeType.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "nicCode");

               // theoreticalQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.theoreticalQuantity =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "theoreticalQuantity");

               // holdingQuantity
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.holdingQuantity =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "holdingQuantity");

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

         // nicCode
         encoder.encodeStartElement("nicCode", "", "");
         String text_3;
         text_3 =  NicCodeType.encode(this.nicCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // theoreticalQuantity
         encoder.encodeStartElement("theoreticalQuantity", "", "");
         text_3 =  Int0To2147483647Type.encode(this.theoreticalQuantity, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // holdingQuantity
         encoder.encodeStartElement("holdingQuantity", "", "");
         text_3 =  Int0To2147483647Type.encode(this.holdingQuantity, xbContext);
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

   public class NC1_InitOdb_ELEM_2_staffHoldings : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:initodb",
          "NC1_InitOdb_ELEM_2_staffHoldings");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","unitId"),
         new XBQualifiedName("","officersCount"),
         new XBQualifiedName("","ncoCount"),
         new XBQualifiedName("","privatesCount"),
         new XBQualifiedName("","totalCount")
      };
      static NC1_InitOdb_ELEM_2_staffHoldings() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  Nc1ObjectRefType unitId;
      protected ulong officersCount;
      protected ulong ncoCount;
      protected ulong privatesCount;
      protected ulong totalCount;

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

      public ulong OfficersCount
      {
         get { return this.officersCount; }
         set { this.officersCount = value; }
      }

      public ulong NcoCount
      {
         get { return this.ncoCount; }
         set { this.ncoCount = value; }
      }

      public ulong PrivatesCount
      {
         get { return this.privatesCount; }
         set { this.privatesCount = value; }
      }

      public ulong TotalCount
      {
         get { return this.totalCount; }
         set { this.totalCount = value; }
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

               // officersCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.officersCount =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "officersCount");

               // ncoCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.ncoCount =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "ncoCount");

               // privatesCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.privatesCount =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "privatesCount");

               // totalCount
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.totalCount =  Int0To2147483647Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "totalCount");

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

         // officersCount
         encoder.encodeStartElement("officersCount", "", "");
         String text_3;
         text_3 =  Int0To2147483647Type.encode(this.officersCount, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // ncoCount
         encoder.encodeStartElement("ncoCount", "", "");
         text_3 =  Int0To2147483647Type.encode(this.ncoCount, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // privatesCount
         encoder.encodeStartElement("privatesCount", "", "");
         text_3 =  Int0To2147483647Type.encode(this.privatesCount, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // totalCount
         encoder.encodeStartElement("totalCount", "", "");
         text_3 =  Int0To2147483647Type.encode(this.totalCount, xbContext);
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

   public class EquipmentCategoryCode
   {
      static EquipmentCategoryCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private EquipmentCategoryCode() {} 


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

   public class FuelCategoryCode
   {
      static FuelCategoryCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private FuelCategoryCode() {} 


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

   public class FuelThresholdCode
   {
      static FuelThresholdCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private FuelThresholdCode() {} 


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

   public class NnoCodeType
   {
      private static XBPatternValidator patternValidator;

      static NnoCodeType() {
         XBUtil.license =  _NC1_InitOdb.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[0-9]*");
      }

      //constructor
      private NnoCodeType() {} 


      public static String encode(string value, com.objsys.xbinder.runtime.XBContext xbContext) 
      {
         //validate length facet
         if (value.Length < 1 || value.Length > 13)
            throw new XBLengthVioException(value.Length);
         patternValidator.validate(value);
         return value;
      }


      public static string decode(String text, com.objsys.xbinder.runtime.XBContext xbContext
         ) {
         patternValidator.validate(text);
         //validate length facet
         if (text.Length < 1 || text.Length > 13)
            throw new XBLengthVioException(text.Length);
         return text;
      }
   }

   public class PackagingTypeCode
   {
      static PackagingTypeCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private PackagingTypeCode() {} 


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

   public class RangeTypeCode
   {
      static RangeTypeCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private RangeTypeCode() {} 


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

   public class RessourceTypeCode
   {
      static RessourceTypeCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private RessourceTypeCode() {} 


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

   public class RicCodeType
   {
      private static XBPatternValidator patternValidator;

      static RicCodeType() {
         XBUtil.license =  _NC1_InitOdb.license;
         patternValidator = new XBPatternValidator();
         patternValidator.addPattern("[A-Z0-9]*");
      }

      //constructor
      private RicCodeType() {} 


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

   public class SupplyClassCode
   {
      static SupplyClassCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private SupplyClassCode() {} 


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

   public class UnitOfMeasurementCode
   {
      static UnitOfMeasurementCode() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //constructor
      private UnitOfMeasurementCode() {} 


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

   public class NC1_InitOdb_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:initodb",
          "NC1_InitOdb_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","operationName"),
         new XBQualifiedName("","forces"),
         new XBQualifiedName("","equipmentsHoldings"),
         new XBQualifiedName("","resourcesHoldings"),
         new XBQualifiedName("","staffHoldings"),
         new XBQualifiedName("","comment")
      };
      static NC1_InitOdb_ELEM() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected string operationName;
      protected bool _set_operationName = false;
      protected System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_forces> forces;
         
      protected System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_equipmentsHoldings> equipmentsHoldings;
         
      protected System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_resourcesHoldings> resourcesHoldings;
         
      protected System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_staffHoldings> staffHoldings;
         
      protected  CommentSectionType comment;   //optional

      //attribute methods

      //content methods

      public string OperationName
      {
         get
         {
            if (!_set_operationName)
                throw new XBException("field operationName not set");

            return this.operationName;
         }
         set
         {
            this.operationName = value;
            _set_operationName = true;
         }
      }

      public System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_forces> Forces
      {
         get
         {
            if (this.forces == null) {
               this.forces = new List< NC1_InitOdb_ELEM_2_forces>();
            }
            return this.forces;
         }
      }

      public System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_equipmentsHoldings> EquipmentsHoldings
      {
         get
         {
            if (this.equipmentsHoldings == null) {
               this.equipmentsHoldings = 
                  new List< NC1_InitOdb_ELEM_2_equipmentsHoldings>();
            }
            return this.equipmentsHoldings;
         }
      }

      public System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_resourcesHoldings> ResourcesHoldings
      {
         get
         {
            if (this.resourcesHoldings == null) {
               this.resourcesHoldings = 
                  new List< NC1_InitOdb_ELEM_2_resourcesHoldings>();
            }
            return this.resourcesHoldings;
         }
      }

      public System.Collections.Generic.IList< NC1_InitOdb_ELEM_2_staffHoldings> StaffHoldings
      {
         get
         {
            if (this.staffHoldings == null) {
               this.staffHoldings = 
                  new List< NC1_InitOdb_ELEM_2_staffHoldings>();
            }
            return this.staffHoldings;
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

               // operationName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.operationName =  Text1To50Type.decode(text, xbContext);

                  _set_operationName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // forces
               this.forces = new List< NC1_InitOdb_ELEM_2_forces>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   NC1_InitOdb_ELEM_2_forces _tmp_forces;
                  _tmp_forces = new  NC1_InitOdb_ELEM_2_forces();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_forces.decode(reader, xbContext, false, false);
                  this.forces.Add(_tmp_forces);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // equipmentsHoldings
               this.equipmentsHoldings = 
                  new List< NC1_InitOdb_ELEM_2_equipmentsHoldings>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   NC1_InitOdb_ELEM_2_equipmentsHoldings _tmp_equipmentsHoldings;
                  _tmp_equipmentsHoldings = new  NC1_InitOdb_ELEM_2_equipmentsHoldings();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_equipmentsHoldings.decode(reader, xbContext, false, false);
                  this.equipmentsHoldings.Add(_tmp_equipmentsHoldings);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // resourcesHoldings
               this.resourcesHoldings = 
                  new List< NC1_InitOdb_ELEM_2_resourcesHoldings>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   NC1_InitOdb_ELEM_2_resourcesHoldings _tmp_resourcesHoldings;
                  _tmp_resourcesHoldings = new  NC1_InitOdb_ELEM_2_resourcesHoldings();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_resourcesHoldings.decode(reader, xbContext, false, false);
                  this.resourcesHoldings.Add(_tmp_resourcesHoldings);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // staffHoldings
               this.staffHoldings = 
                  new List< NC1_InitOdb_ELEM_2_staffHoldings>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   NC1_InitOdb_ELEM_2_staffHoldings _tmp_staffHoldings;
                  _tmp_staffHoldings = new  NC1_InitOdb_ELEM_2_staffHoldings();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_staffHoldings.decode(reader, xbContext, false, false);
                  this.staffHoldings.Add(_tmp_staffHoldings);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  this.comment = new  CommentSectionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.comment.decode(reader, xbContext, false, false);

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

         // operationName
         if (_set_operationName)  {
            encoder.encodeStartElement("operationName", "", "");
            String text_4;
            text_4 =  Text1To50Type.encode(this.operationName, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // forces
         if ( this.forces != null ){
            foreach ( NC1_InitOdb_ELEM_2_forces _tmp_forces in this.forces)
            {
               encoder.encodeStartElement("forces", "", "");
               _tmp_forces.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // equipmentsHoldings
         if ( this.equipmentsHoldings != null ){
            foreach ( NC1_InitOdb_ELEM_2_equipmentsHoldings _tmp_equipmentsHoldings in this.equipmentsHoldings)
            {
               encoder.encodeStartElement("equipmentsHoldings", "", "");
               _tmp_equipmentsHoldings.encode(encoder, xbContext, null, 
                  false);
               encoder.encodeEndElement();
            }
         }

         // resourcesHoldings
         if ( this.resourcesHoldings != null ){
            foreach ( NC1_InitOdb_ELEM_2_resourcesHoldings _tmp_resourcesHoldings in this.resourcesHoldings)
            {
               encoder.encodeStartElement("resourcesHoldings", "", "");
               _tmp_resourcesHoldings.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // staffHoldings
         if ( this.staffHoldings != null ){
            foreach ( NC1_InitOdb_ELEM_2_staffHoldings _tmp_staffHoldings in this.staffHoldings)
            {
               encoder.encodeStartElement("staffHoldings", "", "");
               _tmp_staffHoldings.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // comment
         if (this.comment != null)  {
            encoder.encodeStartElement("comment", "", "");
            this.comment.encode(encoder, xbContext, null, false);
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

   public class NC1_InitOdb_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:initodb","NC1_InitOdb")
      };
      static NC1_InitOdb_CC() {
         XBUtil.license =  _NC1_InitOdb.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_InitOdb_ELEM nC1_InitOdb;

      //content methods

      public  NC1_InitOdb_ELEM NC1_InitOdb
      {
         get
         {
            if (this.nC1_InitOdb == null)
                throw new XBException("field nC1_InitOdb not set");

            return this.nC1_InitOdb;
         }
         set
         {
            this.nC1_InitOdb = value;
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
         //   encoder.setNamespaces(_NC1_InitOdb.namespaceContext);

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

            // nC1_InitOdb
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_InitOdb = new  NC1_InitOdb_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_InitOdb.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_InitOdb");

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

         // nC1_InitOdb
         if (this.nC1_InitOdb == null)
             throw new XBException("field nC1_InitOdb not set");

         encoder.encodeStartElement("NC1_InitOdb",  _NC1_InitOdb.NS_URI,  _NC1_InitOdb.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_InitOdb.encode(encoder, xbContext, null, false);
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

   public class _NC1_InitOdb {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:initodb";
      public static readonly String NS_PREFIX = "nc1initodb";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_InitOdb() {
      }
      static _NC1_InitOdb() {
         XBUtil.license = _NC1_InitOdb.license;
      }
   }
}
