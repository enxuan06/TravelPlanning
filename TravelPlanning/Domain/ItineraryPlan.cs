namespace TravelPlanning.Domain
{
    public class ItineraryPlan: BaseDomainModel
    {

        public String? Activities { get; set; }

        public decimal?  Budget { get; set; }

        public int UserId { get; set; } //foreign key

        public User? User { get; set; }//NAV PROP

        public int DestinationId { get; set; } //foreign key

        public Destination? Destination { get; set; }//NAV PROP



    }
}
