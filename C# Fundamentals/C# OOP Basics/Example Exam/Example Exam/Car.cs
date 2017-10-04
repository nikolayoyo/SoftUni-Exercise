using System;

public class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int suspension;
    private int durability;
    private int acceleration;

    public Car(string brand, string model, int yearOfProduction, int horsepowers, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepowers;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }
    public int Acceleration
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }

    public virtual int Durability
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

    public virtual int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }

    public virtual string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public virtual string Brand
    {
        get { return this.brand; }
        set {this.brand = value; }
    }

    public override string ToString()
    {
        return $"{Environment.NewLine}{this.brand} {this.model} {this.yearOfProduction}" +
            $"{Environment.NewLine}{this.horsepower} HP, 100 m/h in {this.acceleration} s" +
            $"{Environment.NewLine}{this.suspension} Suspension force, {this.durability} Durability";
    }
}

