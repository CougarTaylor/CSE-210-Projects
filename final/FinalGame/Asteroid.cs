using Raylib_cs;
using static Raylib_cs.Raylib;

public class Asteroid : Box
{
    public Asteroid(int x, int y, int width, int height, int speed): base(x, y, width, height, speed)
    {
        _type = "asteroid";
    }
    protected override void AffectPlayer()
    {
        
    }
}