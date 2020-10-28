using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String ad, soyAd, sehir;
            Console.WriteLine("Adınızı girin");
            ad = Console.ReadLine();
            Console.WriteLine("soyadınızı girin");
            soyAd = Console.ReadLine();
            Console.WriteLine("Sehir girin");
            sehir = Console.ReadLine();

            Console.WriteLine("AD: {0} SOYAD: {1} SEHİR: {2}", ad, soyAd, sehir);
            Console.Read();
        }
    }
}
