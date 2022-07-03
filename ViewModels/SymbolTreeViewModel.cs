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
//using Esri.ArcGISRuntime.Symbology.Specialized;
using MilitaryPlanner.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static MilitaryPlanner.ViewModels.DataLoader;

namespace MilitaryPlanner.ViewModels
{

    // une hierarchie de SymbolProperties
    // SymbolViewModel
    public class OrganizedSymbolProperties : SymbolViewModel //SymbolProperties /*, BaseViewModel, IDragable*/
    {
        public OrganizedSymbolProperties() : base() { Parent = null; }

        //(SymbolProperties model = null, int imageSize = 0) 

        bool _isExpanded;
        bool _isSelected;

        public OrganizedSymbolProperties(SymbolProperties model = null, int imageSize = 0, List<OrganizedSymbolProperties> children = null, OrganizedSymbolProperties parent = null) : base(model, imageSize)   //(string name = "", ImageSource source = null, string key = "", string category = "", string symbolClass = "", IReadOnlyList<string> tags = null) : base(name,source,key,category,symbolClass,tags)
        {
            Parent = parent;
            if (children != null)
            Children = children;
        }

        public OrganizedSymbolProperties Parent { get; private set; }

        public string Id { get; set; }

        List<OrganizedSymbolProperties> _liste = new List<OrganizedSymbolProperties>();

        // readonly ReadOnlyCollection<SymbolTreeViewModel> _children;
        //     public ReadOnlyCollection<SymbolProperties>

        // Liste des enfants, fait un parent sur les enfants
        public List<OrganizedSymbolProperties> Children
        {
            get { return _liste; }
            private set
            {
                if (value == null)
                    value = null;
                _liste = value;
                if (_liste != null)
                    foreach (var child in _liste)
                        child.Parent = this;
            } // _children; }
        }

        private static OrganizedSymbolProperties HandleXElement_old(XElement elem)// , List<OrganizedSymbolProperties> liste)
        {
            XName xsic = XName.Get("SIC");
            XName xid = XName.Get("Id");
            XName xchildren = XName.Get("Children");

            XElement sicElem = elem.Element(xsic);
            XElement idElem = elem.Element(xid);
            var xchildrenElements = elem.Elements(xchildren);// XName.Get("Children");

            List<OrganizedSymbolProperties> liste = new List<OrganizedSymbolProperties>();

            foreach (XElement fils in xchildrenElements)
            {

                XElement sicElemFils = fils.Element(xsic);
                XElement idElemFils = fils.Element(xid);
                //           var t = SymbolLoader.Search(sicElemFils.Value).FirstOrDefault(); // TODO PRA : il existe plusieurs valeurs !
                var tf = DataLoader.SearchBySIC(sicElemFils.Value, SearchMode.Extended).FirstOrDefault();

                if (tf == null)
                    tf = DataLoader.CreateNewSymbol(sicElemFils.Value);

                //(string name = "", ImageSource source = null, string key = "", string category = "", string symbolClass = "", IReadOnlyList<string> tags = null) : base(name,source,key,category,symbolClass,tags) { }

                liste.Add(new OrganizedSymbolProperties(tf)
                {
                    //    Name = nameElemFils != null ? nameElemFils.Value : "",//,
                    //                SymbolID = sicElemFils.Value,  // TODO PRA : ecrase la valeur de TF ! interdire le setter ?
                    Id = idElemFils != null ? idElemFils.Value : "" // eventuellement "no id"
                });

            }

            var tb = DataLoader.SearchBySIC(sicElem.Value, SearchMode.Extended).FirstOrDefault(); // TODO PRA et si plusieurs ?*
                                                                                                  // tracer dans la classe que l'on n'a pas exactemment le symbol ?


            OrganizedSymbolProperties organizedSymbolProperties = new OrganizedSymbolProperties(tb)//nameElem != null ? nameElem.Value : "",
                                                                                                   //    tb.Image, tb.Key, tb.Category, tb.SymbolClass, tb.Tags)
            {
                //     Name = nameElem != null ? nameElem.Value : "",//,
                //        SymbolID = sicElem.Value,
                Id = idElem != null ? idElem.Value : "", // eventuellement "no id"
                Children = liste
            };

            return organizedSymbolProperties;
        }

        // Todo PRA ? ajouter une liste globale ? elle ne sert pas dans la pratique ...
        private static OrganizedSymbolProperties HandleXElement(XElement elem, List<OrganizedSymbolProperties> globaleList)// , List<OrganizedSymbolProperties> liste)
        {
            XName xsic = XName.Get("SIC");
            XName xid = XName.Get("Id");
            XName xchildren = XName.Get("Children");
            XName xName = XName.Get("Name");

            XElement nameElem = elem.Element(xName);
            XElement sicElem = elem.Element(xsic);
            XElement idElem = elem.Element(xid);
            var xchildrenElements = elem.Elements(xchildren);

            List<OrganizedSymbolProperties> liste = new List<OrganizedSymbolProperties>();

            foreach (XElement fils in xchildrenElements)
            {
                var createdNode = HandleXElement(fils, globaleList);
                var nodesInListe = globaleList.Where(node => node.Id == createdNode.Id);
                int n = nodesInListe.Count();
                if (n > 0)
                    n = n;
                //        globaleList.Add(createdNode); pas besoin HandleXElement(fils, globaleList); l'a fait
                liste.Add(createdNode);
            }


            var nodesInListe2 = globaleList.Where(node => node.Id == idElem.Value);
            int n2 = nodesInListe2.Count();
            if (n2 > 0)
                n2 = n2;

            var tb = DataLoader.SearchBySIC(sicElem.Value, SearchMode.Extended).FirstOrDefault(); // TODO PRA et si plusieurs ?*
                                                                                                  // tracer dans la classe que l'on n'a pas exactemment le symbol ?

            if (tb == null)
                tb = DataLoader.CreateNewSymbol(sicElem.Value);

            OrganizedSymbolProperties organizedSymbolProperties = new OrganizedSymbolProperties(tb, Constants._treeImageSize)//nameElem != null ? nameElem.Value : "",
                                                                                                   //    tb.Image, tb.Key, tb.Category, tb.SymbolClass, tb.Tags)
            {
                //     Name = nameElem != null ? nameElem.Value : "",//,
                //        SymbolID = sicElem.Value,
                Id = idElem != null ? idElem.Value : "", // eventuellement "no id"
                Children = liste
            };

            if (nameElem != null)  // si le scn a un nom, on le garde
                organizedSymbolProperties.Name = nameElem.Value;


            globaleList.Add(organizedSymbolProperties);

            return organizedSymbolProperties;
        }

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
                //          if (_isExpanded && current.Parent /*_parent*/ != null)
                //              _parent.IsExpanded = true; // TODO PRA  doit on avoir un parent dans l'arbre ?
                // est ce logique ? parent a true si tous les enfants sont a true, ou seulement 1 ?
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



        static public IEnumerable<OrganizedSymbolProperties> Load(string filename)
        {
            if (String.IsNullOrWhiteSpace(filename) || !File.Exists(filename))
                return null;

            XDocument file = XDocument.Load(filename);
            var rootElem = file.Root;
            //        var xmlType = rootElem.Name.LocalName;

            XName xchildren = XName.Get("Children");
            int i = 0;
            List<OrganizedSymbolProperties> listeDuFichier = new List<OrganizedSymbolProperties>();//  rootElement = null;//  new OrganizedSymbolProperties();
            List<OrganizedSymbolProperties> baseNodes = new List<OrganizedSymbolProperties>();
            foreach (XElement elem in rootElem.Elements())
            {
                if (elem.Name != xchildren)
                    continue;
                i++;
                OrganizedSymbolProperties osp = HandleXElement(elem, listeDuFichier);
                baseNodes.Add(osp);
            }

            return baseNodes.AsEnumerable();// listeDuFichier.AsEnumerable();//.FirstOrDefault();
        }

        /*
                #region IDragable
                public bool HasBeenDragged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

                public bool IsDragable => throw new NotImplementedException();

                public Type DataType => throw new NotImplementedException();

                public void Remove(object i)
                {
                    throw new NotImplementedException();
                }
                #endregion
        */
    }

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
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);// Modif pra on autoriser les lectures multiples
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
            var t = DataLoader.Search(temp.SIC);
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


    public class SymbolTreeViewModel : OrganizedSymbolProperties //BaseViewModel, IDragable
    {
        //     readonly OrganizedSymbolProperties current;

        //    public SymbolViewModel SVM { get { return current; }  }

        //modif pra      readonly ReadOnlyCollection<OrganizedSymbolProperties> _children;
        //modif pra            readonly SymbolTreeViewModel _parent;
        //modif pra     readonly SymbolViewModelWrapper _symbolWrapper;

        //      bool _isExpanded;// deplacé vers OrganizedSymbolProperties
        //      bool _isSelected;  // deplacé vers OrganizedSymbolProperties
        //bool _isDragable = true;

        //      private object symbolWrapper;
        //      private SymbolTreeViewModel parent;
        //      readonly string _guid;

        /*  public string Id // avant  GUID
          {
              get; private set; 
         //     {    return _guid; }
          }*/

        public SymbolTreeViewModel(OrganizedSymbolProperties rootNote, int size = 0) : base(rootNote.Model, size, rootNote.Children, rootNote.Parent)//SymbolViewModelWrapper symbolWrapper, SymbolTreeViewModel parent = null)
        {
            //   current = rootNote;

            //   Children = rootNote.Children;
            //   Parent = rootNote.Parent;
            Id = Guid.NewGuid().ToString("D");
        }

        #region SymbolVM Properties
        //     public ReadOnlyCollection<SymbolTreeViewModel> Children
        //     public ReadOnlyCollection<OrganizedSymbolProperties> Children => current.Children.AsReadOnly(); //_children; 
        /*    public SymbolViewModel ItemSVM
            {                get { return _symbolWrapper.SVM; }    } */
        #endregion


        #region NameContainsText

        public bool NameContainsText(string text)
        {
            if (String.IsNullOrEmpty(text) || String.IsNullOrEmpty(Name))
                return false;

            return Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1;
        }

        #endregion // NameContainsText

        #region Parent

        /*      public SymbolTreeViewModel Parent
              {
                  get { return _parent; }
              }*/

        #endregion // Parent

        /*
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
                if (Children != null && Children.Count > 0)//_children != null && _children.Count > 0)
                    return false;
                return true;
            }
        }
        public Type DataType
        {
            get { return typeof(SymbolTreeViewModel); } // todo pra ???
        }

        public static void Remove(object obj)
        {
            // set as disabled?
            // We will need to disable the drag on this model until another slide is created or is deleted from current slide
            SymbolTreeViewModel stvm = obj as SymbolTreeViewModel;

            if (stvm != null)
            {
                //TODO need to use msg.ID or something to keep track of item, for delete, add, etc
                //stvm.IsDragable = false;
                //   if (stvm != null)
                stvm.HasBeenDragged = true;
            }
        }
        #endregion
        */
    }

}
