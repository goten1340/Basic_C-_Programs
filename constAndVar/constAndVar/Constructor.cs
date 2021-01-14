using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constAndVar
{
    class Constructor
    {
        
            public int id;
            public string name;

            public Constructor() : this(0, "")
            {
            }

            public Constructor(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public Constructor(int id) : this(id, "")
            {
            }

            public Constructor(string name) : this(0, name)
            {
            }
        
    }
}
