using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Farklı Şekillerin Alanını Hesaplayan Bir Fonksiyon
Bir fonksiyon yazın:
 Aynı adla ama farklı parametrelerle farklı şekillerin alanını hesaplasın.
 İlk sürüm, bir karenin alanını hesaplasın (bir kenar uzunluğu verilerek).
 İkinci sürüm, bir dikdörtgenin alanını hesaplasın (iki kenar uzunluğu verilerek).
 Üçüncü sürüm, bir dairenin alanını hesaplasın (yarıçap verilerek).*/

namespace overloading2
{   
    class AlanHesapla
    {
        public int Hesapla(int i)
        {
            return i ^ 2;
        }
        public int Hesapla(int i, int j)
        {
            return i * j;
        }
        public double Hesapla(double r)
        {
            return (r*r)*(3.14);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AlanHesapla hsp = new AlanHesapla();
            Console.WriteLine(hsp.Hesapla(5));
            Console.WriteLine(hsp.Hesapla(5,12));
            Console.WriteLine(hsp.Hesapla(5.00));
            Console.ReadKey();
        }
    }
}
