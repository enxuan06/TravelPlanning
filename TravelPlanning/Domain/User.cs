using System.Collections;
using TravelPlanning.Data;

namespace TravelPlanning.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Trip>? Trips { get; set; }= new List<Trip>();
        
    }
}
