using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace AppLib
{
    public class Manager : INotifyPropertyChanged
    {

        public ReadOnlyCollection<Master> LeMaster { get; private set; }
        public ReadOnlyCollection<Region> LesRegions { get; private set; }
        public ReadOnlyCollection<Partis> LesPartis { get; private set; }
        public ReadOnlyCollection<Republique> LesRep { get; private set; } 
        public ReadOnlyCollection<Documents> LesDocuments { get; private set; }


        public IEnumerable<Carte> LesDates => lesDates;

        private List<Carte> lesDates = new List<Carte>()
        {
            new Carte { Date =new DateTime(2007, 1, 1)},
            new Carte { Date =new DateTime(2012, 1, 1)},
            new Carte { Date =new DateTime(2017, 1, 1)},
        };

        public IEnumerable<DateTime> LesDates2 => LesDates.Select(c => c.Date);

        static List<Partis> lesPartis = new List<Partis>();
        static List<Republique> lesReps = new List<Republique>();
        static List<Region> lesRegions = new List<Region>();
        static List<Documents> lesDocs = new List<Documents>();
        IEnumerable<Documents> trieParType = lesDocs.OrderBy(d => d.Type).ThenBy(d => d.DateAjout);
        IEnumerable<Documents> trieParDate = lesDocs.OrderBy(d => d.DateAjout).ThenBy(d => d.Type);

        
        List<Master> leMaster = new List<Master>();
        public List<string> docs = new List<string>();

        IDataManager DataManager { get; set; }

        //injection de dépendance
        public Manager(IDataManager dataManager)
        {
            LeMaster = new ReadOnlyCollection<Master>(leMaster);
            LesRep = new ReadOnlyCollection<Republique>(lesReps);
            LesPartis = new ReadOnlyCollection<Partis>(lesPartis);
            LesRegions = new ReadOnlyCollection<Region>(lesRegions);
            LesDocuments = new ReadOnlyCollection<Documents>(lesDocs);
            
            DataManager = dataManager;
        }


        public void ChargeClass()
        {
            leMaster.AddRange(DataManager.ChargeClass());
        }
        public void ChargePartis()
        {
            lesPartis.AddRange(DataManager.ChargePartis());
        }
        public void ChargeRepublique()
        {
            lesReps.AddRange(DataManager.ChargeRep());
        }
        public void ChargeRegion()
        {
            lesRegions.AddRange(DataManager.ChargeRegion());
        }
        public void ChargeDocuments()
        {
            lesDocs.AddRange(DataManager.ChargeDoc());
        }
        
        public void SauveDocuments()
        {
        }
        public void AjoutDoc(User u, Documents d)
        {
            u.AddDocument(d);
        }

        

        public Master SelectedCateg
        {
            get { return selectedCateg; }
            set { selectedCateg = value; }
        }
        private Master selectedCateg;

        public Partis SelectedPartis
        {
            get; set;
        }
  
        public Republique SelectedRep
        {
            get; set;
        }

        public Region SelectedRegion
        {
            get
            {
                return selectedRegion;
            }
            set
            {
                selectedRegion = value; OnPropertyChanged(nameof(ImgCarte));
            }
        }
        private Region selectedRegion = new Region { Nom = "default" } ;

        public Carte SelectedCarte
        {
            get
            {
                return selectedCarte;
            }
            set
            {
                selectedCarte = value; OnPropertyChanged(nameof(ImgCarte));
            }
        }
        private Carte selectedCarte = new Carte { Date = new DateTime(1, 1, 1) };

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        
        public DateTime SelectedDate
        {
            set
            {
                SelectedCarte = LesDates.SingleOrDefault(c => c.Date == value);
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;

        public string ImgCarte => $"../images/ResPresidentielles/{SelectedCarte.Date.Year.ToString()}/{SelectedRegion.Nom}{SelectedCarte.Date.Year.ToString()}.png";
    }
     
}
