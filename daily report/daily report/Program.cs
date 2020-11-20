using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"The Tech Academy\" \n \"student daily report\"");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int page = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool forHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
            string shareExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string hoursStudy = Console.ReadLine();
            byte studyHours = Convert.ToByte(hoursStudy);




        }
    }
}
