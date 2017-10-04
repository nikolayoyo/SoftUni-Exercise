using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private IList<Car> participants;
    public Dictionary<Car, int> performancePoints;

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.participants = new List<Car>();
        this.performancePoints = new Dictionary<Car, int>();
    }

    public abstract IReadOnlyDictionary<Car, int> OverallPerformance();

    public IReadOnlyCollection<Car> Participants
    {
        get { return this.participants as IReadOnlyCollection<Car>; }
    }

    public void AddCar(Car car)
    {
        this.participants.Add(car);
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

}

