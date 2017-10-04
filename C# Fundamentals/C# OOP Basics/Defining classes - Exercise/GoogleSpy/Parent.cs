public class Parent
{
    private string name;
    private string birthDate;

    public Parent(string name, string birthDate)
    {
        this.name = name;
        this.birthDate = birthDate;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public override string ToString()
    {
        return $"{this.name} {this.birthDate}";
    }
}

