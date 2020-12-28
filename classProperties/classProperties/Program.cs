using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.FirstName = "Sample";
            obj1.SayName();
            obj1.LastName = "Student";
            Console.ReadLine();

            
        }
    }
}
