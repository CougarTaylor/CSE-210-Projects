using Raylib_cs;


public class Box
{
    public int _speed;
    public float _y_speed;
    public Rectangle body = new Rectangle();
    public string _type;
    public Box(int x, int y, int width, int height, int speed, float y_speed)
    {
        body.x = x;
        body.y = y;
        body.width = width;
        body.height = height;
        _speed = speed;
        _y_speed = y_speed;
    }
    
    public void Moveleft()
    {
        body.x -= _speed;
    }
    public void MoveVerticle()
    {
        body.y += _y_speed;
    }

    public virtual void AffectPlayer(Player player1)
    {
        
    }
}