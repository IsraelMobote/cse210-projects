using System;

class Program
{
    static void Main(string[] args)
    {
       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string valueInText2 = Console.ReadLine();
        int guess = int.Parse(valueInText2);

        int number = 1;

        while (guess != magicNumber)
        {
            number ++ ;
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            
            if (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                valueInText2 = Console.ReadLine();
                guess = int.Parse(valueInText2);

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
            }

        }

        Console.WriteLine($"You made {number} guesses");

    }

}


        
    