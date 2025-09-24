namespace Travel_Service.Models.Entity
{
    public class Rooms
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public Hotels Hotel { get; set; }
        public string RoomType { get; set; }
        public string Price {  get; set; }


    }
}
