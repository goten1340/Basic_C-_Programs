using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisoOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int free = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int longTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int soul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int soul2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Salary of person 1");
            int freedom = free * longTime * 52;
            Console.WriteLine(freedom);
            Console.WriteLine("Annual Salary of person 2");
            int superSoul = soul * soul2 * 52;
            Console.WriteLine(superSoul);
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool isIt = freedom > superSoul;
            Console.WriteLine(isIt);


            Console.ReadLine();

        }
    }
}
