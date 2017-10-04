using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Target_Practice
{
    class Program
    {
        static char[][] myMatrix;
        static int[] matrixSizes;
        static void Main(string[] args)
        {
            CreateMatrix();
            ShotFired();
            Recursion();
            PrintField();
        }

        private static void PrintField()
        {
            foreach (var line in myMatrix)
            {
                Console.WriteLine(string.Join("", line));
            }
        }

        private static void CreateMatrix()
        {
            matrixSizes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            myMatrix = new char[matrixSizes[0]][];
            var matrixLength = matrixSizes[0] * matrixSizes[1];
            var filler = new StringBuilder();
            var wordToFill = Console.ReadLine();
            while (filler.Length < matrixLength)
            {
                filler.Append(wordToFill);
            }

            var stack = new Queue<char>(filler.ToString().ToCharArray());
            var oddEvenLine = 1;

            for (int i = myMatrix.Length - 1; i >= 0; i--)
            {
                myMatrix[i] = new char[matrixSizes[1]];

                if (oddEvenLine%2==1)
                {
                    for (int j = myMatrix[i].Length - 1; j >= 0; j--)
                    {
                        myMatrix[i][j] = stack.Dequeue(); 
                    }
                }
                else
                {
                    for (int j = 0; j < myMatrix[i].Length; j++)
                    {
                        myMatrix[i][j] = stack.Dequeue();
                    }
                }
                oddEvenLine++;
            }
        }

        private static void ShotFired()
        {
            var shotDimension = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var row = shotDimension[0];
            var cow = shotDimension[1];
            var range = shotDimension[2];
            var hitCells = new HashSet<int[]>();
            var counter = 0;
            for (int i = row-range; i <= row; i++)
            {
                for (int j = cow - counter; j <= cow+counter; j++)
                {
                    var currentCell = new int[2] { i, j };
                    if (IsValidCell(currentCell))
                    {
                        myMatrix[currentCell[0]][currentCell[1]] = ' ';
                    }
                }

                counter++;
            }

            counter-=2;
            for (int i = row+1 ; i <= row+range; i++)
            {
                for (int j = cow - counter; j <= cow + counter; j++)
                {
                    var currentCell = new int[2] { i, j };
                    if (IsValidCell(currentCell))
                    {
                        myMatrix[currentCell[0]][currentCell[1]] = ' ';
                    }
                }

                counter--;
            }


        }

        private static void Recursion()
        {
            for (int i = 0; i < myMatrix.Length; i++)
            {
                for (int j = 0; j < myMatrix[i].Length; j++)
                {
                    DragDown(i, j);
                }
            }
        }

        private static void DragDown(int row, int col)
        {
            while (LowerCellIsEmptyOrValid(row + 1, col))
            {
                for (int currentRow = row + 1; currentRow >= 1; currentRow--)
                {
                    myMatrix[currentRow][col] = myMatrix[currentRow - 1][col];
                }

                myMatrix[0][col] = ' ';
                row++;
            }
        }

        private static bool LowerCellIsEmptyOrValid(int p, int col)
        {
            if (p>=0 && p<myMatrix.Length && col>=0 && col<myMatrix[0].Length)
            {
                if (myMatrix[p][col] ==' ')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidCell(int[] cell)
        {
            if (cell[0]<0 || cell[0]>=matrixSizes[0] || cell[1]<0 || cell[1]>=matrixSizes[1])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
