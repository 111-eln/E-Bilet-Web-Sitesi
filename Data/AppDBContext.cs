using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketApp.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Actor_Movies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });
            modelbuilder.Entity<Actor_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);
            modelbuilder.Entity<Actor_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelbuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }  
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Actor_Movies> Actor_Movies { get; set; }


    }
}
