using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class Sondage
    {
        private readonly int VotingPoints = 10; //nombre de points de l'utilisateur limité à 10
        private int NbChoix = 0;
        private Dictionary<Partis, int> votes = new Dictionary<Partis, int>();


        /// <summary>
        /// Méthode permettant de savoir le nombre de points de vote restant à l'utilisateur 
        /// </summary
        public int UsedPoints
        {
            get
            {
                return votes.Sum(kpv => kpv.Value);
            }
            set { usedPoints = value; }
        }
        private int usedPoints;

        private int PointsRestants()
        {
            return VotingPoints - UsedPoints;
        }

        public IEnumerable<int> Points() => new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10
        };

    }

}

