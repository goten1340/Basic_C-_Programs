using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("What is your age?");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 1)
                {
                    throw new FormatException(); 
                }
                int now = DateTime.Now.Year;
                int birthYear = now - Age;
                //DateTime displayBirthYear = now.AddYears(-Age);


                Console.WriteLine(birthYear);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot enter a zero or negative number.");
                Console.ReadLine();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry there was an error in your input.");
                Console.ReadLine();
                
            }
            
        }
        
    }   
}
