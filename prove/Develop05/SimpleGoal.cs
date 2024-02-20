using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations You have earned {_points} points");
        Set_isComplete();
        return _points;
        
    }

    public void Set_isComplete()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return  _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string text = $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        return text;
    }
}