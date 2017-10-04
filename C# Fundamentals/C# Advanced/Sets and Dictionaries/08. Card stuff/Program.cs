using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Card_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            var playrsPoints = new Dictionary<string, Player>();
            while (input[0] != "JOKER")
            {
                var name = input[0];
                var cards = input[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (!playrsPoints.ContainsKey(name))
                {
                    playrsPoints[name] = new Player()
                    {
                        Name = name,
                        Cards = new HashSet<string>()
                    };
                }

                foreach (var card in cards)
                {
                    playrsPoints[name].Cards.Add(card);
                }
                input = Console.ReadLine().Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var player in playrsPoints)
            {
                Console.WriteLine($"{player.Value.Name}: {player.Value.Points}");
            }
        }


    }

    public class Player
    {
        public string Name { get; set; }
        public HashSet<string> Cards { get; set; }
        public int Points
        {
            get
            {
                return PointsCounter(Cards);
            }
        }

        public static int PaintCalculate(int firstSign, char secondSign)
        {
            var s = 4;
            var h = 3;
            var d = 2;
            var c = 1;
            if (firstSign==1)
            {
                firstSign = 10;
            }
            if (secondSign == 'C')
            {
                return firstSign * c;
            }
            else if (secondSign == 'S')
            {
                return firstSign * s;
            }
            else if (secondSign == 'H')
            {
                return firstSign * h;
            }
            else
            {
                return firstSign * d;
            }
        }

        public static int PointsCounter(ICollection<string> cards)
        {
            var sum = 0;
            var j = 11;
            var q = 12;
            var k = 13;
            var a = 14;
            foreach (var card in cards)
            {
                int firstSign;
                var isDigit = int.TryParse(card[0].ToString(), out firstSign);
                var secondSign = card.Last();               
                if (isDigit)
                {
                    sum += PaintCalculate(firstSign, secondSign);
                }
                else
                {
                    if (card[0] == 'A')
                    {
                        sum += PaintCalculate(14, secondSign);
                    }
                    else if (card[0] == 'J')
                    {
                        sum += PaintCalculate(11, secondSign);
                    }
                    else if (card[0] == 'K')
                    {
                        sum += PaintCalculate(13, secondSign);
                    }
                    else
                    {
                        sum += PaintCalculate(12, secondSign);
                    }
                }
            }

            return sum;
        }
    }
}
