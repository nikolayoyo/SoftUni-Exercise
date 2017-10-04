using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

   public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance": this.cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "Show":
                this.cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
        }
    }

   public string Check(int id)
    {
        return this.cars[id].ToString().Trim();
    }

   public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual": this.races[id] = new CasualRace(length, route, prizePool);
                break;
            case "Drag":
                this.races[id] = new DragRace(length, route, prizePool);
                break;
            case "Drift":
                this.races[id] = new DriftRace(length, route, prizePool);
                break;
            default:
                break;
        }
    }

    public void Open(int id, string type, int length, string route, int prizePool, int leghtOrTime)
    {
        switch (type)
        {
            case "Circuit":
                this.races[id] = new CircuitRace(length, route, prizePool,leghtOrTime);
                break;
            case "TimeLimit":
                this.races[id] = new TimeLimitRace(length, route, prizePool, leghtOrTime);
                break;
            default:
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (this.garage.ParkedCars.Contains(carId))
        {
            return;
        }

        this.races[raceId].AddParticipant(this.cars[carId]);
    }

   public string Start(int id)
    {
        if (this.races[id].IsEmpty())
        {
            return "Cannot start the race with zero participants.";
        }

        var winners = this.races[id].StartRace();
        this.races.Remove(id);

        return string.Join(Environment.NewLine, winners.Select(w=> w.Trim())).Trim();
    }

   public void Park(int id)
    {
        if (this.races.Any(r=> r.Value.Participants.Contains(this.cars[id])))
        {
            return;
        }

        this.garage.ParkCar(id);
    }

   public void Unpark(int id)
    {
        this.garage.UnparkCar(id);
    }

   public void Tune(int tuneIndex, string addOn)
    {
        if (!this.garage.ParkedCars.Any())
        {
            return;
        }

        foreach (var parkedCarId in garage.ParkedCars)
        {
            cars[parkedCarId].Tune(tuneIndex, addOn);
        }
    }

}

