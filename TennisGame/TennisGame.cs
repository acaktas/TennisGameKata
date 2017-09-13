using System;

namespace TennisGame
{
    public class TennisGame
    {
        private string GetScore(int score)
        {
            switch (score)
            {
                case 1:
                    return "fifteen";
                case 2:
                    return "thirty";
                case 3:
                    return "forty";
            }
            return "love";
        }

        public string GetScore(int playerOne, int playerTwo)
        {
            if (playerOne >= 4 && playerTwo + 2 <= playerOne)
            {
                return "playerOne won";
            }
            if (playerTwo >= 4 && playerOne + 2 <= playerTwo)
            {
                return "playerTwo won";
            }

            if (playerOne < 3 || playerTwo < 3)
                return GetScore(playerOne) + " - " + GetScore(playerTwo);

            if (playerOne == playerTwo)
            {
                return "deuce";
            }

            return playerOne == playerTwo + 1 ? "playerOne advantage" : "playerTwo advantage";
        }
    }
}