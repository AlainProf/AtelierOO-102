//---------------------------------------------
//   Fichier : 
//   Créateur: Alain Martel
//   Date    : 
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Adresse
    {
        public string NumCivique { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }

        //---------------------------------------------
        //
        //---------------------------------------------
        public Adresse()
        {
            NumCivique = "0";
            Rue = "rue sans nom";
            Ville = "Bidonville";
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Adresse(string nc, string r, string v)
        {
            NumCivique = nc;
            Rue = r;
            Ville = v;
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"{NumCivique} {Rue}, {Ville}");
        }



    }
}
