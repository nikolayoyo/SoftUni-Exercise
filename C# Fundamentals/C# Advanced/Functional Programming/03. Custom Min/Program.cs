using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[], string> findThem = FindStuff;
            FindStuff(Console.ReadLine().Split(' ').Select(int.Parse).ToArray(), Console.ReadLine());
           
        }

       public static void FindStuff(int[] bounds, string param)
        {
            var nums = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                nums.Add(i);
            }
            switch (param)
            {
                case "odd":
                    Console.WriteLine(string.Join(" ", nums.Where(n => n%2==1)));
                    break;
                case "even":
                    Console.WriteLine(string.Join(" ", nums.Where(n => n%2==0)));
                    break;
                default:
                    break;
            }

        }
    }
}
