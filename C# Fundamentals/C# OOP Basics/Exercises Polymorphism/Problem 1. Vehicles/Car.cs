using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double litersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.LitersPerKm = litersPerKm +0.9;
    }

    public override void Drive(double distance)
    {
        if (this.FuelQuantity-(distance*LitersPerKm)<0)
        {
            throw new ArgumentException("Car needs refueling");
        }
        this.DistanceTraveled += distance;
        this.FuelQuantity -= (distance * this.LitersPerKm);
    }
}

