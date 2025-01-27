using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Explo
    {
        Util u = new Util();
        public void ExploTableau()
        {
            u.Titre("Les tableaux en C#");
            int[] tabEntiers = new int[10];

            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = i*2;  
            }


            Console.WriteLine("Contenu du Tab:");
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine($"Iten {i}: {tabEntiers[i]}");            }
        }
    }
}
