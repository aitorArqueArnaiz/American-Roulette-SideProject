
namespace Game.Domain.Interfaces
{
    public interface IGameService
    {
        int Bet();

        double BetDirect(int number);

        double betDivided(int number);

        double BetStreet(int number);

        double BetCorner(int number);

        double BetFiveNumbers(int number);

        double BetLine(int number);

        double betDozen(int number);

        double BetColumn(int number);

        double betDoubleDozen(int number);

        double BetDoubleColumn(int number);
        double BetColors(int number);

        double BetOdds(int number);
    }
}
