
using System;




public class Scripture
{
    private Reference _reference;
    private string[] _words;

    private string _text = "";
    bool value = true;
   

    public Scripture(Reference reference, string text)
    {
        _text = text;
        _words = _text.Split(" ");
       
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        int number = 0;
        _words = _text.Split(" ");

        while (number< _words.Count())
        {
           Word newWord = new Word(_words[number]);
           newWord.Hide();
           _words[number] = newWord.GetDisplayText();

            if ((number+1) < _words.Count())
            {
                Word newWord2 = new Word(_words[number]);
                newWord2.Hide();
                _words[number+1] = newWord2.GetDisplayText();
            }
          
           number = number + numberToHide;
        }
    }

    public void GetDisplayText()
    {
        Console.Write($"{_reference.GetDisplayText()}  ");
        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
    }

    public bool IsCompletelyHidden()
    {
        int n = 0;
       

        foreach (string word in _words)
        {
            
            Word newWord = new Word(word);

            if (word == "__________")
            {
                n++;
            }

            if (n == _words.Count())
            {
                value = newWord.IsHidden();
            }
        }
        return value;
    }

}

