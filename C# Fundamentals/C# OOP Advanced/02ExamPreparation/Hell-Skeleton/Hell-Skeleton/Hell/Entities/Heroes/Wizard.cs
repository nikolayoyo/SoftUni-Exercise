using System;
using System.Linq;
using System.Text;

public class Wizard:AbstractHero
{
    public Wizard(string name ) 
        : base(name, WizardConstants.Strength, WizardConstants.Agility, WizardConstants.Intelligence, WizardConstants.HitPoints, WizardConstants.Damage)
    {
    }

    public override string QuitCommandFormat(int index)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{index}. Wizard: {this.Name}");
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
        $"Hero: {this.Name}, Class: Wizard{Environment.NewLine}HitPoints: {this.HitPoints}, Damage: {this.Damage}{Environment.NewLine}Strength: {this.Strength}{Environment.NewLine}gility: {this.Agility}{Environment.NewLine}Intelligence: {this.Intelligence}");

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
