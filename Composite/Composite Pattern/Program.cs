using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO = new Manager("John", "CEO", 30000);

            Employee headSales = new Manager("Robert", "Head Sales", 20000);

            Employee headMarketing = new Manager("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Subordinate("Laura", "Marketing", 10000);
            Employee clerk2 = new Subordinate("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Subordinate("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Subordinate("Rob", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            CEO.Print();

            Console.ReadLine();
        }
    }
}
