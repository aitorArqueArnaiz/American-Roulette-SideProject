using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Game.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace Game.Domain.Services
{
    public class GameService : IGameService
    {
        #region variables

        private List<string> _zeros = new List<string>() { "0", "00" };
        private readonly IBaseRepository _betRepository;
        private int wheel;

        #endregion

        #region Constructors

        public GameService(IBaseRepository repository) : base()
        {
            _betRepository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.wheel = 0;
        }

        #endregion

        #region Methods

        public void Wheel()
        {
            var bet = new Random();
            this.wheel = bet.Next(0, 36);
        }

        public void UserBet()
        {

        }

        public double? ProcesBetDirect(Bet bet)
        {
            return 0;
        }

        public double ProcesBetDivided(Bet bet)
        {
            return 0;
        }


        public double ProcesBetStreet(Bet bet)
        {
            return 0;
        }

        public double ProcesBetCorner(Bet bet)
        {
            return 0;
        }

        public double ProcesBetFiveNumbers(Bet bet)
        {
            return 0;
        }

        public double ProcesBetLine(Bet bet)
        {
            return 0;
        }

        public double ProcesBetDozen(Bet bet)
        {
            return 0;
        }

        public double ProcesBetColumn(Bet bet)
        {
            return 0;
        }

        public double ProcesBetDoubleDozen(Bet bet)
        {
            return 0;
        }

        public double ProcesBetDoubleColumn(Bet bet)
        {
            return 0;
        }
        public double ProcesBetColors(Bet bet)
        {
            return 0;
        }

        public double ProcesBetOdds(Bet bet)
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
