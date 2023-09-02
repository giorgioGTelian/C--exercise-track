using System;

public class Game
{
    private int currentWidth;
    private int currentHeight;

  // Mock positions for player and food
    private int playerX = 10;
    private int playerY = 10;
    private int foodX = 20;
    private int foodY = 20;

    private string playerAppearance = ":-)"; // Mock appearance

    public Game()
    {
        currentWidth = Console.WindowWidth;
        currentHeight = Console.WindowHeight;
    }

    public void Start()
    {
        while (true)
        {
            if (HasConsoleResized())
            {
                Console.Clear();
                Console.WriteLine("Console was resized. Program exiting.");
                Environment.Exit(0);
            }

            Move(terminateOnNondirectionalInput: true);
          
            if (HasPlayerConsumedFood())
            {
                ChangePlayerAppearance();
                RedisplayFood();
            }

           int speedModifier = ShouldIncreaseSpeed() ? 3 : 1;  // 3x speed if appearance suggests so
            Move(terminateOnNondirectionalInput: true, speedModifier: speedModifier);
            
            if (HasPlayerConsumedFood())
            {
                ChangePlayerAppearance();
                RedisplayFood();
            }
        }
    }

    public void Move(bool terminateOnNondirectionalInput = false)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                // Logic for Up movement
                break;
            case ConsoleKey.DownArrow:
                // Logic for Down movement
                break;
            case ConsoleKey.LeftArrow:
                // Logic for Left movement
                break;
            case ConsoleKey.RightArrow:
                // Logic for Right movement
                break;
            default:
                if (terminateOnNondirectionalInput)
                {
                    Console.WriteLine("Nondirectional input detected. Program exiting.");
                    Environment.Exit(0);
                }
                break;
        }
    }

    private bool HasConsoleResized()
    {
        if (currentWidth != Console.WindowWidth || currentHeight != Console.WindowHeight)
        {
            return true;
        }
        return false;
    }
  
  //food methods
  private bool HasPlayerConsumedFood()
    {
        return (playerX == foodX) && (playerY == foodY);
    }

    private void ChangePlayerAppearance()
    {
        // Logic to change player appearance
        Console.WriteLine("Player appearance changed!"); // Mock message
    }

    private void RedisplayFood()
    {
        // Logic to redisplay the food in a new location
        Console.WriteLine("Food redisplayed!"); // Mock message
    }
private bool ShouldFreeze()
    {
        return playerAppearance == "(X_X)";
    }

    private void FreezePlayer()
    {
        Console.WriteLine("Player is frozen!");
        Thread.Sleep(2000);  // Freeze for 2 seconds
    }

    private bool ShouldIncreaseSpeed()
    {
        return playerAppearance == "(^-^)";
    }

    public void Move(bool terminateOnNondirectionalInput = false, int speedModifier = 1)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                // Logic for Up movement
                break;
            case ConsoleKey.DownArrow:
                // Logic for Down movement
                break;
            case ConsoleKey.LeftArrow:
                playerX -= speedModifier;  // Increase left movement speed
                break;
            case ConsoleKey.RightArrow:
                playerX += speedModifier;  // Increase right movement speed
                break;
            default:
                if (terminateOnNondirectionalInput)
                {
                    Console.WriteLine("Nondirectional input detected. Program exiting.");
                    Environment.Exit(0);
                }
                break;
        }
    }
    public static void Main()
    {
        Game game = new Game();
        game.Start();
    }
   
}
