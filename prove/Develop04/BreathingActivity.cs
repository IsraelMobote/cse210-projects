using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "BreathingActivity";
        _description = "This activity will help you relax by walking you through breathing in and breathing out slowly, clear your mind and focus on your breathing";
    }
    public void Run()
    {
        Console.Write("Breadth in...");
        Console.Write("Now Breadth out...");
        ShowCountDown(6)

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while ()


    }
}