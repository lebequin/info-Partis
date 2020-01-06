using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Documents : IEquatable<Documents>
    {
        private string lien;

        public string Lien
        {
            get { return lien; }
            set { lien = value; }
        }
        

        public string DateAjout
        {
            get { return dateAjout; }
            set { dateAjout = value; }
        }
        private string dateAjout;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string type;

        /* event EventHandler<DocAddedEventArgs> DocAdded;

        public virtual void OnDocAdded(DocAddedEventArgs args)
        {
            DocAdded?.Invoke(this, new DocAddedEventArgs(args));
        }*/
        

        /// <summary>
        /// Méthode equals pour verifier que chaque Document n'existe qu'une seule fois en fonction de leur lien 
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Documents);
        }

        public override int GetHashCode()
        {
            return Lien.GetHashCode();
        }

        public bool Equals(Documents other)
        {
            return Lien.Equals(other.Lien);
        }
    }
}
