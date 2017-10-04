using System;

namespace _01.Charity_marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfMarathon = int.Parse(Console.ReadLine());
            var runnersParticipants = int.Parse(Console.ReadLine());
            var averageLapsbyRunner = int.Parse(Console.ReadLine());
            var lenghtOfTrack = double.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            capacity = daysOfMarathon * capacity;
            if (capacity > runnersParticipants)
            {
                capacity = runnersParticipants;
            }
            lenghtOfTrack = capacity * lenghtOfTrack * averageLapsbyRunner;
            lenghtOfTrack /= 1000;
            decimal moneyRaised = (decimal)lenghtOfTrack * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
