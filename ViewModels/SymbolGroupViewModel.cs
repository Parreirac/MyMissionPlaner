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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MilitaryPlanner.ViewModels
{
    public class SymbolGroupViewModel
    {
        readonly IReadOnlyCollection<SymbolTreeViewModel> _firstGeneration;

     /*   public SymbolGroupViewModel( SymbolViewModelWrapper wrapper)
        {
          SymbolTreeViewModel rootSymbol1 = new SymbolTreeViewModel( wrapper);

            _firstGeneration = new ReadOnlyCollection<SymbolTreeViewModel>(
                new[]
                {
                    rootSymbol1
                });
        }*/ 


        // modif pra 
        public SymbolGroupViewModel(SymbolTreeViewModel rootSymbol1)
        {
           // SymbolTreeViewModel rootSymbol1 = new SymbolTreeViewModel(wrapper);

            _firstGeneration = new ReadOnlyCollection<SymbolTreeViewModel>(
                new[]
                {
                    rootSymbol1
                });
        }

        public SymbolGroupViewModel(IEnumerable<OrganizedSymbolProperties> rootODBNode)
        {
            List<SymbolTreeViewModel> l = new List<SymbolTreeViewModel>();
            foreach (OrganizedSymbolProperties node in rootODBNode)
                l.Add(new SymbolTreeViewModel(node, 200));
      
            _firstGeneration  = l.AsReadOnly();

        }

        public IReadOnlyCollection<SymbolTreeViewModel> FirstGeneration
        {
            get { return _firstGeneration; }
        }

    }
}
