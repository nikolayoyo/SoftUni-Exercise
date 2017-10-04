public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = oreOutput + oreOutput * 200.0 / 100.0;
        this.EnergyParam = energyRequirement + energyRequirement * 100.0 / 100.0;
    }
}

