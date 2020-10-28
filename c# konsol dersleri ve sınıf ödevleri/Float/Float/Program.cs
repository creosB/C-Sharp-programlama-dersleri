using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            float sayi;
            sayi = 1.1f;
            Console.WriteLine("1. sayıyı giriniz");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            float toplam = sayi1 + sayi2 + sayi;
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
