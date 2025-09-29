using Travel_Service.Models.Entity;

namespace Travel_Service.Models.Dtos.Response;

public class BookingResponseDto
{
    public int BookingId { get; set; }

    public int CustomerId {  get; set; }
    public User User { get; set; }

    public int PackageId { get; set; }
    public TravelPackages TravelPackage { get; set; }

    public int FlightId { get; set; }
    public Flight Flight {  get; set; }

    public int RoomId {  get; set; }
    public Room Room { get; set; }

    public DateTime DateCreated { get; set; }
    public string Status { get; set; }

    
}