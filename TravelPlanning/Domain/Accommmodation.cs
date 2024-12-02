using System.Data;

namespace TravelPlanning.Domain
{
    public class Accommmodation : BaseDomainModel
    {
        public String? Name { get; set; }

        public String? Address { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set;}

        public String? Type { get; set; }

        public decimal? PricePerNight { get; set; }


    }
}
