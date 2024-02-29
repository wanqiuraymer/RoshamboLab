using RoshamboLab;
Console.WriteLine("Welcome to Rock Paper Scissor!");
Console.WriteLine("Enter you name");
string userName = Console.ReadLine().Trim();
string userPlayerChoice = "";

while (true)
{
    Console.WriteLine("Would you like to play against TheJets or TheSharks (j/s)?");
    userPlayerChoice = Console.ReadLine().Trim().ToLower();
    if (ValidationHandler.isValidPlayer(userPlayerChoice)) { break; }
}
HumanPlayer humanPlayer = new HumanPlayer();
humanPlayer.Name = userName;
int drawCounter = 0;
int winCounter =0;
int loseCounter = 1;
while (true)
{
    Roshambo userChoice = humanPlayer.GenerateRoshambo();
    Console.WriteLine($"{userName}: {userChoice}");
    if (userPlayerChoice == "j")
    {
        RockPlayer rockPlayer = new RockPlayer("TheJets");
        Console.WriteLine($"{rockPlayer.Name}: {rockPlayer.Rosh}");
        if (userChoice == Roshambo.Rock) { Console.WriteLine("It is a draw!"); drawCounter++; }
        else if (userChoice == Roshambo.Paper) { Console.WriteLine($"{userName} wins!"); winCounter++; }
        else { Console.WriteLine($"{rockPlayer.Name} wins"); loseCounter++; }
    }
    else
    {
        RandomPlayer randomPlayer = new RandomPlayer("TheSharks");
        Roshambo randomPlayerChoice = randomPlayer.GenerateRoshambo();
        Console.WriteLine($"{randomPlayer.Name}: {randomPlayerChoice}");
        if (userChoice == randomPlayerChoice) { Console.WriteLine("It is a draw!");drawCounter++; }
        else if (userChoice == Roshambo.Rock && randomPlayerChoice == Roshambo.Scissors ||
                 userChoice == Roshambo.Paper && randomPlayerChoice == Roshambo.Rock ||
                 userChoice == Roshambo.Scissors && randomPlayerChoice == Roshambo.Paper) { Console.WriteLine($"{userName} wins!");winCounter++; }
        else { Console.WriteLine($"{randomPlayer.Name} wins"); loseCounter++; }
    }
    Console.WriteLine("Play again? (y/n)");
    if (Console.ReadLine().Trim().ToLower() != "y") { Console.WriteLine($"{userName} has {winCounter} win(s), {loseCounter} lose(s), and {drawCounter} draw(s)."); Console.WriteLine("Goodbye!"); break; }
   
}

Console.WriteLine();