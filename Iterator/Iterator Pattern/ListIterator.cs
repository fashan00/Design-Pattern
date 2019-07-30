using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ListIterator : Iterator
    {
        private readonly List<string> _names;
        private int index;

        public ListIterator(List<string> names)
        {
            _names = names;
        }

        public bool HasNext()
        {

            if (index < _names.Count)
            {
                return true;
            }
            return false;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                return _names[index++];
            }
            return null;
        }

    }
}
