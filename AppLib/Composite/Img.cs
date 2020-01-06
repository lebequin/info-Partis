using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Img : Leaf
    {
        public Img(string type) : base(type)
        {
        }
        public string Lien { get; set; }
    }
}
