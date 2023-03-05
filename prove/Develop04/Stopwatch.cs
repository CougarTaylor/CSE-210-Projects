using System;

public class Stopwatch : Animation
{

    public override void RunAnimation(int timer)
    {
        base.RunAnimation(timer);

        int countdown = timer;
        do{
            Console.Write($"\b{countdown}");
            Thread.Sleep(1000);
            countdown -= 1;
        }while (countdown != 0);
        CursorAppearance();
    }
    
}