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

//using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Portal;
//using Esri.ArcGISRuntime.WebMap;

using MilitaryPlanner.Helpers;
using MilitaryPlanner.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
//using MapView = Esri.ArcGISRuntime.Controls.MapView;
using MapView = Esri.ArcGISRuntime.UI.Controls.MapView;
namespace MilitaryPlanner.Controllers
{
    class BasemapGalleryController
    {
        private readonly MapView _mapView;
        private readonly BasemapGalleryView _basemapGalleryView;
        private ArcGISPortal _arcGisPortal;
        private string lastItemId;
        public BasemapGalleryController(MapView mapView)
        {
            _mapView = mapView;

            lastItemId = "";
            _basemapGalleryView = new BasemapGalleryView { ViewModel = { mapView = mapView } };

            var owner = Window.GetWindow(mapView);

            if (owner != null)
                _basemapGalleryView.Owner = owner;



            var task = ArcGISPortal.CreateAsync();
            task.ContinueWith(Initialize);

            Mediator.Register(Constants.ACTION_UPDATE_BASEMAP, DoUpdateBasemap);
        }

        public void Toggle()
        {
            _basemapGalleryView.ViewModel.Toggle();
        }
        //    Action<Task<TResult>>
        private async void Initialize(Task<ArcGISPortal> tp)
        {
            if (!tp.IsCompletedSuccessfully)
                return;
            _arcGisPortal = tp.Result;

            // Load portal basemaps
            // var result = await _arcGisPortal.ArcGISPortalInfo.SearchBasemapGalleryAsync();
            // REM PRA : avec la requete de base, pas de choix !

            string queryExpression = string.Format("tags:\"{0}\" access:public type: (\"web map\" NOT \"web mapping application\")", "");

            // Create a query parameters object with the expression and a limit of 10 results
            PortalQueryParameters queryParams = new PortalQueryParameters(queryExpression, 100);

            // Search the portal using the query parameters and await the results
            PortalQueryResultSet<PortalItem> findResult = await _arcGisPortal.FindItemsAsync(queryParams);

            // Get the items from the query results           
            if (findResult.TotalResultsCount > 0)
                _basemapGalleryView.ViewModel.Basemaps = new ObservableCollection<PortalItem>(findResult.Results);

        }

        private async void DoUpdateBasemap(object obj)
        {
            try
            {
                PortalItem item = obj as PortalItem;

                if (item != null && lastItemId != item.ItemId)
                {
                    // Create a Map using the web map (portal item).
                    Map webMap = new Map(item);
                    //  await
                    Task t = webMap.LoadAsync();//.Wait(); // necessaire sinon Basemap est vide
                    await t;

                    if (!t.IsCompletedSuccessfully)
                        return;

                    LayerCollection myCollection = new LayerCollection();
                    // on efface l'ancien fond
                    _mapView.Map.Basemap.BaseLayers = myCollection;//new LayerCollection();
                    if (_mapView.Map.AllLayers.Any(l => l.Id == "basemap"))
                    { // On a au moins un layer basemap à la mauvaise place, on va le changer, il est stocké en dehors de basemap, on va devoir le supprimer de sa place      

                        if (_mapView.Map.OperationalLayers.Any(l => l.Id == "basemap"))
                        {
                            LayerCollection layers = new LayerCollection();
                            foreach (Layer layer in _mapView.Map.OperationalLayers)
                            {
                                if (layer.Id != "basemap")//&& layer.Name.LongCount() > 0)
                                    layers.Add(layer.Clone());
                                else
                                    myCollection.Add(layer.Clone());
                            }
                            _mapView.Map.OperationalLayers = layers;
                        }


                        if (_mapView.Map.Basemap.ReferenceLayers.Any(l => l.Id == "basemap"))
                        {
                            LayerCollection layers = new LayerCollection();
                            foreach (Layer l in _mapView.Map.Basemap.ReferenceLayers) // TODO PRA ? inverser l'ordre des layers ?               
                            {
                                if (l.Id != "basemap")//&& l.Name.LongCount() > 0)
                                    layers.Add(l.Clone());
                                else
                                    myCollection.Add(l.Clone());
                            }
                            _mapView.Map.Basemap.ReferenceLayers = layers;
                        }

                    }
                    if (webMap.OperationalLayers.Any(l => l.Id == "basemap"))
                    {
                        foreach (Layer layer in webMap.OperationalLayers)
                        {
                            if (layer.Id == "basemap")
                                myCollection.Add(layer.Clone());
                        }

                    }
                    if (webMap.Basemap.ReferenceLayers.Any(l => l.Id == "basemap"))
                    {
                        foreach (Layer l in webMap.Basemap.ReferenceLayers)
                        {
                            if (l.Id == "basemap")
                                myCollection.Add(l.Clone());
                        }
                    }
                    foreach (Layer l in webMap.Basemap.BaseLayers)
                        myCollection.Add(l.Clone());

                    _mapView.Map.Basemap = new Basemap(myCollection, _mapView.Map.Basemap.ReferenceLayers);

                    lastItemId = item.ItemId;
                }
            }
            catch (Exception)
            {

            }

        }
    }
}