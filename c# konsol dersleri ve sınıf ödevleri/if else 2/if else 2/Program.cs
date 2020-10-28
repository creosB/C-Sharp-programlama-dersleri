using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.WriteLine("lütfen bir sayı giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 5 == 0)
            {
                Console.WriteLine("sayı 5 e bölünüyor");
            }
            else if (sayi % 3 == 0)
            {
                Console.WriteLine("sayı 3 e bölünüyor");
            }
            else
            {
                Console.WriteLine("sayı 3 veya 5 e bölünmüyor");
            }
            Console.Read();
        }
    }
}
