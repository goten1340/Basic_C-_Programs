using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                string[] stringArray = { "Hello", "Ricardo", "Welcome" };




                int[] numArray = { 4, 6, 8, 10, 12 };




                try
                {
                    Console.WriteLine("Please select string index from 0-2.");
                    string pickString = (Console.ReadLine());
                    int hi = Convert.ToInt32(pickString);
                    if (hi > 2)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        Console.WriteLine(stringArray[hi]);

                    }
                    Console.WriteLine("Please select integer index from 0-4.");
                    string pickInt = (Console.ReadLine());

                    int hello = Convert.ToInt32(pickInt);
                    if (hello > 4)
                    {
                        Console.WriteLine("This is an invalid input");
                    }
                    else
                    {
                        Console.WriteLine(numArray[hello]);
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not type an input.");
                }


                //if (pickString == "")
                //    Console.WriteLine("You didnt pick an index.");
                //if (pickString > 2)
                //    Console.WriteLine("Invalid input.");

                List<string> hey = new List<string>
                {
                    "Auto", "whatsUp", "CanI"
                };

                try
                {
                    Console.WriteLine("Please select a index from 0-2");
                    int pickANum = Convert.ToInt32(Console.ReadLine());
                    if (pickANum > 2)
                    {
                        Console.WriteLine("This is an invalid input.");
                    }
                    else
                    {
                        Console.WriteLine(hey[pickANum]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You gave no input");
                }
            }


            Console.ReadLine();


        }
    }
}
