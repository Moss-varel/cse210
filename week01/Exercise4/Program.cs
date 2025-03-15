using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Ask the user for numbers and add them to the list
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; // Stop if the user enters 0
            }

            numbers.Add(number); // Add the number to the list
        }

        // Core Requirements

        // Compute the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find the maximum number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge

        // Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}