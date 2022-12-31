using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowExercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();
        }

        private static void Exercise1()
        {
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid".
            Console.WriteLine("Please enter a number between 1 and 10");
            short.TryParse(Console.ReadLine(), out var input);
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
            int.TryParse(Console.ReadLine(), out var num1);
            Console.Write("Enter the second number: ");
            int.TryParse(Console.ReadLine(), out var num2);

            Console.WriteLine($"The larger number is {Math.Max(num1, num2)}");
        }
    }

}
