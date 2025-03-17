using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class ExploPoly
    {
        Util u = new();
        List<Humain> population = new List<Humain>();
        public void Recencement()
        {
            ChargerPopulation();
            int nbMales = CompterMales();
            int nbFemelles = CompterFemelles();

            int popActive = CompterActifs();
            int popEnfant = CompterEnfants();
            int popRetraites = CompterRetraites();
            int ageMoyen = CalculerAgeMoyen();

            Console.WriteLine($"la population compte {nbMales} hommes et {nbFemelles} femmes");
            Console.WriteLine($"{popActive} sont en âge d'être actifs.\n {popEnfant} ont moins de 15 ans\n {popRetraites} plus de 65 ans");
            Console.WriteLine($"{ageMoyen} ans est l'age moyen");




            u.Pause();


        }

        int CalculerAgeMoyen()
        {
            int cpm = 0;
            long accumAge = 0;
            foreach (Humain h in population)
            {
                accumAge += h.Age();
            }
            return (int)accumAge/population.Count;
        }
        int CompterEnfants()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Age() <= 15)
                    cpm++;
            }
            return cpm;
        }
        int CompterAdultes()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Age() >= 18)
                    cpm++;
            }
            return cpm;
        }
        int CompterRetraites()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Age() >= 65)
                    cpm++;
            }
            return cpm;
        }
        int CompterActifs()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Age() > 15 && h.Age() < 65)
                    cpm++;
            }
            return cpm;
        }
        int CompterMales()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Genre == "M")
                    cpm++;
            }
            return cpm;
        }
        int CompterFemelles()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h.Genre != "M")
                    cpm++;
            }
            return cpm;
        }

        int CompterEtudiants()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h is Etudiant)
                    cpm++;
            }
            return cpm;
        }

        int CompterStagiaires()
        {
            int cpm = 0;
            foreach (Humain h in population)
            {
                if (h is Stagiaire)
                    cpm++;
            }
            return cpm;
        }
        double CompterSalaireHorairetotal()
        {
            double cpm = 0;
            foreach (Humain h in population)
            {
                if (h is Stagiaire)
                {
                    Stagiaire s = h as Stagiaire;    
                    cpm += s.SalaireHoraire;
                }
            }
            return cpm;
        }

        private void ChargerPopulation()
        {
            if (population.Count > 0)
                return;
            
            string FICHIER_POPULATION = "d:\\alino\\2C6-102\\baseDeDonnees.txt";
            if (File.Exists(FICHIER_POPULATION))
            {
                //Console.WriteLine("Fichier OK");
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                Parseur prs = new Parseur();


                string ligneCourante;
                int numLigne = 0;
                int avancement = 0;

                while (reader.Peek() > -1)
                {
                    numLigne++;
                    

                    if (numLigne % 10000 == 0)
                    {
                        Console.WriteLine($"{avancement}% de complété");
                        avancement++;
                    }

                    ligneCourante = reader.ReadLine();
                    //Console.WriteLine($"{numLigne}:{ligneCourante}");

                    if (prs.ParsingHumain(ligneCourante, out Humain h, out string msgErr))
                    {
                        //Console.Write($"{numLigne}:\t");
                        population.Add(h);
                    }
                    else
                    {
                        Console.WriteLine($"Erreur à la ligne {numLigne}, {msgErr}");
                    }
                }
                Console.WriteLine($"Chargement de {population.Count} humains");
                reader.Close();
            }
            else
            {
                Console.WriteLine($"Erreur le fichier {FICHIER_POPULATION} n'existe pas...");
            }
            u.Pause();
        }

        public void ListeElectorale()
        {
            u.Titre("Nb Electeurs");
            ChargerPopulation();

            int nbElecteurs = CompterAdultes();

            Console.WriteLine($"la population compte {nbElecteurs} électeurs");

            u.Pause();


        }

        public void PretBourse()
        {
            u.Titre("Nb Etudiants");
            ChargerPopulation();

            int nbEtudiants = CompterEtudiants();

            Console.WriteLine($"la population compte {nbEtudiants} étudiants");

            u.Pause();

        }
        public void MilieuStage()
        {
            u.Titre("Salaire moyen stagiaires");
            ChargerPopulation();

            int nbStagiaires = CompterStagiaires();
            double totalRevenus = CompterSalaireHorairetotal();

            Console.WriteLine($"le taux horaire moyen des {nbStagiaires} stagiaires == {totalRevenus/nbStagiaires} $");

            u.Pause();
        }
    }
}
