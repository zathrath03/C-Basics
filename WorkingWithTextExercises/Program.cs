using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithTextExercises
{
    /* Note: For all these exercises, ignore input validation unless otherwise specified. Assume the user provides input in
     * the format that the program expects.
     */
    internal class Program
    {
        private static void Main()
        {
            Exercise4();
        }

        private static void Exercise1()
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are
             * consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
             * "Consecutive"; otherwise, display "Not Consecutive".
             */
            
            Console.WriteLine(IsConsecutive(GetNumbersFromConsole()) ? "Consecutive" : "Not Consecutive");
        }

        private static bool IsConsecutive(IReadOnlyList<int> numbers)
        {
            if (numbers.Count < 2) return true;
            var modifier = DetermineIfIncreasingOrDecreasing(numbers);

            for (byte i = 0; i < numbers.Count - 1; i++)
            {
                var num = numbers[i];
                var nextNum = numbers[i + 1];
                if (num + modifier == nextNum) continue;
                return false;
            }
            return true;
        }

        private static short DetermineIfIncreasingOrDecreasing(IReadOnlyList<int> numbers)
        {
            return numbers[0] < numbers[1] ? (short)1 : (short)-1;
        }

        private static int[] GetNumbersFromConsole()
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            return string.IsNullOrWhiteSpace(input) ? Array.Empty<int>() : Array.ConvertAll(input.Split('-'), Convert.ToInt32);
        }

        private static void Exercise2()
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses
             * Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so,
             * display "Duplicate" on the console.
             */
            var numbers = GetNumbersFromConsole();
            if (numbers == Array.Empty<int>()) return;
            if (HasDuplicates(numbers))
                Console.WriteLine("Duplicate");
        }

        private static bool HasDuplicates(IEnumerable<int> numbers)
        {
            var seen = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (seen.Contains(number))
                    return true;
                seen.Add(number);
            }
            return false;
        }

        private static void Exercise3()
        {
            /* Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid
             * time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid
             * Time". If the user doesn't provide any values, consider it as invalid time.
             */
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            Console.WriteLine(DateTime.TryParse(Console.ReadLine(), out var _) ? "Ok" : "Invalid Time");
        }

        private static void Exercise4()
        {
            /* Write a program and ask the user to enter a few words separated by a space. Use the words to create a
             * variable name with PascalCase. For example, if the user types: "number of students", display
             * "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF
             * STUDENTS", the program should still display "NumberOfStudents".
             */
            var words = GetWordsFromConsole();
            var pascalCase = new StringBuilder();
            foreach (var word in words)
            {
                pascalCase.Append(char.ToUpper(word[0]))
                          .Append(word.Substring(1).ToLower());
            }

            Console.WriteLine(pascalCase);
        }

        private static IEnumerable<string> GetWordsFromConsole()
        {
            Console.Write("Enter a few word separated by a space: ");
            var input = Console.ReadLine();
            return string.IsNullOrWhiteSpace(input) ? Array.Empty<string>() : input.Split(' ');
        }

        private static void Exercise5()
        {
            /* Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the
             * word. So, if the user enters "inadequate", the program should display 6 on the console.
             */
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = 0;

            Console.Write("Enter an English word: ");
            var input = Console.ReadLine().ToLower();

            foreach (var c in input)
            {
                if (vowels.Contains(c))
                    vowelCount++;
            }

            Console.WriteLine(vowelCount);
        }
    }
}
