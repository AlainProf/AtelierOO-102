using atelier2022.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classesExplo
{
    class ExploHeritage
    {
        static public int ExplorationHeritage()
        {
            Console.WriteLine("Concept d'héritage en POO");

            Citoyen mX = new();
            mX.Afficher();

            Citoyen mmeY = new("1234567", "F");
            mmeY.Afficher();

            Citoyen mrad = new Citoyen("Mrad Zakaria", 
                                        new DateTime(2001,9,27), 
                                        new Adresse("303-1369", "Curé-labelle", "St-ClinClin" ), 
                                        "306123123", 
                                        "Masculin");

            mrad.AjouterDiplome(new Diplome("primaire", "régulier", new DateTime(2014, 6, 23)));
            mrad.AjouterDiplome(new Diplome("zgondaire", "DES SN", new DateTime(2019, 6, 23)));
            mrad.AjouterDiplome(new Diplome("kinder surpise", "Doctorat Médecine", new DateTime(2022, 2, 16)));

            mrad.Afficher();

            return 0;
        }
    }
}
