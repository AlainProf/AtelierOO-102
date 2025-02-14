using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_102.Internationnal
{
    internal class CoordGeo
    {
        public double Longitude { get; set; }
        public double Latitude  { get; set; }

        public CoordGeo() 
        { 
            Longitude = 0.0; Latitude = 0.0;    
        }   

        public CoordGeo(double la    , double lo)
        {
            Longitude = lo;
            Latitude = la;
        }   

        public void Afficher()
        {
            // 45° 47′ nord, 74° 00′ ouest
            string NordSud = "N";
            if (Latitude < 0.0)
            {
                NordSud = "S";
            }

            string EstOuest = "O";
            if (Longitude < 0.0)
            {
                EstOuest = "E";
            }



            Console.WriteLine($"{Math.Abs(Latitude)} {NordSud}, {Math.Abs(Longitude)} {EstOuest}");

        }
    }
}
