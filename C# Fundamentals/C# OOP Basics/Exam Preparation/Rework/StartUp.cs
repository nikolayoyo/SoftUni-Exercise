using System;

public class StartUp
{
    public static void Main()
    {
        var manager = new CarManager();
        string input;
        while ((input= Console.ReadLine())!="Cops Are Here")
        {
            var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (args[0])
            {
                case "register":
                    var carId = int.Parse(args[1]);
                    var carType = args[2];
                    var carBrand = args[3];
                    var carModel = args[4];
                    var carYear = int.Parse(args[5]);
                    var carPower = int.Parse(args[6]);
                    var carAcceleration = int.Parse(args[7]);
                    var carSuspension = int.Parse(args[8]);
                    var carDurability = int.Parse(args[9]);

                    manager.Register(carId, carType, carBrand, carModel, carYear, carPower, carAcceleration, carSuspension, carDurability);
                    break;
                case "check":
                    Console.WriteLine(manager.Check(int.Parse(args[1])));
                    break;
                case "open":
                    var raceId = int.Parse(args[1]);
                    var raceType = args[2];
                    var raceLenght = int.Parse(args[3]);
                    var raceRoute = args[4];
                    var racePoolPrize = int.Parse(args[5]);

                    if (args.Length == 6)
                    {
                        manager.Open(raceId, raceType, raceLenght, raceRoute, racePoolPrize);
                    }
                    else
                    {
                        var lapsOrTime = int.Parse(args[6]);
                        manager.Open(raceId, raceType, raceLenght, raceRoute, racePoolPrize,lapsOrTime);
                    }
                    break;
                case "participate":
                    manager.Participate(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "start":
                    Console.WriteLine(manager.Start(int.Parse(args[1])));
                    break;
                case "park":
                    manager.Park(int.Parse(args[1]));
                    break;
                case "unpark":
                    manager.Unpark(int.Parse(args[1]));
                    break;
                case "tune":
                    manager.Tune(int.Parse(args[1]), args[2]);
                    break;

                default:
                    break;
            }
        }
    }
}

