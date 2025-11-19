class Player
{
    private string playerName;
    private int level;
    private int health;

    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Player Name: {playerName}, Level: {level}, Health: {health}");
    }
}
