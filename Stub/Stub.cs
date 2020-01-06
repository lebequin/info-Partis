using AppLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StubLib
{
    public class Stub : IDataManager
    {

        public IEnumerable<Master> ChargeClass()
        {
            return new List<Master>()
            {
                new Master {Categ="Accueil"},
                new Master {Categ="Carte"},
                new Master {Categ="Partis"},
                new Master {Categ="Histoire"},
                new Master {Categ="Documentation"},
                new Master {Categ="Sondage"},

            };

        }

        public void SauvegarderDocuments()
        {
            Debug.WriteLine("Le chargement se fait en xml");
        }

        public IEnumerable<Partis> ChargePartis()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> ChargeRegion()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Republique> ChargeRep()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Documents> ChargeDoc()
        {
            throw new NotImplementedException();
        }
    }
}

    

