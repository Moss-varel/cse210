class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        _isComplete = false;
    }
    
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }
    
    public override string GetStatus() => _isComplete ? "[X]" : "[ ]";
}