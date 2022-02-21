using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    class Carte
    {
        public int Valeur { get; set; }
        public int Sorte { get; set; }

        public Carte()
        {
            Valeur = 0;
            Sorte = 0;
        }

        public Carte(int v, int s)
        {
            Valeur = v;
            Sorte = s;
        }

        public void Afficher()
        {
            string carteTexte="2";
            int couleurBack = 0;
            int couleurFore = 15;

             switch(Valeur)
             {
                case 12:
                    carteTexte = "A";
                    break;
                case 11:
                    carteTexte = "K";
                    break;
                case 10:
                    carteTexte = "Q";
                    break;
                case 9:
                    carteTexte = "J";
                    break;
                case 8:
                    carteTexte = "X";
                    break;
                case 7:
                    carteTexte = "9";
                    break;
                case 6:
                    carteTexte = "8";
                    break;
                case 5:
                    carteTexte = "7";
                    break;
                case 4:
                    carteTexte = "6";
                    break;
                case 3:
                    carteTexte = "5";
                    break;
                case 2:
                    carteTexte = "4";
                    break;
                case 1:
                    carteTexte = "3";
                    break;
                case 0:
                    carteTexte = "2";
                    break;
            }

            switch(Sorte)
            {
                case 0:
                    couleurBack = 0;
                    couleurFore = 15;
                    break;
                case 1:
                    couleurBack = 1;
                    couleurFore = 15;
                    break;
                case 2:
                    couleurBack = 4;
                    couleurFore = 0;
                    break;
                case 3:
                    couleurBack = 12;
                    couleurFore = 0;
                    break;
            }
            Console.BackgroundColor = (ConsoleColor)couleurBack;
            Console.ForegroundColor = (ConsoleColor)couleurFore;

            Console.Write(carteTexte);

            Console.BackgroundColor = (ConsoleColor)0;
            Console.ForegroundColor = (ConsoleColor)10;

        }

    }
}
