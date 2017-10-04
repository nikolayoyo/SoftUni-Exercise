using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Miners_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDic = new Dictionary<string, int>();
            var resource = Console.ReadLine();
            while (resource!="stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (!myDic.ContainsKey(resource))
                {
                    myDic[resource] = 0;
                }

                myDic[resource] += quantity;
                resource = Console.ReadLine();
            }

            foreach (var kv in myDic)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
    }
}
