using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Karmaşık Sayı Hesaplama
Bir struct oluşturun:
Karmaşık sayıları temsil etsin (Real ve Imaginary özellikleri).
Toplama ve çıkarma işlemlerini gerçekleştiren iki metot ekleyin.
Sonucu (a + bi) formatında döndüren bir ToString() metodu yazın.
*/

namespace struct2
{
    struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.Real + c2.Real;
            double imaginaryPart = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.Real - c2.Real;
            double imaginaryPart = c1.Imaginary - c2.Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return $"{Real} - {-Imaginary}i";
            }
            else
            {
                return $"{Real} + {Imaginary}i";
            }
        }
    }

    class Program
    {
        static void Main()
        {

            ComplexNumber c1 = new ComplexNumber(9, 6);  
            ComplexNumber c2 = new ComplexNumber(5, -2); 

            ComplexNumber sum = c1 + c2;
            Console.WriteLine($"Toplama: {c1} + {c2} = {sum}");

            ComplexNumber difference = c1 - c2;
            Console.WriteLine($"Çıkarma: {c1} - {c2} = {difference}");

            ComplexNumber c3 = new ComplexNumber(9, 0); 
            ComplexNumber c4 = new ComplexNumber(0, 1); 

            ComplexNumber sum2 = c3 + c4;
            Console.WriteLine($"Toplama: {c3} + {c4} = {sum2}");
            Console.ReadKey();
        }
    }

}
