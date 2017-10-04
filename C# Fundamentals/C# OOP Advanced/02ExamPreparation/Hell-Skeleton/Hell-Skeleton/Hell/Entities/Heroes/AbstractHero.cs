using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public abstract class AbstractHero: IHero
{
    private IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, long strength, long agility, long intelligence, long hitPoints, long damage)
    {
        this.Name = name;
        this.strength = strength;
        this.agility = agility;
        this.intelligence = intelligence;
        this.hitPoints = hitPoints;
        this.damage = damage;
        this.inventory = new HeroInventory();
    }

    public string Name { get; private set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            var inventoryType =typeof(HeroInventory);

            var fieldInfo = inventoryType
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .First(f => f.GetCustomAttribute(typeof(ItemAttribute)) != null);

            var valueStolen = ((Dictionary<string, IItem>) fieldInfo.GetValue(this.inventory)).Select(kvp => kvp.Value)
                .ToList();

          //  var itemField = inventoryType.GetField("commonItems",
          //      BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
          //
          //  var valueStolen = (List<IItem>)itemField.GetValue(this.inventory);
            


            return valueStolen;

        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }

    public void AddItem(IItem commonItem)
    {
        this.inventory.AddCommonItem(commonItem);
    }

    public abstract string QuitCommandFormat(int index);

    public  int CompareTo(IHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }
        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }

    public override string ToString()
    {
        var sb = new StringBuilder(
            );

        sb.AppendLine(
            $"Hero: {this.Name}, Class: Barbarian\r\nHitPoints: {this.HitPoints}\r\nDamage: {this.Damage}\r\nStrength: {this.Strength}\r\nAgility: {this.Agility}\r\nIntelligence: {this.Intelligence}");
        
        if (this.Items.Count==0)
        {
            sb.AppendLine("Items: None");
            return sb.ToString();
        }

        sb.AppendLine("Items:");
        foreach (var item in this.Items)
        {
            sb.AppendLine(item.ToString());
        }
        
        return sb.ToString().Trim();
    }   
}