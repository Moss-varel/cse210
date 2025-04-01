using System;
using System.Threading;

namespace MindfulnessApp.Models;
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Exercise", "Focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < 3; i++) // 3 cycles of breathing
        {
            Console.WriteLine("\nBreathe in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000);
        }
    }
}
