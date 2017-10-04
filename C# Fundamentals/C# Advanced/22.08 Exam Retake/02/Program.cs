using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        public static int rubeDimention = int.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "Analyze")
            {
                var tokens = input.Split(',').Select(int.Parse).ToArray();


                input = Console.ReadLine();
            }
        }
    }
}
