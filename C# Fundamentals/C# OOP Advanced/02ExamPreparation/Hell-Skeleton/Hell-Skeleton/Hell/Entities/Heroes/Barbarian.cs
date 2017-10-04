using System;
using System.Linq;
using System.Text;

public class Barbarian : AbstractHero
    {
        public Barbarian(string name ) 
            : base(name, BarbarianConstants.Strength, BarbarianConstants.Agility, BarbarianConstants.Intelligence, BarbarianConstants.HitPoints, BarbarianConstants.Damage)
        {
        }

        public override string QuitCommandFormat(int index)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{index}. Barbarian: {this.Name}");
            sb.AppendLine($"###HitPoints: {this.HitPoints}");
            sb.AppendLine($"###Damage: {this.Damage}");
            sb.AppendLine($"###Strength: {this.Strength}");
            sb.AppendLine($"###Agility: {this.Agility}");
            sb.AppendLine($"###Intelligence: {this.Intelligence}");
            sb.AppendLine($"###Items: " + (this.Items.Count != 0 ? string.Join(", ", this.Items.Select(i => i.Name)) : "None"));


        return sb.ToString().Trim();

        }

    public override string ToString()
        {
            var sb = new StringBuilder(
            );

            sb.AppendLine(
                $"Hero: {this.Name}, Class: Barbarian{Environment.NewLine}HitPoints: {this.HitPoints}, Damage: {this.Damage}{Environment.NewLine}Strength: {this.Strength}{Environment.NewLine}Agility: {this.Agility}{Environment.NewLine}Intelligence: {this.Intelligence}");

            if (this.Items.Count == 0)
            {
                sb.AppendLine("Items: None");
                return sb.ToString().Trim();
            }

            sb.AppendLine("Items:");
            foreach (var item in this.Items)
            {
                sb.AppendLine(item.ToString().Trim());
            }

            return sb.ToString().Trim();
        }
}
