using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using ServiceDonneLab5Partie4.model;

namespace ServiceDonneLab5Partie4.vue_model
{
    internal class ProgramVM : INotifyPropertyChanged
    {

        #region INotifyPropertyChange
        public event PropertyChangedEventHandler PropertyChanged;


        //Fonction qui gère le lancement de l'événément PropertyChanged
        protected virtual void ValeurChange(string nomPropriete)
        {
            //Vérifie si il y a au moins 1 abonné
            if (this.PropertyChanged != null)
            {
                //Lance l'événement -> tous les abonnés seront notifiés
                this.PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
            }
        }

        #endregion

        string _recupererNomNom;
        public string RecupererNomNom
        {
            get { return _recupererNomNom; }
            set 
            {
                _recupererNomNom = value;
                ValeurChange("RecupererNomNom");
            }
        }
        string _generatedApiKey;
        public string GeneratedApiKey
        {
            get { return _generatedApiKey; }
            set
            {
                _generatedApiKey = value;
                ValeurChange("GeneratedApiKey");
            }
        }

        static string? _parametreApiKey;
        static public string? ParametreApiKey
        {
            get 
            {
                _parametreApiKey = FileManager.GetApiKey();
                return _parametreApiKey;
            }
            set
            {
                _parametreApiKey = value;
                FileManager.EnregisterAPIKEY(value);
            }
        }

        List<Cour> _listeCourParEtu;
        public List<Cour> ListeCourParEtu
        {
            get { return _listeCourParEtu; }
            set { _listeCourParEtu = value;
                ValeurChange("ListeCourParEtu");
            }
        }
        List<Student> _listeEtuParCour;
        public List<Student> ListeEtuParCour
        {
            get { return _listeEtuParCour; }
            set
            {
                _listeEtuParCour = value;
                ValeurChange("ListeEtuParCour");
            }
        }
        List<Cour> _listeCourParProf;
        public List<Cour> ListeCourParProf
        {
            get { return _listeCourParProf; }
            set
            {
                _listeCourParProf = value;
                ValeurChange("ListeCourParProf");
            }
        }
        Buletin _BuletinEtu;
        public Buletin BuletinEtu
        {
            get { return _BuletinEtu; }
            set
            {
                _BuletinEtu = value;
                ValeurChange("BuletinEtu");
            }
        }
        List<Student> _listeDiplome;
        public List<Student> ListeDiplome
        {
            get { return _listeDiplome; }
            set
            {
                _listeDiplome = value;
                ValeurChange("ListeDiplome");
            }
        }
        string repCreeCour;
        public string RepCreeCour
        {
            get { return repCreeCour; }
            set { repCreeCour = value;
                ValeurChange("RepCreeCour");
            }
        }

        public ProgramVM()
        {
            ApiHelper.InitializeClient();
            ParametreApiKey = FileManager.GetApiKey();
        }

        public async void GetNom(string codePerma)
        {
            if(await ApiHelper.checkApiKey(ParametreApiKey))
                RecupererNomNom = await ApiHelper.GetNomStudent(codePerma);
            else
            {
                RecupererNomNom = "Clee invalide";
            }
        }

        public async void GenerateApiKey()
        {
            GeneratedApiKey = await ApiHelper.GenerateApiKey();
        }

        public async void GetcourParEtu(string codePerma)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                ListeCourParEtu = await ApiHelper.GetListeCourParEtu(codePerma);
            }
            else
            {
                ListeCourParEtu = new List<Cour>();
            }
        }
        public async void GetEtuParCour(string nomCour)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                ListeEtuParCour = await ApiHelper.GetListeEtuParCour(nomCour);
            }
            else
            {
                ListeEtuParCour = new List<Student>();
            }
        }

        public async void GetCourParProf(string prenom, string nom)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                ListeCourParProf = await ApiHelper.GetListeCourParProf(prenom, nom);
            }
            else
            {
                ListeCourParProf = new List<Cour>();
            }
        }
        public async void GetBuletin(string prenom, string nom)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                BuletinEtu = await ApiHelper.GetBuletin(prenom, nom);
            }
            else
            {
                BuletinEtu = new Buletin();
            }
        }
        public async void GetDiplomeParAnnee(string annee)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                ListeDiplome = await ApiHelper.GetDiplomeParAnnee(annee);
            }
            else
            {
                ListeDiplome = new List<Student>();
            }
        }

        public async void CreeCour(string Sigle, string Titre, string Duree)
        {
            if (await ApiHelper.checkApiKey(ParametreApiKey))
            {
                RepCreeCour = await ApiHelper.CreeCour(Sigle, Titre, Duree);
            }
            else
            {
                RepCreeCour = "Clee invalide";
            }
            
        }
    }
}
