using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Entity
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public List<Room> Rooms { get; set; } = new();

    }
}
