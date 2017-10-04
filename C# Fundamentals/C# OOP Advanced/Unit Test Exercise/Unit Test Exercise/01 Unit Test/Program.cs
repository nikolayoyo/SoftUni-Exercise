using System;

namespace _01_Unit_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new Database(new Person[0]);
            db.Add(new Person(1, null));
        }
    }
}
