using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input;
        var citizensAndRobots = new List<IIdiable>();

        while ((input= Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            citizensAndRobots.Add(CitizenRobotFactory.Factory(tokens));
        }


        var bannedId = Console.ReadLine();
        foreach (var registered in citizensAndRobots)
        {
            var id = registered.Id;
            var lastSymbs = id.Substring(id.Length - 3);

            if (lastSymbs==bannedId)
            {
                Console.WriteLine(id);
            }
            
        }
    }
}


