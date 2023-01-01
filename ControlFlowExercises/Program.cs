using System;

namespace ControlFlowExercises
{
    internal class Program
    {
        private static void Main()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
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

            Console.WriteLine($"The larger number is {Math.Max(num1, num2)}");
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
    }

}
