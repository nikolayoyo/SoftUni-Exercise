using System;
using System.Collections.Generic;

public static class HeroFactory
{
    public static IHero GetHero(IList<string> args)
    {
        var heroType = Type.GetType(args[1]);
        var instance = (IHero)Activator.CreateInstance(heroType, new[] {args[0]});   
     

        return instance;
    }
}
