using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var listOfSons = new List<Song>();
        var n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            try
            {
                var tokens = Console.ReadLine().Split(';');
                var name = tokens[0];
                var title = tokens[1];
                var duration = tokens[2].Split(':').Select(int.Parse).ToArray();
                if (duration.Length != 2)
                {
                    throw new Exception("Invalid song.");
                }
                
                listOfSons.Add(new Song(name, title, duration));
                Console.WriteLine("Song added.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        Console.WriteLine("Songs added: " + listOfSons.Count);
        Console.WriteLine("Playlist length: " + SumLengh(listOfSons));
    }

    private static string SumLengh(ICollection<Song> songs)
    {
        var sum = 0;
        foreach (var song in songs)
        {
            sum += song.Durantion[1];
            sum += song.Durantion[0] * 60;
        }

        var hours = sum / 3600;
        sum %= 3600;
        var mins = sum / 60;
        sum %= 60;
        var secs = sum % 60;

        return $"{hours}h {mins}m {secs}s";
    }
}

