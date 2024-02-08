using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string userEntry = Console.ReadLine();
        _duration = int.Parse(userEntry);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
       
    }

    public void ShowSpinner()
    {
        List<string> symbols = new List<string>();
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string item = symbols[i];
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= symbols.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}