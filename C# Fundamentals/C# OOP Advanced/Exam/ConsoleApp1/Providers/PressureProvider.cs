public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        this.EnergyParam = energyOutput + energyOutput * 50.0 / 100.0;
    }
}

