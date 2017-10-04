using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Unit_Test
{
    public class Person
    {
        private readonly long id;
        private readonly string name;

        public Person(long id, string name)
        {
            this.id = id;
            this.name = name;   
        }

        public string Name
        {
            get { return this.name; }
        }

        public long Id
        {
            get { return this.id; }
        }

    }
}
