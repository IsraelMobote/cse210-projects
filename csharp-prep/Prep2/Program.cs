using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string valueInText = Console.ReadLine();
        int percentage = int.Parse(valueInText);
        string letterGrade = "";
        Console.WriteLine();
       
        if (percentage >= 90)
        {
            letterGrade = "AR";
        }

        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade leter is {letterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("Well, you didn't pass the course but I'm sure you will do better next time if you put in extra effort");
        }


    }
}