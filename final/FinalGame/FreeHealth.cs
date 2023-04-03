using Raylib_cs;


public class FreeHealth : Box
{
    public FreeHealth(int x, int y, int width, int height, int speed, int y_speed): base(x, y, width, height, speed, y_speed)
    {
        _type = "freeHealth";
    }
    public override void AffectPlayer(Player player1)
    {
        if (player1._health < 5)
        {
            player1._health += 1;
        }
    }
}