using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using TravelPlanning.Domain;

namespace TravelPlanning.Configurations.Entities
{
    public class TransportationSeed : IEntityTypeConfiguration<Transportation>
    {
        public void Configure(EntityTypeBuilder<Transportation> builder)
        {
            builder.HasData(
       new Transportation
       {
           Id = 1,
           Type = "Boat",
           StartLocation="Tampines",
           EndLocation="Bugis",
           Cost = 150.50m,
           DateCreated = DateTime.Now,
           DataUpdated = DateTime.Now,
           CreatedBy = "System",
           UpdatedBy = "System"
       },
       new Transportation
       {
           Id = 2,
           Type = "AirPlane",
           StartLocation = "Kuala Lumpur",
           EndLocation = "Juhor",
           Cost = 60.50m,
           DateCreated = DateTime.Now,
           DataUpdated = DateTime.Now,
           CreatedBy = "System",
           UpdatedBy = "System"
       }
  );
        }
    }
}
