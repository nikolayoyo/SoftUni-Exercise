using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var userList = new Dictionary<string, User>();
            while (input[0] != "end")
            {
                var userName = input[2].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var ip = input[0].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1];
                if (!userList.ContainsKey(userName))
                {
                    var newUser = new User()
                    {
                        Name = userName,
                        ipCounter = new Dictionary<string, int>()
                    };
                    newUser.ipCounter[ip] = 0;
                    userList[userName] = newUser;
                }

                if (!userList[userName].ipCounter.ContainsKey(ip))
                {
                    userList[userName].ipCounter[ip] = 0;
                }

                userList[userName].ipCounter[ip]++;
                input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var user in userList.OrderBy(x=> x.Key))
            {
                var stringBuild = new StringBuilder();
                Console.WriteLine($"{user.Key}:");
                foreach (var item in user.Value.ipCounter)
                {
                    stringBuild.Append($"{item.Key} => {item.Value}, ");
                }
                stringBuild.Remove(stringBuild.Length - 2, 2);
                Console.WriteLine($"{stringBuild.ToString()}.");
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public Dictionary<string, int> ipCounter { get; set; }
    }
}
