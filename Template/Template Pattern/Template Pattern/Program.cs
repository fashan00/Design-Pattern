using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTemplate game = new Cricket();
            game.Play();
            Console.WriteLine();
            game = new Football();
            game.Play();

            Console.ReadLine();
        }
    }
}
