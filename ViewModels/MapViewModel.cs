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

using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
//using Esri.ArcGISRuntime.Controls;
using Esri.ArcGISRuntime.Mapping;
//using Esri.ArcGISRuntime.Layers;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
//using Esri.ArcGISRuntime.Symbology.Specialized;
//using Esri.ArcGISRuntime.Tasks.Imagery;
using Microsoft.Win32;
using MilitaryPlanner.Behavior;
using MilitaryPlanner.Controllers;
using MilitaryPlanner.Helpers;
using MilitaryPlanner.Models;
using MilitaryPlanner.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Geometry = Esri.ArcGISRuntime.Geometry.Geometry;
//using MapView = Esri.ArcGISRuntime.Controls.MapView;
using MapView = Esri.ArcGISRuntime.UI.Controls.MapView;

namespace MilitaryPlanner.ViewModels
{
    public partial class MapViewModel : BaseViewModel, IDropable
    {
        private enum EditState
        {
            Create,
            DragDrop,
            Move,
            Tool,
            Edit,
            None
        };

        private Point _lastKnownPoint;
        private Point _pointOffset = new Point(); // psoiton du clic sur un moussebuttondown
        private MapView _mapView;
        private Map _map;
        private SimpleMessage _currentMessage;
        private EditState _editState = EditState.None;
        private MessageLayer _militaryMessageLayer;
        private TimeExtent _currentTimeExtent = new TimeExtent(DateTimeOffset.MinValue, DateTimeOffset.MaxValue); // TODO PRA casse la logique de HasTimeExtent
        private Mission _mission = new Mission();// Pour le xaml 
        private int _currentPhaseIndex = 0;
        private Geometry _beforeEditGeometry = null;

        /// <summary>
        /// Dictionary containing a message layer ID as the KEY and a list of military message ID's as the value
        /// </summary>
        private readonly Dictionary<string, List<string>> _phaseMessageDictionary = new Dictionary<string, List<string>>();

        public RelayCommand SetMapCommand { get; set; }
        public RelayCommand PhaseAddCommand { get; set; }
        public RelayCommand PhaseBackCommand { get; set; }
        public RelayCommand PhaseNextCommand { get; set; }

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand LoadCommand { get; set; }
        public RelayCommand MeasureCommand { get; set; }
        public RelayCommand CoordinateReadoutFormatCommand { get; set; }

        public RelayCommand StartViewShedCommand { get; set; }
        public RelayCommand ToggleViewShedToolCommand { get; set; }
        public RelayCommand ToggleGotoXYToolCommand { get; set; }
        public RelayCommand ToggleNetworkingToolCommand { get; set; }
        public RelayCommand ToggleBasemapGalleryCommand { get; set; }

        // controllers
        private GotoXYToolController _gotoXYToolController;
        private NetworkingToolController _networkingToolController;
        private ViewShedToolController _viewShedToolController;
        private CoordinateReadoutController _coordinateReadoutController;  // TODO PRA valeur non utilisée
        private BasemapGalleryController _basemapGalleryController;

        public MapViewModel()
        {
            Mediator.Register(Constants.ACTION_SELECTED_SYMBOL_CHANGED, DoActionSymbolChanged);
            Mediator.Register(Constants.ACTION_CANCEL, DoActionCancel);
            Mediator.Register(Constants.ACTION_DELETE, DoActionDelete);
            Mediator.Register(Constants.ACTION_DRAG_DROP_STARTED, DoDragDropStarted);
            Mediator.Register(Constants.ACTION_PHASE_NEXT, DoSliderPhaseNext);
            Mediator.Register(Constants.ACTION_PHASE_BACK, DoSliderPhaseBack);
            Mediator.Register(Constants.ACTION_SAVE_MISSION, DoSaveMission);
            Mediator.Register(Constants.ACTION_OPEN_MISSIONS, DoOpenMissions); // modif to allow multiples files
            Mediator.Register(Constants.ACTION_EDIT_MISSION_PHASES, DoEditMissionPhases);
            Mediator.Register(Constants.ACTION_EDIT_GEOMETRY, DoEditGeometry);
            Mediator.Register(Constants.ACTION_EDIT_REDO, DoEditRedo);
            Mediator.Register(Constants.ACTION_EDIT_UNDO, DoEditUndo);
            Mediator.Register(Constants.ACTION_CLONE_MISSION, DoCloneMission);
            Mediator.Register(Constants.ACTION_NEW_MISSION, DoNewMission);

            SetMapCommand = new RelayCommand(OnSetMap);
            PhaseAddCommand = new RelayCommand(OnPhaseAdd);
            PhaseBackCommand = new RelayCommand(OnPhaseBack);
            PhaseNextCommand = new RelayCommand(OnPhaseNext);

            SaveCommand = new RelayCommand(OnSaveCommand);
            LoadCommand = new RelayCommand(OnLoadCommand);
            MeasureCommand = new RelayCommand(OnMeasureCommand);

            CoordinateReadoutFormatCommand = new RelayCommand(OnCoordinateReadoutFormatCommand);

            ToggleViewShedToolCommand = new RelayCommand(OnToggleViewShedToolCommand);
            ToggleGotoXYToolCommand = new RelayCommand(OnToggleGotoXYToolCommand);
            ToggleNetworkingToolCommand = new RelayCommand(OnToggleNetworkingToolCommand);
            ToggleBasemapGalleryCommand = new RelayCommand(OnToggleBasemapGalleryCommand);
        }

        private void DoNewMission(object obj)
        {
            _mission = new Mission();// "Default Mission");
            _militaryMessageLayer./*ChildLayers.*/Clear();
            _phaseMessageDictionary.Clear();
            InitializeMapWithMission();
            if (_mission.PhaseList.Count < 1)
            {
                if (_mission.AddPhase("Phase 1"))
                {
                    Mediator.NotifyColleagues(Constants.ACTION_PHASE_ADDED, null);
                    RaisePropertyChanged(() => PhaseDescription);
                }
            }
        }

        private void OnToggleBasemapGalleryCommand(object obj)
        {
            _basemapGalleryController.Toggle();
        }

        private void DoEditUndo(object obj)
        {// todo pra verifier SketchEditor.IsActive -> IsEnabled ou IsEnabled et visible ?
            if (_mapView.SketchEditor.IsEnabled && _mapView.SketchEditor.UndoCommand.CanExecute(null))
                _mapView.SketchEditor.UndoCommand.Execute(null);
        }

        private void DoEditRedo(object obj)
        {// todo pra verifier SketchEditor.IsActive -> IsEnabled ou IsEnabled et visible ?
            if (_mapView.SketchEditor.IsEnabled && _mapView.SketchEditor.RedoCommand.CanExecute(null))
                _mapView.SketchEditor.RedoCommand.Execute(null);
        
        }

        // Ajout PRA from Example Name: SketchOnMap 
        private async Task<Graphic> GetGraphicAsync()
        {
            // Wait for the user to click a location on the map
            //Starts to edit Geometry based on specified SketchCreationMode with the SketchEditConfiguration that the geometry supports.
            // Probablement lié à l'état du SketchEditor !

            Geometry mapPoint = await _mapView.SketchEditor.StartAsync(SketchCreationMode.Point, false);

            if (mapPoint == null)  // ajout pra TODO PRA a tester
                return null;
            // Convert the map point to a screen point
            Point screenCoordinate = _mapView.LocationToScreen((MapPoint)mapPoint);

            // Identify graphics in the graphics overlay using the point  // TODO PRA semble un peu complexe comme moyen ...
            Task<IReadOnlyList<IdentifyGraphicsOverlayResult>> results =  _mapView.IdentifyGraphicsOverlaysAsync(screenCoordinate, 2, false);

            if (!results.IsCompleted )
                return null;
            // If results were found, get the first graphic
            Graphic graphic = null;
            IdentifyGraphicsOverlayResult idResult = results.Result[0];//.Resultresults[0];
            if (idResult != null && idResult.Graphics.Count > 0)
                graphic = idResult.Graphics[0];

            // Return the graphic (or null if none were found)
            return graphic;
        }



        /// <summary>
        /// On this command the currently selected geometry gets edited if it is a polyline or polygon
        /// Updates the military message with the new geometry during and after editing
        /// </summary>
        /// <param name="obj"></param>
        /// 
        private async void DoEditGeometry(object obj)  // obj est null
        {
            // todo pra verifier SketchEditor.IsActive -> IsEnabled ou IsEnabled et visible ?
            if (_mapView.SketchEditor.IsEnabled)//.IsActive)
            {
                //Complete -> CompleteCommand
                if (_mapView.SketchEditor.CompleteCommand.CanExecute(null))
                {
                    _mapView.SketchEditor.CompleteCommand.Execute(null);
                    _editState = EditState.None;
                    System.Diagnostics.Trace.WriteLine("DoEditGeometry   l216 EditState.None");
                    return;
                }
            }

            if (_currentMessage != null)
            {

                var tam = _currentMessage as TimeAwareMilitaryMessage ;// _mission.GetMessages(_currentMessage.Id).FirstOrDefault() as TimeAwareMilitaryMessage;//_mission.MilitaryMessages.FirstOrDefault(msg => msg.Id == _currentMessage.Id);

                if (tam != null)
                {
                    
                    // modif pra : reprise de Example Name: SketchOnMap private async void EditButtonClick(object sender, RoutedEventArgs e)
                 try
                    {
                        _beforeEditGeometry = tam.SymbolGeometry;
                        // Allow the user to select a graphic
                        Task<Graphic> editGraphic =  GetGraphicAsync();
                        if (!editGraphic.IsCompletedSuccessfully) 
                        { return; }
                        _editState = EditState.Edit;  // modif pra déplacé a apres le choix de l'objet
                        // Let the user make changes to the graphic's geometry, await the result (updated geometry)
                        // //editGraphic.Geometry.GeometryType == GeometryType.Point ? SketchCreationMode.Point
                        SketchEditConfiguration config = new SketchEditConfiguration
                        {
                            AllowMove = true
                        };
                        //    config.
                        Task<Geometry> newGeometry = _mapView.SketchEditor.//StartAsync(SketchCreationMode.Point, false);

                       StartAsync(editGraphic.Result.Geometry, SketchCreationMode.Point, config);


                        if (newGeometry.IsCompletedSuccessfully )
                        {
                            System.Diagnostics.Trace.WriteLine("DoEditGeometry   l251");
                            // Display the updated geometry in the graphic
                            //      editGraphic.Geometry = newGeometry.Result;
                            tam.SymbolGeometry = newGeometry.Result;
                            UpdateCurrentMessage(tam, newGeometry.Result);
                        }
                    }
             catch (TaskCanceledException)
                    {
                        // Ignore ... let the user cancel editing
                    }
  //                  catch (Exception ex)
                    {
                        // Report exceptions
                //   MessageBox.Show("Error editing shape: " + ex.Message);
                    }

                    /*        try
                             {
                                 var progress = new Progress<GeometryEditStatus>();

                                 progress.ProgressChanged += (a, ges) =>
                                 {
                                     UpdateCurrentMessage(tam, ges.NewGeometry);
                                 };

                                 _beforeEditGeometry = tam.SymbolGeometry;

                                var resultGeometry = await _mapView.SketchEditor.EditGeometryAsync(tam.SymbolGeometry, null, progress);

                                 if (resultGeometry != null)
                                 {
                                     tam.SymbolGeometry = resultGeometry;
                                     UpdateCurrentMessage(tam, resultGeometry);
                                 }
                             }
                             catch
                             {
                                 // ignored
                             }*/
                }
            }
        }

        [Obsolete]
        private void DoCloneMission(object obj)
        {
           return;
            // ancienne version : 
          /*  Mission cloneMission = _mission.DeepCopy();
            // update mission cloned
            Mediator.NotifyColleagues(Constants.ACTION_MISSION_CLONED, cloneMission); */
        }

        private void OnToggleNetworkingToolCommand(object obj)
        {
            _networkingToolController.Toggle();
        }

        private void OnToggleGotoXYToolCommand(object obj)
        {
            _gotoXYToolController.Toggle();
        }

        private void OnSaveCommand(object obj)
        {
            // file dialog
            var sfd = new SaveFileDialog
            {
                Filter = "Mission xml files (*.xml)|*.xml|Geomessage xml files (*.xml)|*.xml",
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == true)
            {
                Mediator.NotifyColleagues(Constants.ACTION_SAVE_MISSION, String.Format("{0}{1}{2}", sfd.FilterIndex, Constants.SAVE_AS_DELIMITER, sfd.FileName));
            }
        }

        private void OnLoadCommand(object obj)
        {
            var ofd = new OpenFileDialog
            {
                //         Filter = "xml files (*.xml)|*.xml",
                //     Filter = "xml files (*.xml)|*.*",
                RestoreDirectory = true,
                Multiselect = true // test pra 
            };

            if (ofd.ShowDialog() == true)
            {
              
           //       foreach (string FileName in ofd.FileNames)
                    Mediator.NotifyColleagues(Constants.ACTION_OPEN_MISSIONS, ofd.FileNames);

                //     Mediator.NotifyColleagues(Constants.ACTION_OPEN_MISSION, ofd.FileName);
            }
        }

        private string _coordinateReadout = "";
        public string CoordinateReadout
        {
            get
            {
                return _coordinateReadout;
            }

            set
            {
                _coordinateReadout = value;
                RaisePropertyChanged(() => CoordinateReadout);
            }
        }

        private void OnCoordinateReadoutFormatCommand(object obj)
        {
            Mediator.NotifyColleagues(Constants.ACTION_COORDINATE_READOUT_FORMAT_CHANGED, obj);
        }

        [Obsolete]
        private void DoEditMissionPhases(object obj)
        {
            // clone mission phases
            //var cloneMissionPhases = Utilities.DeepClone(_mission.PhaseList);
            Mission cloneMission = _mission.DeepCopy(); //Utilities.CloneObject(_mission) as Mission;

            // load edit mission phases dialog
            var editPhaseDialog = new EditMissionPhasesView();

            // update mission cloned
            Mediator.NotifyColleagues(Constants.ACTION_MISSION_CLONED, cloneMission);
            Mediator.NotifyColleagues(Constants.ACTION_PHASE_INDEX_CHANGED, _currentPhaseIndex);

            editPhaseDialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            if (editPhaseDialog.ShowDialog() == true)
            {
                _mission.PhaseList = cloneMission.PhaseList;
                while (_currentPhaseIndex >= _mission.PhaseList.Count)
                {
                    _currentPhaseIndex--;
                }
                OnCurrentPhaseIndexChanged();
                RaisePropertyChanged(() => PhaseDescription);
            }
        }

        public bool HasTimeExtent
        {
            get
            {
                if (CurrentTimeExtent != null &&
                     (CurrentTimeExtent.StartTime !=DateTimeOffset.MinValue|| CurrentTimeExtent.EndTime != DateTimeOffset.MaxValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public TimeExtent CurrentTimeExtent
        {
            get
            {
                return _currentTimeExtent;
            }
            set
            {
                _currentTimeExtent = value;
                RaisePropertyChanged(() => CurrentTimeExtent);
                RaisePropertyChanged(() => HasTimeExtent);
            }
        }

        // ajout pour le xaml 
        public DateTime StartTime
        {
            get { return _currentTimeExtent.StartTime.DateTime; }
            set { CurrentTimeExtent = new TimeExtent(new DateTimeOffset(value), _currentTimeExtent.EndTime); }
        }

        public DateTime EndTime
        {
            get { return _currentTimeExtent.EndTime.DateTime; }
            set { CurrentTimeExtent = new TimeExtent(_currentTimeExtent.StartTime, new DateTimeOffset(value)); }
        }


        public string PhaseDescription
        {
            get
            {
                if (/*_mission != null && */ CurrentPhaseIndex >= 0 && CurrentPhaseIndex < _mission.PhaseList.Count)
                {
                    var mp = _mission.PhaseList[CurrentPhaseIndex];
                    return String.Format("Phase : {0} \nStart : {1:yyyy/MM/dd HH:mm} \nEnd  : {2:yyyy/MM/dd HH:mm}", mp.Name, mp.VisibleTimeExtent.StartTime, mp.VisibleTimeExtent.EndTime);
                }

                return "Testing";
            }
        }

        private void OnToggleViewShedToolCommand(object obj)
        {
            _viewShedToolController.Toggle();
        }

        // Open files
        private void DoOpenMissions(object filenames )
        {
            string[] afileNames = filenames as string[];// ToString();


            // on doit effacer les anciens pas les actuels
                if (_mission._graphics != null && _mission._graphics.Any())   // Les objets graphiques de l'XML ESRI
                   _mission._graphics.Clear();

            //  _mapView.GraphicsOverlays.Remove()
            //  _tacticalMessageOverlay.Id = "_XML_ESRI";  // TODO PRA


            // mm.Layer.Id = "SHAPEFILE";


            if (_mission.Load(afileNames))
                {
                    InitializeMapWithMission();
                    RaisePropertyChanged(() => PhaseDescription);
                }
       
        }

        private void InitializeMapWithMission()
        {
            CurrentPhaseIndex = 0;

            Mediator.NotifyColleagues(Constants.ACTION_MISSION_LOADED, _mission);

            OnCurrentPhaseIndexChanged();  // va traiter tous les messages de la phase courante.

            var mms = _mission.GetMessages();  // TODO PRA pourquoi tous les messages et pas seulement ceux de la phase ?

            foreach (var mm in mms)
            {
                if (mm.IsTemporary && mm.Layer != null)
                {
                    mm.Layer.Id = "SHAPEFILE";
                    this._map.OperationalLayers.Add(mm.Layer);  // TODO PRA rem pra on n'efface pas les anciennes versions 
                _mission.Remove(mm);}
                Mediator.NotifyColleagues(Constants.ACTION_ITEM_WITH_GUID_ADDED, mm.Id);
            }

            if (_mission._graphics != null && _mission._graphics.Any()) // todo pra a effacer au reset 
            {
                GraphicsOverlay _tacticalMessageOverlay = new GraphicsOverlay();
                _tacticalMessageOverlay.Id = "_XML_ESRI";

                DictionarySymbolStyle mil2525DStyle =  DictionarySymbolStyle.CreateFromFileAsync(Constants.symbolFilePathMil2525d).Result;

                // Use the dictionary symbol style to render graphics in the overlay.
                _tacticalMessageOverlay.Renderer = new DictionaryRenderer(mil2525DStyle);

                foreach (var g in _mission._graphics)
                    _tacticalMessageOverlay.Graphics.Add(g);

                _mapView.GraphicsOverlays.Add(_tacticalMessageOverlay);
            }

        }

        private void DoSaveMission(object obj)
        {
            string param = obj.ToString();

            string fileName;
            int fileType = 1; // MISSION type

            if (param.Contains(Constants.SAVE_AS_DELIMITER))
            {
                var temp = param.Split(new[] { Constants.SAVE_AS_DELIMITER }, StringSplitOptions.None);
                fileType = Convert.ToInt32(temp[0]);
                fileName = temp[1];
            }
            else
            {
                fileName = param;
            }

            if (!String.IsNullOrWhiteSpace(fileName))
            {
                _mission.Save(fileName, fileType);
            }
        }

        private void DoSliderPhaseBack(object obj)
        {
            OnPhaseBack(null);
        }

        private void DoSliderPhaseNext(object obj)
        {
            OnPhaseNext(null);
        }

        public int CurrentPhaseIndex
        {
            get
            {
                return _currentPhaseIndex;
            }

            set
            {
                if (value != _currentPhaseIndex)
                {
                    _currentPhaseIndex = value;

                    RaisePropertyChanged(() => CurrentPhaseIndex);
                    RaisePropertyChanged(() => PhaseDescription);

                    OnCurrentPhaseIndexChanged();

                    Mediator.NotifyColleagues(Constants.ACTION_PHASE_INDEX_CHANGED, _currentPhaseIndex);
                }
            }
        }

        private void OnCurrentPhaseIndexChanged()
        {
            ClearMilitaryMessageLayer();

            // process military messages for current phase
            if (_mission.PhaseList.Any())
            {
                ProccessMilitaryMessages(_mission.PhaseList[CurrentPhaseIndex].VisibleTimeExtent);
            }
        }

        private void ClearMilitaryMessageLayer()
        {
            if (_militaryMessageLayer != null && _mapView != null)
            {
                _mapView.GraphicsOverlays.Remove(_militaryMessageLayer.graphicsOverlay);//.Id);////).Layers.Remove(_militaryMessageLayer.Id);
                _militaryMessageLayer = null;
                AddNewMilitaryMessagelayer();
            }
            // on doit effacer les anciens pas les actuels
         //   if (_mission._graphics != null && _mission._graphics.Any())   // Les objets graphiques de l'XML ESRI
          //      _mission._graphics.Clear();

            //  _mapView.GraphicsOverlays.Remove()
            //  _tacticalMessageOverlay.Id = "_XML_ESRI";  // TODO PRA


            // mm.Layer.Id = "SHAPEFILE";
            //this._map.OperationalLayers.Add(mm.Layer); // TODO PRA
        }

        private void AddNewMilitaryMessagelayer()
        {
            if (_militaryMessageLayer == null)
            {
                _militaryMessageLayer = new MessageLayer(Guid.NewGuid().ToString("D"));// MessageLayer.Type.Mil2525c, null,/*SymbolDictionaryType.Mil2525c*/ /*) { Id = */);// };
                _mapView.GraphicsOverlays/*Map.OperationalLayers*/.Add(_militaryMessageLayer.graphicsOverlay);     // ).Map.OperationalLayers.Add(_militaryMessageLayer.);//Layers.Add(_militaryMessageLayer);
            }
        }

        private static  bool Intersects(TimeExtent t1, TimeExtent t2)
        { 
        if ( (t1.EndTime < t2.StartTime) || (t1.StartTime > t2.EndTime)) 
                return false;
            return true; 
        }


        private void ProccessMilitaryMessages(TimeExtent timeExtent)
        {
            // TODO PRA a adapter.
            // get a list of military messages that intersect this time extent
            //           var militaryMessages = _mission.MilitaryMessages.Where(m => m.VisibleTimeExtent.Intersects(timeExtent)).ToList();
            var militaryMessages = _mission.GetMessages(timeExtent);//.  GetMessages().Where(m => Intersects(timeExtent, (m as TimeAwareMilitaryMessage).VisibleTimeExtent));//.EndTime > timeExtent.StartTime && (m as TimeAwareMilitaryMessage).VisibleTimeExtent.StartTime < timeExtent.EndTime).ToList(); // (timeExtent)) ).ToList();

            var phaseID = _mission.PhaseList[CurrentPhaseIndex].ID;

            foreach (var mesg in militaryMessages)
            {
              //  TimeAwareMilitaryMessage mm = mesg as TimeAwareMilitaryMessage;
             /*    if (mm.ContainsKey(Message.ControlPointsPropertyName))
                {
                    throw new NotImplementedException();
                    // load the correct control points for the current phase
                   if (mm.PhaseControlPointsDictionary.ContainsKey(phaseID))
                    {
                        mm[Message.ControlPointsPropertyName] = mm.PhaseControlPointsDictionary[phaseID];
                    }
                    else
                    {
                        Console.WriteLine(@"ERROR : Control points not found for phase id {0}", phaseID);  //, => ;
                    
                }}*/

                if (mesg.ContainsKey(Message.ActionPropertyName))  // TODO PRA et pourquoi pas de add sinon ? pourquoi n'a t'on pas un create plutot ?
                {
           //         mm[Message.ActionPropertyName] = Constants.MSG_ACTION_UPDATE;  
                }

                if (ProcessMessage(_militaryMessageLayer, mesg))
                {
                    Mediator.NotifyColleagues(Constants.ACTION_ITEM_WITH_GUID_ADDED, mesg.Id);
                }
            }

            DoCloneMission(null);
        }

        private void DoDragDropStarted(object obj)
        {
            _editState = EditState.DragDrop;
    //        System.Diagnostics.Trace.WriteLine("DoDragDropStarted   EditState.DragDrop;");
        }

        private void OnPhaseNext(object param)
        {
            if (CurrentPhaseIndex < _mission.PhaseList.Count - 1)
            {
                // clear any selections
                ClearSelectedMessage();

                CurrentPhaseIndex++;
            }
        }

        private void OnPhaseBack(object param)
        {
            if (CurrentPhaseIndex > 0)
            {
                // clear any selections
                ClearSelectedMessage();

                CurrentPhaseIndex--;
            }
        }

        private void OnPhaseAdd(object param)
        {
            if (_mission.AddPhase("Default Phase Name"))
            {
                Mediator.NotifyColleagues(Constants.ACTION_PHASE_ADDED, null);

                ExtendTimeExtentOnMilitaryMessages(CurrentPhaseIndex);

                CurrentPhaseIndex = _mission.PhaseList.Count - 1;
            }
        }

        private void ExtendTimeExtentOnMilitaryMessages(int currentPhaseIndex)
        {
            // update any military message time extent to the next phase if current extent END matches current phase time extent END
            // this will allow the current phase symbols with unedited time extents to be included in the next phase

            var currentTimeExtentEnd = _mission.PhaseList[currentPhaseIndex].VisibleTimeExtent.EndTime;
            var nextTimeExtentEnd = _mission.PhaseList[currentPhaseIndex + 1].VisibleTimeExtent.EndTime;
            var nextPhaseID = _mission.PhaseList[currentPhaseIndex + 1].ID;

            var currentPhaseMessages = _mission.GetMessages().Where(m => (m as TimeAwareMilitaryMessage).VisibleTimeExtent.EndTime == currentTimeExtentEnd).ToList();

            foreach (var msg in currentPhaseMessages)
            {
                var tam = msg as TimeAwareMilitaryMessage;
                //   tam.VisibleTimeExtent.EndTime = nextTimeExtentEnd;
                tam.VisibleTimeExtent = new TimeExtent(tam.VisibleTimeExtent.StartTime, nextTimeExtentEnd);

                if (tam.ContainsKey(Message.ControlPointsPropertyName))
                { //todo pra 
            //        throw new NotImplementedException();
                    /*     if (tam.PhaseControlPointsDictionary.ContainsKey(nextPhaseID))
                         {
                             tam.PhaseControlPointsDictionary[nextPhaseID] = tam[Message.ControlPointsPropertyName];
                         }
                         else
                         {
                             tam.PhaseControlPointsDictionary.Add(nextPhaseID, tam[Message.ControlPointsPropertyName]);
                         }*/ //TODO PRA modif PhaseControlPointsDictionary
                }
            }
        }

        private Symbol _lineSymbol;
        private GraphicsOverlay _graphicsOverlay;
        //      private MensurationTask _mensurationTask;

        private async void OnMeasureCommand(object param)
        {// todo TEST PRA sur IsActive
            if (_editState == EditState.None && _mapView != null && !_mapView.SketchEditor.IsEnabled /*.IsActive*/)
            {// SimpleLineStyle => SimpleLineSymbolStyle
                _lineSymbol = new SimpleLineSymbol() { Color = System.Drawing.Color.Red, Style = SimpleLineSymbolStyle.Solid, Width = 2 } as Symbol;

                _graphicsOverlay = _mapView.GraphicsOverlays["graphicsOverlay"];

                // World Topo Map doesn't support mensuration
                //var temp = _mapView.Map.Layers["World Topo Map"];
                //var temp = _mapView.Map.Layers["MensurationMapServiceLayer"];

                // _mensurationTask = new MensurationTask(new Uri((temp as ArcGISTiledLayer).ServiceUri));
                // TODO PRA coder cette partie
                // lets do a basic distance measure
                try
                {
                    // todo pra étrange la c'est segment DrawShape.LineSegment _> SketchCreationMode
                    Polyline line = await RequestUserShape(SketchCreationMode.Polyline, _lineSymbol) as Polyline;

                    // Requesting shape cancelled
                    if (line == null)
                        return;
                    /*
                    var parameters = new MensurationLengthParameters()
                    {
                        AngularUnit = AngularUnits.Degrees,
                        LinearUnit = LinearUnits.Meters
                    };

                    var result = await _mensurationTask.DistanceAndAngleAsync(line.Parts.First().StartPoint,line.Parts.First().EndPoint, parameters);

                    // dans le .chm
                    // MapPoint start = new MapPoint(-4.494677, 48.384472, 24.772694, SpatialReferences.Wgs84);
                    // MapPoint end = new MapPoint(-4.495646, 48.384377, 58.501115, SpatialReferences.Wgs84);
                    //_distanceMeasurement = new LocationDistanceMeasurement(start, end);
                    if (result.Distance != null)
                    {
                        ShowResults(result, "Measure results");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Mensuration Error");
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensuration Error");
                }
                finally
                {
                    _graphicsOverlay.Graphics.Clear();
                }
            }
        }

        // Retrieve the given shape type from the user
        //TODO TEST PRA
        // 
        // DrawShape -> SketchCreationMode
        private async Task<Geometry> RequestUserShape(SketchCreationMode drawShape, Symbol symbol)
        {
            if (_mapView == null)
                return null;

            try
            {
                _graphicsOverlay.Graphics.Clear();
                //SketchCreationMode
                var shape = await _mapView.SketchEditor.StartAsync(drawShape, false);//.RequestShapeAsync(drawShape, symbol);

                _graphicsOverlay.Graphics.Add(new Graphic(shape, symbol));
                return shape;
            }
            catch (TaskCanceledException)
            {
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Shape Drawing Error");
                return null;
            }
        }

        // Show results from mensuration task in string format
        private void ShowResults(object result, string caption = "")
        {
            //todo pra coder
            /*
            StringBuilder sb = new StringBuilder();

            if (result is MensurationPointResult)
            {
                MensurationPointResult pointResult = (MensurationPointResult)result;

                if (pointResult.Point != null)
                {
                    sb.Append(pointResult.Point);
                    sb.Append("\n");
                }
            }
            else if (result is MensurationHeightResult)
            {
                var heightResult = (MensurationHeightResult)result;

                if (heightResult.Height != null)
                {
                    sb.Append("Height\n");
                    sb.AppendFormat("Value:\t\t{0}\n", heightResult.Height.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", heightResult.Height.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", heightResult.Height.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", heightResult.Height.LinearUnit);
                    sb.Append("\n");
                }
            }
            else if (result is MensurationLengthResult)
            {
                var lengthResult = (MensurationLengthResult)result;

                if (lengthResult.Distance != null)
                {
                    sb.Append("Distance\n");
                    sb.AppendFormat("Value:\t\t{0}\n", lengthResult.Distance.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", lengthResult.Distance.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", lengthResult.Distance.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", lengthResult.Distance.LinearUnit);
                    sb.Append("\n");
                }
                if (lengthResult.AzimuthAngle != null)
                {
                    sb.Append("Azimuth Angle\n");
                    sb.AppendFormat("Value:\t\t{0}\n", lengthResult.AzimuthAngle.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", lengthResult.AzimuthAngle.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", lengthResult.AzimuthAngle.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", lengthResult.AzimuthAngle.AngularUnit);
                    sb.Append("\n");
                }
                if (lengthResult.ElevationAngle != null)
                {
                    sb.Append("Elevation Angle\n");
                    sb.AppendFormat("Value:\t\t{0}\n", lengthResult.ElevationAngle.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", lengthResult.ElevationAngle.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", lengthResult.ElevationAngle.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", lengthResult.ElevationAngle.AngularUnit);
                    sb.Append("\n");
                }
            }
            else if (result is MensurationAreaResult)
            {
                var areaResult = (MensurationAreaResult)result;

                if (areaResult.Area != null)
                {
                    sb.Append("Area\n");
                    sb.AppendFormat("Value:\t\t{0}\n", areaResult.Area.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", areaResult.Area.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", areaResult.Area.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", areaResult.Area.AreaUnit);
                    sb.Append("\n");
                }

                if (areaResult.Perimeter != null)
                {
                    sb.Append("Perimeter\n");
                    sb.AppendFormat("Value:\t\t{0}\n", areaResult.Perimeter.Value);
                    sb.AppendFormat("Display Value:\t{0}\n", areaResult.Perimeter.DisplayValue);
                    sb.AppendFormat("Uncertainty:\t{0}\n", areaResult.Perimeter.Uncertainty);
                    sb.AppendFormat("Unit:\t\t{0}\n", areaResult.Perimeter.LinearUnit);
                    sb.Append("\n");
                }
            }

            MessageBox.Show(sb.ToString(), caption); */
        }

        private void OnSetMap(object param)  // lorsque l'on clic sur l'onglet map
        {
            var mapView = param as MapView;

            if (mapView == null)
                return;

            if (_mapView != null)
                return;

            _mapView = mapView;
            _map = mapView.Map;

            if (_map.LoadStatus == LoadStatus.FailedToLoad) // MODIF PRA
            {
              //  const string filePath = @"Data\Basemap.tpk";
                Uri myUri = new Uri(Constants.LocalBasemap);
                if (File.Exists(Constants.LocalBasemap))
                {
                    var localTiledLayer = new ArcGISTiledLayer(myUri);//ArcGISLocalTiledLayer (filePath) modif => 100
                    localTiledLayer.Id = @"LocalBasemap";   // .ID modif => 100
                   // await
                   localTiledLayer.LoadAsync().Wait();//.InitializeAsync(); modif => 100  // TODO PRA 
                    Map myMap = new Map(_map.SpatialReference);// SpatialReferences.Wgs84);// 54024));//
                    // TODO PRA :je pige pas avec : BasemapStyle.ArcGISTerrain) cela ne fonctionne pas, la carte n'est pas chargée.
                    // en revanche, avec un SpatialReference si (pourtant il est au hasaerd !

                    myMap.InitialViewpoint = _map.InitialViewpoint;
                    myMap.OperationalLayers.Add(localTiledLayer);
              //      var un = myMap.LoadStatus;
              //      var deux = myMap.LoadError;
              //      var trois = localTiledLayer.LoadError;
              //      var quatre = localTiledLayer.LoadStatus;
                 
                    mapView.Map = myMap;
                    _map = myMap;
                    //     mapView.Map.Basemap.BaseLayers.Add(localTiledLayer); // modif  FocusMapView.Map.AllLayers.Map.Layers.Add(localTiledLayer);
                }



            }


            mapView.MouseLeftButtonDown += mapView_MouseLeftButtonDown;
            mapView.MouseLeftButtonUp += mapView_MouseLeftButtonUp;
            mapView.MouseMove += mapView_MouseMove;

            // setup any controllers that use the map view
            _gotoXYToolController = new GotoXYToolController(mapView, this);
            _networkingToolController = new NetworkingToolController(mapView, this);
            _viewShedToolController = new ViewShedToolController(mapView, this);
            _coordinateReadoutController = new CoordinateReadoutController(mapView, this); // TODO PRA est il utilisé
            _basemapGalleryController = new BasemapGalleryController(mapView);

            // add default message layer
            AddNewMilitaryMessagelayer(); // TODO PRA  PK il est vide ?

            if (_mission.PhaseList.Count < 1)
            {
                if (_mission.AddPhase("Phase 1"))
                {
                    Mediator.NotifyColleagues(Constants.ACTION_PHASE_ADDED, null);
                    RaisePropertyChanged(() => PhaseDescription);
                }
            }
        }

        void mapView_MouseMove(object sender, MouseEventArgs e)
        {
            if (_map == null || _editState == EditState.Tool || _editState == EditState.Edit)
                return;
      //      System.Diagnostics.Trace.WriteLine("mapView_MouseMove");
            _lastKnownPoint = e.GetPosition(_mapView);

            var adjustedPoint = AdjustPointWithOffset(_lastKnownPoint);

            //if a selected symbol, move it
            if (_editState == EditState.Move && e.LeftButton == MouseButtonState.Pressed)
                UpdateCurrentMessage(_mapView.ScreenToLocation(adjustedPoint));

        }

        private Point AdjustPointWithOffset(Point lastKnownPoint)
        {
            return new Point(lastKnownPoint.X + _pointOffset.X, lastKnownPoint.Y + _pointOffset.Y);
        }

        void mapView_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_editState == EditState.Move)
            {
                _mapView.ReleaseMouseCapture();  // modif pra 
                _editState = EditState.None;}
            System.Diagnostics.Trace.WriteLine("mapView_MouseLeftButtonUp " + EditState.None.ToString());
        }

        async void mapView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_editState == EditState.Create || _editState == EditState.Tool || _editState == EditState.Edit)
                return;
            System.Diagnostics.Trace.WriteLine("mapView_MouseLeftButtonDown start" + EditState.None.ToString());
            if (_editState == EditState.None)
            {  
                // hit test on message layer
                if (_militaryMessageLayer != null  )//&& _militaryMessageLayer.graphicsOverlay.Graphics.Any()) // PRA ajout de la deuxieme partie
                {
                    var b = _militaryMessageLayer.graphicsOverlay.Graphics.Any();
                    var c = _militaryMessageLayer.graphicsOverlay.Graphics.Count ;
                    
                    IdentifyGraphicsOverlayResult result = null;
                    
                    try
                    {
                        // Identify the tapped graphics
                        // REM PRA : un dernier int peut limiter le resultat !
                        result = await _mapView.IdentifyGraphicsOverlayAsync(_militaryMessageLayer.graphicsOverlay, e.GetPosition(_mapView), 2, false);

                    }
                    catch (Exception ex)
                    {
              //          MessageBox.Show(e.ToString(), "Error");
                    }

                    // Return if there are no results
                    if (result == null || result.Graphics.Count < 1)
                    {
                        return;
                    }


                    ClearSelectedMessage();



                //    await identifyGraphicsOverlayResult;
               //     if (identifyGraphicsOverlayResult.IsCompletedSuccessfully  ) 
                    {
                        Graphic graphic = result.Graphics.FirstOrDefault(); //identifyGraphicsOverlayResult.Result != null ? identifyGraphicsOverlayResult.Result.Graphics[0] : null;
                //        var result = identifyGraphicsOverlayResult.Result;
        
                      //  if (graphic != null)
                        { 
                        _pointOffset = GetMessageOffset(graphic, e.GetPosition(_mapView));
                        SelectMessageGraphic(graphic);
                        _editState = EditState.Move;
                            _mapView.CaptureMouse();// modif pra .ReleaseMouseCapture(); // test pra on commente
            //                System.Diagnostics.Trace.WriteLine("mapView_MouseLeftButtonDown EditState.Move select");
                        }
                    }
                }
            }
           // System.Diagnostics.Trace.WriteLine("mapView_MouseLeftButtonDown End" + EditState.None.ToString());
        }

        private void ClearSelectedMessage()
        {
            if (_currentMessage != null)
            {
                SelectMessage(_currentMessage, false);
                CurrentTimeExtent = null;
            }
        }

        private void SelectMessageGraphic(Graphic graphic)
        {
            if (graphic == null)
                return;

            if (graphic.Attributes.ContainsKey(Message.IdPropertyName))  // C'est le symbol qui est retourné, du coup, on n'a pas les informations !
            {
                var retour  = _militaryMessageLayer.GetMessage(graphic.Attributes[Message.IdPropertyName].ToString());
                var selectedMessage = retour.FirstOrDefault();// TODO PRA et si plusieurs ,
                SelectMessage(selectedMessage, true);

                UpdateCurrentTimeExtent(selectedMessage);
            }
        }

        private void UpdateCurrentTimeExtent(SimpleMessage selectMessage)  // TODO PRA : a t'on trop de changement ?
        {
            TimeAwareMilitaryMessage tam = selectMessage as TimeAwareMilitaryMessage;
            TimeExtent timeExtent = null;
            if (tam != null)
                timeExtent = tam.VisibleTimeExtent;

            if (timeExtent != null && (timeExtent.StartTime != DateTimeOffset.MinValue && timeExtent.EndTime != DateTimeOffset.MaxValue))
                CurrentTimeExtent = timeExtent;
            else
            {// on recherche le timeExtent de la phase qui contient le message

                var pl = _mission.PhaseList.Where(pl => pl.GetMessages(selectMessage.Id).Any());
               int n = pl.Count();// TMP PRA
                CurrentTimeExtent = pl.FirstOrDefault().VisibleTimeExtent; // TODO PRA et si plusieurs ?
            }
   //         var mm = _mission.GetMessages(selectMessage.Id).FirstOrDefault();//.MilitaryMessages.First(m => m.Id == selectMessage.Id);

     //     if (mm != null)
     //           CurrentTimeExtent = (mm as TimeAwareMilitaryMessage).VisibleTimeExtent;

        }

        private Point GetMessageOffset(Graphic graphic, Point screenPoint)
        {
            var resultPoint = new Point();

            if (graphic == null || _mapView == null)
                return resultPoint;

            if (graphic.Geometry.GeometryType == GeometryType.Point)
            {
                var mp = graphic.Geometry as MapPoint;

                if (mp != null)
                {
                    var point = _mapView.LocationToScreen(mp);

                    resultPoint.X = point.X - screenPoint.X;
                    resultPoint.Y = point.Y - screenPoint.Y;
                }
            }

            return resultPoint;
        }

        private async Task<IdentifyGraphicsOverlayResult> HitTestMessageLayerAsync(MouseButtonEventArgs e)
        {
            if (_mapView != null && _militaryMessageLayer != null && _militaryMessageLayer.graphicsOverlay.Graphics.Any()) // modif pra ajout du test sur l'overlay
            {
                // TODO PRA verifier par rapport à l'origine
                //         var value = await

                return  await _mapView.IdentifyGraphicsOverlayAsync(_militaryMessageLayer.graphicsOverlay, e.GetPosition(_mapView), 2, false);//.WaitAsync();

      //          return value;
  
               /*foreach (var subLayer in _militaryMessageLayer.ChildLayers)
                {
                     var messageSubLayer = subLayer as MessageSubLayer;
                      if(messageSubLayer != null)
                      {
                          var graphic = await messageSubLayer.HitTestAsync(_mapView, e.GetPosition(_mapView));
                          if (graphic != null)
                              return graphic;
                      }  
                }*/
            }

            return null;
        }

        private void SelectMessage(SimpleMessage message, bool isSelected)
        {
            if (_militaryMessageLayer == null || message == null)
                return;

            _currentMessage = isSelected ? message : null;

            var msg = new SimpleMessage(message.Id, true);

            if (_militaryMessageLayer.ProcessMessage(msg, isSelected ? MessageLayer.MessageAction.select /*MilitaryMessageAction.Select */ : MessageLayer.MessageAction.un_select))  //TODO PRA ?
            {
            }
        }

        private void UpdateCurrentMessage(MapPoint mapPoint)
        {
            if (_currentMessage != null && _militaryMessageLayer != null)
            {
                var msg = new SimpleMessage(_currentMessage.Id,true);//, Message.MessageType.position_report /*MilitaryMessageType.PositionReport*/, MessageLayer.MessageAction.update /*MilitaryMessageAction.Update, new List<MapPoint>() { mapPoint }*/);
          //      System.Diagnostics.Trace.WriteLine("UpdateCurrentMessage");
                msg.Add(Message.ControlPointsPropertyName, mapPoint.ToJson());//.ToString());
        //        System.Diagnostics.Trace.WriteLine("UpdateCurrentMessage");
                if (_militaryMessageLayer.ProcessMessage(msg, MessageLayer.MessageAction.update))//.UpdateMessage(msg, mapPoint))
                {
            //        UpdateMilitaryMessageControlPoints(msg); 

                    DoCloneMission(null);
                }
            }
        }

        private void UpdateCurrentMessage(TimeAwareMilitaryMessage tam, Geometry geometry)
        {
            var cpts = string.Empty;

            // TODO find a way to determine if polyline map points need adjustment based on symbol being drawn

            List<MapPoint> mpList = null;

            Polyline polyline = geometry as Polyline;

            if (polyline != null)
            {
                if (tam.symbolProperties.SymbolID.Contains("POLA") //[Message.SicCodePropertyName]
                                                                  ||  // bof pas très propre
                   tam.symbolProperties.SymbolID.Contains("PPA"))
                {
                    mpList = AdjustMapPoints(polyline, SketchCreationMode.Arrow);
                }
                else
                {
                    mpList = AdjustMapPoints(polyline, SketchCreationMode.Polyline);
                }
            }
            else
            {
                var polygon = geometry as Polygon;

                if (polygon != null)
                {
                    mpList = new List<MapPoint>();
                    /*  foreach (var part in polygon.Parts)
                      {
                          mpList.AddRange(part.GetPoints());// part.SelectMany(m => m.Points));// part..ToList());
                          //part.GetPoints());
                      }*/
                    mpList.AddRange(polygon.Parts.SelectMany(m => m.Points));
                }
            }

            if (mpList != null)
            {

                //TODO PRA directement tam ?
                var msg = new SimpleMessage(tam.Id,true);

                msg.Add(Message.ControlPointsPropertyName,mpList.ToString());
                tam[Message.ControlPointsPropertyName] = msg[Message.ControlPointsPropertyName];
                //TODO PRA 
                if (_militaryMessageLayer.ProcessMessage(msg, MessageLayer.MessageAction.update))//.UpdateMilitaryMessage(msg,mpList, _mission.PhaseList[CurrentPhaseIndex].ID))
                {
    //                UpdateMilitaryMessageControlPoints(msg);

                    DoCloneMission(null);
                }
            }
        }

        private void UpdateMilitaryMessageControlPoints(/*MilitaryMessage*/ Message msg)
        {
            var tam = _mission.GetMessages(msg.Id).FirstOrDefault();//.MilitaryMessages.First(m => m.Id == msg.Id);

            if (tam != null)
            {
      //          (tam as TimeAwareMilitaryMessage).StoreControlPoints(_mission.PhaseList[CurrentPhaseIndex].ID, msg);
            }
        }

        private void RemoveMessage(SimpleMessage message)
        {   // TODO PRA faire plus simple ?
   //         var msg = new Message(message.Id, Message.MessageType.position_report/*MilitaryMessageType.PositionReport*/, Message.MessageAction.remove);//MilitaryMessageAction.Remove);
            var msg2 = _mission.GetMessages(message.Id).FirstOrDefault();


            // remove from visible layer
            _militaryMessageLayer.ProcessMessage(msg2, MessageLayer.MessageAction.remove);

           
            RemoveMessageFromPhase(CurrentPhaseIndex, msg2 as TimeAwareMilitaryMessage);// _mission.MilitaryMessages.First(m => m.Id == message.Id));

            DoCloneMission(null);
        }

        private void RemoveMessageFromPhase(int phaseIndex, TimeAwareMilitaryMessage tam)
        {
            // check if message is only is this phase
            var phaseTimeExtent = _mission.PhaseList[phaseIndex].VisibleTimeExtent;

            if (tam.VisibleTimeExtent.StartTime >= phaseTimeExtent.StartTime && tam.VisibleTimeExtent.EndTime <= phaseTimeExtent.EndTime)
            {
                // contained in this phase only, remove completely
                _mission.Remove(tam);

                Mediator.NotifyColleagues(Constants.ACTION_ITEM_WITH_GUID_REMOVED, tam.Id);
                return;
            }
            else if (tam.VisibleTimeExtent.StartTime >= phaseTimeExtent.StartTime && tam.VisibleTimeExtent.EndTime > phaseTimeExtent.EndTime)
            {
                // message starts in this phase but goes into next phase
                // update start with next phase Start
                if (phaseIndex < _mission.PhaseList.Count - 1)
                {
                    //    tam.VisibleTimeExtent.StartTime = _mission.PhaseList[phaseIndex + 1].VisibleTimeExtent.StartTime;
                    tam.VisibleTimeExtent = new TimeExtent(_mission.PhaseList[phaseIndex + 1].VisibleTimeExtent.StartTime, tam.VisibleTimeExtent.EndTime);
                }
            }
            else if (tam.VisibleTimeExtent.StartTime < phaseTimeExtent.StartTime)
            {
                // message starts in previous phase, update END to previous phase END
                if (phaseIndex > 0)
                {
                    //         tam.VisibleTimeExtent.EndTime = _mission.PhaseList[phaseIndex - 1].VisibleTimeExtent.EndTime;
                    tam.VisibleTimeExtent = new TimeExtent(tam.VisibleTimeExtent.StartTime, _mission.PhaseList[phaseIndex - 1].VisibleTimeExtent.EndTime);
                }
            }
        }

        private SymbolViewModel _selectedSymbol;
        //      private readonly string _geometryType = String.Empty;


        // au moins un element traité => true
        private bool ProcessMessage(MessageLayer messageLayer, SimpleMessage msg)
        {
            if (messageLayer != null && msg != null)
            {
                TimeAwareMilitaryMessage tam = msg as TimeAwareMilitaryMessage;

                Message message  = msg as Message;
                bool result = false ;
                if (tam != null)
                    result = messageLayer.ProcessMessage(tam, MessageLayer.MessageAction.create);
                else if (message != null)
                {
                    //  pas necessaire car on a mis les SubMessages dans la phase 
                    //         foreach (SimpleMessage sm in message.SubMessages)
                    //             result = result || messageLayer.ProcessMessage(sm, MessageLayer.MessageAction.create); // todo pra  composition sur le res

                }
                else 
                    result = messageLayer.ProcessMessage(msg, MessageLayer.MessageAction.create);

                //       if (!result)
                //         return false; // todo pra   ajout pra si le message a un pb ...

                if (!_phaseMessageDictionary.ContainsKey(messageLayer.Id))
                    _phaseMessageDictionary.Add(messageLayer.Id, new List<string>());

                if (!_phaseMessageDictionary[messageLayer.Id].Contains(msg.Id))// add         
                    _phaseMessageDictionary[messageLayer.Id].Add(msg.Id);

                DoCloneMission(null);

                return result;
            }

            return false;
        }

        private void DoActionDelete(object obj)
        {
            // remove any selected messages
            if (_currentMessage != null && _editState != EditState.Edit)
            {
                // remove message
                RemoveMessage(_currentMessage);

                CurrentTimeExtent = null;
            }
        }

        private void DoActionCancel(object obj)
        {
            if (_mapView != null)
            {
                if (_mapView.SketchEditor.CancelCommand.CanExecute(null))
                {
                    _mapView.SketchEditor.CancelCommand.Execute(null);
                    RestoreGeometry();
                }
            }

            if (_editState == EditState.Create || _editState == EditState.Edit)
            {
                _editState = EditState.None;
                System.Diagnostics.Trace.WriteLine("DoActionCancelEditState.Move select");
            }
        }

        private void RestoreGeometry()
        {
            if (_currentMessage != null && _beforeEditGeometry != null)
            {
                var tam = _mission.GetMessages(_currentMessage.Id).FirstOrDefault();//.MilitaryMessages.FirstOrDefault(msg => msg.Id == _currentMessage.Id);

                if (tam != null)
                {
                    UpdateCurrentMessage(tam as TimeAwareMilitaryMessage, _beforeEditGeometry);
                    _beforeEditGeometry = null;
                }
            }
        }

        private async void DoActionSymbolChanged(object param)  // Pourquoi la selection d'un symbole sur la palette 
                                                                // fait quelque chose ici ? ne devrait on pas avoir plutot
                                                                // cela sur un drag n drop ?
        {
            _selectedSymbol = param as SymbolViewModel;

            //Cancel editing if started
            if (_mapView.SketchEditor.CancelCommand.CanExecute(null))
                _mapView.SketchEditor.CancelCommand.Execute(null);


            if (_selectedSymbol != null)
            {
                //    Dictionary<string, string> values = (Dictionary<string, string>)_selectedSymbol.Model.Values;
                //   _geometryType = values["GeometryType"]; 
                // REM PRA  values["GeometryType"] lance une exception si la valeur n'est pas trouvée
                // de plus ce n'est plus la catégorie mais SymbolClasses (valeurs "3", "4" ou "5")

                // DrawShape drawShape = DrawShape.Point;
                /*  SketchCreationMode drawShape = SketchCreationMode.Point;
                   switch (_geometryType)
                   {
                       case "Point":
                           drawShape = SketchCreationMode.Point;
                           break;
                       case "Line":
                           drawShape = SketchCreationMode.Polyline;
                           break;
                       case "Polygon":
                           drawShape = SketchCreationMode.Polygon;
                           break;
                       default:
                           drawShape = SketchCreationMode.Point;
                           break;
                   }*/

                try
                {
                    // get geometry from editor
                    //  var geometry = await _mapView.SketchEditor.RequestShapeAsync(drawShape);
                    //~~~~~~~~~~~~
                    // Allow the user to select a graphic
                    Graphic editGraphic = null;
                    try
                    {
                        // Graphic
                        editGraphic = await GetGraphicAsync();
                    }
                    catch //(Exception ex)
                    {
                    }
                    if (editGraphic == null)
                    {
                        _editState = EditState.None; // TODO PRA  mettre le  _editState = EditState.Create; apres ce test ?
                        return;
                    }
                    _editState = EditState.Create;
                    // Let the user make changes to the graphic's geometry, await the result (updated geometry)
                    Geometry newGeometry = await _mapView.SketchEditor.StartAsync(editGraphic.Geometry);

                    // Display the updated geometry in the graphic
                    //   editGraphic.Geometry = newGeometry;

                    _editState = EditState.None;

                    // process symbol with geometry
                    System.Diagnostics.Trace.WriteLine("DoActionSymbolChanged");
                    ProcessSymbol(_selectedSymbol, newGeometry);
                }
                catch (TaskCanceledException)
                {
                    // clean up when drawing task is canceled
                }
            }
        }

        private void ProcessSymbol(SymbolViewModel symbol, Geometry geometry)
        {
            if (symbol == null || geometry == null)
            {
                return;
            }

            //create a new message
            var msg = new TimeAwareMilitaryMessage(Guid.NewGuid().ToString("D"))
            {
                VisibleTimeExtent = new TimeExtent(_mission.PhaseList[CurrentPhaseIndex].VisibleTimeExtent.StartTime,
                    _mission.PhaseList[CurrentPhaseIndex].VisibleTimeExtent.EndTime),
               // Id = Guid.NewGuid().ToString("D"),
                SymbolGeometry = geometry,
                symbolProperties = new SymbolProperties()
                {
                        SymbolID = symbol.SymbolID
                }     
            };

            // set default time extent

            //set other parts of the message
            msg.Add(SimpleMessage.TypePropertyName, Constants.MSG_TYPE_POSITION_REPORT);
    //        msg.Add(Message.ActionPropertyName, Constants.MSG_ACTION_UPDATE);
        //    msg.Add(Message.WkidPropertyName, "3857"); // pl 3857
    //        msg.Add(Message.SicCodePropertyName, symbol.SymbolID);
            msg.Add(Message.UniqueDesignationPropertyName, "1");  // TODO PRA : l'uic ...

            List<MapPoint> mympList = new List<MapPoint>();

            // Construct the Control Points based on the geometry type of the drawn geometry.
            switch (geometry.GeometryType)
            {
                case GeometryType.Point:
                    MapPoint point = geometry as MapPoint;
                    if (point != null)
                        msg.Add(Message.ControlPointsPropertyName, string.Format("{0};{1}", point.X.ToString(), point.Y.ToString()));
                    break;
                case GeometryType.Polygon:
                    Polygon polygon = geometry as Polygon;

                    mympList.AddRange(polygon.Parts.SelectMany(m => m.Points)); // polygon.Parts.SelectMany(pt => pt.GetPoints()).
                    string cpts = mympList.Aggregate(string.Empty, (current, segpt) => current + (";" + segpt.X.ToString() + ";" + segpt.Y.ToString()));
                    //foreach (var pt in polygon.Rings[0])
                    msg.Add(Message.ControlPointsPropertyName, cpts);
                    break;
                case GeometryType.Polyline:
                    Polyline polyline = geometry as Polyline;
                    cpts = string.Empty;

                    // TODO find a way to determine if polyline map points need adjustment based on symbol being drawn
                    var mpList = AdjustMapPoints(polyline, symbol);

                    cpts = mpList.Aggregate(cpts, (current, mp) => current + (";" + mp.X.ToString() + ";" + mp.Y.ToString()));

                    msg.Add(Message.ControlPointsPropertyName, cpts);
                    break;
            }

            //Process the message
            if (ProcessMessage(_militaryMessageLayer, msg))
            {
                AddMilitaryMessageToMessageList(msg);
             
                DoCloneMission(null);
            }
            else
            {
                MessageBox.Show("Failed to process message.");
            }
        }

        //       private void RecordMessageBeingAdded(TimeAwareMilitaryMessage tam)
        //       {
        //           tam.PhaseControlPointsDictionary.Add(tam[Message.ControlPointsPropertyName]); // TODO PRA 
        //            tam.PhaseControlPointsDictionary.Add(_mission.PhaseList[CurrentPhaseIndex].ID, tam[Message.ControlPointsPropertyName]);
        //        AddMilitaryMessageToMessageList(tam);
        //}

        private void AddMilitaryMessageToMessageList(TimeAwareMilitaryMessage tam)
        {// todo pra test modif pra :comment le message pourrait exister déjà ???
            if (_mission.GetMessages(tam.Id).Count==0)//     .MilitaryMessages.Any(m => m.Id == tam.Id))
            {
                var phase = _mission.Phases(tam.VisibleTimeExtent)[0];  //zero et non current, car les phases ne se chevauchent pas.
                                                                        // on ne doit donc avoir qu'un élément (d'index 0)
                phase.AddMessage(tam);// _mission.add.MilitaryMessages.Add(tam);
            }
        }

        private static List<MapPoint> AdjustMapPoints(Polyline polyline, SymbolViewModel symbol)
        {
            // TODO find a better way to determine if we need to adjust the control points for the symbol
            if (symbol.SymbolID.Contains("POLA") || symbol.SymbolID.Contains("PPA"))
            {
                return AdjustMapPoints(polyline, SketchCreationMode.Arrow);// DrawShape.Arrow);
            }

            return AdjustMapPoints(polyline, SketchCreationMode.Polyline/* DrawShape.Polyline*/);
        }

        private static List<MapPoint> AdjustMapPoints(Polyline polyline,/* DrawShape*/SketchCreationMode drawShape)
        {
            if (polyline == null || polyline.Parts == null || !polyline.Parts.Any())
            {
                return null;
            }

            var mapPoints = new List<MapPoint>();

            //           var points = polyline.Parts.First().GetPoints().ToList();
            List<MapPoint> points = new List<MapPoint>
            {
                polyline.Parts[0].StartPoint,
                polyline.Parts[0].EndPoint  // TODO PRA pas tres propre
            };// = polyline.Parts.First().StartPoint;// ...StartPoint();  //.GetPoints().ToList();
            if (drawShape == /*DrawShape*/ SketchCreationMode.Arrow)
            {
                // Arrow shapes like axis of advance 
                // requires at least 3 points, 1 back, 2 front, 3 width

                if (points.Count == 2)
                {
                    // add a third point, otherwise the message processor will fail
                    var thridPoint = new MapPoint(points.Last().X, points.Last().Y);
                    points.Add(thridPoint);
                }

                mapPoints.AddRange(points.Where(point => point != points.Last()));

                mapPoints.Reverse();
                mapPoints.Add(points.Last());
            }
            else
            {
                mapPoints = points;
            }

            return mapPoints;
        }

        #region IDropable
        /// <summary>
        /// IDragable.DataType
        /// the type of object that can be dropped on the map
        /// typeof SymbolTreeViewModel
        /// </summary>
        public Type DataType
        {
            get { return typeof(SymbolViewModel); } // avant :  SymbolTreeViewModel); }
        }

        /// <summary>
        /// IDragable.Drop
        /// Method called when an object of a valid type is dropped on the Map
        /// The data is a SymbolTreeViewModel along with the DragEventArgs
        /// </summary>
        /// <param name="data"></param>
        /// <param name="e"></param>
        public void Drop(object data, DragEventArgs e)
        {
            var svm = (data as SymbolViewModel);

            if (svm != null)
            {
                AddNewMessage(svm/*.ItemSVM*/, e.GetPosition(_mapView),  Guid.NewGuid().ToString("D"));//stvm.GUID*/); // un multiple drop provoquera une rupture de l'unicité des id !
            }



            

            Mediator.NotifyColleagues(Constants.ACTION_DRAG_DROP_ENDED, data);
            _editState = EditState.None;

        }

        #endregion

        private void AddNewMessage(SymbolViewModel symbolViewModel, Point p, string msgId)
        {
      //      var l = new List<string>();
        //    l.Add(symbolViewModel.SymbolID);// {  }
            //create a new message
            var tam = new TimeAwareMilitaryMessage(msgId)
            {
                VisibleTimeExtent = new TimeExtent(_mission.PhaseList[CurrentPhaseIndex].VisibleTimeExtent.StartTime,
                    _mission.PhaseList[CurrentPhaseIndex].VisibleTimeExtent.EndTime),
                symbolProperties = new SymbolProperties()
                {
                    Image = symbolViewModel.Thumbnail,
                    SymbolID = symbolViewModel.SymbolID 
                }
          //      Id = guid
            };

  
            tam.Add(Message.UniqueDesignationPropertyName, symbolViewModel.Name);

            // Construct the Control Points based on the geometry type of the drawn geometry.
            var point = _mapView.ScreenToLocation(p);
            tam.Add(Message.WkidPropertyName, point.SpatialReference.Wkid.ToString().ToString());// ;//
            tam.SymbolGeometry = point;//todo pra passer par lui ?
            CultureInfo cif = new CultureInfo("en-US");
            tam.Add(Message.ControlPointsPropertyName, point.X.ToString(cif) + ";" + point.Y.ToString(cif));

            //Process the message
            if (ProcessMessage(_militaryMessageLayer, tam))
            {
                AddMilitaryMessageToMessageList(tam);

                DoCloneMission(null);
            }
            else
            {
                MessageBox.Show("Failed to process message.");
            }
        }

        bool IDropable.AllowFileDrop()
        {
            return true;
        }

        void IDropable.HandleFileDrop(string[] files)
        {
            Mediator.NotifyColleagues(Constants.ACTION_OPEN_MISSIONS, files);
        }
    }
}
