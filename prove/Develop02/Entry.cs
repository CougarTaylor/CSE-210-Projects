using System;

public class Entry
{
    public string _userInput;
    public string _date;
    public string _prompt;

    public void JournalPrompt()
    {
        Console.WriteLine($"{_prompt}");
        _userInput = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
}