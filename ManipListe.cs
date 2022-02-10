using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022
{
    class ManipListe
    {
        public void ListeHumains()
        {
            List<Humain> classe102 = new();

            classe102.Add(new Humain("Vincent Lavoie-Whitlock", new DateTime(2002, 04, 16)));
            classe102.Add(new Humain("Vincent Diaferia", new DateTime(2002, 09, 3)));
            classe102.Add(new Humain("Julius Leblanc", new DateTime(2002, 04, 16), new DateTime(2010, 9, 11)));
            classe102.Add(new Humain("Jeremy Desjardins", new DateTime(2003, 01, 30)));

            foreach(Humain h in classe102)
            {
                h.Afficher();
            }

            classe102.Sort(plusJeune);

            Console.WriteLine("___________________________________Par jeunesse:"); 
            foreach (Humain h in classe102)
            {
                h.Afficher();
            }

            classe102.Sort((ha, hb) => { return ha.Nom.Length - hb.Nom.Length; });

            Console.WriteLine("___________________________________Par longueur de nom:");
            foreach (Humain h in classe102)
            {
                h.Afficher();
            }


        }
        static int plusJeune(Humain ha, Humain hb)
        {
            if (ha.Naissance.Ticks < hb.Naissance.Ticks)
                return 1;
            if (ha.Naissance.Ticks > hb.Naissance.Ticks)
                return -1;
            return 0;
        }
    }
}
