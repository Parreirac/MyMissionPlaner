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

//using Esri.ArcGISRuntime.Controls;
//using Esri.ArcGISRuntime.Layers;
//using Esri.ArcGISRuntime.Symbology.Specialized;
//using Esri.ArcGISRuntime.Tasks.Imagery;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using MilitaryPlanner.ViewModels;
using System;
using System.Collections.Generic;
//using MapView = Esri.ArcGISRuntime.Controls.MapView;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace MilitaryPlanner.Helpers
{


    // A message layer displays military symbols using graphics that conform to the MILSTD-
    // 2525C or APP6B standards by having a message using a Symbol ID Code(SIC)
    // sent to this layer type.
    // herite de GroupLayer : A group layer is a mechanism to logically group your layers. For example, you can
    // group all of our operational layers(FeatureLayers) into a group so that when they
    // show up in a legend they are under one branch(folder) in the legend.The group
    // layers don't store data themselves, they just contain other kinds of layers. You can
    // create as many group layers as you need.
    public class MessageLayer //: FeatureLayer//Layer// LayerCollection  //Layer // modif pra 
    {

        //    public new string Id { get; set; }
        //  public class  : Layer,
        //  IPopupSource, ITimeAware, IFloorAware
        //  readonly Type _type;

        public enum MessageAction { none, create, update, select, un_select, remove };   //ToString() pour avoir le texte et non la valeur

        public MessageLayer(
       //     Type type,
       string Id = "", GraphicsOverlay tacticalMessageOverlay = null) // TODO PRA et si l'overlay a deja un autre id ?
        {
            //   graphicsOverlay = tacticalMessageOverlay != null ? tacticalMessageOverlay : new GraphicsOverlay();
            graphicsOverlay = tacticalMessageOverlay ?? new GraphicsOverlay();
            graphicsOverlay.Id = Id;
            _messages = new List<SimpleMessage>();
        }


        // TODO PRA GraphicsOverlay Constructor donne un exemple de conversion xml graphique/
        public string Id { get { return graphicsOverlay.Id; } }
        public GraphicsOverlay graphicsOverlay { get; set; }


        ///    <member name = "M:Esri.ArcGISRuntime.Symbology.Specialized.MessageLayer.GetMessage(System.String)" >
        ///    < summary >
        ///Returns the<see cref="T:Esri.ArcGISRuntime.Layers.Graphic"/> with the specified ID.
        ///    </summary>
        ///    <param name = "messageId" > A < see cref="T:System.String"/> representing the identifier of the Message to retrieve.</param>
        ///    <returns>A<see cref="T:Esri.ArcGISRuntime.Layers.Graphic"/> instance.</returns>
        ///    </member>


        private readonly List<SimpleMessage> _messages;

        public void AddMessage(SimpleMessage message)
        {
            _messages.Add(message);
        }

        public IEnumerable<SimpleMessage> GetMessage(String id)
        {
            var machin = _messages.Where(m => m.Id == id);
            return machin.AsEnumerable();
        }


        public bool UpdateMessage(SimpleMessage mes, MapPoint point) // Ajout PRA
        {
            SimpleMessage trueMessage = GetMessage(mes.Id).FirstOrDefault();// TODO PRA si plusieurs ?
                                                                            // var result = trueMessage.getProperty(Message.WkidPropertyName);
                                                                            // SpatialReference sr = SpatialReference.Create(int.Parse(result)); //SpatialReference(result);          
            CultureInfo cif = new CultureInfo("en-US");
            string newValue = point.X.ToString(cif) + ";" + point.Y.ToString(cif);
            trueMessage.Add/*.setProperty*/(Message.ControlPointsPropertyName, newValue);
            return true;
        }


        public bool UpdateMilitaryMessage(Message mes, List<MapPoint> points, string phaseID) // Ajout PRA
        {
            TimeAwareMilitaryMessage trueMessage = GetMessage(mes.Id).FirstOrDefault() as TimeAwareMilitaryMessage;// TODO PRA si plusieurs ?
                                                                                                                   //          string currentPhaseId = ""; //_mission.PhaseList[CurrentPhaseIndex].ID TODO PRA
            trueMessage.StoreControlPoints(points);// phaseID, mes); // TODO PRA : gestion du temps
                                                   //      UpdateMilitaryMessageControlPoints(msg); // TODO PRA
            return true;


        }

        public bool ProcessMessage(SimpleMessage mes, MessageAction action = MessageAction.none)
        {

            if (mes.IsTemporary && mes.Layer != null)
            {
                // Add the feature layer to the map

                /*          graphicsOverlay.
                          this.Ma
                          MyMapView.Map.OperationalLayers.Add(newFeatureLayer);

                          // Zoom the map to the extent of the shapefile
                          await MyMapView.SetViewpointGeometryAsync(newFeatureLayer.FullExtent, 50);

          */

                return false;
            }



            //  var msg = new Message(message.Id, Message.MessageType.position_report /* MilitaryMessageType.PositionReport*/,
            //      isSelected ? Message.MessageAction.select /*MilitaryMessageAction.Select */ : Message.MessageAction.un_select /*MilitaryMessageAction.UnSelect*/);
            if (mes.Id == "0:0:240")
                mes.Id.IsNormalized();

            var trueMessage = GetMessage(mes.Id);
            var graphics = this.graphicsOverlay.Graphics.Where(g => g.Attributes.ContainsKey(Message.IdPropertyName) && mes.Id == g.Attributes[Message.IdPropertyName] as string);

            int n = graphics.Count();  // TODO PRA temp a virer 
                                       //     string action = mes.ContainsKey(Message.ActionPropertyName) ? mes[Message.ActionPropertyName]/*.getProperty()*/ :"";
            switch (action.ToString().ToLower())
            {
                case "create":
                    var symId = mes.symbolProperties.SymbolID;// [Message.SicCodePropertyName];//.getProperty();
                    Geometry geom = mes.SymbolGeometry;
                    if (symId != "")
                    {
                        var sr = SpatialReferences.Wgs84;  //TODO PRA quel SR en NVG, a priori ...
                        var syms = DataLoader.SearchBySIC(symId, DataLoader.SearchMode.Large);

                        var sym = syms.FirstOrDefault();
                        // TODO PRA tester si plus de 1 chercher en multiple

                        if (syms.Count() > 1)
                            throw new Exception("Trop de symboles");

                        if (sym == null)// && mes.SymbolGeometry.GeometryType != GeometryType.Point) // TODO test pra ne marchera pas si faux msg
                            return false;
                        // TODO PRA mettre partout ContainsKey

                        var ga = sym.GraphicObject as Symbol;
                        if (geom != null)
                        {
                            // si le symbole est ponctuel et geom ne l'est pas 
                            // on doit faire quelque chose !
                            if (geom.GeometryType != GeometryType.Point)
                            {
                                if (ga as MarkerSymbol != null) // typiquement ? TextSymbol
                                {
                                    SimpleLineSymbol symbol = new SimpleLineSymbol(SimpleLineSymbolStyle.Solid, System.Drawing.Color.Blue, 5);

                                    Graphic g1 = new Graphic(geom, symbol);
                                  

                                    g1.Attributes.Add(Message.IdPropertyName, mes.Id);// TODO PRA et si on a plusieurs objets dans le msg ?

                                    this.graphicsOverlay.Graphics.Add(g1);

                                   
                                    /*  {
                                          grap,
                                          new Graphic(geom, ga.Clone())
                                      };*/
                                }


                            }


                        }
                        else
                        {

                            var pos = mes.ContainsKey(Message.ControlPointsPropertyName) ? mes[Message.ControlPointsPropertyName] : "0.0;0.00";//.getProperty(Message.ControlPointsPropertyName);
                            string[] p = pos.Split(";");
                            CultureInfo cif = new CultureInfo("en-US");
                            MapPoint point;//= new MapPoint(Convert.ToDouble(p[0], cif), Convert.ToDouble(p[1], cif));
                            string position = p[1] + "* | " + p[0] + "*";// Convert.ToDouble(p[1], cif) + " | " + Convert.ToDouble(p[0], cif);
                            point = CoordinateFormatter.FromLatitudeLongitude(position, sr); // WGS84 par defaut dans le converteur 
                            geom = point;
                        }


                        var graphic = new Graphic(geom, ga.Clone());

                        // La selection des objets passe par l'id en attribut
                        graphic.Attributes.Add(Message.IdPropertyName, mes.Id);// TODO PRA et si on a plusieurs objets dans le msg ?

                        this.graphicsOverlay.Graphics.Add(graphic);

                        this.AddMessage(mes);
                        return true;
                    }
                    else
                    {// TODO PRA typiquement une fleche NVG sans codeSymbole ou nc1fireobjective
                        if (geom == null)
                            return false;
                        //      Color c = SymbolProperties.MilStandardColor_unfilled_symbols(codeSymbol);
                        //    SimpleFillSymbol bufferPolygonFillSymbol = new SimpleFillSymbol(SimpleFillSymbolStyle.Solid, bufferPolygonColor, bufferPolygonOutlineSymbol);
                        SimpleFillSymbol fillSymbol = new SimpleFillSymbol(SimpleFillSymbolStyle.Solid, System.Drawing.Color.Yellow, null);

                        var graphic = new Graphic(geom, fillSymbol);

                        // La selection des objets passe par l'id en attribut
                        graphic.Attributes.Add(Message.IdPropertyName, mes.Id);// TODO PRA et si on a plusieurs objets dans le msg ?

                        this.graphicsOverlay.Graphics.Add(graphic);

                        this.AddMessage(mes);
                        return true;
                    }
                   

                case "none":
                    break;
                case "update":// TODO PRA voir
                    Graphic g = graphics.FirstOrDefault();
                    var texPos = mes[Message.ControlPointsPropertyName];
                    Geometry pFromText = Geometry.FromJson(texPos);
                    g.Geometry = pFromText; // TODO PRA : sauver la nouvelle valeur ?
                    trueMessage.FirstOrDefault().IsModified = true;
                    return true;
                case "select":
                    if (graphics.FirstOrDefault() != null)
                    {
                        var ggg = graphics.FirstOrDefault();
                        graphics.FirstOrDefault().IsSelected = true;
                        return true;
                    }
                    else
                        return false;

                case "un_select":
                    if (graphics.FirstOrDefault() != null)
                    {
                        var gg = graphics.FirstOrDefault();
                        graphics.FirstOrDefault().IsSelected = false;
                        return true;
                    }
                    else
                        return false;

                case "remove":// TODO PRA 
                    break;
                default:
                    //       var result = tam.getProperty(Message.WkidPropertyName);
                    //      SpatialReference sr = SpatialReference.Create(int.Parse(result));
                    {
                        var symId2 = mes.symbolProperties.SymbolID;// [Message.SicCodePropertyName];//.getProperty();

                        if (symId2 != "")
                        {
                            var sr = SpatialReferences.Wgs84;  //TODO PRA quel SR en NVG, a priori ...
                            var syms = DataLoader.SearchBySIC(symId2, DataLoader.SearchMode.Strict);

                            var sym = syms.FirstOrDefault();
                            // TODO PRA tester si plus de 1 chercher en multiple

                            if (syms.Count() > 1)
                                throw new Exception("Trop de symboles");

                            if (sym == null)
                                return false;

                            var pos = mes[Message.ControlPointsPropertyName];//.getProperty(Message.ControlPointsPropertyName);
                            string[] p = pos.Split(";");
                            CultureInfo cif = new CultureInfo("en-US");
                            MapPoint point;//= new MapPoint(Convert.ToDouble(p[0], cif), Convert.ToDouble(p[1], cif));
                            string position = p[1] + "* | " + p[0] + "*";// Convert.ToDouble(p[1], cif) + " | " + Convert.ToDouble(p[0], cif);
                            point = CoordinateFormatter.FromLatitudeLongitude(position, sr); // WGS84 par defaut dans le converteur 
                            var ga = sym.GraphicObject as Symbol;
                            var graphic = new Graphic(point, ga.Clone());

                            // La selection des objets passe par l'id en attribut
                            graphic.Attributes.Add(Message.IdPropertyName, mes.Id);// TODO PRA et si on a plusieurs objets dans le msg ?

                            this.graphicsOverlay.Graphics.Add(graphic);

                            this.AddMessage(mes);
                            return true;
                        }
                        else
                        {// TODO PRA typiquement une fleche NVG sans codeSymbole
                            return false;
                        }
                        break;
                    }
            }








            return true;
        }
        public bool ProcessMessage(TimeAwareMilitaryMessage tam, MessageAction action = MessageAction.none)
        {

            switch (action.ToString())
            {
                case "create":

                    var symId = tam.symbolProperties.SymbolID; //tam[Message.SicCodePropertyName];//.getProperty();

                    var syms = DataLoader.SearchBySIC(symId, DataLoader.SearchMode.Large);

                    var sym = syms.FirstOrDefault();
                    // TODO PRA tester si plus de 1 chercher en multiple
                    int n = syms.Count(); // TEMPO PRA
                    if (syms.Count() > 1)
                        throw new Exception("Trop de symboles");

                    if (sym == null)
                        return false;

                    if (tam.SymbolGeometry.GeometryType == GeometryType.Point)
                    {
                        var result = tam.WkText;// tam[Message.WkidPropertyName];//.getProperty();
                        SpatialReference sr = SpatialReference.Create(int.Parse(result)); //SpatialReference(result);

                        var pos = tam[Message.ControlPointsPropertyName];//.getProperty();
                        string[] p = pos.Split(";");
                        CultureInfo cif = new CultureInfo("en-US");
                        MapPoint point = new MapPoint(Convert.ToDouble(p[0], cif), Convert.ToDouble(p[1], cif), sr); // TODO PRA mettre SR partout !
                        var ga = sym.GraphicObject as Symbol;
                        var graphic = new Graphic(point, ga.Clone());

                        // La selection des objets passe par l'id en attribut
                        graphic.Attributes.Add(Message.IdPropertyName, tam.Id);// TODO PRA et si on a plusieurs objets dans le msg ?

                        this.graphicsOverlay.Graphics.Add(graphic);

                        this.AddMessage(tam);
                        return true;
                    }

                    break;
                case "None":
                    break;
                case "update":// TODO PRA 
                    break;
                case "select":
                    //               graphics.FirstOrDefault().IsSelected = true;
                    break;
                case "un_select":
                    //             graphics.FirstOrDefault().IsSelected = false;
                    break;
                case "remove":// TODO PRA 
                    break;
                default: // TODO PRA dans quel cas ?
                    break;

            }





            return false;
        }


        // IEnumerable<Layer> childLayers;

        /*    public MessageLayer(IEnumerable<Layer> childLayers)
            {
                this.childLayers = childLayers ?? throw new System.ArgumentNullException(nameof(childLayers));
            }  */

        //    public IEnumerable<Layer> ChildLayers { get => childLayers; set => childLayers = value; }

        public void Clear()
        {
            this.graphicsOverlay.Graphics.Clear();
        }

        // From Example Name: DictionaryRendererGraphicsOverlay  2 fonctions
        private static void LoadMilitaryMessages(string militaryMessagePath, GraphicsOverlay layer)  // TODO PRA 
        {
            // Load the XML document.
            XElement xmlRoot = XElement.Load(militaryMessagePath);

            // Get all of the messages.
            IEnumerable<XElement> messages = xmlRoot.Descendants("message");

            // Add a graphic for each message.
            foreach (var message in messages)
            {
                Graphic messageGraphic = GraphicFromAttributes(message.Descendants().ToList());
                layer.Graphics.Add(messageGraphic);
            }
        }

        private static Graphic GraphicFromAttributes(List<XElement> graphicAttributes)
        {
            // Get the geometry and the spatial reference from the message elements.
            XElement geometryAttribute = graphicAttributes.First(attr => attr.Name == Message.ControlPointsPropertyName);// "ControlPointsPropertyName_control_points");
                                                                                                                         //       XElement spatialReferenceAttr = graphicAttributes.First(attr => attr.Name == Message.WkidPropertyName);// "_wkid");

            // Split the geometry field into a list of points.
            Array pointStrings = geometryAttribute.Value.Split(';');

            // Create a point collection in the correct spatial reference.
            int wkid = 4326;// Convert.ToInt32(spatialReferenceAttr.Value);
            SpatialReference pointSR = SpatialReference.Create(wkid);
            PointCollection graphicPoints = new PointCollection(pointSR);

            // Add a point for each point in the list.
            foreach (string pointString in pointStrings)
            {
                var coords = pointString.Split(','); // TODO PRA 
                graphicPoints.Add(Convert.ToDouble(coords[0]), Convert.ToDouble(coords[1])); // todo pra pk pas de SR ?
            }

            // Create a multipoint from the point collection.
            Multipoint graphicMultipoint = new Multipoint(graphicPoints);

            // Create the graphic from the multipoint.
            Graphic messageGraphic = new Graphic(graphicMultipoint);

            // Add all of the message's attributes to the graphic (some of these are used for rendering).
            foreach (XElement attr in graphicAttributes)
            {
                messageGraphic.Attributes[attr.Name.ToString()] = attr.Value;
            }

            return messageGraphic;
        }
    }
}

