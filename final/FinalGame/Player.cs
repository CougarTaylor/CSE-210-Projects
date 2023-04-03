using Raylib_cs;


public class Player
{
    public int _speed;
    public int _health;
    public int _screenwidth;
    public int _screenheight;
    public int _player_num;
    public Rectangle body = new Rectangle();
    public Player(int x, int y, int width, int height, int speed, int health, int screenwidth, int screenheight, int player_num)
    {
        body.x = x;
        body.y = y;
        body.width = width;
        body.height = height;
        _speed = speed;
        _health = health;
        _screenwidth = screenwidth;
        _screenheight = screenheight;
        _player_num = player_num;
    }
    public void MoveRectangle()
    {
        if (_player_num == 1)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                if (body.y < (_screenheight - body.height))
                {
                    body.y += _speed;
                    if (body.y > (_screenheight - body.height))
                    {
                        body.y = _screenheight - body.height;
                    }
                }
                
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                if (body.y > 0)
                {
                    body.y -= _speed;
                    if (body.y < (0))
                    {
                        body.y = 0;
                    }
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                if (body.x > 0)
                {
                    body.x -= _speed;
                    if (body.x < (0))
                    {
                        body.x = 0;
                    }
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                if (body.x < _screenwidth - body.width)
                {
                    body.x += _speed;
                    if (body.x > (_screenwidth - body.width))
                    {
                        body.x = _screenwidth - body.width;
                    }
                }
            }
        }
        else 
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                if (body.y < (_screenheight - body.height))
                {
                    body.y += _speed;
                    if (body.y > (_screenheight - body.height))
                    {
                        body.y = _screenheight - body.height;
                    }
                }
                
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                if (body.y > 0)
                {
                    body.y -= _speed;
                    if (body.y < (0))
                    {
                        body.y = 0;
                    }
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                if (body.x > 0)
                {
                    body.x -= _speed;
                    if (body.x < (0))
                    {
                        body.x = 0;
                    }
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                if (body.x < _screenwidth - body.width)
                {
                    body.x += _speed;
                    if (body.x > (_screenwidth - body.width))
                    {
                        body.x = _screenwidth - body.width;
                    }
                }
            }
        }
    }
}