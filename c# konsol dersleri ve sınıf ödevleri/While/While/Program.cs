using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi;
            String yazi;

            i = 1;

            Console.WriteLine("yazılacak yazıyı girniz: ");
            yazi = Console.ReadLine();

            Console.WriteLine("kaç kere yazılacağını giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());

            while (i <= sayi) {
                Console.WriteLine(yazi + i);
                i++;
            }
            Console.Read();
        }
    }
}
