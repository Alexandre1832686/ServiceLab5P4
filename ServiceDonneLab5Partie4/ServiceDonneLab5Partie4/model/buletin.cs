using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDonneLab5Partie4.model
{
    public class Buletin
    {
        public Cour? Cour { get; set; }
        public int Note { get; set; }


        public Buletin(Cour cour, int note)
        {
            Cour = cour;
            Note = note;
        }
        public Buletin()
        { }
    }
}
