namespace TravelPlanning.Domain
{
    public class ItineraryPlan: BaseDomainModel
    {

        public String? Activities { get; set; }

        public decimal?  Budget { get; set; }

        public int UserId { get; set; }

        public int DestinationId { get; set; }



    }
}
