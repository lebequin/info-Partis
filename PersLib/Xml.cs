 using AppLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PersLib
{
    public class Xml : IDataManager
    {
        public static IEnumerable<Partis> ListPartis = new List<Partis>();
        public static IEnumerable<Republique> ListRep = new List<Republique>();
        public static IEnumerable<Region> ListRegion = new List<Region>();
        public static IEnumerable<Documents> ListDocuments = new List<Documents>();
        /// <summary>
        /// Méthode permettant la lecture du fichier XML contenant les différents partis politiques
        /// </summary>
        public static void LirePartiXMLFile()
        {
            
            XDocument partisFichier = XDocument.Load("PartisXml.xml");
            ListPartis = partisFichier.Descendants("Parti").Select(typeParti => new Partis()
            {
                Nom = typeParti.Attribute("Nom").Value,
                Representant = typeParti.Element("Representant").Value,
                Description = typeParti.Element("Description").Value,
                Biographie = typeParti.Element("Biographie").Value,
                Img = typeParti.Element("img").Value,
                Logo = typeParti.Element("logo").Value,
            }).ToList();
        }

        /// <summary>
        /// Méthode permettant la lecture du fichier XML correspondant aux différentes républiques de la page Histoire
        /// </summary>
        public static void LireRepubliqueXMLFile()
        {
            XDocument repFichier = XDocument.Load("RepXml.xml");
            ListRep = repFichier.Descendants("republique").Select(typeRep => new Republique()
            {
                Num = typeRep.Attribute("num").Value,
                Texte = typeRep.Element("text").Value,
                Carte = typeRep.Element("carte").Value,

            }).ToList();
            
        }

        public static void LireRegionXMLFile()
        {
            XDocument regFichier = XDocument.Load("RegionXml.xml");
            ListRegion = regFichier.Descendants("Region").Select(typeReg => new Region()
            {
                Nom = typeReg.Attribute("Nom").Value,
                Top = XmlConvert.ToInt16(typeReg.Attribute("Top").Value),
                Left = XmlConvert.ToInt16(typeReg.Attribute("Left").Value),
            }).ToList();
        }

        public static void LireDocumentXMLFile()
        {
            XDocument docFichier = XDocument.Load("SauvegardeDocs.xml");
            ListDocuments = docFichier.Descendants("Document").Select(typeDoc => new Documents()
            {
                Lien = typeDoc.Attribute("Lien").Value,
                DateAjout = typeDoc.Element("DateAjout").Value,
                Type = typeDoc.Element("Type").Value,
            }).ToList();

 
        }
        private static void EcrireDocuments()
        {
            XDocument docSauvegarde = new XDocument();

            var doc = ListDocuments.Select(Document => new XElement("Document",
                                            new XAttribute("Lien", Document.Lien),
                                            new XElement("DateAjout", Document.DateAjout),
                                            new XElement("Type", Document.Type)));

            docSauvegarde.Add(new XElement("Document", doc));

            docSauvegarde.Save("SauvegardeDocs.xml");
        }

        public void SauvegarderDocuments()
        {
            EcrireDocuments();
        }

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

        public IEnumerable<Partis> ChargePartis()
        {
            LirePartiXMLFile();
            return ListPartis;
        }

        public IEnumerable<Region> ChargeRegion()
        {
            LireRegionXMLFile();
            return ListRegion;
        }

        public IEnumerable<Republique> ChargeRep()
        {
            LireRepubliqueXMLFile();
            return ListRep;
        }

        public IEnumerable<Documents> ChargeDoc()
        {
            LireDocumentXMLFile();
            return ListDocuments;
        }
    }
}
