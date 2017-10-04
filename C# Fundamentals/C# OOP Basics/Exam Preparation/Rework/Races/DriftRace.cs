using System;
using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
    {
    }

    public override List<string> StartRace()
    {

        var result = base.StartRace();
        var counter = 1;
        foreach (var car in Participants.OrderByDescending(c=> this.Oreder(c)).Take(3))
        {
            if (counter ==1)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool*50/100}");
            }
            else if (counter ==2)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 30 / 100}");
            }
            else if (counter == 3)
            {
                result.Add($"{counter}. {car.Brand} {car.Model} {this.Oreder(car)}PP - ${this.PrizePool * 20 / 100}");
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
        return car.Suspension + car.Durability;
    }
}

