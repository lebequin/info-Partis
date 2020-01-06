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
using MaterialDesignThemes;
namespace InterPol
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager LeManager
        {
            get
            {
                return (Application.Current as App).LeManager;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            LeManager.ChargeClass();
            LeManager.ChargeRegion();
            LeManager.ChargePartis();
            LeManager.ChargeRepublique();
            LeManager.ChargeDocuments();
            DataContext = LeManager;
            mainPart.Content = factory["Accueil"]();
        }
        static Dictionary<string, Func<UserControl>> factory = new Dictionary<string, Func<UserControl>>()
        {
            ["Accueil"] = () => new PresentationParti(),
            ["Carte"] = () =>
            {
                var uc = new MapUC();
                Binding ListDateBinding = new Binding("LesDates2");
                ListDateBinding.Mode = BindingMode.OneWay;
                Binding AnneeSelectioneeBinding = new Binding("SelectedDate");
                AnneeSelectioneeBinding.Mode = BindingMode.TwoWay;
                Binding ListRegionBinding = new Binding("LesRegions");
                ListRegionBinding.Mode = BindingMode.OneWay;
                Binding RegionSelectionneeBinding = new Binding("SelectedRegion");
                RegionSelectionneeBinding.Mode = BindingMode.TwoWay;
                uc.SetBinding(MapUC.LesAnneesProperty, ListDateBinding);
                uc.SetBinding(MapUC.AnneeSelectionneeProperty, AnneeSelectioneeBinding);
                uc.SetBinding(MapUC.LesRegsProperty, ListRegionBinding);
                uc.SetBinding(MapUC.RegionSelectionneeProperty, RegionSelectionneeBinding);
                return uc;
            },
            ["Partis"] = () => new PartisUC(),
            ["Histoire"] = () => new HistoryUC(),
            ["Sondage"] = () => new SondageUC(),
            ["Documents"] = () => new Documentation(),
        };
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = (e.AddedItems[0] as ListBoxItem).Content as string;
            if (factory.ContainsKey(content))
            {
                mainPart.Content = factory[content]();
            }
        }
    }
}