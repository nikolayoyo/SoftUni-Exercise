using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Heigan_the_Stripper
{
    class Program
    {
        public static int[,] DanceFiled = new int[15,15];
        public static Player player;
        static void Main(string[] args)
        {
             player = new Player()
            {
                Health = 18500,
                Position = new int[2] {7, 7 },
                Plague = false,
                DamageToHeigan = double.Parse(Console.ReadLine())
            };

            var heiganTheBitch = 3000000.0;

            while (heiganTheBitch > 0 && player.Health > 0)
            {
                var currentSpell = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                heiganTheBitch -= player.DamageToHeigan;
                if (heiganTheBitch<=0)
                {
                    break;
                }
                var spellArea = new HashSet<int[]>();
                var row = int.Parse(currentSpell[1]);
                var col = int.Parse(currentSpell[2]);
                var spell = currentSpell[0];
                for (int i = row-1; i <= row + 1; i++)
                {
                    for (int j = col-1; j <= col + 1; j++)
                    {
                        if (ValidateCell(i,j))
                        {
                            var currentCell = new int[2] { i, j };
                            spellArea.Add(currentCell);
                        }
                    }
                }


                if (!TryToRun(spellArea))
                {
                    if (spell=="Eruption")
                    {
                        player.Health -= 6000;
                        player.LastSpellHit = "Eruption";
                        if (player.Health < 0)
                        {
                            break;
                        }
                        CheckForPlague();

                    }
                    else if (spell== "Cloud")
                    {
                        CheckForPlague();
                        if (player.Health < 0)
                        {
                            break;
                        }
                        player.Health -= 3500;
                        player.Plague = true;
                    }
                }
                else
                {
                    CheckForPlague();
                }
            }

            if (heiganTheBitch<=0)
            {
                Console.WriteLine("Heigan: Defeated!");
                Console.WriteLine($"Player: {player.Health}");
                Console.WriteLine($"Final Position: {player.Position[0]}, {player.Position[1]}");
            }
            else if (player.Health<=0)
            {
                Console.WriteLine($"Heigan {heiganTheBitch:F2}");
                Console.WriteLine($"Player: Killed by {player.LastSpellHit}");
                Console.WriteLine($"Final Position: {player.Position[0]}, {player.Position[1]}");
            }
        }

        public static void CheckForPlague()
        {
            if (player.Plague)
            {
                player.Health -= 3500;
                player.Plague = false;
                player.LastSpellHit = "Cloud";
            }
        }

        

        public static bool ValidateCell(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < 15 && j < 15)
            {
                return true;
            }

            return false;
        }

        public static bool TryToRun(HashSet<int[]> hitArea)
        {
            var moveTry = new int[2];
            Array.Copy(player.Position, moveTry, 2);
            moveTry[0] -= 1;
            if (RunAwayValidation(moveTry,hitArea))
            {
                player.Position[0] = moveTry[0];
                player.Position[1] = moveTry[1];
                return true;
            }

            Array.Copy(player.Position, moveTry, 2);
            moveTry[1] += 1;
            if (RunAwayValidation(moveTry, hitArea))
            {
                player.Position[0] = moveTry[0];
                player.Position[1] = moveTry[1];
                return true;
            }

            Array.Copy(player.Position, moveTry, 2);
            moveTry[0] += 1;
            if (RunAwayValidation(moveTry,hitArea))
            {
                player.Position[0] = moveTry[0];
                player.Position[1] = moveTry[1];
                return true;
            }

            Array.Copy(player.Position, moveTry, 2);
            moveTry[1] -= 1;
            if (RunAwayValidation(moveTry,hitArea))
            {
                player.Position[0] = moveTry[0];
                player.Position[1] = moveTry[1];
                return true;
            }
            return false;
        }

        public static bool RunAwayValidation(int[] moveTry, HashSet<int[]> hitArea)
        {
            if (ValidateCell(moveTry[0], moveTry[1]) && !CompareCells(moveTry, hitArea))
            {
                return true;
            }
            return false;
        }

        public static bool CompareCells(int[] firstOne, HashSet<int[]> cells)
        {
            foreach (var secondOne in cells)
            {
                if (firstOne[0] == secondOne[0] && firstOne[1] == secondOne[1])
                {
                    return true;
                }
            }            
            return false;
        }
       
    }

    public class Player
    {
        public double DamageToHeigan { get; set; }
        public int[] Position { get; set; }
        public bool Plague { get; set; }
        public string LastSpellHit { get; set; }
        public int Health { get; set; }
    }

}
