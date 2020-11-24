using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ricardo";
            //string quote = "The man said, \\Hello\", Ricardo, \n Hello on a new line. \n \t Hello on a new tab.";
            //string fileName = @"C:\Users\'ricar";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ricardo");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
