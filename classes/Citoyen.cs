using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    /// <summary>
    /// 
    /// </summary>
    class Citoyen : Humain
    {
        /// <summary>
        /// 
        /// </summary>
        public string NAS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sexe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Diplome> Scolarite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Citoyen()
        {
            NAS = "000000000";
            Sexe = "indéfini";
            Scolarite = new List<Diplome>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        public Citoyen(string n, string s)
        {
            NAS = n;
            Sexe = s;
            Scolarite = new List<Diplome>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="nais"></param>
        /// <param name="res"></param>
        /// <param name="n"></param>
        /// <param name="s"></param>
        public Citoyen(string nom, DateTime nais, Adresse res, string n, string s) :
            base(nom, nais, res)
        {
            Console.WriteLine("constructeur dérivé");
            NAS = n;
            Sexe = s;
            Scolarite = new List<Diplome>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public void AjouterDiplome(Diplome d)
        {
            Scolarite.Add(d);
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("numéro ass soc {0}\nSexe:{1}\n", NAS, Sexe );

            if (Scolarite.Count == 0)
            {
                Console.WriteLine("aucune scolarité");
            }
            else
            {
                Console.WriteLine("\nScolarité:");
                foreach (Diplome d in Scolarite)
                {
                    d.Afficher();
                }
            }

            Console.WriteLine("_______________________\n");
        }
    }
}
