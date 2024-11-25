using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir Öğrenci Not Sistemi
Bir sınıf oluşturun:
 Öğrencilerin aldığı derslerin notlarını depolasın.
 Kullanıcı indeksleyici aracılığıyla ders adına göre notlara erişebilsin.
 Eğer ders yoksa bir hata mesajı döndürsün.*/

namespace Tek_Boyutlu_ve_Çift_Boyutlu_İndeksleyiciler2
{

    public class OgrenciNotSistemi
    {
        private Dictionary<string, int> dersNotlari;

        public OgrenciNotSistemi()
        {
            dersNotlari = new Dictionary<string, int>();
        }

        public void DersNotuEkle(string dersAdi, int notu)
        {
            dersNotlari[dersAdi] = notu;
        }

        public int this[string dersAdi]
        {
            get
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    return dersNotlari[dersAdi];
                }
                else
                {
                    throw new KeyNotFoundException("Bu ders bulunmamaktadır: " + dersAdi);
                }
            }
            set
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    dersNotlari[dersAdi] = value;
                }
                else
                {
                    throw new KeyNotFoundException("Bu ders bulunmamaktadır: " + dersAdi);
                }
            }
        }

        public void DersNotlariniYazdir()
        {
            Console.WriteLine("Öğrenci Ders Notları:");
            foreach (var ders in dersNotlari)
            {
                Console.WriteLine($"{ders.Key}: {ders.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OgrenciNotSistemi ogrenciNotlari = new OgrenciNotSistemi();

            ogrenciNotlari.DersNotuEkle("NTP", 92);
            ogrenciNotlari.DersNotuEkle("Fizik", 90);
            ogrenciNotlari.DersNotuEkle("Algoritma", 47);

            ogrenciNotlari.DersNotlariniYazdir();

            try
            {
                Console.WriteLine("\nNTP Notu: " + ogrenciNotlari["NTP"]);

                ogrenciNotlari["Fizik"] = 85;
                Console.WriteLine("Güncellenmiş Fizik Notu: " + ogrenciNotlari["Fizik"]);
                Console.WriteLine("\nBiyoloji Notu: " + ogrenciNotlari["Biyoloji"]);// Geçersiz bir dersin notunu erişmeye çalışma
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("\nHata: " + e.Message);
            }
            Console.ReadKey();
        }
    }

}
