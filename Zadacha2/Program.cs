using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Въведете брой числа: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int sumMoreThan100 = IfSumMoreThan100(numbers);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------------------------");
            if (sumMoreThan100 < 100)
            {
                Console.WriteLine($"Сумата на числата  е под сто и е равна на: {sumMoreThan100}");
            }
            else
            {
                Console.WriteLine($"Сумата на числата е равна на: {sumMoreThan100}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static int IfSumMoreThan100(int[] numbers)
        {
            int sumMoreThan100 = 0;
            foreach (var item in numbers)
            {
                if (item > 100)
                {
                    sumMoreThan100 += item;
                }

            }
            return sumMoreThan100;
        }
    }
}
