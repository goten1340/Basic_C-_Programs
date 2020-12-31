using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            employee<string> obj1 = new employee<string>();
            obj1.things = new List<string>();
            obj1.things.Add("car");
            obj1.things.Add("plane");
            obj1.things.Add("Ship");
            employee<int> obj2 = new employee<int>();
            obj2.things = new List<int>();
            obj2.things.Add(2);
            obj2.things.Add(3);
            obj2.things.Add(34);
            foreach (string s in obj1.things)
            {
                Console.WriteLine(s);
            }
            foreach (int i in obj2.things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
