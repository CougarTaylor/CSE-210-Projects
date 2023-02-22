using System;

public class Scripture
{
    private string _Title;
    public string _text;
    public int _count = 0;
    public int _maxCount = 1;
    private Verse verse;
    public Scripture(string scriptureText)
    {
        string[] FirstSplit = scriptureText.Split("[");
        _Title = FirstSplit[0];
        _text = FirstSplit[1];
        CreateVerse(_text);
    }

    public void CreateVerse(string text)
    {
        verse = new Verse(text);

    }

    public void DisplayVerse()
    {
        verse.DisplayVerse(_Title);
    }

    public void HideWord()
    {
        verse.HideWord();
        _count = verse._count;
        _maxCount = verse._maxCount;
    }
    public void ShowWord()
    {
        verse.ShowWord();
        _count = verse._count;
    }
}