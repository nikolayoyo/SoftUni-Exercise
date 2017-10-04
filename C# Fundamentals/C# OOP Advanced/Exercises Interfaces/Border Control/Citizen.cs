using System;

public class Citizen : IIdiable
{
    private string id;
    private string name;
    private int age;

    public Citizen(string name, int age, string id)
    {
        this.id = id;
        this.age = age;
        this.name = name;
    }
    public string Id => this.id;
}

