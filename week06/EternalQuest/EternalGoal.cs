class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}
    
    public override int RecordEvent() => _points;
    public override string GetStatus() => "[∞]";
}