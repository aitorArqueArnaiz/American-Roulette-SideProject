using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Game.Domain.Services
{
    public class GameService : IGameService
    {
        #region variables

        private List<string> _zeros = new List<string>() { "0", "00" };

        #endregion

        #region Methods

        public int Spin()
        {
            var bet = new Random();
            return bet.Next(0, 36);
        }

        public void UserBet()
        {

        }

        public double? ProcesBetDirect(string number, int bet)
        {
            return 0;
        }

        public double ProcesBetDivided(string number)
        {
            return 0;
        }


        public double ProcesBetStreet(string number)
        {
            return 0;
        }

        public double ProcesBetCorner(string number)
        {
            return 0;
        }

        public double ProcesBetFiveNumbers(string number)
        {
            return 0;
        }

        public double ProcesBetLine(string number)
        {
            return 0;
        }

        public double ProcesBetDozen(string number)
        {
            return 0;
        }

        public double ProcesBetColumn(string number)
        {
            return 0;
        }

        public double ProcesBetDoubleDozen(string number)
        {
            return 0;
        }

        public double ProcesBetDoubleColumn(string number)
        {
            return 0;
        }
        public double ProcesBetColors(string number)
        {
            return 0;
        }

        public double ProcesBetOdds(string number)
        {
            return 0;
        }

        #endregion

        #region Helper Methods

        private bool IsZeroWinningNumber(string bettingNumber)
        {
            return _zeros.Contains(bettingNumber);
        }

        #endregion

    }
}
