using System;
using System.Collections.Generic;

namespace MindfulnessApp.Models;
public class ListingActivity : MindfulnessActivity
{
    public ListingActivity() : base("Listing Activity", "List positive experiences or things you are grateful for.")
    {
    }

    protected override void PerformActivity()
    {
        List<string> responses = new();
        Console.WriteLine("\nList as many things as you can in 10 seconds...");

        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items. Well done!");
    }
}
