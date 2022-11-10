namespace RoshamboRockPaperScissorsLab
{
    public abstract class Player
    {
        public string PlayerName { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Draws { get; private set; }
        public int TotalGames { get { return Wins + Losses + Draws; } }
        public Roshambo RoshamboValue { get; set; }

        protected Player(string name)
        {
            PlayerName = Validator.GetPlayerName(name);
        }

        public abstract Roshambo GenerateRoshambo();

        public void WonGame()
        {
            Wins++;
        }

        public void LostGame()
        {
            Losses++;
        }

        public void DrawGame()
        {
            Draws++;
        }

        public void ShowStats()
        {
            if (TotalGames > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nStats for {PlayerName}");
                Console.ResetColor();

                Console.WriteLine($"Wins: {Wins}");
                Console.WriteLine($"Losses: {Losses}");
                Console.WriteLine($"Draw games: {Draws}");
                Console.WriteLine($"Total games played: {TotalGames}");
            }
        }
    }
}