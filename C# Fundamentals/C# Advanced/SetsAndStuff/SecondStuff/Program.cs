using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var vipGuests = new SortedSet<string>();
            var justGuests = new SortedSet<string>();
            var input = Console.ReadLine().ToCharArray();
            while (string.Join("", input)!= "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(string.Join("",input));
                }
                else
                {
                    justGuests.Add(string.Join("", input));
                }

                input = Console.ReadLine().ToCharArray();
            }

            input = Console.ReadLine().ToCharArray();
            while (string.Join("", input)!= "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(string.Join("", input));
                }
                else
                {
                    justGuests.Remove(string.Join("", input));
                }

                input = Console.ReadLine().ToCharArray();
            }

            Console.WriteLine(vipGuests.Count+justGuests.Count);

            if (vipGuests.Count!=0)
            {
                foreach (var item in vipGuests)
                {
                    Console.WriteLine(item);
                }
            }

            if (justGuests.Count!=0)
            {
                foreach (var item in justGuests)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
