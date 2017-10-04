using System;

public class CommonItem:IItem
{
    private readonly string name;
    private readonly long strengthBonus;
    private readonly long intelligenceBonus;
    private readonly long agilityBonus;
    private readonly long hitPointsBonus;
    private readonly long damageBonus;

    public CommonItem(string name, long strengthBonus, long intelligenceBonus, long agilityBonus, long hitPointsBonus, long damageBonus)
    {
        this.name = name;
        this.strengthBonus = strengthBonus;
        this.intelligenceBonus = intelligenceBonus;
        this.agilityBonus = agilityBonus;
        this.hitPointsBonus = hitPointsBonus;
        this.damageBonus = damageBonus;
    }

    public string Name
    {
        get { return this.name; }
    }

       

    public long StrengthBonus
    {
        get { return this.strengthBonus; }
    }

    public long IntelligenceBonus
    {
        get { return this.intelligenceBonus; }
    }

    public long AgilityBonus
    {
        get { return this.agilityBonus; }
    }

    public long HitPointsBonus
    {
        get { return this.hitPointsBonus; }
    }

    public long DamageBonus
    {
        get { return this.damageBonus; }
    }

    public override string ToString()
    {
        return
            $"###Item: Spear{Environment.NewLine}###{this.StrengthBonus:+00;-00;+00} Strength{Environment.NewLine}###{this.AgilityBonus:+00;-00;+00} Agility{Environment.NewLine}###{this.IntelligenceBonus:+00;-00;+00} Intelligence{Environment.NewLine}###{this.HitPointsBonus:+00;-00;+00} HitPoints{Environment.NewLine}###{this.DamageBonus:+00;-00;+00} Damage";
    }
}
