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

namespace InterPol.UserControls
{
    /// <summary>
    /// Logique d'interaction pour AjoutParti.xaml
    /// </summary>
    public partial class AjoutParti : Window
    {
        public AjoutParti()
        {
            InitializeComponent();
        }

        public Manager LeManager=> (Application.Current as App).LeManager;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("parti ajouté");
        }
    }
}
