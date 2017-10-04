using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Chemistry
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mySet = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var item in input)
                {
                    mySet.Add(item);
                }
            }

            foreach (var item in mySet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
