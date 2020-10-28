using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnt_değişkenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            String ad, soy_Ad, yas, numara;
            int not1, not2, not3, ortalama;
            Console.WriteLine("*** ÖĞRENCİ BİLGİLERİ *****");
            Console.ReadLine();
            ad = "İSİM";
            soy_Ad = "SOYİSİM";
            yas = "YAŞINIZ";
            numara = "NUMARANIZ";
            Console.WriteLine("Ad: {0} SoyAd: {1} Yaş: {2} Numara: {3}", ad, soy_Ad, yas, numara);
            Console.ReadLine();
            Console.WriteLine("*** ÖĞRENCİ NOTLARI *****");
            Console.ReadLine();
            not1 = 60;
            not2 = 70;
            not3 = 80;
            Console.WriteLine("Not 1: {0} No2: {1} Not3: {2}", not1, not2, not3);
            Console.ReadLine();
            Console.WriteLine("*** ORTALAMA *****");
            Console.ReadLine();
            ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalamanız: {0}", ortalama);
            Console.ReadLine();
        }
    }
}
