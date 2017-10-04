using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal //1 2 3 4 5 6//
{   
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var myMatrix = new int[input][];
            var firstIndex = 0;
            var secondIndex = input - 1;
            long primeDiag = 0;
            long scndDiag = 0;
            for (int i = 0; i < input; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                myMatrix[i] = inputLine;
                primeDiag += inputLine[firstIndex + i];
                scndDiag += inputLine[secondIndex - i];
            }

            Console.WriteLine(Math.Abs(primeDiag-scndDiag));
        }
    }
}
