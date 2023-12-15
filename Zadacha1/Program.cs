using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
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
            int sumEven = IfSumEven(numbers);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------------------------------------------------------------");
            if (sumEven < 100)
            {
                Console.WriteLine($"Сумата на четните числа  е под сто и е равна на: {sumEven}");
            }
            else
            {
                Console.WriteLine($"Сумата на четните числа е равна на: {sumEven}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static int IfSumEven(int[] numbers)
        {
            int sumEven = 0;
            for (int i = 2; i <= numbers.Length; i+= 2)
            {
                sumEven += numbers[i - 1];
            }
            return sumEven;
        }
    }
}
