using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ToxicBunnies
{
    class Program
    {
        public static char[][] field;
        static Player Player;
        static void Main(string[] args)
        {
            Player = new Player();
           
            var fieldSize = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            field = new char[fieldSize[0]][];
            for (int i = 0; i < fieldSize[0]; i++)
            {
                field[i] = Console.ReadLine()
                    .ToCharArray();
                FindPlayerPosition(field[i], i);
            }

            Move(Console.ReadLine().ToCharArray());
        }

        private static void Move(char[] moves)
        {
            foreach (var move in moves)
            {
                var lastPosition = new int[2];
               
                Array.Copy(Player.Position, lastPosition, 2);
                switch (move)
                {
                    case 'U': Player.Position[0] -= 1;
                        break;
                    case 'D': Player.Position[0] += 1;
                        break;
                    case 'L': Player.Position[1] -= 1;
                        break;
                    case 'R': Player.Position[1] += 1;
                        break;
                    default:
                        break;
                }
                BunnySpread();
                if (Player.RanAway)
                {
                    PrintField();
                    Console.WriteLine($"won: {lastPosition[0]} {lastPosition[1]}");
                    break;
                }

                if (Player.Dead)
                {
                    PrintField();
                    Console.WriteLine($"dead: {Player.Position[0]} {Player.Position[1]}");
                    break;
                }
            }
        }

        private static void BunnySpread()
        {
            var bunniesToAdd = new List<int[]>();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j]=='B')
                    {
                        try
                        {
                            var test = field[i][j - 1];
                            bunniesToAdd.Add(new int[2] { i, j - 1 }); 
                        }
                        catch (IndexOutOfRangeException)
                        {                            
                        }

                        try
                        {
                            var test = field[i][j  +1];
                            bunniesToAdd.Add(new int[2] { i, j + 1 });
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            var test = field[i-1][j];
                            bunniesToAdd.Add(new int[2] { i-1 , j });
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            var test = field[i+1][j];
                            bunniesToAdd.Add(new int[2] { i+1, j });
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }

            foreach (var bunny in bunniesToAdd)
            {
                field[bunny[0]][bunny[1]] = 'B';
            }
        }

        private static void PrintField()
        {
            foreach (var line in field)
            {
                Console.WriteLine(string.Join("", line));
            }
        }

        private static void FindPlayerPosition(char[] currentRow, int i)
        {
            if (currentRow.Contains('P'))
            {
                Player.Position = new int[2]
                {
                    i,
                    Array.IndexOf(currentRow, 'P')
                };
                field[i][Player.Position[1]] = '.';
            }
       
        }
    }

    class Player
    {
        public int[] Position { get; set; }
        public bool RanAway
        {
            get
            {
                try
                {
                    var tester = Program.field[Position[0]][Position[1]];
                    return false;
                }
                catch (IndexOutOfRangeException)
                {

                    return true;
                }
            }
        }
        public bool Dead
        {
            get
            {
                if (Program.field[Position[0]][Position[1]] =='B')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
