using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TContext> : DbContext, IBaseRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private DbSet<TEntity> Bets { get; set; }

        public BaseRepository(DbContextOptions<BaseRepository<TEntity, TContext>> options) : base(options)
        {
        }

        Task<List<TEntity>> IBaseRepository<TEntity>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<TEntity> IBaseRepository<TEntity>.Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        Task<TEntity> IBaseRepository<TEntity>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
