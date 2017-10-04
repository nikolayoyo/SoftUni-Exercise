using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var myJaggedStuff = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                myJaggedStuff[i] = input.Where(x =>Math.Abs(x % 3) == i).ToArray();
            }

            foreach (var row in myJaggedStuff)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
