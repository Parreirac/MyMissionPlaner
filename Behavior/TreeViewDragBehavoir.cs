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
using System.Windows.Controls;
using System.Windows.Input;
//modif pra using System.Windows.Interactivity;
using Microsoft.Xaml.Behaviors;
using MilitaryPlanner.Helpers;

namespace MilitaryPlanner.Behavior
{
    /// <summary>
    /// For enabling Drop on ItemsControl
    /// </summary>
    public class TreeViewDragBehavior : Behavior<ItemsControl>
    {
        private bool _isMouseClicked;

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLeftButtonDown;
            AssociatedObject.MouseLeftButtonUp += AssociatedObject_MouseLeftButtonUp;
            AssociatedObject.MouseLeave += AssociatedObject_MouseLeave;
        }

        void AssociatedObject_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isMouseClicked = true;
        }

        void AssociatedObject_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isMouseClicked = false;
        }

        void AssociatedObject_MouseLeave(object sender, MouseEventArgs e)
        {
            if (_isMouseClicked)
            {
                //set the item's DataContext as the data to be transferred
                IDragable dragObject = AssociatedObject.DataContext as IDragable;
                if (dragObject != null && dragObject.IsDragable)
                {
                    DataObject data = new DataObject();
                    data.SetData(dragObject.DataType, AssociatedObject.DataContext);
                    DragDrop.DoDragDrop(AssociatedObject, data, DragDropEffects.Move);
                    Mediator.NotifyColleagues(Constants.ACTION_DRAG_DROP_STARTED, data);
                }
            }
            _isMouseClicked = false;
        }
    }
}
