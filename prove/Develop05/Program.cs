//I added some lines of code to show creativity. This lines of code enabled to user to choose to delete a particular goal
// from the list by supplying the number of the goal. I put this Delete feature as part of the menu option.
// you can see the menu options in the GoalManager Class.



using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager p1 = new GoalManager();
        int responseNo = 0;
        while (responseNo != 7)
        {

            p1.Start();
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            responseNo = int.Parse(response);


            if (responseNo == 1)
            {
                p1.ListGoalNames();
                p1.CreateGoal();
            }

            if (responseNo == 2)
            {
                Console.WriteLine("The goals are: ");
                Console.WriteLine();
                p1.ListGoalDetails();
            }

            if (responseNo == 3)
            {
                Console.Write("What is the name of the goal file? ");
                string filename = Console.ReadLine();
                p1.SaveGoals(filename);
            }

            if (responseNo == 4)
            {
                Console.Write("What is the name of the goal file you would like to save from? ");
                string filename = Console.ReadLine();
                p1.LoadGoals(filename);
            }

            if (responseNo == 5)
            {
                Console.WriteLine("The goals are: ");
                p1.RecordEvent();
            }

            if (responseNo == 6)
            {
                Console.WriteLine("The goals are: ");
                Console.WriteLine();
                p1.ListGoalDetails();
                Console.WriteLine("Please Input the number of the goal you would like to delete!");
                Console.Write("> ");
                string delNo = Console.ReadLine();
                int delNumber = int.Parse(delNo);
                p1.DeleteGoal(delNumber);

               
            }

        }
    }
}