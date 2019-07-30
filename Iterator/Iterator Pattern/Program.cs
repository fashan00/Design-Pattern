using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");
            var arrayContainer = new ArrayContainer();
            Iterator iterArray = arrayContainer.CreateIterator();
            while (iterArray.HasNext())
            {
                string name = (string)iterArray.Next();
                Console.WriteLine("Name : " + name);
            }

            Console.WriteLine("\nList");
            var listContainer = new ListContainer();
            Iterator iterList = listContainer.CreateIterator();
            while (iterList.HasNext())
            {
                string name = (string)iterList.Next();
                Console.WriteLine("Name : " + name);
            }

            Console.ReadLine();
        }
    }
}
