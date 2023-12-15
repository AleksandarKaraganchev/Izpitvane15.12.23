using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
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
            int sumLessThan100 = IfSumLessThan100(numbers);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------------------------");
            if (sumLessThan100 < 100)
            {
                Console.WriteLine($"Сумата на числата  е под сто и е равна на: {sumLessThan100}");
            }
            else
            {
                Console.WriteLine($"Сумата на числата е равна на: {sumLessThan100}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static int IfSumLessThan100(int[] numbers)
        {
            int sumLessThan100 = 0;
            foreach (var number in numbers)
            {
                if (number < 100)
                {
                    sumLessThan100 += number;
                }
            }
            return sumLessThan100;
        }
    }
}

