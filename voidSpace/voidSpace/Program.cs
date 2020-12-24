using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            moreParameters obj1 = new moreParameters();
            obj1.takeIn(4, 7);
            obj1.takeIn(input1: 5, input2: 6);
            Console.ReadLine();
        }
    }
}
