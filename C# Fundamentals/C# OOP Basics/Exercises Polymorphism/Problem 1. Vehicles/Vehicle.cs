public abstract class Vehicle
{
    private double fuelQuantity;
    private double literPerKm;
    private double distanceTraveled;

    public double DistanceTraveled { get => this.distanceTraveled; protected set => this.distanceTraveled += value; }

    public double LitersPerKm
    {
        get { return this.literPerKm; }
        set { this.literPerKm = value; }
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public abstract void Drive(double distance);
   

    public virtual void Refuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }
}

