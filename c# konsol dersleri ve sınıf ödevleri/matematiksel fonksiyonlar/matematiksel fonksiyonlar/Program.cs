using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematiksel_fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hangi işlemi yapmak istediğinizi giriniz.");
            String islem = Convert.ToString(Console.ReadLine());
            if (islem == "üs alma")
            {
                Console.WriteLine("sayıyı giriniz.");
                int sayi = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("kaçıncı üssünü almak istediğinizi giriniz");
                int üs = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("sonuç =  " + Math.Pow(sayi, üs));

            }
            else if (islem == "kök alma")
            {
                Console.WriteLine("kökü alınacak sayıyı giriniz");
                int kök = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sonuç = " + Math.Sqrt(kök));
            }
            Console.Read();
        }
    }
}
