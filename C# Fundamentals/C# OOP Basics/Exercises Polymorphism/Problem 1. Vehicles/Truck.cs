using System;

public class Truck:Vehicle
{
    public Truck(double fuelQuantity, double literPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = literPerKm + 1.6;
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity - (distance * LitersPerKm) < 0)
        {
            throw new ArgumentException("Truck needs refueling");
        }
        this.DistanceTraveled += distance;
        this.FuelQuantity -= (distance * this.LitersPerKm);
    }

    public override void Refuel(double fuel)
    {
        fuel *= 0.95;
        base.Refuel(fuel);
    }
}

