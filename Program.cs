//---------------------------------------------
//   Fichier : Program.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------
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
                case ('f'): 
                    ExecFinancier();
                    break;

                case ('h'):
                    ExecHumanite();
                    u.Pause();
                    break;

                case ('t'):
                    ExploTableau();
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
            Console.WriteLine(" F: Financier");
            Console.WriteLine(" H: Humanité");
            Console.WriteLine(" T: Tableaux en C#");
            Console.WriteLine("\n Q: Quitter");
            Console.Write("\n\nVotre choix:");

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
