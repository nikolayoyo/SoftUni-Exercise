using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var myMatrix = new string[input[0]][];
            for (int i = 0; i < myMatrix.Length; i++)
            {
                var firstChar = (char)('a' + i);
                var currentLine = new string[input[1]];
                for (int j = 0; j < input[1]; j++)
                {
                    var currentChar =(char)(firstChar + j);
                    var currentPal = $"{firstChar}{currentChar}{firstChar}";
                    currentLine[j] = currentPal;
                }

                myMatrix[i] = currentLine;
            }

            foreach (var line in myMatrix)
            {
                Console.WriteLine(string.Join(" ",line));
            }
        }
    }
}
