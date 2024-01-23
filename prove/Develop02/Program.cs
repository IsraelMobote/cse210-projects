using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Journal program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Dislay");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        int response = -1;
        

        Console.Write("What would you like to do (type in the number!! corresponding to your choice) ? ");
        response = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today? ");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");

        while (response != 0)
        {
            if (response == 1)
            {
                Journal Journal = new Journal();
                entry._promptText = promptGenerator.Display();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                
                Journal.AddNewEntries(entry._date, entry._promptText, entry._entryText);
                response = 0;

            
            }
        }
        


    }
}