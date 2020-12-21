using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class addEmUp
    {
        public int addemup(int c)
        {
            int results = c - 5;
            return results;
        }
        
        public int addemup(decimal f)
        {
            int results2 = Convert.ToInt32(f) - 4;
            return results2;
        }
        public int addemup(string j)
        {
            int results3 = Convert.ToInt32(j) - 4;
            return results3;
        }
    }
}
