using System;

namespace atelier2022
{
    /// <summary>
    /// Classe utilitaire pour Menu et différents atelier
    /// </summary>
    public class Util
    {
        /// <summary>
        /// Menu principal du programme
        /// </summary>
        public static void Menu()
        {
            ConsoleKeyInfo touche;
            Console.Clear();
            Options();
            while ((touche = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                switch ((Char)touche.Key)
                {
                    case 'H':
                        Console.Clear();
                        ExploHumain();
                        break;
                    case 'F':
                        Console.Clear();
                        Financier();
                        break;
                }
                Options();
            }
        }

        /// <summary>
        /// Affcihage des options du menu principal
        /// </summary>
        static void Options()
        {
            AfficherEntete();
            Console.WriteLine("\tH:  Exploration de Humain");
            Console.WriteLine("\tF:  Le Financier");

            Console.WriteLine("\n\tESC: pour Quitter");
            Console.Write("\t\tVotre choix:");
        }

        /// <summary>
        /// Entête du menu formatté joliment 
        /// </summary>
        static void AfficherEntete()
        {
            string entete = "\nOptions de l'atelier du cours POO 2C6";

            for (int i = 0; i < entete.Length; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine(entete);
            for (int i = 0; i < entete.Length; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Initiation à l'orienté objet. Entre autres : la classe, les propriétés, méthodes, niveau d'encapsulation
        /// composition
        /// </summary>
        static void ExploHumain()
        {
            System.DateTime dt = new System.DateTime(1964, 7, 17);
            Humain h2 = new Humain("Alain", dt);

            h2.Afficher();

            Humain h3 = new Humain("Winston Churchill", new DateTime(1874, 11, 30), new DateTime(1965, 1, 24));
            h3.Afficher();

            Adresse a1 = new Adresse("13761", "Côtes des corbeilles", "Mirabel");

            Humain h4 = new("Marianne P. M.", new DateTime(1989, 04, 20), new Adresse("1234", "Cartier", "Laval"));
            h4.Afficher();
        }

        /// <summary>
        ///   Introduction au C# avec des calculs finaciers procéduraux de placements et de dettes
        /// 
        /// </summary>
        static void Financier()
        {
            bool go = true;
            ConsoleKey cle;

            while (go)
            {
                Console.Clear();
                Console.WriteLine("Le Financier!");
                CalculerRendementErgo();

                Console.WriteLine("appuyez une touche pour continuer ou ESC pour quitter");
                cle = Console.ReadKey(true).Key;
                if (cle == ConsoleKey.Escape)
                    go = false;
            }
            //CalculerRemboursementPret();
        }


        /// <summary>
        /// Calcul du rendement d'un dépôt en boucle 
        /// </summary>
        static void CalculerRendementErgo()
        {
            double depot;
            double tauxInt;
            int duree;
            string compo;
            double rendementCumul;

            SaisirParametreDepot(out depot, out tauxInt, out duree, out compo);
            rendementCumul = depot;

            int tempsCumul = 0;

            switch (compo)
            {
                case "a":
                    while (tempsCumul < duree)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                case "m":
                    while (tempsCumul < duree * 12)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt / 12 * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                case "q":
                    while (tempsCumul < duree * 365)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt / 365 * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                default:
                    Console.WriteLine("ERREUR: Le choix de composition {0} est invalide", compo);
                    break;

            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul.ToString(".00"));
        }

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

    static void CalculerRendement()
        {
            double Depot = 1000;
            double tauxInt = 0.10;
            int duree = 35;
            double rendementCumul = Depot;

            int tempsCumul = 0;
            while (tempsCumul < duree)
            {
                tempsCumul++;
                rendementCumul += tauxInt * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul);
            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul);
        }

        static void CalculerRemboursementPret()
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
        }

        static void CalculerRemboursement(double bal, double inte, double mens)
        {
            double residu = bal;
            Console.WriteLine("Credit de {0} à {1}% avec mensualité de {2} ", residu, inte * 100, mens);
            int nbMois = 0;
            double interetCumul = 0;
            while (residu > 0)
            {
                Console.Write("Mois {0}, intéret: {1} Capital: {2} ", nbMois + 1,
                                                        (residu * inte / 12).ToString(".00"),
                                                        (mens - (residu * inte / 12)).ToString(".00"));
                residu -= mens - ((residu * inte) / 12);
                interetCumul += (residu * inte) / 12;
                Console.WriteLine(" balance à payer : {0}. Intérêt cumulé: {1}", residu.ToString(".00"), interetCumul.ToString(".00"));
                nbMois++;
            }
            Console.WriteLine("Réglement du prêt en {0} mois", nbMois);
        }
    }
}
