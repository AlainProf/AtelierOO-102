//---------------------------------------------
//   Fichier : Program.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------
using AtelierOO_102.Internationnal;
using AtelierOO_102.TP1;
using System.Diagnostics.Metrics;

namespace AtelierOO_102
{
    internal class Program
    {
        const bool debogueCONST = true;
        static Util u = new Util();
        //---------------------------------------------
        //
        //---------------------------------------------
        static void Main(string[] args)
        {
            //AfficherParam(args);

            bool rester = true;
            while (rester)
            {
                try
                {
                    u.SetNoirEttBlanc();
                    u.Titre("Atelier en classe du groupe 2C6-102");
                    AfficherMenu();
                    ExecuterChoix(ref rester);
                }

                 catch (Exception ex)
                {
                   Console.WriteLine("\n\nATTENTION!!! \tException rencontrée : " + ex.Message);
                    Console.Write("Voulez vous poursuivre? (o/n)");   
                    char dec = u.SaisirChar();  
                    if (dec != 'o' && dec != 'O')
                    {
                        rester = false;
                    }
                 }
                finally
                {
                   Console.WriteLine("\n\n :o( Au revoir ....");
                }
            }
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        static void AfficherParam(string[] tabP)
        {
            const bool CONSTBIDON = true;
            if (tabP.Length == 1)
            {
                u = new Util(false);
            }

            if (tabP.Length == 0)
            {
                u.Sep("Aucun paramètres d'Exec");
            }
            else
            {
                u.Sep($"{tabP.Length} params:");
                foreach (string p in tabP)
                {
                    u.Sep(p);
                }
            }
            u.Pause();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine(" A: Interface");
            Console.WriteLine(" B: International");
            Console.WriteLine(" C: Héritage");
            Console.WriteLine(" D: Exceptions en C#");
            Console.WriteLine(" E: Énumération (enum) en C#");
            Console.WriteLine(" F: Couleur et Console");
            Console.WriteLine(" G: TicTacToe");
            Console.WriteLine(" H: ref et out ");
            Console.WriteLine(" I: Financier");
            Console.WriteLine(" J: Humanité");
            Console.WriteLine(" K: Tableaux (array) en C#");
            Console.WriteLine(" L: Listes en C#");
            Console.WriteLine(" M: Fichiers en C#");
            Console.WriteLine(" N: Puissance 4");
            Console.WriteLine(" O: Pile et File");
            Console.WriteLine(" P: Tableau à deux diensions");
            Console.WriteLine(" R: constRuction de la BD");
            Console.WriteLine("\n Q: Quitter");
            Console.Write("\n\nVotre choix:");

        }


        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();
            Explo exp = new Explo();

            switch (choix)
            {
                case ('r'):
                    exp.GenererBD();
                    break;

                case ('p'):
                    exp.ExecTab2D();
                    break;

                case ('o'):
                    exp.ExecPileEtFile();
                    break;

                case ('a'):
                    exp.ExploInterface();
                    break;

                case ('b'):
                    Cooperation inter = new();
                    inter.Exec();
                    break;

                case ('c'):
                    exp.ExecHeritage();
                    break;
                case ('d'):
                    exp.ExecExceptions();
                    break;
                case ('e'):
                    exp.ExecEnum();
                    break;


                case ('f'):
                    ExploEcran exploEcran = new();
                    //exploEcran.ExploCouleur();
                    exploEcran.ExploEpilepsis();
                    break;

                case ('g'):
                    TicTacToe ttt = new TicTacToe();
                    ttt.Jouer();
                    break;

                case ('h'):
                    exp.ExploRefOut();
                    break;

                case ('i'):
                    ExecFinancier();
                    break;

                case ('j'):
                    ExecHumanite();
                    u.Pause();
                    break;

                case ('k'):
                    ExploTableau();
                    u.Pause();
                    break;

                case ('l'):
                    ExploListe();
                    u.Pause();
                    break;

                case ('m'):
                    ExploFichiers exploF= new();
                    //exploF.ExecAleatoire();
                    exploF.Exec();
                    u.Pause();
                    break;

                case ('n'):
                    Puissance4 p4 = new();
                    p4.Jouer();
                    break;

                case ('q'):
                    rester=false;
                    break;
            }

        }



        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExploListe()
        {
            Explo explo = new Explo();
            explo.ExploListeH();

        }
        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExploTableau()
        {
            Explo explo = new Explo();
            explo.ExploTableau();

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExecFinancier()
        {
            Financier fin = new Financier();
            fin.Exec();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExecHumanite()
        {
            u.Titre("Jouer avec les humains");

            Humain h = new Humain();
            h.Afficher();

            Humain h1 = new Humain("Laury-Anne", new DateTime(2006, 9,27), "F" );
            h1.Afficher();

            Humain h2 = new Humain("Alain", new DateTime(1964, 7, 23), "M");
            h2.Afficher();
        }
    }
}
