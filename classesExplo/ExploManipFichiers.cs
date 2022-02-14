using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classesExplo
{
    class ExploManipFichiers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int ExploLectureFichier()
        {
            Console.WriteLine("Exploration des méthodes de lecture de fichiers sur disque");

            List<Humain> classe102 = new();

            string FicIn = "d:\\amartel\\classe102.txt";
            string FicOut = "d:\\amartel\\classe102OrdreAge.txt";

            if (File.Exists(FicIn))
            {
                StreamReader reader = File.OpenText(FicIn);
                string ligneCourante;
                int numLigne = 0;
                while(reader.Peek() > -1)
                {
                    ligneCourante = reader.ReadLine();
                    numLigne++;
                    Console.WriteLine(numLigne + ": " + ligneCourante);

                    ParsingHumain(ligneCourante, out Humain h);
                    classe102.Add(h);
                }
            }
            else
            {
                Console.WriteLine("ERREUR: Le fichier {0} n'existe pas...", FicIn);
            }

            classe102.Sort(ManipListe.plusJeune);

            StreamWriter writer = new(FicOut);
            foreach(Humain h in classe102)
            {
                writer.WriteLine(h.Nom + ";" + h.Naissance.ToString("D"));
            }
            writer.Close();
            return 0;
        }

        private static bool ParsingHumain(string infoBrute, out Humain humCourant )
        {
            string[] HumInfo = infoBrute.Split(';');
            ParsingDate(HumInfo[1], out DateTime naissance);
            humCourant = new(HumInfo[0], naissance);
            //humCourant.Afficher();
            return true;
        }

        static bool ParsingDate(string dateBrute, out DateTime naissance)
        {
            string[] DateInfo = dateBrute.Split('-');
            naissance = new (Convert.ToInt32(DateInfo[0]),
                             Convert.ToInt32(DateInfo[1]),
                             Convert.ToInt32(DateInfo[2]));
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int ExploEcritureFichier()
        {
            Console.WriteLine("Ecriture");
            return 0;
        }
       
    }
}
