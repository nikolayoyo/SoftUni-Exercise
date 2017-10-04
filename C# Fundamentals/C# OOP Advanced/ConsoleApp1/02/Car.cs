using System;

public abstract class Vehicle : ICar
{
    private string color;
    private string model;

    public Vehicle(string model, string color)
    {
        this.color = color;
        this.model = model;
    }

    public string Color => this.color;

    public string Model => this.model;

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.color} {this.GetType()} {this.model}";
    }
}
