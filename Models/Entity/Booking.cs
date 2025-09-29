using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Travel_Service.Models.Entity
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int CustomerId {  get; set; }
        public User User { get; set; }

        public int PackageId { get; set; }
        public TravelPackage TravelPackage { get; set; }


        public int FlightId { get; set; }
        public Flight Flight {  get; set; }

        public int RoomId {  get; set; }
        public Room Room { get; set; }

        public DateTime DateCreated { get; set; }
        public string Status { get; set; }

    }
    
}
