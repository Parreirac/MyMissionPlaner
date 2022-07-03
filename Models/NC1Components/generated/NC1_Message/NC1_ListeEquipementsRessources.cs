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
    public class NC1_ListeEquipementsRessources_ELEM_2_equipments : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ler",
          "NC1_ListeEquipementsRessources_ELEM_2_equipments");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","nicCode"),
         new XBQualifiedName("","name"),
         new XBQualifiedName("","shortName"),
         new XBQualifiedName("","englishName"),
         new XBQualifiedName("","shortEnglishName"),
         new XBQualifiedName("","nnoCode"),
         new XBQualifiedName("","ricCode"),
         new XBQualifiedName("","category"),
         new XBQualifiedName("","isDangerous"),
         new XBQualifiedName("","isStackable"),
         new XBQualifiedName("","type"),
         new XBQualifiedName("","fuel"),
         new XBQualifiedName("","fuelConsumption"),
         new XBQualifiedName("","fuelThreshold"),
         new XBQualifiedName("","emptyWeight"),
         new XBQualifiedName("","grossWeight"),
         new XBQualifiedName("","width"),
         new XBQualifiedName("","length"),
         new XBQualifiedName("","height"),
         new XBQualifiedName("","turningRadius"),
         new XBQualifiedName("","axleLoad"),
         new XBQualifiedName("","vehicleMilitaryClass"),
         new XBQualifiedName("","supplyClass"),
         new XBQualifiedName("","mobilityCategory"),
         new XBQualifiedName("","loadMilitaryClass"),
         new XBQualifiedName("","transportationWidth"),
         new XBQualifiedName("","transportationLength"),
         new XBQualifiedName("","transportationHeight"),
         new XBQualifiedName("","isAirTransportable"),
         new XBQualifiedName("","isSeaTransportable"),
         new XBQualifiedName("","isRailTransportable"),
         new XBQualifiedName("","isRoadTransportable"),
         new XBQualifiedName("","isWaterwayTransportable"),
         new XBQualifiedName("","rangeMean"),
         new XBQualifiedName("","rangeType"),
         new XBQualifiedName("","range")
      };
      static NC1_ListeEquipementsRessources_ELEM_2_equipments() {
         XBUtil.license =  _NC1_ListeEquipementsRessources.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string nicCode;
      protected string name;
      protected string shortName;
      protected bool _set_shortName = false;
      protected string englishName;
      protected bool _set_englishName = false;
      protected string shortEnglishName;
      protected bool _set_shortEnglishName = false;
      protected string nnoCode;
      protected bool _set_nnoCode = false;
      protected string ricCode;
      protected bool _set_ricCode = false;
      protected int category;
      protected bool _set_category = false;
      protected bool isDangerous;
      protected bool _set_isDangerous = false;
      protected bool isStackable;
      protected bool _set_isStackable = false;
      protected string type;
      protected bool _set_type = false;
      protected int fuel;
      protected bool _set_fuel = false;
      protected decimal fuelConsumption;
      protected bool _set_fuelConsumption = false;
      protected int fuelThreshold;
      protected bool _set_fuelThreshold = false;
      protected ulong emptyWeight;
      protected bool _set_emptyWeight = false;
      protected ulong grossWeight;
      protected bool _set_grossWeight = false;
      protected decimal width;
      protected bool _set_width = false;
      protected decimal length;
      protected bool _set_length = false;
      protected decimal height;
      protected bool _set_height = false;
      protected decimal turningRadius;
      protected bool _set_turningRadius = false;
      protected double axleLoad;
      protected bool _set_axleLoad = false;
      protected uint vehicleMilitaryClass;
      protected bool _set_vehicleMilitaryClass = false;
      protected int supplyClass;
      protected bool _set_supplyClass = false;
      protected int mobilityCategory;
      protected bool _set_mobilityCategory = false;
      protected string loadMilitaryClass;
      protected bool _set_loadMilitaryClass = false;
      protected double transportationWidth;
      protected bool _set_transportationWidth = false;
      protected double transportationLength;
      protected bool _set_transportationLength = false;
      protected double transportationHeight;
      protected bool _set_transportationHeight = false;
      protected bool isAirTransportable;
      protected bool _set_isAirTransportable = false;
      protected bool isSeaTransportable;
      protected bool _set_isSeaTransportable = false;
      protected bool isRailTransportable;
      protected bool _set_isRailTransportable = false;
      protected bool isRoadTransportable;
      protected bool _set_isRoadTransportable = false;
      protected bool isWaterwayTransportable;
      protected bool _set_isWaterwayTransportable = false;
      protected string rangeMean;
      protected bool _set_rangeMean = false;
      protected int rangeType;
      protected bool _set_rangeType = false;
      protected decimal range;
      protected bool _set_range = false;

      //attribute methods

      //content methods

      public string NicCode
      {
         get { return this.nicCode; }
         set { this.nicCode = value; }
      }

      public string Name
      {
         get { return this.name; }
         set { this.name = value; }
      }

      public string ShortName
      {
         get
         {
            if (!_set_shortName)
                throw new XBException("field shortName not set");

            return this.shortName;
         }
         set
         {
            this.shortName = value;
            _set_shortName = true;
         }
      }

      public string EnglishName
      {
         get
         {
            if (!_set_englishName)
                throw new XBException("field englishName not set");

            return this.englishName;
         }
         set
         {
            this.englishName = value;
            _set_englishName = true;
         }
      }

      public string ShortEnglishName
      {
         get
         {
            if (!_set_shortEnglishName)
                throw new XBException("field shortEnglishName not set");

            return this.shortEnglishName;
         }
         set
         {
            this.shortEnglishName = value;
            _set_shortEnglishName = true;
         }
      }

      public string NnoCode
      {
         get
         {
            if (!_set_nnoCode) throw new XBException("field nnoCode not set");

            return this.nnoCode;
         }
         set
         {
            this.nnoCode = value;
            _set_nnoCode = true;
         }
      }

      public string RicCode
      {
         get
         {
            if (!_set_ricCode) throw new XBException("field ricCode not set");

            return this.ricCode;
         }
         set
         {
            this.ricCode = value;
            _set_ricCode = true;
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

      public bool IsDangerous
      {
         get
         {
            if (!_set_isDangerous)
                throw new XBException("field isDangerous not set");

            return this.isDangerous;
         }
         set
         {
            this.isDangerous = value;
            _set_isDangerous = true;
         }
      }

      public bool IsStackable
      {
         get
         {
            if (!_set_isStackable)
                throw new XBException("field isStackable not set");

            return this.isStackable;
         }
         set
         {
            this.isStackable = value;
            _set_isStackable = true;
         }
      }

      public string Type
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

      public int Fuel
      {
         get
         {
            if (!_set_fuel) throw new XBException("field fuel not set");

            return this.fuel;
         }
         set
         {
            this.fuel = value;
            _set_fuel = true;
         }
      }

      public decimal FuelConsumption
      {
         get
         {
            if (!_set_fuelConsumption)
                throw new XBException("field fuelConsumption not set");

            return this.fuelConsumption;
         }
         set
         {
            this.fuelConsumption = value;
            _set_fuelConsumption = true;
         }
      }

      public int FuelThreshold
      {
         get
         {
            if (!_set_fuelThreshold)
                throw new XBException("field fuelThreshold not set");

            return this.fuelThreshold;
         }
         set
         {
            this.fuelThreshold = value;
            _set_fuelThreshold = true;
         }
      }

      public ulong EmptyWeight
      {
         get
         {
            if (!_set_emptyWeight)
                throw new XBException("field emptyWeight not set");

            return this.emptyWeight;
         }
         set
         {
            this.emptyWeight = value;
            _set_emptyWeight = true;
         }
      }

      public ulong GrossWeight
      {
         get
         {
            if (!_set_grossWeight)
                throw new XBException("field grossWeight not set");

            return this.grossWeight;
         }
         set
         {
            this.grossWeight = value;
            _set_grossWeight = true;
         }
      }

      public decimal Width
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

      public decimal Length
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

      public decimal Height
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

      public decimal TurningRadius
      {
         get
         {
            if (!_set_turningRadius)
                throw new XBException("field turningRadius not set");

            return this.turningRadius;
         }
         set
         {
            this.turningRadius = value;
            _set_turningRadius = true;
         }
      }

      public double AxleLoad
      {
         get
         {
            if (!_set_axleLoad)
                throw new XBException("field axleLoad not set");

            return this.axleLoad;
         }
         set
         {
            this.axleLoad = value;
            _set_axleLoad = true;
         }
      }

      public uint VehicleMilitaryClass
      {
         get
         {
            if (!_set_vehicleMilitaryClass)
                throw new XBException("field vehicleMilitaryClass not set");

            return this.vehicleMilitaryClass;
         }
         set
         {
            this.vehicleMilitaryClass = value;
            _set_vehicleMilitaryClass = true;
         }
      }

      public int SupplyClass
      {
         get
         {
            if (!_set_supplyClass)
                throw new XBException("field supplyClass not set");

            return this.supplyClass;
         }
         set
         {
            this.supplyClass = value;
            _set_supplyClass = true;
         }
      }

      public int MobilityCategory
      {
         get
         {
            if (!_set_mobilityCategory)
                throw new XBException("field mobilityCategory not set");

            return this.mobilityCategory;
         }
         set
         {
            this.mobilityCategory = value;
            _set_mobilityCategory = true;
         }
      }

      public string LoadMilitaryClass
      {
         get
         {
            if (!_set_loadMilitaryClass)
                throw new XBException("field loadMilitaryClass not set");

            return this.loadMilitaryClass;
         }
         set
         {
            this.loadMilitaryClass = value;
            _set_loadMilitaryClass = true;
         }
      }

      public double TransportationWidth
      {
         get
         {
            if (!_set_transportationWidth)
                throw new XBException("field transportationWidth not set");

            return this.transportationWidth;
         }
         set
         {
            this.transportationWidth = value;
            _set_transportationWidth = true;
         }
      }

      public double TransportationLength
      {
         get
         {
            if (!_set_transportationLength)
                throw new XBException("field transportationLength not set");

            return this.transportationLength;
         }
         set
         {
            this.transportationLength = value;
            _set_transportationLength = true;
         }
      }

      public double TransportationHeight
      {
         get
         {
            if (!_set_transportationHeight)
                throw new XBException("field transportationHeight not set");

            return this.transportationHeight;
         }
         set
         {
            this.transportationHeight = value;
            _set_transportationHeight = true;
         }
      }

      public bool IsAirTransportable
      {
         get
         {
            if (!_set_isAirTransportable)
                throw new XBException("field isAirTransportable not set");

            return this.isAirTransportable;
         }
         set
         {
            this.isAirTransportable = value;
            _set_isAirTransportable = true;
         }
      }

      public bool IsSeaTransportable
      {
         get
         {
            if (!_set_isSeaTransportable)
                throw new XBException("field isSeaTransportable not set");

            return this.isSeaTransportable;
         }
         set
         {
            this.isSeaTransportable = value;
            _set_isSeaTransportable = true;
         }
      }

      public bool IsRailTransportable
      {
         get
         {
            if (!_set_isRailTransportable)
                throw new XBException("field isRailTransportable not set");

            return this.isRailTransportable;
         }
         set
         {
            this.isRailTransportable = value;
            _set_isRailTransportable = true;
         }
      }

      public bool IsRoadTransportable
      {
         get
         {
            if (!_set_isRoadTransportable)
                throw new XBException("field isRoadTransportable not set");

            return this.isRoadTransportable;
         }
         set
         {
            this.isRoadTransportable = value;
            _set_isRoadTransportable = true;
         }
      }

      public bool IsWaterwayTransportable
      {
         get
         {
            if (!_set_isWaterwayTransportable)
                throw new XBException("field isWaterwayTransportable not set");

            return this.isWaterwayTransportable;
         }
         set
         {
            this.isWaterwayTransportable = value;
            _set_isWaterwayTransportable = true;
         }
      }

      public string RangeMean
      {
         get
         {
            if (!_set_rangeMean)
                throw new XBException("field rangeMean not set");

            return this.rangeMean;
         }
         set
         {
            this.rangeMean = value;
            _set_rangeMean = true;
         }
      }

      public int RangeType
      {
         get
         {
            if (!_set_rangeType)
                throw new XBException("field rangeType not set");

            return this.rangeType;
         }
         set
         {
            this.rangeType = value;
            _set_rangeType = true;
         }
      }

      public decimal Range
      {
         get
         {
            if (!_set_range) throw new XBException("field range not set");

            return this.range;
         }
         set
         {
            this.range = value;
            _set_range = true;
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

               // nicCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
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

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  Text1To50Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "name");

               // shortName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.shortName =  ShortTextType.decode(text, xbContext);

                  _set_shortName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // englishName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.englishName =  Text1To50Type.decode(text, xbContext);

                  _set_englishName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // shortEnglishName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.shortEnglishName =  ShortTextType.decode(text, xbContext);

                  _set_shortEnglishName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nnoCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nnoCode =  NnoCodeType.decode(text, xbContext);

                  _set_nnoCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ricCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.ricCode =  RicCodeType.decode(text, xbContext);

                  _set_ricCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // category
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.category =  EquipmentCategoryCode.decode(text, xbContext);

                  _set_category = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isDangerous
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isDangerous = XBSimpleType.parseBoolean(text);

                  _set_isDangerous = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isStackable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isStackable = XBSimpleType.parseBoolean(text);

                  _set_isStackable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // type
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.type =  ShortTextType.decode(text, xbContext);

                  _set_type = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fuel
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[11], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.fuel =  FuelCategoryCode.decode(text, xbContext);

                  _set_fuel = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fuelConsumption
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[12], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.fuelConsumption =  Decimal0To9999999999999Digits3Type.decode(text, xbContext);

                  _set_fuelConsumption = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // fuelThreshold
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[13], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.fuelThreshold =  FuelThresholdCode.decode(text, xbContext);

                  _set_fuelThreshold = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // emptyWeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[14], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.emptyWeight =  Int0To2147483647Type.decode(text, xbContext);

                  _set_emptyWeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // grossWeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[15], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.grossWeight =  Int0To2147483647Type.decode(text, xbContext);

                  _set_grossWeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // width
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[16], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.width =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_width = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // length
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[17], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.length =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_length = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // height
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[18], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.height =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_height = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // turningRadius
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[19], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.turningRadius =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_turningRadius = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // axleLoad
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[20], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.axleLoad =  Decimal0To999999Type.decode(text, xbContext);

                  _set_axleLoad = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // vehicleMilitaryClass
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[21], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.vehicleMilitaryClass =  Int0To999999Type.decode(text, xbContext);

                  _set_vehicleMilitaryClass = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // supplyClass
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[22], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.supplyClass =  SupplyClassCode.decode(text, xbContext);

                  _set_supplyClass = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // mobilityCategory
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[23], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.mobilityCategory = Logistics.MobilityCategoryCode.decode(text, xbContext);

                  _set_mobilityCategory = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // loadMilitaryClass
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[24], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.loadMilitaryClass =  ShortTextType.decode(text, xbContext);

                  _set_loadMilitaryClass = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // transportationWidth
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[25], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.transportationWidth =  Decimal0To99999999Type.decode(text, xbContext);

                  _set_transportationWidth = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // transportationLength
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[26], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.transportationLength =  Decimal0To99999999Type.decode(text, xbContext);

                  _set_transportationLength = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // transportationHeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[27], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.transportationHeight =  Decimal0To99999999Type.decode(text, xbContext);

                  _set_transportationHeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isAirTransportable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[28], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isAirTransportable = XBSimpleType.parseBoolean(text);

                  _set_isAirTransportable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isSeaTransportable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[29], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isSeaTransportable = XBSimpleType.parseBoolean(text);

                  _set_isSeaTransportable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isRailTransportable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[30], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isRailTransportable = XBSimpleType.parseBoolean(text);

                  _set_isRailTransportable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isRoadTransportable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[31], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isRoadTransportable = XBSimpleType.parseBoolean(text);

                  _set_isRoadTransportable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isWaterwayTransportable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[32], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isWaterwayTransportable = XBSimpleType.parseBoolean(text);

                  _set_isWaterwayTransportable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // rangeMean
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[33], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.rangeMean =  ShortTextType.decode(text, xbContext);

                  _set_rangeMean = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // rangeType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[34], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.rangeType =  RangeTypeCode.decode(text, xbContext);

                  _set_rangeType = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // range
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[35], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.range =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_range = true;

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

         // nicCode
         encoder.encodeStartElement("nicCode", "", "");
         String text_3;
         text_3 =  NicCodeType.encode(this.nicCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // name
         encoder.encodeStartElement("name", "", "");
         text_3 =  Text1To50Type.encode(this.name, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // shortName
         if (_set_shortName)  {
            encoder.encodeStartElement("shortName", "", "");
            text_3 =  ShortTextType.encode(this.shortName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // englishName
         if (_set_englishName)  {
            encoder.encodeStartElement("englishName", "", "");
            text_3 =  Text1To50Type.encode(this.englishName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // shortEnglishName
         if (_set_shortEnglishName)  {
            encoder.encodeStartElement("shortEnglishName", "", "");
            text_3 =  ShortTextType.encode(this.shortEnglishName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // nnoCode
         if (_set_nnoCode)  {
            encoder.encodeStartElement("nnoCode", "", "");
            text_3 =  NnoCodeType.encode(this.nnoCode, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // ricCode
         if (_set_ricCode)  {
            encoder.encodeStartElement("ricCode", "", "");
            text_3 =  RicCodeType.encode(this.ricCode, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // category
         if (_set_category)  {
            encoder.encodeStartElement("category", "", "");
            text_3 =  EquipmentCategoryCode.encode(this.category, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isDangerous
         if (_set_isDangerous)  {
            encoder.encodeStartElement("isDangerous", "", "");
            text_3 = this.isDangerous.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isStackable
         if (_set_isStackable)  {
            encoder.encodeStartElement("isStackable", "", "");
            text_3 = this.isStackable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // type
         if (_set_type)  {
            encoder.encodeStartElement("type", "", "");
            text_3 =  ShortTextType.encode(this.type, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // fuel
         if (_set_fuel)  {
            encoder.encodeStartElement("fuel", "", "");
            text_3 =  FuelCategoryCode.encode(this.fuel, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // fuelConsumption
         if (_set_fuelConsumption)  {
            encoder.encodeStartElement("fuelConsumption", "", "");
            text_3 =  Decimal0To9999999999999Digits3Type.encode(this.fuelConsumption, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // fuelThreshold
         if (_set_fuelThreshold)  {
            encoder.encodeStartElement("fuelThreshold", "", "");
            text_3 =  FuelThresholdCode.encode(this.fuelThreshold, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // emptyWeight
         if (_set_emptyWeight)  {
            encoder.encodeStartElement("emptyWeight", "", "");
            text_3 =  Int0To2147483647Type.encode(this.emptyWeight, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // grossWeight
         if (_set_grossWeight)  {
            encoder.encodeStartElement("grossWeight", "", "");
            text_3 =  Int0To2147483647Type.encode(this.grossWeight, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // width
         if (_set_width)  {
            encoder.encodeStartElement("width", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.width, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // length
         if (_set_length)  {
            encoder.encodeStartElement("length", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.length, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // height
         if (_set_height)  {
            encoder.encodeStartElement("height", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.height, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // turningRadius
         if (_set_turningRadius)  {
            encoder.encodeStartElement("turningRadius", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.turningRadius, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // axleLoad
         if (_set_axleLoad)  {
            encoder.encodeStartElement("axleLoad", "", "");
            text_3 =  Decimal0To999999Type.encode(this.axleLoad, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // vehicleMilitaryClass
         if (_set_vehicleMilitaryClass)  {
            encoder.encodeStartElement("vehicleMilitaryClass", "", "");
            text_3 =  Int0To999999Type.encode(this.vehicleMilitaryClass, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // supplyClass
         if (_set_supplyClass)  {
            encoder.encodeStartElement("supplyClass", "", "");
            text_3 =  SupplyClassCode.encode(this.supplyClass, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // mobilityCategory
         if (_set_mobilityCategory)  {
            encoder.encodeStartElement("mobilityCategory", "", "");
            text_3 = Logistics.MobilityCategoryCode.encode(this.mobilityCategory, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // loadMilitaryClass
         if (_set_loadMilitaryClass)  {
            encoder.encodeStartElement("loadMilitaryClass", "", "");
            text_3 =  ShortTextType.encode(this.loadMilitaryClass, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // transportationWidth
         if (_set_transportationWidth)  {
            encoder.encodeStartElement("transportationWidth", "", "");
            text_3 =  Decimal0To99999999Type.encode(this.transportationWidth, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // transportationLength
         if (_set_transportationLength)  {
            encoder.encodeStartElement("transportationLength", "", "");
            text_3 =  Decimal0To99999999Type.encode(this.transportationLength, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // transportationHeight
         if (_set_transportationHeight)  {
            encoder.encodeStartElement("transportationHeight", "", "");
            text_3 =  Decimal0To99999999Type.encode(this.transportationHeight, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isAirTransportable
         if (_set_isAirTransportable)  {
            encoder.encodeStartElement("isAirTransportable", "", "");
            text_3 = this.isAirTransportable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isSeaTransportable
         if (_set_isSeaTransportable)  {
            encoder.encodeStartElement("isSeaTransportable", "", "");
            text_3 = this.isSeaTransportable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isRailTransportable
         if (_set_isRailTransportable)  {
            encoder.encodeStartElement("isRailTransportable", "", "");
            text_3 = this.isRailTransportable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isRoadTransportable
         if (_set_isRoadTransportable)  {
            encoder.encodeStartElement("isRoadTransportable", "", "");
            text_3 = this.isRoadTransportable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isWaterwayTransportable
         if (_set_isWaterwayTransportable)  {
            encoder.encodeStartElement("isWaterwayTransportable", "", "");
            text_3 = this.isWaterwayTransportable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // rangeMean
         if (_set_rangeMean)  {
            encoder.encodeStartElement("rangeMean", "", "");
            text_3 =  ShortTextType.encode(this.rangeMean, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // rangeType
         if (_set_rangeType)  {
            encoder.encodeStartElement("rangeType", "", "");
            text_3 =  RangeTypeCode.encode(this.rangeType, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // range
         if (_set_range)  {
            encoder.encodeStartElement("range", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.range, xbContext);
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

   public class NC1_ListeEquipementsRessources_ELEM_2_resources : 
      com.objsys.xbinder.runtime.XBComplexType
   {

      public static readonly  XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ler",
          "NC1_ListeEquipementsRessources_ELEM_2_resources");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","nicCode"),
         new XBQualifiedName("","name"),
         new XBQualifiedName("","shortName"),
         new XBQualifiedName("","englishName"),
         new XBQualifiedName("","shortEnglishName"),
         new XBQualifiedName("","nnoCode"),
         new XBQualifiedName("","ricCode"),
         new XBQualifiedName("","isDangerous"),
         new XBQualifiedName("","isStackable"),
         new XBQualifiedName("","pieceOfRessourceWeight"),
         new XBQualifiedName("","ressourceType"),
         new XBQualifiedName("","unitOfMeasurement"),
         new XBQualifiedName("","supplyClass"),
         new XBQualifiedName("","packagingWidth"),
         new XBQualifiedName("","packagingLength"),
         new XBQualifiedName("","packagingHeight")
      };
      static NC1_ListeEquipementsRessources_ELEM_2_resources() {
         XBUtil.license =  _NC1_ListeEquipementsRessources.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected string nicCode;
      protected string name;
      protected string shortName;
      protected bool _set_shortName = false;
      protected string englishName;
      protected bool _set_englishName = false;
      protected string shortEnglishName;
      protected bool _set_shortEnglishName = false;
      protected string nnoCode;
      protected bool _set_nnoCode = false;
      protected string ricCode;
      protected bool _set_ricCode = false;
      protected bool isDangerous;
      protected bool _set_isDangerous = false;
      protected bool isStackable;
      protected bool _set_isStackable = false;
      protected ulong pieceOfRessourceWeight;
      protected bool _set_pieceOfRessourceWeight = false;
      protected int ressourceType;
      protected int unitOfMeasurement;
      protected bool _set_unitOfMeasurement = false;
      protected int supplyClass;
      protected bool _set_supplyClass = false;
      protected decimal packagingWidth;
      protected bool _set_packagingWidth = false;
      protected decimal packagingLength;
      protected bool _set_packagingLength = false;
      protected decimal packagingHeight;
      protected bool _set_packagingHeight = false;

      //attribute methods

      //content methods

      public string NicCode
      {
         get { return this.nicCode; }
         set { this.nicCode = value; }
      }

      public string Name
      {
         get { return this.name; }
         set { this.name = value; }
      }

      public string ShortName
      {
         get
         {
            if (!_set_shortName)
                throw new XBException("field shortName not set");

            return this.shortName;
         }
         set
         {
            this.shortName = value;
            _set_shortName = true;
         }
      }

      public string EnglishName
      {
         get
         {
            if (!_set_englishName)
                throw new XBException("field englishName not set");

            return this.englishName;
         }
         set
         {
            this.englishName = value;
            _set_englishName = true;
         }
      }

      public string ShortEnglishName
      {
         get
         {
            if (!_set_shortEnglishName)
                throw new XBException("field shortEnglishName not set");

            return this.shortEnglishName;
         }
         set
         {
            this.shortEnglishName = value;
            _set_shortEnglishName = true;
         }
      }

      public string NnoCode
      {
         get
         {
            if (!_set_nnoCode) throw new XBException("field nnoCode not set");

            return this.nnoCode;
         }
         set
         {
            this.nnoCode = value;
            _set_nnoCode = true;
         }
      }

      public string RicCode
      {
         get
         {
            if (!_set_ricCode) throw new XBException("field ricCode not set");

            return this.ricCode;
         }
         set
         {
            this.ricCode = value;
            _set_ricCode = true;
         }
      }

      public bool IsDangerous
      {
         get
         {
            if (!_set_isDangerous)
                throw new XBException("field isDangerous not set");

            return this.isDangerous;
         }
         set
         {
            this.isDangerous = value;
            _set_isDangerous = true;
         }
      }

      public bool IsStackable
      {
         get
         {
            if (!_set_isStackable)
                throw new XBException("field isStackable not set");

            return this.isStackable;
         }
         set
         {
            this.isStackable = value;
            _set_isStackable = true;
         }
      }

      public ulong PieceOfRessourceWeight
      {
         get
         {
            if (!_set_pieceOfRessourceWeight)
                throw new XBException("field pieceOfRessourceWeight not set");

            return this.pieceOfRessourceWeight;
         }
         set
         {
            this.pieceOfRessourceWeight = value;
            _set_pieceOfRessourceWeight = true;
         }
      }

      public int RessourceType
      {
         get { return this.ressourceType; }
         set { this.ressourceType = value; }
      }

      public int UnitOfMeasurement
      {
         get
         {
            if (!_set_unitOfMeasurement)
                throw new XBException("field unitOfMeasurement not set");

            return this.unitOfMeasurement;
         }
         set
         {
            this.unitOfMeasurement = value;
            _set_unitOfMeasurement = true;
         }
      }

      public int SupplyClass
      {
         get
         {
            if (!_set_supplyClass)
                throw new XBException("field supplyClass not set");

            return this.supplyClass;
         }
         set
         {
            this.supplyClass = value;
            _set_supplyClass = true;
         }
      }

      public decimal PackagingWidth
      {
         get
         {
            if (!_set_packagingWidth)
                throw new XBException("field packagingWidth not set");

            return this.packagingWidth;
         }
         set
         {
            this.packagingWidth = value;
            _set_packagingWidth = true;
         }
      }

      public decimal PackagingLength
      {
         get
         {
            if (!_set_packagingLength)
                throw new XBException("field packagingLength not set");

            return this.packagingLength;
         }
         set
         {
            this.packagingLength = value;
            _set_packagingLength = true;
         }
      }

      public decimal PackagingHeight
      {
         get
         {
            if (!_set_packagingHeight)
                throw new XBException("field packagingHeight not set");

            return this.packagingHeight;
         }
         set
         {
            this.packagingHeight = value;
            _set_packagingHeight = true;
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

               // nicCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
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

               // name
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.name =  Text1To50Type.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "name");

               // shortName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.shortName =  ShortTextType.decode(text, xbContext);

                  _set_shortName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // englishName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[3], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.englishName =  Text1To50Type.decode(text, xbContext);

                  _set_englishName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // shortEnglishName
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[4], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.shortEnglishName =  ShortTextType.decode(text, xbContext);

                  _set_shortEnglishName = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // nnoCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[5], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.nnoCode =  NnoCodeType.decode(text, xbContext);

                  _set_nnoCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ricCode
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[6], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  this.ricCode =  RicCodeType.decode(text, xbContext);

                  _set_ricCode = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isDangerous
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[7], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isDangerous = XBSimpleType.parseBoolean(text);

                  _set_isDangerous = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // isStackable
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[8], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.isStackable = XBSimpleType.parseBoolean(text);

                  _set_isStackable = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // pieceOfRessourceWeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[9], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.pieceOfRessourceWeight =  Int0To2147483647Type.decode(text, xbContext);

                  _set_pieceOfRessourceWeight = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // ressourceType
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[10], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.ressourceType =  RessourceTypeCode.decode(text, xbContext);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }
               else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
               else throw new XBOccurrencesException(0, "ressourceType");

               // unitOfMeasurement
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[11], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.unitOfMeasurement =  UnitOfMeasurementCode.decode(text, xbContext);

                  _set_unitOfMeasurement = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // supplyClass
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[12], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.supplyClass =  SupplyClassCode.decode(text, xbContext);

                  _set_supplyClass = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // packagingWidth
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[13], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.packagingWidth =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_packagingWidth = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // packagingLength
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[14], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.packagingLength =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_packagingLength = true;

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
               }

               // packagingHeight
               if( moreContent_4 && XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[15], elemNs, elemLocalName) )
               {
                  xbContext.decodeSchemaLocationAttrs(reader);
                  String text = reader.ReadString();
                  text = XBSimpleType.whitespaceCollapse(text);
                  this.packagingHeight =  Decimal0To99999999Digits3Type.decode(text, xbContext);

                  _set_packagingHeight = true;

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

         // nicCode
         encoder.encodeStartElement("nicCode", "", "");
         String text_3;
         text_3 =  NicCodeType.encode(this.nicCode, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // name
         encoder.encodeStartElement("name", "", "");
         text_3 =  Text1To50Type.encode(this.name, xbContext);
         encoder.encodeChars(text_3);
         encoder.encodeEndElement();

         // shortName
         if (_set_shortName)  {
            encoder.encodeStartElement("shortName", "", "");
            text_3 =  ShortTextType.encode(this.shortName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // englishName
         if (_set_englishName)  {
            encoder.encodeStartElement("englishName", "", "");
            text_3 =  Text1To50Type.encode(this.englishName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // shortEnglishName
         if (_set_shortEnglishName)  {
            encoder.encodeStartElement("shortEnglishName", "", "");
            text_3 =  ShortTextType.encode(this.shortEnglishName, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // nnoCode
         if (_set_nnoCode)  {
            encoder.encodeStartElement("nnoCode", "", "");
            text_3 =  NnoCodeType.encode(this.nnoCode, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // ricCode
         if (_set_ricCode)  {
            encoder.encodeStartElement("ricCode", "", "");
            text_3 =  RicCodeType.encode(this.ricCode, xbContext);
            encoder.encodeChars(text_3);
            encoder.encodeEndElement();
         }

         // isDangerous
         if (_set_isDangerous)  {
            encoder.encodeStartElement("isDangerous", "", "");
            text_3 = this.isDangerous.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // isStackable
         if (_set_isStackable)  {
            encoder.encodeStartElement("isStackable", "", "");
            text_3 = this.isStackable.ToString().ToLower();
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // pieceOfRessourceWeight
         if (_set_pieceOfRessourceWeight)  {
            encoder.encodeStartElement("pieceOfRessourceWeight", "", "");
            text_3 =  Int0To2147483647Type.encode(this.pieceOfRessourceWeight, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // ressourceType
         encoder.encodeStartElement("ressourceType", "", "");
         text_3 =  RessourceTypeCode.encode(this.ressourceType, xbContext);
         encoder.encodeCharsNoEscaping(text_3);
         encoder.encodeEndElement();

         // unitOfMeasurement
         if (_set_unitOfMeasurement)  {
            encoder.encodeStartElement("unitOfMeasurement", "", "");
            text_3 =  UnitOfMeasurementCode.encode(this.unitOfMeasurement, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // supplyClass
         if (_set_supplyClass)  {
            encoder.encodeStartElement("supplyClass", "", "");
            text_3 =  SupplyClassCode.encode(this.supplyClass, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // packagingWidth
         if (_set_packagingWidth)  {
            encoder.encodeStartElement("packagingWidth", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.packagingWidth, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // packagingLength
         if (_set_packagingLength)  {
            encoder.encodeStartElement("packagingLength", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.packagingLength, xbContext);
            encoder.encodeCharsNoEscaping(text_3);
            encoder.encodeEndElement();
         }

         // packagingHeight
         if (_set_packagingHeight)  {
            encoder.encodeStartElement("packagingHeight", "", "");
            text_3 =  Decimal0To99999999Digits3Type.encode(this.packagingHeight, xbContext);
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

   public class NC1_ListeEquipementsRessources_ELEM :  BaseMessageType
   {

      public static readonly new XBQualifiedName XSD_TYPE = new XBQualifiedName("urn:fra:nc1:message:ler",
          "NC1_ListeEquipementsRessources_ELEM");

      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static new Object[] particleInfo = {
         new XBQualifiedName("","equipments"),
         new XBQualifiedName("","resources"),
         new XBQualifiedName("","comment")
      };
      static NC1_ListeEquipementsRessources_ELEM() {
         XBUtil.license =  _NC1_ListeEquipementsRessources.license;
      }

      //attribute fields

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.

      //content fields
      protected System.Collections.Generic.IList< NC1_ListeEquipementsRessources_ELEM_2_equipments> equipments;
         
      protected System.Collections.Generic.IList< NC1_ListeEquipementsRessources_ELEM_2_resources> resources;
         
      protected  CommentSectionType comment;   //optional

      //attribute methods

      //content methods

      public System.Collections.Generic.IList< NC1_ListeEquipementsRessources_ELEM_2_equipments> Equipments
      {
         get
         {
            if (this.equipments == null) {
               this.equipments = 
                  new List< NC1_ListeEquipementsRessources_ELEM_2_equipments>()
                  ;
            }
            return this.equipments;
         }
      }

      public System.Collections.Generic.IList< NC1_ListeEquipementsRessources_ELEM_2_resources> Resources
      {
         get
         {
            if (this.resources == null) {
               this.resources = 
                  new List< NC1_ListeEquipementsRessources_ELEM_2_resources>()
                  ;
            }
            return this.resources;
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

               // equipments
               this.equipments = 
                  new List< NC1_ListeEquipementsRessources_ELEM_2_equipments>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
               {
                   NC1_ListeEquipementsRessources_ELEM_2_equipments _tmp_equipments;
                  _tmp_equipments = new  NC1_ListeEquipementsRessources_ELEM_2_equipments();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_equipments.decode(reader, xbContext, false, false);
                  this.equipments.Add(_tmp_equipments);

                  moreContent_4 = 
                     XMLStreamHelper.moveToContentElement(reader);
                  if (moreContent_4) {
                     elemLocalName = reader.LocalName;
                     elemNs = reader.NamespaceURI;
                  }
                  else break;
               }

               // resources
               this.resources = 
                  new List< NC1_ListeEquipementsRessources_ELEM_2_resources>()
                  ;
               if (moreContent_4) while( XBQualifiedName.namesMatch(
                  (XBQualifiedName)particleInfo[1], elemNs, elemLocalName) )
               {
                   NC1_ListeEquipementsRessources_ELEM_2_resources _tmp_resources;
                  _tmp_resources = new  NC1_ListeEquipementsRessources_ELEM_2_resources();
                  xbContext.decodeSchemaLocationAttrs(reader);
                  _tmp_resources.decode(reader, xbContext, false, false);
                  this.resources.Add(_tmp_resources);

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
                  (XBQualifiedName)particleInfo[2], elemNs, elemLocalName) )
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

         // equipments
         if ( this.equipments != null ){
            foreach ( NC1_ListeEquipementsRessources_ELEM_2_equipments _tmp_equipments in this.equipments)
            {
               encoder.encodeStartElement("equipments", "", "");
               _tmp_equipments.encode(encoder, xbContext, null, false);
               encoder.encodeEndElement();
            }
         }

         // resources
         if ( this.resources != null ){
            foreach ( NC1_ListeEquipementsRessources_ELEM_2_resources _tmp_resources in this.resources)
            {
               encoder.encodeStartElement("resources", "", "");
               _tmp_resources.encode(encoder, xbContext, null, false);
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

   public class NC1_ListeEquipementsRessources_CC : XBDocumentCodec
   {
      public com.objsys.xbinder.runtime.XBContext _xbContext = new com.objsys.xbinder.runtime.XBContext();


      //particleInfo[i] provides information for the ith particle.
         //For elements, it is a XBQualifiedName, identifying the expected element.
      //For element wildcards, it is a String[], listing the allowed namespaces
      protected static  Object[] particleInfo = {
         new XBQualifiedName("urn:fra:nc1:message:ler","NC1_ListeEquipementsRessources")
      };
      static NC1_ListeEquipementsRessources_CC() {
         XBUtil.license =  _NC1_ListeEquipementsRessources.license;
      }

      //Empty element indicator.  This variable may stay false
      //even if an element is empty because emptiness is
      //sometimes detected by another means.
      protected bool elementEmpty = false;

      //content fields
      protected  NC1_ListeEquipementsRessources_ELEM nC1_ListeEquipementsRessources;
         

      //content methods

      public  NC1_ListeEquipementsRessources_ELEM NC1_ListeEquipementsRessources
      {
         get
         {
            if (this.nC1_ListeEquipementsRessources == null)
                throw new XBException("field nC1_ListeEquipementsRessources not set");

            return this.nC1_ListeEquipementsRessources;
         }
         set
         {
            this.nC1_ListeEquipementsRessources = value;
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
         //   encoder.setNamespaces(_NC1_ListeEquipementsRessources.namespaceContext);

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

            // nC1_ListeEquipementsRessources
            bool moreContent_4 = true;
            if( moreContent_4 && XBQualifiedName.namesMatch(
               (XBQualifiedName)particleInfo[0], elemNs, elemLocalName) )
            {
               this.nC1_ListeEquipementsRessources = new  NC1_ListeEquipementsRessources_ELEM();
               xbContext.decodeSchemaLocationAttrs(reader);
               this.nC1_ListeEquipementsRessources.decode(reader, xbContext, false, false);

               moreContent_4 = XMLStreamHelper.moveToContentElement(reader);
            }
            else if (moreContent_4) throw new XBUnexpectedElementException(elemNs, elemLocalName);
            else throw new XBOccurrencesException(0, "nC1_ListeEquipementsRessources");

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

         // nC1_ListeEquipementsRessources
         if (this.nC1_ListeEquipementsRessources == null)
             throw new XBException("field nC1_ListeEquipementsRessources not set");

         encoder.encodeStartElement("NC1_ListeEquipementsRessources",  _NC1_ListeEquipementsRessources.NS_URI,  _NC1_ListeEquipementsRessources.NS_PREFIX);
         xbContext.encodeSchemaLocationAttrs(encoder);
         this.nC1_ListeEquipementsRessources.encode(encoder, xbContext, null, 
            false);
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

   public class _NC1_ListeEquipementsRessources {

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
      public static readonly String NS_URI = "urn:fra:nc1:message:ler";
      public static readonly String NS_PREFIX = "nc1ler";

      /* Runtime License expiration: Sun Jul 17 06:45:01 2022
 */
      public static readonly byte[] license = {
         0x54, (byte)0xa9, 0x52, (byte)0xa5, 0x62, (byte)0xd3, (byte)0x93, 
            (byte)0xcd} ;

      public static XBDoubleFormat defaultDoubleFmt = new XBDoubleFormat();

      public _NC1_ListeEquipementsRessources() {
      }
      static _NC1_ListeEquipementsRessources() {
         XBUtil.license = _NC1_ListeEquipementsRessources.license;
      }
   }
}
