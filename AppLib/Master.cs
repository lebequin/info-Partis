using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Master
    {
        private string categ;

        public string Categ
        {
            get { return categ; }
            set { categ = value; }
        }

        public override string ToString()
        {
            return $"{Categ}";
        }
    }
}
