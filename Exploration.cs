using System;

namespace atelier2022
{
    /// <summary>
    /// Classe utilitaire pour Menu et différents ateliers
    /// </summary>
    public class Exploration
    {

        /// <summary>
        /// Initiation à l'orienté objet. Entre autres : la classe, les propriétés, méthodes, niveau d'encapsulation, ...
        /// composition
        /// </summary>
        public static void ExploHumain()
        {
            System.DateTime dt = new System.DateTime(1964, 7, 17);
            Humain h2 = new Humain("Alain", dt);

            h2.Afficher();

            Humain h3 = new Humain("Winston Churchill", new DateTime(1874, 11, 30), new DateTime(1965, 1, 24));
            h3.Afficher();

            Adresse a1 = new Adresse("13761", "Côtes des corbeilles", "Mirabel");

            Humain h4 = new("Marianne P. M.", new DateTime(1989, 04, 20), new Adresse("1234", "Cartier", "Laval"));
            h4.Afficher();
        }

        /// <summary>
        /// Calcul du rendement d'un dépôt en boucle 
        /// </summary>
        public static void CalculerRendementErgo()
        {          
            double rendementCumul;
            SaisirParametreDepot(out double depot, out double tauxInt, out int duree, out string compo);
            rendementCumul = depot;

            int tempsCumul = 0;
            int freqComp = 1;
            switch (compo)
            {
                case "m": freqComp = 12; break;
                case "q": freqComp = 365; break;
            }

            
            while (tempsCumul < duree * freqComp)
            {
                tempsCumul++;
                rendementCumul += (tauxInt/ freqComp) * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul.ToString(".00"));
        }

        /// <summary>
        /// Permet de saisir les paramètres de calcul désiré par l'utilisateur
        /// </summary>
        /// <param name="depot">Le dépôt initial</param>
        /// <param name="tauxInt">taux d'intérêt annuel</param>
        /// <param name="duree">nombre d'années où le dépôt fructifiera</param>
        /// <param name="compo">fréqwuence de composition de l'intérêt</param>
        static void SaisirParametreDepot(out double depot, out double tauxInt, out int duree, out string compo)
        {
            string strDepot;
            string strTauxInt;
            string strDuree;
            
            Console.WriteLine("Depot:");
            strDepot = Console.ReadLine();
            Console.WriteLine("Intérêt:");
            strTauxInt = Console.ReadLine();
            Console.WriteLine("Durée:");
            strDuree = Console.ReadLine();
            Console.WriteLine("Composition de l'intérêt:");
            compo = Console.ReadLine();
            Console.WriteLine("Paramètres:\nDépôt: {0}\nTaux intérêt:{1}\nDurée:{2}", strDepot, strTauxInt, strDuree);
            depot = Convert.ToDouble(strDepot);
            tauxInt = Convert.ToDouble(strTauxInt);
            duree = Convert.ToInt32(strDuree);
         }

        /// <summary>
        /// Saisie des paramètres et Calcul du temps nécessaire pour rembourser une dette
        /// </summary>
        public static void CalculerRemboursementPret()
        {
            //string strPaiementMinimum;
            string strInteret;
            string strPaiementMensuel;
            string strBalance;

            Console.WriteLine("Balance:");
            strBalance = Console.ReadLine();
            Console.WriteLine("taux d'intérêt:");
            strInteret = Console.ReadLine();
            Console.WriteLine("remboursement mensuel:");
            strPaiementMensuel = Console.ReadLine();
            CalculerRemboursement(Convert.ToDouble(strBalance), Convert.ToDouble(strInteret), Convert.ToDouble(strPaiementMensuel));
        }

        /// <summary>
        ///  Calcul du temps nécessaire pour rembourser une dette
        /// </summary>
        /// <param name="bal">La balance du prêt à rembourser</param>
        /// <param name="inte">Taux d'intéêt annuel sur la dette</param>
        /// <param name="mens">Remboursement mensuels</param>
        static void CalculerRemboursement(double bal, double inte, double mens)
        {
            double residu = bal;
            Console.WriteLine("Credit de {0} à {1}% avec mensualité de {2} ", residu, inte * 100, mens);
            int nbMois = 0;
            double interetCumul = 0;
            while (residu > 0)
            {
                Console.Write("Mois {0}, intéret: {1} Capital: {2} ", nbMois + 1,
                                                        (residu * inte / 12).ToString(".00"),
                                                        (mens - (residu * inte / 12)).ToString(".00"));
                residu -= mens - ((residu * inte) / 12);
                interetCumul += (residu * inte) / 12;
                Console.WriteLine(" balance à payer : {0}. Intérêt cumulé: {1}", residu.ToString(".00"), interetCumul.ToString(".00"));
                nbMois++;
            }
            Console.WriteLine("Réglement du prêt en {0} mois", nbMois);
        }

        /// <summary>
        /// Manip des Array en C#: initialisation, parcours, tri, ...
        /// </summary>
        public static void ArrayInt()
        {
            ManipArray.Introduction();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ArrayHumain()
        {
            ManipArray.ArrayDInstance();
        }
    }
}
