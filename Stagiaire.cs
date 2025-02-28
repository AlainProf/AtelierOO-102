using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Stagiaire : Etudiant
    {
        public string Entreprise { get; set; }
        public double SalaireHoraire { get; set; }  

        public Stagiaire(string entrep, double sal)
        {
            Entreprise = entrep;
            SalaireHoraire = sal;
        }
        public Stagiaire(string n, DateTime nais, string g, string mat, string prog, double moy, string entrep, double sal) : base(n, nais, g, mat, prog, moy)
        {
            Entreprise = entrep;
            SalaireHoraire = sal;
        }
        public Stagiaire(string n, DateTime nais, string g, Adresse dom, string prog, double moy, string entrep, int sal) : base(n, nais, g, dom, prog, moy)
        {
            Entreprise = entrep;
            SalaireHoraire = sal;
        }
        public Stagiaire(string n, DateTime nais, string g, Adresse dom, string mat,string prog, double moy, string entrep, int sal) : base(n, nais, g, dom, mat, prog, moy)
        {
            Entreprise = entrep;
            SalaireHoraire = sal;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" en stage chez " + Entreprise + " payé " + SalaireHoraire + " $");
        }
    }
}
