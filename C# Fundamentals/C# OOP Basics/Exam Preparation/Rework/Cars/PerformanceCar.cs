using System;
using System.Collections.Generic;
using System.Linq;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, year, (horsepower+ horsepower*50/100), acceleration, (suspension- suspension*25/100), durability)
    {
        this.addOns = new List<string>();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.addOns.Add(addOn);
        this.HorsePower += (tuneIndex);
        this.Suspension += (tuneIndex/2);
    }

    public override string ToString()
    {
        var original =  base.ToString()+Environment.NewLine + "Add-ons: ";
        if (this.addOns.Any())
        {
            original += string.Join(", ", addOns);
        }
        else
        {
            original += "None";
        }

        return original.Trim();
    }
}

