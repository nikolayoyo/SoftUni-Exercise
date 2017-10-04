public class Company
{
    private string name;
    private string department;
    private double salary;

    public Company(string name, string department, double salary)
    {
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }


}
