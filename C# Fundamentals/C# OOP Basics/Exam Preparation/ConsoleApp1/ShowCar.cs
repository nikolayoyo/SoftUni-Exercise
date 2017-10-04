using System;

class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.stars = 0;
    }

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"{this.stars} *";
    }

    public override void Tune(int points, string addOn)
    {
        this.Horsepower += points;
        this.Suspension += points / 2;
        this.Stars += points;
    }
}

