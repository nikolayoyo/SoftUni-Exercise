using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Rotation
{
    class Program
    {
        public static List<List<char>> myMatrix;
        public static int maxLength;
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            myMatrix = new List<List<char>>();
            var pattern = "[0-9]+";
            var rotation = int.Parse(Regex.Match(command, pattern).ToString())/90%4;
            var inputWord = Console.ReadLine();
             maxLength = 0;
            while (inputWord!="END")
            {
                myMatrix.Add(inputWord.ToCharArray().ToList());
                if (inputWord.Length > maxLength)
                {
                    maxLength = inputWord.Length;
                }
                inputWord = Console.ReadLine();
            }

            switch (rotation)
            {
                case 1:Ninety();
                    break;
                case 2: HundedEighty();
                    break;
                case 3:TwoHundrerd();
                    break;
                default:
                    JustPrint();
                    break;
            }
        }

        private static void JustPrint()
        {
            foreach (var item in myMatrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }

        private static void HundedEighty()
        {
            var reversedList = new List<string>();
            for (int i = 0; i < myMatrix.Count; i++)
            {
                var currentWord = new StringBuilder();
                currentWord.Append(string.Join("",myMatrix[i]));
                for (int j = 0; j < maxLength-myMatrix[i].Count; j++)
                {
                    currentWord.Append(" ");
                }
                reversedList.Add(ReverseString(currentWord.ToString()));
            }

            for (int i = reversedList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(reversedList[i]);
            }
        }

        private static void TwoHundrerd()
        {
            var rotatedList = new List<string>();
            var counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                var currentLine = new StringBuilder();
                foreach (var word in myMatrix)
                {
                    char currentChar;
                    if (i >= word.Count)
                    {
                        currentChar = ' ';
                    }
                    else
                    {
                        currentChar = word[i];
                    }

                    currentLine.Append(currentChar);
                }
                rotatedList.Add(currentLine.ToString());
            }

            for (int i = rotatedList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(rotatedList[i]);
            }
        }  

    public static void Ninety()
        {
            var rotatedList = new List<string>();
            var counter = 0;
            for (int i = 0; i < maxLength; i++)
            {
                var currentLine = new StringBuilder();
                foreach (var word in myMatrix)
                {
                    char currentChar;
                    if (i >= word.Count)
                    {
                        currentChar = ' ';
                    }
                    else
                    {
                        currentChar = word[i];
                    }

                    currentLine.Append(currentChar);
                }
                var rotatedString = currentLine.ToString();
                rotatedList.Add(ReverseString(rotatedString));
            }

            foreach (var line in rotatedList)
            {
                Console.WriteLine(line);
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
