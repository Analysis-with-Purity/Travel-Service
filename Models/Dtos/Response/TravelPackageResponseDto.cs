namespace Travel_Service.Models.Dtos.Response;

public class TravelPackageResponseDto
{
    public Guid PackageId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public HotelResponseDto Hotel { get; set; }
    public FlightResponseDto Flight { get; set; }
}