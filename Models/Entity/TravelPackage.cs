using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Entity
{
    public class TravelPackage
    {
        [Key]
        public int PackageId { get; set; }
        public string? PackageClass { get; set; }
        public string Amount { get; set; }
        public List<Flight> Flights { get; set; } = new();
        public string? Destination { get; set; }
        public int? NoOfDays { get; set; }

    }
}
