using AppLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace InterPol
{
    /// <summary>
    /// Logique d'interaction pour AddDoc.xaml
    /// </summary>
    public partial class AddDoc : Window
    {
        public AddDoc()
        {
            InitializeComponent();
            animWin();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                LocalLinkInput.Text = Directory.GetCurrentDirectory();
                LeManager.docs.Add(LocalLinkInput.Text);
            }
        }

        public Manager LeManager
        {
            get
            {
                return (Application.Current as App).LeManager;
            }
        }

        private void OpenLink(object sender, RoutedEventArgs e)
        {
            LeManager.docs.Add(URLLinkInput.Text);
        }

        void animWin()
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 2000;
            anim.AccelerationRatio = 0.3;
            anim.DecelerationRatio = 0.3;
            anim.Duration = TimeSpan.FromSeconds(1);
            AddDocTop.BeginAnimation(DockPanel.WidthProperty, anim);
        }
    }
}
