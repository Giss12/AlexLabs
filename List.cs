using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            List<int> numbers = new List<int>(10);
            for (int i = 0; i < 10; i++)
            {
                parts.Add(rand.Next(0, 10));
            }
            numbers.RemoveAt(3);
            numbers.RemoveAt(5);
            numbers.Add(12);
            numbers.ForEach(Console.WriteLine);
        }
    }
}