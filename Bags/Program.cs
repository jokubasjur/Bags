using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initBags = { 100, 100, 100, 100, 110 };
            Random rng = new Random();
            int[] shuffledBags = initBags.OrderBy(b => rng.Next()).ToArray();
            Console.Write("Bags: ");
            PrintBags(shuffledBags);
            FindHeaviestBag(shuffledBags);
        }

        // Bags are splitted into 3 groups of 2, 2, 1
        // If both groups of 2 are equal then 5th bag is the heaviest
        // If not then compare heavier group 
        public static void FindHeaviestBag(int[] bags)
        {
            if (bags[0] + bags[1] == bags[2] + bags[3])
            {
                Console.WriteLine("5th bag is the heaviest: " + bags[4]);
            }
            else if (bags[0] + bags[1] > bags[2] + bags[3])
            {
                if (bags[0] > bags[1])
                {
                    Console.WriteLine("1st bag is the heaviest: " + bags[0]);
                }
                else
                {
                    Console.WriteLine("2nd bag is the heaviest: " + bags[1]);
                }
            }
            else
            {
                if (bags[2] > bags[3])
                {
                    Console.WriteLine("3rd bag is the heaviest: " + bags[2]);
                }
                else
                {
                    Console.WriteLine("4th bag is the heaviest: " + bags[3]);
                }
            }
        }

        public static void PrintBags(int[] bags)
        {
            for (int i = 0; i < bags.Length; i++)
            {
                Console.Write(bags[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
