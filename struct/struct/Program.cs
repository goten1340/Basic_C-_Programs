using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Number obj1 = new Number();
            Number forTech = new Number();
            obj1.Amount = 38.9m;
            Console.WriteLine(obj1.Amount);
            Console.ReadLine();
        }
    }
    struct Number
    {
        public decimal Amount { get; set; }
    }
}
