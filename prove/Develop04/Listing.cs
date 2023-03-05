using System;

public class Listing : Activity
{
    private Animation _animation;
    private string _getReadyPrompt;
    List<string> GetReadyPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public Listing(Animation animation)
    {
        _animation = animation;
    }
    public override void SetUp()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.SetUp();
    }
    
    public override void GetReady()
    {
        base.GetReady();
        Get_GetReadyPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {_getReadyPrompt} ---\n");
        Console.Write("You may begin in:  ");
        _animation.RunAnimation(5);
        Console.WriteLine();
    }

    private void Get_GetReadyPrompt()
    {
        Random randomSetUp = new Random();
        int GetReadyPromptIndex = randomSetUp.Next(GetReadyPrompts.Count);
        string selected_GetReadyPrompt = GetReadyPrompts[GetReadyPromptIndex];
        _getReadyPrompt = selected_GetReadyPrompt;
    }

    public override void Start()
    {
        int count = 0;
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(_seconds))
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
    }

    public override void DisplayEndMessage()
    {
        base.DisplayEndMessage();
        Console.WriteLine($"You have completed at least {_seconds} seconds of the Listing Activity.");
        Thread.Sleep(4000);
    }
}