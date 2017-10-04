using System.Collections.Generic;
using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int lenght, string route, int prizePool, int goldTime) : base(lenght, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public override void AddParticipant(Car car)
    {
        if (Participants.Count >1)
        {
            return;
        }

        this.AddParticipant(car);
    }

    public override List<string> StartRace()
    {
        foreach (var participant in Participants)
        {
            var participantTime = this.Lenght * ((participant.HorsePower / 100) * participant.Acceleration);

            var result = new StringBuilder(base.StartRace()[0]);
            result.AppendLine($"{participant.Brand} {participant.Model} - {participantTime} s");

            if (participantTime <= this.goldTime)
            {
                result.AppendLine($"Gold Time, ${this.PrizePool}");
            }
            else if (participantTime <= goldTime + 15)
            {
                result.AppendLine($"Silver Time, ${this.PrizePool * 50 / 100}");
            }
            else if (participantTime > goldTime + 15)
            {
                result.AppendLine($"Bronze Time, ${this.PrizePool * 30 / 100}");
            }

            return new List<string>() { result.ToString().Trim() };
        }

        return new List<string>();
    }
}


