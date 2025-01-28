using Microsoft.AspNetCore.Identity;
using TravelPlanning.Data;

namespace TravelPlanning.Domain
{
    public class Trip: BaseDomainModel
    {

        public string? TripName { get; set; }

        public string? Country { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UserId { get; set; } //foreign key of the identity (TranelPlanningUser) table

        public  User? User { get; set; }

        // Navigation properties
        public  ICollection<Activity> Activities { get; set; }= new List<Activity>();
        public  ICollection<Flight> Flights { get; set; } = new List<Flight>();
        public ICollection<Lodging> Lodgings { get; set; } = new List<Lodging>();
        public  ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();


    }
}
