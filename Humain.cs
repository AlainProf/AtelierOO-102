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
        //-------------- Méthode Old-Fashionned

        /*private DateTime Naissance;
        
        public DateTime getNaissance()
        {
           return Naissance;
        }
        public void setNaissance(DateTime n)
        {
           Naissance = `n;
        }*/
        
        ///------------------ Métohde Property
        
        /*private DateTime Naissance;
        public DateTime Naissance 
        { 
            get 
            { 
                return Naissance; 
            } 
            set 
            { 
              Naissance = value
            } 
        }*/

        // Méthode automatic preoperty
        public DateTime Naissance { get; set; }

        public string Genre { get; set; }
        public string Nom { get; set; }
        public Adresse Domicile { get; set; }   

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain()
        {
            Nom = "inconnu";
            Naissance = new DateTime(1,1,1);
            Genre = "F";
            Domicile = new Adresse();   
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n)
        {
            Nom = n;
            Naissance = DateTime.Now;
            Genre = "F";
            Domicile = new Adresse();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, DateTime nais)
        {
            Nom = n;
            Naissance = nais;
            Genre = "F";
            Domicile = new Adresse();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, DateTime nais, string g)
        {
            Nom = n;
            Naissance = nais;
            Genre = g;
            Domicile = new Adresse();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"{Nom}, {Age()} ans");
            Domicile.Afficher();

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public long Age()
        {
            DateTime mtn = DateTime.Now;
            long ndSec = (mtn.Ticks - Naissance.Ticks)/ (10000000);
            long an = ndSec/(long)(60*60*24*365.24);
            return an;
            
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public static int ComparerLongeurNom(Humain a, Humain b)
        {
            if (a.Nom.Length > b.Nom.Length)
                return 1;

            if (a.Nom.Length < b.Nom.Length)
                return -1;

            return 0;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public static int ComparerNom(Humain a, Humain b)
        {
            return (a.Nom.CompareTo(b.Nom));
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
