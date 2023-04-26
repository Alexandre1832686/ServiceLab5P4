using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDonneLab5Partie4.model
{
    public class Student
    {
        private string _codePermanant,_nom,_prenom;
        private DateTime _naissance,_inscription,_diplome;
        private int _da;

        public Student()
        { }

        public Student(string codePermanant, string nom, string prenom, DateTime naissance, DateTime inscription, DateTime diplome, int da)
        {
            CodePermanant = codePermanant;
            Nom = nom;
            Prenom = prenom;
            Naissance = naissance;
            Inscription = inscription;
            Diplome = diplome;
            Da = da;

        }

        public string CodePermanant
        {
            get { return _codePermanant; }
            set { _codePermanant = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public int Da
        {
            get { return _da; }
            set { _da = value; }
        }
        public DateTime Naissance
        {
            get { return _naissance; }
            set { _naissance = value; }
        }
        public DateTime Inscription
        {
            get { return _inscription; }
            set
            {
                _inscription = value;
            }
        }
        public DateTime Diplome
        {
            get { return _diplome; }
            set { _diplome = value; }
        }


    }
}
