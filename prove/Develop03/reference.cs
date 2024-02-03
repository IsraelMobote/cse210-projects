using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    int n = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        n = 1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        n = 2;
    }
   public string GetDisplayText()
    {
        string displayText = "";
        if (n==1)
        {
            displayText = $" {_book} {_chapter}: {_verse}";
        }
        else if (n==2)
        {
            displayText = $" {_book} {_chapter}: {_verse}-{_endVerse}";
        }

        return displayText;
    }

}