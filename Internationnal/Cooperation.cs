using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Internationnal
{
    internal class Cooperation
    {
        Util _u = new();
        public void Exec()
        {
            _u.Titre("Coop Internationnale");
            // 45° 47′ nord, 74° 00′ ouest

            CoordGeo cgSt = new CoordGeo(45.47, 74.68);
            //cgSt.Afficher();

            //12° 02′ 43″ sud, 77° 01′ 52″ ouest
            CoordGeo cgLima = new CoordGeo(-12.02, 77.01);
            //cgLima.Afficher();

            //Ville v1 = new("Saint-Jérôme", cgSt, 80000);
            //Ville v2 = new("Lima", cgLima, 8890000);

            //v1.Afficher();
            //v2.Afficher();  

            List<Ville> lv = new List<Ville>();
            lv.Add(new Ville("Toronto", new CoordGeo(43.40, 79.23), 3025647));
            lv.Add(new Ville("Montréal", new CoordGeo(45.3, 73.35), 1700000));
            lv.Add(new Ville("Calgary", new CoordGeo(51.4, 114.05), 1600000));
            lv.Add(new Ville("Ottawa", new CoordGeo(45.25, 75.41), 1170000));
            lv.Add(new Ville("Edmonton", new CoordGeo(53.32, 113.3), 1223000));
            lv.Add(new Ville("Winnipeg", new CoordGeo(49.53, 97.08), 749000));
            lv.Add(new Ville("Missisauga", new CoordGeo(43.36, 79.39), 710000));

            Pays p1 = new("Canada", lv, new Ville("Ottawa", new CoordGeo(45.25, 75.41), 1170000));

            p1.Afficher();
            _u.Pause();


            //mel 37° 48′ 51″ sud, 144° 58′ 06″ est
            //sydey 33° 51′ 22″ sud, 151° 11′ 33″ est
            // bris 27° 28′ 00″ sud, 153° 02′ 00″ est

            lv = new List<Ville>();
            lv.Add(new Ville("Melbourne", new CoordGeo(-37.48, -144.58), 1234567));
            lv.Add(new Ville("Sydney", new CoordGeo(-33.51, -151.11), 800000));
            lv.Add(new Ville("Brisabane", new CoordGeo(-27.48, -153.02), 1600000));


            Pays p2 = new("Australie", lv, new Ville("Sydney", new CoordGeo(-33.51, -151.11), 800000));
            p2.Afficher();
            _u.Pause();

        }
    }
}
