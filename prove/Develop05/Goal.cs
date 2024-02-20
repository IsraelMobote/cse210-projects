using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    
    public string Get_shortName()
    {
        return _shortName;
    }

    public virtual bool IsComplete()
    {
        bool boll = false;
        return boll;
    }

    public virtual string GetDetailsString()
    {
        bool value = IsComplete();
        string goalDetails = "";

        if (value == false)
        {
            goalDetails = $"[ ] {_shortName} ({_description})";
        }
        else if (value == true)
        {
            goalDetails = $"[X] {_shortName} ({_description})";
        }

        return goalDetails;
    }

    
    public virtual string GetStringRepresentation()
    {
        string text = $"";
        return text;
    }
 
}