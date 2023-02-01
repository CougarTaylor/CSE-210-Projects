using System;


public class Journal
{
    public void Display()
    {
        foreach(Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._userInput}\n");
        }
    }

    public List<Entry> entries = new List<Entry>();
    
}