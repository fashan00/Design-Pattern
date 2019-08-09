using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Manager : Employee
    {
        public Manager(string name, string dept, int sal) : base(name, dept, sal)
        {
            
        }

        public override void Add(Employee employee)
        {
            subordinates.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            subordinates.Remove(employee);
        }

        public override Employee GetChild(int i)
        {
            return subordinates[i];
        }

        public override void Print()
        {
            base.Print();

            foreach (Employee employee in GetSubordinates())
            {
                employee?.Print();
            }
        }

    }
}
