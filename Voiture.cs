using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Voiture
    {
        public string Marque { get; set; }

        public Voiture(string marque)
        {
            Marque = marque;    
        }

        public void Afficher()
        {
            Console.WriteLine($"{Marque}");
        }



    }
}
