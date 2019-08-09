using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public abstract class Employee
    {
        protected List<Employee> subordinates = new List<Employee>();

        public virtual string Name { get; protected set; }
        public virtual string Dept { get; protected set; }
        public virtual int Salary { get; protected set; }

        public Employee(string name, string dept, int sal)
        {
            this.Name = name;
            this.Dept = dept;
            this.Salary = sal;
        }

        public virtual List<Employee> GetSubordinates()
        {
            return subordinates;
        }

        public virtual void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }
        public virtual Employee GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Employee :[ Name : {Name}, dept : {Dept}, salary :{Salary} ]");
            Console.WriteLine("---------------------");
        }
    }
}
