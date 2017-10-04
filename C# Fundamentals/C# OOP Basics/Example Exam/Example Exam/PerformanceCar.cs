using System;
using System.Collections.Generic;

public class PerformanceCar: Car
{
    

    private IList<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepowers, int acceleration, int suspension, int durability)
        :base(brand, model,yearOfProduction, horsepowers, acceleration, suspension, durability)
    {
        this.addOns = new List<string>();
    }

    public IReadOnlyCollection<string> AddOns
    {
       get { return this.addOns as IReadOnlyCollection<string>; }
    }

    public void AddAddOn(string addOn)
    {
        this.addOns.Add(addOn);
    }

    public override int Horsepower
    {
        get => base.Horsepower; set =>
         base.Horsepower = (int)(value * 1.5);
    }

    public override int Suspension
    {
        get => base.Suspension;
        set => base.Suspension = (int)(value*0.75);
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Add-ons: {string.Join(", ", addOns)}";
    }
}

