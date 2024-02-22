using System;
using System.Dynamic;

public class CheckManager
{

    private List<string> _recordings;
    public int Start()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Begin a Food Check");
        Console.WriteLine("   2. Print History");
        Console.WriteLine("   3. Save History");
        Console.WriteLine("   4. Load History");
        Console.WriteLine("   5. Clear History");
        Console.WriteLine("   6. Quit");
        Console.WriteLine();
        Console.WriteLine("Please type in the number of the menu option you want to proceed! with");
        Console.Write("> ");
        string response = Console.ReadLine();
        int responseNo = int.Parse(response);

        return responseNo;
    }

    public void ListChecks()
    {
        Console.WriteLine();
        Console.WriteLine("The Food Checks are: ");
        Console.WriteLine("   1. CarbsChecks");
        Console.WriteLine("   2. FruitCheck");
        Console.WriteLine("   3. ProteinCheck");
        Console.WriteLine("   4. SaltCheck");
    }


}

