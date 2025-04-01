class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }
    
    public override int RecordEvent() => Points;
    public override string GetStatus() => "[∞]";
}