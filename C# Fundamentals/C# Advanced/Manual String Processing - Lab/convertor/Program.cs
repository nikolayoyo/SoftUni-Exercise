using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().ToLower();
            var lookFor = Console.ReadLine();
            var regexDidIt = Regex.Matches(inputText, lookFor);
            Console.WriteLine(regexDidIt.Count);
        }
    }
}
