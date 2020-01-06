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
    /// Logique d'interaction pour MapUC.xaml
    /// </summary>
    public partial class MapUC : UserControl
    {
        public Manager LeManager => (Application.Current as App).LeManager;
        

        public MapUC()
        {
            InitializeComponent();
            animDate();
        }
       /// <summary>
       /// Methode permettant de faire l'animation sur les titres.
       /// </summary>
        void animDate()
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 100;
            anim.To = 500;
            anim.AccelerationRatio = 0.33;
            anim.DecelerationRatio = 0.33;
            anim.Duration = TimeSpan.FromSeconds(1);
            ResMap.BeginAnimation(ContentControl.WidthProperty, anim);
        }



        public IEnumerable<DateTime> LesAnnees
        {
            get { return (IEnumerable<DateTime>)GetValue(LesAnneesProperty); }
            set { SetValue(LesAnneesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LesAnnees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LesAnneesProperty =
            DependencyProperty.Register("LesAnnees", typeof(IEnumerable<DateTime>), typeof(MapUC), new PropertyMetadata(new List<DateTime>(), (s, e) => { }));



        public DateTime AnneeSelectionnee
        {
            get { return (DateTime)GetValue(AnneeSelectionneeProperty); }
            set { SetValue(AnneeSelectionneeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AnneeSelectionnee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AnneeSelectionneeProperty =
            DependencyProperty.Register("AnneeSelectionnee", typeof(DateTime), typeof(MapUC), new PropertyMetadata(DateTime.Now));



        public IEnumerable<Region> LesRegs
        {
            get { return (IEnumerable<Region>)GetValue(LesRegsProperty); }
            set { SetValue(LesRegsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LesRegions2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LesRegsProperty =
            DependencyProperty.Register("LesRegs", typeof(IEnumerable<Region>), typeof(MapUC), new PropertyMetadata(new List<Region>(), (s, e) => { }));



        public Region RegionSelectionnee
        {
            get { return (Region)GetValue(RegionSelectionneeProperty); }
            set { SetValue(RegionSelectionneeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegionSelectionnee.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegionSelectionneeProperty =
            DependencyProperty.Register("RegionSelectionnee", typeof(Region), typeof(MapUC));


    }
}