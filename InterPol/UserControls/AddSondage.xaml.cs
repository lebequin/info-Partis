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
    /// Logique d'interaction pour AddSondage.xaml
    /// </summary>
    public partial class AddSondage : UserControl
    {
        public AddSondage()
        {
            InitializeComponent();
        }

        public int Id
        {
            get
            {
                return mId;
            }
            internal set
            {
                mId = value;
            }
        }
        private int mId;
    }
}
