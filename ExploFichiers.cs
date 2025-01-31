using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class ExploFichiers
    {
        Util u=new Util();  
        public void Exec()
        {
            u.Titre("Exploration des fichiers en C#");
            ParcourirFichierEnLecture();

            u.Pause();
        }

        private void ParcourirFichierEnLecture()
        {
            string FICHIER_POPULATION = "d:\\alino\\popu.txt";
            if (File.Exists(FICHIER_POPULATION))
            {
                //Console.WriteLine("Fichier OK");
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string ligneCourante;
                int numLigne = 0;   
                List<Humain> electeurs = new List<Humain>();

                while(reader.Peek() > -1)
                {
                    numLigne++;
                    ligneCourante = reader.ReadLine();  
                    //Console.WriteLine($"{numLigne}:{ligneCourante}");

                    if (ParsingHumain(ligneCourante, out Humain h))
                    {
                        //Console.Write($"{numLigne}:\t");
                        electeurs.Add(h);    
                    }
                    else
                    {
                        Console.WriteLine($"Erreur fichier corrompu à la ligne {numLigne}");
                    }
                }
                Console.WriteLine($"Chargement de {electeurs.Count} électeurs");
                reader.Close();
            }
            else
            {
                Console.WriteLine($"Erreur le fichier {FICHIER_POPULATION} n'existe pas...");
            }
        }

        private bool ParsingHumain(string infoBrute, out Humain h)
        {
            int nbChamps = CompterNbChamps(infoBrute);
            h = new Humain();
            if (nbChamps == 8)
            {
                //Console.WriteLine("Bingo");
                string[] tabInfo = infoBrute.Split(';');

                h = new Humain(tabInfo[0],
                               new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                               tabInfo[4]);
                h.Domicile = new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]);

                return true;
            }
            else
            {
                Console.WriteLine($"Erreur ({nbChamps}) est un nombre de champs incorrect");
                return false;   
            }
        }

        private int CompterNbChamps(string info)
        {
            if (info.Length == 0)
                return 0;

            int nbChamps = 1;
            foreach (char c in info)
            {
                if (c == ';')
                {
                    nbChamps++;
                }
            }
            return nbChamps;
        }
    }
}
