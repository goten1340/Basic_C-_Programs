using System;
using System.IO;
namespace DateandTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Time = DateTime.Now;
            Console.WriteLine(Time);
            Console.WriteLine("Please input a number");
            int Date = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = Time.AddHours(Date);
            Console.WriteLine(futureTime);
        }
    }
}
