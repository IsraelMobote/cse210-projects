using System;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _text = "__________";
    }

    
    public string GetDisplayText()
    {
        return _text;
    }

    public bool IsHidden()
    {
        bool value = _isHidden;
        return value;
    }
}