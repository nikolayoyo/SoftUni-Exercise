using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());



        var myBox = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        Console.WriteLine($"Surface area - {myBox.Surface():F2}");
        Console.WriteLine($"Lateral Surface Area - {myBox.Lateral():F2}");
        Console.WriteLine($"Volume - {myBox.Volume():f2}");

    }
}

