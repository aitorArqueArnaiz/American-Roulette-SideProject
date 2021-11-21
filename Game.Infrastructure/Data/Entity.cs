using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Infrastructure.Data
{
    public class Entity
    {
        [ForeignKey("Id")]
        public long Id { get; set; }
        public int Number { get; set; }
        public double ammount { get; set; }
        public int type { get; set; }
    }
}
