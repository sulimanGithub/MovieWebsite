using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieWebsite.Models;

namespace MovieWebsite.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie_Actor>().HasKey(ma => new
            {
                ma.ActorId,
                ma.MovieId
            });

            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.Movie).WithMany(ma => ma.Movie_Actor).HasForeignKey
                (m => m.MovieId);

            modelBuilder.Entity<Movie_Actor>().HasOne(m => m.Actor).WithMany(ma => ma.Movie_Actor).HasForeignKey
               (m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie_Actor> Movies_Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
