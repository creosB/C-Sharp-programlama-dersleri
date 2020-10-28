using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrry_komut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];

            for (int i= 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + ".sayiyi giriniz");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(sayilar);

            Console.Clear();
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
