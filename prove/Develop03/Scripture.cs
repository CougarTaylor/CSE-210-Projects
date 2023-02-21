using System;

public class Scripture
{
    public List<Verse> verses = new List<Verse>();


    public Scripture(List<string> verseList)
    {
        foreach (string loader in verseList)
        {
            string[] VerseArray = loader.Split("[");
            foreach (string reference in VerseArray)
            {
                // verses.Add(new Verse(reference)[0]);
            }
        }
    }
    public void ConvertToString()
    {
        foreach(Verse verse in verses)
        {
            // Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            // Console.WriteLine($"{entry._userInput}\n");
        }
    }
    public void HideWord()
    {
        Console.WriteLine("pass");
    }
}