using System;

public class Ferrari : ICar
{
    private string driver;

    public Ferrari(string driver)
    {
        this.driver = driver;
    }

    public string Model => "488-Spider";

    public string DriverName => this.driver;

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.driver}";
    }
}

