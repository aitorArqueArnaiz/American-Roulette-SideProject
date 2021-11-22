
using Game.Domain.Entities;
using System.Collections.Generic;

namespace Game.Domain.Interfaces
{
    public interface IGameService
    {
        /// <summary>
        /// Method that wheels the roulette.
        /// </summary>
        void Wheel();

        /// <summary>
        /// Method that returns the last winning value of thw roulette.
        /// </summary>
        /// <returns></returns>
        public int GetWheelValue();

        /// <summary>
        /// Method that saves the user bet into repository.
        /// </summary>
        void UserBet(Bet bet);

        /// <summary>
        /// Method that get all the player bets existing in the data base.
        /// </summary>
        /// <returns></returns>
        List<Bet> GetAllPlayerBets();

        /// <summary>
        /// Method that proceses the direct bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double? ProcesBetDirect(Bet bet);

        /// <summary>
        /// Method that proceses the divided bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double? ProcesBetDivided(Bet bet);

        /// <summary>
        /// Method that proceses the street bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetStreet(Bet bet);

        /// <summary>
        /// Method that proceses the corner bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetCorner(Bet bet);

        /// <summary>
        /// Method that proceses the five numbers bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetFiveNumbers(Bet bet);

        /// <summary>
        /// Method that proceses the line bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetLine(Bet bet);

        /// <summary>
        /// Method that proceses the dozen bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDozen(Bet bet);

        /// <summary>
        /// Method that proceses the column bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetColumn(Bet bet);

        /// <summary>
        /// Method that proceses the double dozen bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDoubleDozen(Bet bet);

        /// <summary>
        /// Method that proceses the double column bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDoubleColumn(Bet bet);

        /// <summary>
        /// Method that proceses the color's bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetColors(Bet bet);

        /// <summary>
        /// Method that proceses the odd or even bet.
        /// </summary>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetOdds(Bet bet);
    }
}
