using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();
        
        while (true)
        {
            Console.WriteLine("\n1. Add Goal\n2. Record Event\n3. Show Goals\n4. Save & Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Goal Type (1-Simple, 2-Eternal, 3-Checklist): ");
                    int type = int.Parse(Console.ReadLine());
                    
                    if (type == 1)
                        manager.AddGoal(new SimpleGoal(name, points));
                    else if (type == 2)
                        manager.AddGoal(new EternalGoal(name, points));
                    else if (type == 3)
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, points, targetCount, bonus));
                    }
                    break;
                case "2":
                    manager.ShowGoals();
                    Console.Write("Select goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoal(index);
                    break;
                case "3":
                    manager.ShowGoals();
                    break;
                case "4":
                    manager.SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
