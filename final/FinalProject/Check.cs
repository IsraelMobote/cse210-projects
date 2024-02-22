using System;

public abstract class Check
{
    private int _totalPercentage;
    private List<string> _foodProducts;

    public Check()
    {

    }

    public abstract void  Run();

    public abstract void PerformCheck();
    public void DisplayEndMessage()
    {

    }
    public abstract void RecordEvent();
    public void ShowSpinner()
    {

    }

    public abstract string GetHistory(int number);
     
}