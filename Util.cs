//---------------------------------------------
//   Fichier : Util.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Util
    {
        //---------------------------------------------
        //
        //---------------------------------------------
        public static void Titre(string leTitre)
        {
            ViderEcran();
            for (int i = 0; i < leTitre.Length;i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();    
            Console.WriteLine(leTitre);
            for (int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("\n\n");
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public static void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public static char SaisirChar()
        {
            ConsoleKeyInfo cle = Console.ReadKey();
            return cle.KeyChar;
        }
    }


}
