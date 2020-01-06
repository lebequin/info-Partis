using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Video : Leaf
    {
        public Video(string type) : base(type)
        {
        }

        public string Lien {
            get
            {
                return lien;
            }
            set {
                lien = value;
            }
        }
        private string lien;
    }
}
