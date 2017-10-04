using System;
using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override IReadOnlyDictionary<Car, int> OverallPerformance()
    {
        foreach (var car in Participants)
        {
            this.performancePoints[car] = car.Acceleration + car.Durability;
        }

        return this.performancePoints.OrderByDescending(c => c.Value) as IReadOnlyDictionary<Car, int> ;
    }


}

