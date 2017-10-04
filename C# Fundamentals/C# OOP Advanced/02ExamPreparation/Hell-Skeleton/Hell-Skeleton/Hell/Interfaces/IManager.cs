using System;
using System.Collections.Generic;

    public interface IManager
    {
        string AddHero(IList<string> arguments);

        string AddItemToHero(IList<string> arguments);

        string Inspect(IList<string> arguments);

        string Quit(IList<string> arguments);

        string AddRecipe(IList<string> argsList);
    }
