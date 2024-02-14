using System;

public class ListingActivity : Activity
{
    private int _count = 0;
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<int> numberList = new List<int>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        string description1 = "This activity will help you reflect on the good things in your life by having";
        string description2 = "you list as many things as you can in a certain area";

        _description = description1 + " " + description2;

    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items");
    }

    public string GetRandomPrompt()
    {
        int number = 0;
        bool pass = false;
        while (pass == false)
        {
            Random randomGenerator = new Random();
            number = randomGenerator.Next(0, _prompts.Count());

            if (numberList.Contains(number) == false)
            {
                numberList.Add(number);
                pass = true;
            }

            if (numberList.Count() >= _prompts.Count())
            {
                numberList.Clear();
            }
        }

        return _prompts[number];
     
    }

}