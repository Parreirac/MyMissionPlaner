// Copyright 2015 Esri 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//using Esri.ArcGISRuntime.Symbology;//.Specialized;
using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Geometry;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MilitaryPlanner.Helpers
{

    // Classe proposée par ESRI pour gerer un calque avec phasage.

    public class TimeAwareMilitaryMessage : SimpleMessage//, IXmlSerializable
    {
        public TimeAwareMilitaryMessage():base("")
        {
            PostInit();
        }
        public TimeAwareMilitaryMessage(string id ) : base(id)
        {
            PostInit();
        }
        public TimeAwareMilitaryMessage(TimeExtent timeExtent) : base("")
        {
            VisibleTimeExtent = new TimeExtent(timeExtent.StartTime, timeExtent.EndTime); // TODO PRA vérifier cela !
            PostInit();
        }

        public TimeExtent VisibleTimeExtent
        {
            get;
            set;
        }

      //  public Geometry SymbolGeometry { get; set; }

        private void PostInit() // init des param non stockés
        {
            try
            {
             //   this.isTemporary = false;
                if (VisibleTimeExtent == null)
                    VisibleTimeExtent = new TimeExtent(DateTimeOffset.MinValue, DateTimeOffset.MaxValue);

                var resultWkid = this.WkText;// this[Message.WkidPropertyName];//getProperty();
                SpatialReference sr = SpatialReference.Create(int.Parse(resultWkid)); //SpatialReference(result);

                string resultControlPoints = this[Message.ControlPointsPropertyName];// getProperty();
                var resultSplit = resultControlPoints.Split(','); // TODO PRA passer par la culture

                string newValue = null;
                if (resultSplit.Length == 2) // utiliser un cif todo pra ?
                {
                    newValue = resultSplit[0] + ";" + resultSplit[1];
                }
                if (resultSplit.Length == 3)
                {
                    newValue = resultSplit[0] + ";" + resultSplit[1] + "," + resultSplit[2];
                }
                if (resultSplit.Length == 4)
                {
                    newValue = resultSplit[0] + "," + resultSplit[1] + ";" + resultSplit[2] + "," + resultSplit[3];
                }
                this[Message.ControlPointsPropertyName] = newValue;

                // TODO PRA quid si plusieurs points. en cible mettre la vraie position


                var pos = this[Message.ControlPointsPropertyName];//.getProperty();
                string[] pp = pos.Split(";");
                CultureInfo cif = new CultureInfo("en-US");
                MapPoint p = new MapPoint(Convert.ToDouble(pp[0], cif), Convert.ToDouble(pp[1], cif), sr);

          //      MapPoint p = new MapPoint(0, 0, sr);
                Geometry geo = p;

     //           var resultSicCode = this[Message.SicCodePropertyName];// getProperty(Message.SicCodePropertyName);

                char[] tab = resultControlPoints.ToCharArray();

                if (tab[0] == 'G' && tab[5] == 'L')
                {
                    List<MapPoint> tabMapPoints = new List<MapPoint> { p, p, p };
                    geo = new Polyline(tabMapPoints, sr);
                }
                else if (tab[0] == 'G' && tab[5] == 'A')
                {
                    List<MapPoint> tabMapPoints = new List<MapPoint> { p, p, p };
                    geo = new Polygon(tabMapPoints, sr);
                }
                SymbolGeometry = geo;

            }
            catch
            { }

        }

        //    public Dictionary<string, string> PhaseControlPointsDictionary = new Dictionary<string, string>();
        public List< string> PhaseControlPointsDictionary = new List<string>(); // TODO pra renommer !
        public void StoreControlPoints(List<MapPoint> points) 
        {
            CultureInfo cif = new CultureInfo("en-US");
            foreach (MapPoint point in points)
            { 
            string newValue = point.X.ToString(cif) + ";" + point.Y.ToString(cif);
                PhaseControlPointsDictionary.Add(newValue);
            }
            // TOD PRA on doit changer la geometrie !

         //   trueMessage.setProperty(Message.ControlPointsPropertyName, newValue);
        }
        /*      public void StoreControlPoints(string phaseID,  Message msg)//MilitaryMessage)
              {
                  this[Message.ControlPointsPropertyName] = msg[Message.ControlPointsPropertyName];

                  if (PhaseControlPointsDictionary.ContainsKey(phaseID))
                  {
                      PhaseControlPointsDictionary[phaseID] = msg[Message.ControlPointsPropertyName];
                  }
                  else
                  {
                      PhaseControlPointsDictionary.Add(phaseID, msg[Message.ControlPointsPropertyName]);
                  }
              }*/
        /*
              public XmlSchema GetSchema()
              {
                  return null;
              }
        */
        /*    public void ReadXml(string toRead) // ajout pra 
           {
               byte[] bytes = Encoding.Unicode.GetBytes(toRead); ;
               MemoryStream ss = new MemoryStream(bytes);
               XmlReader reader = XmlReader.Create(ss);
               this.ReadXml(reader);
           } */



        public static TimeAwareMilitaryMessage  MonReader(XElement timeAwareMilitaryMessageElement)
           {
               //   XDocument file = XDocument.Load(filename);
           //    XName missionPhase = XName.Get("MissionPhase");
        //       XName name = XName.Get("Name");
               XName id = XName.Get("ID");
              // XName phaseList = XName.Get("PhaseList");
               XName visibleTimeExtent = XName.Get("VisibleTimeExtent");
               XName start = XName.Get("Start");
               XName end = XName.Get("End");
               //     XName persistentMessages = XName.Get("PersistentMessages");
               //     XName persistentMessage = XName.Get("PersistentMessage");
               XName propertyItems = XName.Get("PropertyItems");
               XName propertyItem = XName.Get("PropertyItem");
               XName key = XName.Get("Key");
               XName value = XName.Get("Value");
               //        var rootElem = file.Root;//.Elements(name);// file.Root.Attribute(name);//.Value; 



               var elemId = timeAwareMilitaryMessageElement.Element(id);
               string stringId = "no id";
               if (elemId != null)
                   stringId = elemId.Value;

               TimeAwareMilitaryMessage msg = new TimeAwareMilitaryMessage(stringId);

                XElement vte = timeAwareMilitaryMessageElement.Element(visibleTimeExtent);
               if (vte != null)
                   msg.VisibleTimeExtent = new TimeExtent((DateTimeOffset)vte.Element(start), (DateTimeOffset)vte.Element(end));

               var items = timeAwareMilitaryMessageElement.Element(propertyItems);

               if (items != null)
               {
                   foreach (var item in items.Elements(propertyItem))
                {
                    if (item.Element(key).Value == Message.SicCodePropertyName)
                    {
                        msg.symbolProperties.SymbolID = item.Element(value).Value;
                    }
                    else
                       msg.Add(item.Element(key).Value, item.Element(value).Value);
                }
               }
               msg.PostInit();
               return msg;
           }



           public void ReadXml(XmlReader reader)
           {

               reader.Read(); // move to inner element, PersistenMessage
               XmlSerializer serializer = new XmlSerializer(typeof(PersistentMessage));
               var temp = serializer.Deserialize(reader) as PersistentMessage;
               if (temp != null)
               {
                   // TODO PRA          VisibleTimeExtent = temp.VisibleTimeExtent;

                   foreach (var pi in temp.PropertyItems)
                   {
                       if (ContainsKey(pi.Key))
                       {
                           this[pi.Key] = pi.Value;
                       }
                       else
                       {
                           Add(pi.Key, pi.Value);
                       }
                   }

                   foreach (var pc in temp.PhaseControlPoints)
                   {
             //          PhaseControlPointsDictionary.Add(pc.Key, pc.Value); //TODO PRA 
                   }
               }

               reader.Read();

               PostInit();
           }

           public void WriteXml(XmlWriter writer)
           {
               var pm = new PersistentMessage
               {
                   ID = Id,
                   //  VisibleTimeExtent = VisibleTimeExtent,
                   VisibleTimeExtent = { new PropertyItem { Key = "Start", Value = this.VisibleTimeExtent.StartTime.ToString() } ,
                   new PropertyItem { Key = "End", Value = this.VisibleTimeExtent.EndTime.ToString() }
                   },
                   PropertyItems = this.Select(kvp => new PropertyItem { Key = kvp.Key, Value = kvp.Value }).ToList(),
              //     PhaseControlPoints = PhaseControlPointsDictionary
                     //  PhaseControlPointsDictionary.Select(kvp => new PropertyItem { Key = kvp.Key, Value = kvp.Value })
                       //    .ToList()
               };

               // get properties in property list


               XmlSerializer serializer = new XmlSerializer(typeof(PersistentMessage));
               serializer.Serialize(writer, pm);
           }
       }

       public class CustomItem
       {
           public string Key { get; set; }
           public string Value { get; set; }
       }

       public class PropertyItem
       {
           public string Key { get; set; }
           public string Value { get; set; }
       }

       public class PersistentMessage
       {
           public string ID // todo pra déjà présent dans le dico
           {
               get;
               set;
           }
           public List<PropertyItem> VisibleTimeExtent  // modif pra stocké sous forme de dico  // TODO PRA a tester ?
           {
               get;
               set;
           }

           /*    public TimeExtent VisibleTimeExtent
                {
                    get;
                    set;
                }*/
        public List<PropertyItem> PropertyItems
        {
            get;
            set;
        }

        public List<PropertyItem> PhaseControlPoints
        {
            get;
            set;
        }

    }

}
