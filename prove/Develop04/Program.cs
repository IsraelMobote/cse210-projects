using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool endProgram = true;


        while (endProgram == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. quit");
            Console.Write("Select a choice from the menu: ");
            string userEntry = Console.ReadLine();
            int userEntryNo = int.Parse(userEntry);

       
        
            if (userEntryNo == 1)
            {
                Console.Clear();
                BreathingActivity process1 = new BreathingActivity();
                process1.DisplayStartingMessage();
                Console.WriteLine("Get ready ");
                process1.ShowSpinner();
               
                
            }

            if (userEntryNo == 2)
            {
                Console.Clear();
            }

            if (userEntryNo == 3)
            {
                Console.Clear();
            }

            if (userEntryNo == 4)
            {
                endProgram = false;
            }

        }

    }
}