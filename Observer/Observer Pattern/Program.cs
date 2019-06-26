using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            var hexaObserver = new HexaObserver(subject);
            var octalObserver = new OctalObserver(subject);
            var binaryObserver = new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);

            Console.WriteLine("\nSecond state change: 10");
            subject.SetState(10);

            Console.ReadLine();
        }
    }
}
