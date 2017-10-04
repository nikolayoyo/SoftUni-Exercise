using System.Collections.Generic;

public class Garage
{
    private List<int> parkedCars;

    public Garage()
    {
        this.parkedCars = new List<int>();
    }

    public IReadOnlyCollection<int> ParkedCars
    {
        get => this.parkedCars as IReadOnlyCollection<int>;
    }

    public void ParkCar(int id)
    {
        this.parkedCars.Add(id);
    }

    public void UnparkCar(int id)
    {
        this.parkedCars.Remove(id);
    }
}

