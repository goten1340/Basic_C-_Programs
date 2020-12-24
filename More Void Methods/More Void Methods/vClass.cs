using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Void_Methods
{
    class vClass
    {
        public void division(int h)
        {
            Console.WriteLine("Input a number to be divided by 2");
            Console.WriteLine(h / 2);
        }
        static public void division(out float g, out float f)
        {
            g = 50.5f;
            f = 34.5f;
            g += f;
            

            //float secondMethod = 6 - g;
            //return secondMethod;
        }
    }
}
