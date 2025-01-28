namespace TravelPlanning.Domain
{
    public class Lodging: BaseDomainModel
    {

        public int TripId { get; set; } // Foreign Key referencing Trip.TripId
        
        public string? HotelName { get; set; }

        public string? Address { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }


        //Navigation Property
        public Trip? Trip { get; set; }



    }
}
