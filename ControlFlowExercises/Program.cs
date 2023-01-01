using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlFlowExercises

/* Note: for all these exercises, ignore input validation unless otherwise
 * directed. Assume the user enters a value in the format that the program
 * expects. For example, if the program expects the user to enter a number,
 * don't worry about validating if the input is a number or not. When testing
 * your program, simply enter a number.
 */
{
    internal class Program
    {
        private static void Main()
        {
            Exercise9();
        }

        private static void Exercise1()
        {
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid".
            Console.WriteLine("Please enter a number between 1 and 10");
            var input = Convert.ToInt16(Console.ReadLine());
            if (1 <= input && input <= 10)
            {
                Console.WriteLine("Valid Input");
            } else {
                Console.WriteLine("Invalid Input");
            }
        }

        private static void Exercise2()
        {
            //Write a program which takes two numbers from the
            //console and displays the maximum of the two.
            Console.Write("Enter the first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var max = num1 > num2 ? num1 : num2;
            Console.WriteLine($"The larger number is {max}");
        }

        private static void Exercise3()
        {
            /* Write a program and ask the user to enter the
             * width and height of an image. Then tell if the
             * image is landscape or portrait.
             */
            Console.Write("Enter the width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? "landscape" : "portrait";
            Console.WriteLine($"The image is {orientation}");
        }

        private static void Exercise4()
        {
            /* Your job is to write a program for a speed camera. For
             * simplicity, ignore the details such as camera, sensors, etc and
             * focus purely on the logic. Write a program that asks the user
             * to enter the speed limit. Once set, the program asks for the
             * speed of a car. If the user enters a value less than the speed
             * limit, program should display Ok on the console. If the value
             * is above the speed limit, the program should calculate the
             * number of demerit points. For every 5km/hr above the speed
             * limit, 1 demerit points should be incurred and displayed on the
             * console. If the number of demerit points is above 12, the
             * program should display License Suspended.
             */
            const short kphOverPerDemerit = 5;

            Console.Write("Enter the speed limit: ");
            var speedLimit = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            var carSpeed = Convert.ToInt16(Console.ReadLine());
            if (carSpeed > speedLimit)
            {
                var demerits = (short)((carSpeed - speedLimit) / kphOverPerDemerit);
                Console.WriteLine($"That car has incurred {demerits} demerit points");
                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }

        private static void Exercise5()
        {
            /* Write a program to count how many numbers between 1 and 100 are
             * divisible by 3 with no remainder. Display the count on the console.
             */
            byte count = 0;
            for (byte i = 3; i < 100; i += 3)
                count += 1;
            Console.WriteLine($"There are {count} numbers evenly divisible by 3 between 1 and 100");
        }

        private static void Exercise6()
        {
            /* Write a program and continuously ask the user to enter a number
             * or "ok" to exit. Calculate the sum of all the previously
             * entered numbers and display it on the console.
             */

            string input;
            var numbers = new List<int>();

            do
            {
                Console.Write("Enter a number or \"ok\" to exit: ");
                input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out var number))
                {
                    numbers.Add(number);
                }

            } while (input.ToLowerInvariant() != "ok");

            Console.WriteLine(numbers.Sum());
        }

        private static void Exercise7()
        {
            /* Write a program and ask the user to enter a number. Compute the
             * factorial of the number and print it on the console. For
             * example, if the user enters 5, the program should calculate
             * 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */

            // ulong can only hold 1.8E18
            // 20! = 2.4E18, so any value entered 20 or above results in overflow
            byte input;
            do
            {
                Console.Write("Please enter a positive number below 20: ");
                if (!byte.TryParse(Console.ReadLine(), out input))
                    input = 20;
                
            } while (input > 19);
            
            ulong output = 1;
            for (byte i = 1; i <= input; i++)
            {
                output *= i;
            }
            Console.WriteLine($"{input}! = {output}");
        }

        private static void Exercise8()
        {
            /* Write a program that picks a random number between 1 and 10.
             * Give the user 4 chances to guess the number. If the user
             * guesses the number, display “You won"; otherwise, display “You
             * lost". (To make sure the program is behaving correctly, you can
             * display the secret number on the console first.)
             */

            var answer = (byte) new Random().Next(1, 11);
            byte guess = 0;
            Console.WriteLine("I have chosen a number between 1 and 10 (inclusive)");
            Console.WriteLine("You have four chances to guess my number.");
            Console.WriteLine($"The answer is {answer}");

            for (byte turn = 1; turn < 5; turn++)
            {
                
                do
                {
                    Console.Write($"Turn {turn}: What's your guess? ");

                } while (!byte.TryParse(Console.ReadLine(), out guess));

                if (guess != answer) continue;
                Console.WriteLine("You won");
                break;
            }

            if (guess != answer)
            {
                Console.WriteLine("You lost");
            }
        }

        private static void Exercise9()
        {
            /* Write a program and ask the user to enter a series of numbers
             * separated by comma. Find the maximum of the numbers and display
             * it on the console. For example, if the user enters
             * “5, 3, 8, 1, 4", the program should display 8.
             */

            Console.WriteLine("Enter a series of numbers separated by commas.");
            try
            {
                var max = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse).Max();
                Console.WriteLine($"The maximum is {max}");
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
