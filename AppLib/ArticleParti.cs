using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    class ArticleParti
    {
        public string Presentation {
            get
            {
                return presentation;
            }
            set
            {
               presentation = value;

            }
        }
        private string presentation;
        private string Objectifs { get; set; }
        private string ImgCamp { get; set; }
        private string ImgStaff { get; set; }

        private Dictionary<string, int> liens = new Dictionary<string, int>();

    }
}
