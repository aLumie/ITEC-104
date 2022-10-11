using System;
using System.Collections.Generic;

namespace Act6 {
    internal class Program
    {
        //User input process 
        public static void Hash(out HashSet<int> HashSets) // adding my own method "Hash"
        {
            HashSets = new HashSet<int>(); // Declaring an int variable
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i + 0} : "); // user input
                HashSets.Add(int.Parse(Console.ReadLine()));
            }
        }
        public static void Main(string[] args) // Declaring the hashsets variable in Main
        {
            Console.WriteLine("HashSet1");
            Hash(out HashSet<int> hashset1); // adding first main variable

            Console.WriteLine("\nHashSet2");
            Hash(out HashSet<int> hashset2); // adding second main variable
            
            //using Join method to concatenate the elements
            Console.WriteLine($"\nUnion: {string.Join(" ", hashset1.Union(hashset2).ToArray())}"); // using join method and union method
            Console.WriteLine($"\nIntersection: {string.Join(" ", hashset1.Intersect(hashset2).ToArray())}"); // using join method and intersect method
            Console.WriteLine($"\nSet Difference: {string.Join(" ", hashset1.Except(hashset2).ToArray())}"); // using join method and except method

            Console.ReadLine();
        }
    }
}
