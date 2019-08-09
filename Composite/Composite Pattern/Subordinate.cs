using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Subordinate : Employee
    {
        public Subordinate(string name, string dept, int sal) : base(name, dept, sal)
        {
        }
    }
}
