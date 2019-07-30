using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ArrayContainer : IContainer
    {
        public string[] names = { "Robert", "John", "Julie", "Lora" };

        public Iterator CreateIterator()
        {
            return new ArrayIterator(names);
        }
    }
}
