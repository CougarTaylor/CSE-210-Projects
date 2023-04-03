using Raylib_cs;


public class WorldManager
{
    private int _screenwidth;
    private int _screenheight;
    public List<Stars> AllStar = new List<Stars>();
    public List<Box> Particles = new List<Box>();
    public List<Box> Lives = new List<Box>();
    public List<float> VerticleSpeeds = new List<float>(){
        -.5f, 0, 0, 0, 0, 0, .5f, -.3f, .3f
    };
    private int _dodgemecounter = 0;
    private int _hitMecounter = 0;
    private int _asteroidcounter = 0;
    private int _StartOfGameTimer = 0;
    private int _AteroidSpawnTime = 30;
    private int _freeHealthcounter = 0;
    public void RandomDodgeMe()
    {
        if (_dodgemecounter == 100)
        {
        Random random = new Random();
        int randomWidth = random.Next(13, 20);
        int randomHeight = random.Next(13, 20);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(5, 9);
        DodgeMe dodgeme = new DodgeMe(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed, 0);
        Particles.Add(dodgeme);
        _dodgemecounter = 0;
        }
        _dodgemecounter++;
    }
    public void RandomHitMe()
    {
        if (_hitMecounter == 200)
        {
        Random random = new Random();
        int randomWidth = random.Next(13, 20);
        int randomHeight = random.Next(13, 20);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(5, 9);
        HitMe hitMe = new HitMe(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed, 0);
        Particles.Add(hitMe);
        _hitMecounter = 0;
        }
        _hitMecounter++;
    }
    public void RandomFreeHealth()
    {
        if (_freeHealthcounter == 200)
        {
        Random random = new Random();
        int randomWidth = random.Next(13, 20);
        int randomHeight = random.Next(13, 20);
        int random_y_Value = random.Next(0, _screenheight - randomHeight);
        int randomSpeed = random.Next(5, 9);
        FreeHealth freeHealth = new FreeHealth(_screenwidth, random_y_Value, randomWidth, randomHeight, randomSpeed, 0);
        Particles.Add(freeHealth);
        _freeHealthcounter = 0;
        }
        _freeHealthcounter++;
    }
    
    public void SendAsteroid()
    {
        if (_asteroidcounter >= _AteroidSpawnTime)
        {
        Random random = new Random();
        int randomWidth = random.Next(30, 40);
        int random_y_Value = random.Next(0, _screenheight - randomWidth);
        int randomSpeed = random.Next(4, 6);
        float random_y_speed = VerticleSpeeds[random.Next(VerticleSpeeds.Count)];
        Asteroid asteroid = new Asteroid(_screenwidth, random_y_Value, randomWidth, randomWidth, randomSpeed, random_y_speed);
        Particles.Add(asteroid);
        _asteroidcounter = 0;
        }
        _asteroidcounter++;
        _StartOfGameTimer++;
        if (_StartOfGameTimer >= 500)// && _AteroidSpawnTime > 10
        {
            _AteroidSpawnTime -= 2;
            _StartOfGameTimer = 0;
        }
        // else if (_StartOfGameTimer > 20 * 50)
        // {
        //     _AteroidSpawnTime = 20;
        // }
        // else if (_StartOfGameTimer > 30 * 50)
        // {
        //     _AteroidSpawnTime = 15;
        // }
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
        Lives.Clear();
        for (int i = 0; i < player1._health; i++)
        {
            int Width = 8;
            int Height = 12;
            int x_Value = 5 + (i * 10);
            Box life = new Box(x_Value, 5, Width, Height, 0, 0);
            Lives.Add(life);
        }
    }

    public WorldManager(int screenwidth, int screenheight)
    {
        _screenwidth = screenwidth;
        _screenheight = screenheight;
    }

}