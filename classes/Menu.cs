using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    class Menu
    {
        public string Nom { get; set; }
        public List<MenuItem> lstItems = new List<MenuItem>();

        public Menu(string n)
        {
            Nom = n;
        }

        public void AjouterItem(MenuItem mi)
        {
            lstItems.Add(mi);
        }

        public void Afficher()
        {
            Console.Clear();
            for(int i=0; i< Nom.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n" + Nom);
            for (int i = 0; i < Nom.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");

            foreach( MenuItem menuItem in lstItems)
            {
                Console.WriteLine("\t" + menuItem.Cle + ": " + menuItem.Item);
            }
            Console.WriteLine("\nESC  pour quitter");
        }

        public void SaisirChoix()
        {
            ConsoleKeyInfo keyInfo;
            while (( keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
               foreach (MenuItem menuItem in lstItems)
                {
                    if ( (char)keyInfo.Key == menuItem.Cle)
                    {
                        Console.Clear();
                        menuItem.Action();
                        Console.ReadKey();
                        Afficher();
                    }
                }
            }
        }

    }
}
