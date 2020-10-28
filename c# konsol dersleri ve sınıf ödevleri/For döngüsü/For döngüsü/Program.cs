using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi;
            String yazi;

            Console.WriteLine("yazdırmak istediğiniz yazıyı giriniz...");
            yazi = Console.ReadLine();

            Console.WriteLine("kaç kere yazdırmak istediğinizi giriniz...");
            sayi = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= sayi; i++)
            {
                Console.WriteLine(yazi);
            }
            Console.Read();
        }
    }
}
