// See https://aka.ms/new-console-template for more information
int playerRandomNum;
int enemyRandomNum;

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
        Console.WriteLine("Player wins this round");
    } else if(playerRandomNum < enemyRandomNum){
        Console.WriteLine("Enemy AI wins this round");
    } else{Console.WriteLine("Player and Enemy AI tie this round");}
}

Console.WriteLine("Game Over!");
