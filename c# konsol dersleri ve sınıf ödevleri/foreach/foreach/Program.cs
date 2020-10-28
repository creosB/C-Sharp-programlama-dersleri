using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] isim = new string[1];
            int[] not1 = new int[1];
            int[] not2 = new int[1];
            int[] ortalama = new int[1];

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("ismi giriniz:");
                isim[i] = Console.ReadLine();

                Console.WriteLine("1. sayıyız giriniz:");
                not1[i] = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("2. sayıyı giriniz:");
                not2[i] = Convert.ToInt16(Console.ReadLine());

                ortalama[i] = (not1[i] + not2[i]) / 2;
            }
            foreach (int i in ortalama)
            {
                Console.Clear();
                Console.WriteLine("ortalama: " + i);
            }
            Console.Read();
        }
    }
}
