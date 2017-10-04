using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Email_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDid = new Dictionary<string, string>();
            var name = Console.ReadLine();
            while (name!="stop")
            {
                var mail = Console.ReadLine();
                var lastChars = string.Join("",mail.ToCharArray()
                    .Skip(mail.Length - 2)
                    .Take(2)
                    .ToArray());                    
                if (lastChars!="us" && lastChars!="uk")
                {
                    myDid[name] = mail;
                }

                name = Console.ReadLine();
            }

            foreach (var item in myDid)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
