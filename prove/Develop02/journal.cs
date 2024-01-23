
using System.IO;


public class Journal
{
    Entry entry = new Entry();
    public List<string> _journal = new List<string>();
    public string _file = "myjournal.txt";
    public void AddNewEntries(string date, string prompt, string entry)
    {
        
        
        using (StreamWriter outputFile = new StreamWriter(_file))
        {
            outputFile.WriteLine("date");
            outputFile.WriteLine(prompt);
            outputFile.WriteLine(entry);

        }
       
    }

    public void DisplayAll(Entry NewEntry)
    {

    }

    public void SaveToFile(string fileName)
    {

    }

    public void LoadFromFile(string fileName)
    {

    }
    
}