//---------------------------------------------
//   Fichier : Humain.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Humain
    {
        string _nom;
        string _naissance;
        string _genre;

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain()
        {
            _nom = "inconnu";
            _naissance = "2999-12-31";
            _genre = "F";
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, string nais, string g)
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
        }

    }


}
