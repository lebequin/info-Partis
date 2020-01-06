using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleLib
{
    class ArticleParti : Article
    {
        private string Presentation { get; set; }
        private string Objectifs { get; set; }
        private string ImgCamp { get; set; }
        private string ImgStaff { get; set; }

        private Dictionary<string, int> liens = new Dictionary<string, int>();

    }
}
