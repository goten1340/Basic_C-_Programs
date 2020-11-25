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
                //1.Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
                //3.Add in a message that displays when the user selects an index that doesn’t exist.

                string[] stringArray = { "Hello", "Ricardo", "Welcome", "hi" };

                try
                {
                    Console.WriteLine("Please select string index from 0-2.");
                    int pickString = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The string you selected is  " + stringArray[pickString]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not type an input.");
                }
                catch
                {
                    Console.WriteLine("Index does not exist");
                }


                //2.Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
                //3.Add in a message that displays when the user selects an index that doesn’t exist.

                int[] numArray = { 4, 6, 8, 10, 12 };
                try {
                    Console.WriteLine("Please select number index from 0-4");
                    int pickNumber = Convert.ToInt32(Console.ReadLine());
                    

                    if (pickNumber > 4)
                    
                    {
                        Console.WriteLine("Index does not exist.");
                    }
                    else
                    {
                        Console.WriteLine("The number you selected is " + numArray[pickNumber]);

                    }
                    //if (pickString == "")
                    //    Console.WriteLine("You didnt pick an index.");
                    //if (pickString > 2)
                    //    Console.WriteLine("Invalid input.");

                    //4.Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
                    //3.Add in a message that displays when the user selects an index that doesn’t exist.

                    
                }
                
                catch (FormatException) { 
                Console.WriteLine("You gave no input.");
                
                }

                List<string> hello = new List<string>() { "Auto", "whatsUp", "CanI" };

                try
                {
                    Console.WriteLine("Please select a index from 0-2");
                    int pickANum = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("The index number you selected contains the content " + hello);
                    if (pickANum < 0 || pickANum > 2)
                    {
                        Console.WriteLine("This is an invalid input");

                    }
                    else
                    {
                        Console.WriteLine(hello[pickANum]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You gave no input");
                }
                Console.ReadLine();
                    
                



           


            }
        }
    }
}
