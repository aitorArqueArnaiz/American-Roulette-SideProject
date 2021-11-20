using Game.Domain.Interfaces;
using System;

namespace Game.Domain.Services
{
    public class GameService : IGameService
    {
        public int Spin()
        {
            var bet = new Random();
            return bet.Next(0, 36);
        }

        public double BetDirect(string number, string winningNumber, int bet)
        {
            // TODO : Check in roulette model that the betting number exists in the game.
            if(winningNumber == number ||
                number == "0" || 
                number == "00")
            {
                return 35 * bet;
            }
            return 0.0;
        }

        public double betDivided(string number)
        {
            return 0;
        }


        public double BetStreet(string number)
        {
            return 0;
        }

        public double BetCorner(string number)
        {
            return 0;
        }

        public double BetFiveNumbers(string number)
        {
            return 0;
        }

        public double BetLine(string number)
        {
            return 0;
        }

        public double betDozen(string number)
        {
            return 0;
        }

        public double BetColumn(int number)
        {
            return 0;
        }

        public double betDoubleDozen(string number)
        {
            return 0;
        }

        public double BetDoubleColumn(string number)
        {
            return 0;
        }
        public double BetColors(string number)
        {
            return 0;
        }

        public double BetOdds(string number)
        {
            return 0;
        }
    }
}
