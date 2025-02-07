//---------------------------------------------
//   Fichier : 
//   Créateur: Alain Martel
//   Date    : 
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class ExploEcran
    {
        Util u = new();

        //---------------------------------------------
        //
        //---------------------------------------------

        public void ExploEpilepsis()
        {
            int limiteX = Console.WindowWidth-1;
            int limiteY = Console.WindowHeight-1;

            while (true)
            {

                int iter = 0;
                int x = 0;
                int y = 0;

                while (iter <= Math.Floor((double)(limiteX / 2)) && iter <= Math.Floor((double)limiteY / 2))
                {

                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; x < limiteX - iter; x++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        //Thread.Sleep(1);
                    }

                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; y < limiteY - iter; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        // Thread.Sleep(1);
                    }

                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; x > iter; x--)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                        //Thread.Sleep(1);
                    }

                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; y > iter; y--)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                    //Thread.Sleep();
                    iter++;
                    x = iter;
                    y = iter;
                }
            }
            u.SetNoirEttBlanc();
            u.ViderEcran();
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExploCouleur()
        {
            u.Titre("Les couleurs de la console en C#");

            int largeur = Console.WindowWidth;
            int hauteur = Console.WindowHeight;

            u.Sep($"Lar:{largeur} X Hau:{hauteur}");

            Console.SetCursorPosition(largeur / 2, hauteur / 2);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('M');




            u.Pause();
        }
    }
}
