// To exceed requirements in the program. I put in another option for the user to make entering entries easy
// which is the 'Find-Entries option in the program to inform the user how many entries they have recorded and help them 
// find a specific entry by inputing the number of the entry.



using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the Journal program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Dislay");
        Console.WriteLine("3. Find-entries");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Quit");
        Console.WriteLine("");
        int response = -1;
        int specialNumber = 0;
        
        while (response != 0)
        {
            Console.Write("What would you like to do (type in the number!! corresponding to your choice) ? ");
            response = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Entry entry = new Entry();
            DateTime theCurrentTime = DateTime.Now;
            entry._date = theCurrentTime.ToShortDateString();

            if (response == 1)
            {
                Journal Journal = new Journal();
                PromptGenerator PromptGenerator = new PromptGenerator();
                entry._promptText = PromptGenerator.Display();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                
                Journal.AddNewEntries(entry._date, entry._promptText, entry._entryText, specialNumber);
                specialNumber++;
            
            }

            else if (response == 2)
            {
                Journal Journal = new Journal();
                Journal.DisplayAll();

            }

            else if (response == 3)
            {
                if (specialNumber == 0)
                {
                    Console.WriteLine("You have 0 entries in the journal");
                }

                else if (specialNumber > 0)
                {
                    Journal Journal =new Journal();
                    Journal.LoadFromFile("myjournal.txt");
                    int totalEntries = Journal._journal.Count() - 1;
                    Console.WriteLine($"You have {totalEntries} entries in the journal");
                    Console.WriteLine($"What entry will you love to see(type in!! only the number of the entry)");
                    Console.Write("> ");
                    int entryNumber = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine((Journal._journal[entryNumber]).Trim());

                }

            }

            else if (response == 4)
            {
                Journal Journal = new Journal();
                Console.WriteLine("What did you want to name the file that ");
                Console.WriteLine("your Journal entries will be saved to.");
                Console.Write("> ");
                string savedFile = Console.ReadLine();
                Journal.SaveToFile(savedFile);

            }

            else if (response == 5)
            {
                Journal journal = new Journal();
                Console.WriteLine("What is the name of the file that you want to");
                Console.WriteLine("load journal entries from");
                Console.Write("> ");
                string loadedFile = Console.ReadLine();
                journal.LoadFromFile(loadedFile);

                specialNumber++;

            }

            else if (response == 6)
            {
                Console.WriteLine("Thankyou! for using the journal program, have a nice day");
                response = 0;
            }

            

        }

    }
        
}