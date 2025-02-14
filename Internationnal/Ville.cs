using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Internationnal
{
    internal class Ville
    {
        Util _u = new();
        public string Nom { get; set; }
        public CoordGeo Position { get; set; }
        public int Population { get; set; }

        CoordGeo coordTmp = new(0, 0);

        public Ville(string n = "pandemonium", CoordGeo p = null, int pop = 0)
        {
            Nom = n;
            Position = p;
            Population = pop;
        }

        public void Afficher()
        {
            _u.Sep(Nom);
            Console.Write(" Située à ");
            Position.Afficher();
            Console.WriteLine($"{Population} habitants");
        }

        public static int ComparerPop(Ville va, Ville vb)
        {
            if (va.Population > vb.Population)
            {
                return 1;
            }
            if (va.Population < vb.Population)
            {
                return -1;
            }
            return 0;
        }


        public static int CompareEst(Ville va, Ville vb)
        {
            if (va.Position.Longitude > vb.Position.Longitude)
            {
                return 1;
            }
            if (va.Position.Longitude < vb.Position.Longitude)
            {
                return -1;
            }
            return 0;
        }
        public static int CompareNord(Ville va, Ville vb)
        {
            if (va.Position.Latitude > vb.Position.Latitude)
            {
                return 1;
            }
            if (va.Position.Latitude < vb.Position.Latitude)
            {
                return -1;
            }
            return 0;
        }

    }
}
