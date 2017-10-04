using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.Trying_it
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var patternt = @"<a.*?href\s*=\s*""(\D +?)"".+?<\/a>";
                var matches = Regex.Match(input, patternt);
                Console.WriteLine(matches.Groups[0]);
                input = Console.ReadLine();
            }
        }
    }
}
