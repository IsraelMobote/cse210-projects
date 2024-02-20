using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void Set_amountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int newPoints = _points;

        if (_amountCompleted == _target)
        {
            newPoints = _points + _bonus;
        }
        Console.WriteLine($"Congratulations You have earned {newPoints} points");
        return newPoints;
    }

    public override bool IsComplete()
    {
        bool value = false;
        if (_amountCompleted == _target)
        {
            value = true;
        }

        return value;
    }

    public override string GetDetailsString()
    {
        bool value = IsComplete();
        string goalDetails = "";

        if (value == false)
        {
            goalDetails = $"[ ] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }
        
        else if (value == true)
        {
            goalDetails = $"[X] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }

        return goalDetails;
        
    }

    public override string GetStringRepresentation()
    {
        string text = $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return text;
    }
}