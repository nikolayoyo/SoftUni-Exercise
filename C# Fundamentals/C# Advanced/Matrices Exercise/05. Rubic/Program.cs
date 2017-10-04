using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubic
{
    class Program
    {
        public static int[][] rubicCube;

        public static int[] sizeOfMatrix;

        static void Main(string[] args)
        {
             sizeOfMatrix = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            CreateMatrix();

            var commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Rotate(command);
            }

            Rearange();
        }

        private static void Rearange()
        {
            var counter = 1;
            for (int i = 0; i < rubicCube.Length; i++)
            {
                for (int j = 0; j < rubicCube[i].Length; j++)
                {
                    var mustBe = counter + j;
                    var currentElement = rubicCube[i][j];
                    if (mustBe==currentElement)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var positionOfMustBe = FindIndex(mustBe);
                        rubicCube[i][j] = mustBe;
                        rubicCube[positionOfMustBe[0]][positionOfMustBe[1]] = currentElement;
                        Console.WriteLine($"Swap ({i}, {j}) with ({positionOfMustBe[0]}, {positionOfMustBe[1]})");
                    }
                }
                counter = rubicCube[i][sizeOfMatrix[1] - 1]+1;
            }
        }

        private static int[] FindIndex(int mustBe)
        {
            var indexToReturn = new int[2];
            for (int i = 0; i < sizeOfMatrix[0]; i++)
            {
                indexToReturn[0] = i;
                indexToReturn[1] = Array.IndexOf(rubicCube[i], mustBe);
                if (indexToReturn[1]!=-1)
                {
                    break;
                }
            }

            return indexToReturn;

        }

        private static void Rotate(string[] command)
        {
            var indexOfRowOrColum = int.Parse(command[0]);
            var direction = command[1];
            var moves = int.Parse(command[2]);

            if (command[1] == "up")
            {
                MoveUp(indexOfRowOrColum,direction,moves);
            }
            else if (command[1] == "down")
            {
                MoveDown(indexOfRowOrColum, direction, moves);
            }
            else if (command[1] == "left")
            {
                MoveLeft(indexOfRowOrColum, direction, moves);
            }
            else if (command[1] == "right")
            {
                MoveRight(indexOfRowOrColum, direction, moves);
            }
        }

        private static void MoveRight(int indexOfRowOrColum, string direction, int moves)
        {
            var rotationQueue = new Queue<int>();
            for (int i = sizeOfMatrix[1] - 1; i >= 0; i--)
            {
                rotationQueue.Enqueue(rubicCube[indexOfRowOrColum][i]);
            }

            for (int i = 0; i < moves; i++)
            {
                var dequeued = rotationQueue.Dequeue();
                rotationQueue.Enqueue(dequeued);
            }

            for (int i = sizeOfMatrix[1] - 1; i >= 0; i--)
            {
                rubicCube[indexOfRowOrColum][i] = rotationQueue.Dequeue();
            }
        }

        private static void MoveLeft(int indexOfRow, string direction, int moves)
        {
            var rotationQueue = new Queue<int>();
            foreach (var item in rubicCube[indexOfRow])
            {
                rotationQueue.Enqueue(item);
            }

            for (int i = 0; i < moves; i++)
            {
                var dequeued = rotationQueue.Dequeue();
                rotationQueue.Enqueue(dequeued);
            }

            for (int i = 0; i < sizeOfMatrix[1]; i++)
            {
                rubicCube[indexOfRow][i] = rotationQueue.Dequeue();
            }
        }

        private static void MoveDown(int indexOfColum, string direction, int moves)
        {
            var rotationQueue = new Queue<int>();
            for (int i = rubicCube.Length - 1; i >= 0; i--)
            {
                rotationQueue.Enqueue(rubicCube[i][indexOfColum]);
            }

            for (int i = 0; i < moves; i++)
            {
                var dequeued = rotationQueue.Dequeue();
                rotationQueue.Enqueue(dequeued);
            }

            for (int i = rubicCube.Length - 1; i >= 0; i--)
            {
                rubicCube[i][indexOfColum] = rotationQueue.Dequeue();
            }

        }

        private static void MoveUp(int indexOfColum, string direction, int moves)
        {
            var rotationQueue = new Queue<int>();
            foreach (var line in rubicCube)
            {
                rotationQueue.Enqueue(line[indexOfColum]);
            }

            for (int i = 0; i < moves; i++)
            {
                var dequeued = rotationQueue.Dequeue();
                rotationQueue.Enqueue(dequeued);
            }

            for (int i = 0; i < rubicCube.Length; i++)
            {
                rubicCube[i][indexOfColum] = rotationQueue.Dequeue();
            }
        }

        static void CreateMatrix()
        {
             rubicCube = new int[sizeOfMatrix[0]][];
            int counter = 1;
            for (int i = 0; i < sizeOfMatrix[0]; i++)
            {
                rubicCube[i] = new int[sizeOfMatrix[1]];

                for (int j = 0; j < sizeOfMatrix[1]; j++)
                {
                    rubicCube[i][j] = counter + j;
                }

                counter = rubicCube[i][sizeOfMatrix[1] - 1] + 1;
            }
        }
    }
}
