using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var healtSymbols = new List<char>
            {
                '+',
                '-',
                '*',
                '/',
                '.'
            };
            for (int i = 0; i < 10; i++)
            {
                healtSymbols.Add(Convert.ToChar(i + '0'));
            }
            var pattern = @"-?\+?\d+(\.?\d+)*";
            var demonList = new List<Demon>();
            foreach (var demon in input)
            {
                var currentDemon = new Demon
                {
                    Name = demon
                };
                var hpOfDemon = 0;
                foreach (var symbol in demon)
                {
                    if (!healtSymbols.Contains(symbol))
                    {
                        hpOfDemon += (int)symbol;
                    }
                }
                currentDemon.HP = hpOfDemon;
                var currentDMG = 0.0;
                var matches = Regex.Matches(demon, pattern);
                if (matches.Count != 0)
                {
                    foreach (var numbers in matches)
                    {
                        var currentMatch = numbers.ToString();
                        if (char.IsDigit(currentMatch[0]))
                        {
                            currentDMG += double.Parse(currentMatch.Trim('.'));
                        }
                        else if (currentMatch[0] == '+')
                        {
                            currentMatch = currentMatch.Remove(0, 1).Trim('.');
                            currentDMG += double.Parse(currentMatch);
                        }
                        else if (currentMatch[0] == '-')
                        {
                            currentMatch = currentMatch.Remove(0, 1).Trim('.');
                            currentDMG -= double.Parse(currentMatch);
                        }
                    }
                }
                var devide = demon.Count(d => d == '/');
                var multyply = demon.Count(m => m == '*');
                //        devide *= 2;
                //          multyply *= 2;
                for (int i = 0; i < devide; i++)
                {
                    currentDMG /= 2.0;
                }
                for (int i = 0; i < multyply; i++)
                {
                    currentDMG *= 2.0;
                }
                currentDemon.DMG = currentDMG;
                demonList.Add(currentDemon);
            }
            foreach (var item in demonList.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{item.Name} - {item.HP} health, {item.DMG:F2} damage ");
            }
        }

    }

    class Demon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public double DMG { get; set; }
    }
}
