﻿// Copyright 2015 Esri 
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
using System.Windows;
using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime.Symbology;
using MilitaryPlanner.ViewModels;
using MilitaryPlanner.Views;
using MapView = Esri.ArcGISRuntime.UI.Controls.MapView;
using Esri.ArcGISRuntime.UI;

namespace MilitaryPlanner.Controllers
{
    public class ViewShedToolController
    {
        private readonly ViewShedToolView _viewShedToolView;

        public ViewShedToolController(MapView mapView, MapViewModel mapViewModel)
        {
            _viewShedToolView = new ViewShedToolView { ViewModel = { mapView = mapView } };

            var owner = Window.GetWindow(mapView);

            if (owner != null)
            {
                _viewShedToolView.Owner = owner;
            }

            mapView.GraphicsOverlays.Add(new GraphicsOverlay() { Id = "inputOverlay", Renderer = _viewShedToolView.LayoutRoot.Resources["PointRenderer"] as Renderer });
            mapView.GraphicsOverlays.Add(new GraphicsOverlay() { Id = "ViewshedOverlay", Renderer = _viewShedToolView.LayoutRoot.Resources["ViewshedRenderer"] as Renderer });
        }

        public void Toggle()
        {
            _viewShedToolView.ViewModel.Toggle();
        }
    }
}
