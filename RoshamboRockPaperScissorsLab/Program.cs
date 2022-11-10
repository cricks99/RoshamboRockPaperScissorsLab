using RoshamboRockPaperScissorsLab;

Console.WriteLine("Welcome to Rock Paper Scissors!");

Player humanPlayer = new HumanPlayer();
Player[] otherPlayers = { new RockPlayer("RockPlayer"), new RandomPlayer("RandomPlayer") };

do
{
    Console.Clear();

    string playingAgain = "";
    if (humanPlayer.TotalGames > 0)
        playingAgain = " again";
    Console.WriteLine($"I'm glad you're playing{playingAgain}, {humanPlayer.PlayerName}!\n");

    Player chosenPlayer = Validator.GetOtherPlayer(otherPlayers);
    
    Console.Clear();
    Console.WriteLine($"{humanPlayer.PlayerName}, you chose to play against {chosenPlayer.PlayerName}.");

    PlayGame.PlayRoshambo(humanPlayer, chosenPlayer);

    humanPlayer.ShowStats();
    foreach (Player player in otherPlayers)
        player.ShowStats();
}
while (Validator.PlayAgain());

Console.WriteLine("\nThanks for playing!");
Console.ReadKey();
Environment.Exit(0);