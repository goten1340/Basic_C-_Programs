using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.WriteLine("Enter package width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package length");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            decimal multiplyAndDivide = width * height * length * weight / 100.00m;
            Console.WriteLine("Your estimated total for shipping this package is:$"+multiplyAndDivide);
            Console.ReadLine();
        }
    }
}
