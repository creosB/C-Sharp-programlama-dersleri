using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            String[] sorular = { "sea", "selam", "merhaba" };
            String[] cevaplar = { "ase", "ok", "bb" };
            int a, b;

            a = rasgele.Next(0, sorular.Length);
            b = rasgele.Next(0, cevaplar.Length);
            a = b;
            Console.WriteLine(a);
            Console.WriteLine(sorular[a]);
            Console.WriteLine(b);
            Console.WriteLine(cevaplar[b]);
            Console.Read();                   
        }
    }
}
