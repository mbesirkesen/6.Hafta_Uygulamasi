using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* GPS Konum Mesafesi
Bir struct oluşturun:
Enlem ve boylam (Latitude ve Longitude) bilgilerini tutsun.
İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplayan bir metot ekleyin (Haversine Formülü).
*/
namespace struct3
{
    struct GPSLocation
    {
        public double Latitude { get; set; } 
        public double Longitude { get; set; } 


        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public static double Distance(GPSLocation point1, GPSLocation point2)
        {

            const double EarthRadiusKm = 6371;

            double lat1Rad = DegreesToRadians(point1.Latitude);
            double lon1Rad = DegreesToRadians(point1.Longitude);
            double lat2Rad = DegreesToRadians(point2.Latitude);
            double lon2Rad = DegreesToRadians(point2.Longitude);

            double deltaLat = lat2Rad - lat1Rad;
            double deltaLon = lon2Rad - lon1Rad;
            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));


            double distance = EarthRadiusKm * c;
            return distance;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
    }

    class Program
    {
        static void Main()
        {
            GPSLocation point1 = new GPSLocation(25.1357, -24.0060); 
            GPSLocation point2 = new GPSLocation(12.0452, -121.2278); 

            double distance = GPSLocation.Distance(point1, point2);

     
            Console.WriteLine($"Mesafe: {distance:F2} km");
            Console.ReadKey();
        }
    }

}
