using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected int _points;
    
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }
    
    public abstract int RecordEvent(); // Polymorphic behavior for completion
    public abstract string GetStatus(); // Display goal status
    public string GetName() => _name;
}