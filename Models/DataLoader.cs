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
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using MilitaryPlanner.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MilitaryPlanner.ViewModels
{
    public static class DataLoader
    {

        private static SymbolStyle MilitarySymbolDictionary = null;


        public static SymbolStyle GetMilitarySymbolDictionary {get {return MilitarySymbolDictionary;}}
        private static SymbolViewModelWrapper swRoot = null;

        public static ObservableCollection<SymbolViewModel> Symbols { get; private set; }

        private static IEnumerable<OrganizedSymbolProperties> rootODB;

        public static IEnumerable<OrganizedSymbolProperties> RootODBNode { get { return rootODB; } }

        public static SymbolViewModelWrapper GetWrapper()
        {
            if (swRoot == null)
                throw new Exception("GetWrapper non initialisé");
            return swRoot;
        }

        private static readonly IList<SymbolProperties> defaultSPlist = new List<SymbolProperties>(); 

        static public void Init()
        {
            try
            {
                if (MilitarySymbolDictionary == null)
                    MilitarySymbolDictionary = SymbolStyle.OpenAsync(Constants.symbolFilePathMil2525d).Result;


                // Create a symbol dictionary style following the mil2525d spec.
         //       string symbolFilePath = DataManager.GetDataFolder("c78b149a1d52414682c86a5feeb13d30", "mil2525d.stylx");
               //DictionarySymbolStyle mil2525DStyle = await DictionarySymbolStyle.CreateFromFileAsync(symbolFilePath);

    //            string militaryMessagePath = ArcGISRuntime.Samples.Managers.DataManager.GetDataFolder("1e4ea99af4b440c092e7959cf3957bfa", "Mil2525DMessages.xml");



                // lists to contain the available symbol layers for each category of symbol.
                defaultSPlist.Clear();

                // Get the default style search parameters.
                SymbolStyleSearchParameters searchParams = MilitarySymbolDictionary.GetDefaultSearchParametersAsync().Result;

                // Search the style with the default parameters to return all symbol results.
                IList<SymbolStyleSearchResult> styleResults = MilitarySymbolDictionary.SearchSymbolsAsync(searchParams).Result;

                Task[] downloadsTask = new Task[styleResults.Count];
                int i = 0;

                foreach (SymbolStyleSearchResult result in styleResults)
                {
                    downloadsTask[i] = CreateImageTasks(result);
                    i++;
                }

                Task.WhenAll(downloadsTask).Wait();

                for (int j = 0; j < downloadsTask.Length; j++)
                {
                    Task<Task<RuntimeImage>> ti = (Task<Task<RuntimeImage>>)downloadsTask[j];
                    var result = (ti.AsyncState as SymbolStyleSearchResult);
                    RuntimeImage watch = ti.Result.Result;
                    int h = watch.Height; int w = watch.Width;
                    var image = watch.ToImageSourceAsync().Result;
                    var symbolInfo = new SymbolProperties(result.Name, image.Clone(), result.Key, result.Category, result.SymbolClass, result.Tags);
                    symbolInfo.GraphicObject = result.Symbol; // TODO PRA Pas propre ....
                    defaultSPlist.Add(symbolInfo);
                    ti.Dispose();
                }

                rootODB = OrganizedSymbolProperties.Load(Constants.OOB_FILE);

//                if (swRoot == null)
//                    swRoot = SymbolViewModelWrapper.Load(Constants.OOB_FILE);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SymbolLoader:Init()\n" + ex.ToString());  // TODO lancer une erreur  que l'init lance la lecture du stylx
            }
        }

        public enum SearchMode { Strict, Extended, Large };
        // Strict search only => one code
        // Extended search with *
        // Large Change affilition to * 


        private static bool MySymbolIDCompare(string gauche, string droite)
        {
            int lg = gauche.Length;
            int ld = droite.Length;
            int jm = Math.Min(lg, ld);
            int jM = Math.Max(lg, ld);

            if (jm != jM)
            {// TODO PRA si dans l'excedent on a autre chose que - ou * return false


            }

            //       bool returnValue = true;
            for (int j = 0; j < jm /*&& returnValue*/; j++)
            {
                char cg = gauche[j];
                char cd = droite[j];
                if (cg != cd && cg != '*')
                {

                    //         if (j > 5)
                    //           returnValue = returnValue;
                    return false;
                }
                else
                {

                }
            }

            return true;
        }


        // Evaluate quality of symbol substitution.
        // left char counts less than right char
  
        private static int EvaluateSubstitution(SymbolProperties s, string BaseSymbolCode)
        {
            string symboleCodeGauche = s.SymbolID;
            int r = 0;
            int p = 1;
            for (int i = 0; i < BaseSymbolCode.Length; i++)
            {
                if (symboleCodeGauche[i] == BaseSymbolCode[i])
                    r += p;
                p*=2;
            }
            return r;
        
        }
        public static IEnumerable<SymbolProperties> SearchBySIC(string searchString, SearchMode mode = SearchMode.Strict)
        {
            var sortie = defaultSPlist.Where(s => MySymbolIDCompare(s.SymbolID, searchString));

            bool findOne = sortie.Any();

            if (mode == SearchMode.Strict || findOne)
                return sortie;//.FirstOrDefault();//.FirstOrDefault<SymbolProperties>;// (sortie.FirstOrDefault(), Constants._imageSize);

            IEnumerable<SymbolProperties> retour = null;//= symbols.AsEnumerable();//(from symbol in symbols select new SymbolViewModel(symbol, 2*Constants._imageSize));
            int length = searchString.Length;

            // Si le symbole n'est pas présent, on recherche un symbole plus général
            //           if (mode == SearchMode.Extended/* && length > 2*/)  // TODO PRA : tracer les changements de symboles.
            //          {
            char[] searchStringAsChars = searchString.ToCharArray();
            int j = 0;
            while (length - 4 > j && !findOne)  // TODO PRA expliquer le 2 
            {
                j++;
                searchStringAsChars[length - j] = '-'; // TODO pra, j'efface une info donc - plutot que *
                retour = SearchBySIC(new string(searchStringAsChars), SearchMode.Strict);
                findOne = retour.Any();
            }
            if (findOne)
                return retour;
            //          }



            if (mode == SearchMode.Large)
            {
                searchStringAsChars = searchString.ToCharArray();
                searchStringAsChars[3] = '*';// on efface la géometrie connue par ailleur
                IEnumerable<SymbolProperties> r1 = SearchBySIC(new string(searchStringAsChars), SearchMode.Extended);

                searchStringAsChars[1] = '*';// // on efface l'hostilité que l'on sait gerer

                IEnumerable<SymbolProperties> r2 = SearchBySIC(new string(searchStringAsChars), SearchMode.Extended);

               // IEnumerable
                retour = r1.Concat(r2);

                // on tri en fonction de la qualité de la substitution 
                retour =retour.OrderBy(s => EvaluateSubstitution(s, searchString));


  //              if (searchStringAsChars[14] == 'C')  // civilan ORDER OF BATTLE
  //                  searchStringAsChars[14] = '-'; // modif pour le NVG
  //              retour = SearchBySIC(new string(searchStringAsChars), SearchMode.Extended);
            }


            return retour;
        }

        // rechercher les SymbolProperties qui dont le nom ou un Tag contient un des nom de searchString (separateur , ou ;)
        // Perform the search applying any selected keywords and filters 
        public static IEnumerable<SymbolViewModel> Search(string searchString, bool tryCorrect = true)
        {  /*
            var sstring = searchString.Split(';', ',').ToList();
            var mysym = await MilitarySymbolLoader.GetSymbolAsync(sstring);
            return new SymbolViewModel(mysym as SymbolProperties, _imageSize); // marche pas comme ca on a perdu toutes les propriétées
            */

            if (defaultSPlist == null)
                throw new Exception("Symbols non initialisés appeler LoadSymbolDictionary");

            // Perform the search applying any selected keywords and filters 
            //        var symbols = defaultSPlist.AsEnumerable();

            var liste = new List<SymbolProperties>(capacity: defaultSPlist.Count);  // TODO PRA, a tester
            foreach (SymbolProperties s in defaultSPlist)  // 
                liste.Add(s); // new SymbolProperties(s)); ;

            var symbols = liste.AsEnumerable();

            int length = searchString != null ? searchString.Length : 0;

            if (length > 0)
            {
                //               foreach (var ss in searchString.Split(';', ','))  // modif pra : desactivation de cette partie qui dans la pratique
                //                                                                 // ne sert pas encore. Le test sur le nom est il utile ?

                String mysearch = searchString.ToLower().Trim().Trim(Constants.trimChar);
                //             symbols = symbols.Where(s => s.Name.ToLower().Contains(ss.ToLower().Trim()) || s.Keywords.Any(kw => char.ToString(kw).ToLower().Contains(ss.ToLower().Trim())));
                //                symbols = symbols.Where(s => mysearch.Contains(s.Name.ToLower().Trim().Trim(Constants.trimChar)) || s.Tags.Any(tag => mysearch.Contains(tag.ToLower().Trim().Trim(Constants.trimChar))));
                symbols = symbols.Where(s => s.Name.ToLower().Trim().Trim(Constants.trimChar).Contains(mysearch)
                             || s.Tags.Any(tag => tag.ToLower().Trim().Trim(Constants.trimChar).Contains(mysearch)));//  tag => mysearch.Contains(tag.ToLower().Trim().Trim(Constants.trimChar))));

            }

            IEnumerable<SymbolViewModel> retour = null;//= symbols.AsEnumerable();//(from symbol in symbols select new SymbolViewModel(symbol, 2*Constants._imageSize));
            bool findOne = symbols.Any();
            // Si le symbole n'est pas présent, on recherche un symbole plus général
            if (!findOne && tryCorrect && length > 0)  // TODO PRA : tracer les changements de symboles.
            {
                char[] searchStringAsChars = searchString.ToCharArray();
                int j = 0;
                while (tryCorrect && length > j && !findOne)
                {
                    j++;
                    searchStringAsChars[length - j] = '*';
                    retour = Search(new string(searchStringAsChars), false);
                    findOne = retour.Any();
                }
                if (tryCorrect && !findOne)
                    throw new Exception("Aucun symbole trouvé pour le remplacement de " + searchString);
            }
            else
                retour = (from symbol in symbols select new SymbolViewModel(symbol, Constants._imageSize));

            return retour;
        }

        /*
        public static Task CreateImageTaskWithOption(SymbolStyleSearchResult res)
        {

            var ts = TaskScheduler.FromCurrentSynchronizationContext();
            // Task.Factory.StartNew
            // var t = new Task(async () =>
            Action a = new Action(async () =>
          {
              var mySymbol = await res.GetSymbolAsync().ConfigureAwait(false);
              // Create a swatch image from the symbol.
              RuntimeImage swatch = await mySymbol.CreateSwatchAsync(Constants._imageSize, Constants._imageSize, Constants._imageDPI, System.Drawing.Color.Transparent).ConfigureAwait(false);

              int h = swatch.Height; int w = swatch.Width;
              var symbolImage = await swatch.ToImageSourceAsync().ConfigureAwait(false); ;
              SymbolProperties symbolInfo = new SymbolProperties(res.Name, symbolImage.Clone(), res.Key, res.Category, res.SymbolClass, res.Tags);
              defaultSPlist.Add(symbolInfo);
              var symbolImage2 = await swatch.ToImageSourceAsync().ConfigureAwait(false); ;
          }
          );//,TaskCreationOptions.AttachedToParent);// TaskCreationOptions.AttachedToParent); TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent
            //   t.Start( ts);
            //  var t = Task.Factory.StartNew(a, new CancellationToken(), TaskCreationOptions.AttachedToParent, ts);
            var t = Task.Factory.StartNew(a, TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach);//| TaskCreationOptions.DenyChildAttach);
                                                                                                                         // var t = 
                                                                                                                         //      Task.Factory.StartNew(MyfunctionAsync, res, new CancellationToken(), TaskCreationOptions.AttachedToParent);
            return t;
        }*/

        static readonly Func<Task<Symbol>, object?, Task<RuntimeImage>> CreateSwatch = async (Task<Symbol> arg1, object obj) =>
        {
            Symbol sym = arg1.Result;
            return await sym.CreateSwatchAsync(Constants._imageSize, Constants._imageSize, Constants._imageDPI, System.Drawing.Color.Transparent); //.ConfigureAwait(false);
        };


        /*    static readonly Func<Task<Task<RuntimeImage>>, object?, Task<System.Windows.Media.ImageSource>> CreateImage = async (Task<Task<RuntimeImage>> arg1, object obj) =>
            {
                RuntimeImage watch = arg1.Result.Result;
                int h = watch.Height; int w = watch.Width;
                return await watch.ToImageSourceAsync();
            };

            static readonly Func<Task<Task<System.Windows.Media.ImageSource>>, object?, Task> CreateObject = (Task<Task<System.Windows.Media.ImageSource>> arg1, object obj) =>
           {  
               System.Windows.Media.ImageSource image = arg1.Result.Result;
               var res = obj as SymbolStyleSearchResult;

               var disp = System.Windows.Application.Current.Dispatcher;
               var tmp = disp.BeginInvoke(new Action(() =>
                {
                    var symbolInfo = new SymbolProperties(res.Name, image, res.Key, res.Category, res.SymbolClass, res.Tags);
                    defaultSPlist.Add(symbolInfo);
                }));
               return tmp.Task;
           };*/

        private static Symbol Mf(object arg)
        {
            SymbolStyleSearchResult res = arg as SymbolStyleSearchResult;
            return res.GetSymbolAsync().Result;//.ConfigureAwait(false);
        }

        public static Task CreateImageTasks(SymbolStyleSearchResult res)
        {
            try
            {
                Task<Symbol> t1 = new Task<Symbol>(Mf, res);
                Task<Task<RuntimeImage>> t2 = t1.ContinueWith(CreateSwatch, res, TaskContinuationOptions.AttachedToParent);
                t1.Start();
                return t2;
            }
            catch (Exception ex)
            {
                String s = ex.ToString();
            }

            return null;
        }

        public static Task CreateImageTaskSynch(SymbolStyleSearchResult res)
        {
            return Task.Run(() =>
            {
                var mySymbol = res.GetSymbolAsync().Result;// ;.ConfigureAwait(false); ;
                // Create a swatch image from the symbol.
                RuntimeImage swatch = mySymbol.CreateSwatchAsync(Constants._imageSize, Constants._imageSize, Constants._imageDPI, System.Drawing.Color.Transparent).Result;//.ConfigureAwait(false);

                int h = swatch.Height; int w = swatch.Width;
                var symbolImage = swatch.ToImageSourceAsync().Result;//.ConfigureAwait(false); ;
                SymbolProperties symbolInfo = new SymbolProperties(res.Name, symbolImage.Clone(), res.Key, res.Category, res.SymbolClass, res.Tags);
                defaultSPlist.Add(symbolInfo);
            });
        }

        // Unknown Symbol we have to create a new one
        public static SymbolProperties CreateNewSymbol(string codeSymbol)
        {

            System.Windows.Media.Imaging.BitmapSource Image = System.Windows.Media.Imaging.BitmapSource.Create
     (2, 2, Constants._imageSize, Constants._imageSize,// 96, 96,
      System.Windows.Media.PixelFormats.Indexed1,
      new System.Windows.Media.Imaging.BitmapPalette(new List<System.Windows.Media.Color> { System.Windows.Media.Colors.Transparent }),
      new byte[4],
      1);/* */

            // TODO utiliser + le code


            Color c = SymbolProperties.MilStandardColor_unfilled_symbols(codeSymbol);

            var textSymbol = new TextSymbol(codeSymbol, c, 10, Esri.ArcGISRuntime.Symbology.HorizontalAlignment.Center, Esri.ArcGISRuntime.Symbology.VerticalAlignment.Middle);


            //         RuntimeImage swatch = textSymbol.CreateSwatchAsync().Result;// Constants._imageSize, Constants._imageSize, Constants._imageDPI, System.Drawing.Color.Transparent).Result;//.ConfigureAwait(false);

            //      int h = swatch.Height; int w = swatch.Width;
            //   var symbolImage = swatch.ToImageSourceAsync().Result;//.ConfigureAwait(false); ;

            List<string> tags = new List<string> { codeSymbol };

            SymbolProperties symbolInfo = new SymbolProperties("Name", Image.Clone(), "", "", "", tags);
            symbolInfo.GraphicObject = textSymbol;

            // TODO : tracer al creation de ce symbole
            defaultSPlist.Add(symbolInfo);

            return symbolInfo;

        }
        public static Task CreateImageTaskSynch2(SymbolStyleSearchResult res)
        {
            Task t = new Task(() =>
            {
                var mySymbol = res.GetSymbolAsync().Result;// ;.ConfigureAwait(false); ;
                // Create a swatch image from the symbol.
                RuntimeImage swatch = mySymbol.CreateSwatchAsync(Constants._imageSize, Constants._imageSize, Constants._imageDPI, System.Drawing.Color.Transparent).Result;//.ConfigureAwait(false);

                int h = swatch.Height; int w = swatch.Width;
                var symbolImage = swatch.ToImageSourceAsync().Result;//.ConfigureAwait(false); ;
                SymbolProperties symbolInfo = new SymbolProperties(res.Name, symbolImage.Clone(), res.Key, res.Category, res.SymbolClass, res.Tags);
                defaultSPlist.Add(symbolInfo);
            });
            t.RunSynchronously(TaskScheduler.Current);
            return t;
        }


    }
}
