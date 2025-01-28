using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TravelPlanning.Configurations.Entities;
using TravelPlanning.Domain;

namespace TravelPlanning.Data
{
    public class TravelPlanningContext(DbContextOptions<TravelPlanningContext> options) : IdentityDbContext<TravelPlanningUser>(options)
    {

        public DbSet<TravelPlanning.Domain.User> User { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Flight> Flight { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Lodging> Lodging { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure the relationship between User and TravelPlanningUser
           
            builder.Entity<User>()
            .HasOne(u => u.IdentityUser) // Navigation property
            .WithOne()                   // No reverse navigation from IdentityUser
            .HasForeignKey<User>(u => u.IdentityUserId) // Foreign key property

            .OnDelete(DeleteBehavior.Cascade); // Optional: Define delete behavior
            

            // Configure the relationship between Trip and User
            builder.Entity<Trip>()
                .HasOne(t => t.User) // Trip is linked to User
                .WithMany(u => u.Trips) // User can have many Trips
                .HasForeignKey(t => t.UserId) // Foreign key is UserId
                .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete

            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
        
        
    }
}

