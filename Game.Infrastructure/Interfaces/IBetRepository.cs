using Game.Infrastructure.Data;
using System.Collections.Generic;

namespace Game.Infrastructure.Interfaces
{
    public interface IBetRepository
    {
        void AddUserBet(Entity entity);

        List<Entity> GetAllUserBets();
    }
}
