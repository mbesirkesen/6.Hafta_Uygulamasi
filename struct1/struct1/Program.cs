using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Zaman İşlemleri
Bir struct oluşturun :
Saat ve dakikayı tutacak şekilde tasarlansın (Hour ve Minute özellikleri).
Kullanıcı bir zaman nesnesi oluşturduğunda, eğer girilen saat/dakika geçersizse otomatik olarak 0 yapılmalı.
Zamanın toplam dakika değerini döndüren bir metot ekleyin.
İki zaman nesnesi arasındaki farkı (dakika olarak) hesaplayan bir metot ekleyin.
*/

namespace struct1
{
    struct Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }


        public Time(int hour, int minute)
        {
        
            if (hour < 0 || hour >= 24)
            {
                Hour = 0; // Geçersiz saat girildiğinde 0 yap
            }
            else
            {
                Hour = hour;
            }

            if (minute < 0 || minute >= 60)
            {
                Minute = 0; // Geçersiz dakika girildiğinde 0 yap
            }
            else
            {
                Minute = minute;
            }
        }


        public int ToTotalMinutes()
        {
            return (Hour * 60) + Minute;
        }


        public static int DifferenceInMinutes(Time time1, Time time2)
        {
            int totalMinutes1 = time1.ToTotalMinutes();
            int totalMinutes2 = time2.ToTotalMinutes();
            return Math.Abs(totalMinutes1 - totalMinutes2); 
        }


        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}";
        }
    }

    class Program
    {
        static void Main()
        {

            Time time1 = new Time(5, 30);  
            Time time2 = new Time(12, 45);  
            Time time3 = new Time(25, 70);  

        
            Console.WriteLine($"Time1: {time1}");  
            Console.WriteLine($"Time2: {time2}");  
            Console.WriteLine($"Time3: {time3}");  


            Console.WriteLine($"Time1 toplam dakika: {time1.ToTotalMinutes()}");  
            Console.WriteLine($"Time2 toplam dakika: {time2.ToTotalMinutes()}");  


            int difference = Time.DifferenceInMinutes(time1, time2);
            Console.WriteLine($"Time1 ile Time2 arasındaki fark: {difference} dakika");  


            Console.WriteLine($"Time3 toplam dakika: {time3.ToTotalMinutes()}");
            Console.ReadKey();
        }
    }

}
