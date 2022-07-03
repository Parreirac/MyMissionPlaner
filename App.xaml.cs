using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Esri.ArcGISRuntime;
using MilitaryPlanner.ViewModels;

namespace MilitaryPlanner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

  //      static App() => SymbolLoader.Init(this.);// Test pour forcer le chargement de l'odb avant la création de la vue


        private void Application_Startup(object sender, StartupEventArgs e)  // REM : appel avant la création des views.
        {
            // Before initializing the ArcGIS Runtime first 
            // set the ArcGIS Runtime license by providing the license string 
            // obtained from the License Viewer tool.
            //ArcGISRuntime.SetLicense("Place the License String in here");

            // modif pra
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPKc242815f0b7c417e9cf134a41a19ceb5Uy8OhkyCd4Uzc52W9YchXPTDgKM4XcqLZwAhy2DGnepF67nhiyyqoPhG6dEcFHpZ";

            // Initialize the ArcGIS Runtime before any components are created.
            try
            {
                ArcGISRuntimeEnvironment.Initialize(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                // Exit application
                Shutdown();
            }

            //  pour forcer le chargement de l'odb avant la création de la vue
            DataLoader.Init();
                
              
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MilitaryPlanner.Properties.Settings.Default.Save();
        }
    }
}
