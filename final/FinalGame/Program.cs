using Raylib_cs;
using static Raylib_cs.Raylib;
class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player(200, 200, 35, 20, 5, 4);

        int screenwidth = 800;
        int screenheight = 450;

        WorldManager NewWorld = new WorldManager(screenwidth, screenheight);

        InitWindow(screenwidth, screenheight, "The Game");
        SetTargetFPS(50);
        DateTime endTime = DateTime.Now;
        while (!WindowShouldClose())
        {
            DateTime startTime = DateTime.Now;
            BeginDrawing();

            ClearBackground(Color.BLACK);

            NewWorld.ShowHealth(player1);
            foreach (Box lives in NewWorld.Lives)
            {
                DrawRectangleRec(lives.body, Color.GOLD);
            }

            foreach (Stars stars in NewWorld.AllStar)
            {
                DrawRectangleRec(stars.body, Color.RAYWHITE);
            }

            foreach (Box item in NewWorld.Particles)
            {
                if (item._type == "asteroid")
                {
                    DrawRectangleRec(item.body, Color.GRAY);
                }
                else if (item._type == "hitMe")
                {
                    DrawRectangleRec(item.body, Color.BLUE);
                }
                else if (item._type == "dodgeMe")
                {
                    DrawRectangleRec(item.body, Color.RED);
                }
            }

            DrawRectangleRec(player1.body, Color.DARKGRAY);
            
            EndDrawing();
            
            for (int i = 0; i < NewWorld.AllStar.Count(); i++)
            {
                NewWorld.AllStar[i].Moveleft();
                if (NewWorld.AllStar[i].body.x < 0 - NewWorld.AllStar[i].body.width)
                {
                    NewWorld.AllStar.Remove(NewWorld.AllStar[i]);
                }
            }

            for (int i = 0; i < NewWorld.Particles.Count(); i++)
            {
                NewWorld.Particles[i].Moveleft();
                if (NewWorld.Particles[i].body.x < 0 - NewWorld.Particles[i].body.width)
                {
                    NewWorld.Particles.Remove(NewWorld.Particles[i]);
                }
                if (CheckCollisionRecs(player1.body, NewWorld.Particles[i].body))
                {
                    if (NewWorld.Particles[i]._type == "hitMe")
                    {
                        player1._speed = 8;
                        endTime = startTime.AddSeconds(4);
                        NewWorld.Particles.RemoveAt(i);
                    }
                    else if (NewWorld.Particles[i]._type == "dodgeMe")
                    {
                        player1._speed = 2;
                        endTime = startTime.AddSeconds(4);
                        NewWorld.Particles.RemoveAt(i);
                    }
                    else if (NewWorld.Particles[i]._type == "asteroid")
                    {
                        NewWorld.Particles.RemoveAt(i);
                        if (player1._health > 0)
                        {
                            player1._health -= 1;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if (startTime >= endTime)
                {
                    player1._speed = 5;
                }
                // else
                // {
                //     player1._speed = 5;
                // }
            }


            NewWorld.SeeTheStars();
            NewWorld.RandomHitMe();
            NewWorld.RandomDodgeMe();
            NewWorld.SendAsteroid();
            player1.MoveRectangle();
        }
        CloseWindow();
    }
}