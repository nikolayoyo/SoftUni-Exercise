using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var draftManager = new DraftManager();

        while (true)
        {
            var input = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var cmd = input[0];
            input.RemoveAt(0);

            switch (cmd)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(input)); 
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(input));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(input));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(input));
                    break;
                case "Shutdown": Console.WriteLine(draftManager.ShutDown());
                    break;
                default:
                    break;
            }

            if (cmd == "Shutdown")
            {
                break;
            }
        }
    }
}

