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
using System.Windows.Input;
//using Esri.ArcGISRuntime.Controls;
using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime.Geometry;
using MilitaryPlanner.Helpers;
using MilitaryPlanner.ViewModels;
using Esri.ArcGISRuntime.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.UI;

namespace MilitaryPlanner.Controllers
{
    public class CoordinateReadoutController
    {
        private readonly MapView _mapView;
        private readonly MapViewModel _mapViewModel;

        private enum CoordinateReadoutFormat
        {
            DD,
            DMS,
            GARS,
            GEOREF,
            MGRS,
            USNG,
            UTM
        };


        //TODO PRA LatitudeLongitudeGrid Constructor pour la grille UTM autre ...


        private CoordinateReadoutFormat _coordinateReadoutFormat = CoordinateReadoutFormat.DD;

        public CoordinateReadoutController(MapView mapView, MapViewModel mapViewModel)
        {
            _mapView = mapView;
            _mapViewModel = mapViewModel;

            _mapView.MouseMove += mapView_MouseMove;

            Mediator.Register(Constants.ACTION_COORDINATE_READOUT_FORMAT_CHANGED, OnCoordinateReadoutFormatChanged);
        }

        private void OnCoordinateReadoutFormatChanged(object obj)
        {
            string format = obj as string;

            if (!String.IsNullOrWhiteSpace(format))
            {
                _coordinateReadoutFormat = format switch
                {
                    "DD" => CoordinateReadoutFormat.DD,
                    "DMS" => CoordinateReadoutFormat.DMS,
                    "GARS" => CoordinateReadoutFormat.GARS,
                    "GEOREF" => CoordinateReadoutFormat.GEOREF,
                    "MGRS" => CoordinateReadoutFormat.MGRS,
                    "USNG" => CoordinateReadoutFormat.USNG,
                    "UTM" => CoordinateReadoutFormat.UTM,
                    _ => CoordinateReadoutFormat.MGRS,
                };
            }
        }

        void mapView_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateCoordinateReadout(e.GetPosition(_mapView));
        }

        private async void UpdateCoordinateReadout(Point point)
        {
            
            var mp = _mapView.ScreenToLocation(point);

            if (mp == null)
                return;

            string coordinateReadout ;
            try
            {
                // we can do DD, DMS, GARS, GEOREF, MGRS, USNG, UTM
                coordinateReadout = _coordinateReadoutFormat switch
                {
                    CoordinateReadoutFormat.DD => CoordinateFormatter.ToLatitudeLongitude(mp, LatitudeLongitudeFormat.DecimalDegrees, 3),
                    CoordinateReadoutFormat.DMS => CoordinateFormatter.ToLatitudeLongitude(mp, LatitudeLongitudeFormat.DegreesMinutesSeconds, 1),
                    CoordinateReadoutFormat.GARS => CoordinateFormatter.ToGars(mp),
                    CoordinateReadoutFormat.GEOREF => CoordinateFormatter.ToGeoRef(mp, 4),
                    CoordinateReadoutFormat.MGRS => CoordinateFormatter.ToMgrs(mp, MgrsConversionMode.Automatic, 5, true),
                    CoordinateReadoutFormat.USNG => CoordinateFormatter.ToUsng(mp, 5, true),
                    CoordinateReadoutFormat.UTM => CoordinateFormatter.ToUtm(mp, UtmConversionMode.LatitudeBandIndicators, true),
                    _ => CoordinateFormatter.ToMgrs(mp, MgrsConversionMode.Automatic, 5, true),
                };
                _mapViewModel.CoordinateReadout = coordinateReadout;


            // On recherche l'objet sous la souris 

            // Convert the map point to a screen point
            Point screenCoordinate = _mapView.LocationToScreen( mp);
            // Identify graphics in the graphics overlay using the point  // TODO PRA semble un peu complexe comme moyen ...
    //        Task<IReadOnlyList<IdentifyGraphicsOverlayResult>>
            var results = await _mapView.IdentifyGraphicsOverlaysAsync(screenCoordinate, 2, false);
            
            if (results == null) //!results.IsCompleted)
                return ;
            // If results were found, get the first graphic
            Graphic graphic = null;
                IdentifyGraphicsOverlayResult idResult = results[0];//results.Result[0];//.Resultresults[0];
            if (idResult != null && idResult.Graphics.Count > 0)
                graphic = idResult.Graphics[0];
                object idRes;
                if (graphic.Attributes.TryGetValue(Message.IdPropertyName,out idRes))
                {

                    coordinateReadout = "Object " + idRes.ToString() + "\n"+(coordinateReadout != null ? coordinateReadout : "");
                    _mapViewModel.CoordinateReadout = coordinateReadout;
                }
                


            }
            catch (Exception ex)
            { 
            // TODO PRA 
            }


        }

    }
}
