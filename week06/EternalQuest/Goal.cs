using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public abstract int RecordEvent(); // Method to track completion
    public abstract string GetStatus(); // Display goal status
}