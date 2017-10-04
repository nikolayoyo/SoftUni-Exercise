using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new SortedSet<string>();
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0]!= "END")
            {
                if (input[0] =="IN")
                {
                    mySet.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    mySet.Remove(input[1]);
                }

                input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (mySet.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in mySet)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
