using atelier2022.classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atelier2022
{
    /// <summary>
    /// Classe utilitaire pour Menu et différents ateliers
    /// </summary>
    public class Exploration
    {

        /// <summary>
        /// Initiation à l'orienté objet. Entre autres : la classe, les propriétés, méthodes, niveau d'encapsulation, ...
        /// composition
        /// </summary>
        public static int ExploHumain()
        {
            System.DateTime dt = new System.DateTime(1964, 7, 17);
            Humain h2 = new Humain("Alain", dt);

            h2.Afficher();

            Humain h3 = new Humain("Winston Churchill", new DateTime(1874, 11, 30), new DateTime(1965, 1, 24));
            h3.Afficher();

            Adresse a1 = new Adresse("13761", "Côtes des corbeilles", "Mirabel");

            Humain h4 = new("Marianne P. M.", new DateTime(1989, 04, 20), new Adresse("1234", "Cartier", "Laval"));
            h4.Afficher();
            return 0;
        }

        /// <summary>
        /// Calcul du rendement d'un dépôt en boucle 
        /// </summary>
        public static int CalculerRendementErgo()
        {
            double rendementCumul;
            SaisirParametreDepot(out double depot, out double tauxInt, out int duree, out string compo);
            rendementCumul = depot;

            int tempsCumul = 0;
            int freqComp = 1;
            switch (compo)
            {
                case "m": freqComp = 12; break;
                case "q": freqComp = 365; break;
            }


            while (tempsCumul < duree * freqComp)
            {
                tempsCumul++;
                rendementCumul += (tauxInt / freqComp) * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul.ToString(".00"));
            return 0;
        }

        /// <summary>
        /// Permet de saisir les paramètres de calcul désiré par l'utilisateur
        /// </summary>
        /// <param name="depot">Le dépôt initial</param>
        /// <param name="tauxInt">taux d'intérêt annuel</param>
        /// <param name="duree">nombre d'années où le dépôt fructifiera</param>
        /// <param name="compo">fréqwuence de composition de l'intérêt</param>
        static void SaisirParametreDepot(out double depot, out double tauxInt, out int duree, out string compo)
        {
            string strDepot;
            string strTauxInt;
            string strDuree;

            Console.WriteLine("Depot:");
            strDepot = Console.ReadLine();
            Console.WriteLine("Intérêt:");
            strTauxInt = Console.ReadLine();
            Console.WriteLine("Durée:");
            strDuree = Console.ReadLine();
            Console.WriteLine("Composition de l'intérêt:");
            compo = Console.ReadLine();
            Console.WriteLine("Paramètres:\nDépôt: {0}\nTaux intérêt:{1}\nDurée:{2}", strDepot, strTauxInt, strDuree);
            depot = Convert.ToDouble(strDepot);
            tauxInt = Convert.ToDouble(strTauxInt);
            duree = Convert.ToInt32(strDuree);
        }

        /// <summary>
        /// Saisie des paramètres et Calcul du temps nécessaire pour rembourser une dette
        /// </summary>
        public static int CalculerRemboursementPret()
        {
            //string strPaiementMinimum;
            string strInteret;
            string strPaiementMensuel;
            string strBalance;

            Console.WriteLine("Balance:");
            strBalance = Console.ReadLine();
            Console.WriteLine("taux d'intérêt:");
            strInteret = Console.ReadLine();
            Console.WriteLine("remboursement mensuel:");
            strPaiementMensuel = Console.ReadLine();
            CalculerRemboursement(Convert.ToDouble(strBalance), Convert.ToDouble(strInteret), Convert.ToDouble(strPaiementMensuel));
            return 0;
        }

        /// <summary>
        ///  Calcul du temps nécessaire pour rembourser une dette
        /// </summary>
        /// <param name="bal">La balance du prêt à rembourser</param>
        /// <param name="inte">Taux d'intéêt annuel sur la dette</param>
        /// <param name="mens">Remboursement mensuels</param>
        static void CalculerRemboursement(double bal, double inte, double mens)
        {
            double residu = bal;
            Console.WriteLine("Credit de {0} à {1}% avec mensualité de {2} ", residu, inte * 100, mens);
            int nbMois = 0;
            double interetCumul = 0;

            Console.WriteLine("Mois | intérêt | intérêt cum | Capital");
            Console.WriteLine("______________________________________");

            while (residu > 0)
            {
                nbMois++;
                residu -= mens - ((residu * inte) / 12);
                interetCumul += (residu * inte) / 12;
                StringBuilder s = new();
                s.AppendFormat("{0}\t{1}\t{2}\t{3}", nbMois, ((residu * inte) / 12).ToString(".00"), interetCumul.ToString(".00"), (mens - (residu * inte) / 12).ToString(".00"));
                Console.WriteLine(s);
            }
            Console.WriteLine("\nRéglement du prêt en {0} mois", nbMois);
        }

        /// <summary>
        /// Manip des Array en C#: initialisation, parcours, tri, ...
        /// </summary>
        public static int ArrayInt()
        {
            ManipArray.Introduction();
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int ArrayHumain()
        {
            ManipArray.ArrayDInstance();
            return 0;
        }

        public static int ExploCouleur()
        {
            Console.WriteLine("Arc en ciel");

            int nbCol = Console.WindowWidth;
            int nbLignes = Console.WindowHeight;
            int nbCouleurs = Enum.GetValues(typeof(ConsoleColor)).Length;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            /* Console.Write("blanc sur noir");

             Console.BackgroundColor = ConsoleColor.Red;
             Console.ForegroundColor = ConsoleColor.Yellow;

             Console.Write("jaune sur rouge");*/

            
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < nbLignes; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)(i % nbCouleurs);
                    for (int j = 0; j < nbCol; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, i);
                    //Thread.Sleep(5);
                }

                for (int i = 0; i < nbCol; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)(i % nbCouleurs);
                    for (int j = 0; j < nbLignes; j++)
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(i, j);
                    }
                    //Thread.Sleep(5);
                }


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("{0} car de large par {1} car de haut", MaxLargeur, MaxHauteur);


            return 0;
        }

        public static int CielEtoile()
        {
            int nbCol = Console.WindowWidth;
            int nbLignes = Console.WindowHeight;
            int nbCouleurs = Enum.GetValues(typeof(ConsoleColor)).Length;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Random alea = new();

            while (true)
            {
                for (int i = 0; i < (nbCol * nbLignes); i++)
                {
                    int x = alea.Next(nbCol);
                    int y = alea.Next(nbLignes);
                    int back = alea.Next(nbCouleurs);
                    while (back == 0)
                        back = alea.Next(nbCouleurs);

                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = (ConsoleColor)back;
                    Console.Write(" ");
                    Thread.Sleep(1);
                }
            }

            return 0;

        }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public static int ExploStackNQueue()
        {
            Stack<Carte> pioche = new Stack<Carte>();

            pioche.Push(new Carte(10, 3));
            pioche.Push(new Carte(9, 1));
            pioche.Push(new Carte(3, 3));
            pioche.Push(new Carte(0, 1));

            while(pioche.Count > 0)
            {
                Carte tempo = pioche.Pop();
                tempo.Afficher(0, 0);
                Console.ReadLine();
            }

            Queue<Humain> ListeAttente = new();

            ListeAttente.Enqueue(new Humain("William", new DateTime(2000, 1, 1)));
            ListeAttente.Enqueue(new Humain("Julius", new DateTime(2002, 1, 1)));
            ListeAttente.Enqueue(new Humain("Vincent", new DateTime(2004, 1, 1)));
            ListeAttente.Enqueue(new Humain("Alain", new DateTime(1964, 1, 1)));


            while (ListeAttente.Count > 0)
            {
                Humain tempo = ListeAttente.Dequeue();
                tempo.Afficher();
                Console.ReadLine();
            }




            return 0;
        }
    }
}
