using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2x2_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var myMatix = new char[input[0]][];
            for (int i = 0; i < input[0]; i++)
            {
                myMatix[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            var counter = 0;
            for (int i = 0; i < myMatix.Length-1; i++)
            {
                for (int j = 0; j < myMatix[i].Length-1; j++)
                {
                    var topLeft = myMatix[i][j];
                    var topRight = myMatix[i][j + 1];
                    var botLeft = myMatix[i + 1][j];
                    var botRight = myMatix[i + 1][j + 1];
                    if (topLeft==topRight && topRight==botLeft && botLeft ==botRight)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
