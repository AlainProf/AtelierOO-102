using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022
{
    /// <summary>
    /// Classe représentant un lieu sur terre
    /// </summary>
    class Adresse
    {
        /// <summary>
        /// Numéro civique de la porte
        /// </summary>
        public string NumCivique;
        /// <summary>
        /// Rue où est situé l'adresse
        /// </summary>
        public string Rue;
        /// <summary>
        /// ville de l'adresse
        /// </summary>
        public string Ville;


        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="nc">numéro civique</param>
        /// <param name="r">rue</param>
        /// <param name="v">ville</param>
        public Adresse(string nc, string r, string v)
        {
            NumCivique = nc;
            Rue = r;
            Ville = v;
        }

        public void Afficher()
        {
            Console.WriteLine(NumCivique + " rue {0}" + ", ville {1}", Rue, Ville);
        }
    }
}
