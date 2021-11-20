
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
        /// <returns>The winning ammount or zero.</returns>
        double BetDirect(int number);

        /// <summary>
        /// Method that proceses the divided bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDivided(int number);

        /// <summary>
        /// Method that proceses the street bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetStreet(int number);

        /// <summary>
        /// Method that proceses the corner bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetCorner(int number);

        /// <summary>
        /// Method that proceses the five numbers bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetFiveNumbers(int number);

        /// <summary>
        /// Method that proceses the line bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetLine(int number);

        /// <summary>
        /// Method that proceses the dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDozen(int number);

        /// <summary>
        /// Method that proceses the column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetColumn(int number);

        /// <summary>
        /// Method that proceses the double dozen bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double betDoubleDozen(int number);

        /// <summary>
        /// Method that proceses the double column bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetDoubleColumn(int number);

        /// <summary>
        /// Method that proceses the color's bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetColors(int number);

        /// <summary>
        /// Method that proceses the odd or even bet.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The winning ammount or zero.</returns>
        double BetOdds(int number);
    }
}
