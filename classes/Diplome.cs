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
    class Diplome
    {
        /// <summary>
        /// 
        /// </summary>
        public string Niveau { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Obtention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Diplome()
        {
            Niveau = "inconnu";
            Nom = "non défini";
            Obtention = new DateTime(1, 1, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="no"></param>
        /// <param name="o"></param>
        public Diplome(string n, string no, DateTime o)
        {
            Niveau = n;
            Nom = no;
            Obtention = o;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine("Diplôme {0} d'étude {1}, obtenu le {2}", Nom, Niveau, Obtention );
        }

    }
}
