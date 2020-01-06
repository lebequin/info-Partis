using System;
using AppLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace InterPol.TemplateSelectors
{
    class TypeDonneeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextTemplate
        {
            get;set;
        }

        public DataTemplate ImgTemplate
        {
            get; set;
        }

        public DataTemplate PodcastTemplate
        {
            get;set;
        }

        public DataTemplate VideoTemplate
        {
            get;set;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if(item is Text) return TextTemplate;
            if(item is Img) return ImgTemplate;
            if(item is Podcast) return PodcastTemplate;
            if (item is Video) return VideoTemplate;
            return base.SelectTemplate(item, container);
        }
         
    }
}
