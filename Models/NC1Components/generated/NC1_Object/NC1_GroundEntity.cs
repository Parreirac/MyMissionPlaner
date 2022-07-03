using System;
using System.Text;
using System.Collections.Generic;
using com.objsys.xbinder.runtime;
namespace NC1.Obj.groundentity
{

   using System.IO;
   using System.Xml;
   using com.objsys.xbinder.runtime;
    using NC1.Dictionnaries;
    using NC1.Obj;
    using NC1.Location;
 //   using PointType = NC1.Location.PointType;
    public class GroundEntityType_4
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:groundentity",
          "GroundEntityType_4");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","point"),
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
         return false;
      }

      public enum Choice  {
         None, point, polyline, polygon, circle, ellipse, arcband}
      protected Choice _whichField;
      static GroundEntityType_4() {
         XBUtil.license =  _NC1_GroundEntity.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PointType point;
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

            // polyline
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               this.polyline = new  PolylineType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.polyline.decode(reader, xbContext, false, false);
               _whichField = Choice.polyline;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // polygon
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
            {
               this.polygon = new  PolygonType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.polygon.decode(reader, xbContext, false, false);
               _whichField = Choice.polygon;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // circle
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
            {
               this.circle = new  CircleType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.circle.decode(reader, xbContext, false, false);
               _whichField = Choice.circle;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // ellipse
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
            {
               this.ellipse = new  EllipseType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.ellipse.decode(reader, xbContext, false, false);
               _whichField = Choice.ellipse;

               XMLStreamHelper.moveToContentElement(reader);
            }

            // arcband
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
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

   public class GroundEntityType_2_location : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:groundentity",
          "GroundEntityType_2_location");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","quality")
      };
      static GroundEntityType_2_location() {
         XBUtil.license =  _NC1_GroundEntity.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected bool _set_name = false;
      protected  GroundEntityType_4 groundEntityType_4;
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

      public  GroundEntityType_4 GroundEntityType_4
      {
         get
         {
            if (this.groundEntityType_4 == null)
                throw new XBException("field groundEntityType_4 not set");

            return this.groundEntityType_4;
         }
         set
         {
            this.groundEntityType_4 = value;
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

               // groundEntityType_4
               if( moreContent_4 && 
                   GroundEntityType_4.acceptsElem(elemNs, elemLocalName)
                   )
               {
                  this.groundEntityType_4 = new  GroundEntityType_4();
                  this.groundEntityType_4.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "groundEntityType_4");

               // quality
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
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

         // groundEntityType_4
         if (this.groundEntityType_4 == null)
             throw new XBException("field groundEntityType_4 not set");

         this.groundEntityType_4.encode(encoder, xbContext);

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

   public class GroundEntityType_2_tacticalData : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:groundentity",
          "GroundEntityType_2_tacticalData");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","name"),
         new XBQualifiedName("","type"),
         new XBQualifiedName("","description"),
         new XBQualifiedName("","status"),
         new XBQualifiedName("","dimensions"),
         new XBQualifiedName("","achievementStatus"),
         new XBQualifiedName("","validityPeriod"),
         new XBQualifiedName("","url"),
         new XBQualifiedName("","comment"),
         new XBQualifiedName("","extVersion")
      };
      static GroundEntityType_2_tacticalData() {
         XBUtil.license =  _NC1_GroundEntity.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string name;
      protected bool _set_name = false;
      protected int type;
      protected bool _set_type = false;
      protected string description;
      protected bool _set_description = false;
      protected int status;
      protected bool _set_status = false;
      protected  DimensionType dimensions;   //optional
      protected int achievementStatus;
      protected bool _set_achievementStatus = false;
      protected System.Collections.Generic.IList< PeriodType> validityPeriod;
         
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

      public int Type
      {
         get
         {
            if (!_set_type) throw new XBException("field type not set");

            return this.type;
         }
         set
         {
            this.type = value;
            _set_type = true;
         }
      }

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

      public int Status
      {
         get
         {
            if (!_set_status) throw new XBException("field status not set");

            return this.status;
         }
         set
         {
            this.status = value;
            _set_status = true;
         }
      }

      public  DimensionType Dimensions
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

      public int AchievementStatus
      {
         get
         {
            if (!_set_achievementStatus)
                throw new XBException("field achievementStatus not set");

            return this.achievementStatus;
         }
         set
         {
            this.achievementStatus = value;
            _set_achievementStatus = true;
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

               // type
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.type =  L110_39Code.decode(text, xbContext);

                  _set_type = true;

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
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.description =  LongTextObjectType.decode(text, xbContext);

                  _set_description = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // status
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.status =  L125_1Code.decode(text, xbContext);

                  _set_status = true;

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
                  this.dimensions = new  DimensionType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.dimensions.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // achievementStatus
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.achievementStatus =  L125_24Code.decode(text, xbContext);

                  _set_achievementStatus = true;

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
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
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

         // type
         if (_set_type)  {
            encoder.encodeStartElement("type", "", "");
            String text_4;
            text_4 =  L110_39Code.encode(this.type, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // description
         if (_set_description)  {
            encoder.encodeStartElement("description", "", "");
            String text_4;
            text_4 =  LongTextObjectType.encode(this.description, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // status
         if (_set_status)  {
            encoder.encodeStartElement("status", "", "");
            String text_4;
            text_4 =  L125_1Code.encode(this.status, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
            encoder.encodeEndElement();
         }

         // dimensions
         if (this.dimensions != null)  {
            encoder.encodeStartElement("dimensions", "", "");
            this.dimensions.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

         // achievementStatus
         if (_set_achievementStatus)  {
            encoder.encodeStartElement("achievementStatus", "", "");
            String text_4;
            text_4 =  L125_24Code.encode(this.achievementStatus, xbContext);
            encoder.encodeCharsNoEscaping(text_4);
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

   public class GroundEntityType :  PhysicalObjectType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:objet:groundentity",
          "GroundEntityType");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","location"),
         new XBQualifiedName("","tacticalData")
      };
      static GroundEntityType() {
         XBUtil.license =  _NC1_GroundEntity.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected  GroundEntityType_2_location location;   //optional
      protected  GroundEntityType_2_tacticalData tacticalData;
            //optional

      //attribute methods

      //content methods

      public  GroundEntityType_2_location Location
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

      public  GroundEntityType_2_tacticalData TacticalData
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

               // location
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.location = new  GroundEntityType_2_location();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.location.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // tacticalData
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.tacticalData = new  GroundEntityType_2_tacticalData();
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

         // location
         if (this.location != null)  {
            encoder.encodeStartElement("location", "", "");
            this.location.encode(encoder, xbContext, null, false);
            encoder.encodeEndElement();
         }

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

   public class NC1_GroundEntity_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:objet:groundentity","NC1_GroundEntity")
      };
      static NC1_GroundEntity_CC() {
         XBUtil.license =  _NC1_GroundEntity.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  GroundEntityType nC1_GroundEntity;

      //content methods

      public  GroundEntityType NC1_GroundEntity
      {
         get
         {
            if (this.nC1_GroundEntity == null)
                throw new XBException("field nC1_GroundEntity not set");

            return this.nC1_GroundEntity;
         }
         set
         {
            this.nC1_GroundEntity = value;
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
         //   encoder.setNamespaces(_NC1_GroundEntity.namespaceContext);

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

            // nC1_GroundEntity
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_GroundEntity = new  GroundEntityType();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_GroundEntity.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_GroundEntity");

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

         // nC1_GroundEntity
         if (this.nC1_GroundEntity == null)
             throw new XBException("field nC1_GroundEntity not set");

         encoder.encodeStartElement("NC1_GroundEntity",  _NC1_GroundEntity.NS_URI,  _NC1_GroundEntity.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_GroundEntity.encode(encoder, xbContext, null, false);
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

   public class _NC1_GroundEntity {

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
      public static readonly String NS_URI = "urn:fra:nc1:objet:groundentity";
      public static readonly String NS_PREFIX = "nc1groundentity";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_GroundEntity() {
      }
      static _NC1_GroundEntity() {
         XBUtil.license = _NC1_GroundEntity.license;
      }
   }
}
