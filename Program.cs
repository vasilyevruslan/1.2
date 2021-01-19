using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Zadanie_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий уровень
            try
            {
                double a, b, c, M;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите a:");
                a = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Введите b:");
                b = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите c:");
                c = double.Parse(Console.ReadLine());
                M = 0.5 * Math.Sqrt(2 * b * 2 *b + 2 * c * 2 * c - a * a);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Результат M:" + M);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
