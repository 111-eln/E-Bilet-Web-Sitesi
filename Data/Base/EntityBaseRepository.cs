using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Razorpay.Api;

namespace eTicketApp.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDBContext _context;
        public EntityBaseRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)=> await _context.Set<T>().AddAsync(entity);
         public async Task DeleteAsync(int id)
        {
            var entity= await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }
        public async Task<IEnumerable<T>> GetAllAsync()=> await _context.Set<T>().ToListAsync();
         
        public async  Task<T> GetByIdAsync(int id)=>await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        
        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
        }
    }
}
