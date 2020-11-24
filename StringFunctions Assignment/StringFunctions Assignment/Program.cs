using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello " + "how" + " are you?";
            string upper = text.ToUpper();

            StringBuilder sb = new StringBuilder("Hello World");
            sb.Append(" This is my place.");
            sb.Append(" What i learn is to give back to my community.");
            sb.Append(" What else should I say?");
            sb.Append(" Thank you for listening.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
