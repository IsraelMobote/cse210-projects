using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and breathing out slowly, clear your mind and focus on your breathing";
    }
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (startTime < endTime)
        {
            Console.WriteLine();
            Console.Write("Breadth in...");
            ShowCountDown(4);
            Console.Write("Now Breadth out...");
            ShowCountDown(6);

            startTime = DateTime.Now;

        }


    }
}