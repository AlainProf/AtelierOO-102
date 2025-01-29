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
        const int TAILLE = 1000000;
        int[] tabEntiers = new int[TAILLE];
        Humain[] tabGr102 = new Humain[TAILLE];
        string[] tabNoms = new string[10] { "Zakary", "Ubert", "Loïc", "David", "Liam", "Maxim", "LauryAn", "Emy", "Léa", "Saad" };

        List<int> listeEntiers = new();
        List<Humain> lstGr102 = new();

        Random r = new();

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
                lstGr102.Add(h);
            }

            u.Sep($"Liste contient {lstGr102.Count}");
            //AfficherListeH();
            u.Pause();

            u.Sep("Liste triée selon age:");
            lstGr102.Sort(ComparerAgeNoStatLocal);
            //AfficherListeH();
            u.Pause();

            u.Sep("Liste inversée:");
            lstGr102.Reverse();
            //AfficherListeH();
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
            if (a._naissance.Ticks > b._naissance.Ticks)
                return 1;
            if (a._naissance.Ticks < b._naissance.Ticks)
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
        public void ExploTableau()
        {

            u.Titre("Les tableaux en C#");


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
    }
}
