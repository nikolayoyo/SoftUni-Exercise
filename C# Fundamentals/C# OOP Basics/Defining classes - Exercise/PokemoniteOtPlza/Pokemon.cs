class Pokemon
{
    private string name;
    private int health;
    private string element;

    public Pokemon(string name, string element, int hp)
    {
        this.name = name;
        this.element = element;
        this.health = hp;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Element
    {
        get { return element; }
        set { element = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

}

