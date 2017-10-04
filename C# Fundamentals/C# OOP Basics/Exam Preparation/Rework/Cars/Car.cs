using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int year, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = year;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public string Brand { get => this.brand; }

    public string Model { get => this.model; }

    public int YearOfProduction { get => this.yearOfProduction; }

    public int Durability { get => this.durability; }

    public int Acceleration { get => this.acceleration; }

    public int HorsePower { get=> this.horsepower; set => this.horsepower= value; }

    public int Suspension { get=> this.suspension; set=> this.suspension = value; }

    public abstract void Tune(int tuneIndex, string addOn);

    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        result.AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s");
        result.AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

        return result.ToString().Trim();
    }

    public void DecreaseDurability(int laps, int lenght)
    {
        this.durability -= (laps * (lenght * lenght));
    }
}

