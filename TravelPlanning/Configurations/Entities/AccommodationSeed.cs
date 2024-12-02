using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelPlanning.Domain;

namespace TravelPlanning.Configurations.Entities
{
    public class AccommodationSeed : IEntityTypeConfiguration<Accommmodation>
    {
        public void Configure(EntityTypeBuilder<Accommmodation> builder)
        {
            builder.HasData(
       new Accommmodation
       {
           Id = 1,
           Name = "Park View Hotel",
           Type = "Hotel",
           StartDate = new DateTime(2024, 12, 1),
           EndDate = new DateTime(2024, 12, 5),
           PricePerNight = 80.50m,
           DateCreated = DateTime.Now,
           DataUpdated = DateTime.Now,
           CreatedBy = "System",
           UpdatedBy = "System"
       },
       new Accommmodation
       {
           Id = 2,
           Name = "KSL Hotel & Resort",
           Type = "Motel",
           StartDate = new DateTime(2024, 12, 8),
           EndDate = new DateTime(2024, 12, 14),
           PricePerNight = 80.50m,
           DateCreated = DateTime.Now,
           DataUpdated = DateTime.Now,
           CreatedBy = "System",
           UpdatedBy = "System"
       }
  );
        }
    }
}
