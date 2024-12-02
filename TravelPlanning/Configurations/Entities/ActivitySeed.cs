using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelPlanning.Domain;

namespace TravelPlanning.Configurations.Entities
{
    public class ActivitySeed : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
      new Activity
      {
          Id = 1,
          Name = "Visit Sultan Mosque",
          Type = "Religious and Cultural Landmark",
          Duration = 1,
          Location = "Bugis",
          DateCreated = DateTime.Now,
          DataUpdated = DateTime.Now,
          CreatedBy = "System",
          UpdatedBy = "System"
      },
      new Activity
      {
          Id = 2,
          Name = "LEGOLAND Malaysia",
          Type = "Theme Park",
          Location = "Juhor",
          Duration = 2,
          DateCreated = DateTime.Now,
          DataUpdated = DateTime.Now,
          CreatedBy = "System",
          UpdatedBy = "System"
      }
 );
        }
    }
}
