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
        private string _valeurTexte;
        public int Sorte { get; set; }
        private int _couleurBack;
        private int _couleurFore;
        private int _largeurCarte = 4;


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

        public int Afficher(int decalageX, int decalageY)
        {
            SetValeurTexte();
            SetCouleurCarte();

            int xCarte = (decalageX * _largeurCarte) + (decalageX);
            int yCarte = (decalageY * 4);

            Console.SetCursorPosition(xCarte, yCarte);
            Console.Write(_valeurTexte + "   ");
            Console.SetCursorPosition(xCarte, yCarte+1);
            Console.Write("    ");
            Console.SetCursorPosition(xCarte, yCarte+2);
            Console.Write("   " + _valeurTexte);

            JeuPoker.CouleurTapis();

            return 0;
        }

        private void SetCouleurCarte()
        {
            switch (Sorte)
            {
                case 0:
                    _couleurBack = 0;
                    _couleurFore = 15;
                    break;
                case 1:
                    _couleurBack = 1;
                    _couleurFore = 15;
                    break;
                case 2:
                    _couleurBack = 4;
                    _couleurFore = 14;
                    break;
                case 3:
                    _couleurBack = 12;
                    _couleurFore = 14;
                    break;
            }
            Console.BackgroundColor = (ConsoleColor)_couleurBack;
            Console.ForegroundColor = (ConsoleColor)_couleurFore;
        }

        private void SetValeurTexte()
        {
            switch (Valeur)
            {
                case 12:
                    _valeurTexte = "A";
                    break;
                case 11:
                    _valeurTexte = "K";
                    break;
                case 10:
                    _valeurTexte = "Q";
                    break;
                case 9:
                    _valeurTexte = "J";
                    break;
                case 8:
                    _valeurTexte = "X";
                    break;
                case 7:
                    _valeurTexte = "9";
                    break;
                case 6:
                    _valeurTexte = "8";
                    break;
                case 5:
                    _valeurTexte = "7";
                    break;
                case 4:
                    _valeurTexte = "6";
                    break;
                case 3:
                    _valeurTexte = "5";
                    break;
                case 2:
                    _valeurTexte = "4";
                    break;
                case 1:
                    _valeurTexte = "3";
                    break;
                case 0:
                    _valeurTexte = "2";
                    break;

            }
        }
    }
}
