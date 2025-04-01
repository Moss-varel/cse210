namespace MindfulnessApp.Models;
public abstract class MindfulnessActivity
{
    protected string Name { get; }
    protected string Description { get; }

    protected MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
        PerformActivity();
        Console.WriteLine($"\n{Name} completed!");
    }

    protected abstract void PerformActivity();
}
