//---------------------------------------------
//   Fichier : 
//   Créateur: Alain Martel
//   Date    : 
//---------------------------------------------
using AtelierOO_102.Poker;
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
        const int TAILLE = 10;
        int[] tabEntiers = new int[TAILLE];
        Humain[] tabGr102 = new Humain[TAILLE];
        string[] tabNoms = new string[10] { "Zakary", "Ubert", "Loïc", "David", "Liam", "Maxim", "LauryAn", "Emy", "Léa", "Saad" };

        List<int> listeEntiers = new();
        List<Humain> lstGr102 = new();

        Random r = new();


        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploRefOut()
        {
            int param = 7;
            u.Titre("Explo des ref et out");
            methode1(param);
            u.Sep($"out methode 1 :{param}");

            methode2(ref param);
            u.Sep($"out methode 2 :{param}");

            methode3(out int param2);
            u.Sep($"out methode 3 :{param2}");
            u.Pause();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        void methode1(int p)
        {
            u.Sep($"in methode 1 :{p}");
            p *= 2;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        void methode2(ref int p)
        {
            u.Sep($"in methode 2 :{p}");
            p *= 3;

        }
        //---------------------------------------------
        //
        //---------------------------------------------
        void methode3(out int  p)
        {
            p = 42;
            u.Sep($"in methode 3 :{p}");
            p *= 4; 
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploListeH()
        {

            u.Titre("Listes en C#");

            u.Sep($"Liste contient {lstGr102.Count}");

            for (int i = 0; i < TAILLE; i++)
            {
                Humain h = new Humain(tabNoms[i%10], new DateTime(r.Next(1964, 2008), r.Next(1, 13), r.Next(1, 29)));
                Adresse dom = new("1234", "rue de la paix", "Rimouski");
                h.Domicile = dom;
                lstGr102.Add(h);
            }

            u.Sep($"Liste contient {lstGr102.Count}");
            AfficherListeH();
            u.Pause();

            u.Sep("Liste triée selon age:");
            lstGr102.Sort(ComparerAgeNoStatLocal);
            AfficherListeH();
            u.Pause();

            u.Sep("Liste inversée:");
            lstGr102.Reverse();
            AfficherListeH();
            u.Pause();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void AfficherListeH()
        {
            for (int i = 0; i < lstGr102.Count; i++)
            {
                Console.Write($"{i}:");
                lstGr102[i].Afficher();
            }
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploListe()
        {

            u.Titre("Listes en C#");

            u.Sep($"Liste contient {listeEntiers.Count}");

            for (int i = 0; i < TAILLE; i++)
            {
                listeEntiers.Add(r.Next(1, 101));
            }

            u.Sep($"Liste contient {listeEntiers.Count}");
            AfficherListe();
            u.Pause();

            u.Sep("Liste triée:");
            listeEntiers.Sort();
            AfficherListe();
            u.Pause();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void AfficherListe()
        {
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                Console.WriteLine($"{i} : {listeEntiers[i]}");
            }
        }



        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploTableauH()
        {

            u.Titre("Tableaux d'Humains");


            for (int i = 0; i < tabGr102.Length; i++)
            {
                tabGr102[i] = new Humain(tabNoms[i], new DateTime(r.Next(1964, 2008), r.Next(1, 13), r.Next(1, 29)));
            }

            u.Sep("Groupe 102:");
            AfficherTabH();
            u.Pause();

            u.Sep("Gr 102 trié par nom:");
            Array.Sort(tabGr102, Humain.ComparerNom);
            AfficherTabH();
            u.Pause();

            u.Sep("Gr 102 trié par long nom:");
            Array.Sort(tabGr102, Humain.ComparerLongeurNom);
            AfficherTabH();
            u.Pause();

            u.Sep("Gr 102 trié par age:");
            Humain dummy = new Humain();
            Array.Sort(tabGr102, dummy.ComparerAgeNoStat);
            AfficherTabH();
            u.Pause();

            u.Sep("Gr 102 trié par naissance:");
            Array.Sort(tabGr102, ComparerAgeNoStatLocal);
            AfficherTabH();
            u.Pause();

            /*
            u.Sep("Tab trié:");
            Array.Sort(tabEntiers);
            AfficherTab();
            u.Pause();

            u.Sep("Tab inverse:");
            Array.Reverse(tabEntiers);
            AfficherTab();
            u.Pause();*/
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public int ComparerAgeNoStatLocal(Humain a, Humain b)
        {
            if (a.Naissance.Ticks > b.Naissance.Ticks)
                return 1;
            if (a.Naissance.Ticks < b.Naissance.Ticks)
                return -1;
            return 0;

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void AfficherTabH()
        {
            for (int i = 0; i < tabGr102.Length; i++)
            {
                tabGr102[i].Afficher();
            }
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        double divParZ(int den)
        {
            int i = 1000;
            return i / den;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploTableau()
        {

            u.Titre("Les tableaux en C#");

            divParZ(0);


            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = r.Next(1, 11);
            }


            u.Sep("Contenu du Tab:");
            AfficherTab();
            u.Pause();

            u.Sep("Tab inverse:");
            Array.Reverse(tabEntiers);
            AfficherTab();
            u.Pause();


            u.Sep("Tab trié:");
            Array.Sort(tabEntiers);
            AfficherTab();
            u.Pause();

            u.Sep("Tab inverse:");
            Array.Reverse(tabEntiers);
            AfficherTab();
            u.Pause();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void AfficherTab()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine($"Iten {i}: {tabEntiers[i]}");
            }
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExecEnum()
        {
            u.Titre("Exploration des enum");

            int j = 2;
            JourSemaine aujh ;

            bool indValide = Enum.IsDefined(typeof(JourSemaine), j);
            if (indValide)
            {
                aujh = (JourSemaine)j;
            }
            else
            {
                Console.WriteLine($"{j} n'est pas un indice valide de mon enum");
                aujh = JourSemaine.Vendredi;

            }

            JourSemaine dem = (JourSemaine)(++j);

            u.Sep($"Nous somme {aujh}, demain sera {dem}");


            JourSemaine jourX = JourSemaine.Dimanche;
            int jx = (int)jourX;

            u.Sep($"Dimanche est le {jx}ième jour de l'enum");

            u.Pause();

            Carte c1 = new Carte();
            c1.Afficher();

            Carte c2 = new Carte(u.rdm.Next(0, 4), u.rdm.Next(0, 13));
            c2.Afficher();

            u.Pause();

            Paquet paq = new();
            paq.Afficher();
            u.Pause();

            paq = new(true);
            paq.Afficher();
            u.Pause();

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExecExceptions()
        {
            string nomFichier = "d:\\alino\\popu.txt";
            try
            {
                u.Titre("Les exceptions en C#");

                StreamReader reader = new StreamReader(nomFichier);
                u.Sep("Fichier ouvert");
                u.Pause();  
            }
            catch(Exception ex)
            {
                // Console.WriteLine($"Exception: incapable d'ouvrir le ficher {nomFichier}");
                throw (new Exception($"incapable d'ouvrir le ficher {nomFichier}"));
            }
        }

        public void ExecHeritage()
        {
            u.Titre("Héritage en C#");
           // Etudiant e = new();
           // e.Afficher();

            //e = new("1234567", "tech info", 0.95);
            //e.Afficher();

            //e = new("Xavier", new DateTime(2007,02,28), "M", "1234567", "tech info", 0.95);
            //e.Afficher();

            Stagiaire stag = new("Xavier", new DateTime(2007, 02, 28), "M", "1234567", "tech info", 0.95, "Hydro-Québec", 22.34);
            stag.Afficher();


            u.Pause();

        }
    }
}

