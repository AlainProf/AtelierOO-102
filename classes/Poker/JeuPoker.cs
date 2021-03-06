using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    class JeuPoker
    {
        private static int _couleurTapis = 2; // Vert
        private static int _couleurTexte = 15; // Blanc

        public static readonly int NB_CARTES_PAR_MAIN = 5;
        public readonly int NB_JOUEURS;


        private Paquet lePaquet = new Paquet();

        private MainPoker[] MainsJoueurs;

        public JeuPoker(int nbJ = 4)
        {
            NB_JOUEURS = nbJ;
            MainsJoueurs = new MainPoker[NB_JOUEURS];
            for (int i = 0; i < NB_JOUEURS; i++)
            {
                MainsJoueurs[i] = new MainPoker();

            }
        }
        public int Jouer()
        {
            CouleurTapis();
            Console.Clear();
           lePaquet.Brasser();
            //lePaquet.Afficher();
            for (int i = 0; i < NB_JOUEURS * NB_CARTES_PAR_MAIN; i++)
            {
                Carte c = lePaquet.Distribuer();
                int indice = (int)(i / NB_JOUEURS);
                MainsJoueurs[i % NB_JOUEURS].AjouterCarte(indice, c);
            }

            for (int i = 0; i < NB_JOUEURS; i++)
            {
                MainsJoueurs[i].Afficher(i);
            }

            return 0;
        }

        public static void CouleurTapis()
        {
            Console.BackgroundColor = (ConsoleColor)_couleurTapis;
            Console.ForegroundColor = (ConsoleColor)_couleurTexte;

        }

    }
}
