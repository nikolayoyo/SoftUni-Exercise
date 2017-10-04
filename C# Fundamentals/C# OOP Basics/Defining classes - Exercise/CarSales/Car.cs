using System;

class Car
{
    public Car(string model, Engine engine, string weight,string color)
    {
        this.model = model;
        this.color = color;
        this.engine = engine;
        this.weight = weight;
    }

    public Car(string model, Engine engine, string colorOrWeight)
    {
        this.model = model;
        this.engine = engine;
        int weight;
        if (int.TryParse(colorOrWeight, out weight))
        {
            this.weight = colorOrWeight;
            this.color = "n/a";
        }
        else
        {
            this.color = colorOrWeight;
            this.weight = "n/a";
        }
    }

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = "n/a";

    }

    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    private string weight;

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private Engine engine;

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public override string ToString()
    {
        return $"{this.model}:" +
            $"{Environment.NewLine}  { this.engine.Model}:" +
            $"{Environment.NewLine}    Power: {this.engine.Power}" +
            $"{Environment.NewLine}    Displacement: {this.engine.Displacement}" +
            $"{Environment.NewLine}    Efficiency: {this.engine.Efficiency}" +
            $"{Environment.NewLine}  Weight: {this.weight}" +
            $"{Environment.NewLine}  Color: {this.color}";
    }
}

