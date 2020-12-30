using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.FirstName = "Sample";
            obj1.LastName = "Student";
            obj1.SayName();
            Console.ReadLine();
        }
    }
}
