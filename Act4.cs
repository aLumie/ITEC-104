using System;

namespace Activity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("==ARRAY PROGRAM==");
                const int n = 5;
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter Element: ", i + 1);
                    string str = Console.ReadLine();
                    numbers[i] = int.Parse(str);
                }

                Console.Write("\nOdd numbers: ");
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] % 2 == 1)
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();

                Console.Write("Even numbers: ");
                for (int i = 0; i < n; i++)
                {
                    if (numbers[i] % 2 == 0)
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
           
        }
    }
}
