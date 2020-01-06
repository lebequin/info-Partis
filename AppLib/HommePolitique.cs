using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    class HommePolitique
    {
        

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string nom;

        

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        private DateTime dateDebut;

        

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }
        private DateTime dateFin;


        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        private string image;



    }
}
