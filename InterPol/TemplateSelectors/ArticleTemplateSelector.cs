 using System;
using AppLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InterPol
{
    class ArticleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ArticleRepTemplate
        {
            get; set;
        }

        public DataTemplate ArticlePartiTemplate
        {
            get; set;
        }

        public DataTemplate ArticleDocTemplate
        {
            get; set;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Partis) return ArticlePartiTemplate;
            if (item is Republique) return ArticleRepTemplate;
            if (item is Documents) return ArticleDocTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
