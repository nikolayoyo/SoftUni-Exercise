using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var listOfCards = new List<Car>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            listOfCards.Add(new Car(input[0],
                int.Parse(input[1]), int.Parse(input[2]),
                int.Parse(input[3]), input[4],
                double.Parse(input[5]), int.Parse(input[6]),
                double.Parse(input[7]), int.Parse(input[8]),
                double.Parse(input[9]), int.Parse(input[10]),
                double.Parse(input[11]), int.Parse(input[12])
                ));
        }

        var lookFor = Console.ReadLine();
        List<Car> customList;
        if (lookFor== "fragile")
        {
           customList = listOfCards.Where(c => c.Cargo.CargoType == lookFor).Where(c => c.Tires.Sum(t => t.Presure) < 4).ToList();
        }
        else
        {
            customList = listOfCards.Where(c => c.Cargo.CargoType == lookFor).Where(c => c.Engine.EnginePower>250).ToList();
        }

        foreach (var car in customList)
        {
            Console.WriteLine(car.Model);
        }
    }
}

