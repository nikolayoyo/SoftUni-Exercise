using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Read_20_s
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstOne = int.Parse(input[0]).ToString("X");
            var secondOne = Convert.ToString(int.Parse(input[0]), 2);
            var thirdOne = double.Parse(input[0]);
            var builder = new StringBuilder();
            builder.Append("|");
            builder.Append(firstOne);
            for (int i = 0; i < 10-firstOne.Length; i++)
            {
                builder.Append(" ");
            }
            builder.Append("|");
            if (secondOne.Length < 10)
            {
                var zerosNeededBySide = (10 - secondOne.Length);
                for (int i = 0; i < zerosNeededBySide; i++)
                {
                    builder.Append("0");
                }
                builder.Append(secondOne);
                
            }
            else if (secondOne.Length==10)
            {
                builder.Append(secondOne);
            }
            else if (secondOne.Length>10)
            {
                var subs = secondOne.Substring(0, 10);
                builder.Append(subs);

            }

            builder.Append("|");
            var parsedSecond = $"{double.Parse(input[1]):F2}";
            for (int i = 0; i < 10-parsedSecond.Length; i++)
            {
                builder.Append(" ");
            }
            builder.Append(parsedSecond);
            builder.Append("|");
            var fourthShit = double.Parse(input[2]);
            builder.Append($"{fourthShit:F3}");
            for (int i = 0; i < 10-fourthShit.ToString().Length; i++)
            {
                builder.Append(" ");
            }
            builder.Append("|");

            Console.WriteLine(builder.ToString());
        }
    }
}
