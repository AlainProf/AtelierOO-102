//---------------------------------------------
//   Fichier : Program.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------
using AtelierOO_102.TP1;

namespace AtelierOO_102
{
    internal class Program
    {

        static Util u = new Util();
        //---------------------------------------------
        //
        //---------------------------------------------
        static void Main(string[] args)
        {
            u.SetNoirEttBlanc();
            bool rester = true;
            while (rester)
            {
                u.Titre("Atelier en classe du groupe 2C6-102");
                AfficherMenu();
                ExecuterChoix(ref rester);
            }
            Console.WriteLine("\n\n :o( Au revoir ....");
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();

            switch(choix)
            {
                case ('p'):
                    Puissance4 p4 = new();
                    p4.Jouer();
                    break;

                case ('c'):
                    ExploEcran exploEcran = new();
                    //exploEcran.ExploCouleur();
                    exploEcran.ExploEpilepsis();
                    break;

                case ('t'):
                    TicTacToe ttt = new TicTacToe();
                    ttt.Jouer();
                    break;

                case ('r'):
                    Explo exp = new Explo();
                    exp.ExploRefOut();
                    break;

                case ('f'):
                    ExecFinancier();
                    break;

                case ('h'):
                    ExecHumanite();
                    u.Pause();
                    break;

                case ('a'):
                    ExploTableau();
                    u.Pause();
                    break;

                case ('l'):
                    ExploListe();
                    u.Pause();
                    break;

                case ('i'):
                    ExploFichiers exploF= new();
                    exploF.Exec();
                    u.Pause();
                    break;

                case ('q'):
                    rester=false;
                    break;
            }

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine(" P: Puissance 4");
            Console.WriteLine(" c: Couleur et Console");
            Console.WriteLine(" t: TicTacToe");
            Console.WriteLine(" R: ref et out ");
            Console.WriteLine(" F: Financier");
            Console.WriteLine(" H: Humanité");
            Console.WriteLine(" a: Tableaux (array) en C#");
            Console.WriteLine(" L: Listes en C#");
            Console.WriteLine(" I: Fichiers en C#");
            Console.WriteLine("\n Q: Quitter");
            Console.Write("\n\nVotre choix:");

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
            explo.ExploTableauH();

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
