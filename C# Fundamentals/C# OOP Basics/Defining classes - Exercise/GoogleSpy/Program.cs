using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var listOtPersons = new List<Person>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!listOtPersons.Any(p=> p.Name == tokens[0]))
            {
                listOtPersons.Add(new Person(tokens[0]));
            }

            var currentPerson = listOtPersons.First(p => p.Name == tokens[0]);

            switch (tokens[1])
            {
                case "car": currentPerson.Car = new Car(tokens[2], int.Parse(tokens[3]));
                    break;
                case "parents": currentPerson.Parents.Add(new Parent(tokens[2], tokens[3]));
                    break;
                case "pokemon": currentPerson.Pokemons.Add(new Pokemon(tokens[2], tokens[3]));
                    break;
                case "company": currentPerson.Company = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));
                    break;
                case "children": currentPerson.Childrens.Add(new Parent(tokens[2], tokens[3]));
                    break;
                default:
                    break;
            }
        }

        var lookFor = Console.ReadLine();
        Console.WriteLine(listOtPersons.First(p=> p.Name==lookFor));
    }
}
