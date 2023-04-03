using Raylib_cs;


public class DodgeMe : Box
{
    public DodgeMe(int x, int y, int width, int height, int speed, int y_speed): base(x, y, width, height, speed, y_speed)
    {
        _type = "dodgeMe";
    }
    public override void AffectPlayer(Player player1)
    {
        player1._speed = 2;
    }
}