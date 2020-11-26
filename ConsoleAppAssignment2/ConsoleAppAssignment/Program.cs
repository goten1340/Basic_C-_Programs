using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************** ASSIGNMENT 1 ******************

            string[] names = { "joe", "josh", "marina", "sally" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Please write some content.");
            string Content = Console.ReadLine();
            foreach (string name in names)
            {
                string userInput = name + Content;
                Console.WriteLine(userInput);
            }


            //*************** ASSIGNMENT 2 ******************

            Console.WriteLine("For the first for loop.");
            for (int a = 75; a > 50; a--)
            {
                Console.WriteLine(a);

            }



            //*************** ASSIGNMENT 3 ******************

            Console.WriteLine("For the second for loop.");
            for (int b = 25; b < 40; b++)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("For the third for loop.");
            for (int c = 12; c <= 12; c++)
            {
                Console.WriteLine(c);
            }

            //*************** ASSIGNMENT 4 ******************


            List<string> uniques = new List<string> { "family", "Sally", "Wax", "string" };
            Console.WriteLine("Please enter text you are looking for.");
            string userInput2 = Console.ReadLine();
            for (int d = 0; d < uniques.Count; d++)
            {
                if (userInput2 == uniques[d])
                {
                    Console.WriteLine(d);
                }

                else
                {
                    Console.WriteLine("Match not found at this index");
                }
            }
            //*************** ASSIGNMENT 5 ******************

            List<string> identical = new List<string> { "sally", "sally", "joe", "tom" };
            Console.WriteLine("Select a word to search for in the index. ");
            string userInput3 = Console.ReadLine();

            for (int e = 0; e < identical.Count; e++)
            {
                if (userInput3 == identical[e])
                {
                    Console.WriteLine(e);
                }
                else
                {
                    Console.WriteLine("Word not found in the indices");
                }

            }
            //*************** ASSIGNMENT 6 ******************


            List<string> lastPart = new List<string> { "dog", "ant", "cat", "cat" };
                List<string> backup = new List<string> ();
                foreach (string l in lastPart)
                {
                    foreach (string temp in backup)
                    {
                        if (l == temp)
                        {
                            Console.WriteLine(temp + " Has appeared before");
                        }
                        else
                        {
                            Console.WriteLine(l + " Has not appeared before on the list");
                        }

                    }
                    backup.Add(l);
                } 
            }

        }
    }

