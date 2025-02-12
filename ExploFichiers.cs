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
    internal class ExploFichiers
    {
        Util _u=new Util();
        List<Humain> _electeurs = new List<Humain>();
        Parseur prs = new Parseur();
        //---------------------------------------------
        //
        //---------------------------------------------
        public void ExecAleatoire(int nbElecteurs = 100)
        {
            _u.Titre($"Génération de {nbElecteurs} d'électeurs");
            for(int i = 0; i < nbElecteurs; i++)
            {
                Humain elAlea = Humain.GenererAlea();
                _electeurs.Add(elAlea);
            }

            EcrireElecteursTries();
            _u.Pause();
        }
        //---------------------------------------------
        //
        //---------------------------------------------
        public void Exec()
        {
            _u.Titre("Exploration des fichiers en C#");
            ParcourirFichierEnLecture();

            _u.Pause();
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        private void ParcourirFichierEnLecture()
        {
            string FICHIER_POPULATION = "d:\\alino\\popu.txt";
            if (File.Exists(FICHIER_POPULATION))
            {
                //Console.WriteLine("Fichier OK");
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string ligneCourante;
                int numLigne = 0;   
               

                while(reader.Peek() > -1)
                {
                    numLigne++;
                    ligneCourante = reader.ReadLine();  
                    //Console.WriteLine($"{numLigne}:{ligneCourante}");

                    if (prs.ParsingHumain(ligneCourante, out Humain h, out string msgErr))
                    {
                        //Console.Write($"{numLigne}:\t");
                        _electeurs.Add(h);    
                    }
                    else
                    {
                        Console.WriteLine($"Erreur à la ligne {numLigne}, {msgErr}");
                    }
                }
                Console.WriteLine($"Chargement de {_electeurs.Count} électeurs");
                _u.Pause();
                reader.Close();

                //EcrireElecteursTries();
            }
            else
            {
                Console.WriteLine($"Erreur le fichier {FICHIER_POPULATION} n'existe pas...");
            }
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        private void EcrireElecteursTries()
        {
            StringBuilder sb; ;   
            _electeurs.Sort(Humain.ComparerNom);

            _u.Sep($"Nous avons charger {_electeurs.Count} électeurs");

            // Le deuxième param: si TRUE == mode append; si false (ou absent) le fichier de destination est flushé avant l'écriture
            StreamWriter sw = new StreamWriter("d:\\alino\\popuTriA.txt");
            foreach(Humain h in _electeurs)
            {
                sb = new();
                sb.Append(h.Nom);
                sb.Append(";");
                sb.Append(h.Naissance.Year);
                sb.Append(";");
                sb.Append(h.Naissance.Month);
                sb.Append(";");
                sb.Append(h.Naissance.Day);
                sb.Append(";");
                sb.Append(h.Genre);
                sb.Append(";");
                sb.Append(h.Domicile.NumCivique);
                sb.Append(";");
                sb.Append(h.Domicile.Rue);
                sb.Append(";");
                sb.Append(h.Domicile.Ville);

                Console.WriteLine(sb.ToString());
                _u.Pause();

                sw.WriteLine(sb.ToString());

            }
            sw.Close();


        }
    }
}
