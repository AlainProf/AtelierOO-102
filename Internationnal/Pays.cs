using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Internationnal
{
    internal class Pays
    {
        Util _u = new();
        public string Nom {  get; set; }    
        public List<Ville> LesVilles { get; set; }

        public Ville Capital { get; set; }

        public Pays(string n, List<Ville> lv, Ville cap)
        {
            Nom = n;    
            LesVilles = lv; 
            Capital = cap;  
        }

        public void Afficher()
        {
            _u.Sep(Nom);
            Console.WriteLine($"Capital: {Capital.Nom}");

            //LesVilles.Sort(Ville.ComparerPop);
            LesVilles.Sort(Ville.CompareEst);
            //LesVilles.Sort(Ville.CompareNord);

            int pop = 0;
            foreach(Ville v in LesVilles)
            {
                pop += v.Population;
                v.Afficher();   
            }

            _u.Sep($"{pop} habitants");
        }
    }
}
