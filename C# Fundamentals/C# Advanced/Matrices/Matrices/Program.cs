using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] myMatrix = new int[input[0]][];
            var sum = 0;
            for (int i = 0; i < input[0]; i++)
            {
                var nums = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                myMatrix[i] = nums;
                sum += nums.Sum();
            }
            Console.WriteLine(myMatrix.Length);
            Console.WriteLine(myMatrix[0].Length);
            Console.WriteLine(sum);
        }
    }
}
