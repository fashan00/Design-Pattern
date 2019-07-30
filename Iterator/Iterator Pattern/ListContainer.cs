using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ListContainer : IContainer
    {
        public List<string> names = new List<string>{ "Robert", "John", "Julie", "Lora" };

        public Iterator CreateIterator()
        {
            return new ListIterator(names);
        }
    }
}
