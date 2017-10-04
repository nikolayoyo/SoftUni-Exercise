using System.Collections.Generic;

public abstract class Race
{
    private int lenght;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public Race(int lenght, string route, int prizePool)
    {
        this.lenght = lenght;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public bool IsEmpty()
    {
        return this.participants.Count > 0;
    }

    public virtual void AddParticipant(Car car)
    {
        this.participants.Add(car);
    }

    public int Lenght
    {
        get => this.lenght;
    }

    public string Route
    {
        get => this.route;
    }

    public int PrizePool { get => this.prizePool; }

    public IReadOnlyList<Car> Participants
    {
        get
        {
            return this.participants;
        }
    }

    public virtual List<string> StartRace()
    {
        return new List<string>()
        {
            $"{this.route} - {this.lenght}"
        };
    }

}

