namespace Game.Domain.Services
{
    using Game.Domain.Entities;
    using Game.Domain.Interfaces;
    using Game.Domain.model;
    using Game.Infrastructure.Interfaces;
    using System;
    using System.Collections.Generic;
    using static Game.Domain.Shared.Enums;

    public class GameService : IGameService
    {
        #region variables

        /// <summary>
        /// List that represents the zer's of roulette table game.
        /// </summary>
        private List<string> _zeros = new List<string>() { "0", "00" };

        /// <summary>
        /// Bet repository.
        /// </summary>
        private readonly IBetRepository _betRepository;

        /// <summary>
        /// Wheel value.
        /// </summary>
        private int wheel;

        /// <summary>
        /// Direc bet payback for user.
        /// </summary>
        private const int _directBetPayback = 35;

        /// <summary>
        /// Horse bet payback for user.
        /// </summary>
        private const int _horseBetPayback = 17;

        /// <summary>
        /// Transversal bet payback for user.
        /// </summary>
        private const int _transversalBetPayback = 11;

        /// <summary>
        /// Corner bet payback for user.
        /// </summary>
        private const int _cornerBetPayback = 8;

        /// <summary>
        /// Five bet payback for user.
        /// </summary>
        private const int _fiveBetPayback = 6;

        /// <summary>
        /// Line bet payback for user.
        /// </summary>
        private const int _lineBetPayback = 5;

        /// <summary>
        /// Dozen bet payback for user.
        /// </summary>
        private const int _dozenBetPayback = 2;

        /// <summary>
        /// Column bet payback for user.
        /// </summary>
        private const int _columnBetPayback = 2;

        /// <summary>
        /// Double dozen bet payback for user.
        /// </summary>
        private const double _doubleDozenBetPayback = 0.5;

        /// <summary>
        /// Double column bet payback for user.
        /// </summary>
        private const double _doubleColumnBetPayback = 0.5;

        /// <summary>
        /// Colors bet payback for user.
        /// </summary>
        private const int _colorsBetPayback = 1;

        /// <summary>
        /// Odds bet payback for user.
        /// </summary>
        private const int _oddsBetPayback = 1;

        #endregion

        #region Constructors

        public GameService(IBetRepository repository) : base()
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

        public void UserBet(Bet bet)
        {
            if (!this.CheckBetIsValid(bet))
            {
                throw new Exception($"Undefined bet type for user bet {bet.bet.Id}");
            }
            _betRepository.AddUserBet(bet.bet);
        }

        public double? ProcesBetDirect(Bet bet)
        {
            if (!this.CheckBetIsValid(bet) && this.CheckNumberIsValidInRouletteModel(bet))
            {
                throw new Exception($"Undefined bet type for user bet {bet.bet.Id}");
            }
            
            if (bet.bet.Number == this.wheel || 
                this.IsZeroWinningNumber(bet.bet.Number.ToString()))
            {
                return bet.bet.ammount * _directBetPayback;
            }
            return 0.0;
        }

        public double? ProcesBetDivided(Bet bet)
        {
            return 0.0;
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

        /// <summary>
        /// Method that checks if user bet number is "0" or either "00".
        /// </summary>
        /// <param name="bettingNumber"></param>
        /// <returns>True if number is "0" or "00"</returns>
        private bool IsZeroWinningNumber(string bettingNumber)
        {
            return _zeros.Contains(bettingNumber);
        }

        /// <summary>
        /// Method that checks that user bet type is valid.
        /// </summary>
        /// <param name="userBet"></param>
        /// <returns>True if user bet type is valid.</returns>
        private bool CheckBetIsValid(Bet userBet)
        {
            if (userBet == null || userBet.bet.type == (int)BetType.Undefined)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method that checks that a betting number exists in roulette model.
        /// </summary>
        /// <param name="userBet"></param>
        /// <returns>True if number exists in roulette table.</returns>
        private bool CheckNumberIsValidInRouletteModel(Bet userBet)
        {
            foreach(var item in Roulette.roulette)
            {
                if(item.Value.value == userBet.bet.Number.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public int GetWheelValue()
        {
            return this.wheel;
        }

        #endregion

    }
}
