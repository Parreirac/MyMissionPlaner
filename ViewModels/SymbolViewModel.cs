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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MilitaryPlanner.Behavior;
//using Esri.ArcGISRuntime.Symbology.Specialized;
using MilitaryPlanner.Helpers;



namespace MilitaryPlanner.ViewModels
{
    // Symbol view model. Primary role is to expose an image property to be used in data binding.
    public class SymbolViewModel : BaseViewModel, IDragable, IDropable
    {
        public string Category
        {
            get { return _model.Category; }
        }

        public string SymbolID
        {
            get { return _model.SymbolID; }
            set { _model.SymbolID = value; } 
        }

        public SymbolProperties Model
        {
            get { return _model; }
        }

        private ImageSource _image;

        private int _imageSize;

        private readonly SymbolProperties _model;

        public SymbolViewModel(SymbolProperties model = null, int imageSize = 0) // TODO PRA 0 ou -1 ?
        {
            _model = model;
            _imageSize = imageSize;
        }

        private string _name;

        public string Name { get { return _name ?? _model.Name; } set { _name = value; } }

        public int ImageSize 
        { get { return _imageSize; } }

        public string Keywords { get { return string.Join(", ", _model.Keywords); } }

        public ImageSource Thumbnail  // pourquoi ne pas donner image directement ? utile si on a réellement une petite taille
        {
            get
            {
                if (_image == null)
                {
                    try
                    {
                            _image = _model.Image.Clone();           
                    }
                    catch
                    {
                        return null;  // TODO PRA  on devrait avoit avoir une image par defaut/
                    }
                }
                return _image;
            }
        }



        public void InvalidateImage(int imageSize)
        {
            _imageSize = imageSize;  // TODO PRA peut etre un RaiseP de trop
            if (_image != null)
            {
                _image = null;
                RaisePropertyChanged(() => Thumbnail);
            }

            RaisePropertyChanged(() => ImageSize);
        }

        #region IDragable
        public bool HasBeenDragged { get { return _hasBeenDragged; } set { _hasBeenDragged = value; } }

        bool _isDragrable = true;
        bool _hasBeenDragged = false;

        public bool IsDragable { get { return _isDragrable; } }

        public Type DataType
        {
            get { return typeof(SymbolViewModel); }
        }

        public void Remove(object i)
        {
            //throw new NotImplementedException();
        }

        void IDropable.Drop(object data, DragEventArgs e)  // TODO PRA ca sert ca ?
        {
            //   System.Windows.Controls.Image t;
            FrameworkElement fe = e.Data.GetData(typeof(FrameworkElement)) as FrameworkElement;
            //     ContainerFromElement(fe)

            var p = fe.Parent;

            IDragable source = e.Data.GetData(DataType) as IDragable;
  
            var source2 = e.Source;
            var os = e.OriginalSource;
            var RE = e.RoutedEvent;
            //  throw new NotImplementedException();
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
