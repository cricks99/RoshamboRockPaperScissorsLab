namespace RoshamboRockPaperScissorsLab
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }
        public HumanPlayer() : base("") { }
        
        public override Roshambo GenerateRoshambo()
        {
            return Validator.GetRoshambo();
        }
    }
}