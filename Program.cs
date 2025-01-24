//---------------------------------------------
//   Fichier : Program.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------
namespace AtelierOO_102
{
    internal class Program
    {
        //---------------------------------------------
        //
        //---------------------------------------------
        static void Main(string[] args)
        {
            Util.Titre("Atelier en classe du groupe 2C6-102");
            AfficherMenu();
            ExecuterChoix();
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        static void ExecuterChoix()
        {
            char choix = Util.SaisirChar();

            switch(choix)
            {
                case ('f'): 
                    ExecFinancier();
                    break;

                case ('h'):
                    ExecHumanite();
                    break;
                case ('q'):
                    Console.WriteLine("Au revoir ... :o(");
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
            Console.Write("Votre choix:");

            Console.WriteLine("\n\n__________\n Q: Quitter");
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
            Util.Titre("Jouer avec les humains");

            Humain h = new Humain();
            h.Afficher();

            Humain h1 = new Humain("Adam", "-6000", "M");
            h1.Afficher();

            Humain h2 = new Humain("Êve", "-5999", "F");
            h2.Afficher();
        }
    }
}
