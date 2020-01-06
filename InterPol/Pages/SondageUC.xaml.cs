using AppLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace InterPol
{
    /// <summary>
    /// Logique d'interaction pour SondageUC.xaml
    /// </summary>
    public partial class SondageUC : UserControl
    {
        public SondageUC()
        {
            InitializeComponent();
            
        }

        List<AddSondage> ListSondage = new List<AddSondage>();

        private void ValidationButton(object sender, RoutedEventArgs e)
        {
            if(ComboAge.SelectedItem is null || ComboRegion.SelectedItem is null)
            {
                MessageBox.Show("Les champs doivent être remplis");
            }
            else
            {
                MessageBox.Show("Votre vote a bien été validé");
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddSondage sondage = new AddSondage();
            if (ListSondage.Count == 2) { return; }
            sondage.Id = ListSondage.Count + 1;
            mSondage.RowDefinitions.Add(new RowDefinition());
            mSondage.Children.Add(sondage);
            sondage.SetValue(System.Windows.Controls.Grid.RowProperty, sondage.Id);
            ListSondage.Add(sondage);
        }

        private void Supp(object sender, RoutedEventArgs e)
        {
            int nb = ListSondage.Count;
            if (nb == 0) { return; }

            AddSondage sondage = ListSondage.ElementAt(nb - 1);
            mSondage.Children.Remove(sondage);
            mSondage.RowDefinitions.RemoveAt(nb);
            ListSondage.RemoveAt(nb - 1);
        }
        /*
        Chart.DataContext = new KeyValuePair<Partis, int>[] {


                                    new KeyValuePair<Partis, int>(Partis, 10),


                                    new KeyValuePair<Partis, int>(Nom, 11),


                                    new KeyValuePair<Partis, int>(Nom, votes.Value()),


                                    new KeyValuePair<Partis, int>(Nom, votes.Value()),


                                    new KeyValuePair<Partis, int>(Nom, votes.Value()) 
        };*/
}
}
