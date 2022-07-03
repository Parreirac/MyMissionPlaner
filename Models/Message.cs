
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

using Esri.ArcGISRuntime.Geometry;
using System;
using System.Collections.Generic;


namespace MilitaryPlanner.Helpers
{
    /// <summary>
    /// Represents a Graphic feature rendered on the map with military symbology. Initialement dans Esri.ArcGISRuntime.Symbology.Specialized.Message
    /// 
    /// Each message, represented by an instance of the class, comprises a <see cref="T:System.Collections.Generic.Dictionary`2"/> of 
    /// <see cref = "T:System.String" /> key value pairs.These specify a number of important characteristics of the message:
    /// Id ("_id"): Any string value.</item>
    /// Type("_type") : "position_report", "spot_report", or "chemlight".</item>
    /// Action("_action") : "update", "select", "un-select" or "remove".</item>
    /// Control points("_control_points"): A semi-colon-separated string of comma-separated coordinate pairs e.g. 53.95,-23.67;53.93,-23.55;53.91,-23.45.</item>
    /// Symbol ID Code("sic") : A string value representing the ID code of the symbol in the dictionary e.g."GHGPGPWA------X".</item>
    /// Spatial Reference Well Known ID("_wkid") : A string representing the WKID code for a spatial reference e.g. for WGS1984 specify "4326".</item>
    /// Spatial Reference Well Known Text ("_wkt"): A string representing the Well Known Test string of the spatial reference.</item>
    /// 
    /// The key value pairs can be explicitly constructed (string keywords for the Key component of the Key Value Pair shown in brackets above). 
    /// Or alternatively the<see cref="T:Esri.ArcGISRuntime.Symbology.Specialized.MilitaryMessage"/> class that facilitates the construction of Message objects.

    ///  var messageProperties = new Dictionary<string, string>();
    ///  messageProperties.Add(@"_type", @"position_report");
    ///  messageProperties.Add(@"_action", @"update");
    ///  messageProperties.Add(@"_id", pointElement.Id);
    ///  messageProperties.Add(@"_control_points", string.Format(CultureInfo.InvariantCulture, @"{0},{1}", pointElement.X, pointElement.Y));
    ///  messageProperties.Add(@"_wkid", @"4326");
    ///  messageProperties.Add(@"sic", pointElement.SymbolCode);
    ///  messageProperties.Add(@"uniquedesignation", pointElement.Label);
    /// 
    /// </summary>

    // classe de base pour un message militaire.
    // on va avoir des symboles, et les attributs qui vont avec  (position typiquement)
    // les actions (initialement ici) vont basculer dans la partie graphique (messageLayer)
    // SimpleMessage ne stocke qu'un seul objet graphique.
    // les données de SymbolProperties sont dans SymbolProperties
    // l'id et la géométrie sont dans id et geometry, 
    // le reste des données sont dans le dictionnaire.
    public class SimpleMessage : Dictionary<string, string>
    {

        // si pas utilisé a basculer plus bas !
        public enum MessageType { position_report, spot_report, chemlight };
        public enum Type { Mil2525c, APP6B, APP6D };  


        public Esri.ArcGISRuntime.Mapping.Layer Layer { get;private set; }


        public SimpleMessage(Esri.ArcGISRuntime.Mapping.Layer layer) { Layer = layer; IsTemporary = true;Id = Layer.Id; }


        public SimpleMessage()
        { this.Id = "No Id"; symbolProperties = new SymbolProperties(); SymbolGeometry = null; IsTemporary = false; }
        public SimpleMessage(string id, bool isTemporary = false)
        { IsModified = false; IsTemporary = isTemporary; this.Id = id; symbolProperties = new SymbolProperties(); SymbolGeometry = null; }

        public bool IsTemporary { get; private set; } // peut etre ne servira pas a la fin
        // <summary>
        // indicates a change in content eg position 
        // </summary>
        public bool IsModified { get; set; }

        public SymbolProperties symbolProperties { get; set; }

        public string Id { get; private set; }
        public Geometry SymbolGeometry 
        { 
            get; 
            set; 
        }


        // <summary>
        // get SpatialReferences or default value (WGS84)
        // </summary>
        public string WkText
        {
            get { return ContainsKey(WkidPropertyName) ? this[WkidPropertyName] : "4326";}
        }

        public static readonly string ControlPointsPropertyName = "_Control_Points";//"ControlPoints";
        public static readonly string ActionPropertyName = "_Action"; //"Action";
        public static readonly string TypePropertyName = "Type";
        public static readonly string WkidPropertyName = "_wkid";//"Wkid";
        public static readonly string SicCodePropertyName = "sic";// "SicCode";  // TODO PRA Protected ?
        public static readonly string UniqueDesignationPropertyName = "UniqueDesignation";

    }

    // Message peut aussi servir de vecteur d'info
    // dans ce cas, il ne contient qu'id et positions.
    public class Message : SimpleMessage
    {
        public static readonly String IdPropertyName = "Id";
        
        public new SymbolProperties symbolProperties
        {  // todo pra ?  on pourrait mettre le premier de la liste.
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        readonly List<SimpleMessage> _simpleMessages = new List<SimpleMessage>();

        public List<SimpleMessage> SubMessages { get { return _simpleMessages;}  }

        public void AddSimpleMessage(SimpleMessage msg) { _simpleMessages.Add(msg); }
        
        public void RemoveSimpleMessage(SimpleMessage msg) { _simpleMessages.Remove(msg); }

        public Message(String id, bool temporary = false) : base(id, temporary)    { }

        public Message() : base("No id")    { }

        public Message(String id, MessageType positionReport) : base(id)
        {
            this[TypePropertyName] = positionReport.ToString();  //   throw new NotImplementedException();
        }

    }

}