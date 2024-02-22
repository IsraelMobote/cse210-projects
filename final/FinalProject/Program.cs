using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        CheckManager p1 = new CheckManager();
        int responseNo = p1.Start();

        if (responseNo == 1)
        {
            p1.ListChecks();
        }
    }
}