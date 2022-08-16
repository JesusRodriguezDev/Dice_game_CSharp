// See https://aka.ms/new-console-template for more information
int playerRandomNum;
int enemyRandomNum;

int playerPoints = 0;
int enemyPoints = 0;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll the dice");
    Console.ReadKey();

    playerRandomNum = random.Next(1,7);
    Console.WriteLine("You rolled a " + playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);  //pause to mimic AI thinking after player roll

    enemyRandomNum = random.Next(1,7);
    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

    if (playerRandomNum > enemyRandomNum)
    {
        Console.WriteLine("Player wins this round, point awarded to the player");
        Console.WriteLine("");
        playerPoints ++;
    } else if(playerRandomNum < enemyRandomNum){
        Console.WriteLine("Enemy AI wins this round, point awarded to the enemy AI");
        Console.WriteLine("");
        enemyPoints ++ ;
    } else{Console.WriteLine("Player and Enemy AI tie this round, no points awarded");
    Console.WriteLine("");
    }
}

Console.WriteLine("Game Over!");
Console.WriteLine("The player has a total of " + playerPoints + " points");
Console.WriteLine("The enemy AI has a total of " + enemyPoints + " points");
Console.WriteLine("");

if (playerPoints > enemyPoints)
{
    Console.WriteLine("You win!");
} else if(playerPoints < enemyPoints){
    Console.WriteLine("You lose!");
} else {Console.WriteLine("It's a tie between you and the enemy AI: " + playerPoints + " - " + enemyPoints);}
