using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Region : INotifyPropertyChanged, IEquatable<Region>
    {
        public string Nom { get; set; }

        public int NbHabitants { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public string Lien
        {
            get { return mlien; }
            set { mlien = value; OnPropertyChanged("Lien"); }
        }
        private string mlien = String.Empty;

        /// <summary>
        /// Méthode equals pour verifier que chaque Région n'existe qu'une seule fois en fonction de leur nom
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as Region);
        }

        public bool Equals(Region other)
        {
            return Nom.Equals(other.Nom);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }



    }
}
