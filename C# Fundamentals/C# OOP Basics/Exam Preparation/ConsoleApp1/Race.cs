using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int,Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.PrizePool = prizePool;
        this.Route = route;
        this.participants = new Dictionary<int, Car>();
    }

    public abstract Dictionary<int, int> PerformancePoints();

    public IReadOnlyDictionary<int,Car> Participants
    {
        get { return participants as IReadOnlyDictionary<int, Car>; }

    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }
        
    public void Participate(int id, Car car)
    {
        this.participants[id] = car;
    }
}



