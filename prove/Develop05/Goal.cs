using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        bool boll = true;
        return boll;
    }

    public virtual string GetDetailsString()
    {
        string stringg = "";
        return stringg;
    }

    
    public virtual string GetStringRepresentation()
    {
        string stringg = "";
        return stringg;
    }
 
}