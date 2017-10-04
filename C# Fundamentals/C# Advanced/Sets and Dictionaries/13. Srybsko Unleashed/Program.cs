using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.Srybsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new Dictionary<string, Resort>();
            var rawInput = Console.ReadLine();
            var pattern = @"(([A-Za-z]+\s)+)@(([A-Za-z]+\s)+)(\d+)\s+(\d+)";
            while (rawInput!="End")
            {
                var input = Regex.Split(rawInput, pattern);
                var matches = Regex.Match(rawInput, pattern);
                if (matches.Success)
                {
                    var Name = matches.Groups[1].ToString();
                    

                    var resort = matches.Groups[3].ToString();
                    var tickerPrice = int.Parse(matches.Groups[5].ToString());

                    var ticketsSold = int.Parse(matches.Groups[6].ToString());
                  

                    if (!mySet.ContainsKey(resort))
                    {
                        var newResort = new Resort()
                        {
                            Name = Name,
                            SingersAndMoney = new Dictionary<string, int>()
                        };
                        mySet[resort] = newResort;
                    }
                    if (!mySet[resort].SingersAndMoney.ContainsKey(Name))
                    {
                        mySet[resort].SingersAndMoney[Name] = 0;
                    }

                    mySet[resort].SingersAndMoney[Name] += tickerPrice * ticketsSold;
                    
                }
                rawInput = Console.ReadLine();
                
            }

            foreach (var resort in mySet)
            {
                Console.WriteLine(resort.Key.Substring(0, resort.Key.Length-1));
                foreach (var singer in resort.Value.SingersAndMoney.OrderByDescending(x=> x.Value).ThenBy(x=> x.Key))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }

    class Resort
    {
        public string Name { get; set; }
        public Dictionary<string, int> SingersAndMoney { get; set; }
    }
}
