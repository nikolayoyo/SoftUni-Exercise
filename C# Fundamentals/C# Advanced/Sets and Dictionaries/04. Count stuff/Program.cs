using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var myDic = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (!myDic.ContainsKey(item))
                {
                        myDic[item] = 0;
                }

                myDic[item]++;
            }

            foreach (var kvp in myDic.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
