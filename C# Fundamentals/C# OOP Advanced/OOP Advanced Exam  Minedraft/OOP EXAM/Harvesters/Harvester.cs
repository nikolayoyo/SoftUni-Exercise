public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.oreOutput = oreOutput;
        this.energyRequirement = energyRequirement;
    }
}

