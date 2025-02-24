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
        string _matricule;
        string _programme;
        double _moyenne;

        Util _u = new();

        public Etudiant()
        {
            _u.Sep("Cons Etudiant défaut");
            _matricule = "0000000";
            _programme = "prog vide";
            _moyenne = 0;
        }
        public Etudiant(string mat, string prog, double moy)
        {
            _u.Sep("Cons Etudiant 3 param");
            _matricule = mat;
            _programme = prog;
            _moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, string mat, string prog, double moy) : base(n, nais, g)
        {
            _u.Sep("Cons Etudiant 6 param");
            _matricule = mat;
            _programme = prog;
            _moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, Adresse dom, string prog, double moy) : base(n, nais, g, dom)
        {
            matMax++;
            _matricule = matMax.ToString(); 
            _programme = prog;
            _moyenne = moy;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($" Mat:{_matricule}, étudie en {_programme} ({_moyenne}%)");
        }

    }
}
