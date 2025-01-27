//---------------------------------------------
//   Fichier : Financoer.cs
//   Créateur: Alain Martel
//   Date    : 2025-01-24
//---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtelierOO_102
{
    internal class Financier
    {
        Util u = new Util();

        public void Exec()
        {
            bool rester = true;
            while (rester)
            {
                u.Titre("Finacier 2025");
                AfficherMenu();
                ExecuterChoix(ref rester);
            }

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();

            switch (choix)
            {
                case ('p'):
                    CalculerRendement();
                    u.Pause();
                    break;

                case ('r'):
                    CalculerPret();
                    u.Pause();
                    break;
                case ('q'):
                    rester = false;
                    break;
            }

        }

        //---------------------------------------------
        //
        //---------------------------------------------
        void AfficherMenu()
        {
            Console.WriteLine(" P: Placement");
            Console.WriteLine(" R: Rembourser prêt");
            Console.WriteLine("\n Q: Quitter");
            Console.Write("\n\nVotre choix:");
        }



        //---------------------------------------------
        //
        //---------------------------------------------
        public void CalculerRendement()
        {
            u.Titre("Calcul de rendement");

            Console.Write("Montant du placement:");
            int placement = u.SaisirEntier();

            Console.Write("Taux intérêt annuel:");
            double tauxInteretAnnuel = u.SaisirReel();

            Console.Write("Durée en années du placement:");
            int duree = u.SaisirEntier();

            Console.Write("Composition (A|M|Q):");
            char compo = u.SaisirChar();
            Console.WriteLine();    

            Console.Write("Affichage détaillé? (o/n):");
            char infoDetail = u.SaisirChar();
            Console.WriteLine();

            double intCum = 0;
            double capitalCum = placement;


            if (infoDetail == 'o')
            {
                Console.WriteLine(@"{0}{1}{2}", "an".PadLeft(6),
                  "Capital".PadLeft(12),
                  "Interet cour".PadLeft(12));
            }

            int iter = duree;
            double tauxInteret = tauxInteretAnnuel;

            switch(compo)
            {
                case 'm':
                case 'M':
                    iter = duree * 12;
                    tauxInteret = (tauxInteret / 12);
                    break;

                case 'q':
                case 'Q':
                    iter = duree * 365;
                    tauxInteret = (tauxInteret / 365);
                    break;
            }


            for (int i = 0; i < iter; i++)
            {
                double interetPeriode = tauxInteret * capitalCum;
                intCum += interetPeriode;
                capitalCum += interetPeriode;

                if (infoDetail == 'o')
                {

                    Console.WriteLine(@"{0}{1}{2}", i.ToString().PadLeft(6),
                      (capitalCum - interetPeriode).ToString("N2").PadLeft(12),
                      interetPeriode.ToString("N2").PadLeft(12));
                }     
            }
            Console.WriteLine("\n_________________________________\n");
            Console.WriteLine($"Un placement de {placement}$ rapportera {intCum.ToString("N2")}$ en {duree} ans (Capital final: {capitalCum.ToString("N2")} )");

        }


        //---------------------------------------------
        //
        //---------------------------------------------
        public void CalculerPret()
        {
            u.Titre("Remboursement d'un prêt!");

            Console.Write("Montant de la dette:");
            int dette = u.SaisirEntier();

            Console.Write("Taux intérêt:");
            double tauxInteretAnnuel = u.SaisirReel();

            Console.Write("Affichage détaillé? (o/n):");
            char infoDetail = u.SaisirChar();

            double tauxIntMensuel = tauxInteretAnnuel / 12;
            double pourcentageMinDelaDette = 0.04;
            double detteResiduelle = dette;
            double intCum = 0;
            double paieCum = 0;


            int nbMois = 0;

            if (infoDetail == 'o')
            {

                Console.WriteLine(@"{0}{1}{2}{3}{4}{5}{6}", "Mois".PadLeft(6),
                                  "Dette".PadLeft(12),
                                  "Paiem mens".PadLeft(12),
                                  "rembours".PadLeft(12),
                                  "int mens".PadLeft(12),
                                  "int cum".PadLeft(12),
                                  "paie cum".PadLeft(12));
            }

            while (detteResiduelle > 1)
            {
                nbMois++;

                double paiementCourant = detteResiduelle * pourcentageMinDelaDette;
                paieCum += paiementCourant;
                double intMensuel = detteResiduelle * tauxIntMensuel;
                intCum += intMensuel;
                double remboursementCourant = paiementCourant - intMensuel;
                detteResiduelle -= remboursementCourant;

                if (infoDetail == 'o')
                {
                    Console.WriteLine(nbMois.ToString().PadLeft(6)
                                   + (detteResiduelle + remboursementCourant).ToString("N2").PadLeft(12)
                                   + paiementCourant.ToString("N2").PadLeft(12)
                                   + remboursementCourant.ToString("N2").PadLeft(12)
                                   + intMensuel.ToString("N2").PadLeft(12)
                                   + intCum.ToString("N2").PadLeft(12)
                                   + paieCum.ToString("N2").PadLeft(12));
                }
            }
            Console.WriteLine("\n_________________________________\n");
            // Console.WriteLine("Dette de " + dette + "$" + " remboursée en " + nbMois + " mois" );    
            // Console.WriteLine(@"Dette de {0}$ remboursée en {1} mois", dette, nbMois);
            Console.WriteLine($"Dette de {dette}$ remboursée en {nbMois} mois. Intérêt cum:{intCum.ToString("N2")}$, paiement total:{paieCum.ToString("N2")}$");
        }
    }
}
