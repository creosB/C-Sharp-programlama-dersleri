using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmatik_4_işlem
{
    class Program
    {
        static void Main(string[] args)
        {
            nt sayi1, sayi2, toplam, bolum, carpim, fark;

            Console.WriteLine("----- TOPLAMA İŞLEMİ -----");

            Console.WriteLine("Birinci sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("TOPLAM SONUC : {0} ", toplam);

            bolum = sayi1 / sayi2;
            Console.WriteLine("Bölüm: {0} ", bolum);

            carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım: {0} ", carpim);

            fark = sayi1 - sayi2;
            Console.WriteLine("Fark: {0} ", fark);
            Console.Read();
        }
    }
}
