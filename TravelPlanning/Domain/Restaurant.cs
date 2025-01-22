using System.Data;

namespace TravelPlanning.Domain
{
    public class Restaurant : BaseDomainModel
    {

        public int TripId { get; set; } // Foreign Key referencing Trip.TripId
        public String? ResturantName { get; set; }

        public String? Address { get; set; }

        public DateTime DateVisited { get; set; }

        //Navigation Property
        public Trip Trip { get; set; }
    }
}
