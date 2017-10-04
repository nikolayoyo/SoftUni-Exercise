using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static List<int> MagicNature = new List<int>();
        public static Queue<int> flowers = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        public static Stack<int> buckets = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        public static int currentFlower;
        public static int currentBucket;
        static void Main(string[] args)
        {
            while (CheckCount())
            {
                currentFlower += flowers.Dequeue();
                currentBucket += buckets.Pop();
                if (currentFlower > currentBucket)
                {
                    GreaterFlowerThanBucket();
                }
                else if (currentBucket>currentFlower)
                {
                    GreaterBucketThanFlower();
                }
                else if (currentFlower==currentBucket)
                {
                    Bloom();
                }
            }
            
            if (buckets.Count ==0)
            {
                if (currentFlower!=0)
                {
                    Console.WriteLine($"{currentFlower+flowers.Dequeue()} {string.Join(" ", flowers)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join(" ", flowers)}");

                }
            }
            else
            {
                if (currentBucket != 0)
                {
                    Console.WriteLine($"{currentBucket + buckets.Pop()} {string.Join(" ", buckets)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join(" ", buckets)}");

                }
            }

            if (MagicNature.Count!=0)
            {
                Console.WriteLine(string.Join(" ", MagicNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        private static void GreaterFlowerThanBucket()
        {
            if (ShouldReturn())
            {
                return;
            }
            currentFlower -= currentBucket;         
            currentBucket = buckets.Pop();
            if (currentFlower> currentBucket)
            {
                GreaterFlowerThanBucket();
            }
            else if (currentFlower< currentBucket)
            {
                GreaterBucketThanFlower();
            }
            else if (currentFlower == currentBucket)
            {
                Bloom();
            }

        }

        private static void Bloom()
        {
            MagicNature.Add(currentFlower);

            currentFlower = 0;
            currentBucket = 0;
        }

        private static void GreaterBucketThanFlower()
        {
            currentBucket -= currentFlower;

            currentFlower = 0;
        }

        private static bool CheckCount()
        {
            return (flowers.Count > 0 && buckets.Count > 0);
        }

        private static bool ShouldReturn()
        {
            return (currentBucket != 0 && currentFlower != 0);
        }

        private static void TryToPop()
        {
            if (buckets.Count!=0)
            {

            }
        }
    }
}
