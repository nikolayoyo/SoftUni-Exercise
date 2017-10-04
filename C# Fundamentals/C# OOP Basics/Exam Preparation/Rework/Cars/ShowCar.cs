using System;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, year, horsepower, acceleration, suspension, durability)
    {
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        this.HorsePower += tuneIndex;
        this.Suspension += tuneIndex /2;
        this.stars += tuneIndex;
    }

    public override string ToString()
    {
        return (base.ToString() + $"{Environment.NewLine}{this.stars} *").Trim();
    }
}

