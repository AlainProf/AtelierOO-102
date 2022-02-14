using atelier2022.classes;
using atelier2022.classesExplo;
using System;

namespace atelier2022
{
    /// <summary>
    /// Programme démontrant toutes les notions enseignées ds le cours 2C6 POO
    /// </summary>
    class Program
    {
        static Menu MenuPrincipal = new Menu("Atelier 2C6 POO");
        static void Main(string[] args)
        {
            MenuPrincipal.AjouterItem(new MenuItem("Lecture de fichiers", 'L', ExploManipFichiers.ExploLectureFichier));
            MenuPrincipal.AjouterItem(new MenuItem("Ecriture de fichiers", 'E', ExploManipFichiers.ExploEcritureFichier));
            MenuPrincipal.AjouterItem(new MenuItem("Classe Humain", 'H', Exploration.ExploHumain));
            MenuPrincipal.AjouterItem(new MenuItem("Rendement d'un dépôt", 'R', Exploration.CalculerRendementErgo));
            MenuPrincipal.AjouterItem(new MenuItem("Remboursement d'un prêt", 'P', Exploration.CalculerRemboursementPret));
            MenuPrincipal.AjouterItem(new MenuItem("Tableau d'entiers", 'T', Exploration.ArrayInt));
            MenuPrincipal.AjouterItem(new MenuItem("Tableau d'instances", 'A', Exploration.ArrayHumain));
            ManipListe ml = new();
            MenuPrincipal.AjouterItem(new MenuItem("Liste d'instances", 'I', ml.ListeHumains));

            MenuPrincipal.Afficher();
            MenuPrincipal.SaisirChoix();
            //MenuOld();
        }

        /// <summary>
        /// Affcihage du menu principal du programme
        /// Obsolete: on utilise mtn les menu OO
        /// </summary>
        public static void MenuOld()
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
                        Exploration.ExploHumain();
                        break;
                    case 'D':
                        Console.Clear();
                        Exploration.CalculerRendementErgo();
                        break;
                    case 'P':
                        Console.Clear();
                        Exploration.CalculerRemboursementPret();
                        break;
                    case 'A':
                        Console.Clear();
                        Exploration.ArrayInt();
                        break;
                    case 'R':
                        Console.Clear();
                        Exploration.ArrayHumain();
                        break;
                    case 'L':
                        Console.Clear();
                        ManipListe ml = new();
                        ml.ListeHumains();
                        break;
                }
                Console.ReadKey();
                Options();
            }
        }

        /// <summary>
        /// Affcihage des options du menu principal
        /// /// Obsolete: on utilise mtn les menu OO
        /// </summary>
        static void Options()
        {
            AfficherEntete();
            Console.WriteLine("\tH:  Exploration de Humain");
            Console.WriteLine("\tD:  Rendement d'un dépôt");
            Console.WriteLine("\tP:  Remboursement d'un prêt");
            Console.WriteLine("\tA:  Array d'entiers en C#");
            Console.WriteLine("\tR:  Array d'Humain");
            Console.WriteLine("\tL:  Liste d'Humain");

            Console.WriteLine("\n\tESC: pour Quitter");
            Console.Write("\t\tVotre choix:");
            
        }

        /// <summary>
        /// Entête formattée joliment du menu  
        /// Obsolete: on utilise mtn les menu OO
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

    }
}
