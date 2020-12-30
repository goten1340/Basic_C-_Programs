using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    public class Employee : IQuittable
    {
        //public override void SayName() { Console.WriteLine(FirstName + " " + LastName);}
        public void Quit()
        {
            Console.WriteLine("I Quit");
            Console.ReadLine();
        }
    }
}
