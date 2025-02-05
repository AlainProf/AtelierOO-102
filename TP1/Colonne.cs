using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.TP1
{
    internal class Colonne
    {
        Case[] _cases = new Case[Puissance4.HAUTEUR_GRILLE];

        public Colonne(int numCol)
        {
            for (int i = 0; i < Puissance4.HAUTEUR_GRILLE; i++)
            {
                _cases[i] = new Case(numCol, i);
            }
        }

        public void Afficher()
        {
            foreach (Case uneCase in _cases)
            {
                uneCase.Afficher();
            }
        }

        public void InsererJeton(string symbole)
        {
            _cases[0].Contenu = symbole; 
        }
    }
}
