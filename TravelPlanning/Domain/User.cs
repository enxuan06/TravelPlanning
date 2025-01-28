using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using TravelPlanning.Data;

namespace TravelPlanning.Domain
{
    public class User
    {
        public int Id { get; set; }

       
       public string? IdentityUserId { get; set; }

        public TravelPlanningUser? IdentityUser { get; set; }
        public string? UserName { get; set; }
        public string? DomainUsername { get; set; }

        public DateTime DateCreated { get; set; }
        public ICollection<Trip>? Trips { get; set; }= new List<Trip>();
        
    }
}
