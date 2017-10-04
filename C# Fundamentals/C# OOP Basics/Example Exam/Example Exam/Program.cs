using System;

public class Program
{
    public static void Main()
    {
        var manager = new CarManager();
        string input;
        while ((input=Console.ReadLine()) != "Cops Are Here")
        {
            var tokens = input.Split();
            switch (tokens[0])
            {
                case "register": manager.Register(int.Parse(tokens[1]), tokens[2], tokens[3], tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8]), int.Parse(tokens[9]));
                    break;
                case "open": manager.Open(int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                    break;
                case "participate": manager.Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                    case "check": manager.Check(int.Parse(tokens[1]));
                    break;
                case "start": manager.Start(int.Parse(tokens[1]));
                    break;
                default:
                    break;
            }
        }
    }
}

