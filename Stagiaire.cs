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
        public Stagiaire(string n, DateTime nais, string g, string mat, string prog, double moy, string entrep, double sal) : base(n, nais, g, mat, prog, moy)
        {
            _entreprise = entrep;
            _salaireHoraire = sal;
        }
        public Stagiaire(string n, DateTime nais, string g, Adresse dom, string prog, double moy, string entrep, int sal) : base(n, nais, g, dom, prog, moy)
        {
            _entreprise = entrep;
            _salaireHoraire = sal;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" en stage chez " + _entreprise + " payé " + _salaireHoraire + " $");
        }
    }
}
