using System;
using System.Linq;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            if (lenght >= 0)
            {


                var field = new int[lenght];
                var indexesOfBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                foreach (var item in indexesOfBugs)
                {
                    if (item >= 0 && item < field.Length)
                    {
                        field[item] = 1;
                    }
                }
                for (;;)

                {
                    var input = Console.ReadLine().Split(' ').ToList();
                    if (input[0] == "end")
                    {
                        break;
                    }
                    var indexOfBug = long.Parse(input[0]);
                    var direction = input[1];
                    var moveWith = long.Parse(input[2]);
                    if (direction == "right")
                    {
                        if (indexOfBug >= 0 && indexOfBug < field.Length)
                        {


                            if (field[indexOfBug] == 1)
                            {
                                var positionsToMove = indexOfBug + moveWith;
                                field[indexOfBug] = 0;
                                if (positionsToMove >= 0 && positionsToMove < field.Length)
                                {
                                    if (field[positionsToMove] == 0)
                                    {
                                        field[positionsToMove] = 1;
                                    }
                                    else if (field[positionsToMove] != 0)
                                    {
                                        while (positionsToMove < field.Length && positionsToMove > 0)
                                        {
                                            if (field[positionsToMove] != 0)
                                            {
                                                positionsToMove += moveWith;

                                            }
                                            else
                                            {
                                                break;
                                            }

                                        }
                                        if (positionsToMove >= 0 && positionsToMove < field.Length)
                                        {
                                            field[positionsToMove] = 1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                    else if (direction == "left")
                    {
                        if (indexOfBug >= 0 && indexOfBug < field.Length)
                        {


                            if (field[indexOfBug] == 1)
                            {
                                var positionToMove = indexOfBug - moveWith;
                                field[indexOfBug] = 0;
                                if (positionToMove >= 0 && positionToMove < field.Length)
                                {
                                    if (field[positionToMove] == 0)
                                    {
                                        field[positionToMove] = 1;
                                    }
                                    else if (field[positionToMove] != 0)
                                    {
                                        while (field[positionToMove] != 0 || positionToMove >= 0 || positionToMove < field.Length)
                                        {
                                            positionToMove -= moveWith;
                                        }
                                        if (positionToMove >= 0 && positionToMove < field.Length)
                                        {
                                            field[positionToMove] = 1;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                Console.WriteLine(string.Join(" ", field));
            }
        }
    }
}