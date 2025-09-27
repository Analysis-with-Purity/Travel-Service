using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Entity
{
    public class Room
    {
        [Key]
        public Guid RoomId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string RoomType { get; set; }
        public string Price {  get; set; }


    }
}
