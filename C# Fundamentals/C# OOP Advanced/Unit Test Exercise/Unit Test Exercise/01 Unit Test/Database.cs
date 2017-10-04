using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Unit_Test
{
    public class Database
    {
        private const int MaxCapacity = 16;

        private Person[] storage;

        public Database(params Person[] initialInts)
        {
            this.storage= new Person[MaxCapacity];
            if (initialInts.Length>16)
            {
                throw new InvalidOperationException();
            }
            
            this.storage = initialInts;
        }

        public void Add(Person element)
        {
            if (this.storage.Length>=16)
            {
                throw new InvalidOperationException();
            }

            if (this.storage.Any(p=> p.Name == element.Name || p.Id == element.Id))
            {
                throw new InvalidOperationException();
            }

            var duplicate = this.storage;
            this.storage = new Person[this.storage.Length+1];

            for (int i = 0; i < duplicate.Length; i++)
            {
                storage[i] = duplicate[i];
            }

            this.storage[this.storage.Length - 1] = element;
        }

        public Person FindById(long id)
        {
            if (id<0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var wantedPerson = this.storage.FirstOrDefault(p => p.Id == id);
            if (wantedPerson == null)
            {
                throw  new InvalidOperationException();
            }

            return wantedPerson;
        }

        public Person FindByUsername(string name)
        {
            if (name==null)
            {
                throw new ArgumentNullException();
            }

            var wantedPerson = this.storage.FirstOrDefault(p => p.Name == name);
            if (wantedPerson==null)
            {
                throw  new InvalidOperationException();
            }

            return wantedPerson;
        }

        public void Remove()
        {
            if (this.storage.Length==0)
            {
                throw new InvalidOperationException();
            }
            var duplica = this.storage;
            this.storage = new Person[this.storage.Length-1];

            for (int i = 0; i < duplica.Length-1; i++)
            {
                this.storage[i] = duplica[i];
            }
        }

        public Person[] Fetch()
        {
            return this.storage;
        }
    }
}
