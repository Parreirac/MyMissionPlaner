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

using System.Collections.ObjectModel;
using MilitaryPlanner.Helpers;
using Esri.ArcGISRuntime.Portal;
//using Esri.ArcGISRuntime.Mapping.Basemap;

namespace MilitaryPlanner.ViewModels
{

    public class BasemapGalleryViewModel : BaseToolViewModel
    {
        public RelayCommand ChangeBasemapCommand { get; set; }

        public BasemapGalleryViewModel()
        {
            ChangeBasemapCommand = new RelayCommand(OnChangeBasemapCommand);
        }

        // modif pra ArcGISPortalItem -> PortalItem
        private ObservableCollection<PortalItem> _basemaps;

        public ObservableCollection<PortalItem> Basemaps
        {
            get { return _basemaps;}

            set
            {
                _basemaps = value;
                RaisePropertyChanged(() => Basemaps);
            }
        }

        private void OnChangeBasemapCommand(object obj)
        {
            Mediator.NotifyColleagues(Constants.ACTION_UPDATE_BASEMAP, obj);
        }
    }
}
