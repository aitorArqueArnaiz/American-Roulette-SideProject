
namespace Game.Domain.Shared
{
    public class Enums
    {
        public enum BetType
        {
            Direct = 1,
            Divided = 2,
            Street = 3,
            Corner = 4,
            FiveNumbers = 5,
            Line = 6,
            Dozen = 7,
            Column = 8,
            DoubleDozen = 9,
            DoubleColumn = 10,
            Color =11,
            Odd = 12,
            Undefined = 13
        }

        public enum GameState
        {
            Waiting = 1,
            Playing = 2,
            Processing = 3
        }
    }
}
