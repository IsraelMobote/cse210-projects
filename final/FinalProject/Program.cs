using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int responseNo = 0;
        List<string> recordings = new List<string>();

        while (responseNo != 6)
        {
            Console.WriteLine();
            CheckManager p1 = new CheckManager();
            responseNo = p1.Start();


            if (responseNo == 1)
            {
                p1.ListChecks();
                Console.WriteLine("Please type in the number of the foodCheck you would like to start! ");
                Console.Write("> ");
                string response2 = Console.ReadLine();
                int responseNo2 = int.Parse(response2);

                if (responseNo2 == 1)
                {
                    CarbsCheck c1 = new CarbsCheck();

                    c1.Run();
                    c1.PerformCheck();
                    c1.ShowSpinner();
                    c1.DisplayEndMessage();
                    c1.StoreHistory();

                    List<string> recordings1 = c1.Get_recordings();
                    recordings.Add(" ");

                    foreach (string line in recordings1)
                    {
                        recordings.Add(line);
                    }

                }

                else if (responseNo2 == 2)
                {
                    FruitCheck c2 = new FruitCheck();

                    c2.Run();
                    c2.PerformCheck();
                    c2.ShowSpinner();
                    c2.DisplayEndMessage();
                    c2.StoreHistory();

                    List<string> recordings1 = c2.Get_recordings();
                    recordings.Add(" ");

                    foreach (string line in recordings1)
                    {
                        recordings.Add(line);
                    }

                }

                else if (responseNo2 == 3)
                {
                    ProteinCheck c3 = new ProteinCheck();

                    c3.Run();
                    c3.PerformCheck();
                    c3.ShowSpinner();
                    c3.DisplayEndMessage();
                    c3.StoreHistory();

                    List<string> recordings1 = c3.Get_recordings();
                    recordings.Add(" ");

                    foreach (string line in recordings1)
                    {
                        recordings.Add(line);
                    }

                }

                else if (responseNo2 == 4)
                {
                    SodiumCheck c4 = new SodiumCheck();

                    c4.Run();
                    c4.PerformCheck();
                    c4.ShowSpinner();
                    c4.DisplayEndMessage();
                    c4.StoreHistory();

                    List<string> recordings1 = c4.Get_recordings();
                    recordings.Add(" ");

                    foreach (string line in recordings1)
                    {
                        recordings.Add(line);
                    }

                }

                Console.Clear();

            }

            else if (responseNo == 2)
            {
                if (recordings.Count() == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have no entry in History");
                }

                foreach (string text in recordings)
                {
                    Console.WriteLine(text);  
                }
                CarbsCheck n1 = new CarbsCheck();
                n1.ShowSpinner();
                Console.Clear();

            }

            else if (responseNo == 3)
            {
                Console.Write("What is the name of the file you would like to save History! to? ");
                string filename = Console.ReadLine();
                File f1 = new File(recordings);
                f1.SaveToFile(filename);

                CarbsCheck n1 = new CarbsCheck();
                n1.ShowSpinner();
                Console.Clear();

            }

            else if (responseNo == 4)
            {
                Console.Write("What is the name of the file you would like to load History! from? ");
                string filename = Console.ReadLine();
                File f2 = new File(recordings);
                recordings = f2.LoadFromFile(filename);

                CarbsCheck n1 = new CarbsCheck();
                n1.ShowSpinner();
                Console.Clear();
            }

            else if (responseNo == 5)
            {
                recordings.Clear();

                CarbsCheck n1 = new CarbsCheck();
                n1.ShowSpinner();
                Console.Clear();
            }
        }
    }
}