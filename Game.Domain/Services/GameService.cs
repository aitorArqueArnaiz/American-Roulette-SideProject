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

        public double betDivided(int number)
        {
            return 0;
        }


        public double BetStreet(int number)
        {
            return 0;
        }

        public double BetCorner(int number)
        {
            return 0;
        }

        public double BetFiveNumbers(int number)
        {
            return 0;
        }

        public double BetLine(int number)
        {
            return 0;
        }

        public double betDozen(int number)
        {
            return 0;
        }

        public double BetColumn(int number)
        {
            return 0;
        }

        public double betDoubleDozen(int number)
        {
            return 0;
        }

        public double BetDoubleColumn(int number)
        {
            return 0;
        }
        public double BetColors(int number)
        {
            return 0;
        }

        public double BetOdds(int number)
        {
            return 0;
        }
    }
}
