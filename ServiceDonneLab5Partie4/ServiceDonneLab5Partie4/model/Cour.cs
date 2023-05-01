using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDonneLab5Partie4.model
{
    public class Cour
    {
        public string? Sigle { get; set; }
        public string? Titre { get; set; }
        public int Duree { get; set; }

        public Cour(string sigle, string titre, int duree)
        {
            Sigle = sigle;
            Titre = titre;
            Duree = duree;
        }
        public Cour()
        { }
    }
}
