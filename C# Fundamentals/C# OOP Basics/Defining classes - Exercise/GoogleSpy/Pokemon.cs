public class Pokemon
{
    private string name;
    private string element;

    public Pokemon(string name, string element)
    {
        this.name = name;
        this.element = element;
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

    public override string ToString()
    {
        return $"{this.name} {this.element}";
    }
}
