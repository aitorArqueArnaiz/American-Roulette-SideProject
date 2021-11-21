
namespace Game.Domain.Interfaces
{
    public interface IGameService
    {
        /// <summary>
        /// Method that spins the roulette game.
        /// </summary>
        /// <returns>the winning number.</returns>
        int Spin();

        /// <summary>
        /// Method that saves the user bet into repository.
        /// </summary>
        void UserBet();

        /// <summary>
        /// Method that proceses the direct bet.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double? ProcesBetDirect(string number, int bet);

        /// <summary>
        /// Method that proceses the divided bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDivided(string number);

        /// <summary>
        /// Method that proceses the street bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetStreet(string number);

        /// <summary>
        /// Method that proceses the corner bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetCorner(string number);

        /// <summary>
        /// Method that proceses the five numbers bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetFiveNumbers(string number);

        /// <summary>
        /// Method that proceses the line bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetLine(string number);

        /// <summary>
        /// Method that proceses the dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDozen(string number);

        /// <summary>
        /// Method that proceses the column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetColumn(string number);

        /// <summary>
        /// Method that proceses the double dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDoubleDozen(string number);

        /// <summary>
        /// Method that proceses the double column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetDoubleColumn(string number);

        /// <summary>
        /// Method that proceses the color's bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetColors(string number);

        /// <summary>
        /// Method that proceses the odd or even bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double ProcesBetOdds(string number);
    }
}
