using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022
{
    class Humain
    {
        string _nom;
        DateTime _naissance;
        DateTime _deces;
        Adresse _residence;

        public Humain()
        {
            _nom = "inconnu";
            _naissance = DateTime.Now;
            _deces = new DateTime(1, 1, 1);
            _residence = null;
        }
        public Humain(string n, DateTime na)
        {
            _nom = n;
            _naissance = na;
            _deces = new DateTime(1, 1, 1);
            _residence = null;
        }
        public Humain(string n, DateTime na, Adresse a)
        {
            _nom = n;
            _naissance = na;
            _deces = new DateTime(1, 1, 1);
            _residence = a;
        }
        public Humain(string n, DateTime na, DateTime de)
        {
            _nom = n;
            _naissance = na;
            _deces = de ;
            _residence = null;
        }

        public void Afficher()
        {
            Console.WriteLine("nom:{0}", _nom);
            Console.WriteLine("né le :{0}", _naissance);
            Console.WriteLine(" agé de {0}", Age());
            // commentaire
            if (!EstVivant())
            {
                Console.WriteLine("Décédé le " + _deces);
                Console.WriteLine("Il y a {0} ans ", AnneesDepuisDeces());
            }
            if (_residence != null)
            {
                Console.Write("domicilié au ");
                _residence.Afficher();
            }
            else
                Console.WriteLine("SDF");
        }

        private int Age()
        {
            long delta;
            if (EstVivant())
            {
                delta = DateTime.Now.Ticks - _naissance.Ticks;
            }
            else
            {
                delta = _deces.Ticks - _naissance.Ticks;
            }

            delta /= 10000000;
            delta = delta / ((long)365.24 * 24 * 3600);

            //Console.WriteLine("Delta:" + delta);
            return (int)delta;
        }
        private int AnneesDepuisDeces()
        {
            long delta = DateTime.Now.Ticks - _deces.Ticks;

            delta /= 10000000;
            delta = delta / ((long)365.24 * 24 * 3600);

            //Console.WriteLine("Delta:" + delta);
            return (int)delta;
        }

        public bool EstVivant()
        {
            return !(_deces.Ticks > 1000000000);
        }

        public void Mourir()
        {
            _deces = DateTime.Now;
        }
    }
}

