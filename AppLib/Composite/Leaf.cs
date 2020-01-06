using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Leaf : Item
    {
        public Leaf(string nom) : base(nom)
        {
        }

        public override void AffichDebug()
        {
            Debug.WriteLine(nom);
        }

        public override void AjouterFils(Item i)
        {
            Debug.WriteLine("on ne peut pas ajouter dans la feuille");
        }

        public override void SupprimerFils(Item i)
        {
            Debug.WriteLine("on ne peut pas supprimer dans la feuille");
        }
    }
}
