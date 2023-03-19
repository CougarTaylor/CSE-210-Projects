using Raylib_cs;


public class HitMe : Box
{
    public HitMe(int x, int y, int width, int height, int speed): base(x, y, width, height, speed)
    {
        _type = "hitMe";
    }
    protected override void AffectPlayer()
    {

    }
}