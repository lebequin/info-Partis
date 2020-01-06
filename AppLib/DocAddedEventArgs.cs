using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    class DocAddedEventArgs : EventArgs
    {
        /// <summary>
        /// nouvelle information
        /// </summary>
        public string Info { get; private set; }
        
        /// <summary>
        /// constructeur de la classe DocAddedEventArgs
        /// </summary>
        /// <param name="info">nouvelle information</param>
        public DocAddedEventArgs(string info)
        {
            Info = info;
        }
    }
}
