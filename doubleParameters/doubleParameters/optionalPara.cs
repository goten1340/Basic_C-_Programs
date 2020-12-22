using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleParameters
{
    class optionalPara
    {
        public int doublePara(int a, int b = 3)
        {
            int results = 5 - a - b;
            return results;

        }
        public int optionalSecondNumber(int s , int f = 4)
        {
            int results2 = 6 - s - f;
            return results2;
        }
    }
}
