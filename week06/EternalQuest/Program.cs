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
                    manager.AddGoal(new SimpleGoal(name, points));
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
