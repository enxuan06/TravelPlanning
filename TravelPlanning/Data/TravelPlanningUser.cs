using Microsoft.AspNetCore.Identity;
using TravelPlanning.Domain;

namespace TravelPlanning.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class TravelPlanningUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

      
    }
}
 