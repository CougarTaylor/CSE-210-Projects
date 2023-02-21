using System;

public class Word
{
    private string _text;
    private string _textTemp;
    public bool _IsVisible;


    public Word(string text)
    {
        _text = text;
        _IsVisible = true;
    }
    
    public void Hide()
    {
        _textTemp = _text;
        int flow = _text.Count();
        _text = "";
        for (int i = 0; i < flow; i ++)
        {
            _text += "_";
        }
        _IsVisible = false;
    }
    public void Show()
    {
        _text = _textTemp;
        _IsVisible = true;
    }
    public void DisplayWord()
    {
        Console.Write(_text + " ");
    }
}