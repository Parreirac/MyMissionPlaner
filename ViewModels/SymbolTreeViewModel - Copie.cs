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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;

//using Esri.ArcGISRuntime.Symbology.Specialized;
using MilitaryPlanner.Behavior;
using MilitaryPlanner.ViewModels;

namespace MilitaryPlanner.ViewModels2
{

    [Serializable]
    public class SymbolViewModelWrapper
    {
        //     public SymbolViewModelWrapper(SymbolProperties model = null, int imageSize = 0) // MODIF PRA , changement de signature
        //     { SVM = new SymbolViewModel( model,imageSize ); }

        public SymbolViewModelWrapper()
        { } /// SVM = new SymbolViewModel(); }  // Serializable=> constructeur sans parametre
                                          // modif pra ajout init de SVM.

        List<SymbolViewModelWrapper> _children = new List<SymbolViewModelWrapper>();
        string _sic;
        string _name; // Modif PRA : le scénario contient des noms

        [XmlElement]
        public List<SymbolViewModelWrapper> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        [XmlIgnore]
        public SymbolViewModel SVM { get; set; }

        [XmlElement]
        public string SIC { get { return _sic; } set { _sic = value; } }

        [XmlElement]//
        public string Name { get { return _name; } set { _name = value; } }

        [XmlElement]
        public string Id { get; set; }

        internal void Save(string filename)
        {
            XmlSerializer x = new XmlSerializer(GetType());
            FileStream fs = new FileStream(filename, FileMode.Create);
            x.Serialize(fs, this);
            fs.Close();
        }


  
        static public SymbolViewModelWrapper Load(string filename)
        {
        //    System.Diagnostics.Trace.WriteLine("Entering Task<SymbolViewModelWrapper> LoadAsync(string filename)"+ filename+"\n");
            try
            {
                SymbolViewModelWrapper value = new SymbolViewModelWrapper();
                XmlSerializer x = new XmlSerializer(value.GetType());
                //XmlWriter writer = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read,FileShare.Read);// Modif pra on autoriser les lectures multiples
                XmlReader reader = XmlReader.Create(fs);
                

                var temp = x.Deserialize(reader) as SymbolViewModelWrapper; // /!\ ceci lit le fichier !
                fs.Close();// modif pra 

                InitializeWrapper(temp);

   //              System.Diagnostics.Trace.WriteLine("Exit Task<SymbolViewModelWrapper> LoadAsync(string filename)" + filename + "\n");
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Task<SymbolViewModelWrapper> LoadAsync\n" + ex.ToString());
                return null;
            }
  
        }

   //     static List<SymbolViewModelWrapper> _AllSymbols = new List<SymbolViewModelWrapper>();  // TODO PRA ne sert pas actuellement 

        private static void InitializeWrapper(SymbolViewModelWrapper temp)
        {
        //    _AllSymbols.Add(temp);
                      var t =  DataLoader.Search(temp.SIC);
         if (t.Any())
            { 
                var s = t.FirstOrDefault();

                if (temp.Name != null) // si le scénario a un nom, on le conserve.
                    s.Name = temp.Name;
                temp.SVM = s;
            }
         else
             temp.SVM = null;

       

    //        _ = temp.SVM.Thumbnail; // force le clone de l'image

            //        System.Diagnostics.Trace.WriteLine("Enter InitializeWrapperAsync ");
            if (temp.Children == null || temp.Children.Count <= 0)
                return;
 
            foreach (var w in temp.Children)
            {
                InitializeWrapper(w);

       /*         var v =  SymbolLoader.Search(w.SIC);   // Est-ce utile ??
                if (v.Any())
                    w.SVM = v.FirstOrDefault();
                else
                    w.SVM = null;

                _ = w.SVM.Thumbnail; // force le clone de l'image
       */ 
            }
   /*         var t =  SymbolLoader.Search(temp.SIC);
            if (t.Any())
                temp.SVM = t.FirstOrDefault();
            else
                temp.SVM = null;*/


        }
    }

    public class SymbolTreeViewModel : BaseViewModel, IDragable
    {
        readonly ReadOnlyCollection<SymbolTreeViewModel> _children;
        readonly SymbolTreeViewModel _parent;
        readonly SymbolViewModelWrapper _symbolWrapper;

        bool _isExpanded; 
        bool _isSelected;
        //bool _isDragable = true;
      
        //      private object symbolWrapper;
        //      private SymbolTreeViewModel parent;
        readonly string _guid;

        /*  public SymbolTreeViewModel(SymbolViewModelWrapper symbolWrapper)  : this(symbolWrapper, null) // peut provoquer un stackowerflow !
          { }*/

        public SymbolTreeViewModel( SymbolViewModelWrapper symbolWrapper, SymbolTreeViewModel parent = null)
        {
            if (symbolWrapper == null || String.IsNullOrWhiteSpace(symbolWrapper.Id)) // modif PRA test sur symbolWrapper
            {
                _guid = Guid.NewGuid().ToString("D");
            }
            else
            {
                _guid = symbolWrapper.Id;
            }
            _symbolWrapper = symbolWrapper;
            _parent = parent;

            if (_symbolWrapper == null)
            {   // ajout PRA
                List<SymbolTreeViewModel> listeVide = new List<SymbolTreeViewModel>();
            //    SymbolTreeViewModel [] symbolTreeViewModel = { new SymbolTreeViewModel(symbolWrapper, parent) };
                _children = new ReadOnlyCollection<SymbolTreeViewModel>(listeVide);// (symbolTreeViewModel);
            }
            else
                _children = new ReadOnlyCollection<SymbolTreeViewModel>(
                (from child in _symbolWrapper.Children
                 select new SymbolTreeViewModel( child, this))
                 .ToList<SymbolTreeViewModel>());
        }

     /*   public SymbolTreeViewModel(object symbolWrapper, SymbolTreeViewModel parent)
        {
            this.symbolWrapper = symbolWrapper;
            this.parent = parent;
        }*/

        #region SymbolVM Properties

        public ReadOnlyCollection<SymbolTreeViewModel> Children
        {
            get { return _children; }
        }

        public string Name
        {
            get { return _symbolWrapper.SVM.Name; }
        }

        public ImageSource Thumbnail
        {
            get { return _symbolWrapper.SVM.Thumbnail; }
        }

        public int ImageSize
        {
            get { return _symbolWrapper.SVM.ImageSize; }
        }

        public SymbolViewModel ItemSVM
        {
            get { return _symbolWrapper.SVM; }
        }

        #endregion

        #region IsExpanded

        /// <summary>
        /// Gets/sets whether the TreeViewItem 
        /// associated with this object is expanded.
        /// </summary>
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                    RaisePropertyChanged(() => IsExpanded);
                }

                // Expand all the way up to the root.
                if (_isExpanded && _parent != null)
                    _parent.IsExpanded = true;
            }
        }

        #endregion // IsExpanded

        #region IsSelected

        /// <summary>
        /// Gets/sets whether the TreeViewItem 
        /// associated with this object is selected.
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                    RaisePropertyChanged(() => IsSelected);
                }
            }
        }

        #endregion // IsSelected

        public string GUID
        {
            get
            {
                return _guid;
            }
        }



        #region NameContainsText

        public bool NameContainsText(string text)
        {
            if (String.IsNullOrEmpty(text) || String.IsNullOrEmpty(Name))
                return false;

            return Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        #endregion // NameContainsText

        #region Parent

        public SymbolTreeViewModel Parent
        {
            get { return _parent; }
        }

        #endregion // Parent


        #region IDragable

        bool _hasBeenDragged;

        public bool HasBeenDragged
        {
            get
            {
                return _hasBeenDragged;
            }

            set
            {
                if (value != _hasBeenDragged)
                {
                    _hasBeenDragged = value;
                    RaisePropertyChanged(() => HasBeenDragged);
                }
            }
        }

        public bool IsDragable
        {
            get
            {
                if (_children != null && _children.Count > 0)
                    return false;
                return true;
            }
        }
        public Type DataType
        {
            get { return typeof(SymbolTreeViewModel); }
        }

        public void Remove(object i)
        {
            // set as disabled?
            // We will need to disable the drag on this model until another slide is created or is deleted from current slide
            SymbolTreeViewModel stvm = i as SymbolTreeViewModel;

            if (i != null)
            {
                //TODO need to use msg.ID or something to keep track of item, for delete, add, etc
                //stvm.IsDragable = false;
                if (stvm != null) stvm.HasBeenDragged = true;
            }
        }
        #endregion
    }
}
