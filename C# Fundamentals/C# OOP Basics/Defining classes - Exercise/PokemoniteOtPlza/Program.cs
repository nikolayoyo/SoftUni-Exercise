using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var listOfTrainers = new List<Trainer>();
        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!listOfTrainers.Any(t => t.Name == tokens[0]))
            {
                listOfTrainers.Add(new Trainer(tokens[0]));
            }

            listOfTrainers.First(t => t.Name == tokens[0]).Pokemos.Add(new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3])));
        }

        while ((input = Console.ReadLine()) != "End")
        {
            for (int i = 0; i < listOfTrainers.Count; i++)
            {
                var currentTrainer = listOfTrainers[i];
                if (currentTrainer.Pokemos.Any(p=> p.Element== input))
                {
                    currentTrainer.NumberOfBadges++;
                }
                else
                {
                    for (int j = 0; j < currentTrainer.Pokemos.Count; j++)
                    {
                        currentTrainer.Pokemos[j].Health -= 10;
                    }

                    currentTrainer.Pokemos.RemoveAll(p => p.Health <= 0);
                }
            }
        }

        foreach (var trainer in listOfTrainers.OrderByDescending(t=>t.NumberOfBadges))
        {
            Console.WriteLine(trainer);
        }
    }
}

