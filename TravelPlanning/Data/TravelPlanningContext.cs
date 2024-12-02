using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TravelPlanning.Configurations.Entities;
using TravelPlanning.Data;

namespace TravelPlanning.Data
{
    public class TravelPlanningContext(DbContextOptions<TravelPlanningContext> options) : IdentityDbContext<TravelPlanningUser>(options)
    {
        public DbSet<TravelPlanning.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Accommmodation> Accommmodation { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Destination> Destination { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.Transportation> Transportation { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.ItineraryPlan> ItineraryPlan { get; set; } = default!;
        public DbSet<TravelPlanning.Domain.User> User { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AccommodationSeed());
            builder.ApplyConfiguration(new ActivitySeed());
            builder.ApplyConfiguration(new TransportationSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}

