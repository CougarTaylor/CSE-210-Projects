using System;

public class Spinner : Animation
{
        public override void RunAnimation(int timer)
    {
        base.RunAnimation(timer);

        int countdown = timer;
        do{
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            countdown -= 1;
        }while (countdown != 0);
        CursorAppearance();
    }

}