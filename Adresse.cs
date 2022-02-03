using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022
{
    class Adresse
    {
        string _numCivique;
        string _rue;
        string _ville;


        public Adresse(string nc, string r, string v)
        {
            _numCivique = nc;
            _rue = r;
            _ville = v;
        }

        public void Afficher()
        {
            Console.WriteLine(_numCivique + " rue {0}" + ", ville {1}", _rue, _ville);
        }
    }
}
