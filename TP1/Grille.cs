using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.TP1
{
    internal class Grille
    {
        Colonne[] _colonnes = new Colonne[Puissance4.LARGEUR_GRILLE];

        public Grille()
        {
            for (int i = 0; i < Puissance4.LARGEUR_GRILLE; i++)
            {
                _colonnes[i] = new Colonne(i);   
            }
        }

        public void Afficher()
        {
            Console.SetCursorPosition(0, Puissance4.DECALAGE_TITRE);
            Console.WriteLine("  A    B    C    D    E    F    G");
            foreach (Colonne uneColonne in _colonnes)
            {
                uneColonne.Afficher();
            }
        }

        public void InsererJeton(int col, string contenu )
        {
            _colonnes[col].InsererJeton(contenu);
        }
    }
}
