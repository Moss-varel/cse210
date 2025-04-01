using System;
using System.Collections.Generic;

namespace MindfulnessApp.Models;
public class ReflectionActivity : MindfulnessActivity
{
    private readonly List<string> _prompts = new()
    {
        "Think of a time you felt happy.",
        "Recall a moment you overcame a challenge.",
        "Reflect on a time you helped someone."
    };

    public ReflectionActivity() : base("Reflection Activity", "Think deeply about past experiences.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine("\n" + _prompts[random.Next(_prompts.Count)]);
    }
}
