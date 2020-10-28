using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sehirler = new string[3], km = new string[3];
            Console.WriteLine("***** ŞEHİRLER ***** ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Şehirler: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("***** Mesafe *****");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Kaç kilometre: ");
                km[i] = Console.ReadLine();
            }
            Console.WriteLine("***** SONUÇ *****");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Şehir: {0} Km: {1}", sehirler[i], km[i]);
            }
            Console.Read();
        }
    }
}
