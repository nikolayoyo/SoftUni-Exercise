using System;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepowers, int acceleration, int suspension, int durability)
        :base(brand, model,yearOfProduction, horsepowers, acceleration, suspension, durability)
    {
    }
    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}{stars} *";
    }
}

