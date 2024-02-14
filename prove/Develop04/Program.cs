// To exceed requirements, I added some lines of codes in my ReflectingActivity class and in the Listing
//Activity class. I added these lines of code to make sure the questions and the prompts in the reflecting
// and Listing Activity do not repeat themselves to the user until all other questions/prompts have been 
//dislayed

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
                Console.WriteLine("Get ready.... ");
                process1.ShowSpinner(1);
                process1.Run();

                Console.WriteLine();
                process1.DisplayEndingMessage();
                
                Console.Clear();    
            }

            if (userEntryNo == 2)
            {
                Console.Clear();
                ReflectingActivity process2 = new ReflectingActivity();
                process2.DisplayStartingMessage();
                Console.WriteLine("Get ready.... ");
                process2.ShowSpinner(1);

                // all the features of the breathing activity are abstracted inside the 
                // BreathingActivity class and they will run when the Run() method in the class is called
                process2.Run();

                Console.WriteLine();
                process2.DisplayEndingMessage();

                Console.Clear();
            }


            if (userEntryNo == 3)
            {
                Console.Clear();
                ListingActivity process3 = new ListingActivity();
                process3.DisplayStartingMessage();
                Console.WriteLine("Get ready.... ");
                process3.ShowSpinner(1);

                process3.Run();

                Console.WriteLine();
                process3.DisplayEndingMessage();
                
                Console.Clear();  
            }

            if (userEntryNo == 4)
            {
                endProgram = false;
            }

        }

    }
}