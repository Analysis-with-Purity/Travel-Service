namespace Travel_Service.Models.Entity
{
    public class Bookings
    {
        public int BookingId { get; set; }

        public int CustomerId {  get; set; }
        public Customers Customer { get; set; }

        public int PackageId { get; set; }
        public TravelPackages TravelPackage { get; set; }

        public int FlightId { get; set; }
        public Flights Flight {  get; set; }

        public int RoomId {  get; set; }
        public Rooms Room { get; set; }

        public DateTime DateCreated { get; set; }
        public string Status { get; set; }

    }
    
}
