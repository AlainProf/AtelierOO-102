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

        static  string _back;
        static  string _fore;
        static string _nbJoueurs;
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        Console.WriteLine("Arg {0}:  {1}", i, args[i]);

                    }
                }
                _back = args[0];
                _fore = args[1];
                _nbJoueurs = args[2];

                //Console.ReadLine();
                initCouleurEcran();
                //Carte c = new();
                //MenuPrincipal.AjouterItem(new MenuItem("Une Carte design", 'C', c.Afficher));
                JeuPoker partiePoker = new(Convert.ToInt32(_nbJoueurs));
                MenuPrincipal.AjouterItem(new MenuItem("Poker", 'K', partiePoker.Jouer));
                MenuPrincipal.AjouterItem(new MenuItem("Ciel étoilé ", 'I', Exploration.CielEtoile));
                MenuPrincipal.AjouterItem(new MenuItem("Couleur de la console", 'O', Exploration.ExploCouleur));
                MenuPrincipal.AjouterItem(new MenuItem("Stack et Queue ", 'S', Exploration.ExploStackNQueue));
                /*            MenuPrincipal.AjouterItem(new MenuItem("Explo Héritage", 'H', ExploHeritage.ExplorationHeritage));
                            MenuPrincipal.AjouterItem(new MenuItem("Lecture de fichiers", 'L', ExploManipFichiers.ExploLectureFichier));
                            MenuPrincipal.AjouterItem(new MenuItem("Ecriture de fichiers", 'E', ExploManipFichiers.ExploEcritureFichier));
                            MenuPrincipal.AjouterItem(new MenuItem("Classe Humain", 'C', Exploration.ExploHumain));
                            MenuPrincipal.AjouterItem(new MenuItem("Rendement d'un dépôt", 'R', Exploration.CalculerRendementErgo));
                            MenuPrincipal.AjouterItem(new MenuItem("Remboursement d'un prêt", 'P', Exploration.CalculerRemboursementPret));
                            MenuPrincipal.AjouterItem(new MenuItem("Tableau d'entiers", 'T', Exploration.ArrayInt));
                            MenuPrincipal.AjouterItem(new MenuItem("Tableau d'instances", 'A', Exploration.ArrayHumain));
                            ManipListe ml = new();
                            MenuPrincipal.AjouterItem(new MenuItem("Liste d'instances", 'I', ml.ListeHumains));*/

                MenuPrincipal.Afficher();
                MenuPrincipal.SaisirChoix();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERREUR: Une exception a été lancée: ({0})", e.Message);
            }
            finally
            {
                Console.WriteLine("Finalement...");
                Console.ReadLine();
            }
        }

        static void initCouleurEcran()
        {
            Console.BackgroundColor = (ConsoleColor)Convert.ToInt32(_back);
            Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(_fore); ;
            Console.Clear();
        }
    }
}
