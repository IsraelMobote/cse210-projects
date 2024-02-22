using System;

public class File
{
    private List<string> _recordings = new List<string>();
    public File(List<string> history)
    {
        _recordings = history;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           
            foreach (string line in _recordings)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    public List<string> LoadFromFile(string filename)
    {
        _recordings.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _recordings.Add(line);
        }
        return _recordings;
    }
}