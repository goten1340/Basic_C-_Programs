using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int times50 = 50;
            string userInput = Console.ReadLine();
            int results = Convert.ToInt32(userInput);
            int superResults = results * times50;
            Console.Write(superResults);
            Console.ReadLine();

            int plus25 = 25;
            string superInput = Console.ReadLine();
            int fieryResult = Convert.ToInt32(superInput);
            int veryResult = plus25 + fieryResult;
            Console.WriteLine(veryResult);
            Console.ReadLine();

            Decimal divide = 12.5m;
            string fireInput = Console.ReadLine();
            decimal convert = Convert.ToDecimal(fireInput);
            decimal sunResult = convert / divide;
            Console.WriteLine(sunResult);
            Console.ReadLine();

            bool trueOrFalse = 51 > 50;
            string ok = Console.ReadLine();
            bool ready = Convert.ToBoolean(ok);
            Console.WriteLine(ready);
            Console.ReadLine();

            int seven = 7;
            string forever = Console.ReadLine();
            int comeOn = Convert.ToInt32(forever);
            Console.WriteLine(comeOn);
            Console.ReadLine();
            
        }
    }
}
