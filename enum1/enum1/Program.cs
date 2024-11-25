using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Trafik Işığı Durumu
Bir enum oluşturun:
Trafik ışıkları (Red, Yellow, Green) için durumları temsil etsin.
Bir sınıf oluşturun ve enum’a göre hangi durumda ne yapılması gerektiğini döndüren bir metot yazın.
*/

namespace enum1
{
    enum TrafikIşıklari
    {
        kirmizi,
        yesil,
        sari
        
    }
    class TrafikIsikDurumu
    {
        public static string NeYapmali(TrafikIşıklari durum)
        {
            switch (durum) {
                case TrafikIşıklari.kirmizi:
                    return "Dur!";
                case TrafikIşıklari.sari:
                    return "Hazırlan!";
                case TrafikIşıklari.yesil:
                    return "Geç!";
                default: return "Bilinmeyen durum";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                TrafikIşıklari suan = TrafikIşıklari.kirmizi;
                Console.WriteLine($"Şuanki Işık: {suan} Yapman Gereken: {TrafikIsikDurumu.NeYapmali(suan)}");

                TrafikIşıklari suann = TrafikIşıklari.yesil;
                Console.WriteLine($"Şuanki Işık: {suann} Yapman Gereken: {TrafikIsikDurumu.NeYapmali(suann)}");

                TrafikIşıklari suannn = TrafikIşıklari.sari;
                Console.WriteLine($"Şuanki Işık: {suannn} Yapman Gereken: {TrafikIsikDurumu.NeYapmali(suannn)}");

                //TrafikIşıklari hata = TrafikIşıklari.mor;
                //Console.WriteLine($"Şuanki Işık: {hata} Yapman Gereken: {TrafikIsikDurumu.NeYapmali(hata)}");
                Console.ReadKey();
            }
        }
    }
}