namespace TravelPlanning.Domain
{
    public class Transportation : BaseDomainModel
    {
        public string? Type { get; set; }

        public string? StartLocation { get; set; }
        
        public string? EndLocation { get; set; }

        public decimal? Cost { get; set; }


    }
}
