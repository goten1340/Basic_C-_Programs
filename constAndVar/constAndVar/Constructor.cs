using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constAndVar
{
    class Constructor
    {
        {
            private int id;
            private string name;

            public Prepare() : this(0, "")
            {
            }

            public Prepare(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public Prepare(int id) : this(id, "")
            {
            }

            public Prepare(string name) : this(0, name)
            {
            }
        }
    }
}
