using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int sayi1, sayi2, toplam, bölünecek;
            Console.WriteLine("..... İŞLEM .....");
            Console.WriteLine("toplama");
            Console.WriteLine("çıkarma");
            Console.WriteLine("çarpma");
            Console.WriteLine("bölme");

            Console.WriteLine("istediğiniz işlemin sembolünü yazınız");
            a = Convert.ToChar(Console.ReadLine());
            switch (a){
                case '+': Console.Clear();
                    Console.WriteLine("1. sayıyı giriniz");
                    sayi1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("2. sayıyı giriniz");
                    sayi2 = Convert.ToInt16(Console.ReadLine());
                    toplam = sayi1 + sayi2;
                    Console.Clear();
                    Console.Write(toplam);
                    break;
                case '-':
                    Console.Clear();
                    Console.WriteLine("1. sayıyı giriniz");
                    sayi1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("2. sayıyı giriniz");
                    sayi2 = Convert.ToInt16(Console.ReadLine());
                    toplam = sayi1 - sayi2;
                    Console.Clear();
                    Console.Write(toplam);
                    break;
                case '*':
                    Console.Clear();
                    Console.WriteLine("1. sayıyı giriniz");
                    sayi1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("2. sayıyı giriniz");
                    sayi2 = Convert.ToInt16(Console.ReadLine());
                    toplam = sayi1 * sayi2;
                    Console.Clear();
                    Console.Write(toplam);
                    break;
                case '/':
                    Console.WriteLine("1. sayıyı giriniz");
                    sayi1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("kaça bölüneceğini yazını.");
                    bölünecek = Convert.ToInt16(Console.ReadLine());
                    toplam = sayi1 / bölünecek;
                    Console.Clear();
                    Console.Write(toplam);
                    break;                 
            }
            Console.Read();
        }
    }
}
