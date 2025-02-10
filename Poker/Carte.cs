using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Poker
{
    enum SorteCarte
    {
        Pique,
        Trefle,
        Carreau,
        Coeur
    }

    enum ValeurCarte
    {
        deux,
        trois, 
        quatre,
        cinq,
        six,
        sept,
        huit,
        neuf,
        dix,
        valet,
        dame,
        roi,
        _as
    }

    internal class Carte
    {
        int _valeur;
        int _sorte;
        Util u = new();

        public Carte()
        {
            _valeur = (int)ValeurCarte.deux;
            _sorte = (int)SorteCarte.Pique;
        }
        public Carte(int s, int v)
        {
            _valeur = (int)(ValeurCarte)v;
            _sorte = (int)(SorteCarte)s;
        }

        public void Afficher()
        {
            if (_valeur== 12)
            {
                u.Sep($"as de {(SorteCarte)_sorte}");
            }
            else
            {
                u.Sep($"{(ValeurCarte)_valeur} de {(SorteCarte)_sorte}");
            }
        }

        public static int ComparerValeur(Carte ca, Carte cb)
        {
            if (ca._valeur > cb._valeur)
            {
                return 1;
            }
            if (ca._valeur < cb._valeur)
            {
                return -1;
            }
            return 0;   
        }
    }
}
