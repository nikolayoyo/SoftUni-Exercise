using System.Collections.Generic;
using System.Linq;

public class Recipe:IRecipe
    {
        private readonly string name;
        private readonly long strengthBonus;
        private readonly long agilityBonus;
        private readonly long intelligenceBonus;
        private readonly long hitPointsBonus;
        private readonly long damageBonus;
        private readonly IReadOnlyList<string> requiredItems;

        public Recipe(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus, params string[] requiredItems)
        {
            this.name = name;
            this.strengthBonus = strengthBonus;
            this.agilityBonus = agilityBonus;
            this.intelligenceBonus = intelligenceBonus;
            this.hitPointsBonus = hitPointsBonus;
            this.damageBonus = damageBonus;
            this.requiredItems = requiredItems.ToList() as IReadOnlyList<string>;
        }

        public string Name
        {
            get { return this.name; }
        }

        public long StrengthBonus
        {
            get { return this.strengthBonus; }
        }

        public long AgilityBonus
        {
            get { return this.agilityBonus; }
        }

        public long IntelligenceBonus
        {
            get { return this.intelligenceBonus; }
        }

        public long HitPointsBonus
        {
            get { return this.hitPointsBonus; }
        }

        public long DamageBonus
        {
            get { return this.damageBonus; }
        }

        public IReadOnlyList<string> RequiredItems
        {
            get { return this.requiredItems; }
        }
    }
