using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mySet = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                mySet.Add(Console.ReadLine());
            }

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
