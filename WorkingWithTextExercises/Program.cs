using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise2();
        }

        private static void Exercise1()
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are
             * consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
             * "Consecutive"; otherwise, display "Not Consecutive".
             */

            Console.Write("Enter a few numbers separated by a hyphen: ");
            var numbers = Array.ConvertAll(Console.ReadLine().Split('-'), Convert.ToInt32);
            var modifier = numbers[0] < numbers[1] ? (short)1 : (short)-1;

            for (byte i = 0; i < numbers.Length - 1; i++)
            {
                var num = numbers[i];
                var nextNum = numbers[i + 1];
                if (num + modifier == nextNum) continue;
                Console.WriteLine("Not Consecutive");
                return;
            }
            Console.WriteLine("Consecutive");
        }

        private static void Exercise2()
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses
             * Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so,
             * display "Duplicate" on the console.
             */
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;
            var numbers = Array.ConvertAll(input.Split('-'), Convert.ToInt32);
            var seen = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (seen.Contains(number))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }

                seen.Add(number);
            }
        }
    }
}
