using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you wish to perform the operation on?");
                int numberPicked = Convert.ToInt32(Console.ReadLine());
            MethodClass obj1 = new MethodClass();
            Console.WriteLine(obj1.AddEmUp(numberPicked));
            Console.WriteLine(obj1.Minus(numberPicked));
            Console.WriteLine(obj1.division(numberPicked));
            Console.ReadLine();

        }
    }
}
