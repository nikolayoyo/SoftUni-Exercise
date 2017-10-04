using System.Collections.Generic;
using System.Linq;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override Dictionary<int, int> PerformancePoints()
    {
        var copyPartisipants = this.Participants.OrderByDescending(c => c.Value.Horsepower/c.Value.Acceleration);

        var winners = new Dictionary<int, int>();
        foreach (var car in copyPartisipants)
        {
            var c = car.Value;
            winners[car.Key] = c.Horsepower / c.Acceleration;
        }

        return winners;
    }
}
