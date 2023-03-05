using System;

public class Activity
{
    protected int _seconds;
    private Animation _animation = new Spinner();
    
    public virtual void SetUp()
    {
        Console.WriteLine();
        int seconds = HowManySeconds();
        _seconds = seconds;
    }

    protected int HowManySeconds()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        return seconds;
    }

    public virtual void GetReady()
    {
        Console.WriteLine("Get ready...");
        _animation.RunAnimation(4);
        Console.WriteLine();
    }

    public virtual void Start()
    {
        Console.Write("This is the where the activity starts.");
    }

    public virtual void DisplayEndMessage()
    {
        Console.WriteLine("Great Job!!!  You did it!!!");
        Thread.Sleep(3000);
        Console.WriteLine();
    }

    public void RunAnimation()
    {
        Console.Write("Yuuh Everyone else be sleepin' ");
    }
}