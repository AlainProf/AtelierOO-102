using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102
{
    internal class Etudiant : Humain
    {
        static int matMax = 1000000;
        public string Matricule { get; set; }
        public string Programme { get; set; }
        public double Moyenne { get; set; } 

        Util _u = new();

        public Etudiant()
        {
            _u.Sep("Cons Etudiant défaut");
            Matricule = "0000000";
            Programme = "prog vide";
            Moyenne = 0;
        }
        public Etudiant(string mat, string prog, double moy)
        {
            _u.Sep("Cons Etudiant 3 param");
            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, string mat, string prog, double moy) : base(n, nais, g)
        {
            _u.Sep("Cons Etudiant 6 param");
            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, Adresse dom, string prog, double moy) : base(n, nais, g, dom)
        {
            matMax++;
            Matricule = matMax.ToString();
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g,Adresse dom, string mat, string prog, double moy) : base(n, nais, g, dom)
        {
            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($" Mat:{Matricule}, étudie en {Programme} ({Moyenne}%)");
        }

    }
}
