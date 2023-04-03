using Raylib_cs;


public class HitMe : Box
{
    public HitMe(int x, int y, int width, int height, int speed, int y_speed): base(x, y, width, height, speed, y_speed)
    {
        _type = "hitMe";
    }
    public override void AffectPlayer(Player player1)
    {
        player1._speed = 8;
    }
}