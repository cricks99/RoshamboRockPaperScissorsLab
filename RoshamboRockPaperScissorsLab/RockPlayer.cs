namespace RoshamboRockPaperScissorsLab
{
    public class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name) { }
 
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}