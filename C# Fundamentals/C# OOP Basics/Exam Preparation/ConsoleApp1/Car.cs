using System;
using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    protected int horsepower;
    protected int suspension;
    protected int durability;
    protected int acceleration;

    public int Acceleration
    {
        get { return acceleration; }
        set { acceleration = value; }
    }

    public abstract void Tune(int points, string addOn);

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.suspension = suspension;
        this.Dubrability = durability;
        this.acceleration = acceleration;
    }

    public int Dubrability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }

    public virtual int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }

    public virtual int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }

    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Brand
    {
        get { return this.brand; }
        set { this.brand = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s");
        sb.AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

        return sb.ToString().Trim();
    }
}

