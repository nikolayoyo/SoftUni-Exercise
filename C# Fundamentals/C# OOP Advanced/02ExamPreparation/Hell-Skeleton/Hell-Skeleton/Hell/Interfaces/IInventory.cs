public interface IInventory
    {
      //  IReadOnlyList<IItem> RecipeItems { get; }
      //
      //  IReadOnlyList<IItem> CommonItems { get; }

        void AddCommonItem(IItem item);

        void AddRecipeItem(IRecipe item);

        long TotalStrengthBonus { get; }

        long TotalIntelligenceBonus { get; }

        long TotalAgilityBonus { get; }

        long TotalHitPointsBonus { get; }

        long TotalDamageBonus { get; }

    }
