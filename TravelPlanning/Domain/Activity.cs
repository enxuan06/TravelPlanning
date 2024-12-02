namespace TravelPlanning.Domain
{
    public class Activity : BaseDomainModel
    {

        public String? Name { get; set; }

        public String? Location { get; set; }

        public String? Type { get; set; }

        public int?  Duration { get; set; }

        
    }
}
