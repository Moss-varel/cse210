using System;
using MindfulnessApp.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Mindfulness App!");
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            MindfulnessActivity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => throw new Exception("Invalid choice. Try again.")
            };

            if (activity == null) break;

            activity.Start();
        }

        Console.WriteLine("Thank you for using the Mindfulness App!");
    }
}
