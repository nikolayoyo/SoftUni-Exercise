using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLotDimension = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var myField = new int[parkingLotDimension[0]][];
            for (int i = 0; i < parkingLotDimension[0]; i++)
            {
                myField[i] = new int[parkingLotDimension[1]];
            }
            var input = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            while (input[0]!="stop")
            {
                var entryPoint = int.Parse(input[0]);
                var seekedRow = int.Parse(input[1]);
                var seekedCol = int.Parse(input[2]);
                var initialMove = 1 + Math.Abs(entryPoint - seekedRow) + seekedCol;
                if (myField[seekedRow][seekedCol] ==0)
                {
                    myField[seekedRow][seekedCol] = 1;
                    Console.WriteLine(initialMove);
                }
                else
                {
                    if (myField[seekedRow].Where(x=> x!=1).ToArray().Length>1)
                    {
                        var closestMovesMinus = 0;
                        var closestColMinus = 0;
                        var closesetMovesPlus = 0;
                        var closestColPlus = 0;
                        for (int i = seekedCol-1; i >= 1; i--)
                        {
                            closestMovesMinus++;
                            if (myField[seekedRow][i]!=1)
                            {
                                closestColMinus = i;
                                break;
                            }
                        }

                        for (int i = seekedCol+1; i < myField[seekedRow].Length; i++)
                        {
                            closesetMovesPlus++;
                            if (myField[seekedRow][i]!=1)
                            {
                                closestColPlus = i;
                                break;
                            }
                        }
                        if (closestColMinus==0)
                        {
                            initialMove = 1 + Math.Abs(entryPoint - seekedRow) + closestColMinus;
                            myField[seekedRow][closestColPlus] = 1;
                        }
                        else if (closestColPlus==0)
                        {
                            initialMove = 1 + Math.Abs(entryPoint - seekedRow) + closestColMinus;
                            myField[seekedRow][closestColMinus] = 1;
                        }
                        else if (closesetMovesPlus>=closestMovesMinus)
                        {

                            initialMove = 1 + Math.Abs(entryPoint - seekedRow) + closestColMinus;
                            myField[seekedRow][closestColMinus] = 1;
                        }
                        else
                        {
                            initialMove = 1 + Math.Abs(entryPoint - seekedRow) + closestColMinus;
                            myField[seekedRow][closestColPlus] = 1;

                        }

                        Console.WriteLine(initialMove);
                    }
                    else
                    {
                        Console.WriteLine($"Row {seekedRow} full");
                    }
                }

                input = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }
        }
    }
}
