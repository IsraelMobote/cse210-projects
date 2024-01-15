using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of nmubers, type 0 when finished");
        
        int number = 1;
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string valueInText = Console.ReadLine();
            number = int.Parse(valueInText);
            numbers.Add(number);
        }
        int result = numbers.Sum();
        Console.WriteLine($"The sum is: {result}");
        int totalNumber = numbers.Count;
        float average = (float)result / totalNumber;
        Console.WriteLine($"The average is: {average}");
        number = -11122554;
    
        foreach (int numb in numbers)
        {
            if (numb > number)
            {
                number = numb;

            }
        }

        Console.WriteLine($"The Largest number is: {number}");
        
    }
}

