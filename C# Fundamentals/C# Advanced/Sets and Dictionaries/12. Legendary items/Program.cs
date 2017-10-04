using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_items
{
    class Program
    {
        static void Main(string[] args)
        {
            var realStuff = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            realStuff["shards"] = 0;
            realStuff["motes"] = 0;
            realStuff["fragments"] = 0;

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1].ToLower();
                    if (material == "shards" || material =="fragments"|| material=="motes")
                    {
                        realStuff[material] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }

                    if (realStuff.Any(x=> x.Value>=250))
                    {
                        break;
                    }
                }
                if (realStuff.Any(x => x.Value >= 250))
                {
                    break;
                }
            }

            if (realStuff["motes"]>=250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                realStuff["motes"] -= 250;
            }
            else if (realStuff["shards"]>=250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                realStuff["shards"] -= 250;
            }
            else if (realStuff["fragments"]>=250)
            {
                Console.WriteLine("Valanyr obtained!");
                realStuff["fragments"] -= 250;
            }
            foreach (var item in realStuff.OrderByDescending(x=>x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderByDescending(x => x.Value).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
