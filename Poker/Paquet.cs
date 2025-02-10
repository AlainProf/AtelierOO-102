using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Poker
{
    internal class Paquet
    {
        Carte[] lesCartes = new Carte[52];   

        public Paquet(bool melanger=false)
        {
            int iter = 0;
            Util u = new();

            if (!melanger)
            {

                for (int s = 0; s < 4; s++)
                {
                    for (int v = 0; v < 13; v++)
                    {
                        lesCartes[iter] = new Carte(s, v);
                        iter++;
                    }
                }
            }
            else
            {
                for(int i = 0; i < 52; i++)
                {
                    lesCartes[i] = new Carte(u.rdm.Next(0, 4), u.rdm.Next(0, 13));
                }
                Array.Sort(lesCartes, Carte.ComparerValeur);
            }
        }

       public void Afficher()
        {
            foreach(Carte c in lesCartes)
            {
                c.Afficher();   
            }
        }

    }
}
