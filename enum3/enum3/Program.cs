using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Çalışan Rolleri ve Maaş Hesaplama
Bir enum oluşturun:
 Çalışan rolleri (Manager, Developer, Designer, Tester) için maaşları belirlemek üzere.
 Enum’a göre maaşı hesaplayan bir metot yazın.*/

namespace enum3
{   
    enum Roller
    {
        Müdür,
        Geliştirici,
        Tasarimci,
        Testci
    }
    class Maas
    {
        public static string MaasHesapla(Roller rol)
        {
            switch (rol)
            {
                case Roller.Geliştirici:
                    return "Geliştirici Maaşı: 75000 TL";
                case Roller.Müdür:
                    return "Müdür Maaşı: 125000 TL";
                case Roller.Tasarimci:
                    return "Tasarımcı Maaşı: 65000 TL";
                case Roller.Testci:
                    return "Tester Maaşı: 60000 TL";
                default: return " ";

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Roller rol = Roller.Testci;
            Console.WriteLine(Maas.MaasHesapla(rol));

            rol = Roller.Geliştirici;
            Console.WriteLine(Maas.MaasHesapla(rol));

            rol = Roller.Müdür;
            Console.WriteLine(Maas.MaasHesapla(rol));

            rol = Roller.Tasarimci;
            Console.WriteLine(Maas.MaasHesapla(rol));
            Console.ReadKey();
        }
    }
}
