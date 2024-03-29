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
using System;
using System.Windows;
//using Esri.ArcGISRuntime.Layers;
//using Esri.ArcGISRuntime.Mapping;
using MilitaryPlanner.Helpers;
using Esri.ArcGISRuntime.UI;

namespace MilitaryPlanner.ViewModels
{
    public class NetworkingToolViewModel : BaseToolViewModel
    {
        public NetworkingToolViewModel()
        {
            GetDirectionsCommand = new RelayCommand(OnGetDirectionsCommand);
        }

        public RelayCommand GetDirectionsCommand { get; set; }

        private bool _addressIsExpanded = false;

        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public bool AddressIsExpanded
        {
            get { return _addressIsExpanded;}
            set
            {
                _addressIsExpanded = value;
                RaisePropertyChanged(() => AddressIsExpanded);
                RaisePropertyChanged(() => PanelInstructionsVisibility);
            }
        }

        public Visibility _panelInstructionsVisibility = Visibility.Visible;

        public Visibility PanelInstructionsVisibility
        {
            get
            {
                if (AddressIsExpanded)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }

        private string _routeTotals = String.Empty;
        public string RouteTotals
        {
            get
            {
                return _routeTotals;
            }

            set
            {
                _routeTotals = value;
                RaisePropertyChanged(() => RouteTotals);
            }
        }

        private GraphicCollection _graphics = null;
        public GraphicCollection Graphics
        {
            get
            {
                return _graphics;
            }

            set
            {
                _graphics = value;
                RaisePropertyChanged(() => Graphics);
            }
        }

        private Visibility _panelResultsVisibility = Visibility.Collapsed;
        public Visibility PanelResultsVisibility
        {
            get
            {
                return _panelResultsVisibility;
            }

            set
            {
                _panelResultsVisibility = value;
                RaisePropertyChanged(() => PanelResultsVisibility);
            }
        }

        private Visibility _progressVisibility = Visibility.Collapsed;
        public Visibility ProgressVisibility
        {
            get
            {
                return _progressVisibility;
            }

            set
            {
                _progressVisibility = value;
                RaisePropertyChanged(() => ProgressVisibility);
            }
        }

        private void OnGetDirectionsCommand(object obj)
        {
            Mediator.NotifyColleagues(Constants.ACTION_ROUTING_GET_DIRECTIONS, null);
        }

    }
}
