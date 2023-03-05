using System;

public class Breathing : Activity
{
    private Animation _animation;

    public Breathing(Animation animation)
    {
        _animation = animation;
    }

    public override void SetUp()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly,  Clear your mind and focus on your breathing.");
        base.SetUp();
    }

    public override void Start()
    {
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(_seconds))
        {
            Console.WriteLine("Breath in ...");
            _animation.RunAnimation(3);
            Console.WriteLine();
            Console.WriteLine("Breath out ...");
            _animation.RunAnimation(3);
            Console.WriteLine();
        }
    }

    public override void DisplayEndMessage()
    {
        base.DisplayEndMessage();
        Console.WriteLine($"You have completed at least {_seconds} seconds of the Breathing Activity.");
        Thread.Sleep(4000);
    }


}