using System;
using System.Security.Principal;

public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you did something really difficult",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    List<int> numberList = new List<int>();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        string description1 = "This activity will help you reflect on times in your life when you have shown strength and resilence.";
        string description2 =  "This will help you recognise the power you have and how you can use it in other aspects of your life";
        _description = description1 + " " + description2;
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        
        Console.WriteLine(DisplayRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter and continue. ");
        string n = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        Console.Clear();
        // A fresh screen will appear 
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // the while loop will continue until the startTime exceeds the endTime 
        while (DateTime.Now < endTime)
        {
            Console.Write(DisplayRandomQuestions());
            ShowSpinner(0);
        }
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count());
     
        return _prompts[number];
    }

    public string GetRandomQuestion()
    {
// I used the codes below before the return statement to make sure that no question is repeated until
// all the questions have been displayed 
        int number2 = 0;
        bool pass = false;
        while (pass == false)
        {
            Random randomGenerator2 = new Random();
            number2 = randomGenerator2.Next(0, _questions.Count());
       

            if (numberList.Contains(number2) == false)
            {
                numberList.Add(number2);
                pass = true;
            }

            else
            {
                pass = false;
            }

            if (numberList.Count() == _questions.Count())
            {
                numberList.Clear();
            }
        }
            
        return _questions[number2];
    }

    public string DisplayRandomPrompt()
    {
        string prompt = $" ---{GetRandomPrompt()}--- ";
        return prompt;
    }

    public string DisplayRandomQuestions()
    {
        string question = $"> {GetRandomQuestion()}";
        return question;
    }
}