using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
            var winningSyngs = new string[]
            {
                "@",
                "\\$",
                "\\^",
                "#"
            };

            foreach (var ticket in input)
            {
                bool foundMatch = false;
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var left = string.Join("", ticket.Take(10));
                    var right = string.Join("", ticket.Skip(10));
                    foreach (var symbol in winningSyngs)
                    {
                        var leftMatch = Regex.Match(left, $"{symbol}{{6,}}");
                        if (leftMatch.Success)
                        {
                            var rightMatch = Regex.Match(right, $"{symbol}{{6,}}");
                            if (rightMatch.Success)
                            {
                                var lenghtOfWin = Math.Min(rightMatch.Value.Length, leftMatch.Value.Length);
                                foundMatch = true;
                                if (lenghtOfWin == 10)
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {lenghtOfWin}{symbol.Trim('\\')} Jackpot!");
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {lenghtOfWin}{symbol.Trim('\\')}");
                                }
                                break;
                            }

                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!foundMatch)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
