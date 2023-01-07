using System;
using System.IO;

namespace WorkingWithFilesExercises
{
    internal class Program
    {
        private const string Path = @"..\..\LoremIpsum.txt";

        private static void Main()
        {
            Exercise2();
        }

        private static void Exercise1()
        {
            // Write a program that reads a text file and displays the number of words.
            Console.WriteLine(File.ReadAllText(Path).Split(' ').Length);
        }

        private static void Exercise2()
        {
            // Write a program that reads a text file and displays the longest word in the file.
            var maxLength = 0;
            var longestWord = "";
            var words = File.ReadAllText(Path).Split(' ');

            foreach (var word in words)
            {
                if (word.Length <= maxLength) continue;
                longestWord = word;
                maxLength = word.Length;
            }
            Console.WriteLine(longestWord);
        }
    }
}
