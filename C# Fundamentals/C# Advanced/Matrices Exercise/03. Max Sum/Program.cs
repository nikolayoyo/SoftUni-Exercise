using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Max_Sum
{
    class Program
    {
        public static int[][] myMatrix;

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
             myMatrix = new int[input[0]][];
            for (int i = 0; i < input[0]; i++)
            {
                myMatrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSum = long.MinValue;
            var bestPosition = new int[2];
            for (int i = 0; i < myMatrix.Length-2; i++)
            {
                for (int j = 0; j < myMatrix[i].Length-2; j++)
                {
                    var currentSum = SumIt(i, j);
                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                        bestPosition[0] = i;
                        bestPosition[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            PrintIt(bestPosition);
        }

        public static void PrintIt(int[] indexes)
        {
            for (int k =indexes[0]; k <= indexes[0] + 2; k++)
            {
                for (int w = indexes[1]; w <= indexes [1]+ 2; w++)
                {
                    Console.Write($"{myMatrix[k][w]} ");
                }
                Console.WriteLine();
            }
        }

        public static long SumIt(int i, int j)
        {
            long sum = 0;
            for (int k = i; k <= i+2; k++)
            {
                for (int w = j; w <= j+2; w++)
                {
                    sum += myMatrix[k][w];
                }
            }

            return sum;
        }
    }
}
