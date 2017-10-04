using System.Collections.Generic;

class Trainer
{
    private string name;
    private int numberOfBadges;
    private List<Pokemon> pokemons;

    public Trainer(string trainerName)
    {
        this.name = trainerName;
        this.pokemons = new List<Pokemon>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int NumberOfBadges
    {
        get { return numberOfBadges; }
        set { numberOfBadges = value; }
    }

    public List<Pokemon> Pokemos
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public override string ToString()
    {
        return $"{this.name} {this.numberOfBadges} {this.pokemons.Count}";
    }

}

