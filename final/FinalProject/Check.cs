using System;

public abstract class Check
{
    protected string _checkName;
    protected float _totalPercentage;
    protected List<string> _foodProducts = new List<string>();
    protected List<string> _recordings = new List<string>();

    public Check()
    {

    }

    public List<string> Get_recordings()
    {
        return _recordings;
    }

    public abstract void  Run();

    public abstract void PerformCheck();
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You consumed {_totalPercentage}% of your required daily Consumption");
        Console.WriteLine();

        if (_totalPercentage > 105)
        {
            Console.WriteLine($"You really need to cut down on your daily {_checkName} consumption");
            Console.WriteLine();
            ShowSpinner();
        }

        else if (_totalPercentage < 95)
        {
            Console.WriteLine($"You really need to increase on your daily {_checkName} consumption");
            Console.WriteLine();
            ShowSpinner();
        }

        else if (_totalPercentage >=95 )
        {
            Console.WriteLine($"Your daily {_checkName} consumption is normal! , Keep up the good work");
            Console.WriteLine();
            ShowSpinner();
        }
       
        Console.WriteLine();
    }
    
    public void ShowSpinner()
    {
        List<string> symbols = new List<string>();
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string item = symbols[i];
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= symbols.Count)
            {
                i = 0;
            }
        }

       
        Console.WriteLine();
        
    }

    public List<string> Get_foodProducts()
    {
        return _foodProducts;
    }

    public abstract void StoreHistory();
     
}