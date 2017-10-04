using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var cars = new Dictionary<string, Car>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            cars[tokens[0]]= new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));
        }

        string input;
        while ((input= Console.ReadLine())!="End")
        {
            var tokens = input.Split();
            cars[tokens[1]].Drive(double.Parse(tokens[2]));
        }

        foreach (var kvp in cars)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}