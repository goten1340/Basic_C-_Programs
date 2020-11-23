using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_console_app_assignment
{
    class Program
    {
        static void Main(string[] args)
        {   // first step
            Console.WriteLine("Please type a number less than 4");
            int canI = Convert.ToInt32(Console.ReadLine());
            bool wild = canI < 4;
            while (!wild);
            Console.WriteLine("User input is " + canI);
            Console.ReadLine();

            // second step
            Console.WriteLine("Enter a number greater than 4");
            int canU = Convert.ToInt32(Console.ReadLine());
            do
            {
              Console.WriteLine("User input is " + canU);
              Console.ReadLine();
            } while (canU > 4);
            

        }
    }
}
