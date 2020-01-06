using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    class Composite : Item
    {
        private List<Item> child = new List<Item>();

        public Composite(string nom) : base(nom)
        {

        }
        public override void AffichDebug()
        {
            Debug.WriteLine("--");
        }

        public override void AjouterFils(Item i)
        {
            child.Add(i);
        }

       

        public override void SupprimerFils(Item i)
        {
            child.Remove(i);
        }

    }
}
