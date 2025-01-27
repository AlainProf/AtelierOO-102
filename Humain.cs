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
        DateTime _naissance;
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
            Console.WriteLine($"{_nom}: né le {_naissance}");
            Console.WriteLine($"Agé de {Age()} ans");
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public long Age()
        {
            DateTime mtn = DateTime.Now;
            return (mtn.Ticks - _naissance.Ticks);
            //duree = duree / (long)(86400 * 365.24);
            //return duree;  //24*60*60
        }

    }


}
