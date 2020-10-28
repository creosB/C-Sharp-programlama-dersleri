using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        private static int carpma(int s1,int s2)
        {
            int c = s1 * s2;
            return c;
        }
        
        static void Main(string[] args)
        {       
            Console.WriteLine("çarpmak istediğiniz 1. sayıyı giriniz");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("çarpmak istediğiniz 2. sayıyı giriniz");
            int sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Çarpım = " + carpma(sayi1, sayi2));
            Console.Read();
        }
    }
}
