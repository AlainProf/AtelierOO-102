using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Stagiaire : Etudiant
    {
        string _entreprise;
        double _salaireHoraire;

        public Stagiaire(string entrep, double sal)
        {
            _entreprise = entrep;
            _salaireHoraire = sal;
        }
        public Stagiaire(string n, DateTime nais, string g, string mat, string prog, double moy, string entrep, double sal):base(n,nais,g,mat,prog,moy) 
        {
            _entreprise = entrep;
            _salaireHoraire = sal;
        }

        public void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Entrerpise:" + _entreprise + " salire:" + _salaireHoraire + " de l'heure");
        }
    }
}
