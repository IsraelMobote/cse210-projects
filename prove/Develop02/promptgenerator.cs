using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public string[] _prompts = {"Who was the most interesting person I interacted with today? ",
    "What was the best part of my day?",
     "How did I see the hand of the Lord in my life today?",
     "What was the strongest emotion I felt today?",
     "If I had one thing I could do over today, what would it be?",
     "What was the most delicious food you ate today" ,
     "Who was the first person you saw today",
     "What was the one thing you did today that you were most proud of"};
    

    public string Display()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 8);
        string prompt = _prompts[number];

        return prompt;

    }
   

    
    
    
    
    
     

    
}

