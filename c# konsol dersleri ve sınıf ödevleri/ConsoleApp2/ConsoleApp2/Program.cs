using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diskriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Diskriminant";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("******* Formül *******");
            Console.WriteLine("******* b2 − 4ac *******");
            Console.WriteLine("************************");
            Console.WriteLine("a sayısını giriniz : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("b sayısını giriniz : ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("c sayısını giriniz : ");
            int c = Convert.ToInt16(Console.ReadLine());
            int toplam = (b * b) - 4 * a * c;
            Console.WriteLine("sonuç = {0}", toplam);
            Console.Read();
            
        }
    }
}
