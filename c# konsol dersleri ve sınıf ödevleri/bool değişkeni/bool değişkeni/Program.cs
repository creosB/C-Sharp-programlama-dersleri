using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("şifreyi giriniz");
            string sifre = Convert.ToString(Console.ReadLine());
            bool durum1 = sifre == "baris";
            if (durum1 == true)
            {
                Console.WriteLine("şifreyi doğru girdiniz");
            }
            else
            {
                Console.WriteLine("şifreyi yanlış girdiiz");
            }
            Console.Read();
        }
    }
}
