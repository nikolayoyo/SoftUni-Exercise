using System;
using System.Text;

public abstract class Provider:Worker
{
    internal Provider(string id, double energyOutput):base(id, energyOutput)
    {
        this.EnergyParam = energyOutput;
    }

    public override double EnergyParam {
        get => base.EnergyParam; 
        protected set
        {
            if (value> 10000.0)
            {
                throw new ArgumentException("EnergyOutput");
            }

            base.EnergyParam = value;

        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        string type = this.GetType().Name;
        int typeEnd = type.IndexOf("Provider");
        type = type.Insert(typeEnd, " ");

        builder.AppendLine($"{type} - {this.Id}");
        builder.AppendLine($"Energy Output: {this.EnergyParam}");
        return builder.ToString().Trim();
    }
}

