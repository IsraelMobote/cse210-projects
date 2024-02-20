using System;

public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        bool boll = true;
        return boll;
    }

    public override string GetStringRepresentation()
    {
        string stringg = "";
        return stringg;
    }
}