using System;
using System.Collections.Generic;
using System.Linq;

namespace Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ',' }).Select(s => s.Trim()).ToList();
            var singersList = new Dictionary<string, List<string>>();
            foreach (var item in names)
            {
                singersList[item] = new List<string>();
            }

            var songs = Console.ReadLine().Split(new[] { ',' }).Select(s => s.Trim()).ToList();
            for (;;)
            {
                var input = Console.ReadLine().Split(new[] { ',' }).Select(s => s.Trim()).ToList();
                if (input[0] == "dawn")
                {
                    break;
                }

                if (singersList.ContainsKey(input[0]) && songs.Contains(input[1]))
                {
                    if (!singersList[input[0]].Contains(input[2]))
                    {
                        singersList[input[0]].Add(input[2]);
                    }

                }
            }

            if (singersList.Any(x => x.Value.Count > 0))
            {
                foreach (var singer in singersList.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
                {
                    if (singer.Value.Count != 0)
                    {
                        Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                        foreach (var song in singer.Value.OrderBy(s => s))
                        {
                            Console.WriteLine($"--{song}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
