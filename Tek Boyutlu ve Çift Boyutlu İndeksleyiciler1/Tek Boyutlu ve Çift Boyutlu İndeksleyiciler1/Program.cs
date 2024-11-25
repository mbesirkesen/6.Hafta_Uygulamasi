using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Özel Bir Kitaplık Yönetim Sistemi
Bir sınıf oluşturun:
 Sınıf, bir kitap koleksiyonunu (dizi) depolasın.
 Kullanıcı, indeksleyici aracılığıyla belirli bir indekste hangi kitabın olduğunu
öğrenebilsin ve kitap adını değiştirebilsin.
 Eğer kullanıcı geçersiz bir indeks ile erişim yaparsa uygun bir hata mesajı döndürsün.*/

namespace Tek_Boyutlu_ve_Çift_Boyutlu_İndeksleyiciler1
{
    public class KitaplikYonetimSistemi
    {
        private List<string> kitaplar;
        public KitaplikYonetimSistemi()
        {
            kitaplar = new List<string>();
        }

        public void KitapEkle(string kitapAdi)
        {
            kitaplar.Add(kitapAdi);
        }

        public string this[int indeks]
        {
            get
            {
                if (indeks < 0 || indeks >= kitaplar.Count)
                {
                    throw new IndexOutOfRangeException("Geçersiz indeks! Bu indekste kitap yok.");
                }
                return kitaplar[indeks];
            }
            set
            {
                if (indeks < 0 || indeks >= kitaplar.Count)
                {
                    throw new IndexOutOfRangeException("Geçersiz indeks! Bu indekse kitap eklenemez.");
                }
                kitaplar[indeks] = value;
            }
        }

        public void KitaplariYazdir()
        {
            Console.WriteLine("Kitap Koleksiyonu:");
            for (int i = 0; i < kitaplar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {kitaplar[i]}");
            }
        }
        public void KitabıYaz(int i)
        {   
            Console.WriteLine($"{i + 1}. kitap: {kitaplar[i]}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KitaplikYonetimSistemi kitaplik = new KitaplikYonetimSistemi();

            kitaplik.KitapEkle("1984");
            kitaplik.KitapEkle("Seffiller");
            kitaplik.KitapEkle("Ben ve Dünya");

            kitaplik.KitaplariYazdir();

            try
            {
                kitaplik.KitabıYaz(2);// Geçerli indeks
                kitaplik[1] = "Yeni Dünya"; 
                Console.Write($"Güncellenmiş " ); kitaplik.KitabıYaz(1);

                //kitaplik.KitabıYaz(12);
                Console.WriteLine(kitaplik[4]);  // Geçersiz indeks
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\nHata: " + e.Message);
            }
            Console.ReadKey();
        }
    }

}
