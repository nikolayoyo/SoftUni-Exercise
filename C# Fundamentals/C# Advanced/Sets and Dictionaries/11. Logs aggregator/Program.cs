using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var allUsers = new SortedDictionary<string, User>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);
                if (!allUsers.ContainsKey(username))
                {
                    var newUser = new User
                    {
                        Name = username,
                        IPs = new SortedSet<string>()
                    };
                    allUsers[username] = newUser;
                }

                var currentUser = allUsers[username];
                if (!currentUser.IPs.Contains(ip))
                {
                    currentUser.IPs.Add(ip);
                }

                currentUser.Duration += duration;
            }

            foreach (var user in allUsers)
            {
                var ips = string.Join(", ", user.Value.IPs);
                Console.WriteLine($@"{user.Key}: {user.Value.Duration} [{ips}]");
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public SortedSet<string> IPs { get; set; }
    }
}
