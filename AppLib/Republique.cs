using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppLib
{
    public class Republique : IEquatable<Republique>
    {
        public string Num { get; set; }

        private string num;

        public string Carte {get; set;}
        private string carte;

        public string Texte { get; set; }
        private string texte;

        /// <summary>
        /// Méthode equals pour verifier que chaque République n'existe qu'une seule fois en fonction de leur numéro
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Republique);
        }

        public bool Equals(Republique other)
        {
            return Num.Equals(other.Num);
        }

        public override int GetHashCode()
        {
            return Num.GetHashCode();
        }
    }
}
