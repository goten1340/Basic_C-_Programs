using System;
using System.IO;

namespace logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number?");
            string results = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Owner\source\repos\logs\logs\logs.txt", results);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Owner\source\repos\logs\logs\logs.txt"));
            Console.ReadLine();
        }
    }
}
