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

        public Paquet()
        {
            int iter = 0;
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
            int iter = 0;
            for (int i = 0; i < 13; i++)
            {
                lesCartes[iter].Afficher();
                iter++;
            }
            Console.WriteLine();
            for (int i = 0; i < 13; i++)
            {
                lesCartes[iter].Afficher();
                iter++;
            }
            Console.WriteLine();
            for (int i = 0; i < 13; i++)
            {
                lesCartes[iter].Afficher();
                iter++;
            }
            Console.WriteLine();
            for (int i = 0; i < 13; i++)
            {
                lesCartes[iter].Afficher();
                iter++;
            }
            Console.WriteLine();
            return 0;
        }
    }
}
