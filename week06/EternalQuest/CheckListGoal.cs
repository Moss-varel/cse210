class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;
    
    public ChecklistGoal(string name, int points, int targetCount, int bonus)
    {
        Name = name;
        Points = points;
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }
    
    public override int RecordEvent()
    {
        _currentCount++;
        return _currentCount == _targetCount ? Points + _bonus : Points;
    }
    
    public override string GetStatus() => $"[{_currentCount}/{_targetCount}]";
}