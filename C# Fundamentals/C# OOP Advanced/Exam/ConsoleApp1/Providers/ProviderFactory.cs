using System.Collections.Generic;

public static class ProviderFactory
{
    public static Provider Get(List<string> args)
    {
        switch (args[0])
        {
            case "Solar": return new SolarProvider(args[1], double.Parse(args[2]));
            case "Pressure": return new PressureProvider(args[1], double.Parse(args[2]));
            default: return null;
        }
    }
}

