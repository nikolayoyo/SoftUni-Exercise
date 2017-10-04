using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Program
    { 
        static void Main(string[] args)
        {
            var myDic = new Dictionary<string, string>();
            var input = Console.ReadLine()
                .Split('-');
            while (input[0]!="search")
            {
                myDic[input[0]] = input[1];
                input = Console.ReadLine()
                .Split('-');
            }

            var searchName = Console.ReadLine();
            while (searchName!="stop")
            {
                if (myDic.ContainsKey(searchName))
                {
                    Console.WriteLine($"{searchName} -> {myDic[searchName]}");
                }
                else
                {
                    Console.WriteLine($"Contact {searchName} does not exist.");
                }

                searchName = Console.ReadLine();
            }
        }
    }
}
