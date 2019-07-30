using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ArrayIterator : Iterator
    {
        private readonly string[] _names;
        private int index;

        public ArrayIterator(string[] names)
        {
            _names = names;
        }

        public bool HasNext()
        {

            if (index < _names.Length)
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
