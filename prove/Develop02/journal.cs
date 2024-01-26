
using System.IO;
using System.Runtime.CompilerServices;



public class Journal
{
    Entry entry = new Entry();
    public string[] _journal = {};

    string file = @"C:\Users\user\Documents\cse210-projects\cse210-projects\prove\Develop02\myjournal.txt";
    string file2 = @"C:\Users\user\Documents\cse210-projects\cse210-projects\prove\Develop02";
    
    public void AddNewEntries(string date, string prompt, string entry, int specialNumber)
    {
        
        if (specialNumber == 0)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                
                
                outputFile.WriteLine(date);
                outputFile.WriteLine(prompt);
                outputFile.Write("> ");
                outputFile.WriteLine(entry);
                outputFile.WriteLine(">>>");

            }

        }

        else
        {
            using (StreamWriter outputFile = File.AppendText(file))
            {
                
                
                outputFile.WriteLine(date);
                outputFile.WriteLine(prompt);
                outputFile.Write("> ");
                outputFile.WriteLine(entry);
                outputFile.WriteLine(">>>");

            }


        }
        
       
    }

    public void DisplayAll()
    {
        string lines = System.IO.File.ReadAllText(file);
        _journal = lines.Split(">>>");
        foreach (string item in _journal)
        {
            Entry entry = new Entry();
            entry.Display(item);
        }
    }

    public void SaveToFile(string fileName)
    {
        
        string lines = System.IO.File.ReadAllText(file);
        string[] paths = {file2, fileName};
        string fullPath = Path.Combine(paths);

        using (StreamWriter outputFile = new StreamWriter(fullPath))
        {
            outputFile.WriteLine(lines);
            
        }
        


    }

    public void LoadFromFile(string fileName)
    {
        string[] paths = {file2, fileName};
        string fullpath = Path.Combine(paths);
        string lines = System.IO.File.ReadAllText(fullpath);
        _journal = lines.Split(">>>");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(lines);
            
        }

    }
    
}