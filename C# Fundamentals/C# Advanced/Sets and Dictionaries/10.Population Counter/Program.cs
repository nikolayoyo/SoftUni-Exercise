using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countriesList = new Dictionary<string, County>();
            var input = Console.ReadLine()
                .Split('|');
            while (input[0]!="report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);
                if (!countriesList.ContainsKey(country))
                {
                    var newCountry = new County()
                    {
                        Name = country,
                        CityPop = new Dictionary<string,long>()
                    };
                    countriesList[country] = newCountry;
                }

                if (!countriesList[country].CityPop.ContainsKey(city))
                {
                    countriesList[country].CityPop[city] = population;
                }

                countriesList[country].TotalPopulation += population;
                input = Console.ReadLine()
                .Split('|');
            }

            foreach (var country in countriesList.OrderByDescending(x=> x.Value.TotalPopulation))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.TotalPopulation})");
                foreach (var city in country.Value.CityPop.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }

    class County
    {
        public string Name { get; set; }
        public Dictionary<string,long> CityPop { get; set; }
        public long TotalPopulation { get; set; }
    }
}
