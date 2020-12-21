using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            addEmUp obj1 = new addEmUp();
            Console.WriteLine(obj1.addemup(3));
            Console.WriteLine(obj1.addemup(3m));
            Console.WriteLine(obj1.addemup("3"));
            Console.ReadLine();
        }
    }
}
