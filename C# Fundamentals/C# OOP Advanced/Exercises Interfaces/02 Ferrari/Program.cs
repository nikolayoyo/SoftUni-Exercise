﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        var rari = new Ferrari(Console.ReadLine());

        Console.WriteLine(rari);
    }
}

