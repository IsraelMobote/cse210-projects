using System;
using System.IO;


public class GoalManager
{
    private int _score;

    private List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine();
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        // this is the delete feature which I put in to exceed requirements
        Console.WriteLine("   6. Delete Goal");
        Console.WriteLine("   7. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have got {_score} points ");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        int n = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{n}. {goal.GetDetailsString()}");
            n++;
        }
    }

    public void CreateGoal()
    {
        Console.Write("Which type of goal would you like to create: ");
        string response2 = Console.ReadLine();
        int response2No = int.Parse(response2);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated for this goal? ");
        string points = Console.ReadLine();
        int pointsNum = int.Parse(points);

        if (response2No == 1)
        {
            SimpleGoal g1 = new SimpleGoal(goalName,goalDescription,pointsNum);
            _goals.Add(g1);
        }
        else if (response2No == 2)
        {
            EternalGoal g2 = new EternalGoal(goalName,goalDescription,pointsNum);
            _goals.Add(g2);
        }
        else if (response2No == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string timesForBonus = Console.ReadLine();
            int timesForBonusNum = int.Parse(timesForBonus);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            int bonusNum = int.Parse(points);

            ChecklistGoal g3 = new ChecklistGoal(goalName,goalDescription,pointsNum,timesForBonusNum,bonusNum);
            _goals.Add(g3);
        }
    }

    public void RecordEvent()
    {
        int n = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{n}. {goal.Get_shortName()}");
            n++;
           
        }
        Console.WriteLine("Which goal did you accomplish? ");
        string response = Console.ReadLine();
        int responseNo = int.Parse(response);
        int totalPoint = _goals[responseNo - 1].RecordEvent();
        _score = _score + totalPoint;
        Console.WriteLine($"You now have {_score}");

        
    }

    public void DeleteGoal(int number)
    {
        _goals.RemoveAt(number - 1);
    }
    public void SaveGoals(string filename)
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string text = goal.GetStringRepresentation();
                outputFile.WriteLine(text);
            }
        }
        
    }
    
    public void LoadGoals(string file)
    {
      
       string[] lines = System.IO.File.ReadAllLines(file);
       
       _score = int.Parse(lines[0]);

       string[] lines2 = System.IO.File.ReadAllLines(file).Skip(1).ToArray();
       foreach (string line in lines2)
       {
            string[] paths = line.Split(":");
            // input is the variable that stores the type of goal
            string input = paths[0];
            //text is the variable that stores the attributes of the goal
            string text = paths[1];
            
            string[] paths2 = text.Split(",");

            if (input.Trim() == "SimpleGoal")
            {
                SimpleGoal c1 = new SimpleGoal(paths2[0],paths2[1],int.Parse(paths2[2]));
                if (paths2[3] == "True")
                {
                    c1.Set_isComplete();
                }
                _goals.Add(c1);
            }

            else if (input == "EternalGoal")
            {
                    EternalGoal c2 = new EternalGoal(paths2[0],paths2[1],int.Parse(paths2[2]));
                    _goals.Add(c2);
            }

            if (input == "ChecklistGoal")
            {
                ChecklistGoal c3 = new ChecklistGoal(paths2[0],paths2[1],int.Parse(paths2[2]),int.Parse(paths2[4]),int.Parse(paths2[3]));
                int num = int.Parse(paths2[5]);
                c3.Set_amountCompleted(num);
                _goals.Add(c3);
            }
       }
       

       
    }

}