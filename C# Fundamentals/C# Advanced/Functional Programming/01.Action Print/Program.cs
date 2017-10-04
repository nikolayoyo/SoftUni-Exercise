using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(Console.ReadLine()
             .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static void Print(ICollection<string> message)
        {
            foreach (var item in message)
            {
                Console.WriteLine("Sir "+ item);
            }
        }
    }
}
