namespace RoshamboRockPaperScissorsLab
{
    static public class PlayGame
    {
        static public void PlayRoshambo(Player humanPlayer, Player chosenPlayer)
        {
            humanPlayer.RoshamboValue = humanPlayer.GenerateRoshambo();
            chosenPlayer.RoshamboValue = chosenPlayer.GenerateRoshambo();

            Console.WriteLine();
            ShowChosen(humanPlayer.PlayerName, humanPlayer.RoshamboValue);
            ShowChosen(chosenPlayer.PlayerName, chosenPlayer.RoshamboValue);

            Console.ForegroundColor = ConsoleColor.Green;
            
            bool? humanWin = IsWin(humanPlayer.RoshamboValue, chosenPlayer.RoshamboValue);
            switch (humanWin)
            {
                case true:
                    humanPlayer.WonGame();
                    chosenPlayer.LostGame();
                    Console.WriteLine($"{humanPlayer.PlayerName} wins!");    
                    break;

                case false:
                    humanPlayer.LostGame();
                    chosenPlayer.WonGame();
                    Console.WriteLine($"{chosenPlayer.PlayerName} wins!");
                    break;

                default:
                    humanPlayer.DrawGame();
                    chosenPlayer.DrawGame();
                    Console.WriteLine("Draw game!");
                    break;
            }

            Console.ResetColor();
        }

        static public void ShowChosen(string playerName, Roshambo chosenItem)
        {
            Console.Write($"{playerName} chose ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{chosenItem.ToString().ToLower()}");
            Console.ResetColor();
            Console.WriteLine(".");
        }

        static public bool? IsWin(Roshambo humanRoshambo, Roshambo chosenPlayerRoshambo)
        {
            bool? humanWin;

            if (humanRoshambo == chosenPlayerRoshambo)
                humanWin = null;
            else humanWin =
                humanRoshambo == Roshambo.Paper && chosenPlayerRoshambo == Roshambo.Rock ||
                humanRoshambo == Roshambo.Rock && chosenPlayerRoshambo == Roshambo.Scissors ||
                humanRoshambo == Roshambo.Scissors && chosenPlayerRoshambo == Roshambo.Paper;

            return humanWin;
        }
    }
}