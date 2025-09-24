namespace Travel_Service.Models.Entity
{
    public class Hotels
    {
        public Guid HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public int NoOfAvailableRooms { get; set; }
        public Rooms Rooms { get; set; }

    }
}
