namespace AtelierOO_102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atelier en classe du groupe 2C6-102");
            Console.WriteLine("___________________________________\n");

            AfficherMenu();
        }

        static void AfficherMenu()
        {
            Console.WriteLine(" F: Financier");
            Console.WriteLine(" H: Humanité");
            Console.Write("Votre choix:");

            Console.WriteLine("\n\n__________\n Q: Quitter");
        }
    }
}
