namespace TravelPlanning.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserName { get; set; }

        public List<ItineraryPlan>? TravelPlan { get; set; }

        public string? EmailAddress { get; set; }



    }
}
