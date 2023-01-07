using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFilesExercises
{
    internal class Program
    {
        private const string Path = @"..\..\LoremIpsum.txt";
        static void Main(string[] args)
        {
            Exercise1();
        }

        static void Exercise1()
        {
            // Write a program that reads a text file and displays the number of words.
            Console.WriteLine(File.ReadAllText(Path).Split(' ').Length);
        }
    }
}
