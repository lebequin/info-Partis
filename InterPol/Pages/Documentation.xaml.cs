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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterPol
{
    /// <summary>
    /// Logique d'interaction pour Documentation.xaml
    /// </summary>
    public partial class Documentation : UserControl
    {
        public Manager LeManager
        {
            get
            {
                return (Application.Current as App).LeManager;
            }
        }

        public Documentation()
        {
            InitializeComponent();
            animMenu();
        }
       
        private void ShowPopup(object sender, RoutedEventArgs e)
        {
            AddDoc w = new AddDoc();
            w.Show();
        }
        /// <summary>
        /// Methode permettant de faire l'animation sur les titres.
        /// </summary>
        void animMenu()
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 500;
            anim.AccelerationRatio = 0.33;
            anim.DecelerationRatio = 0.33;
            anim.Duration = TimeSpan.FromSeconds(1);
            BackMenu.BeginAnimation(Rectangle.WidthProperty, anim);
        }
    }
}
