
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var engines = new List<Engine>();
        for (int i = 0; i < n; i++)
        {
            var tokes = Console.ReadLine().Split();
            if (tokes.Length==4)
            {
                engines.Add(new Engine(tokes[0],tokes[1], tokes[2], tokes[3]));
            }
            else if (tokes.Length==3)
            {
                engines.Add(new Engine(tokes[0], tokes[1], tokes[2]));
            }
            else
            {
                engines.Add(new Engine(tokes[0], tokes[1]));
            }
        }
        var cars = new List<Car>();
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var currentEngine = engines.First(e => e.Model == tokens[1]);
            if (tokens.Length ==4)
            {
                cars.Add(new Car(tokens[0], currentEngine, tokens[2], tokens[3]));
            }
            else if (tokens.Length ==3)
            {
                cars.Add(new Car(tokens[0], currentEngine,tokens[2]));
            }
            else
            {
                cars.Add(new Car(tokens[0], currentEngine));
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

