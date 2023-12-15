using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
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
            int sumOdd = IfSumOdd(numbers);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------------------------");
            if (sumOdd < 100)
            {
                Console.WriteLine($"Сумата на нечетните числа е под сто и е равна на: {sumOdd}");
            }
            else
            {
                Console.WriteLine($"Сумата на нечетните числа е равна на: {sumOdd}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static int IfSumOdd(int[] numbers)
        {
            int sumOdd = 0;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                sumOdd += numbers[i];
            }
            return sumOdd;
        }
    }
}

