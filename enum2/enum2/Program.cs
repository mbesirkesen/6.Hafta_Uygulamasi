using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Hava Durumu Tahmini
Bir enum oluşturun :
 Hava durumu tiplerini(Sunny, Rainy, Cloudy, Stormy) temsil etsin.
 Enum’a göre tavsiye veren bir metot yazın (örneğin, yağmurluysa şemsiye alın).*/

namespace enum2
{   
    enum HavaDurumu
    {
        gunesli,
        yagmurlu,
        bulutlu,
        fırtınali
    }
    class Tavsiye
    {
        public static string TavsiyeVer(HavaDurumu hava)
        {
            switch (hava)
            {
                case HavaDurumu.bulutlu:
                    return "Hava Bulutlu yağmur yağabilir şemsiyenizi almanız iyi bir tercih olru";
                case HavaDurumu.fırtınali:
                    return "Hava Fırtınalı dışarı çıkmamanız sizin için iyi olur";
                case HavaDurumu.gunesli:
                    return "Hava Güneşli dışarıda istediğiniz gibi takılabilirsiniz";
                case HavaDurumu.yagmurlu:
                    return "Hava Yağmurlu şemsiyenizi almanız iyi bir tercih olur";
                default: return "";
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HavaDurumu suan = HavaDurumu.yagmurlu;
            Console.WriteLine(Tavsiye.TavsiyeVer(suan));

            suan = HavaDurumu.bulutlu;
            Console.WriteLine(Tavsiye.TavsiyeVer(suan));

            suan = HavaDurumu.fırtınali;
            Console.WriteLine(Tavsiye.TavsiyeVer(suan));

            suan = HavaDurumu.gunesli;
            Console.WriteLine(Tavsiye.TavsiyeVer(suan));
            Console.ReadKey();
        }
    }
}
