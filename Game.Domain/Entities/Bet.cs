using static Game.Domain.Shared.Enums;

namespace Game.Domain.Entities
{
    public class Bet : BaseEntity
    {
        public Bet()
        {
            this.Number = int.MinValue;
            this.ammount = double.MinValue;
            this.type = BetType.Undefined;
        }

        public int Number { get; set; }
        public double ammount { get; set; }
        public BetType type { get; set; }
    }
}
