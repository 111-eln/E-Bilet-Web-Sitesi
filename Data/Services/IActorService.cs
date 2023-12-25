using eTicketApp.Models;

namespace eTicketApp.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newactor);
        Task DeleteAsync(int id);
    }
}
