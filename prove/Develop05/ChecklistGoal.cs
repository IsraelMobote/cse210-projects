using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        bool boll = true;
        return boll;
    }

    public override string GetDetailsString()
    {
        string stringg = "";
        return stringg;
    }

    public override string GetStringRepresentation()
    {
        string stringg = "";
        return stringg;
    }
}