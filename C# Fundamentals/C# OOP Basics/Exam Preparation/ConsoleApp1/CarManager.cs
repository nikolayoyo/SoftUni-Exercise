using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int ,Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race> ();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance": this.cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;

            default: this.cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
        }
    }

    public string Check(int id)
    {
        return this.cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual": this.races[id] = new CasualRace(length, route, prizePool);
                break;
            case "Drag": this.races[id] = new DragRace(length, route, prizePool);
                break;
            case "Drift": this.races[id] = new DriftRace(length, route, prizePool);
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (this.garage.CarsParked.Contains(carId))
        {
            return;
        }

        this.races[raceId].Participate(carId, this.cars[carId]);
    }

    public string Start(int id)
    {
        if (this.races[id].Participants.Count ==0)
        {
            return ("Cannot start the race with zero participants.");
        }

        var builder = new StringBuilder();
        var counter = 1; 

        var winners = this.races[id].PerformancePoints();
        builder.AppendLine($"{this.races[id].Route} - {this.races[id].Length}");
        foreach (var winner in winners)
        {
            var winnerCar = this.cars[winner.Key];
            var currentLine = ($"{counter}. {winnerCar.Brand} {winnerCar.Model} {winner.Value}PP - $");
            if (counter ==1)
            {
                currentLine+=(this.races[id].PrizePool *50/100);
            }
            else if (counter ==2)
            {
                currentLine += (this.races[id].PrizePool * 30/100);
            }
            else if (counter ==3)
            {
                currentLine += (this.races[id].PrizePool * 20/100);
            }

            builder.AppendLine(currentLine);
            counter++;
            if (counter==4 || winners.Count == counter-1)
            {
                break;
            }
        }

        this.races.Remove(id);
        return builder.ToString().Trim();
    }

    public void Park(int id)
    {
        if (this.races.Values.Any(c=> c.Participants.ContainsKey(id)))
        {
            return;
        }

        this.garage.ParkCar(id);
    }

    public  void Unpark(int id)
    {
        this.garage.UnparkCar(id);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.garage.CarsParked.Count ==0)
        {
            return;
        }

        foreach (var car in this.garage.CarsParked)
        {
            this.cars[car].Tune(tuneIndex, addOn);
        }
    }
}
