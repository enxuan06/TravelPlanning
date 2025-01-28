namespace TravelPlanning.Domain
{
    public class Activity : BaseDomainModel
    {

        public int TripId { get; set; } // Foreign Key referencing Trip.TripId
        public String? ActivityName { get; set; }

        public string? Description { get; set; }

        public string? Address { get; set; }

        //Navigation Property
        public Trip? Trip { get; set; }
    }
}
