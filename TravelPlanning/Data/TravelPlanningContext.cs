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

            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}

