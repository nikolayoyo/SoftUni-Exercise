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
            case "Performance":
                this.cars[id] = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "Show":
                 this.cars[id] = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            default:
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
            case "Casual":
                this.races[id] = new CasualRace(length, route, prizePool);
                break;
            case "Drift":
                this.races[id] = new DriftRace(length, route, prizePool);
                break;
            case "Drag":

                this.races[id] = new DragRace(length, route, prizePool);
                break;
            default: 
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        if (this.garage.ParkedCars.Count!=0 && this.garage.ParkedCars.ContainsKey(carId))
        {
            return;
        }

        this.races[raceId].AddCar(this.cars[carId]);
    }
    
    public string Start(int id)
    {
        if (this.races[id].Participants.Count==0)
        {
            return  "Cannot start the race with zero participants.";
        }

        var currentRace = this.races[id];
        System.Console.WriteLine($"{currentRace.Route} - {currentRace.Length}");
        IReadOnlyDictionary<Car, int> participants = currentRace.OverallPerformance();
        var counter = 1;
        foreach (var winner in participants.Take(3))
        {
            if (counter ==1)
            {
                System.Console.WriteLine($"{winner.Key.Brand} {winner.Key.Model} {winner.Value}PP - ${currentRace.PrizePool*0.5}");
            }
            else if (counter == 2)
            {
                System.Console.WriteLine($"{winner.Key.Brand} {winner.Key.Model} {winner.Value}PP - ${currentRace.PrizePool * 0.3}");
            }
            else if (counter==3)
            {
                System.Console.WriteLine($"{winner.Key.Brand} {winner.Key.Model} {winner.Value}PP - ${currentRace.PrizePool * 0.2}");
            }
            counter++;
            if (counter == 4)
            {
                break;
            }
        }
        return "";
    }

    public void Park(int id)
    {
        if (this.races.Values.Any(v => v.Participants.Contains(this.cars[id])))
        {
            return;
        }

        this.garage.Park(id, this.cars[id]);
    }

    public void Unpark(int id)
    {
        this.garage.Unpark(id);
        
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (this.garage.ParkedCars.Count==0)
        {
            return;
        }

        foreach (var car in cars)
        {
            car.Value.Horsepower += tuneIndex;
            car.Value.Suspension += tuneIndex / 2;
            if (car.Value is ShowCar)
            {
                (car.Value as ShowCar).Stars++;
            }
            else if (car.Value is PerformanceCar)
            {
                (car.Value as PerformanceCar).AddAddOn(addOn);
            }
        }
    }
}


