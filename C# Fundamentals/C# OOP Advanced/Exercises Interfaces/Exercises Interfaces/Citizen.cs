using System;

public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public Citizen(string name, int age,string id, string birthdate)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.birthdate = birthdate;
    }
    public string Name => this.name;

    public int Age => this.age;

    public string Id => this.id;

    public string Birthdate => this.birthdate;
}

