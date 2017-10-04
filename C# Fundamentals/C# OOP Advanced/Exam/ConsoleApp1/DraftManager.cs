using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private Dictionary<string,Harvester> harvesters;
    private Dictionary<string,Provider> providers;
    string mode;
    private double totalMinedOre;
    private double totalStoredEnergy;

    public DraftManager()
    {
        harvesters = new Dictionary<string, Harvester>();
        providers = new Dictionary<string, Provider>();
        mode = "Full";
        totalStoredEnergy = 0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string outputMessage = string.Empty;
        try
        {
            this.harvesters[arguments[1]] = (HarvesterFactory.Get(arguments));
            outputMessage = $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
        }
        catch (System.ArgumentException ex)
        {
            outputMessage = $"Harvester is not registered, because of it's {ex.Message}";
        }

        return outputMessage;

    }

    public string RegisterProvider(List<string> arguments)
    {
        string outputMessage = string.Empty;
        var energyOutput = double.Parse(arguments[2]);

        try
        {
            this.providers[arguments[1]] = ProviderFactory.Get(arguments);
            outputMessage = $"Successfully registered {arguments[0]} Provider - {arguments[1]}";          
        }
        catch (System.ArgumentException ex)
        {

            outputMessage = $"Provider is not registered, because of it's {ex.Message}";

        }

        return outputMessage;

    }

    public string Day()
    {
        double summedEnergyOutput = 0;
        foreach (var prov in providers)
        {
            summedEnergyOutput += prov.Value.EnergyParam;
        }

        this.totalStoredEnergy += summedEnergyOutput;

        double requiredEnergy = 0 ;
        double summedOreOutput = 0 ;
        foreach (var harv in harvesters)
        {
            requiredEnergy += harv.Value.EnergyParam;
            summedOreOutput += harv.Value.OreOutput;
        }
       

        switch (this.mode)
        {
            case "Full":
                break;
            case "Half":
                requiredEnergy = requiredEnergy * 60.0 / 100.0;
                summedOreOutput = summedOreOutput * 50.0 / 100.0;
                break;
            case "Energy":
                summedOreOutput = 0;
                requiredEnergy = 0;
                break;
        }


        if (requiredEnergy<= this.totalStoredEnergy)
        {
            this.totalMinedOre += summedOreOutput;
            this.totalStoredEnergy -= requiredEnergy;
        }
        else
        {
            summedOreOutput = 0;
        }

        var output = new StringBuilder();
        output.AppendLine("A day has passed.");
        output.AppendLine($"Energy Provided: {summedEnergyOutput}");
        output.AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        return output.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {this.mode} Mode";

    }

    public string Check(List<string> arguments)
    {
        if (this.providers.ContainsKey(arguments[0]))
        {
            return this.providers[arguments[0]].ToString();
        }
        else if (this.harvesters.ContainsKey(arguments[0]))
        {
            return this.harvesters[arguments[0]].ToString();
        }
        else
        {
            return $"No element found with id - {arguments[0]}";
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");


        return sb.ToString().Trim();
    }


}

