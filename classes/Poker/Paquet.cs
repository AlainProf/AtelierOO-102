using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    class Paquet
    {
        Carte[] lesCartes = new Carte[52];

        private int _curseur;

        public Paquet()
        {
            int iter = 0;
            _curseur = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    lesCartes[iter] = new Carte(j, i);
                    iter++;
                } 
            }
        }

        public int Afficher()
        {
            JeuPoker.CouleurTapis();
            Console.Clear();
            int iter = 0;
            for (int i = 0; i < 52; i++)
            {
                lesCartes[iter].Afficher(i%13, i/13);
                iter++;
            }
            return 0;
        }

        public void Brasser()
        {
            Random alea = new();

            for (int i = 52-1; i > 1; i--)
            {
                //tirage au sort d'uin index entre 0 et la valeur courante de i
                int randomIndex = alea.Next(i);

                //permutation entre la carte[randomIndex] et la carte[i]
                Carte temp = lesCartes[i];
                lesCartes[i] = lesCartes[randomIndex];
                lesCartes[randomIndex] = temp;
            }
        }

        public Carte Distribuer()
        {
            if (_curseur > 51)
            {
                Exception e = new Exception("Impossible de rejoindre la carte");
                throw (e);
            }
            return lesCartes[_curseur++];
        }
    }
}
