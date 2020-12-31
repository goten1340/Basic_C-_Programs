using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overload_assignment
{
    class Employee
    {
        public int id { get; set; }
        public static bool operator ==(Employee obj1, Employee obj2)
        {
            if (obj1.id == obj2.id)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee obj1, Employee obj2)
        {
            return (obj1.id != obj2.id);
        } 
        
    }
}
