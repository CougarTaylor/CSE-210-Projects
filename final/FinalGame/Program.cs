using Raylib_cs;
using static Raylib_cs.Raylib;
class Program
{
    static void Main(string[] args)
    {
        int screenwidth = 1200;//800
        int screenheight = 800;//450
        List<Player> Players = new List<Player>(){
        new Player(200, 200, 35, 20, 5, 5, screenwidth, screenheight, 2),
        new Player(200, 200, 35, 20, 5, 5, screenwidth, screenheight, 1)
        };
        WorldManager NewWorld = new WorldManager(screenwidth, screenheight);

        InitWindow(screenwidth, screenheight, "The Game");
        SetTargetFPS(50);
        DateTime endTime = DateTime.Now;
        NewWorld.ShowHealth(Players[0]);
        int points = 0;
        while (!WindowShouldClose())
        {
            DateTime startTime = DateTime.Now;
            BeginDrawing();

            ClearBackground(Color.BLACK);

            
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
                else if (item._type == "freeHealth")
                {
                    DrawRectangleRec(item.body, Color.PURPLE);
                }
                else if (item._type == "dodgeMe")
                {
                    DrawRectangleRec(item.body, Color.RED);
                }
            }

            DrawText($"{points}", screenwidth - 80, 20, 20, Color.LIGHTGRAY);

            DrawRectangleRec(Players[0].body, Color.DARKGRAY);
            DrawRectangleRec(Players[1].body, Color.LIME);
            
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
                NewWorld.Particles[i].MoveVerticle();
                if (NewWorld.Particles[i].body.x < 0 - NewWorld.Particles[i].body.width)
                {
                    NewWorld.Particles.Remove(NewWorld.Particles[i]);
                }

                foreach (Player player in Players)
                {
                    if (CheckCollisionRecs(player.body, NewWorld.Particles[i].body))
                    {
                        if (NewWorld.Particles[i]._type == "hitMe")
                        {
                            NewWorld.Particles[i].AffectPlayer(player);
                            endTime = startTime.AddSeconds(4);
                            NewWorld.Particles.RemoveAt(i);
                        }
                        else if (NewWorld.Particles[i]._type == "freeHealth")
                        {
                            NewWorld.Particles[i].AffectPlayer(player);
                            NewWorld.ShowHealth(player);
                            NewWorld.Particles.RemoveAt(i);
                            if (player._health == 5)
                            {
                                points += 1000;
                            }
                        }
                        else if (NewWorld.Particles[i]._type == "dodgeMe")
                        {
                            NewWorld.Particles[i].AffectPlayer(player);
                            endTime = startTime.AddSeconds(4);
                            NewWorld.Particles.RemoveAt(i);
                        }
                        else if (NewWorld.Particles[i]._type == "asteroid")
                        {
                            NewWorld.Particles[i].AffectPlayer(player);
                            NewWorld.ShowHealth(player);
                            
                            if (player._health > 0)
                            {
                                NewWorld.Particles.RemoveAt(i);
                            }
                            else
                            {
                                return;
                            }
                            
                        }
                    }
                    if (startTime >= endTime)
                    {
                        player._speed = 5;
                    }
                }
            }
            points ++;
            NewWorld.SeeTheStars();
            NewWorld.RandomHitMe();
            NewWorld.RandomFreeHealth();
            NewWorld.RandomDodgeMe();
            NewWorld.SendAsteroid();
            Players[0].MoveRectangle();
            Players[1].MoveRectangle();
        }
        CloseWindow();
    }
}