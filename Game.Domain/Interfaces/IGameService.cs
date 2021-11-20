
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
        /// Method that proceses the direct bet.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="winningNumber"></param>
        /// <param name="bet"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetDirect(string number, string winningNumber, int bet);

        /// <summary>
        /// Method that proceses the divided bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDivided(string number);

        /// <summary>
        /// Method that proceses the street bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetStreet(string number);

        /// <summary>
        /// Method that proceses the corner bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetCorner(string number);

        /// <summary>
        /// Method that proceses the five numbers bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetFiveNumbers(string number);

        /// <summary>
        /// Method that proceses the line bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetLine(string number);

        /// <summary>
        /// Method that proceses the dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDozen(string number);

        /// <summary>
        /// Method that proceses the column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetColumn(string number);

        /// <summary>
        /// Method that proceses the double dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDoubleDozen(string number);

        /// <summary>
        /// Method that proceses the double column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetDoubleColumn(string number);

        /// <summary>
        /// Method that proceses the color's bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetColors(string number);

        /// <summary>
        /// Method that proceses the odd or even bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetOdds(string number);
    }
}
