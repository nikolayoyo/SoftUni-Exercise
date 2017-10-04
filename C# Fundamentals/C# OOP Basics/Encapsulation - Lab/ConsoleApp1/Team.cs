using System;
using System.Collections.Generic;

class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> secondTeam;

    public Team()
    {
        this.firstTeam = new List<Person>();
        this.secondTeam = new List<Person>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return this.firstTeam.AsReadOnly(); }
    }


    public IReadOnlyCollection<Person> SecondTeam
    {
        get { return this.secondTeam.AsReadOnly(); }
    }

    public void AddPlayer(Person player)
    {
        if (player.Age<40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.secondTeam.Add(player);
        }
    }

    public override string ToString()
    {
        return $"First team have {firstTeam.Count} players {Environment.NewLine}Second team have {secondTeam.Count} players";
    }
}

