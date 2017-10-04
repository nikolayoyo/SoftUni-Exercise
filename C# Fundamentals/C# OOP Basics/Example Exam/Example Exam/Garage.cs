using System;
using System.Collections.Generic;

public class Garage
{
    private Dictionary<int,Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new Dictionary<int, Car>();
    }

    public IReadOnlyDictionary<int,Car> ParkedCars
    {
        get => this.parkedCars as IReadOnlyDictionary<int, Car>;
    }

    public void Park(int id,Car car)
    {
        this.parkedCars[id] = car;
    }

    internal void Unpark(int id)
    {
        this.parkedCars.Remove(id);
    }
}

