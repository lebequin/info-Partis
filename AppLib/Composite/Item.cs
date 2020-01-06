using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public abstract class Item : IEquatable<Item>
    {
        protected string nom;

        public Item(string nom)
        {
            this.nom = nom;
        }

        public abstract void AffichDebug();

        public abstract void AjouterFils(Item i);
        public abstract void SupprimerFils(Item i);

        public bool Equals(Item other)
        {
            return nom.Equals(other.nom);
        }
    }
}