using System;

public class Reflecting : Activity
{    
    private Animation _animation;
    private string _getReadyPrompt;
    private string _startPrompt;
    List<string> GetReadyPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> StartPrompts = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflecting(Animation animation)
    {
        _animation = animation;
    }
    public override void SetUp()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.SetUp();
    }

    public override void GetReady()
    {
        base.GetReady();
        Get_GetReadyPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_getReadyPrompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:  ");
        _animation.RunAnimation(5);
    }

    public override void Start()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(_seconds))
        {
            Get_StartPrompt();
            Console.Write("-" + _startPrompt + "  ");
            Thread.Sleep(8000);
            Console.WriteLine("");
        }
    }

    private void Get_GetReadyPrompt()
    {
        Random randomSetUp = new Random();
        int GetReadyPromptIndex = randomSetUp.Next(GetReadyPrompts.Count);
        string selected_GetReadyPrompt = GetReadyPrompts[GetReadyPromptIndex];
        _getReadyPrompt = selected_GetReadyPrompt;
    }

    private void Get_StartPrompt()
    {
        Random randomStart = new Random();
        int StartPromptIndex = randomStart.Next(StartPrompts.Count);
        string selected_StartPrompt = StartPrompts[StartPromptIndex];
        _startPrompt = selected_StartPrompt;
    }
    
    public override void DisplayEndMessage()
    {
        base.DisplayEndMessage();
        Console.WriteLine($"You have completed at least {_seconds} seconds of the Reflecting Activity.");
        Thread.Sleep(4000);
    }

}