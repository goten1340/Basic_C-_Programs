using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> divideNumber = new List<int> { 70, 50, 2, 31 };

            Console.WriteLine("Please select a number to divide all the numbers in the list");
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                foreach (int number in divideNumber)
                {
                    Console.WriteLine(number / select);
                }
            }
         
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cant divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid format");
            }
            catch (SystemException ex)
            {
                Console.WriteLine("invalid input" );
            }
        }   
    }
}
