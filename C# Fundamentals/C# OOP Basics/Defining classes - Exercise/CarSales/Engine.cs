class Engine
{
    public Engine(string model, string power, string  displacement, string eff)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = eff;
    }

    public Engine(string model, string power, string displacemenEff)
    {
        this.model = model;
        this.power = power;

        int disp;
        if (int.TryParse(displacemenEff, out disp))
        {
            this.displacement = displacemenEff;
            this.efficiency = "n/a";
        }
        else
        {
            this.displacement = "n/a";
            this.efficiency = displacemenEff;
        }
    }

    public Engine(string model, string power)
    {
        this.model = model;
        this.power = power;
        this.efficiency = "n/a";
        this.displacement = "n/a";
    }

    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string power;

    public string Power
    {
        get { return power; }
        set { power = value; }
    }

    private string displacement;

    public string Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }

    private string efficiency;

    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }

}

