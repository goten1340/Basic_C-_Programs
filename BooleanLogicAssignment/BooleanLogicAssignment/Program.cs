using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            Int32 age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\".");
            Boolean gotcha = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How mant speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualify?");
            Boolean isIt = age > 15 && gotcha == false && speedingTickets <= 3;
            Console.WriteLine(isIt);
            Console.ReadLine();


        }
    }
}
