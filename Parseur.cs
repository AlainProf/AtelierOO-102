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
            if (nbChamps == 5)
            {
                //Console.WriteLine("Bingo");
                string[] tabInfo = infoBrute.Split(';');

                if (Valider(tabInfo, out string contexte))
                {

                    h = new Humain(tabInfo[0],
                                   new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                   tabInfo[4]);
                    //h.Domicile = new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]);
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
            if (int.TryParse(tabInfo[1], out int an) )
            {
                if (an > 2007)
                {
                    contexte = ErreursAtelier.ElecteurMineur.ToString();
                    return false;
                }
                if (an < 1926)
                {
                    contexte = ErreursAtelier.ElecteurSenile.ToString();
                    return false;
                }
            }

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
