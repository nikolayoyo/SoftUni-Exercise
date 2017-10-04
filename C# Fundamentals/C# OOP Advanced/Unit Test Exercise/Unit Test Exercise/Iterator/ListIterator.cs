using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListIterator
    {
        private IList<string> collection;
        private int index;

        public ListIterator(IList<string> collection)
        {
            if (collection==null)
            {
                throw new ArgumentNullException();
            }

            this.collection = collection;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index+1>=this.collection.Count)
            {
                return false;
            }

            this.index++;
            return true;
        }

        public bool HasNext()
        {
            if (this.index + 1 >= this.collection.Count)
            {
                return false;
            }
            
            return true;
        }

        public string Print()
        {
            if (this.collection.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.collection[index];
        }
    }
}
