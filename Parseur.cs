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
    enum ErreursAtelier
    {
        NomTropLong,
        NomTropCourt,
        ElecteurMineur,
        ElecteurSenile
    }

    internal class Parseur
    {
        //---------------------------------------------
        //
        //---------------------------------------------
        public bool ParsingHumain(string infoBrute, out Humain h, out string msgErr)
        {
            int nbChamps = CompterNbChamps(infoBrute);
            h = new Humain();
            msgErr = "";

            //   Stagiaire (13 info)
            if (nbChamps == 13)
            {
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderStagiaire(tabInfo, out string contexte))
                {
                    h = new Stagiaire(tabInfo[0],
                                   new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                   tabInfo[4],
                                   new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]),
                                   tabInfo[8], tabInfo[9], double.Parse(tabInfo[10]),
                                   tabInfo[11], int.Parse(tabInfo[12]));
                    return true;
                }
                else
                {
                    msgErr = $"{contexte}";
                    return false;
                }
            }


            //   Etudiant (11 info)
            if (nbChamps == 11)
            {
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderEtudiant(tabInfo, out string contexte))
                {

                    h = new Etudiant(tabInfo[0],
                                   new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                   tabInfo[4],
                                   new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]),
                                   tabInfo[8], tabInfo[9], double.Parse(tabInfo[10]));
                    return true;
                }
                else
                {
                    msgErr = $"{contexte}";
                    return false;
                }


            }

            //   Humain pur
            if (nbChamps == 8)
            {
                string[] tabInfo = infoBrute.Split(';');

                if (Valider(tabInfo, out string contexte))
                {

                    h = new Humain(tabInfo[0],
                                   new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                   tabInfo[4],
                                   new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]));
                    return true;
                }
                else
                {
                    msgErr = $"{contexte}";
                    return false;
                }
            }
            else
            {
                msgErr = $"Nombre de champs incorrect : ({nbChamps}) champs";
                return false;
            }
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        bool Valider(string[] tabInfo, out string contexte)
        {
            contexte = "";
            if (tabInfo[0].Length > 50)
            {
                contexte = ErreursAtelier.NomTropLong.ToString();
                return false;
            }
            if (tabInfo[0].Length < 2)
            {
                contexte = ErreursAtelier.NomTropCourt.ToString();
                return false;
            }

            return true;    
        }


        //---------------------------------------------
        //
        //---------------------------------------------
        bool ValiderEtudiant(string[] tabInfo, out string contexte)
        {
            contexte = "";
            return true;
        }

        //---------------------------------------------
        //
        //---------------------------------------------
        bool ValiderStagiaire(string[] tabInfo, out string contexte)
        {
            contexte = "";
            return true;
        }


        //---------------------------------------------
        //
        //---------------------------------------------
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
