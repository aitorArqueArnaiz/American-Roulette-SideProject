using Game.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        /// <summary>
        /// Method that gets all the bets from the repository.
        /// </summary>
        /// <returns>The list of user bets.</returns>
        Task<List<T>> GetAll();

        /// <summary>
        /// Method that finds a bet in the repository given an id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The uuser bet.</returns>
        Task<T> Find(int id);

        /// <summary>
        /// Method that adds a set of user bets in the repository.
        /// </summary>
        /// <param name="userBets"></param>
        void AddRange(List<Entity> userBets);

        /// <summary>
        /// Method that adds a single user bet into repository.
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Method that updated a given user bet in the repository.
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Method that deletes a given user bet from the repository.
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}
