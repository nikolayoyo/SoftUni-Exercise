public class CitizenRobotFactory
{
    public static IIdiable Factory(string[] args)
    {
        if (args.Length == 3)
        {
            return new Citizen(args[0], int.Parse(args[1]), args[2]);
        }
        else
        {
            return new Robot(args[0], args[1]);
        }
    }
}

