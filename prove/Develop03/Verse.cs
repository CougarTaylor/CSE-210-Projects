using System;

public class Verse
{
    public List<Word> words = new List<Word>();
    private string _Title;
    public int _count = 0;
    public int _maxCount = 1;
    private bool _DidGoBack = true;
    private int _wordIndex;


    public Verse(string scripture)
    {
        string[] FirstSplit = scripture.Split("[");
        _Title = FirstSplit[0];
        string[] WordArray = FirstSplit[1].Split(" ");
        foreach (string currentWord in WordArray)
        {
            words.Add(new Word(currentWord));
        }
    }

    public void DisplayVerse()
    {
        Console.Write(_Title);
        foreach (Word word in words)
        {
            word.DisplayWord();
        }
    }

    public void HideWord()
    {
        _maxCount = words.Count;
        Random random = new Random();
        while (true)
        {
            _wordIndex = random.Next(words.Count);
            if (words[_wordIndex]._IsVisible == true)
            {
                _count ++;
                _DidGoBack = false;
                words[_wordIndex].Hide();
                break;
            }
        }
    }
    public void ShowWord()
    {
        if (_DidGoBack == false && _count > 0)
        {
            words[_wordIndex].Show();
            _count -= 1;
            _DidGoBack = true;
        }
    }

}