using System.Data;

namespace TravelPlanning.Domain
{
    public class Flight : BaseDomainModel
    {

        public  int TripId { get; set; } // Foreign Key referencing Trip.TripId
        public string? AirlineName{ get; set; }

        public DateTime DepartureDate { get; set; }

        //Navigation Property
        public Trip? Trip { get; set; }

    }
}
