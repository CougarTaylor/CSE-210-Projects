using System;

public class MovingDot : Animation
{
    List<string> bars = new List<string>
    {
    "|..                             |",
    "| ..                            |",
    "|  ..                           |",
    "|   ..                          |",
    "|    ..                         |",
    "|     ..                        |",
    "|      ..                       |",
    "|       ..                      |",
    "|        ..                     |",
    "|         ..                    |",
    "|          ..                   |",
    "|           ..                  |",
    "|            ..                 |",
    "|             ..                |",
    "|              ..               |",
    "|               ..              |",
    "|                ..             |",
    "|                 ..            |",
    "|                  ..           |",
    "|                   ..          |",
    "|                    ..         |",
    "|                     ..        |",
    "|                      ..       |",
    "|                       ..      |",
    "|                        ..     |",
    "|                         ..    |",
    "|                          ..   |",
    "|                           ..  |",
    "|                            .. |",
    "|                             ..|",
    };
    public override void RunAnimation(int timer)
    {  

        base.RunAnimation(timer);

        int countdown = timer;
        do{
            int Counter = 1;
            int ReverseCounter = 29;
            while (Counter < 29 && ReverseCounter == 29)
            {
                Console.Write($"\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b{bars[Counter]}");
                Thread.Sleep(1000 / (bars.Count() * timer));
                Counter++;
            }
            while (Counter == 29 && ReverseCounter >= 1)
            {
                Console.Write($"\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b{bars[ReverseCounter]}");
                Thread.Sleep(1000 / (bars.Count() * timer));
                ReverseCounter--;
            }
            countdown -= 1;

        }while (countdown != 0);

        CursorAppearance();
    }
}