namespace RoshamboRockPaperScissorsLab
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name) { }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int randomRoshambo = random.Next(0, 3);

            return (Roshambo)randomRoshambo;
        }
    }
}