using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<String> _prompts = new List<string>();

    public string Display()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        string prompt = _prompts[number];

        return prompt;

    }
   

    
    
    
    
    
     

    
}

