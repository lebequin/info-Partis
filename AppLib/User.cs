using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLib
{
    public class User : IDataErrorInfo
    {
        public List<Documents> mesDoc = new List<Documents>();
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        private string region;

        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int age;

        /// <summary>
        /// Méthode permmettant l'ajout d'un document choisi par l'utilisateur
        /// </summary>
        /// <param name="d"></param>
        public List<Documents> AddDocument(Documents d)
        {
            if (mesDoc.Contains(d))
            {
                Debug.WriteLine("Document déjà existant");

            }
            else
            {
                mesDoc.Add(d);
            }
            return mesDoc;
        }
        /// <summary>
        /// Méthode permmettant la suppression d'un document choisi par l'utilisateur
        /// </summary>
        /// <param name="d"></param>
        public void DeleteDocuments(Documents d)
        {
            if (mesDoc.Contains(d))
            {
                mesDoc.Remove(d);
            }
            else
            {
                Debug.WriteLine("Document introuvable");
            }
        }

        /// <summary>
        /// Méthode permettant de vérifier que l'age et la région de la personne soumettant le sondage a bien été vérifié
        /// </summary>
        /// <param name="columnError"></param>
        /// <returns></returns>
        public string this[string columnError]
        {
            get
            {
                switch (columnError)
                {
                    case nameof(Region): 
                        if(region is null)
                        {
                            return "Veuillez saisir votre région pour valider";
                        }
                        break;
                    case nameof(Age):
                        if (age == 0)
                        {
                            return "Veuillez choisir votre tranche d'age";
                        }
                        break;
                }
                return string.Empty;
            }
        }

        public string Error { get; }
    }

}
