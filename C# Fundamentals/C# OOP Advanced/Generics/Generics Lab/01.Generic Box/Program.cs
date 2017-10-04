using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var firstKvp = Console.ReadLine().Split();
        var firsTuple = new Tuple<string, string, string>($"{firstKvp[0]} {firstKvp[1]}", firstKvp[2], firstKvp[3]);

        var secondKvp = Console.ReadLine().Split();
        var secondTuple = new Tuple<string, int, bool>(secondKvp[0], int.Parse(secondKvp[1]), secondKvp[2]=="Drunk");

        var thirdKvp = Console.ReadLine().Split();
        var thirdTuple = new Tuple<string, double, string>(thirdKvp[0], double.Parse(thirdKvp[1]), thirdKvp[2]);

        Console.WriteLine(firsTuple);
        Console.WriteLine(secondTuple);
        Console.WriteLine(thirdTuple);

    }
}

