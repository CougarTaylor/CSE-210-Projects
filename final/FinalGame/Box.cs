using Raylib_cs;


public class Box
{
    public int _speed;
    public Rectangle body = new Rectangle();
    public string _type;
    public Box(int x, int y, int width, int height, int speed)
    {
        body.x = x;
        body.y = y;
        body.width = width;
        body.height = height;
        _speed = speed;
    }
    
    public void Moveleft()
    {
        body.x -= _speed;
        
    }

    protected virtual void AffectPlayer()
    {
        
    }
}