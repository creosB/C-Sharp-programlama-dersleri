using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosol_rengi_değiştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "arka plan rengi değiştirme";
            Console.WriteLine("istediğiiz arka plan rengini girin");
            string renk = Convert.ToString(Console.ReadLine());
            switch (renk)
            {
                case "siyah": Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case "mavi":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case "yeşil":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "sarı":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
            }
            Console.WriteLine("istediğiiz yazı rengini girin");
            string yazırenk = Convert.ToString(Console.ReadLine());
            switch (yazırenk)
            {
                case "siyah":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case "mavi":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case "yeşil":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "sarı":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
            }
            Console.Read();
        }
    }
}
