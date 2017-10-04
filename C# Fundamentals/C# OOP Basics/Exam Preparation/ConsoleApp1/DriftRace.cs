using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override Dictionary<int, int> PerformancePoints()
    {
        var copyPartisipants = this.Participants.OrderByDescending(c => c.Value.Suspension / c.Value.Dubrability);

        var winners = new Dictionary<int, int>();
        foreach (var car in copyPartisipants)
        {
            var c = car.Value;
            winners[car.Key] = c.Suspension / c.Dubrability;
        }

        return winners;
    }
}

