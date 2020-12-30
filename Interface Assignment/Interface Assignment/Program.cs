using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable obj1 = new Employee();
            obj1.Quit();
        }
    }
}
