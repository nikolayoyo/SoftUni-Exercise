using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Crossfire
{
    class Program
    {
        public static List<List<long>> myMatrix;
        static void Main(string[] args)
        {
            CreateAndFillMatrix();
            FiredShots();
            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            foreach (var line in myMatrix)
            {
                if (line[0]==-1)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", line));
                }
            }
        }

        private static void FiredShots()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0] != "Nuke")
            {
                var row = int.Parse(input[0]);
                var col = int.Parse(input[1]);
                var radius = int.Parse(input[2]);

                for (int i = col+radius; i >= col-radius; i--)
                {
                    if (ValidateCell(row,i))
                    {
                        if (myMatrix[row].Count!=1)
                        {
                            myMatrix[row].RemoveAt(i);
                        }
                        else
                        {
                            myMatrix[row][i] = -1;
                        }
                    }
                }

                for (int i = row-radius; i <= row+radius; i++)
                {
                    if (ValidateCell(i,col))
                    {
                        if (myMatrix[i].Count!=1)
                        {
                            myMatrix[i].RemoveAt(col);
                        }
                        else
                        {
                            myMatrix[i][col] = -1;
                        }
                    }
                }
                input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }

        private static void CreateAndFillMatrix()
        {
            var matrixDimension = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            long counter = 1;
            myMatrix = new List<List<long>>();
            for (int i = 0; i < matrixDimension[0]; i++)
            {
                var currentLit = new List<long>();
                for (int j = 0; j < matrixDimension[1]; j++)
                {
                    currentLit.Add(j + counter);
                }
                myMatrix.Add(currentLit);
                counter = myMatrix[i][matrixDimension[1] - 1] + 1;
            }
        }

        static bool ValidateCell(int i, int j)
        {
            if (i>=0 && i<myMatrix.Count)
            {
                if (j>=0 && j< myMatrix[i].Count)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
