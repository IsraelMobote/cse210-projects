public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
   

    public void Display(string entry)
    {
        Console.WriteLine(entry.Trim());
    }
}