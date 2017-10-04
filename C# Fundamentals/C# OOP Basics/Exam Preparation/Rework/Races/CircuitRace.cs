using System.Collections.Generic;
using System.Linq;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int lenght, string route, int prizePool, int laps) : base(lenght, route, prizePool)
    {
        this.laps = laps;
    }

    public override List<string> StartRace()
    {
        var result = new List<string>() { $"{this.Route} - {this.Lenght * laps}" };
        var counter = 1;

        foreach (var car in Participants)
        {
            car.DecreaseDurability(this.laps, this.Lenght);
        }

        foreach (var car in Participants.OrderByDescending(car => this.Oreder(car)).Take(4))
        {
            if (counter == 1)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 40 / 100}");
            }
            else if (counter == 2)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 30 / 100}");
            }
            else if (counter == 3)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 20 / 100}");
            }
            else if (counter == 4)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 10 / 100}");

            }
            else
            {
                break;
            }

            counter++;
        }

        return result;
    }

    private int Oreder(Car car)
    {
        return (car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability);
    }
}

