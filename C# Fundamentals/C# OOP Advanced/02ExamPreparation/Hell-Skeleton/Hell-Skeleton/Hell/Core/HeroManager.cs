using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HeroManager : IManager
{
    public Dictionary<string, IHero> heroes;

    public HeroManager()
    {
        this.heroes = new Dictionary<string, IHero>();
    }

    public string AddHero(IList<string> arguments)
    {
        string result = null;

        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            heroes[heroName] = HeroFactory.GetHero(arguments);
            result = string.Format(string.Format(Constants.HeroCreateMessage, heroType, heroName));
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string result = null;

        //Ма те много бе!
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        IItem newItem = new CommonItem(itemName, strengthBonus, intelligenceBonus, agilityBonus, hitPointsBonus,
            damageBonus);

        this.heroes[heroName].AddItem(newItem);

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
        return result;
    }


    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString().Trim();
    }

    public string Quit(IList<string> arguments)
    {
        var sb = new StringBuilder();
        var counter = 1;
        foreach (var hero in heroes.OrderByDescending(h=> h.Value).ThenByDescending(h=> h.Value))
        {
            sb.AppendLine(hero.Value.QuitCommandFormat(counter).Trim());
            counter++;
        }

        return sb.ToString().Trim();
    }

    public string AddRecipe(IList<string> arguments)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        string[] itemRequiredList = arguments.Skip(7).ToArray();

        var newRecpeItem = new Recipe(itemName,strengthBonus,agilityBonus,intelligenceBonus,hitPointsBonus,damageBonus,itemRequiredList);

        this.heroes[heroName].AddRecipe(newRecpeItem);

        return string.Format(Constants.RecipeCreatedMessage, itemName, heroName);
    }
}