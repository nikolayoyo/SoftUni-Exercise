using System;

public abstract class Worker
{
    private string id;
    private double energyParam;


    internal Worker(string id, double energyParam)
    {
        this.id = id;
        this.energyParam = energyParam;
    }

    public virtual double EnergyParam
    {
        get => this.energyParam;

        protected set
        {
            if (value <= 0.0)
            {
                throw new ArgumentException("EnergyRequirement");
            }

            this.energyParam = value;

        }
    }

    public string Id
    {
        get => this.id;
    }
}

