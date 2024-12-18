﻿namespace DiscoverParallel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Parallel.ForEach(numbers, number =>
        {
            Console.WriteLine("Processing on " + number);
        });
    }
}