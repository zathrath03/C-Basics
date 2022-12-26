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

            Console.WriteLine("==========================================================");
            // Write code in the .NET Editor to display a message
            // When you're finished, the message should resemble the following output:
            // Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
            // Store Bob, 3, and 34.4 in variables
            // These variables should be given names that reflect their purpose.
            // Make sure you select the correct data type for each of the variables based on the type of data it will hold.
            // Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form the complete message.

            string name = "Bob";
            byte numberOfMessages = 3;
            float temperature = 34.4f;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(numberOfMessages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.WriteLine(" celsius.");

            Console.WriteLine("Hello, {0}! You have {1} messages in your inbox. The temperature is {2} celsius.", name, numberOfMessages, temperature);

            Console.WriteLine($"Hello, {name}! You have {numberOfMessages} messages in your inbox. The temperature is {temperature} celsius.");

            Console.ReadKey();
        }
    }
}
