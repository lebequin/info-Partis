using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Text : Leaf
    {
        public Text(string type) : base(type)
        {

        }
        private string titre;

        private string texte;
    }
}
