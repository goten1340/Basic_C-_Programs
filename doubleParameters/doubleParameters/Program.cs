using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            optionalPara obj = new optionalPara();
            Console.WriteLine(obj.doublePara(5));
            Console.WriteLine("Choose first number");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may input a second number if you want");
            string Number2 = Console.ReadLine();
            if (Number2 == "")
            {                
                Console.WriteLine(obj.optionalSecondNumber(Number1));
                
            }
            else
            {
                int conversion = Convert.ToInt32(Number2);
                Console.WriteLine(obj.optionalSecondNumber(Number1, conversion));
            }
            Console.ReadLine();
        }
    }
}
