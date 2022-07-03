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
using System.Windows;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using MilitaryPlanner.Helpers;
using MilitaryPlanner.ViewModels;
using MilitaryPlanner.Views;
using MapView = Esri.ArcGISRuntime.UI.Controls.MapView;

namespace MilitaryPlanner.Controllers
{
    public class GotoXYToolController
    {
        private readonly MapView _mapView;
        private readonly GotoXYToolView _gotoXyToolView;

        public GotoXYToolController(MapView mapView, MapViewModel mapViewModel)
        {
            _mapView = mapView;

            _gotoXyToolView = new GotoXYToolView { ViewModel = { mapView = mapView } };

            var owner = Window.GetWindow(mapView);

            if (owner != null)
            {
                _gotoXyToolView.Owner = owner;
            }

            Mediator.Register(Constants.ACTION_GOTO_XY_COORDINATES, OnGotoXYCoordinates);
        }

        public void Toggle()
        {
            _gotoXyToolView.ViewModel.Toggle();
        }

        private void OnGotoXYCoordinates(object obj)
        {
            MapPoint mp ;
            try
            {
                var gitem = obj as GotoItem;

                var sr = SpatialReferences.Wgs84; // TODO PRA pourquoi aps directement MyMapView.SpatialReference ?
                
                if (gitem != null)
                {
                    

                    switch (gitem.Format)
                    {
                      //  case "DD":  // TODO TEST PRA voir les autre conversions dans le code.
                                      // le convertisseur est il plus évolué et gere 3 cas DD en 1 ?
                      //      mp = ConvertCoordinate.FromDecimalDegrees(gitem.Coordinate, sr);
                      //     break;
                      //  case "DDM":
                       //     mp = ConvertCoordinate.FromDegreesDecimalMinutes(gitem.Coordinate, sr);
                      //      break;
                      //  case "DMS":
                      //      mp =   CoordinateFormatter.FromLatitudeLongitude(gitem.Coordinate, sr) ;
                     //       mp = ConvertCoordinate.FromDegreesMinutesSeconds(gitem.Coordinate, sr);
                       //     break;
                        case "GARS":
                            mp =  CoordinateFormatter.FromGars(gitem.Coordinate, sr, GarsConversionMode.Center);
                                //ConvertCoordinate.FromGars(gitem.Coordinate, sr, GarsConversionMode.Center);
                            break;
                        case "GEOREF":
                            mp =  CoordinateFormatter.FromGeoRef(gitem.Coordinate, sr) ;
                                //ConvertCoordinate.FromGeoref(gitem.Coordinate, sr);
                            break;
                        case "MGRS":
                            mp =  CoordinateFormatter.FromMgrs(gitem.Coordinate, sr, MgrsConversionMode.Automatic) ;// .FromMgrs(gitem.Coordinate, sr, MgrsConversionMode.Automatic);
                            //mp = ConvertCoordinate.FromMgrs(gitem.Coordinate, sr, MgrsConversionMode.Automatic);
                            break;
                        case "USNG":
                            mp =  CoordinateFormatter.FromUsng(gitem.Coordinate, sr) ;
                            //mp = ConvertCoordinate.FromUsng(gitem.Coordinate, sr);
                            break;
                        case "UTM":
                            mp =  CoordinateFormatter.FromUtm(gitem.Coordinate, sr, UtmConversionMode.NorthSouthIndicators );
                           // mp = ConvertCoordinate.FromUtm(gitem.Coordinate, sr, UtmConversionMode.None);
                            break;
                        default:
                            mp =  CoordinateFormatter.FromLatitudeLongitude(gitem.Coordinate, sr );
                           // mp = ConvertCoordinate.FromDecimalDegrees(gitem.Coordinate, SpatialReferences.Wgs84);
                            break;
                    }

                    if (mp != null)
                    {
                        Viewpoint vp = new Viewpoint(mp, Convert.ToDouble(gitem.Scale));
                        /*  if (!String.IsNullOrWhiteSpace(gitem.Scale))
                        {
                                _mapView.SetViewpointAsync().SetViewAsync(mp, Convert.ToDouble(gitem.Scale));
                        }
                             else
                        {
                               _mapView.SetViewpointAsync().SetViewpointAsync().SetViewAsync(mp);
                        }*/
                        _mapView.SetViewpointAsync(vp);
                    }
                    else
                    {
                        MessageBox.Show("Failed to convert coordinate.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to convert coordinate.");
            }
        }
    }
}
