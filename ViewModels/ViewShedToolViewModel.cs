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
using System.Linq;
using System.Windows;
//using Esri.ArcGISRuntime.Controls;
using Esri.ArcGISRuntime.Geometry;
//using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Tasks.Geoprocessing;
using MilitaryPlanner.Helpers;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Tasks;

namespace MilitaryPlanner.ViewModels
{
    public class ViewShedToolViewModel : BaseToolViewModel
    {
        public RelayCommand StartViewShedCommand { get; set; }
        public RelayCommand CloseViewShedCommand { get; set; }

        public ViewShedToolViewModel()
        {
            StartViewShedCommand = new RelayCommand(OnStartViewShedCommandAsync);
            CloseViewShedCommand = new RelayCommand(OnCloseViewShedCommand);
            // _gpTask is now a Task<_gpTask> so we don't have wait here
            _gpTask =  GeoprocessingTask.CreateAsync(new Uri(ViewshedServiceUrl));
  //          _gpTask = t.Result;//  TODO PRA, on pourrait ne pas forcer l'attente par un Result.
        }

        private void OnCloseViewShedCommand(object obj)
        {
            IsToolOpen = false;

            if (_inputOverlay != null)
            {
                _inputOverlay.Graphics.Clear();
            }

            if (_viewshedOverlay != null)
            {
                _viewshedOverlay.Graphics.Clear();
            }
        }

        //viewshed
        private const string ViewshedServiceUrl = "http://sampleserver6.arcgisonline.com/arcgis/rest/services/Elevation/ESRI_Elevation_World/GPServer/Viewshed";

        private GraphicsOverlay _inputOverlay;
        private GraphicsOverlay _viewshedOverlay;
        private readonly Task<GeoprocessingTask> _gpTask;

        private bool _viewShedEnabled = true;
        public bool ViewShedEnabled
        {
            get
            {
                return _viewShedEnabled;
            }
            set
            {
                _viewShedEnabled = value;
                RaisePropertyChanged(() => ViewShedEnabled);
            }
        }

        private Visibility _viewShedProgressVisible = Visibility.Collapsed;
        public Visibility ViewShedProgressVisible
        {
            get
            {
                return _viewShedProgressVisible;
            }
            set
            {
                _viewShedProgressVisible = value;
                RaisePropertyChanged(() => ViewShedProgressVisible);
            }
        }

        private string _toolStatus = "";
        public string ToolStatus
        {
            get
            {
                return _toolStatus;
            }
            set
            {
                _toolStatus = value;
                RaisePropertyChanged(() => ToolStatus);
            }
        }

        private async void OnStartViewShedCommandAsync(object obj)
        {
            GeoprocessingJob myViewshedJob = null;
            try
                {
                _inputOverlay = mapView.GraphicsOverlays["inputOverlay"];
                _viewshedOverlay = mapView.GraphicsOverlays["ViewshedOverlay"];

                string txtMiles = obj as string;

                ViewShedEnabled = false;
                _inputOverlay.Graphics.Clear();
                _viewshedOverlay.Graphics.Clear();

                //get the user's input point
                var inputPoint = await mapView.SketchEditor.StartAsync(SketchCreationMode.Point, false); 

                ViewShedProgressVisible = Visibility.Visible;
                _inputOverlay.Graphics.Add(new Graphic() { Geometry = inputPoint });

                var parameter = new GeoprocessingParameters(GeoprocessingExecutionType.SynchronousExecute);
                parameter.OutputSpatialReference = mapView.SpatialReference;        

                // Create a new feature collection table based upon point geometries using the current map view spatial reference
                FeatureCollectionTable myInputFeatures = new FeatureCollectionTable(new List<Field>(), GeometryType.Point, mapView.SpatialReference);

                Feature myInputFeature = myInputFeatures.CreateFeature();

                // Assign a physical location to the new point feature based upon where the user clicked in the map view
                myInputFeature.Geometry = inputPoint;

                // Add the new feature with (x,y) location to the feature collection table
                await myInputFeatures.AddFeatureAsync(myInputFeature);

                parameter.Inputs.Add("Input_Observation_Point", new GeoprocessingFeatures(myInputFeatures));
                parameter.Inputs.Add("Viewshed_Distance ", new GeoprocessingLinearUnit(Convert.ToDouble(txtMiles), LinearUnits.Miles));
          
                // Create the job that handles the communication between the application and the geoprocessing task
                myViewshedJob = _gpTask.Result.CreateJob(parameter);// myViewshedTask.CreateJob(myViewshedParameters);
                
                    ToolStatus = "Processing on server...";
                  //  var result = await _gpTask.CreateJob(parameter);//ExecuteAsync(parameter);
                    // Execute analysis and wait for the results
                    GeoprocessingResult myAnalysisResult = await myViewshedJob.GetResultAsync();

                    if (myAnalysisResult == null || myAnalysisResult.Outputs /*.OutParameters*/ == null)// || !(result.OutParameters[0] is GPFeatureRecordSetLayer))
                        throw new ApplicationException("No viewshed graphics returned for this start point.");
                    // Get the results from the outputs
                    GeoprocessingFeatures myViewshedResultFeatures = (GeoprocessingFeatures)myAnalysisResult.Outputs["Viewshed_Result"];

                    // Add all the results as a graphics to the map
                    IFeatureSet myViewshedAreas = myViewshedResultFeatures.Features;
                    foreach (Feature myFeature in myViewshedAreas)
                    {
                        _viewshedOverlay.Graphics.Add(new Graphic(myFeature.Geometry));
                    }

                  
                    ToolStatus = "Finished processing. Retrieving results...";
                  //  var viewshedLayer = (GPFeatureRecordSetLayer)result.OutParameters[0];
                  //  _viewshedOverlay.Graphics.AddRange(viewshedLayer.FeatureSet.Features.OfType<Graphic>());
                    //~~
                }
                catch (Exception ex)
                {
                    // Display an error message if there is a problem
                    if (myViewshedJob.Status ==  JobStatus.Failed && myViewshedJob.Error != null)
                        MessageBox.Show("Executing geoprocessing failed. " + myViewshedJob.Error.Message, "Geoprocessing error");
                    else
                        MessageBox.Show("An error occurred. " + ex.ToString(), "Sample error");
                }
                finally
                {
                    // Indicate that the geoprocessing is not running
                    //   SetBusy(false);
                    ViewShedEnabled = true;
                    ViewShedProgressVisible = Visibility.Collapsed;
                }


            }

      
   //     }
    }
}
