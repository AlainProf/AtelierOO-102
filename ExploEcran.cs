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
