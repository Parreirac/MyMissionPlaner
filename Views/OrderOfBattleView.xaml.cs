using MilitaryPlanner.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MilitaryPlanner.Views
{
    /// <summary>
    /// Interaction logic for OrderOfBattleView.xaml
    /// </summary>
    public partial class OrderOfBattleView : UserControl
    {
        public OrderOfBattleView()
        {

            InitializeComponent();

            //          this.Loaded += new RoutedEventHandler(Control_Loaded);
            //          this.Initialized += new EventHandler(Control_Initialized);
        }


  /*      void Control_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= new RoutedEventHandler(Control_Loaded);  // On l'a supprime pour ne pas avoir d'appels ulterieurs
            var dc = this.DataContext as OrderOfBattleViewModel;
            if (dc != null)
                (dc as OrderOfBattleViewModel).ExpandGroupSymbol(null); // permet de forcer l'initialisation

        }
        
        void Control_Initialized(object sender, EventArgs e)   // TODO TEST PRA jamais d'appel ?
        {

        } */

      /*  private void OnLoaded(object sender, System.Windows.RoutedEventArgs e) // ajout pra, mais peut plus simple
                                                                               // de creer le model dans le constructeur et de la mettre DC
                                                                               // TODO PRA ? /!\ N'est pas appelé qu'une fois
        {
            var dc = (sender as Control).DataContext;
            if (dc != null)
            {
                (dc as OrderOfBattleViewModel).ExpandGroupSymbol(null); // permet de forcer l'initialisation
                string str = dc.ToString();
            }

        }*/

        //private void SymbolListBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    // Reset the selected item so that every mouse click of the listbox generates a selectionchanged event
        //    SymbolListBox.SelectedItem = null;
        //}
    }
}
