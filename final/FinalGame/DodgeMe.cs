using Raylib_cs;


public class DodgeMe : Box
{
    public DodgeMe(int x, int y, int width, int height, int speed): base(x, y, width, height, speed)
    {
        _type = "dodgeMe";
    }
    protected override void AffectPlayer()
    {
        
    }
}