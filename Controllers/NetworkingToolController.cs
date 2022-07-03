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
using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
//using Esri.ArcGISRuntime.Controls;
//using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime.Geometry;
//using Esri.ArcGISRuntime.Mapping;
//using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Symbology;
//using Esri.ArcGISRuntime.Tasks.NetworkAnalyst;
using Esri.ArcGISRuntime.Tasks.NetworkAnalysis;
using MilitaryPlanner.Helpers;
using MilitaryPlanner.ViewModels;
using MilitaryPlanner.Views;
//modif pra 
using MapView = Esri.ArcGISRuntime.UI.Controls.MapView  ;// Esri.ArcGISRuntime.Controls.MapView;
using Esri.ArcGISRuntime.Tasks.Geocoding;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime;


namespace MilitaryPlanner.Controllers
{
    public class NetworkingToolController
    {
        private readonly MapView _mapView;
        private readonly NetworkingToolView _networkingToolView;

        private const string OnlineRoutingService = "http://sampleserver6.arcgisonline.com/arcgis/rest/services/NetworkAnalysis/SanDiego/NAServer/Route";

        private /* readonly */ RouteTask /*OnlineRouteTask*/ _routeTask;
        private readonly Symbol _directionPointSymbol;
        private readonly GraphicsOverlay _stopsOverlay;
        private readonly GraphicsOverlay _routesOverlay;
        private readonly GraphicsOverlay _directionsOverlay;

        private const string OnlineLocatorUrl = "http://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer";
        //Class containing the information for a ArcGIS Geocode service. It contains notably the address fields the service
        // expects to successfully geocode an address. 
   //     private LocatorServiceInfo _locatorServiceInfo;
        private LocatorTask /*OnlineLocatorTask*/ _locatorTask;


      
        public NetworkingToolController(MapView mapView, MapViewModel mapViewModel)
        {
            this._mapView = mapView;

            _networkingToolView = new NetworkingToolView { ViewModel = { mapView = mapView } };

            var owner = Window.GetWindow(mapView);

            if (owner != null)
            {
                _networkingToolView.Owner = owner;
            }

            // hook mapview events
            // /*.MapViewTapped */
            mapView.GeoViewTapped  += mapView_MapViewTapped;
            /*.MapViewDoubleTapped */
            mapView.GeoViewDoubleTapped  += mapView_MapViewDoubleTapped;

            // hook listDirections
            _networkingToolView.listDirections.SelectionChanged += listDirections_SelectionChanged;

            // hook view resources
            _directionPointSymbol = _networkingToolView.LayoutRoot.Resources["directionPointSymbol"] as Symbol;

            mapView.GraphicsOverlays.Add(new GraphicsOverlay { Id = "RoutesOverlay", Renderer = _networkingToolView.LayoutRoot.Resources["routesRenderer"] as Renderer });
            mapView.GraphicsOverlays.Add(new GraphicsOverlay { Id = "StopsOverlay" });
            mapView.GraphicsOverlays.Add(new GraphicsOverlay { Id = "DirectionsOverlay", Renderer = _networkingToolView.LayoutRoot.Resources["directionsRenderer"] as Renderer, SelectionColor = System.Drawing.Color.Red });

            _stopsOverlay = mapView.GraphicsOverlays["StopsOverlay"];
            _routesOverlay = mapView.GraphicsOverlays["RoutesOverlay"];
            _directionsOverlay = mapView.GraphicsOverlays["DirectionsOverlay"];

     //       _routeTask =  new OnlineRouteTask(new Uri(OnlineRoutingService));

            Mediator.Register(Constants.ACTION_ROUTING_GET_DIRECTIONS, DoGetDirections);

      //      _locatorTask = new OnlineLocatorTask(new Uri(OnlineLocatorUrl)) { AutoNormalize = true };
        }


        public void Toggle()
        {
            _networkingToolView.ViewModel.Toggle();

            if (!_networkingToolView.ViewModel.IsToolOpen)
            {
                Reset();
            }
        }

        private void Reset()
        {
            // clean up
            _networkingToolView.ViewModel.PanelResultsVisibility = Visibility.Collapsed;

            _stopsOverlay.Graphics.Clear();
            _routesOverlay.Graphics.Clear();
            //  Modif pra  GraphicsSource n'existe plus     _directionsOverlay.GraphicsSource = null;
        }

        private void mapView_MapViewTapped(object sender, GeoViewInputEventArgs e)
        {
            if (!_networkingToolView.ViewModel.IsToolOpen || _networkingToolView.ViewModel.AddressIsExpanded == true)
                return;

            try
            {
                e.Handled = true;

                if (_directionsOverlay.Graphics.Any())
                {
                    Reset();
                }

                var graphicIdx = _stopsOverlay.Graphics.Count + 1;
                _stopsOverlay.Graphics.Add(CreateStopGraphic(e.Location, graphicIdx));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sample Error");
            }
        }

        private async void mapView_MapViewDoubleTapped(object sender, GeoViewInputEventArgs e)
        {
            if (!_networkingToolView.ViewModel.IsToolOpen || _networkingToolView.ViewModel.AddressIsExpanded == true)
                return;

            if (_stopsOverlay.Graphics.Count < 2)
                return;

            e.Handled = true;

            await RunRouting();
        }

        private async Task<int> RunRouting()
        {
         
            try
            {
                if (_routeTask == null)
                    _routeTask = await RouteTask.CreateAsync(new Uri(OnlineRoutingService));//  new OnlineRouteTask(new Uri(OnlineRoutingService));

                _networkingToolView.ViewModel.PanelResultsVisibility = Visibility.Collapsed;
                _networkingToolView.ViewModel.ProgressVisibility = Visibility.Visible;

                RouteParameters routeParams = await _routeTask.CreateDefaultParametersAsync();  //.GetDefaultParametersAsync();

                routeParams.OutputSpatialReference /*.OutSpatialReference */= _mapView.SpatialReference;
                routeParams.ReturnDirections = true;
                routeParams.DirectionsDistanceUnits /*.DirectionsLengthUnit */ = UnitSystem.Imperial;// LinearUnits.Miles;
                routeParams.DirectionsLanguage = CultureInfo.CurrentCulture.ToString(); //  new CultureInfo("en-Us"); // CultureInfo.CurrentCulture;
                
                //~~~~
                // Create a list to hold stops that should be on the route.
                List<Stop> routeStops = new List<Stop>();

                // Create stops from the graphics.
                foreach (Graphic stopGraphic in _stopsOverlay.Graphics)
                {
                    // Note: this assumes that only points were added to the stops overlay.
                    MapPoint stopPoint = (MapPoint)stopGraphic.Geometry;

                    // Create the stop from the graphic's geometry.
                    Stop routeStop = new Stop(stopPoint);

                    // Set the name of the stop to its position in the list.
                    routeStop.Name = $"{_stopsOverlay.Graphics.IndexOf(stopGraphic) + 1}";

                    // Add the stop to the list of stops.
                    routeStops.Add(routeStop);
                }
                routeParams.SetStops(routeStops); //routeParams.SetStops(_stopsOverlay.Graphics);
                //~~~~
                 var routeResult = await _routeTask.SolveRouteAsync(routeParams);//.SolveAsync(routeParams);
                if (routeResult == null || routeResult.Routes == null || !routeResult.Routes.Any())
                    throw new Exception("No route could be calculated");

                Route route = routeResult.Routes[0];
                _routesOverlay.Graphics.Add(new Graphic(route.RouteGeometry/*.RouteFeature.Geometry*/));

   //             _directionsOverlay.GraphicsSource = route.DirectionManeuvers.Select(rd => GraphicFromRouteDirection(rd));

                  
                _networkingToolView.ViewModel.Graphics = _directionsOverlay.Graphics;
                //todo PRA test sur /*rd.Time*/ rd.EstimatedArrivalTime
                //TODO TEST modif pra EstimatedArrivalTimeShift <=  EstimatedArrivalTime sinon probleme de cast
                var totalTime = route.DirectionManeuvers.Select(rd => /*rd.Time*/ rd.EstimatedArrivalTimeShift/*.EstimatedArrivalTime*/).Aggregate(TimeSpan.Zero, (p, v) =>
                {
                    return p.Add(v);
                });
                //todo PRA test .GetLength(LinearUnits.Miles) mais Length en metres todo conversion ou changement d'unité dans le format
                var totalLength = route.DirectionManeuvers.Select(rd => rd.Length/*.GetLength(LinearUnits.Miles)*/ ).Sum();
                _networkingToolView.ViewModel.RouteTotals = string.Format("Time: {0:h':'mm':'ss} / Length: {1:0.00} mi", totalTime, totalLength);

                if (!route.RouteGeometry.IsEmpty/*.RouteFeature.Geometry.IsEmpty*/)
                {
                    EnvelopeBuilder myEnvelopeBuilder = new EnvelopeBuilder(route.RouteGeometry.Extent);
                    myEnvelopeBuilder.Expand(1.25);
                    await _mapView.SetViewpointGeometryAsync(myEnvelopeBuilder.ToGeometry(), 0);

                  //  await _mapView.SetViewAsync(route.RouteFeature.Geometry.Extent.Expand(1.25));
                }
            }
            catch (AggregateException ex)
            {
                var innermostExceptions = ex.Flatten().InnerExceptions;
                if (innermostExceptions != null && innermostExceptions.Count > 0)
                {
                    MessageBox.Show(innermostExceptions[0].Message, "Sample Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Sample Error");
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sample Error");
                Reset();
            }
            finally
            {
                _networkingToolView.ViewModel.ProgressVisibility = Visibility.Collapsed;

                if (_directionsOverlay.Graphics.Any())
                {
                    _networkingToolView.ViewModel.PanelResultsVisibility = Visibility.Visible;
                }
            }

            return 0;
        }

        void listDirections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _directionsOverlay.ClearSelection();

            if (e.AddedItems != null && e.AddedItems.Count == 1)
            {
                var graphic = e.AddedItems[0] as Graphic;
                if (graphic != null) graphic.IsSelected = true;
            }
        }

        private static Graphic CreateStopGraphic(MapPoint location, int id)
        {
            var symbol = new CompositeSymbol();

            //SimpleMarkerStyle =>SimpleMarkerSymbolStyle
            symbol.Symbols.Add(new SimpleMarkerSymbol { Style = SimpleMarkerSymbolStyle.Circle, Color = System.Drawing.Color.Blue, Size = 16 });
            symbol.Symbols.Add(new TextSymbol
            {
                Text = id.ToString(),
                Color = System.Drawing.Color.White,
                VerticalAlignment = Esri.ArcGISRuntime.Symbology.VerticalAlignment.Middle,//VerticalTextAlignment.Middle,
                HorizontalAlignment = Esri.ArcGISRuntime.Symbology.HorizontalAlignment.Center,//HorizontalTextAlignment.Center,
                // YOffset = -1  // TODO TEST PRA plus d'offset ?
            });

            var graphic = new Graphic
            {
                Geometry = location,
                Symbol = symbol
            };

            return graphic;
        }

        private Graphic GraphicFromRouteDirection(/* RouteDirection*/ DirectionManeuver rd)
        {
            var graphic = new Graphic(rd.Geometry);
            graphic.Attributes.Add("Direction", rd.DirectionText);// .Text);
            graphic.Attributes.Add("Time", string.Format("{0:h\\:mm\\:ss}", rd.EstimatedArrivalTime));//.Time));
            //TODO PRA unité de mesure
            graphic.Attributes.Add("Length", string.Format("{0:0.00}", rd.Length)); // ().GetLength(LinearUnits.Miles)));
            if (rd.Geometry is MapPoint)
                graphic.Symbol = _directionPointSymbol;

            return graphic;
        }

        private async void DoGetDirections(object obj)
        {
            if (String.IsNullOrWhiteSpace(_networkingToolView.ViewModel.FromAddress) ||
                String.IsNullOrWhiteSpace(_networkingToolView.ViewModel.ToAddress))
            {
                return;
            }

            if (_locatorTask == null)
                _locatorTask = await LocatorTask.CreateAsync(new Uri(OnlineLocatorUrl)); // TODO PRA que devient le AutoNormalize = true  ?

            // geocode from and to address
    //        if (_locatorServiceInfo == null)
     //           _locatorServiceInfo = await _locatorTask.GetInfoAsync();

            Reset();

            IReadOnlyList<SuggestResult> suggestions = await _locatorTask.SuggestAsync(_networkingToolView.ViewModel.FromAddress);

            // Stop gracefully if there are no suggestions
            if (suggestions.Count < 1) { return; }

            // Get the full address for the first suggestion
            SuggestResult firstSuggestion = suggestions[0];
            IReadOnlyList<GeocodeResult> candidateFromResults = await _locatorTask.GeocodeAsync(firstSuggestion.Label);

            // Stop gracefully if the geocoder does not return a result
            if (candidateFromResults.Count < 1) { return; }

            suggestions = await _locatorTask.SuggestAsync(_networkingToolView.ViewModel.ToAddress);
            firstSuggestion = suggestions[0];

            if (suggestions.Count < 1) { return; }
            IReadOnlyList<GeocodeResult> candidateToResults = await _locatorTask.GeocodeAsync(firstSuggestion.Label);

            if (candidateToResults.Count < 1) { return; }
            /*
            // geocode from address
            var candidateFromResults = await _locatorTask.GeocodeAsync(
                GetInputAddressFromUI(_networkingToolView.ViewModel.FromAddress), new List<string> { "Addr_type", "Score", "X", "Y" }, _mapView.SpatialReference, CancellationToken.None);

            // geocode to address
            var candidateToResults = await _locatorTask.GeocodeAsync(
                GetInputAddressFromUI(_networkingToolView.ViewModel.ToAddress), new List<string> { "Addr_type", "Score", "X", "Y" }, _mapView.SpatialReference, CancellationToken.None);
            */
            if (candidateFromResults.Any() && candidateToResults.Any())
            {
                var fromResult = candidateFromResults[0];
                var toResult = candidateToResults[0];

                var fromMapPoint = fromResult.Extent.GetCenter();
                var toMapPoint = toResult.Extent.GetCenter();

                _stopsOverlay.Graphics.Add(CreateStopGraphic(new MapPoint(fromMapPoint.X, fromMapPoint.Y, _mapView.SpatialReference), 1));
                _stopsOverlay.Graphics.Add(CreateStopGraphic(new MapPoint(toMapPoint.X, toMapPoint.Y, _mapView.SpatialReference), 2));

                await RunRouting();
            }
        }
        /*
        private System.Collections.Generic.IDictionary<string, string> GetInputAddressFromUI(string singleLineAddress)
        {
            Dictionary<string, string> address = new Dictionary<string, string>();

            address[_locatorServiceInfo.SingleLineAddressField.FieldName] = singleLineAddress;

            return address;
        }*/
    }
}
