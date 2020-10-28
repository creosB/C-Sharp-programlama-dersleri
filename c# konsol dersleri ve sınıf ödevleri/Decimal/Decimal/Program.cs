using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal elma, armut, toplam;
            int sayi1, sayi2;

            elma = 4.99M;
            armut = 3.99m;

            Console.WriteLine("1. ürün ne kadar satıldı");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. ürün ne kadar satıldı");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            toplam = sayi1 * elma + sayi2 * armut;
            Console.Write(toplam + "TL");
            Console.Read();
        }
    }
}
