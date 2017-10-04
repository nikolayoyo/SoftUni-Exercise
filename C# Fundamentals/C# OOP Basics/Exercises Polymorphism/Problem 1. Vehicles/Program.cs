using System;

public class Program
{
    public static void Main()
    {
        var carTokens = Console.ReadLine().Split();
        var truckTokens = Console.ReadLine().Split();

        var car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
        var truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

        var nCmds = int.Parse(Console.ReadLine());

        for (int i = 0; i < nCmds; i++)
        {
            var cmd = Console.ReadLine().Split();
            try
            {
                if (cmd[1] == "Car")
                {
                    switch (cmd[0])
                    {
                        case "Drive": car.Drive(double.Parse(cmd[2]));
                            Console.WriteLine($"Car travelled {cmd[2]} km");

                            break;
                        case "Refuel": car.Refuel(double.Parse(cmd[2]));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (cmd[0])
                    {
                        case "Drive":
                            truck.Drive(double.Parse(cmd[2]));
                            Console.WriteLine($"Truck travelled {cmd[2]} km");
                            break;
                        case "Refuel":
                            truck.Refuel(double.Parse(cmd[2]));
                            break;
                        default:
                            break;
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine($"Car: {car.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}" );
    }
}

