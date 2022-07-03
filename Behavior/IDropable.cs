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

namespace MilitaryPlanner.Behavior
{
    interface IDropable
    {
        /// <summary>
        /// Type of the data item
        /// </summary>
        Type DataType { get; }

        /// <summary>
        /// Drop data into the collection.
        /// </summary>
        /// <param name="data">The data to be dropped</param>
        /// <param name="e">drag event args</param>
        void Drop(object data, DragEventArgs e);

        // ajout de la gestion des fichiers


        /// <summary>
        /// Allow files 
        /// </summary>
        bool AllowFileDrop();  //ajout pra 

        /// <summary>
        /// if AllowFileDrop is true, behavior calls HandleFileDrop 
        /// </summary>
        void HandleFileDrop(string[] files);


    }
}
