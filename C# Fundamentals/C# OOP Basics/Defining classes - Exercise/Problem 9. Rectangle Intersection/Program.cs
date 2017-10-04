using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var triangles = new Dictionary<string,Rectangle>();
        var initialInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
        for (int i = 0; i < initialInput[0]; i++)
        {
            var rawInput = Console.ReadLine().Split();
            triangles[rawInput[0]]= (new Rectangle(rawInput[0], double.Parse(rawInput[1]), double.Parse(rawInput[2]), double.Parse(rawInput[3]), double.Parse(rawInput[4])));
        }

        for (int i = 0; i < initialInput[1]; i++)
        {
            var rawInput = Console.ReadLine().Split();
            var firstOne = triangles[rawInput[0]];
            var secondOne = triangles[rawInput[1]];

            Console.WriteLine(firstOne.ComparedTo(secondOne).ToString().ToLower());
        }
    }
}