using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_boyutlu_diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris1 = new int[2, 4];
            int[,] matris2 = new int[2, 4];
            int[,] toplammatris = new int[2, 4];

            Console.WriteLine("1. Matrisin Değerlerini Giriniz");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(i + " satırın " + j + " Sutunu Giriniz : ");
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("2. Matris Giriniz :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(i + " Satırın " + j + " Sutunu Giriniz : ");
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    toplammatris[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(toplammatris[i, j] + " ");
                }
            }
            Console.Read();
        }
    }
    }
