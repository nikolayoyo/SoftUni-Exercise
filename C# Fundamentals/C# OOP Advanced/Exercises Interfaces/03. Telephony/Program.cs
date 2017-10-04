using System;

public class Program
{
    public  static void Main(string[] args)
    {
        var myPhone = new Smartphone();

        var numbers = Console.ReadLine().Split();

        foreach (var number in numbers)
        {
            Console.WriteLine(myPhone.Call(number));
        }

        var sites = Console.ReadLine().Split();
        foreach (var url in sites)
        {
            Console.WriteLine(myPhone.Browse(url));
        }
    }
}

