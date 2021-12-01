using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Infrastructure.Data
{
    public class Entity : BaseEntity
    {
        public int Number { get; set; }
        public double ammount { get; set; }
        public int type { get; set; }
    }
}
