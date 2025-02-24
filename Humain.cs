//---------------------------------------------
//   Fichier : Humain.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------

using AtelierOO_102.donnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Humain : IComparable<Humain> 
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

        public int CompareTo(Humain lautre)
        {
            if (this.Domicile.Ville.CompareTo(lautre.Domicile.Ville) == 1)
                return 1;
            if (this.Domicile.Ville.CompareTo(lautre.Domicile.Ville) == -1)
                return -1;

            if (this.Domicile.Rue.CompareTo(lautre.Domicile.Rue) == 1)
                return 1;
            if (this.Domicile.Rue.CompareTo(lautre.Domicile.Rue) == -1)
                return -1;

            return(this.Domicile.NumCivique.CompareTo(lautre.Domicile.NumCivique));

        }

        Util _u = new();

        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain()
        {
            //_u.Sep("Cons Humain par défaut");
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
            //_u.Sep("Cons Humain 1 param");

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
            //_u.Sep("Cons Humain 3 param");
            Nom = n;
            Naissance = nais;
            Genre = g;
            Domicile = new Adresse();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public Humain(string n, DateTime nais, string g, Adresse dom)
        {
            Nom = n;
            Naissance = nais;
            Genre = g;
            Domicile = dom;
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public virtual void Afficher()
        {
            Console.Write($"{Nom}, {Age()} ans");
           // Domicile.Afficher();

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
        public static int ComparerAge(Humain a, Humain b)
        {
            if (a.Age() > b.Age())
                return 1;
            if (a.Age() < b.Age())
                return -1;
            return 0;
        }

        public static Humain GenererAlea()
        {
            Util u = new();
            int ip = u.rdm.Next(0, 200);


            // Les 102 premiers prénoms sont féminins
            string sexe = "M";
            if (ip <= 102)
                sexe = "F";

            int ifa = u.rdm.Next(0, 200);

            string nomTmp = donneesBrutes.tabPrenoms[ip] + " " + donneesBrutes.tabFamilles[ifa];
            DateTime nais = new DateTime(u.rdm.Next(1926, 2024), u.rdm.Next(1, 13), u.rdm.Next(1, 29));

            int ir = u.rdm.Next(0,500);
            int iv = u.rdm.Next(0, 50);

            Adresse dom = new Adresse(u.rdm.Next(19, 1960).ToString(), donneesBrutes.tabRues[ir], donneesBrutes.tabVilles[iv] );

            int tirage = u.rdm.Next(0, 1000);
            
            // Si vrai on intantie un étudiant
            if (tirage % 3 == 0 )
            {
                DateTime dateMin = new DateTime(2008, 2, 1);
                DateTime dateMax = new DateTime(1975, 2, 1);
                if (nais.Ticks > dateMax.Ticks && nais.Ticks < dateMin.Ticks)
                {
                    int iprog = u.rdm.Next(0, 115);
                    int tirageStag = u.rdm.Next(0, 5);
                    if (tirageStag % 5 == 3)
                    {
                        int iEntrep = u.rdm.Next(0, 50);
                        return (new Stagiaire(nomTmp, nais, sexe, dom,
                            donneesBrutes.tabProgs[iprog], u.rdm.Next(10, 100),
                            donneesBrutes.tabEntreprises[iEntrep], u.rdm.Next(0, 17000)));
                    }

                    return (new Etudiant(nomTmp, nais, sexe, dom, donneesBrutes.tabProgs[iprog], u.rdm.Next(10, 100)));
                }
            }
            return (new Humain(nomTmp, nais, sexe, dom));
        }

    }


}
