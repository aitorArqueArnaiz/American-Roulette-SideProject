using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Infrastructure.Data.Repositories
{
    public class BaseRepository : DbContext, IBaseRepository
    {
        private DbSet<Bet> Bets { get; set; }

        public BaseRepository(DbContextOptions<BaseRepository> options) : base(options)
        {
        }
    }

    internal class Bet
    {
        [ForeignKey("Id")]
        public long Id { get; set; }
        public int Number { get; set; }
        public double ammount { get; set; }
        public int type { get; set; }
    }
}
