using System;
using System.Collections.Generic;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display all the values 
            List<int> ValueList = test(new List<int>(new int[] { 10, 20, 35, 65, 53, 48, 5, 1 }));

            foreach (var i in ValueList)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> test(List<int> nums)
        {
            //Condition to remove all integers ending with 5
            return nums.Where(n => n % 10 < 5).ToList();
        }
    }
}