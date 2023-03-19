using Raylib_cs;


public class WorldManager
{
    private int _screenwidth;
    private int _screenheight;
    public List<Stars> AllStar = new List<Stars>();
    public List<Box> Particles = new List<Box>();
    public List<Box> Lives = new List<Box>();
    private int _counter1 = 0;
    private int _counter2 = 0;
    private int _counter3 = 0;
    public void RandomDodgeMe()
    {
        if (_counter1 == 100)
        {
        Random random = new Random();
        int randomWidth = random.Next(13, 20);
        int randomHeight = random.Next(13, 20);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(5, 9);
        DodgeMe dodgeme = new DodgeMe(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed);
        Particles.Add(dodgeme);
        _counter1 = 0;
        }
        _counter1++;
    }
    public void RandomHitMe()
    {
        if (_counter2 == 200)
        {
        Random random = new Random();
        int randomWidth = random.Next(13, 20);
        int randomHeight = random.Next(13, 20);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(5, 9);
        HitMe hitMe = new HitMe(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed);
        Particles.Add(hitMe);
        _counter2 = 0;
        }
        _counter2++;
    }
    
    public void SendAsteroid()
    {
        if (_counter3 == 30)
        {
        Random random = new Random();
        int randomWidth = random.Next(30, 40);
        int random_y_Value = random.Next(0, _screenheight - randomWidth);
        int randomSpeed = random.Next(4, 6);
        Asteroid asteroid = new Asteroid(_screenwidth, random_y_Value, randomWidth, randomWidth, randomSpeed);
        Particles.Add(asteroid);
        _counter3 = 0;
        }
        _counter3++;
    }
    
    public void SeeTheStars()
    {
        Random random = new Random();
        int randomWidth = random.Next(5, 7);
        int randomHeight = random.Next(5, 7);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(8, 14);
        Stars stars = new Stars(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed);
        AllStar.Add(stars);
    }

    public void ShowHealth(Player player1)
    {
        for (int i = 0; i > player1._health + 1; i++)
        {
            int Width = 8;
            int Height = 12;
            int x_Value = 5 + (i * 10);
            int Speed = 0;
            Box life = new Box(x_Value, 5, Width, Height, Speed);
            Lives.Add(life);
        }
    }

    public WorldManager(int screenwidth, int screenheight)
    {
        _screenwidth = screenwidth;
        _screenheight = screenheight;
    }

}