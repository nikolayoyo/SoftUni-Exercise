using System;
using System.Text;

public abstract class Harvester: Worker
    {
    private double oreOutput;

    internal Harvester(string id, double oreOutput, double energyRequirement)
        :base(id, energyRequirement)
    {
        this.OreOutput = oreOutput;
    }   

    public double OreOutput
    {
        get => this.oreOutput;

        protected set
        {
            if (value<=0.0)
            {
                throw new ArgumentException("OreOutput");
            }

            this.oreOutput = value;

        }
    }

    public override double EnergyParam
    {
        get => base.EnergyParam;
        protected set
        {
            if (value>= 20000)
            {
                throw new ArgumentException("EnergyParam");
            }
            base.EnergyParam = value;
        }
    }


    public override string ToString()
    {
        var builder = new StringBuilder();
        string type = this.GetType().Name;
        int typeEnd = type.IndexOf("Harvester");
        type = type.Insert(typeEnd, " ");

        builder.AppendLine( $"{type} - {this.Id}");
        builder.AppendLine($"Ore Output: {this.oreOutput}");
        builder.AppendLine($"Energy Requirement: {this.EnergyParam}");

        return builder.ToString().Trim();

    }
}

