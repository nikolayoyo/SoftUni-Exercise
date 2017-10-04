using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lego_stuff
{
    class Program
    {
        static int[][] firstLego;
        static int[][] secondLego;
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            firstLego = new int[rows][];
            secondLego = new int[rows][];
            firstLego = ReadMatrix(rows, firstLego);
            secondLego = ReadMatrix(rows, secondLego);
            ReverseSecond();
            CheckIfMatch();
        }

        private static void CheckIfMatch()
        {
            var firstRowsElements = firstLego[0].Length + secondLego[0].Length;
            var doTheyFit = true;
            for (int i = 0; i < firstLego.Length; i++)
            {
                var currentSum = firstLego[i].Length + secondLego[i].Length;
                if (currentSum!=firstRowsElements)
                {
                    doTheyFit = false;  
                    break;
                }
            }

            if (doTheyFit)
            {
                printSucess();
            }
            else
            {
                PrintFail();
            }
        }

        private static void PrintFail()
        {
            var countOfElements = 0;
            for (int i = 0; i < firstLego.Length; i++)
            {
                countOfElements += firstLego[i].Length;
                countOfElements += secondLego[i].Length;
            }

            Console.WriteLine($"The total number of cells is: {countOfElements}");
        }

        private static void printSucess()
        {
            for (int i = 0; i < firstLego.Length; i++)
            {
                Console.WriteLine($"[{string.Join(", ", firstLego[i])}, {string.Join(", ", secondLego[i])}]");
            }
        }

        private static void ReverseSecond()
        {
            var newSecond = new int[secondLego.Length][];
            for (int i = 0; i < secondLego.Length; i++)
            {
                newSecond[i] = secondLego[i].Reverse().ToArray();
            }

            secondLego = newSecond;
        }

        public static int[][] ReadMatrix(int rows, int[][] lego)
        {
            for (int i = 0; i < rows; i++)
            {
                lego[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            return lego;
        }
    }
}
