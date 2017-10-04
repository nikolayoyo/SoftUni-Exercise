using System.Collections.Generic;

public class Garage
{
    private List<int> carsParked;

    public Garage()
    {
        this.carsParked = new List<int>();
    }

    public IReadOnlyList<int> CarsParked
    {
        get { return this.carsParked as IReadOnlyList<int>; }
    }

    public void ParkCar(int carId)
    {
        carsParked.Add(carId);
    }

    public void UnparkCar(int carId)
    {
        carsParked.Remove(carId);
    }
}

