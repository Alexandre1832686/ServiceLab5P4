using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        static string? _parametreApiKey;
        public string? ParametreApiKey
        {
            get { return _parametreApiKey; }
            set
            {
                _parametreApiKey = value;
                FileManager.EnregisterAPIKEY(value);
                ValeurChange("ParametreApiKey");
            }
        }

        public ProgramVM()
        {
            ApiHelper.InitializeClient();
            ParametreApiKey = FileManager.GetApiKey();
        }


        public async void GetNom(string codePerma)
        {
            RecupererNomNom = await ApiHelper.GetNomStudent(codePerma);
        }

    }
}
