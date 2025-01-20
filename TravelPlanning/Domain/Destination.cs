namespace TravelPlanning.Domain
{
    public class Destination: BaseDomainModel
    {
        public String? Name { get; set; }

        public String? Country { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } 

        public int ActivityId { get; set; }
        public Activity? Activity { get; set; }

        public int TransportId { get; set; }
        public Transportation? Transportation { get; set; }

        public int AccomId  { get; set; }
        public Accommmodation? Accommmodation { get; set; }

        


    }
}
