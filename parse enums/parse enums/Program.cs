using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_enums
{
    class Program
    {
        
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wedsnesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
            
        }
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Please enter the current day of week");
                string day = Console.ReadLine();
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine(days);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                
            }
            Console.ReadLine();
        }
    }
}
