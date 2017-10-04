using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Replace(',','.')
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var myDic = new SortedDictionary<double, int>();
            foreach (var number in input)
            {
                if (myDic.ContainsKey(number))
                {
                    myDic[number]++;
                }
                else
                {
                    myDic[number] = 1;
                }
            }

            foreach (var number in myDic)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
