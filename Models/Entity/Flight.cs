using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Entity
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string Airline { get; set; }
        // public DateTime DepatureTime { get; set;}
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        // public DateTime ArrivalTime { get; set;}
        public string Amount { get; set; }
        public FlightClass Class { get; set; }

    }
}
