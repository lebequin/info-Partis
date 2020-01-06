using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Podcast : Leaf
    {
        public Podcast(string type) : base(type)
        {
        }

        public string Lien { get; set; }
    }
}
