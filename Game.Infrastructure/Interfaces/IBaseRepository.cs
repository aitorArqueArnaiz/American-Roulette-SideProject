using Game.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
