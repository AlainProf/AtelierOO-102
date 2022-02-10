using System;

namespace atelier2022
{
    /// <summary>
    /// Représente un humain
    /// </summary>
    class Humain
    {
        /// <summary>
        /// Nom de l'humain
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Date de naissance 
        /// </summary>
        public DateTime Naissance { get;  set; }
        /// <summary>
        /// Date de décès s'il est est mort
        /// </summary>
        public DateTime Deces { get; set; }
        /// <summary>
        /// Endroit où il demeure
        /// </summary>
        public Adresse Residence { get; set; }
        
        /// <summary>
        /// Coinstructeur par défaut
        /// </summary>
        public Humain()
        {
            Nom = "inconnu";
            Naissance = DateTime.Now;
            Deces = new DateTime(1, 1, 1);
            Residence = null;
        }
        /// <summary>
        /// Constructeur pour humain vivant dont on ne connaît pas l'adresse
        /// </summary>
        /// <param name="n">nom</param>
        /// <param name="na">date de naissance</param>
        public Humain(string n, DateTime na)
        {
            Nom = n;
            Naissance = na;
            Deces = new DateTime(1, 1, 1);
            Residence = null;
        }

        /// <summary>
        /// Constructeur pour humain vivant dont on connaît l'adresse
        /// </summary>
        /// <param name="n">nom</param>
        /// <param name="na">date de naissance</param>
        /// <param name="a">adresse de sa résidence</param>
        public Humain(string n, DateTime na, Adresse a)
        {
            Nom = n;
            Naissance = na;
            Deces = new DateTime(1, 1, 1);
            Residence = a;
        }

        /// <summary>
        /// Constructeur pour humain mort
        /// </summary>
        /// <param name="n">nom</param>
        /// <param name="na">date de naissance</param>
        /// <param name="de">date de trépas</param>
        public Humain(string n, DateTime na, DateTime de)
        {
            Nom = n;
            Naissance = na;
            Deces = de ;
            Residence = null;
        }

        /// <summary>
        /// Affiche une instance avec ces détails
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine("nom:{0}", Nom);
            System.Console.WriteLine("né le :{0}", Naissance);
            Console.WriteLine(" agé de {0}", Age());
            // commentaire
            if (!EstVivant())
            {
                Console.WriteLine("Décédé le " + Deces);
                Console.WriteLine("Il y a {0} ans ", AnneesDepuisDeces());
            }
            if (Residence != null)
            {
                Console.Write("domicilié au ");
                Residence.Afficher();
            }
            else
                Console.WriteLine("SDF");
            Console.WriteLine(".....");
        }

        /// <summary>
        /// Lorsqu'un humaibn trépasse on fixe la date de décès
        /// </summary>
        public void Mourir()
        {
            Deces = DateTime.Now;
        }


        //------------------------------
        //
        //------------------------------
        private int Age()
        {
            long delta;
            if (EstVivant())
            {
                delta = DateTime.Now.Ticks - Naissance.Ticks;
            }
            else
            {
                delta = Deces.Ticks - Naissance.Ticks;
            }

            delta /= 10000000;
            delta /= ((long)365.24 * 24 * 3600);
                       
            return (int)delta;
        }

        //------------------------------
        //
        //------------------------------
        private int AnneesDepuisDeces()
        {
            long delta = DateTime.Now.Ticks - Deces.Ticks;

            delta /= 10000000;
            delta /= ((long)365.24 * 24 * 3600);

            return (int)delta;
        }

        //------------------------------
        //
        //------------------------------
        private bool EstVivant()
        {
            return !(Deces.Ticks > 1000000000);
        }

    }
}

