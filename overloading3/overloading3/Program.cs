using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Zaman Farkını Farklı Formatlarda Hesaplama
Bir fonksiyon yazın:
 Aynı adla ama farklı parametrelerle iki tarih arasındaki farkı hesaplasın.
 İlk sürüm, gün cinsinden farkı döndürsün.
 İkinci sürüm, saat cinsinden farkı döndürsün.
 Üçüncü sürüm, iki tarih arasında yıl, ay ve gün cinsinden farkı ayrı ayrı döndürsün.*/

namespace overloading3
{
    class ZamanHesapla
    {
        public int TarihFarki(DateTime tarih1, DateTime tarih2)
        {
            return (tarih2 - tarih1).Days;
        }
        public int TarihFarki(DateTime tarih1, DateTime tarih2, bool saatCinsinden)
        {
            if (saatCinsinden)
            {
                return (int)(tarih2 - tarih1).TotalHours;
            }
            return TarihFarki(tarih1, tarih2);
        }
        public void TarihFarki(DateTime tarih1, DateTime tarih2, out int yilFarki, out int ayFarki, out int gunFarki)
        {
            yilFarki = tarih2.Year - tarih1.Year;
            ayFarki = tarih2.Month - tarih1.Month;
            gunFarki = tarih2.Day - tarih1.Day;

            if (gunFarki < 0)
            {
                ayFarki--;
                gunFarki += DateTime.DaysInMonth(tarih2.Year, tarih2.Month - 1);
            }
            if (ayFarki < 0)
            {
                yilFarki--;
                ayFarki += 12;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ZamanHesapla hsp = new ZamanHesapla();
            DateTime tarih1 = new DateTime(2020, 1, 1);
            DateTime tarih2 = DateTime.Now;
            int yilFarki = 0, ayFarki = 0, gunFarki = 0;
            Console.WriteLine($"Gün cinsinden fark: {hsp.TarihFarki(tarih1, tarih2)}");
            Console.WriteLine($"Saat cinsinden fark: {hsp.TarihFarki(tarih1, tarih2, true)}");
            hsp.TarihFarki(tarih1, tarih2, out int yil, out int ay, out int gun);
            Console.WriteLine($"Yıl cinsinden fark: {yil}, Ay cinsinden fark: {ay}, Gün cinsinden fark: {gun}");
            Console.ReadKey();
        }
    }
}


