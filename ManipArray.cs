using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022
{
    class ManipArray
    {
        /// <summary>
        /// Méthode pour explorer les diverses possibilités des Array C#
        /// </summary>
        public static void Introduction()
        {
            Console.WriteLine("Tableau d'entiers\n");

            int[] notes = new int[6];

            notes[0] = 71;
            notes[1] = 82;
            notes[2] = 60;
            notes[3] = 82;
            notes[4] = 57;
            notes[5] = 99;

            int accum = 0;
            int iter = 0;
            foreach(int n in notes)
            {
                iter++;
                accum += n;
                Console.WriteLine("note {0}: {1}", iter, n);
            }
            int moyenne = accum / notes.Length;
            Console.WriteLine("moyenne de {0}", moyenne);

            Console.WriteLine("moyenne coold {0}", notes.Average());

            Console.WriteLine("Note max:" + notes.Max());
            Console.WriteLine("Note min:" + notes.Min());
        }

        public static void ArrayDInstance()
        {
            Console.WriteLine("Tableau d'objets\n");

            Humain[] eleves_102 = new Humain[5];

            eleves_102[0] = new Humain();
            eleves_102[1] = new Humain("Zakaria Mrad (PP)", new DateTime(2001,9,24));
            eleves_102[2] = new Humain("Vincent Laverdière", new DateTime(2001, 9, 26));
            eleves_102[3] = new Humain("Nicola  Labelle", new DateTime(1996, 8, 8));
            eleves_102[4] = new Humain("David                      Mousette", new DateTime(2002, 2, 7));


            Console.WriteLine("Affichage sans tri");
            foreach (Humain e in eleves_102)
            {
                e.Afficher();
            }
            Console.WriteLine("__________________________________\n\n");
            Array.Sort(eleves_102, TriParVieux);

            Console.WriteLine("Affichage du plus vieux au plus jeune");
            foreach (Humain e in eleves_102)
            {
                e.Afficher();
            }
            Console.WriteLine("__________________________________\n\n");

            Console.WriteLine("Affichagedu plus jeune au plus vieux");
            Array.Sort(eleves_102, TriParJeune);
            foreach (Humain e in eleves_102)
            {
                e.Afficher();
            }
            Console.WriteLine("__________________________________\n\n");

            Console.WriteLine("Affichage selon longueur du nom");
            Array.Sort(eleves_102, (ha, hb) => { return ha.Nom.Length - hb.Nom.Length; } );
            foreach (Humain e in eleves_102)
            {
                e.Afficher();
            }
            Console.WriteLine("__________________________________\n\n");
        }

        static int TriParVieux(Humain ha, Humain hb)
        {
            if (ha.Naissance.Ticks > hb.Naissance.Ticks)
                return 1;
            if (ha.Naissance.Ticks < hb.Naissance.Ticks)
                return -1;
            return 0;
        }
        static int TriParJeune(Humain ha, Humain hb)
        {
            if (ha.Naissance.Ticks < hb.Naissance.Ticks)
                return 1;
            if (ha.Naissance.Ticks > hb.Naissance.Ticks)
                return -1;
            return 0;
        }
    }
}
