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

    enum JourSemaine
    {
        Lundi = 1,
        Mardi =2,
        Mercredi=3,
        Jeudi=4,
        Vendredi=5,
        Samedi=6,
        Dimanche=7,
    }
    internal class Util
    {
        bool _modeDebogue = true;

        public Random rdm = new();

        public readonly string[] TabNoms = new string[10] { "Xavier", "Louam", "Saad", "Léa", "Emy", "Laury-Anne", "Maxim", "Liam", "Ubert", "David" };
        public readonly string[] TabRues = new string[10] { "1ier avenue", "2iieme rue", "115 aap8", "boul Labelle", "Aut 15 nord", "de l'église", "Notee-Dame", "sans issue", "cul de sac", "Fournier" };
        public readonly string[] TabVilles = new string[10] { "St-Jérôme", "Miabel", "Blainville", "Ste-Thérèse", "Rosemère", "Laval", "Montréal", "Longueuil", "St-Bruno", "Akwasasne" };

        static readonly bool debogueRO = false;
        public Util(bool pd= true)
        {
            
        }

        public void SetModeDebogue(bool mode)
        {
           // debogueRO = mode;
            _modeDebogue = mode;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public void Titre(string leTitre)
        {
            ViderEcran();
            for (int i = 0; i < leTitre.Length; i++)
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
        public void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public char SaisirChar()
        {
            ConsoleKeyInfo cle = Console.ReadKey();
            return cle.KeyChar;
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        public int SaisirEntier()
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int res))
            {
                return res;
            }
            return 0;
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public  double SaisirReel()
        {
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double res))
            {
                return res;
            }
            return 0.0;
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public void Pause()
        {
            if (_modeDebogue)
                Console.WriteLine("\n\tAppuyez sur une touche...");
            else
                Console.WriteLine("--");  
            Console.ReadKey(true);
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        public void Sep(string msg="")
        {
            if (_modeDebogue)
                Console.WriteLine($"----------{msg}----------");
            else
                Console.WriteLine($"{msg}");
        }

        public void SetNoirEttBlanc()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
