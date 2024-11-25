using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Çok Katmanlı Bir Otopark Sistemi
Bir sınıf oluşturun:
Her katmanda bir dizi park yerini temsil etsin.
Kullanıcı, indeksleyici aracılığıyla belirli bir kat ve park yeri kombinasyonuna erişebilsin.
Park yeri boşsa "Empty" döndürsün, doluysa araç plakasını göstersin.
*/

namespace Tek_Boyutlu_ve_Çift_Boyutlu_İndeksleyiciler4
{
    class ParkingSystem
    {
        private string[,] parkingSpaces;

        public ParkingSystem(int floors, int spacesPerFloor)
        {

            parkingSpaces = new string[floors, spacesPerFloor];

            for (int i = 0; i < floors; i++)
            {
                for (int j = 0; j < spacesPerFloor; j++)
                {
                    parkingSpaces[i, j] = "Empty";
                }
            }
        }

        public string this[int floor, int space]
        {
            get
            {
                
                if (floor >= 0 && floor < parkingSpaces.GetLength(0) && space >= 0 && space < parkingSpaces.GetLength(1))
                {
                    return parkingSpaces[floor, space];
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz kat veya park yeri! Lütfen geçerli bir kombinasyon giriniz.");
                }
            }
            set
            {
                
                if (floor >= 0 && floor < parkingSpaces.GetLength(0) && space >= 0 && space < parkingSpaces.GetLength(1))
                {
                    parkingSpaces[floor, space] = value; 
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz kat veya park yeri! Lütfen geçerli bir kombinasyon giriniz.");
                }
            }
        }

     
        public void DisplayParkingStatus()
        {
            for (int i = 0; i < parkingSpaces.GetLength(0); i++)
            {
                Console.WriteLine($"Kat {i + 1}:");
                for (int j = 0; j < parkingSpaces.GetLength(1); j++)
                {
                    Console.Write($"[ {parkingSpaces[i, j]} ] ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    class Program
    {
        static void Main()
        {
       
            ParkingSystem parkingSystem = new ParkingSystem(5, 4);

          
            parkingSystem.DisplayParkingStatus();

           
            parkingSystem[0, 0] = "ABC123";  
            parkingSystem[2, 3] = "XYZ789";  

          
            Console.WriteLine("\nGüncellenmiş Otopark Durumu:");
            parkingSystem.DisplayParkingStatus();
            
            Console.WriteLine("\nKat 1, Park Yeri 1: " + parkingSystem[0, 0]);  
            Console.WriteLine("Kat 3, Park Yeri 4: " + parkingSystem[2, 3]);  
            Console.WriteLine("Kat 2, Park Yeri 2: " + parkingSystem[1, 1]);  

  
            try
            {
                Console.WriteLine(parkingSystem[5, 4]);  // Hata alır
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  // Geçersiz kat veya park yeri!
            }
            Console.ReadKey();
        }
    }
}
