using Game.Infrastructure.Data;
using static Game.Domain.Shared.Enums;

namespace Game.Domain.Entities
{
    public class Bet : BaseEntity
    {
        public Bet()
        {
        }

        public Entity bet { get; set; }
    }
}
