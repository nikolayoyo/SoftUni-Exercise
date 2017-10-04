using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var myMatrix = new int[input[0]][];
            for (int i = 0; i < input[0]; i++)
            {
                myMatrix[i]= Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }

            var maxSumRow = 0;
            var maxSumCow = 0;
            var maxSum = int.MinValue;

            for (int i = 0; i < myMatrix.Length-1; i++)
            {
                for (int j = 0; j < myMatrix[i].Length-1; j++)
                {
                    var currentSum = myMatrix[i][j] + myMatrix[i][j + 1] + myMatrix[i + 1][j] + myMatrix[i + 1][j + 1];
                    if (currentSum>maxSum)
                    {
                        maxSumRow = i;
                        maxSumCow = j;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine($"{myMatrix[maxSumRow][maxSumCow]} {myMatrix[maxSumRow][maxSumCow + 1]}");
            Console.WriteLine($"{myMatrix[maxSumRow+1][maxSumCow]} {myMatrix[maxSumRow+1][maxSumCow + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
