using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            int sayi, not1, not2, ortalama;
            isim = "creos";
            Console.WriteLine("isminizi giriniz");

            if (isim == Console.ReadLine())
            {
                Console.WriteLine("doğru giriş");
                Console.WriteLine("Pozitif bir sayı girip not hesaplama kısmına geçebilirsiniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 0)
                {
                    Console.WriteLine("pozitif bir sayı girdiniz not hesaplamaya geçiliyor...");

                    Console.WriteLine("1. notunuzu giriniz");
                    not1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. notunuzu giriniz");
                    not2 = Convert.ToInt32(Console.ReadLine());

                    ortalama = (not1 + not2) / 2;

                    if (ortalama >= 50)
                    {
                        Console.WriteLine("tebrikler geçtiniz : {0}", ortalama);
                    }
                    else
                    {
                        Console.WriteLine("başarısız oldunuz");
                    }
                }
                else
                {
                    Console.WriteLine("negatif bir sayı girdiniz");
                }

            }
            else
            {
                Console.WriteLine("yanlış giriş");
            }
            Console.Read();
        }
    }
}
