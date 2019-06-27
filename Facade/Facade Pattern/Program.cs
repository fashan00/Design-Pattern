using Facade_Pattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFacade shapeFacade = new ShapeFacade();
            shapeFacade.DrawAll();

            Console.ReadLine();
        }
    }
}
