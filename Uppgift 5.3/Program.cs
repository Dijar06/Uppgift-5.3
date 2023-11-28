using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("Skriv in tal nummer " + (i + 1));
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(tal[0] + tal[1] + tal[2]);
        }
    }
}