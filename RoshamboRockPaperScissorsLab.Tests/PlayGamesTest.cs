namespace RoshamboRockPaperScissorsLab.Tests
{
    public class PlayGamesTest
    {
        [Theory]
        [InlineData("p", 1, 0, 0)]  //paper - human win
        [InlineData("s", 0, 1, 0)]  //scissors - human loss
        [InlineData("r", 0, 0, 1)]  //rock - draw

        public void HumanVsRockPlayer(string rps, int winTotal, int lossTotal, int drawTotal)
        {
            //Arrange
            StringReader playerNames = new StringReader("");
            Console.SetIn(playerNames);

            Player sut1 = new HumanPlayer();
            Player sut2 = new RockPlayer("RockPlayer");

            StringReader chooseRockPaperScissors = new StringReader(rps);
            Console.SetIn(chooseRockPaperScissors);

            //Act
            PlayGame.PlayRoshambo(sut1, sut2);

            //Assert
            Assert.Equal(winTotal, sut1.Wins);
            Assert.Equal(lossTotal, sut1.Losses);
            Assert.Equal(drawTotal, sut1.Draws);
            Assert.Equal(1, sut1.TotalGames);
        }
    }
}