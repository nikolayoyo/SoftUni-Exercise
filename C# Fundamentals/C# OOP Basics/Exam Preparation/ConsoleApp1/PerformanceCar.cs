using System;
using System.Collections.Generic;

public class PerformanceCar : Car
{
    private IList<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.addOns = new List<string>();
        this.horsepower = horsepower + horsepower * 50 / 100;
        this.suspension = suspension - suspension * 25 / 100;
    }



    public IReadOnlyList<string> AddOns
    {
        get => this.addOns as IReadOnlyList<string>;
    }

    public override int Horsepower { get => base.Horsepower ; set => base.Horsepower =value; }

    public override int Suspension { get => base.Suspension ; set => base.Suspension = value; }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine +"Add-ons: " + (addOns.Count > 0 ? (string.Join(", ", addOns)) : "None");
    }

    public override void Tune(int points, string addOn)
    {
        this.Horsepower += points;
        this.Suspension += points / 2;
        this.addOns.Add(addOn);
    }
}

