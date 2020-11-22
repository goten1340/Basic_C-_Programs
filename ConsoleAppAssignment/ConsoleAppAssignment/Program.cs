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
            int fall = Convert.ToInt32(Console.ReadLine());
            int wow = fall * 50;
            Console.Write(wow);
            Console.ReadLine();

            int call = Convert.ToInt32(Console.ReadLine());
            int see = call + 25;
            Console.WriteLine(see);
            Console.ReadLine();

            
            
            decimal divide1 = Convert.ToDecimal(Console.ReadLine());
            decimal sunResult = divide1 / 12.5m;
            Console.WriteLine(sunResult);
            Console.ReadLine();

           
            int ready = Convert.ToInt32(Console.ReadLine());
            bool gif = ready > 50;
            Console.WriteLine(gif);
            Console.ReadLine();

            int foreal = Convert.ToInt32(Console.ReadLine());
            int go = foreal % 7;
            Console.WriteLine(go);
            Console.ReadLine();
            
        }
    }
}
