using Raylib_cs;
using static Raylib_cs.Raylib;

public class Asteroid : Box
{
    public Asteroid(int x, int y, int width, int height, int speed, float y_speed): base(x, y, width, height, speed, y_speed)
    {
        _type = "asteroid";
    }
    public override void AffectPlayer(Player player1)
    {
        player1._health -= 1;
    }
}