using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Void_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            vClass obj1 = new vClass();
            Console.WriteLine("Please input a number to operate.");
            int input = Convert.ToInt32(Console.ReadLine());
            obj1.division(input);
            Console.ReadLine();
            float g;
            float super;
            vClass.division(out super,out g );
            Console.WriteLine(g + super);
            Console.ReadLine();
        }
    }
}
