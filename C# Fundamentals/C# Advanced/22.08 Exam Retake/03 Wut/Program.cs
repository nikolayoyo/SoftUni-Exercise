using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Wut
{
    class Program
    {
        public static int MaximumCapacity = int.Parse(Console.ReadLine());
        public static Queue<Bunker> Bunkers = new Queue<Bunker>();
        static void Main(string[] args)
        {
            string rawInput;
            while ((rawInput = Console.ReadLine())!= "Bunker Revision")
            {
                var tokens = rawInput.Split();
                foreach (var token in tokens)
                {
                    int weapon;
                    var isIsNumber = int.TryParse(token, out weapon);
                    if (isIsNumber)
                    {
                        if (Bunkers.Count==1)
                        {
                            SingleBunkerLogic(weapon);
                        }
                        else if (Bunkers.Count>1)
                        {
                            MultiplyBunkersLogic(weapon);
                        }
                    }
                    else
                    {
                        Bunkers.Enqueue(new Bunker()
                        {
                            Name = token,
                            WeaponsStored = new Queue<int>()
                        });
                    }
                }
                
            }
        }

        private static void MultiplyBunkersLogic(int weapon)
        {
            var currentBunker = Bunkers.Peek();
            if (currentBunker.CurrentStatus+weapon<=MaximumCapacity)
            {
                currentBunker.AddWeapon(weapon);
            }
            else
            {
                PrintBunker(currentBunker);
                Bunkers.Dequeue();
                currentBunker = Bunkers.Peek();
                if (Bunkers.Count>1)
                {
                    MultiplyBunkersLogic(weapon);
                }
                else
                {
                    SingleBunkerLogic(weapon);
                }
            }
        }

        private static void PrintBunker(Bunker currentBunker)
        {
            if (currentBunker.WeaponsStored.Count!=0)
            {
                Console.WriteLine($"{currentBunker.Name} -> {string.Join(", ", currentBunker.WeaponsStored)}");
            }
            else
            {
                Console.WriteLine($"{currentBunker.Name} -> Empty");

            }
        }

        private static void SingleBunkerLogic(int weapon)
        {
            var currentBunker = Bunkers.Peek();
            if (currentBunker.CurrentStatus+weapon<= MaximumCapacity)
            {
                currentBunker.AddWeapon(weapon);
            }
            else if(weapon> MaximumCapacity)
            {
                return;
            }
            else if (weapon<= MaximumCapacity)
            {
                while (currentBunker.CurrentStatus+weapon>MaximumCapacity)
                {
                    currentBunker.RemoveWeapon();
                }

                if (currentBunker.CurrentStatus+weapon<= MaximumCapacity)
                {
                    currentBunker.AddWeapon(weapon);
                }
            }
        }
    }

    class Bunker
    {
        public string Name { get; set; }
        public int CurrentStatus { get; set; }
        public Queue<int> WeaponsStored { get; set; }

        public void AddWeapon(int weapon)
        {
            WeaponsStored.Enqueue(weapon);
            CurrentStatus += weapon;
        }

        public void RemoveWeapon()
        {
            CurrentStatus-= WeaponsStored.Dequeue();
        }
    }
}                       
