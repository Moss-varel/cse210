using System;
using System.Collections.Generic;
using System.IO;
using EternalQuest;
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _filePath = "goals.txt";

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].RecordEvent();
            Console.WriteLine("Goal recorded! New score: " + _score);
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}:{goal.GetName()}:{((Goal)goal)._points}");
            }
        }
    }

    public void LoadGoals()
    {
        if (!File.Exists(_filePath)) return;

        string[] lines = File.ReadAllLines(_filePath);
        _score = int.Parse(lines[0]);

        foreach (string line in lines[1..])
        {
            string[] parts = line.Split(':');
            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
        }
    }
}