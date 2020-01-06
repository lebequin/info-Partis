using InterPol.UserControls;
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
    /// Logique d'interaction pour PartisUC.xaml
    /// </summary>
    public partial class PartisUC : UserControl
    {
        public PartisUC()
        {
            InitializeComponent();
            animMenu();
        }
        void animMenu()
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 500;
            anim.AccelerationRatio = 0.33;
            anim.DecelerationRatio = 0.33;
            anim.Duration = TimeSpan.FromSeconds(1);
            BackMenu.BeginAnimation(DockPanel.WidthProperty, anim);
        }
        private void ShowPopup(object sender, RoutedEventArgs e)
        {
            AjoutParti p = new AjoutParti();
            p.Show();
        }
    }
}
