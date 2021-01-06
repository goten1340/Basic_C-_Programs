using System;
using System.Collections.Generic;
using System.Linq;

namespace LambaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> obj1 = new List<employee>()
            {
                 new employee() { firstName = "Joe", lastName = "Ryan", id = 1 },
                 new employee() { firstName = "Joe", lastName = "Cloud", id = 2 },
                 new employee() { firstName = "Jake", lastName = "Reynolds", id = 3 },
                 new employee() { firstName = "Boe", lastName = "Ryan", id = 4 },
                 new employee() { firstName = "Bob", lastName = "Ryan", id = 5 },
                 new employee() { firstName = "Joe", lastName = "Ryan", id = 6 },
                 new employee() { firstName = "Bog", lastName = "Ryan", id = 7 },
                 new employee() { firstName = "Joe", lastName = "Ryan", id = 8 },
                 new employee() { firstName = "Bob", lastName = "Ryan", id = 9 },
                 new employee() { firstName = "Joe", lastName = "Ryan", id = 10 },

            };



            //employee emp1 = new employee();
            //emp1.id = 1;
            //emp1.firstName = "Ricardo";
            //emp1.lastName = "Sanchez";
            //obj1.Add(emp1); 
            //employee emp2 = new employee();
            //emp2.id = 2;
            //emp2.firstName = "Val";
            //emp2.lastName = "Morales";
            //obj1.Add(emp2);
            //employee emp3 = new employee();
            //emp3.id = 3;
            //emp3.firstName = "Joe";
            //emp3.lastName = "Rodriguiz";
            //obj1.Add(emp3);
            //employee emp4 = new employee();
            //emp4.id = 4;
            //emp4.firstName = "Joe";
            //emp4.lastName = "Wash";
            //obj1.Add(emp4);
            //employee emp5 = new employee();
            //emp5.id = 5;
            //emp5.firstName = "Computer";
            //emp5.lastName = "Sal";
            //obj1.Add(emp5);
            //employee emp6 = new employee();
            //emp6.id = 6;
            //emp6.firstName = "Harry";
            //emp6.lastName = "Scary";
            //obj1.Add(emp6);
            //employee emp7 = new employee();
            //emp7.id = 7;
            //emp7.firstName = "Chip";
            //emp7.lastName = "ster";
            //obj1.Add(emp7);
            //employee emp8 = new employee();
            //emp8.id = 8;
            //emp8.firstName = "bone";
            //emp8.lastName = "nappa";
            //obj1.Add(emp8);
            //employee emp9 = new employee();
            //emp9.id = 9;
            //emp9.firstName = "weevil";
            //emp9.lastName = "Serenade";
            //obj1.Add(emp9);
            //employee emp10 = new employee();
            //emp10.id = 10;
            //emp10.firstName = "Sally";
            //emp10.lastName = "Ramirez";
            //obj1.Add(emp10);


            List<employee> obj2 = new List<employee>();
            foreach (var employee in obj1)
            {

                if (employee.firstName == "Joe")
                {
                    employee joe = new employee();
                    obj2.Add(employee);
                }
                Console.WriteLine(employee.firstName);
                Console.ReadLine();
            }



                List<employee> cat = new List<employee>();
                cat = obj1.Where(x => x.firstName == "Joe").ToList();

                List<employee> dog = new List<employee>();
                dog = obj1.Where(x => x.id > 5).ToList();

            }
        }
    }