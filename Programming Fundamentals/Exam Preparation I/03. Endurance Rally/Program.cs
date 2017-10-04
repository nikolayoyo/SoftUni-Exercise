using System;
using System.Linq;

namespace racers
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToList();
            var givenPoints = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkPounts = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            foreach (var racer in names)
            {
                bool failed = false;
                double fuel = (double)racer[0];
                for (int i = 0; i < givenPoints.Count; i++)
                {
                    var currentPoint = givenPoints[i];
                    if (checkPounts.Contains(i))
                    {
                        fuel += currentPoint;
                    }
                    else
                    {
                        fuel -= currentPoint;
                        if (fuel <= 0)
                        {
                            failed = true;
                            Console.WriteLine($"{racer} - reached {i}");
                            break;
                        }
                    }
                }
                if (!failed)
                {
                    Console.WriteLine($"{racer} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
