using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] isimler = new string[2];
            int[] sinav1 = new int[2];
            int[] sinav2 = new int[2];
            int[] ortalama = new int[2];

            for (int i = 0; i < 2; i++){
                Console.Clear();
                Console.Write(i + 1 + "ismi giriniz: ");
                isimler[i] = Console.ReadLine();

                Console.Write(i + 1 + "notunuzu giriniz: ");
                sinav1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + "notunuzu giriniz: ");
                sinav2[i] = Convert.ToInt32(Console.ReadLine());

                ortalama[i] = (sinav1[i] + sinav2[i]) / 2;
            }
            Console.WriteLine("***** SONUÇ *****");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("isimler: {0} 1. sınav notu: {1} 2. sınav notu: {2} ortalama: {3}",isimler[i],sinav1[i],sinav2[i],ortalama[i] );
            }
            Console.Read();
        }
    }
}
