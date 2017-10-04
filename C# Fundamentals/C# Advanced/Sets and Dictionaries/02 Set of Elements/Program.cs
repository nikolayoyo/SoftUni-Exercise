using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Set_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < nm[0]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }

            for (int i = 0; i < nm[1]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                secondSet.Add(input);
            }

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }
    }
}
