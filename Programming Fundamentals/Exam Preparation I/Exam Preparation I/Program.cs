using System;
using System.Linq;
namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingTime = Console.ReadLine().Split(':').Select(long.Parse).ToList();
            var stepsMade = long.Parse(Console.ReadLine());
            var secondPerStep = long.Parse(Console.ReadLine());
            var timeTook = stepsMade * secondPerStep;
            var second = startingTime[2];
            var minutes = startingTime[1];
            var hours = startingTime[0];
            second = second + timeTook;
            minutes += second / 60;
            second %= 60;
            hours += minutes / 60;
            minutes %= 60;
            hours %= 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{second:00}");
        }
    }
}
