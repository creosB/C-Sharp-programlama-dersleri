using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaman
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;

            Console.WriteLine("hangi yılda doğduğunuzu giriniz");
            int dogm = Convert.ToInt32(Console.ReadLine());
            zaman = DateTime.Now;
            int yıl = zaman.Year;
            int dogmgun = (yıl - dogm);
            Console.WriteLine("yaşınız = {0}",dogmgun);
            Console.Read();
        }
    }
}
