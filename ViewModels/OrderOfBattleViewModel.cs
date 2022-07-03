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
using MilitaryPlanner.Behavior;
using MilitaryPlanner.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MilitaryPlanner.ViewModels
{
    public class OrderOfBattleViewModel : BaseViewModel, IDropable  // ajout PRA 
    {
        // Public members for data binding
        public ObservableCollection<SymbolViewModel> Symbols { get; private set; }
        public string SearchString { get; set; }

        // commands
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand SymbolChangedCommand { get; set; }
        public RelayCommand SymbolDragCommand { get; set; }

    //    private readonly int _imageSize; // TODO PRA est ce utile ? ou peut passer dans le builder

        // Currently selected symbol 
        SymbolViewModel _selectedSymbol = null;
        public SymbolViewModel SelectedSymbol
        {
            get
            {
                return _selectedSymbol;
            }

            set
            {
                _selectedSymbol = value;
                RaisePropertyChanged(() => SelectedSymbol);
                Mediator.NotifyColleagues(Constants.ACTION_SELECTED_SYMBOL_CHANGED, value);
            }
        }

/*        public SymbolGroupViewModel GroupSymbol
        {
            get { return _groupSymbol;}
        } */

        /* readonly modif pra */ //private SymbolGroupViewModel _groupSymbol;
        private IEnumerable<OrganizedSymbolProperties> _groupSymbol;

        public IEnumerable/*IReadOnlyCollection*/<OrganizedSymbolProperties> FirstGeneration
        {
            get { return _groupSymbol; } //.AS.AsEnumerable().As; }
        }

    

        public OrderOfBattleViewModel()
        {
         //   System.Diagnostics.Trace.WriteLine("in OrderOfBattleViewModel()");
            Mediator.Register(Constants.ACTION_CANCEL, DoActionCancel);
            Mediator.Register(Constants.ACTION_ITEM_WITH_GUID_REMOVED, DoActionItemWithGuidRemoved);
            Mediator.Register(Constants.ACTION_ITEM_WITH_GUID_ADDED, DoActionItemWithGuidAdded);
          
            // Check the ArcGIS Runtime is initialized
            if (!ArcGISRuntimeEnvironment.IsInitialized)
                ArcGISRuntimeEnvironment.Initialize();

            // hook the commands
            SearchCommand = new RelayCommand(OnSearch);
            SymbolChangedCommand = new RelayCommand(OnSymbolChanged);

            // Collection of view models for the displayed list of symbols
            Symbols = new ObservableCollection<SymbolViewModel>();

            // Set the image size
            //   _imageSize = Constants._imageSize;

            // modif pra : pas d'await dans le constructeur on teste autre chose
            //       var rootSymbol = await SymbolLoader.LoadSymbolWrapperAsync(new SymbolProperties(), _imageSize);
            //       // org tree view
            //       _groupSymbol = new SymbolGroupViewModel(rootSymbol);
            //       ExpandGroupSymbol(_groupSymbol);

            //     System.Diagnostics.Trace.WriteLine("out OrderOfBattleViewModel()");


            Init();
        }

        private void Init()
        {
            if (_groupSymbol != null)
                return;

            // version de base    var wrapper = DataLoader.GetWrapper();// LoadSymbolWrapper();

            // org tree view
            // TODO PRA trouver une taille
            _groupSymbol = DataLoader.RootODBNode; // new SymbolGroupViewModel( DataLoader.RootODBNode);// wrapper);

            ExpandGroupSymbol( null);
       //     SelectedSymbol = _groupSymbol.FirstGeneration.FirstOrDefault().ItemSVM;// TODO PRA ?
            
        }

        private void SetAllNodesToDraggable()
        {
            foreach (var sym in _groupSymbol)//_groupSymbol.FirstGeneration)
                SetAllLeavesToDraggable(sym);
        }

        private void SetAllLeavesToDraggable(OrganizedSymbolProperties stvm)
        {
            stvm.HasBeenDragged = false;

            if (stvm.Children != null && stvm.Children.Count > 0)
            {
                foreach (var stvm2 in stvm.Children) 
                      SetAllLeavesToDraggable(stvm2 );
            }
        }

        /// <summary>
        /// Method that handles the addition of a symbol to the map view
        /// Sets the property that controls the objects dragability
        /// </summary>
        /// <param name="obj"></param>
        private void DoActionItemWithGuidAdded(object obj)
        {
            string guid = obj as string;

            // object here is a guid
            if (guid == null)
                return;

            foreach (var sym in _groupSymbol)//_groupSymbol.FirstGeneration)
            {
                var temp = FindChildWithGuid(sym, guid);

                if (temp != null)
                    temp.HasBeenDragged = true;
               
            }
        }

        /// <summary>
        /// Method handles the removal of a symbol from the entire mission
        /// Reset HasBeenDragged property in OOB Tree so that it can be dragged/dropped again
        /// </summary>
        /// <param name="obj"></param>
        private void DoActionItemWithGuidRemoved(object obj)
        {
            string guid = obj as string;

            // object here is a guid
            if (guid == null)
                return;

            foreach (var sym in _groupSymbol) // _groupSymbol.FirstGeneration)
            {
                var temp = FindChildWithGuid(sym, guid);

                if (temp != null)
                {
                    temp.HasBeenDragged = false;
                }
            }
        }

        /// <summary>
        /// Method finds the first child node with the given GUID
        /// </summary>
        /// <param name="stvm"></param>
        /// <param name="guid"></param>
        /// <returns>Tree Symbol object with the given GUID</returns>
        private OrganizedSymbolProperties FindChildWithGuid(OrganizedSymbolProperties stvm, string guid)
        {
            if (stvm == null)
                return null;

            if (stvm.Id.CompareTo(guid) == 0)
                return stvm;

            var v = stvm.Children.Where(x => x.Id == guid).FirstOrDefault();

            return v;//as SymbolTreeViewModel;

    //            return stvm.Children.Select(stvm2 => FindChildWithGuid(stvm2, guid)).FirstOrDefault(result => result != null);
        }

        public void ExpandGroupSymbol(object o) // modif pra changement de signature (SymbolGroupViewModel groupSymbol)
        {
            if (_groupSymbol != null)
                foreach (var svm in _groupSymbol)//_groupSymbol.FirstGeneration)
                     ExpandSymbolTreeViewModelRecursive(svm);
                   
        }

        private void ExpandSymbolTreeViewModelRecursive(OrganizedSymbolProperties svm)
        {
            if (svm == null)
                return;
                
            svm.IsExpanded = true;

            foreach (var item in svm.Children)
                ExpandSymbolTreeViewModelRecursive(item);// as SymbolTreeViewModel);
        }

        private void DoActionCancel(object obj)
        {
            
        }

        /// <summary>
        /// Handler for when a selection of a symbol has changed
        /// </summary>
        /// <param name="param"></param>
        private void OnSymbolChanged(object param)
        {
            SelectionChangedEventArgs e = param as SelectionChangedEventArgs;
            if (e == null)
                return;
            if (e.AddedItems.Count != 1)
                return;
            if (e.AddedItems[0].GetType() != typeof(SymbolViewModel))
                return;

            SelectedSymbol = e.AddedItems[0] as SymbolViewModel;
        }

        private void OnSearch(object parameter) // TODO pra a priori se lance trop, dès que le champ recherche réapparait                     
                                                      // meme sans changement de texte
        {

            // Clear the current Symbols collection
            Symbols.Clear();
            //    MilitarySymbolLoader militarySymbolLoader = new MilitarySymbolLoader(MilitarySymbolLoader.symbolFilePathMil2525c);
            // Perform the search applying any selected keywords and filters 

            var symbols = DataLoader.Search(SearchString);

            foreach (var s in symbols)//var s in from symbol in allSymbols select new SymbolViewModel(symbol, Constants._imageSize))
                Symbols.Add(new SymbolViewModel(s.Model, Constants._imageSize));// TODO test pra mettre un new ?

            //RaisePropertyChanged(() => SelectedSymbol);

            SelectedSymbol = null; // Va provoquer un reDraw;

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
  //              AddNewMessage(svm/*.ItemSVM*/, e.GetPosition(_mapView), Guid.NewGuid().ToString("D"));//stvm.GUID*/); // un multiple drop provoquera une rupture de l'unicité des id !
            }

            Mediator.NotifyColleagues(Constants.ACTION_DRAG_DROP_ENDED, data);
   //         _editState = EditState.None;

        }

        bool IDropable.AllowFileDrop()
        {
            return false;
        }

        void IDropable.HandleFileDrop(string[] files)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
