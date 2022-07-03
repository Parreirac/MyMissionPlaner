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
    using FreeShapeType = NC1.Obj.freeshape.FreeShapeType;
    using CbrnEventType = NC1.Obj.cbrnevent.CbrnEventType;
    using EventType = NC1.Obj._event.EventType;
    using TacPointType = NC1.Obj.tacpoint.TacPointType;
    using TacLineType = NC1.Obj.tacline.TacLineType;
    using TacAreaType = NC1.Obj.tacarea.TacAreaType;
    using RouteType = NC1.Obj.route.RouteType;
    using IntelRequirementType = NC1.Obj.intelrequirement.IntelRequirementType;



    public class NC1_PEMA_ELEM_12
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:pema",
          "NC1_PEMA_ELEM_12");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("","subordinateUnitId"),
         new XBQualifiedName("","unitTypeDescription")
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
         None, subordinateUnitId, unitTypeDescription}
      protected Choice _whichField;
      static NC1_PEMA_ELEM_12() {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected System.Collections.Generic.IList< Nc1ObjectRefType> subordinateUnitId;
         
      protected string unitTypeDescription;

      //content methods

      public System.Collections.Generic.IList< Nc1ObjectRefType> SubordinateUnitId
      {
         get
         {
            if (_whichField != Choice.subordinateUnitId ) 
               throw new XBException("field subordinateUnitId not set");
            if (_whichField  != Choice.subordinateUnitId) {
               this.subordinateUnitId = new List< Nc1ObjectRefType>();
               _whichField = Choice.subordinateUnitId;
            }
            return this.subordinateUnitId;
         }
      }

      public string UnitTypeDescription
      {
         get
         {
            if (_whichField != Choice.unitTypeDescription ) 
               throw new XBException("field unitTypeDescription not set");
            return this.unitTypeDescription;
         }
         set
         {
            this.unitTypeDescription = value;
            _whichField = Choice.unitTypeDescription;
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

            // subordinateUnitId
            if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.subordinateUnitId = new List< Nc1ObjectRefType>();
               do  {
                   Nc1ObjectRefType _tmp_subordinateUnitId;
                  _tmp_subordinateUnitId = new  Nc1ObjectRefType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_subordinateUnitId.decode(reader, xbContext, false, false);
                  this.subordinateUnitId.Add(_tmp_subordinateUnitId);
                  _whichField = Choice.subordinateUnitId;

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
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) );
            }

            // unitTypeDescription
            else if ( XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
            {
               xbContext.decodeSchemaLocationAttrs(reader);
               String text = reader.ReadString();
               this.unitTypeDescription =  MediumTextType.decode(text, xbContext);
               _whichField = Choice.unitTypeDescription;

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

            // subordinateUnitId
            case Choice.subordinateUnitId: {
               if (this.subordinateUnitId == null || 
                  this.subordinateUnitId.Count < 1) 
                  throw new XBOccurrencesException( (this.subordinateUnitId == null ? 0 : this.subordinateUnitId.Count ) );

               foreach ( Nc1ObjectRefType _tmp_subordinateUnitId in this.subordinateUnitId)
               {
                  encoder.encodeStartElement("subordinateUnitId", "", "");
                  _tmp_subordinateUnitId.encode(encoder, xbContext, null, 
                     false);
                  encoder.encodeEndElement();
               }
               break;
            }

            // unitTypeDescription
            case Choice.unitTypeDescription: {
               if (_whichField != Choice.unitTypeDescription ) 
                  throw new XBException("field unitTypeDescription not set");
               encoder.encodeStartElement("unitTypeDescription", "", "");
               String text_5;
               text_5 =  MediumTextType.encode(this.unitTypeDescription, xbContext);
               encoder.encodeChars(text_5);
               encoder.encodeEndElement();
               break;
            }
            default: throw new XBException("no field set for choice group");
         }
      }
   }

   public class NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea
       : com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:pema",
          "NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","physicalObject"),
         new XBQualifiedName("","tacPoint"),
         new XBQualifiedName("","tacLine"),
         new XBQualifiedName("","tacArea"),
         new XBQualifiedName("","freeShape")
      };

      public enum Choice  {
         None, physicalObject, tacPoint, tacLine, tacArea, freeShape}
      protected Choice _whichField;
      static NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea() 
      {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  PhysicalObjectType physicalObject;
      protected  TacPointType tacPoint;
      protected  TacLineType tacLine;
      protected  TacAreaType tacArea;
      protected  FreeShapeType freeShape;

      //attribute methods

      //content methods

      public  PhysicalObjectType PhysicalObject
      {
         get
         {
            if (_whichField != Choice.physicalObject ) 
               throw new XBException("field physicalObject not set");
            return this.physicalObject;
         }
         set
         {
            this.physicalObject = value;
            _whichField = Choice.physicalObject;
         }
      }

      public  TacPointType TacPoint
      {
         get
         {
            if (_whichField != Choice.tacPoint ) 
               throw new XBException("field tacPoint not set");
            return this.tacPoint;
         }
         set
         {
            this.tacPoint = value;
            _whichField = Choice.tacPoint;
         }
      }

      public  TacLineType TacLine
      {
         get
         {
            if (_whichField != Choice.tacLine ) 
               throw new XBException("field tacLine not set");
            return this.tacLine;
         }
         set
         {
            this.tacLine = value;
            _whichField = Choice.tacLine;
         }
      }

      public  TacAreaType TacArea
      {
         get
         {
            if (_whichField != Choice.tacArea ) 
               throw new XBException("field tacArea not set");
            return this.tacArea;
         }
         set
         {
            this.tacArea = value;
            _whichField = Choice.tacArea;
         }
      }

      public  FreeShapeType FreeShape
      {
         get
         {
            if (_whichField != Choice.freeShape ) 
               throw new XBException("field freeShape not set");
            return this.freeShape;
         }
         set
         {
            this.freeShape = value;
            _whichField = Choice.freeShape;
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

               // physicalObject
               if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.physicalObject =  PhysicalObjectType.createObject(
                     XMLStreamHelper.readXsiType(reader) );
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.physicalObject.decode(reader, xbContext, false, false);
                  _whichField = Choice.physicalObject;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // tacPoint
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.tacPoint = new  TacPointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.tacPoint.decode(reader, xbContext, false, false);
                  _whichField = Choice.tacPoint;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // tacLine
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  this.tacLine = new  TacLineType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.tacLine.decode(reader, xbContext, false, false);
                  _whichField = Choice.tacLine;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // tacArea
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  this.tacArea = new  TacAreaType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.tacArea.decode(reader, xbContext, false, false);
                  _whichField = Choice.tacArea;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }

               // freeShape
               else if ( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  this.freeShape = new  FreeShapeType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.freeShape.decode(reader, xbContext, false, false);
                  _whichField = Choice.freeShape;

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

            // physicalObject
            case Choice.physicalObject: {
               if (_whichField != Choice.physicalObject ) 
                  throw new XBException("field physicalObject not set");
               encoder.encodeStartElement("physicalObject", "", "");
               this.physicalObject.encode(encoder, xbContext, 
                   PhysicalObjectType.XSD_TYPE, false);
               encoder.encodeEndElement();
               break;
            }

            // tacPoint
            case Choice.tacPoint: {
               if (_whichField != Choice.tacPoint ) 
                  throw new XBException("field tacPoint not set");
               encoder.encodeStartElement("tacPoint", "", "");
               this.tacPoint.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // tacLine
            case Choice.tacLine: {
               if (_whichField != Choice.tacLine ) 
                  throw new XBException("field tacLine not set");
               encoder.encodeStartElement("tacLine", "", "");
               this.tacLine.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // tacArea
            case Choice.tacArea: {
               if (_whichField != Choice.tacArea ) 
                  throw new XBException("field tacArea not set");
               encoder.encodeStartElement("tacArea", "", "");
               this.tacArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
               break;
            }

            // freeShape
            case Choice.freeShape: {
               if (_whichField != Choice.freeShape ) 
                  throw new XBException("field freeShape not set");
               encoder.encodeStartElement("freeShape", "", "");
               this.freeShape.encode(encoder, xbContext, null, false);
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

   public class NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:pema",
          "NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","meansDescription"),
         new XBQualifiedName("","associatedArea")
      };
      static NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans() {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_PEMA_ELEM_12 nC1_PEMA_ELEM_12;
      protected string meansDescription;
      protected bool _set_meansDescription = false;
      protected  NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea associatedArea;
         

      //attribute methods

      //content methods

      public  NC1_PEMA_ELEM_12 NC1_PEMA_ELEM_12
      {
         get
         {
            if (this.nC1_PEMA_ELEM_12 == null)
                throw new XBException("field nC1_PEMA_ELEM_12 not set");

            return this.nC1_PEMA_ELEM_12;
         }
         set
         {
            this.nC1_PEMA_ELEM_12 = value;
         }
      }

      public string MeansDescription
      {
         get
         {
            if (!_set_meansDescription)
                throw new XBException("field meansDescription not set");

            return this.meansDescription;
         }
         set
         {
            this.meansDescription = value;
            _set_meansDescription = true;
         }
      }

      public  NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea AssociatedArea
      {
         get
         {
            if (this.associatedArea == null)
                throw new XBException("field associatedArea not set");

            return this.associatedArea;
         }
         set
         {
            this.associatedArea = value;
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

               // nC1_PEMA_ELEM_12
               if( moreContent_4 && 
                   NC1_PEMA_ELEM_12.acceptsElem(elemNs, elemLocalName) )
               {
                  this.nC1_PEMA_ELEM_12 = new  NC1_PEMA_ELEM_12();
                  this.nC1_PEMA_ELEM_12.decode(reader, xbContext);
                  moreContent_4 = !XMLStreamHelper.isEndContent(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "nC1_PEMA_ELEM_12");

               // meansDescription
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.meansDescription =  LongTextType.decode(text, xbContext);

                  _set_meansDescription = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // associatedArea
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  this.associatedArea = new  NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans_associatedArea();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.associatedArea.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "associatedArea");

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

         // nC1_PEMA_ELEM_12
         if (this.nC1_PEMA_ELEM_12 == null)
             throw new XBException("field nC1_PEMA_ELEM_12 not set");

         this.nC1_PEMA_ELEM_12.encode(encoder, xbContext);

         // meansDescription
         if (_set_meansDescription)  {
            encoder.encodeStartElement("meansDescription", "", "");
            String text_4;
            text_4 =  LongTextType.encode(this.meansDescription, xbContext);
            encoder.encodeChars(text_4);
            encoder.encodeEndElement();
         }

         // associatedArea
         if (this.associatedArea == null)
             throw new XBException("field associatedArea not set");

         encoder.encodeStartElement("associatedArea", "", "");
         this.associatedArea.encode(encoder, xbContext, null, false);
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

   public class NC1_PEMA_ELEM_2_intelCollectionMeansPlan : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:pema",
          "NC1_PEMA_ELEM_2_intelCollectionMeansPlan");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","intelRequirement"),
         new XBQualifiedName("","involvedPhysicalObject"),
         new XBQualifiedName("","involvedRoute"),
         new XBQualifiedName("","involvedTacPoint"),
         new XBQualifiedName("","involvedTacLine"),
         new XBQualifiedName("","involvedTacArea"),
         new XBQualifiedName("","involvedEvent"),
         new XBQualifiedName("","involvedCbrnEvent"),
         new XBQualifiedName("","involvedFreeShape"),
         new XBQualifiedName("","intelMeans")
      };
      static NC1_PEMA_ELEM_2_intelCollectionMeansPlan() {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  IntelRequirementType intelRequirement;
      protected System.Collections.Generic.IList< PhysicalObjectType> involvedPhysicalObject;
         
      protected System.Collections.Generic.IList< RouteType> involvedRoute;
         
      protected System.Collections.Generic.IList< TacPointType> involvedTacPoint;
         
      protected System.Collections.Generic.IList< TacLineType> involvedTacLine;
         
      protected System.Collections.Generic.IList< TacAreaType> involvedTacArea;
         
      protected System.Collections.Generic.IList< EventType> involvedEvent;
         
      protected System.Collections.Generic.IList< CbrnEventType> involvedCbrnEvent;
         
      protected System.Collections.Generic.IList< FreeShapeType> involvedFreeShape;
         
      protected System.Collections.Generic.IList< NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans> intelMeans;
         

      //attribute methods

      //content methods

      public  IntelRequirementType IntelRequirement
      {
         get
         {
            if (this.intelRequirement == null)
                throw new XBException("field intelRequirement not set");

            return this.intelRequirement;
         }
         set
         {
            this.intelRequirement = value;
         }
      }

      public System.Collections.Generic.IList< PhysicalObjectType> InvolvedPhysicalObject
      {
         get
         {
            if (this.involvedPhysicalObject == null) {
               this.involvedPhysicalObject = 
                  new List< PhysicalObjectType>();
            }
            return this.involvedPhysicalObject;
         }
      }

      public System.Collections.Generic.IList< RouteType> InvolvedRoute
      {
         get
         {
            if (this.involvedRoute == null) {
               this.involvedRoute = new List< RouteType>();
            }
            return this.involvedRoute;
         }
      }

      public System.Collections.Generic.IList< TacPointType> InvolvedTacPoint
      {
         get
         {
            if (this.involvedTacPoint == null) {
               this.involvedTacPoint = new List< TacPointType>();
            }
            return this.involvedTacPoint;
         }
      }

      public System.Collections.Generic.IList< TacLineType> InvolvedTacLine
      {
         get
         {
            if (this.involvedTacLine == null) {
               this.involvedTacLine = new List< TacLineType>();
            }
            return this.involvedTacLine;
         }
      }

      public System.Collections.Generic.IList< TacAreaType> InvolvedTacArea
      {
         get
         {
            if (this.involvedTacArea == null) {
               this.involvedTacArea = new List< TacAreaType>();
            }
            return this.involvedTacArea;
         }
      }

      public System.Collections.Generic.IList< EventType> InvolvedEvent
      {
         get
         {
            if (this.involvedEvent == null) {
               this.involvedEvent = new List< EventType>();
            }
            return this.involvedEvent;
         }
      }

      public System.Collections.Generic.IList< CbrnEventType> InvolvedCbrnEvent
      {
         get
         {
            if (this.involvedCbrnEvent == null) {
               this.involvedCbrnEvent = new List< CbrnEventType>();
            }
            return this.involvedCbrnEvent;
         }
      }

      public System.Collections.Generic.IList< FreeShapeType> InvolvedFreeShape
      {
         get
         {
            if (this.involvedFreeShape == null) {
               this.involvedFreeShape = new List< FreeShapeType>();
            }
            return this.involvedFreeShape;
         }
      }

      public System.Collections.Generic.IList< NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans> IntelMeans
      {
         get
         {
            if (this.intelMeans == null) {
               this.intelMeans = 
                  new List< NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans>()
                  ;
            }
            return this.intelMeans;
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

               // intelRequirement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                  this.intelRequirement = new  IntelRequirementType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  this.intelRequirement.decode(reader, xbContext, false, false);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "intelRequirement");

               // involvedPhysicalObject
               this.involvedPhysicalObject = 
                  new List< PhysicalObjectType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   PhysicalObjectType _tmp_involvedPhysicalObject;
                  _tmp_involvedPhysicalObject = 
                      PhysicalObjectType.createObject(
                     XMLStreamHelper.readXsiType(reader) );
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedPhysicalObject.decode(reader, xbContext, false, false);
                  this.involvedPhysicalObject.Add(_tmp_involvedPhysicalObject
                     );

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedRoute
               this.involvedRoute = new List< RouteType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                   RouteType _tmp_involvedRoute;
                  _tmp_involvedRoute = new  RouteType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedRoute.decode(reader, xbContext, false, false);
                  this.involvedRoute.Add(_tmp_involvedRoute);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedTacPoint
               this.involvedTacPoint = new List< TacPointType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                   TacPointType _tmp_involvedTacPoint;
                  _tmp_involvedTacPoint = new  TacPointType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedTacPoint.decode(reader, xbContext, false, false);
                  this.involvedTacPoint.Add(_tmp_involvedTacPoint);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedTacLine
               this.involvedTacLine = new List< TacLineType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                   TacLineType _tmp_involvedTacLine;
                  _tmp_involvedTacLine = new  TacLineType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedTacLine.decode(reader, xbContext, false, false);
                  this.involvedTacLine.Add(_tmp_involvedTacLine);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedTacArea
               this.involvedTacArea = new List< TacAreaType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                   TacAreaType _tmp_involvedTacArea;
                  _tmp_involvedTacArea = new  TacAreaType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedTacArea.decode(reader, xbContext, false, false);
                  this.involvedTacArea.Add(_tmp_involvedTacArea);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedEvent
               this.involvedEvent = new List< EventType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                   EventType _tmp_involvedEvent;
                  _tmp_involvedEvent = new  EventType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedEvent.decode(reader, xbContext, false, false);
                  this.involvedEvent.Add(_tmp_involvedEvent);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedCbrnEvent
               this.involvedCbrnEvent = new List< CbrnEventType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                   CbrnEventType _tmp_involvedCbrnEvent;
                  _tmp_involvedCbrnEvent = new  CbrnEventType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedCbrnEvent.decode(reader, xbContext, false, false);
                  this.involvedCbrnEvent.Add(_tmp_involvedCbrnEvent);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // involvedFreeShape
               this.involvedFreeShape = new List< FreeShapeType>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                   FreeShapeType _tmp_involvedFreeShape;
                  _tmp_involvedFreeShape = new  FreeShapeType();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_involvedFreeShape.decode(reader, xbContext, false, false);
                  this.involvedFreeShape.Add(_tmp_involvedFreeShape);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // intelMeans
               this.intelMeans = 
                  new List< NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                   NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans _tmp_intelMeans;
                  _tmp_intelMeans = new  NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_intelMeans.decode(reader, xbContext, false, false);
                  this.intelMeans.Add(_tmp_intelMeans);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.intelMeans.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.intelMeans.Count, "intelMeans");
               else if (this.intelMeans.Count == 0 && moreContent_4) 
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

         // intelRequirement
         if (this.intelRequirement == null)
             throw new XBException("field intelRequirement not set");

         encoder.encodeStartElement("intelRequirement", "", "");
         this.intelRequirement.encode(encoder, xbContext, null, false);
         encoder.encodeEndElement();

         // involvedPhysicalObject
         if ( this.involvedPhysicalObject != null ){
            foreach ( PhysicalObjectType _tmp_involvedPhysicalObject in this.involvedPhysicalObject)
            {
               encoder.encodeStartElement("involvedPhysicalObject", "", "");
               _tmp_involvedPhysicalObject.encode(encoder, xbContext, 
                   PhysicalObjectType.XSD_TYPE, false);
               encoder.encodeEndElement();
            }
         }

         // involvedRoute
         if ( this.involvedRoute != null ){
            foreach ( RouteType _tmp_involvedRoute in this.involvedRoute)
            {
               encoder.encodeStartElement("involvedRoute", "", "");
               _tmp_involvedRoute.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedTacPoint
         if ( this.involvedTacPoint != null ){
            foreach ( TacPointType _tmp_involvedTacPoint in this.involvedTacPoint)
            {
               encoder.encodeStartElement("involvedTacPoint", "", "");
               _tmp_involvedTacPoint.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedTacLine
         if ( this.involvedTacLine != null ){
            foreach ( TacLineType _tmp_involvedTacLine in this.involvedTacLine)
            {
               encoder.encodeStartElement("involvedTacLine", "", "");
               _tmp_involvedTacLine.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedTacArea
         if ( this.involvedTacArea != null ){
            foreach ( TacAreaType _tmp_involvedTacArea in this.involvedTacArea)
            {
               encoder.encodeStartElement("involvedTacArea", "", "");
               _tmp_involvedTacArea.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedEvent
         if ( this.involvedEvent != null ){
            foreach ( EventType _tmp_involvedEvent in this.involvedEvent)
            {
               encoder.encodeStartElement("involvedEvent", "", "");
               _tmp_involvedEvent.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedCbrnEvent
         if ( this.involvedCbrnEvent != null ){
            foreach ( CbrnEventType _tmp_involvedCbrnEvent in this.involvedCbrnEvent)
            {
               encoder.encodeStartElement("involvedCbrnEvent", "", "");
               _tmp_involvedCbrnEvent.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // involvedFreeShape
         if ( this.involvedFreeShape != null ){
            foreach ( FreeShapeType _tmp_involvedFreeShape in this.involvedFreeShape)
            {
               encoder.encodeStartElement("involvedFreeShape", "", "");
               _tmp_involvedFreeShape.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // intelMeans
         if (this.intelMeans == null || this.intelMeans.Count < 1) 
            throw new XBOccurrencesException( (this.intelMeans == null ? 0 : this.intelMeans.Count ) );

         foreach ( NC1_PEMA_ELEM_2_intelCollectionMeansPlan_intelMeans _tmp_intelMeans in this.intelMeans)
         {
            encoder.encodeStartElement("intelMeans", "", "");
            _tmp_intelMeans.encode(encoder, xbContext, null, false);
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

   public class NC1_PEMA_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:pema",
          "NC1_PEMA_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","intelCollectionMeansPlan"),
         new XBQualifiedName("","comment")
      };
      static NC1_PEMA_ELEM() {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected System.Collections.Generic.IList< NC1_PEMA_ELEM_2_intelCollectionMeansPlan> intelCollectionMeansPlan;
         
      protected  CommentSectionType comment;   //optional

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< NC1_PEMA_ELEM_2_intelCollectionMeansPlan> IntelCollectionMeansPlan
      {
         get
         {
            if (this.intelCollectionMeansPlan == null) {
               this.intelCollectionMeansPlan = 
                  new List< NC1_PEMA_ELEM_2_intelCollectionMeansPlan>();
            }
            return this.intelCollectionMeansPlan;
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

               // intelCollectionMeansPlan
               this.intelCollectionMeansPlan = 
                  new List< NC1_PEMA_ELEM_2_intelCollectionMeansPlan>();
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   NC1_PEMA_ELEM_2_intelCollectionMeansPlan _tmp_intelCollectionMeansPlan;
                  _tmp_intelCollectionMeansPlan = new  NC1_PEMA_ELEM_2_intelCollectionMeansPlan();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_intelCollectionMeansPlan.decode(reader, xbContext, false, false);
                  this.intelCollectionMeansPlan.Add(
                     _tmp_intelCollectionMeansPlan);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }
               if ( this.intelCollectionMeansPlan.Count < 1 && !moreContent_4) 
                  throw new XBOccurrencesException(this.intelCollectionMeansPlan.Count, "intelCollectionMeansPlan");
               else if (this.intelCollectionMeansPlan.Count == 0 && moreContent_4) 
                  throw new XBUnexpectedElementException(elemNs, elemLocalName);

               // comment
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
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

         // intelCollectionMeansPlan
         if (this.intelCollectionMeansPlan == null || 
            this.intelCollectionMeansPlan.Count < 1) 
            throw new XBOccurrencesException( (this.intelCollectionMeansPlan == null ? 0 : this.intelCollectionMeansPlan.Count ) );

         foreach ( NC1_PEMA_ELEM_2_intelCollectionMeansPlan _tmp_intelCollectionMeansPlan in this.intelCollectionMeansPlan)
         {
            encoder.encodeStartElement("intelCollectionMeansPlan", "", "");
            _tmp_intelCollectionMeansPlan.encode(encoder, xbContext, null, 
               false);
            encoder.encodeEndElement();
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

   public class NC1_PEMA_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:pema","NC1_PEMA")
      };
      static NC1_PEMA_CC() {
         XBUtil.license =  _NC1_PEMA.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_PEMA_ELEM nC1_PEMA;

      //content methods

      public  NC1_PEMA_ELEM NC1_PEMA
      {
         get
         {
            if (this.nC1_PEMA == null)
                throw new XBException("field nC1_PEMA not set");

            return this.nC1_PEMA;
         }
         set
         {
            this.nC1_PEMA = value;
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
         //   encoder.setNamespaces(_NC1_PEMA.namespaceContext);

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

            // nC1_PEMA
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_PEMA = new  NC1_PEMA_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_PEMA.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_PEMA");

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

         // nC1_PEMA
         if (this.nC1_PEMA == null)
             throw new XBException("field nC1_PEMA not set");

         encoder.encodeStartElement("NC1_PEMA",  _NC1_PEMA.NS_URI,  _NC1_PEMA.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_PEMA.encode(encoder, xbContext, null, false);
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

   public class _NC1_PEMA {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:pema";
      public static readonly String NS_PREFIX = "nc1pema";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_PEMA() {
      }
      static _NC1_PEMA() {
         XBUtil.license = _NC1_PEMA.license;
      }
   }
}
