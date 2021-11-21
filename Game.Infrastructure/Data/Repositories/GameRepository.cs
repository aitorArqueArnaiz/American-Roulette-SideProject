using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public class GameRepository : BaseRepository
    {
        public GameRepository(DbContextOptions<BaseRepository> options) : base(options)
        {
        }
    }
}
