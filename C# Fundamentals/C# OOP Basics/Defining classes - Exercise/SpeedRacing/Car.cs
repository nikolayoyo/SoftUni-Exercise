
class Car
{
    private string model;
    private double traveled = 0.0;
    private double consumption;
    private double fuel;

    public Car(string model,double fuel ,double consumption)
    {
        this.model = model;
        this.fuel = fuel;
        this.consumption = consumption;
    }

    public void Drive(double km)
    {
        if (km * consumption > fuel)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        fuel -= (km * consumption);
        traveled += km;
    }

    public double Fuel
    {
        get
        {
            return this.fuel;
        }
        set
        {
            this.fuel = value;
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public double Traveled
    {
        get
        {
            return this.traveled;
        }
        set
        {
            this.traveled = value;
        }
    }

    public double Consumption
    {
        get
        {
            return this.consumption;
        }
        set
        {
            this.consumption = value;
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuel:F2} {this.traveled}";
    }
}

