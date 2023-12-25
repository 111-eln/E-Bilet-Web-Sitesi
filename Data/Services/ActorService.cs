using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDBContext _context;
        public ActorService(AppDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result); 
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            throw new NotImplementedException();
        }

       
        public async Task<Actor> UpdateAsync(int id, Actor newactor)
        {
            _context.Update(newactor);
            await _context.SaveChangesAsync();
            return newactor;
        }
    }
}
