using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public interface IDataManager
    {
        IEnumerable<Master> ChargeClass();
        IEnumerable<Region> ChargeRegion();
        IEnumerable<Partis> ChargePartis();
        IEnumerable<Republique> ChargeRep();
        IEnumerable<Documents> ChargeDoc();
        void SauvegarderDocuments();
    }
}
