using NUnit.Framework;

namespace TennisGameTest
{
    [TestFixture]
    public class GameTest
    {
        private readonly TennisGame.TennisGame _tennisGame = new TennisGame.TennisGame();

        [TestCase(0, 0, "love - love")]
        [TestCase(1, 0, "fifteen - love")]
        [TestCase(4, 3, "playerOne advantage")]
        [TestCase(3, 4, "playerTwo advantage")]
        [TestCase(2, 3, "thirty - forty")]
        [TestCase(3, 2, "forty - thirty")]
        [TestCase(3, 3, "deuce")]
        [TestCase(2, 2, "thirty - thirty")]
        [TestCase(4, 2, "playerOne won")]
        [TestCase(2, 4, "playerTwo won")]
        [TestCase(6, 5, "playerOne advantage")]
        [TestCase(6, 6, "deuce")]
        [TestCase(8, 6, "playerOne won")]
        public void Should_be_correct_score(int playerOneScore, int playerTwoScore, string result)
        {
            Assert.AreEqual(result, _tennisGame.GetScore(playerOneScore, playerTwoScore));
        }
    }
}
