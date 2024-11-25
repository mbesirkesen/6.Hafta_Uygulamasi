using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Matematiksel İşlemleri Çeşitlendiren Bir Fonksiyon

Bir fonksiyon yazın:
 Aynı adla ama farklı parametrelerle toplam işlemi yapacak.
 İlk sürümü iki tam sayıyı toplasın.
 İkinci sürümü üç tam sayıyı toplasın.
 Üçüncü sürümü bir dizi (array) tam sayıyı toplasın.*/

namespace overloading1
{   
    class Hesapla
    {
        public int Hesap(int i,int j)
        {
            return i + j;
        }
        public int Hesap(int i,int j,int k)
        {
            return i + j + k;
        }
        public int Hesap(Array array)
        { int toplam = 0;
            foreach (int i in array )
            {
                toplam += i ;
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 3, 5, 7, 8, 90, 78 };
            Hesapla hsp = new Hesapla();
            Console.WriteLine(hsp.Hesap(1, 5));
            Console.WriteLine(hsp.Hesap(1, 5 ,9));
            Console.WriteLine(hsp.Hesap(dizi));
            Console.ReadKey();
        }
    }
}
