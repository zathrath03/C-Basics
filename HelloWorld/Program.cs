using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine('b');
            Console.WriteLine(123);
            Console.WriteLine(12.30m);
            Console.WriteLine(true);
            Console.WriteLine(false);

            string firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Beth";
            Console.WriteLine(firstName);
            firstName = "Conrad";
            Console.WriteLine(firstName);
            firstName = "Grant";
            Console.WriteLine(firstName);

            char userOption;
            int gameScore;
            decimal particlesPerMillion;
            bool processedCustomer;

            var message = "Hello World!";
            // message = 0; Cannot implicitly convert type 'int' to 'string'
            Console.WriteLine(message);
            
            Console.ReadKey();
        }
    }
}
