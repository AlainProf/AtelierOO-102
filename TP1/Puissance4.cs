using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.TP1
{
    internal class Puissance4
    {
        public static readonly int LARGEUR_GRILLE = 7;
        public const int DECALAGE_TITRE = 10;
        public const int HAUTEUR_GRILLE = 6;
        Util u = new Util();
        Grille _grille = new();
        bool partieTerminee = false;
        string joueurActif = "x";
        public void Jouer()
        {
            u.Titre("Puissance 4!!!!");
            _grille.Afficher();
            while (!partieTerminee)
            {
                TraiterProchainCoup();
            }
            u.Pause();
        }

        void TraiterProchainCoup()
        {
            int numCol = SaisirColonne();
            _grille.InsererJeton(numCol, joueurActif);
            _grille.Afficher();
            if (joueurActif == "x")
                joueurActif = "o";
            else
                joueurActif = "x";
        }

        int SaisirColonne()
        {
            Console.Write("Votre choix:");
            char choix = u.SaisirChar();

            switch (choix)
            {
                case ('a'): return 0;
                case ('b'): return 1;
                case ('c'): return 2;
                case ('d'): return 3;
                case ('e'): return 4;
                case ('f'): return 5;
                case ('g'): return 6;
            }
            return 0;
        }
    }
}
