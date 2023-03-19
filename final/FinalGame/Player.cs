using Raylib_cs;


public class Player
{
    public int _speed;
    public int _health;
    public Rectangle body = new Rectangle();
    public Player(int x, int y, int width, int height, int speed, int health)
    {
        body.x = x;
        body.y = y;
        body.width = width;
        body.height = height;
        _speed = speed;
        _health = health;
    }
    public void MoveRectangle()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            if (body.y < (450 - body.height))
            {
                body.y += _speed;
            }
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            if (body.y > 0)
            {
                body.y -= _speed;
            }
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            if (body.x > 0)
            {
                body.x -= _speed;
            }
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            if (body.x < 800 - body.width)
            {
                body.x += _speed;
            }
        }
    }
}