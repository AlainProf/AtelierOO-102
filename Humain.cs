//---------------------------------------------
//   Fichier : Humain.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Humain
    {
        string _nom;
        public DateTime _naissance;
        string _genre;

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain()
        {
            _nom = "inconnu";
            _naissance = new DateTime(1,1,1);
            _genre = "F";
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n)
        {
            _nom = n;
            _naissance = DateTime.Now;
            _genre = "F";
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, DateTime nais)
        {
            _nom = n;
            _naissance = nais;
            _genre = "F";
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, DateTime nais, string g)
        {
            _nom = n;
            _naissance = nais;
            _genre = g;
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"{_nom}, {Age()} ans");

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public long Age()
        {
            DateTime mtn = DateTime.Now;
            long ndSec = (mtn.Ticks - _naissance.Ticks)/ (10000000);
            long an = ndSec/(long)(60*60*24*365.24);
            return an;
            
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public static int ComparerLongeurNom(Humain a, Humain b)
        {
            if (a._nom.Length > b._nom.Length)
                return 1;

            if (a._nom.Length < b._nom.Length)
                return -1;

            return 0;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public static int ComparerNom(Humain a, Humain b)
        {
            return (a._nom.CompareTo(b._nom));
        }

        public int ComparerAgeNoStat(Humain a, Humain b)
        {
            if (a.Age() > b.Age())
                return 1;
            if (a.Age() < b.Age())
                return -1;
            return 0;   

        }

    }


}
