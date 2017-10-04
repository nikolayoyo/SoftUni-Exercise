using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dragon_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragonTypes = new Dictionary<string, DragonType>();
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var currentDragon = new Dragon
                {
                    Name = input[1],
                    Damage = CheckIfNull(input[2], "dmg"),
                    Health = CheckIfNull(input[3], "health"),
                    Armor = CheckIfNull(input[4], "armor")
                };
                if (!dragonTypes.ContainsKey(input[0]))
                {
                    dragonTypes[input[0]] = new DragonType
                    {
                        Name = input[0],
                        Dragons = new List<Dragon>()
                    };
                }
                if (dragonTypes[input[0]].Dragons.Exists(x => x.Name == currentDragon.Name))
                {
                    dragonTypes[input[0]].Dragons.RemoveAll(x => x.Name == currentDragon.Name);
                }
                dragonTypes[input[0]].Dragons.Add(currentDragon);
            }

            foreach (var type in dragonTypes)
            {
                Console.WriteLine($"{type.Key}::({type.Value.DamageAv:F2}/{type.Value.HealthAv:F2}/{type.Value.ArmorAv:F2})");
                foreach (var dragon in type.Value.Dragons.OrderBy(d=> d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        public static int CheckIfNull(string input, string type)
        {
            if (input=="null")
            {
                if (type == "armor")
                {
                    return 10;
                }
                else if (type == "dmg")
                {
                    return 45;
                }
                else
                {
                    return 250;
                }
                
            }
            else
            {
                return int.Parse(input);
            }
        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }

    class DragonType
    {
        public string Name { get; set; }
        
        public  List<Dragon> Dragons { get; set; }

        public double DamageAv
        {
            get
            {
                double avDmg = 0;
                foreach (var dragon in Dragons)
                {
                    avDmg += (double)dragon.Damage;
                }

                return avDmg / Dragons.Count;
            }
        }

        public double HealthAv
        {
            get
            {
                double avgHP = 0;
                foreach (var dragon in Dragons)
                {
                    avgHP += (double)dragon.Health;
                }

                return avgHP / Dragons.Count;
            }
        }

        public double ArmorAv
        {
            get
            {
                double armorAv = 0;
                foreach (var dragon in Dragons)
                {
                    armorAv += (double)dragon.Armor;
                }

                return armorAv / Dragons.Count;
            }
        }
    }
}
