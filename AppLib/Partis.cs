using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace AppLib
{
    public class Partis : IEquatable<Partis>
    {

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string nom;

        public string Representant { get; set; }

        public string Description { get; set; }

        public string Biographie { get; set; }

        public string Img { get; set; }

        public string Logo { get; set; }
        
        public override string ToString()
        {
            return $"{Nom} ({Description}) {Representant}";
        }
        /// <summary>
        /// Méthode equals pour verifier que chaque Parti n'existe qu'une seule fois en fonction de leur nom
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Partis);
        }

        public bool Equals(Partis other)
        {
            return Nom.Equals(other.Nom);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}